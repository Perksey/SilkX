using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core
{
    /// <summary>
    /// A single dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr2D<T>
        where T : unmanaged
    {
        /// <summary>
        /// Creates an instance of <see cref="Ptr2D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr2D(Ptr<T>* ptr)
        {
            Native = ptr;
        }

        /// <summary>
        /// Creates an instance of <see cref="Ptr2D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr2D(void** ptr)
            : this((Ptr<T>*)ptr) { }

        /// <summary>
        /// Creates an instance of <see cref="Ptr2D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr2D(T** ptr)
            : this((Ptr<T>*)ptr) { }

        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly Ptr<T>* Native;

        /// <summary>
        /// A reference to the pointer value
        /// </summary>
        public readonly ref Ptr<T> Handle => ref Unsafe.AsRef<Ptr<T>>(Native);

        /// <summary>
        /// Returns the value located within this pointer
        /// </summary>
        public ref T Value
        {
            get
            {
                if (Native == null)
                    return ref Unsafe.NullRef<T>();
                return ref Native->Handle;
            }
        }

        /// <summary>
        /// Gets a ref to the offset pointer value
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the offset pointer value</returns>
        public ref Ptr<T> this[nuint index] => ref Unsafe.AsRef<Ptr<T>>(((nuint)Native + (index * (nuint)sizeof(T))).ToPointer());

        /// <summary>
        /// Gets the underlying pointer.
        /// </summary>
        /// <returns>The underlying pointer.</returns>
        /// <remarks>
        /// This function allows a <see cref="Ptr"/> to be used in a <c>fixed</c> statement.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref T* GetPinnableReference()
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(Ptr2D<>)).MakeGenericType(typeof(T)),
                    nameof(Native)
                )
            );
            IL.Emit.Ret();
            throw IL.Unreachable();
        }

        /// <summary>
        /// Creates a span with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <returns>the span</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Span<Ptr<T>> AsSpan(int length) => new(Native, length);

        /// <summary>
        /// Creates an array with the given length from this pointer
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Ptr<T>[] ToArray(int length) => AsSpan(length).ToArray();

        /// <summary>
        /// Creates a 2D Jagged array from this pointer
        /// </summary>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths">the number of elements in each array at this pointer</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T[][] ToArray(int length, int[] lengths) => SilkMarshal.NativeToArray<T>(new(Native, length), lengths);

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, Ref2D<T> rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, Ref2D<T> rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ref2D<T> lh, Ptr2D<T> rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ref2D<T> lh, Ptr2D<T> rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, void* rh) => lh.Native is not null && lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, void* rh) => lh.Native is not null && lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(void* lh, Ptr2D<T> rh) => rh.Native is not null && lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(void* lh, Ptr2D<T> rh) => rh.Native is not null && lh != rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, void** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, void** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(void** lh, Ptr2D<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(void** lh, Ptr2D<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, T* rh) => lh.Native is not null && lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, T* rh) => lh.Native is not null && lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(T* lh, Ptr2D<T> rh) => rh.Native is not null && lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(T* lh, Ptr2D<T> rh) => rh.Native is not null && lh != rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, T** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, T** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(T** lh, Ptr2D<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(T** lh, Ptr2D<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(NullPtr lh, Ptr2D<T> rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(NullPtr lh, Ptr2D<T> rh) => null != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, Ptr2D rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, Ptr2D rh) => lh.Native != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D lh, Ptr2D<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D lh, Ptr2D<T> rh) => lh.Native != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(void* ptr) => new((Ptr<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void*(Ptr2D<T> ptr) => ptr.Native is not null ? ptr.Native->Native : null;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(void** ptr) => new((Ptr<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void**(Ptr2D<T> ptr) => (void**)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(T** ptr) => new((Ptr<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T*(Ptr2D<T> ptr) => ptr.Native is not null ? ptr.Native->Native : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T**(Ptr2D<T> ptr) => (T**)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ref2D(Ptr2D<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ref2D<T>(Ptr2D<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(Ref2D ptr) => (void**)ptr;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(Ref2D<T> ptr) => (T**)ptr;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="Ptr2D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D(Ptr2D<T> ptr) => new((Ptr*)ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ptr2D{T}"/> from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(Ptr2D ptr) => new((Ptr<T>*)ptr.Native);

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Ptr2D<T>(NullPtr ptr) => new((Ptr<T>*)null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Ptr2D<T> lh, Ptr2D<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Ptr2D<T> lh, Ptr2D<T> rh) => lh.Native != rh.Native;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals([NotNullWhen(true)] object? obj) => base.Equals(obj);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode() => base.GetHashCode();
    }
}
