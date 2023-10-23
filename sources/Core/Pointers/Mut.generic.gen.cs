// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ============================================= THIS FILE IS AUTOGENERATED ============================================
// =============================== Please make any edits in eng/pointergen/Generator.cs! ===============================
// ============================================= THIS FILE IS AUTOGENERATED ============================================

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A single dimension pointer wrapper
/// </summary>
public readonly ref struct Mut<T>
	where T : unmanaged
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public Mut(ref T @Ref)
    {
        this.Ref = ref @Ref;
    }

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref T Ref;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref T this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get => ref Unsafe.Add(ref Ref, index);
    }

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="Mut{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T GetPinnableReference() => ref Ref;

    /// <summary>
    /// Creates a span with the given length from this pointer.
    /// </summary>
    /// <param name="length">the span length</param>
    /// <returns>the span</returns>
    public Span<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref Ref, length);

    /// <summary>
    /// Determines if this <see cref="Mut{T}"/> equals another object
    /// Always returns false as ref structs cannot be passed in, meaning this will never be true
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Whether this object is the same as </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals([NotNullWhen(true)] object? obj) => false;

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => Ref.GetHashCode();

    /// <summary>
    /// Determines if two <see cref="Mut{T}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator ==(Mut<T> lh, Mut<T> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="Mut{T}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator !=(Mut<T> lh, Mut<T> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="Mut{T}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Mut<T>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="Mut{T}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Mut{T}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Mut<T> lh, NullPtr rh) => lh == (Mut<T>)rh;

    /// <summary>
    /// Determines whether a <see cref="Mut{T}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Mut{T}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Mut<T> lh, NullPtr rh) => lh != (Mut<T>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Mut{T}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Mut{T}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, Mut<T> rh) => (Mut<T>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Mut{T}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Mut{T}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, Mut<T> rh) => (Mut<T>)lh != rh;

    /// <summary>
    /// Creates a <see cref="Mut{T}"/> from a span
    /// </summary>
    /// <param name="span"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Mut<T>(Span<T> span) => new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="Mut{T}"/> from a byte pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Mut<T>(T* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a <see cref="Mut{T}"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Mut<T>(void* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a byte pointer from a <see cref="Mut{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator T*(Mut<T> ptr) => (T*)Unsafe.AsPointer(ref ptr.Ref);

    /// <summary>
    /// Creates a void pointer from a <see cref="Mut{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator void*(Mut<T> ptr) => Unsafe.AsPointer(ref ptr.Ref);

    /// <summary>
    /// creates a <see cref="Mut{T}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Mut<T>(T[] array) => array.AsSpan();

    /// <summary>
    /// creates a <see cref="Mut{T}"/> from a 2D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Mut<T>(T[,] array) => MemoryMarshal.CreateSpan(ref array[0, 0], array.Length);

    /// <summary>
    /// creates a <see cref="Mut{T}"/> from a 3D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Mut<T>(T[,,] array) => MemoryMarshal.CreateSpan(ref array[0, 0, 0], array.Length);

    /// <summary>
    /// Creates a string from a <see cref="Mut{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator string(Mut<T> ptr)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
        {
            fixed (void* raw = ptr)
            {
                return new string((char*)raw);
            }
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            fixed (void* raw = ptr)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
        {
            fixed (void* raw = ptr)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        throw new InvalidCastException();
    }

    /// <summary>
    /// Create a non-generic version of <see cref="Mut{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Mut(Mut<T> ptr) => new Mut<T>(ref ptr.Ref);
}