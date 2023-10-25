using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A managed pointer to a const object
/// </summary>
/// <typeparam name="T">the type of pointer held</typeparam>
/// <typeparam name="BaseType">the non-pointer type held within this pointer</typeparam>
/// <param name="ptr"></param>
public unsafe struct PtrToConst<T, BaseType>(T* ptr) : IPointerToMutable
    where T : unmanaged
    where BaseType : unmanaged
{
    private readonly T* Pointer = ptr;

    /// <summary>
    /// Get a copy of the held native pointer
    /// </summary>
    public readonly T* NativePointer => Pointer;

    /// <summary>
    /// Gets a Reference to the value held
    /// </summary>
    public readonly ref readonly T Value => ref Unsafe.AsRef<T>((void*)Pointer);
    /// <summary>
    /// Gets a reference to the value held at the index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>the reference to the value held at the index</returns>
    public ref readonly T this[int index] => ref Unsafe.AsRef<T>((void*)(((nint)Pointer) + (index * (PtrToConst<T, BaseType>.Depth > 1 ? sizeof(nint) : sizeof(T)))));

    int IPointer.Depth
    {
        get
        {
            IPointer? ptr = default(T) as IPointer;
            return ptr is null ? 1 : ptr.Depth + 1;
        }
    }
    void* IPointer.Pointer => Pointer;

    /// <summary>
    /// Creates a <see cref="ReadOnlySpan{T}"/> from this pointer
    /// </summary>
    /// <param name="length"></param>
    /// <returns>the span</returns>
    public ReadOnlySpan<T> AsSpan(int length) => new(Pointer, length);

    /// <summary>
    /// Retrieve the value held by the pointer
    /// </summary>
    /// <param name="ptr">the pointer</param>
    public static implicit operator T(PtrToConst<T, BaseType> ptr) => *ptr.Pointer;

    /// <summary>
    /// Retrieve the void pointer of the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator void*(PtrToConst<T, BaseType> ptr) => ptr.Pointer;

    /// <summary>
    /// Creates a <see cref="PtrToConst{T, BaseType}"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst<T, BaseType>(T* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="PtrToConst{T, BaseType}"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator Ptr<T, BaseType>(PtrToConst<T, BaseType> ptr) => new(ptr.Pointer);

    /// <summary>
    /// Creates a <see cref="PtrToConst{T, BaseType}"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst(PtrToConst<T, BaseType> ptr) => new(ptr.Pointer, Depth);

    /// <summary>
    /// Converts the pointer into a pointer to the BaseType
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator BaseType*(PtrToConst<T, BaseType> ptr)
    {
        if (PtrToConst<T, BaseType>.Depth != 1)
            throw new InvalidCastException();
        return (BaseType*)ptr.Pointer;
    }

    /// <summary>
    /// Converts the pointer into a double pointer to the BaseType
    /// Only valid for depth 1 or 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator BaseType**(PtrToConst<T, BaseType> ptr)
    {
        switch (PtrToConst<T, BaseType>.Depth)
        {
            case 1:
                return (BaseType**)&ptr.Pointer;
            case 2:
                return (BaseType**)ptr.Pointer;
            default:
                throw new InvalidCastException();
        }
    }

    /// <summary>
    /// Converts the pointer into a triple pointer to the BaseType
    /// Only valid for depth 2 or 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator BaseType***(PtrToConst<T, BaseType> ptr)
    {
        switch (PtrToConst<T, BaseType>.Depth)
        {
            case 2:
                return (BaseType***)&ptr.Pointer;
            case 3:
                return (BaseType***)ptr.Pointer;
            default:
                throw new InvalidCastException();
        }
    }

    /// <summary>
    /// Creates a <see cref="PtrToConst{T, BaseType}"/> from a nullptr
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst<T, BaseType>(NullPtr ptr) => new(null);

    /// <summary>
    /// Creates a string from a <see cref="PtrToConst{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator string(PtrToConst<T, BaseType> ptr)
    {
        if (PtrToConst<T, BaseType>.Depth != 1 || typeof(T) != typeof(BaseType))
            throw new InvalidCastException();

        if (typeof(T) == typeof(char) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
        {
            return new string((char*)ptr.Pointer);
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)ptr.Pointer)
                );
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
        {
            int words;
            for (words = 0; ((uint*)ptr.Pointer)[words] != 0; words++)
            {
                // do nothing
            }

            return Encoding.UTF32.GetString((byte*)ptr.Pointer, words * 4);
        }

        throw new InvalidCastException();

    }

    /// <summary>
    /// Create a managed pointer from a BaseType double pointer
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst<T, BaseType>(BaseType** ptr) => PtrToConst<T, BaseType>.Depth != 2
            ? throw new InvalidCastException()
            : new PtrToConst<T, BaseType>((T*)ptr);

    /// <summary>
    /// Create a managed pointer from a BaseType triple pointer
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst<T, BaseType>(BaseType*** ptr) => PtrToConst<T, BaseType>.Depth != 3
            ? throw new InvalidCastException()
            : new PtrToConst<T, BaseType>((T*)ptr);

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst<T, BaseType> lh, PtrToConst<T, BaseType> rh) => lh.Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst<T, BaseType> lh, PtrToConst<T, BaseType> rh) => lh.Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst<T, BaseType> lh, Ptr<T, BaseType> rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst<T, BaseType> lh, Ptr<T, BaseType> rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst<T, BaseType> lh, Ptr rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, PtrToConst<T, BaseType> rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, PtrToConst<T, BaseType> rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst<T, BaseType> lh, Ptr rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst<T, BaseType> lh, PtrToConst rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst<T, BaseType> lh, PtrToConst rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, PtrToConst<T, BaseType> rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, PtrToConst<T, BaseType> rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst<T, BaseType> lh, NullPtr rh) => lh.Pointer == null;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst<T, BaseType> lh, NullPtr rh) => lh.Pointer != null;

    /// <inheritdoc/>
    public override bool Equals([NotNullWhen(true)] object? obj) => Value.Equals(obj);

    /// <inheritdoc/>
    public override int GetHashCode() => base.GetHashCode();

    internal static int Depth
    {
        get
        {
            IPointer def = default(PtrToConst<T, BaseType>);
            return def.Depth;
        }
    }
}
