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
public unsafe readonly ref struct MutPtrPtr<T> 
	where T : unmanaged
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public MutPtrPtr(ref MutPtr<T> @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutPtrPtr<>).MakeGenericType(typeof(T))),
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
    public readonly ref MutPtr<T> Ref
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
                    TypeRef.Type(typeof(MutPtrPtr<>).MakeGenericType(typeof(T))),
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
    public ref MutPtr<T> this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(MutPtrPtr<>).MakeGenericType(typeof(T))),
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
    /// This function allows a <see cref="MutPtrPtr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(MutPtrPtr<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="MutPtrPtr{T}"/> equals another object
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
    /// Determines if two <see cref="MutPtrPtr{T}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutPtrPtr<T> lh, MutPtrPtr<T> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="MutPtrPtr{T}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutPtrPtr<T> lh, MutPtrPtr<T> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="MutPtrPtr{T}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator MutPtrPtr<T>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="MutPtrPtr{T}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutPtrPtr{T}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(MutPtrPtr<T> lh, NullPtr rh) => lh == (MutPtrPtr<T>)rh;

    /// <summary>
    /// Determines whether a <see cref="MutPtrPtr{T}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="MutPtrPtr{T}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(MutPtrPtr<T> lh, NullPtr rh) => lh != (MutPtrPtr<T>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutPtrPtr{T}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutPtrPtr{T}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, MutPtrPtr<T> rh) => (MutPtrPtr<T>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="MutPtrPtr{T}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="MutPtrPtr{T}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, MutPtrPtr<T> rh) => (MutPtrPtr<T>)lh != rh;

    /// <summary>
    /// Creates a <see cref="MutPtrPtr{T}"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr<T>(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void pointer from a <see cref="MutPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(MutPtrPtr<T> ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="MutPtrPtr{T}"/> from a pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr<T>(T*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a pointer from a <see cref="MutPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T***(MutPtrPtr<T> ptr) => (T***)Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));
    
    /// <summary>
    /// creates a <see cref="MutPtrPtr{T}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MutPtrPtr<T>(T[][][] array)
        => SilkMarshal.JaggedArrayToPointerArray<T>(array);

    /// <summary>
    /// creates a <see cref="MutPtrPtr{T}"/> from a pointer array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator MutPtrPtr<T>(T**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(MutPtrPtr<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(MutPtr<>).MakeGenericType(typeof(T))).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Create a non-generic version of <see cref="MutPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator MutPtrPtr(MutPtrPtr<T> ptr) => new MutPtrPtr(ref ptr.InteriorRef);
}