using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A managed pointer to a mutable object
/// </summary>
/// <typeparam name="T">the type of pointer held</typeparam>
/// <typeparam name="BaseType">the non-pointer type held within this pointer</typeparam>
/// <param name="ptr"></param>
/// <param name="handle"></param>
public unsafe struct Ptr<T, BaseType>(T* ptr, GCHandle? handle = null) : IPointerToMutable, IDisposable
    where T : unmanaged
    where BaseType : unmanaged
{
    /// <summary>
    /// Create a pinned pointer to a managed reference
    /// </summary>
    /// <param name="value">the managed reference</param>
    public Ptr(ref T value)
        : this(null)
    {
        Handle = GCHandle.Alloc(value, GCHandleType.Pinned);
        Pointer = (T*)Handle.Value.AddrOfPinnedObject().ToPointer();
    }

    /// <summary>
    /// Creates a pinned pointer to a managed handle
    /// </summary>
    /// <param name="handle"></param>
    public Ptr(GCHandle handle)
        : this(null)
    {
        Handle = handle;
        Pointer = (T*)handle.AddrOfPinnedObject().ToPointer();
    }

    private readonly T* Pointer = ptr;
    private readonly GCHandle? Handle = handle;

    /// <summary>
    /// Get a copy of the held native pointer
    /// </summary>
    public T* NativePointer => Pointer; 

    /// <summary>
    /// Gets a Reference to the value held
    /// </summary>
    public ref T Value => ref Unsafe.AsRef<T>(Pointer);
    /// <summary>
    /// Gets a reference to the value held at the index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>the reference to the value held at the index</returns>
    public ref T this[int index] => ref Unsafe.AsRef<T>((void*)(((nint)Pointer) + (index * (PtrToConst<T, BaseType>.Depth > 1 ? sizeof(nint) : sizeof(T)))));

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
    /// Creates a <see cref="Span{T}"/> from this pointer
    /// </summary>
    /// <param name="length"></param>
    /// <returns>the span</returns>
    public Span<T> AsSpan(int length) => new(Pointer, length);

    /// <summary>
    /// Retrieve the value held by the pointer
    /// </summary>
    /// <param name="ptr">the pointer</param>
    public static implicit operator T(Ptr<T, BaseType> ptr) => *ptr.Pointer;

    /// <summary>
    /// Retrieve the void pointer of the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator void*(Ptr<T, BaseType> ptr) => ptr.Pointer;

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a native pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr<T, BaseType>(T* ptr) => new(ptr);

    /// <summary>
    /// Creates a <see cref="PtrToConst{T, BaseType}"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrToConst<T, BaseType>(Ptr<T, BaseType> ptr) => new(ptr.Pointer, ptr.Handle);

    /// <summary>
    /// Creates a <see cref="Ptr"/> from the pointer
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr(Ptr<T, BaseType> ptr) => new(ptr.Pointer, ptr.Handle, Depth);

    /// <summary>
    /// Converts the pointer into a pointer to the BaseType
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator BaseType*(Ptr<T, BaseType> ptr)
    {
        if (Ptr<T, BaseType>.Depth != 1)
            throw new InvalidCastException();
        return (BaseType*)ptr.Pointer;
    }

    /// <summary>
    /// Converts the pointer into a double pointer to the BaseType
    /// Only valid for depth 1 or 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator BaseType**(Ptr<T, BaseType> ptr)
    {
        switch (Ptr<T, BaseType>.Depth)
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
    public static implicit operator BaseType***(Ptr<T, BaseType> ptr)
    {
        switch (Ptr<T, BaseType>.Depth)
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
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a BaseType array
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType[] array) => Depth != 1 ? throw new InvalidCastException() : new(GCHandle.Alloc(array, GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 2D BaseType array
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType[][] array) => Depth != 2 ? throw new InvalidCastException() : SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 2D BaseType array
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType[][][] array) => Depth != 3 ? throw new InvalidCastException() : SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a BaseType span
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(Span<BaseType> span)
    {
        if (Depth != 1)
            throw new InvalidCastException();
        return new(*(T**)SilkMarshal.SpanRefToPtr<BaseType>(ref span), GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 2D BaseType span
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(Span<BaseType[]> span) => Depth != 2 ? throw new InvalidCastException() : new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 2D BaseType span
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(Span<BaseType[][]> span) => Depth != 3 ? throw new InvalidCastException() : new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a BaseType span
    /// Only valid for depth 1 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(ReadOnlySpan<BaseType> span)
    {
        if (Depth != 1)
            throw new InvalidCastException();
        return new(*(T**)SilkMarshal.SpanRefToPtr<BaseType>(ref span), GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 2D BaseType span
    /// Only valid for depth 2 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(ReadOnlySpan<BaseType[]> span) => Depth != 2 ? throw new InvalidCastException() : new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a jagged 3D BaseType span
    /// Only valid for depth 3 pointers 
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(ReadOnlySpan<BaseType[][]> span) => Depth != 3 ? throw new InvalidCastException() : new(GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned));

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a nullptr
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr<T, BaseType>(NullPtr ptr) => new(null);

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a string
    /// Only valid for depth 1 pointers
    /// </summary>
    /// <param name="str"></param>
    public static implicit operator Ptr<T, BaseType>(string str)
    {
        if (typeof(T) != typeof(byte)
            && typeof(T) != typeof(sbyte)
            && typeof(T) != typeof(char)
            && typeof(T) != typeof(short)
            && typeof(T) != typeof(ushort)
            && typeof(T) != typeof(int)
            && typeof(T) != typeof(uint)
            || typeof(T) != typeof(BaseType)
            || Ptr<T, BaseType>.Depth != 1
            )
        {
            throw new InvalidCastException();
        }

        object? obj = sizeof(T) == 2 ? str : SilkMarshal.StringToArray(str, sizeof(T));

        return new(GCHandle.Alloc(obj, GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a span of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(Span<string> span)
    {
        if ((typeof(BaseType) != typeof(byte)
            && typeof(BaseType) != typeof(sbyte)
            && typeof(BaseType) != typeof(char)
            && typeof(BaseType) != typeof(short)
            && typeof(BaseType) != typeof(ushort)
            && typeof(BaseType) != typeof(int)
            && typeof(BaseType) != typeof(uint))
            || Ptr<T, BaseType>.Depth != 2
        )
        {
            throw new InvalidCastException();
        }

        return new Ptr<T, BaseType>(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(BaseType)), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a <see cref="Ptr{T, BaseType}"/> from a span of string arrays
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="span"></param>
    public static implicit operator Ptr<T, BaseType>(Span<string[]> span)
    {
        if (Ptr<T, BaseType>.Depth != 3
            && typeof(BaseType) != typeof(byte)
            && typeof(BaseType) != typeof(sbyte)
            && typeof(BaseType) != typeof(char)
            && typeof(BaseType) != typeof(short)
            && typeof(BaseType) != typeof(ushort)
            && typeof(BaseType) != typeof(int)
            && typeof(BaseType) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new Ptr<T, BaseType>(GCHandle.Alloc(SilkMarshal.StringArrayToArray(span, sizeof(BaseType)), GCHandleType.Pinned));
    }

    /// <summary>
    /// Creates a string from a <see cref="Ptr{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static explicit operator string(Ptr<T, BaseType> ptr)
    {
        if (Ptr<T, BaseType>.Depth != 1 || typeof(T) != typeof(BaseType))
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
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType*[] array) => Ptr<T, BaseType>.Depth != 2
            ? throw new InvalidCastException()
            : new Ptr<T, BaseType>(GCHandle.Alloc(array, GCHandleType.Pinned));

    /// <summary>
    /// Create a managed pointer from a BaseType double pointer
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType** ptr) => Ptr<T, BaseType>.Depth != 2
            ? throw new InvalidCastException()
            : new Ptr<T, BaseType>((T*)ptr);

    /// <summary>
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType*[][] array) => Ptr<T, BaseType>.Depth != 3
            ? throw new InvalidCastException()
            : new Ptr<T, BaseType>(GCHandle.Alloc(array, GCHandleType.Pinned));

    /// <summary>
    /// Create a managed pointer from a BaseType pointer array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType**[] array) => Ptr<T, BaseType>.Depth != 3
            ? throw new InvalidCastException()
            : new Ptr<T, BaseType>(GCHandle.Alloc(array, GCHandleType.Pinned));

    /// <summary>
    /// Create a managed pointer from a BaseType triple pointer
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ptr<T, BaseType>(BaseType*** ptr) => Ptr<T, BaseType>.Depth != 3
            ? throw new InvalidCastException()
            : new Ptr<T, BaseType>((T*)ptr);

    /// <summary>
    /// Create a managed pointer from an array of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strings"></param>
    public static implicit operator Ptr<T, BaseType>(string[] strings)
    {
        if (PtrToConst<T, BaseType>.Depth != 2
            && typeof(BaseType) != typeof(byte)
            && typeof(BaseType) != typeof(sbyte)
            && typeof(BaseType) != typeof(char)
            && typeof(BaseType) != typeof(short)
            && typeof(BaseType) != typeof(ushort)
            && typeof(BaseType) != typeof(int)
            && typeof(BaseType) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new Ptr<T, BaseType>(GCHandle.Alloc(SilkMarshal.StringArrayToArray(strings, sizeof(BaseType)), GCHandleType.Pinned));
    }

    /// <summary>
    /// Create a managed pointer from a jagged 2d array of strings
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strings"></param>
    public static implicit operator Ptr<T, BaseType>(string[][] strings)
    {
        if (PtrToConst<T, BaseType>.Depth != 2
            && typeof(BaseType) != typeof(byte)
            && typeof(BaseType) != typeof(sbyte)
            && typeof(BaseType) != typeof(char)
            && typeof(BaseType) != typeof(short)
            && typeof(BaseType) != typeof(ushort)
            && typeof(BaseType) != typeof(int)
            && typeof(BaseType) != typeof(uint)
        )
        {
            throw new InvalidCastException();
        }

        return new Ptr<T, BaseType>(GCHandle.Alloc(SilkMarshal.StringArrayToArray(strings, sizeof(BaseType)), GCHandleType.Pinned));
    }

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr<T, BaseType> lh, Ptr<T, BaseType> rh) => lh.Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr<T, BaseType> lh, Ptr<T, BaseType> rh) => lh.Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr<T, BaseType> lh, PtrToConst<T, BaseType> rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr<T, BaseType> lh, PtrToConst<T, BaseType> rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr<T, BaseType> lh, Ptr rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr lh, Ptr<T, BaseType> rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr lh, Ptr<T, BaseType> rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr<T, BaseType> lh, Ptr rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr<T, BaseType> lh, PtrToConst rh) => lh.Pointer == ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr<T, BaseType> lh, PtrToConst rh) => lh.Pointer != ((IPointer)rh).Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(PtrToConst lh, Ptr<T, BaseType> rh) => ((IPointer)lh).Pointer == rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(PtrToConst lh, Ptr<T, BaseType> rh) => ((IPointer)lh).Pointer != rh.Pointer;

    /// <summary>
    /// Determines whether two pointers are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator ==(Ptr<T, BaseType> lh, NullPtr rh) => lh.Pointer == null;

    /// <summary>
    /// Determines whether two pointers are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>whether two pointers are equal</returns>
    public static bool operator !=(Ptr<T, BaseType> lh, NullPtr rh) => lh.Pointer != null;

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

    internal static int Depth
    {
        get
        {
            IPointer def = default(Ptr<T, BaseType>);
            return def.Depth;
        }
    }
}
