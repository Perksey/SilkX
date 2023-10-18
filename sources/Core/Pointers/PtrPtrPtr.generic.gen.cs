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
public unsafe readonly ref struct PtrPtrPtr<T> 
	where T : unmanaged
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public PtrPtrPtr(ref readonly PtrPtr<T> @Ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldarg_1();
        IL.Emit.Stfld(
            FieldRef.Field(
                TypeRef.Type(typeof(PtrPtrPtr<>).MakeGenericType(typeof(T))),
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
    public PtrPtrPtr(ref readonly byte @InteriorRef)
    {
        this.InteriorRef = ref @InteriorRef; 
    }

    /// <summary>
    /// The underlying reference
    /// </summary>
    public readonly ref readonly PtrPtr<T> Ref
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
                    TypeRef.Type(typeof(PtrPtrPtr<>).MakeGenericType(typeof(T))),
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
    public ref readonly PtrPtr<T> this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(PtrPtrPtr<>).MakeGenericType(typeof(T))),
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
    /// This function allows a <see cref="PtrPtrPtr{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref readonly T** GetPinnableReference()
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldfld(
            FieldRef.Field(
                TypeRef.Type(typeof(PtrPtrPtr<>).MakeGenericType(typeof(T))),
                nameof(InteriorRef)
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Determines if this <see cref="PtrPtrPtr{T}"/> equals another object
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
    /// Determines if two <see cref="PtrPtrPtr{T}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(PtrPtrPtr<T> lh, PtrPtrPtr<T> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="PtrPtrPtr{T}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(PtrPtrPtr<T> lh, PtrPtrPtr<T> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator PtrPtrPtr<T>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="PtrPtrPtr{T}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="PtrPtrPtr{T}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(PtrPtrPtr<T> lh, NullPtr rh) => lh == (PtrPtrPtr<T>)rh;

    /// <summary>
    /// Determines whether a <see cref="PtrPtrPtr{T}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="PtrPtrPtr{T}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(PtrPtrPtr<T> lh, NullPtr rh) => lh != (PtrPtrPtr<T>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="PtrPtrPtr{T}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="PtrPtrPtr{T}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, PtrPtrPtr<T> rh) => (PtrPtrPtr<T>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="PtrPtrPtr{T}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="PtrPtrPtr{T}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, PtrPtrPtr<T> rh) => (PtrPtrPtr<T>)lh != rh;

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a void pointer from a <see cref="PtrPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator void*(PtrPtrPtr<T> ptr) => Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(T*** ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a pointer from a <see cref="PtrPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator T***(PtrPtrPtr<T> ptr) => (T***)Unsafe.AsPointer(ref Unsafe.AsRef(in ptr.InteriorRef));
    
    /// <summary>
    /// creates a <see cref="PtrPtrPtr{T}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(T[][][] array)
        => SilkMarshal.JaggedArrayToPointerArray<T>(array);

    /// <summary>
    /// creates a <see cref="PtrPtrPtr{T}"/> from a pointer array
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrPtrPtr<T>(T**[] array)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(PtrPtrPtr<>).MakeGenericType(typeof(T))),
                TypeRef.Type(typeof(PtrPtr<>).MakeGenericType(typeof(T))).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(Span<string[]> span)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new PtrPtrPtr<T>(ref SilkMarshal.StringArrayToNative(span, sizeof(T)));
    }

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a string span.
    /// </summary>
    /// <param name="span">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(ReadOnlySpan<string[]> span)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new PtrPtrPtr<T>(ref SilkMarshal.StringArrayToNative(span, sizeof(T)));
    }

    /// <summary>
    /// Creates a <see cref="PtrPtrPtr{T}"/> from a string array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrPtrPtr<T>(string[][] array)
    {
        if (
            typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new PtrPtrPtr<T>(ref SilkMarshal.StringArrayToNative(array, sizeof(T)));
    }

    /// <summary>
    /// Create a non-generic version of <see cref="PtrPtrPtr{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrPtrPtr(PtrPtrPtr<T> ptr) => new PtrPtrPtr(in ptr.InteriorRef);
}