using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Core;

/// <summary>
/// Class containing extension methods for pointer types
/// </summary>
public unsafe static class PointerExtensions
{
    #region ReadToString Extensions
    #region MUT Extensions
    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<byte, byte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this.NativePointer)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<byte, byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<sbyte, sbyte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this.NativePointer)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<sbyte, sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<ushort, ushort> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<ushort, ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<short, short> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<short, short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<char, char> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<char, char> @this, int length) => new string(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<uint, uint> @this)
    {
        int words;
        for (words = 0; ((uint*)@this.NativePointer)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this.NativePointer, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<uint, uint> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this.NativePointer, length * 4);
        
    }

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<int, int> @this)
    {
        int words;
        for (words = 0; ((uint*)@this.NativePointer)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this.NativePointer, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this Ptr<int, int> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this.NativePointer, length * 4);
    }
    #endregion

    #region PTR Extensions
    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<byte, byte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated(@this.NativePointer)
            );
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<byte, byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<sbyte, sbyte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this.NativePointer)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<sbyte, sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<ushort, ushort> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<ushort, ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<short, short> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<short, short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<char, char> @this)
    {
        return new string((char*)@this.NativePointer);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<char, char> @this, int length) => new string(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<uint, uint> @this)
    {
        int words;
        for (words = 0; ((uint*)@this.NativePointer)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this.NativePointer, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<uint, uint> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this.NativePointer, length * 4);
        
    }

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<int, int> @this)
    {
        int words;
        for (words = 0; ((uint*)@this.NativePointer)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this.NativePointer, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrToConst<int, int> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this.NativePointer, length * 4);
        
    }
    #endregion
    #endregion

    #region ReadToStringArray Extensions
    #region 2D Extensions
    #region MutMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<Ptr<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(int));
    #endregion

    #region MutPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this Ptr<PtrToConst<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(int));
    #endregion

    #region PtrMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<Ptr<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(int));
    #endregion

    #region PtrPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrToConst<PtrToConst<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            sizeof(int));
    #endregion
    #endregion

    #region 3DExtensions
    #region MutMutMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region MutMutPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<Ptr<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region MutPtrMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region MutPtrPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this Ptr<PtrToConst<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region PtrMutMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region PtrMutPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<Ptr<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region PtrPtrMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion

    #region PtrPtrPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrToConst<PtrToConst<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new(@this.NativePointer, length),
            lengths, sizeof(int));
    #endregion
    #endregion
    #endregion
}
