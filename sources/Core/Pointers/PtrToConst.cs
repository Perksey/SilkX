using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A managed pointer to a const object
/// </summary>
/// <param name="ptr"></param>
/// <param name="handle"></param>
/// <param name="depth">the depth of the pointer types before a non-pointer type</param>

public unsafe struct PtrToConst(void* ptr, GCHandle? handle = null, int depth = 1) : IPointerToMutable, IDisposable
{
    /// <summary>
    /// Create a pinned pointer to a managed reference
    /// </summary>
    /// <param name="value">the managed reference</param>
    public PtrToConst(ref object value)
        : this(null)
    {
        Handle = GCHandle.Alloc(value, GCHandleType.Pinned);
        Pointer = Handle.Value.AddrOfPinnedObject().ToPointer();
    }

    /// <summary>
    /// Creates a pinned pointer to a managed handle
    /// </summary>
    /// <param name="handle"></param>
    /// <param name="depth">the depth of the pointer types before a non-pointer type</param>
    public PtrToConst(GCHandle handle, int depth = 1)
        : this(null)
    {
        Handle = handle;
        Pointer = (void*)handle.AddrOfPinnedObject().ToPointer();
        Depth = depth;
    }

    private readonly void* Pointer = ptr;
    private readonly GCHandle? Handle = handle;

    /// <inheritdoc/>
    public int Depth { init; get; } = depth;

    /// <summary>
    /// Get a copy of the held native pointer
    /// </summary>
    public readonly void* NativePointer => Pointer;

    /// <summary>
    /// Gets a Reference to the value held
    /// </summary>
    public readonly ref readonly byte Value => ref Unsafe.AsRef<byte>(Pointer);
    /// <summary>
    /// Gets a reference to the value held at the index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>the reference to the value held at the index</returns>
    public ref readonly byte this[int index] => ref Unsafe.AsRef<byte>((void*)(((nint)Pointer) + (index * Depth > 1 ? sizeof(nint) : sizeof(byte))));

    void* IPointer.Pointer => Pointer;

    /// <summary>
    /// Creates a <see cref="ReadOnlySpan{T}"/> from this pointer
    /// </summary>
    /// <param name="length"></param>
    /// <returns>the span</returns>
    public ReadOnlySpan<byte> AsSpan(int length) => new(Pointer, length);

    /// <summary>
    /// Convert to a generic pointer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="BaseType"></typeparam>
    /// <returns></returns>
    public PtrToConst<T, BaseType> AsGeneric<T, BaseType>()
        where T : unmanaged
        where BaseType : unmanaged
    {
        if (PtrToConst<T, BaseType>.Depth != Depth)
            throw new InvalidOperationException();
        return new PtrToConst<T, BaseType>((T*)Pointer, Handle);
    }

    /// <summary>
    /// Retrieve the value held by the pointer
    /// </summary>
    /// <param name="ptr">the pointer</param>
    public static implicit operator byte(PtrToConst ptr) => *(byte*)ptr.Pointer;

