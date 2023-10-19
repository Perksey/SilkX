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
public unsafe readonly ref struct MutPtrPtr 
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public MutPtrPtr(ref MutPtr @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutPtrPtr)),
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
    internal MutPtrPtr(ref byte @InteriorRef)
    {
        this.InteriorRef = ref @InteriorRef; 
    }

    /// <summary>
    /// The underlying reference
    /// </summary>
    public readonly ref MutPtr Ref
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
                    TypeRef.Type(typeof(MutPtrPtr)),
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

    private readonly ref byte InteriorRef;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref MutPtr this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(MutPtrPtr)),
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
    /// This function allows a <see cref="MutPtrPtr"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref byte** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutPtrPtr)),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="MutPtrPtr"/> equals another object
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
    /// Determines if two <see cref="MutPtrPtr"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutPtrPtr lh, MutPtrPtr rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="MutPtrPtr"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutPtrPtr lh, MutPtrPtr rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="MutPtrPtr"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator MutPtrPtr(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="MutPtrPtr"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutPtrPtr"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutPtrPtr lh, NullPtr rh) => lh == (MutPtrPtr)rh;

    /// <summary>
    /// Determines whether a <see cref="MutPtrPtr"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutPtrPtr"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutPtrPtr lh, NullPtr rh) => lh != (MutPtrPtr)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutPtrPtr"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutPtrPtr"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, MutPtrPtr rh) => (MutPtrPtr)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutPtrPtr"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutPtrPtr"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, MutPtrPtr rh) => (MutPtrPtr)lh != rh;

    /// <summary>
    /// Creates a <see cref="MutPtrPtr"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void pointer from a <see cref="MutPtrPtr"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(MutPtrPtr ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="MutPtrPtr"/> from a pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr(byte*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a pointer from a <see cref="MutPtrPtr"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator byte***(MutPtrPtr ptr) => (byte***)Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));
    
    /// <summary>
    /// creates a <see cref="MutPtrPtr"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr(byte[][][] array)
        => SilkMarshal.JaggedArrayToPointerArray<byte>(array);

    /// <summary>
    /// creates a <see cref="MutPtrPtr"/> from a pointer array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator MutPtrPtr(byte**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(byte).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(MutPtrPtr)),
                TypeRef.Type(typeof(MutPtr)).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }
}