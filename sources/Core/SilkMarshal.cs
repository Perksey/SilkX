using System.Buffers;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// Contains marshalling utilities.
/// </summary>
public static unsafe class SilkMarshal
{
    private record GCHandleSentinel(GCHandle Handle)
    {
        public DependentHandle? DependentHandle { get; set; }

        ~GCHandleSentinel()
        {
            DependentHandle?.Dispose();
            Handle.Free();
        }
    }

    /// <summary>
    /// Converts a string into its native representation such that the returned ref can be passed to native.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="charSize">Character size. Must be 1, 2, or 4.</param>
    /// <returns>A reference to the converted bytes.</returns>
    /// <exception cref="ArgumentException">
    /// Either:
    /// <list type="bullet">
    /// <item><description>The character size was not 1, 2 or 4.</description></item>
    /// <item><description><see cref="Utf8.FromUtf16"/> failed.</description></item>
    /// </list>
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly byte StringToNative(ReadOnlySpan<char> str, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in str.GetPinnableReference())))
        {
            return ref Unsafe.NullRef<byte>();
        }

        switch (charSize)
        {
            case 2:
            {
                return ref Unsafe.As<char, byte>(ref Unsafe.AsRef(in str.GetPinnableReference()));
            }
            default:
            {
                return ref StringToArray(str, charSize)![0];
            }
        }
    }

    /// <summary>
    /// Converts a string into its native representation such that the returned array can be passed to native.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="charSize">Character size. Must be 1, 2, or 4.</param>
    /// <returns>The converted bytes.</returns>
    /// <exception cref="ArgumentException">
    /// Either:
    /// <list type="bullet">
    /// <item><description>The character size was not 1, 2 or 4.</description></item>
    /// <item><description><see cref="Utf8.FromUtf16"/> failed.</description></item>
    /// </list>
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[]? StringToArray(ReadOnlySpan<char> str, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in str.GetPinnableReference())))
        {
            return null;
        }

        switch (charSize)
        {
            case 1:
            {
                var maxCharCount = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
                byte[]? arr = null;
                try
                {
                    var utf8 =
                        maxCharCount > 256
                            ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                            : stackalloc byte[maxCharCount];
                    if (
                        Utf8.FromUtf16(str, utf8, out _, out var bytesWritten)
                        != OperationStatus.Done
                    )
                    {
                        throw new ArgumentException("Failed to convert to UTF8", nameof(str));
                    }

                    utf8 = utf8[..(bytesWritten + 1)];
                    utf8[bytesWritten] = 0;
                    var ret = new byte[utf8.Length];
                    utf8.CopyTo(ret);

                    return ret;
                }
                finally
                {
                    if (arr is not null)
                    {
                        ArrayPool<byte>.Shared.Return(arr);
                    }
                }
            }
            case 2:
            {
                var utf16 = new byte[(str.Length + 1) * 2];
                MemoryMarshal
                    .CreateReadOnlySpan(ref Unsafe.AsRef(in str[0]), str.Length + 1)
                    .CopyTo(MemoryMarshal.Cast<byte, char>(utf16));
                return utf16;
            }
            case 4:
            {
                var maxCharCount = Encoding.UTF32.GetMaxByteCount(str.Length) + 4;
                byte[]? arr = null;
                try
                {
                    var utf32 =
                        maxCharCount > 256
                            ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                            : stackalloc byte[maxCharCount];
                    var bytesWritten = Encoding.UTF32.GetBytes(str, utf32);
                    utf32 = utf32[..(bytesWritten + 4)];
                    Unsafe.As<byte, int>(ref utf32[bytesWritten]) = 0;
                    var ret = new byte[utf32.Length];
                    utf32.CopyTo(ret);

                    return ret;
                }
                finally
                {
                    if (arr is not null)
                    {
                        ArrayPool<byte>.Shared.Return(arr);
                    }
                }
            }
            default:
            {
                throw new ArgumentException(
                    "Invalid char size, must be 1, 2, or 4",
                    nameof(charSize)
                );
            }
        }
    }

    /// <summary>
    /// Creates an array containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static nint[]? StringArrayToArray(ReadOnlySpan<string> strs, nint charSize = 1)
    {
        var ret = new nint[strs.Length];
        for (var i = 0; i < strs.Length; i++)
        {
            var native = StringToArray(strs[i], charSize);
            var handle = GCHandle.Alloc(native, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates an array containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static byte[]? StringArrayToArray(ReadOnlySpan<string[]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret);
        for (var i = 0; i < strs.Length; i++)
        {
            var native = StringArrayToArray(strs[i], charSize);
            var handle = GCHandle.Alloc(native, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            span[i] = handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates an array containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static byte[]? StringArrayToArray(ReadOnlySpan<string[][]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret);
        for (var i = 0; i < strs.Length; i++)
        {
            var native = StringArrayToArray(strs[i], charSize);
            var handle = GCHandle.Alloc(native, GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            span[i] = handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static ref byte StringArrayToNative(ReadOnlySpan<string> strs, nint charSize = 1)
    {
        var ret = StringArrayToArray(strs, charSize);
        if (ret is null)
        {
            return ref Unsafe.NullRef<byte>();
        }

        return ref MemoryMarshal.Cast<nint, byte>(ret)[0];
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string 2d jagged array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static ref byte StringArrayToNative(ReadOnlySpan<string[]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret);
        for (var i = 0; i < strs.Length; i++)
        {
            ref var native = ref StringArrayToNative(strs[i], charSize);
            span[i] = (nint)Unsafe.AsPointer(ref native);
        }

        return ref ret[0];
    }

    /// <summary>
    /// Creates a reference to memory containing the native representation of the given string 3d jagged array.
    /// </summary>
    /// <param name="strs">The strings.</param>
    /// <param name="charSize">The character size of the marshalled strings.</param>
    /// <returns>The reference.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    public static ref byte StringArrayToNative(ReadOnlySpan<string[][]> strs, nint charSize = 1)
    {
        var ret = new byte[strs.Length * sizeof(nint)];
        var span = MemoryMarshal.Cast<byte, nint>(ret);
        for (var i = 0; i < strs.Length; i++)
        {
            ref var native = ref StringArrayToNative(strs[i], charSize);
            span[i] = (nint)Unsafe.AsPointer(ref native);
        }

        return ref ret[0];
    }

    /// <summary>
    /// Creates an array of pointers from an array of arrays.
    /// </summary>
    /// <param name="array">The span/array.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The created array.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T*[] JaggedArrayToPointerArray<T>(ReadOnlySpan<T[]> array)
        where T : unmanaged
    {
        var ret = new T*[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var handle = GCHandle.Alloc(array[i], GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = (T*)handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Creates an array of pointers from an array of arrays.
    /// </summary>
    /// <param name="array">The span/array.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The created array.</returns>
    /// <exception cref="InvalidOperationException">A GC exception occurred.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T**[] JaggedArrayToPointerArray<T>(ReadOnlySpan<T[][]> array)
        where T : unmanaged
    {
        var ret = new T**[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var handle = GCHandle.Alloc(array[i], GCHandleType.Pinned);
            var sentinel = new GCHandleSentinel(handle);
            var dep = new DependentHandle(ret, sentinel);
            if (!dep.IsAllocated)
            {
                throw new InvalidOperationException(
                    "Failed to allocate dependent handle to keep string alive"
                );
            }

            sentinel.DependentHandle = dep;
            ret[i] = (T**)handle.AddrOfPinnedObject();
        }

        return ret;
    }

    /// <summary>
    /// Converts a span of string pointers to a string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]? NativeToStringArray(ReadOnlySpan<nint> native, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in native.GetPinnableReference())))
        {
            return null;
        }
        var ret = new string?[native.Length];
        for (var i = 0; i < native.Length; i++)
        {
            ret[i] = NativeToString(ref *(byte*)native[i], charSize);
        }

        return ret;
    }

    /// <summary>
    /// Converts a span of string pointers to an array of string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <param name="lengths">length of the first-level arrays</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]?[]? NativeToStringArray(ReadOnlySpan<nint> native, int[] lengths, nint charSize = 1)
    {
        if (native == null || native.Length != lengths.Length)
        {
            return null;
        }

        string?[]?[]? strings = new string[native.Length][];
        for (int i = 0; i < native.Length; i++)
        {
            strings[i] = NativeToStringArray(MemoryMarshal.CreateReadOnlySpan(
                ref Unsafe.As<byte, nint>(ref Unsafe.AsRef<byte>((byte*)native[i])),
                lengths[i]
            ), charSize);
        }

        return strings;
    }

    /// <summary>
    /// Converts a span of string pointers to an array of string array.
    /// </summary>
    /// <param name="native">The pointer span.</param>
    /// <param name="charSize">The character size.</param>
    /// <param name="lengths0">length of the first-level arrays</param>
    /// <param name="lengths1">length of the second-level arrays</param>
    /// <returns>The read string array.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[]?[]?[]? NativeToStringArray(ReadOnlySpan<nint> native, int[] lengths0, int[] lengths1, nint charSize = 1)
    {
        if (native == null || native.Length != lengths0.Length)
        {
            return null;
        }

        string?[]?[]?[]? strings = new string[native.Length][][];
        for (int i = 0; i < native.Length; i++)
        {
            strings[i] = NativeToStringArray(MemoryMarshal.CreateReadOnlySpan(
                ref Unsafe.As<byte, nint>(ref Unsafe.AsRef<byte>((byte*)native[i])),
                lengths0[i]
            ), lengths1, charSize);
        }

        return strings;
    }

    /// <summary>
    /// Converts a byte reference to a string.
    /// </summary>
    /// <param name="native">A reference to the string's native representation.</param>
    /// <param name="charSize">The character size of the native representation.</param>
    /// <returns>The string.</returns>
    /// <exception cref="ArgumentException"><paramref name="native"/> must be 1, 2, or 4.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? NativeToString(ref byte native, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref native))
        {
            return null;
        }
        switch (charSize)
        {
            case 1:
            {
                fixed (byte* ptr = &native)
                {
                    return Encoding.UTF8.GetString(
                        MemoryMarshal.CreateReadOnlySpanFromNullTerminated(ptr)
                    );
                }
            }
            case 2:
            {
                fixed (void* ptr = &native)
                {
                    return new string((char*)ptr);
                }
            }
            case 4:
            {
                fixed (byte* ptr = &native)
                {
                    int words;
                    for (words = 0; ((uint*)ptr)[words] != 0; words++)
                    {
                        // do nothing
                    }

                    return Encoding.UTF32.GetString(ptr, words * 4);
                }
            }
            default:
            {
                throw new ArgumentException("Char size must be 1, 2, or 4", nameof(charSize));
            }
        }
    }

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRefToConst<T, T> AsPtrToConst<T>(ref this T @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a pointer from a span.
    /// </summary>
    /// <param name="ref">A span of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given span's elements.</returns>
    public static PtrRefToConst<T, T> AsPtrToConst<T>(this Span<T> @ref)
        where T : unmanaged => new(ref @ref.GetPinnableReference());

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="PtrToConst{T, T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRefToConst<PtrToConst<T, T>, T> AsPtrToConst2D<T>(ref this PtrToConst<T, T> @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="PtrToConst{T, T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRefToConst<PtrToConst<T, T>, T> AsPtrToConst2D<T>(ref this PtrRefToConst<T, T> @ref)
        where T : unmanaged => new(ref RefConversion<T, PtrToConst<T, T>>(ref @ref));

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="PtrToConst{T, T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRefToConst<PtrToConst<T, T>, T> AsPtrToConst2D<T>(ref this Span<T> @ref)
        where T : unmanaged => new(ref SpanRefConversion<T, PtrToConst<T, T>>(ref @ref));

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRef<T, T> AsPtr<T>(ref this T @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a pointer from a span.
    /// </summary>
    /// <param name="ref">A span of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given span's elements.</returns>
    public static PtrRef<T, T> AsPtr<T>(this Span<T> @ref)
        where T : unmanaged => new(ref @ref.GetPinnableReference());

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T, T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRef<Ptr<T, T>, T> AsPtr2D<T>(ref this Ptr<T, T> @ref)
        where T : unmanaged => new(ref @ref);

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T, T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRef<Ptr<T, T>, T> AsPtr2D<T>(ref this PtrRef<T, T> @ref)
        where T : unmanaged => new(ref RefConversion<T, Ptr<T, T>>(ref @ref));

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref">A reference to a <see cref="Ptr{T,T}"/>.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The pointer to the given reference.</returns>
    public static PtrRef<Ptr<T, T>, T> AsPtr2D<T>(ref this Span<T> @ref)
        where T : unmanaged => new(ref SpanRefConversion<T, Ptr<T,T>>(ref @ref));

    /// <summary>
    /// Unsafely creates a <see cref="Ptr{T, T}"/> from a <see cref="PtrToConst{T, T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The reinterpreted pointer.</returns>
    public static Ptr<T, T> ConstCast<T>(PtrToConst<T, T> ptr)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely creates a <see cref="Ptr{T, T}"/> from a <see cref="PtrToConst{T, T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The reinterpreted pointer.</returns>
    public static ref Ptr<T, T> ConstCast<T>(ref PtrToConst<T, T> ptr)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely creates a <see cref="Ptr{T, T}"/> from a <see cref="PtrToConst{T, T}"/>.
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The reinterpreted pointer.</returns>
    public static PtrRef<Ptr<T, T>, T> ConstCast<T>(PtrRefToConst<PtrToConst<T, T>, T> ptr)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Unsafely creates a <see cref="PtrRef{T, T}"/> from a <see cref="PtrRefToConst{T, T}"/>
    /// </summary>
    /// <param name="ptr">The pointer.</param>
    /// <typeparam name="T">The pointee type.</typeparam>
    /// <returns>The reinterpreted pointer.</returns>
    public static ref PtrRef<Ptr<T, T>, T> ConstCast<T>(ref PtrToConst<PtrToConst<T, T>, T> ptr)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ref To SpanRefConversion<From,To>(ref Span<From> @ref)
        where From : unmanaged
        where To : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ref To RefConversion<From, To>(ref From @ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ref readonly To RefRoConversion<From, To>(ref readonly From @ref)
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ref To RefConversion<T, To>(ref PtrRef<T, T> @ref)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static ref To RefConversion<T, To>(ref PtrRefToConst<T, T> @ref)
        where T : unmanaged
    {
        IL.Emit.Ldarg_0();
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

}
