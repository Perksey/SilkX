using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A managed pointer to a mutable object
/// </summary>
/// <param name="ptr"></param>
/// <param name="depth">the depth of the pointer types before a non-pointer type</param>
public unsafe struct Ptr(void* ptr, int depth = 1) : IPointerToMutable
{
    private readonly void* Pointer = ptr;

    /// <inheritdoc/>
    public int Depth { init; get; } = depth;

    /// <summary>
    /// Get a copy of the held native pointer
    /// </summary>
    public void* NativePointer => Pointer;

    /// <summary>
    /// Gets a Reference to the value held
    /// </summary>
    public ref byte Value => ref Unsafe.AsRef<byte>(Pointer);
    /// <summary>
    /// Gets a reference to the value held at the index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>the reference to the value held at the index</returns>
    public ref byte this[int index] => ref Unsafe.AsRef<byte>((byte*)(((nint)Pointer) + (index * Depth > 1 ? sizeof(nint) : sizeof(byte))));

    void* IPointer.Pointer => Pointer;

    /// <summary>
    /// Creates a <see cref="Span{T}"/> from this pointer
    /// </summary>
    /// <param name="length"></param>
    /// <returns>the span</returns>
    public Span<byte> AsSpan(int length) => new(Pointer, length);

    /// <summary>
    /// Convert to a generic pointer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="BaseType"></typeparam>
    /// <returns></returns>
    public Ptr<T, BaseType> AsGeneric<T, BaseType>()
        where T : unmanaged
        where BaseType : unmanaged
    {
        if (Ptr<T, BaseType>.Depth != Depth)
            throw new InvalidOperationException();
        return new Ptr<T, BaseType>((T*)Pointer);
    }

    /// <summary>
    /// Retrieve the value held by the pointer
    /// </summary>
    /// <param name="ptr">the pointer</param>
    public static implicit operator byte(Ptr ptr) => *(byte*)ptr.Pointer;

    /// <summary>
    /// Retrieve the void pointer of the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator void*(Ptr ptr) => ptr.Pointer;

    /// <summary>
    /// Creates a <see cref="Ptr"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(void* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="Ptr"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(byte* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="PtrToConst"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(Ptr ptr) => new(ptr.Pointer);

    /// <summary>
    /// Converts the pointer into a pointer to the BaseType
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator byte*(Ptr ptr)
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
    public static implicit operator byte**(Ptr ptr)
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
    public static implicit operator byte***(Ptr ptr)
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
    /// Create a managed pointer from a BaseType double pointer
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(byte** ptr) => new Ptr(ptr, 2);

    /// <summary>
    /// Create a managed pointer from a BaseType double pointer
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(void** ptr) => new Ptr(ptr, 2);

    /// <summary>
    /// Create a managed pointer from a BaseType triple pointer
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(byte*** ptr) => new Ptr(ptr, 3);

    /// <summary>
    /// Create a managed pointer from a BaseType triple pointer
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(void*** ptr) => new Ptr(ptr, 3);

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, Ptr rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, Ptr rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, PtrToConst rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, PtrToConst rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, Ptr rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, Ptr rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, NullPtr rh) => lh.Pointer == null;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, NullPtr rh) => lh.Pointer != null;

    /// <inheritdoc/>
    public override bool Equals([NotNullWhen(true)] object? obj) => Value.Equals(obj);

    /// <inheritdoc/>
    public override int GetHashCode() => base.GetHashCode();
}
