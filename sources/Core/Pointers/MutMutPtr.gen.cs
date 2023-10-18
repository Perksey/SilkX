// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ============================================= THIS FILE IS AUTOGENERATED ============================================
// =============================== Please make any edits in eng/pointergen/Generator.cs! ===============================
// ============================================= THIS FILE IS AUTOGENERATED ============================================

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// A pointer wrapper class
/// </summary>
public unsafe readonly ref struct MutMutPtr 
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public MutMutPtr(ref readonly MutPtr @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutMutPtr)),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="InteriorRef">The underlying ref.</param>
    public MutMutPtr(ref readonly byte @InteriorRef)
    {
        this.InteriorRef = ref @InteriorRef; 
    }

    /// <summary>
    /// The underlying reference
    /// </summary>
    public readonly ref readonly MutPtr Ref
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        get
        {
            // Would use the delegate* trick but this isn't optimised in JIT yet or necessarily safe
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
            FieldRef.Field(
                    TypeRef.Type(typeof(MutMutPtr)),
                                    nameof(InteriorRef)
                                )
                            );
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// The underlying generic reference
    /// </summary>
    public readonly ref readonly byte GetInteriorRef() => ref InteriorRef;

    private readonly ref readonly byte InteriorRef;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref readonly MutPtr this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(MutMutPtr)),
                    nameof(InteriorRef)
                )
            );
            IL.Emit.Ldarg_1();
            IL.Emit.Sizeof<nuint>();
            IL.Emit.Mul();
            IL.Emit.Add();
            IL.Emit.Ret();
            throw IL.Unreachable();
        }
    }

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="MutMutPtr"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref readonly byte** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutMutPtr)),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="MutMutPtr"/> equals another object
    /// Always returns false as ref structs cannot be passed in, so it will never be true
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Whether this object is the same as </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals([NotNullWhen(true)] object? obj) => false;

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => InteriorRef.GetHashCode();

    /// <summary>
    /// Determines if two <see cref="MutMutPtr"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutMutPtr lh, MutMutPtr rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="MutMutPtr"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutMutPtr lh, MutMutPtr rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator MutMutPtr(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="MutMutPtr"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutMutPtr"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutMutPtr lh, NullPtr rh) => lh == (MutMutPtr)rh;

    /// <summary>
    /// Determines whether a <see cref="MutMutPtr"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutMutPtr"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutMutPtr lh, NullPtr rh) => lh != (MutMutPtr)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutMutPtr"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutMutPtr"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, MutMutPtr rh) => (MutMutPtr)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutMutPtr"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutMutPtr"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, MutMutPtr rh) => (MutMutPtr)lh != rh;

    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void pointer from a <see cref="MutMutPtr"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(MutMutPtr ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(byte*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a pointer from a <see cref="MutMutPtr"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator byte***(MutMutPtr ptr) => (byte***)Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));
    
    /// <summary>
    /// creates a <see cref="MutMutPtr"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(byte[][][] array)
        => SilkMarshal.JaggedArrayToPointerArray<byte>(array);

    /// <summary>
    /// creates a <see cref="MutMutPtr"/> from a pointer array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator MutMutPtr(byte**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(byte).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(MutMutPtr)),
                TypeRef.Type(typeof(MutPtr)).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(Span<string[]> span)
    {
        return new MutMutPtr(ref SilkMarshal.StringArrayToNative(span, sizeof(byte)));
    }


    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(ReadOnlySpan<string[]> span)
    {
        return new MutMutPtr(ref SilkMarshal.StringArrayToNative(span, sizeof(byte)));
    }

    /// <summary>
    /// Creates a <see cref="MutMutPtr"/> from a string array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutMutPtr(string[][] array)
    {
        return new MutMutPtr(ref SilkMarshal.StringArrayToNative(array, sizeof(byte)));
    }
}