    /// <summary>
    /// Retrieve the void pointer of the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator void*(PtrToConst ptr) => ptr.Pointer;

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(void* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(byte* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator Ptr(PtrToConst ptr) => new(ptr.Pointer, ptr.Handle, ptr.Depth);

    /// <summary>
    /// Converts the pointer into a pointer to the BaseType
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator byte*(PtrToConst ptr)
    {
        if (ptr.Depth != 1)
            throw new InvalidCastException();
        return (byte*)ptr.Pointer;
    }

    /// <summary>
    /// Converts the pointer into a double pointer to the BaseType
    /// Only valid for depth 1 or 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator byte**(PtrToConst ptr)
    {
        switch (ptr.Depth)
        {
            case 1:
                return (byte**)&ptr.Pointer;
            case 2:
                return (byte**)ptr.Pointer;
            default:
                throw new InvalidCastException();
        }
    }

    /// <summary>
    /// Converts the pointer into a triple pointer to the BaseType
    /// Only valid for depth 2 or 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator byte***(PtrToConst ptr)
    {
        switch (ptr.Depth)
        {
            case 2:
                return (byte***)&ptr.Pointer;
            case 3:
                return (byte***)ptr.Pointer;
            default:
                throw new InvalidCastException();
        }
    }

    /// <summary>
    /// Creates a <see cref="Ptr"/> from a BaseType array
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte[] array) => new(GCHandle.Alloc(array, GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr"/> from a jagged 2D BaseType array
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte[][] array) => SilkMarshal.JaggedArrayToPointerArray<byte>(array);

    /// <summary>
    /// Creates a <see cref="Ptr"/> from a jagged 2D BaseType array
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte[][][] array) => SilkMarshal.JaggedArrayToPointerArray<byte>(array);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a BaseType span
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(Span<byte> span)
    {
        return new(*(byte**)SilkMarshal.SpanRefToPtr<byte>(ref span), GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a jagged 2D BaseType span
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(Span<byte[]> span) => new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned), 2);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a jagged 2D BaseType span
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(Span<byte[][]> span) => new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned), 3);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a BaseType span
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(ReadOnlySpan<byte> span)
    {
        return new(*(byte**)SilkMarshal.SpanRefToPtr<byte>(ref span), GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a jagged 2D BaseType span
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(ReadOnlySpan<byte[]> span) => new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned), 2);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a jagged 3D BaseType span
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(ReadOnlySpan<byte[][]> span) => new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned), 3);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a nullptr
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(NullPtr ptr) => new(null);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a string
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="str"></param>
    public static implicit operator PtrToConst(string str)
    {
        object? obj = SilkMarshal.StringToArray(str, sizeof(byte));

        return new(GCHandle.Alloc(obj, GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a span of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(Span<string> span)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(byte)), GCHandleType.Pinned), 2);
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a span of string arrays
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(Span<string[]> span)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(byte)), GCHandleType.Pinned), 3);
    }

    /// <summary>
    /// Creates a string from a <see cref="PtrToConst"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator string(PtrToConst ptr)
    {
        if (ptr.Depth != 1)
            throw new InvalidCastException();

        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)ptr.Pointer)
            );
    }

    /// <summary>
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte*[] array) => new PtrToConst(GCHandle.Alloc(array, GCHandleType.Pinned), 2);

    /// <summary>
    /// Create a managed pointer from a BaseType double pointer
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(byte** ptr) => new PtrToConst(ptr, null, 2);

    /// <summary>
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte*[][] array) => new PtrToConst(GCHandle.Alloc(array, GCHandleType.Pinned), 3);

    /// <summary>
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrToConst(byte**[] array) => new PtrToConst(GCHandle.Alloc(array, GCHandleType.Pinned), 3);

    /// <summary>
    /// Create a managed pointer from a BaseType triple pointer
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(byte*** ptr) => new PtrToConst(ptr, null, 3);

    /// <summary>
    /// Create a managed pointer from an array of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strings"></param>
    public static implicit operator PtrToConst(string[] strings)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(strings, sizeof(byte)), GCHandleType.Pinned), 2);
    }

    /// <summary>
    /// Create a managed pointer from a jagged 2d array of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strings"></param>
    public static implicit operator PtrToConst(string[][] strings)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(strings, sizeof(byte)), GCHandleType.Pinned), 2);
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a span of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(ReadOnlySpan<string> span)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(byte)), GCHandleType.Pinned), 2);
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from a span of string arrays
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator PtrToConst(ReadOnlySpan<string[]> span)
    {
        return new PtrToConst(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(byte)), GCHandleType.Pinned), 3);
    }

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, Ptr rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, PtrToConst rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, PtrToConst rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, Ptr rh) => lh.Pointer != ((IPointer)rh).Pointer;


    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, PtrToConst rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, PtrToConst rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, NullPtr rh) => lh.Pointer == null;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, NullPtr rh) => lh.Pointer != null;

    /// <inheritdoc/>
    public override bool Equals([NotNullWhen(true)] object? obj) => Value.Equals(obj);

    /// <inheritdoc/>
    public override int GetHashCode() => base.GetHashCode();

    /// <summary>
    /// Frees pinned handle
    /// </summary>
    public void Dispose()
    {
        if (Handle is not null)
        {
            Handle.Value.Free();
        }
    }
}
