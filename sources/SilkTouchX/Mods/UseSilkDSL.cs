using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SilkTouchX.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace SilkTouchX.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
public class UseSilkDSL : IMod
{
    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var rewriter = new Rewriter();
        foreach (var (fName, node) in syntax.Files)
        {
            if (fName.StartsWith("sources/"))
            {
                syntax.Files[fName] = rewriter.Visit(node);
            }
        }

        return Task.FromResult(syntax);
    }

    private class Rewriter() : CSharpSyntaxRewriter(true)
    {
        private HashSet<string>? _parameterIdentifiers;
        private bool _returnTypeReplaceable;
        private bool _wroteUsing;
        private bool _hasUsings;
        private bool _needsUsing;

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var ret = base.VisitClassDeclaration(node);
            return ret switch
            {
                // Make sure diffs aren't crazy
                ClassDeclarationSyntax syn
                    => syn.WithMembers(
                        List(
                            syn.Members.OrderBy(
                                x => (x as MethodDeclarationSyntax)?.Identifier.ToString()
                            )
                        )
                    ),
                _ => ret
            };
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            Debug.Assert(!_returnTypeReplaceable);
            Debug.Assert(_parameterIdentifiers is null);

            // Make sure the function either has a body or is an extern function
            var consider =
                node.Body is not null
                || node.Modifiers.Any(x => x.IsKind(SyntaxKind.ExternKeyword));
            if (!consider)
            {
                return base.VisitMethodDeclaration(node);
            }

            // Get the list of DSL applicable parameters
            var paramsToChange = node.ParameterList.Parameters
                .Where(x => x.Type is not null && IsDSLApplicable(x.Type))
                .ToArray();
            _parameterIdentifiers = paramsToChange.Select(x => x.Identifier.ToString()).ToHashSet();
            _returnTypeReplaceable = IsDSLApplicable(node.ReturnType);

            // VisitParameter and VisitIdentifierName will change the parameter types and replace any references of
            // the parameter with the "inner identifier" - the name of the variable yielded from the fixed statement
            // that we're yet to generate.
            if (
                base.VisitMethodDeclaration(node)
                is not MethodDeclarationSyntax methWithReplacementsButNoFixed
            )
            {
                _parameterIdentifiers = null;
                return null;
            }

            // If we didn't do any replacements and aren't doing anything to the return type, don't do anything
            _parameterIdentifiers = null;
            if (paramsToChange.Length == 0 && !_returnTypeReplaceable)
            {
                return methWithReplacementsButNoFixed;
            }

            // If body is null, it would only be because the original body was null which must've meant we passed the
            // "extern" check when determining whether to consider this function, ergo we need to make a P/Invoke
            // wrapper.
            var hasRet = node.ReturnType.ToString() != "void";
            var body = (StatementSyntax?)methWithReplacementsButNoFixed.Body;
            if (body is null)
            {
                var ident = IdentToPInvokeIdent(node.Identifier);
                // Declare the P/Invoke function
                var fun = LocalFunctionStatement(
                        // Add all the original attributes back, including the DllImport but make sure that if the original
                        // DllImport is ExactSpelling we add an EntryPoint instead (given that we're changing the function
                        // name)
                        List(
                            node.AttributeLists.Select(
                                x =>
                                    x.WithAttributes(
                                        SeparatedList(
                                            x.Attributes.Select(
                                                y =>
                                                    y.IsExactSpellingDllImport()
                                                        ? y.WithArgumentList(
                                                            AttributeArgumentList(
                                                                SeparatedList(
                                                                    y.ArgumentList?.Arguments.Select(
                                                                        z =>
                                                                            z.NameEquals?.Name.Identifier.ToString()
                                                                            == nameof(
                                                                                DllImportAttribute.ExactSpelling
                                                                            )
                                                                                ? AttributeArgument(
                                                                                    NameEquals(
                                                                                        IdentifierName(
                                                                                            nameof(
                                                                                                DllImportAttribute.EntryPoint
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                    null,
                                                                                    LiteralExpression(
                                                                                        SyntaxKind.StringLiteralExpression,
                                                                                        Literal(
                                                                                            node.Identifier.ToString()
                                                                                        )
                                                                                    )
                                                                                )
                                                                                : z
                                                                    )
                                                                )
                                                            )
                                                        )
                                                        : y
                                            )
                                        )
                                    )
                            )
                        ),
                        // Remove any accessibility modifiers - this is a local function
                        TokenList(
                            node.Modifiers.Where(
                                x =>
                                    x.Kind() switch
                                    {
                                        SyntaxKind.PublicKeyword
                                        or SyntaxKind.PrivateKeyword
                                        or SyntaxKind.InternalKeyword
                                        or SyntaxKind.ProtectedKeyword
                                            => false,
                                        _ => true
                                    }
                            )
                        ),
                        node.ReturnType,
                        ident,
                        null,
                        node.ParameterList,
                        List<TypeParameterConstraintClauseSyntax>(),
                        node.Body,
                        node.ExpressionBody
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

                // Call the P/Invoke function with the converted values
                var inv = InvocationExpression(
                    IdentifierName(ident),
                    ArgumentList(
                        SeparatedList(
                            node.ParameterList.Parameters.Select(
                                x =>
                                    Argument(
                                        IdentifierName(
                                            x.Type is not null && IsDSLApplicable(x.Type)
                                                ? IdentToInnerIdent(x.Identifier)
                                                : x.Identifier
                                        )
                                    )
                            )
                        )
                    )
                );
                body = Block(fun, hasRet ? ReturnStatement(inv) : ExpressionStatement(inv));

                // Remove the extern keyword from the outer method
                methWithReplacementsButNoFixed = methWithReplacementsButNoFixed
                    .WithModifiers(
                        TokenList(
                            methWithReplacementsButNoFixed.Modifiers.Where(
                                x => !x.IsKind(SyntaxKind.ExternKeyword)
                            )
                        )
                    )
                    .AddMaxOpt();
                _needsUsing = true;
            }

            // Convert expression bodies to statement bodies
            if (body is ExpressionStatementSyntax expr)
            {
                body = Block(
                    hasRet ? ExpressionStatement(expr.Expression) : ReturnStatement(expr.Expression)
                );
            }

            // Generate the fixed blocks for the "inner idents"
            Debug.Assert(body is BlockSyntax);
            foreach (var param in paramsToChange)
            {
                Debug.Assert(param.Type is not null);
                body = FixedStatement(
                    VariableDeclaration(
                        param.Type,
                        SingletonSeparatedList(
                            VariableDeclarator(IdentToInnerIdent(param.Identifier))
                                .WithInitializer(
                                    EqualsValueClause(IdentifierName(param.Identifier))
                                )
                        )
                    ),
                    body
                );
            }

            // The method body needs to be a block. Alternatively each FixedStatement could be wrapped in a Block, but
            // that would be a lot of nested fixeds.
            if (body is not BlockSyntax)
            {
                body = Block(body);
            }

            // Need to check on the return type, but assume that there's an implicit conversion in the DSL
            if (_returnTypeReplaceable)
            {
                _returnTypeReplaceable = false;
                methWithReplacementsButNoFixed = methWithReplacementsButNoFixed.WithReturnType(
                    GetDSLType(node.ReturnType, node.AttributeLists, SyntaxKind.ReturnKeyword)
                );
            }

            return methWithReplacementsButNoFixed
                .WithBody((BlockSyntax)body)
                .WithSemicolonToken(default);
        }

        public override SyntaxNode? VisitParameter(ParameterSyntax node)
        {
            var ret = base.VisitParameter(node) as ParameterSyntax;

            // In release builds don't do the _parameterIdentifiers lookup because we do this in the VisitIdentifierName
            if (
                (_parameterIdentifiers?.Contains(node.Identifier.ToString()) ?? false)
                && ret is { Type: not null }
            )
            {
                return ret.WithType(GetDSLType(ret.Type, node.AttributeLists, null));
            }

            return ret;
        }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        {
            var ret = base.VisitIdentifierName(node) as IdentifierNameSyntax;
            if (ret is null)
            {
                return ret;
            }

            if (!(_parameterIdentifiers?.Contains(node.Identifier.ToString()) ?? false))
            {
                return ret;
            }

            return IdentifierName(IdentToInnerIdent(ret.Identifier)).WithTriviaFrom(ret);
        }

        public override SyntaxNode? VisitAttribute(AttributeSyntax node)
        {
            if ((_parameterIdentifiers?.Count).GetValueOrDefault() == 0 && !_returnTypeReplaceable)
            {
                return base.VisitAttribute(node);
            }

            return node.IsDllImport()
                ? null // Remove the attribute as it is being moved to a local function
                : base.VisitAttribute(node);
        }

        public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)
        {
            var ret = base.VisitAttributeList(node) as AttributeListSyntax;
            if (ret is not null && ret.Attributes.Count == 0)
            {
                return null;
            }

            return ret;
        }

        private static SyntaxToken IdentToInnerIdent(SyntaxToken token)
        {
            Debug.Assert(token.IsKind(SyntaxKind.IdentifierToken));
            return Identifier($"__dsl_{token.ToString().TrimStart('@')}");
        }

        private static SyntaxToken IdentToPInvokeIdent(SyntaxToken token)
        {
            Debug.Assert(token.IsKind(SyntaxKind.IdentifierToken));
            return Identifier($"__DSL_{token}");
        }

        private static bool IsDSLApplicable(TypeSyntax syn) => syn is PointerTypeSyntax;

        private static TypeSyntax GetDSLType(
            TypeSyntax syntax,
            IEnumerable<AttributeListSyntax?>? attrLists,
            SyntaxKind? target
        )
        {
            var indirectionLevels = 0;
            var isVoid = false;
            while (syntax is PointerTypeSyntax inner)
            {
                indirectionLevels++;
                syntax = inner.ElementType;
            }

            if (syntax is PredefinedTypeSyntax lang && lang.Keyword.IsKind(SyntaxKind.VoidKeyword))
            {
                isVoid = true;
            }

            if (indirectionLevels > 2)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(syntax),
                    "Indirection levels greater than 2 are currently unsupported by SilkDSL."
                );
            }

            var isConst = false;
            if (attrLists is not null)
            {
                foreach (var attrs in attrLists)
                {
                    if (
                        attrs is null
                        || (
                            target is not null
                            && !(attrs.Target?.Identifier.IsKind(target.Value)).GetValueOrDefault()
                        )
                        || (target is null && attrs.Target is not null)
                    )
                    {
                        continue;
                    }

                    foreach (var attributeSyntax in attrs.Attributes)
                    {
                        if (
                            attributeSyntax.Name.ToString() == "NativeTypeName"
                            && attributeSyntax.ArgumentList?.Arguments.FirstOrDefault()?.Expression
                                is LiteralExpressionSyntax lit
                            && lit.Token.ValueText.StartsWith("const ")
                        )
                        {
                            isConst = true;
                        }
                    }
                }
            }

            return isVoid
                ? IdentifierName(
                    isConst switch
                    {
                        true => string.Join("", Enumerable.Repeat("Ptr", indirectionLevels)),
                        false => string.Join("", Enumerable.Repeat("Mut", indirectionLevels)),
                    }
                )
                : GenericName(
                        Identifier(
                            isConst switch
                            {
                                true => string.Join("", Enumerable.Repeat("Ptr", indirectionLevels)),
                                false => string.Join("", Enumerable.Repeat("Mut", indirectionLevels)),
                            }
                        )
                    )
                    .WithTypeArgumentList(TypeArgumentList(SingletonSeparatedList(syntax)));
        }

        public override SyntaxNode? VisitUsingStatement(UsingStatementSyntax node)
        {
            _hasUsings = true;
            return base.VisitUsingStatement(node);
        }

        public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
        {
            var ret = base.VisitCompilationUnit(node);
            if (!_wroteUsing && _needsUsing)
            {
                return ret switch
                {
                    CompilationUnitSyntax syn
                        => syn.AddUsings(
                            UsingDirective(
                                QualifiedName(
                                    QualifiedName(
                                        IdentifierName("System"),
                                        IdentifierName("Runtime")
                                    ),
                                    IdentifierName("CompilerServices")
                                )
                            )
                        ),
                    _ => ret
                };
            }

            _wroteUsing = false;
            return ret;
        }

        public override SyntaxNode? VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            var hadUsings = _hasUsings;
            var ret = base.VisitNamespaceDeclaration(node);
            if (!_hasUsings || hadUsings || !_needsUsing)
            {
                return ret;
            }

            // The masochistic code writer has decided to put usings within the namespace rather than at the
            // compilation unit level, so let's begrudgingly follow suit
            _wroteUsing = true;
            return ret switch
            {
                NamespaceDeclarationSyntax syn
                    => syn.AddUsings(
                        UsingDirective(
                            QualifiedName(
                                QualifiedName(IdentifierName("System"), IdentifierName("Runtime")),
                                IdentifierName("CompilerServices")
                            )
                        )
                    ),
                _ => ret
            };
        }
    }
}
