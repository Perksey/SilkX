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
    public static string ReadToString(this PtrRef<byte, byte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<byte, byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<sbyte, sbyte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<sbyte, sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<ushort, ushort> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<ushort, ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<short, short> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<short, short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<char, char> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<char, char> @this, int length) => new string(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<uint, uint> @this)
    {
        int words;
        for (words = 0; ((uint*)@this)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<uint, uint> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this, length * 4);
        
    }

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<int, int> @this)
    {
        int words;
        for (words = 0; ((uint*)@this)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRef<int, int> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this, length * 4);
    }
    #endregion

    #region PTR Extensions
    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<byte, byte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this)
            );
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<byte, byte> @this, int length) => Encoding.UTF8.GetString(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<sbyte, sbyte> @this)
    {
        return Encoding.UTF8.GetString(
                MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)@this)
            );
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<sbyte, sbyte> @this, int length) => Encoding.UTF8.GetString(MemoryMarshal.Cast<sbyte, byte>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<ushort, ushort> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<ushort, ushort> @this, int length) => new string(MemoryMarshal.Cast<ushort, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<short, short> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<short, short> @this, int length) => new string(MemoryMarshal.Cast<short, char>(@this.AsSpan(length)));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<char, char> @this)
    {
        return new string((char*)@this);
        
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<char, char> @this, int length) => new string(@this.AsSpan(length));

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<uint, uint> @this)
    {
        int words;
        for (words = 0; ((uint*)@this)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<uint, uint> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this, length * 4);
        
    }

    /// <summary>
    /// Creates a string from this pointer as a c-style string
    /// </summary>
    /// <param name="this"></param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<int, int> @this)
    {
        int words;
        for (words = 0; ((uint*)@this)[words] != 0; words++)
        {
            // do nothing
        }

        return Encoding.UTF32.GetString((byte*)@this, words * 4);
    }

    /// <summary>
    /// Creates a string from this pointer with the given length
    /// </summary>
    /// <param name="this"></param>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public static string ReadToString(this PtrRefToConst<int, int> @this, int length)
    {
        return Encoding.UTF32.GetString((byte*)@this, length * 4);
        
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
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<Ptr<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(int));
    #endregion

    #region MutPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRef<PtrToConst<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(int));
    #endregion

    #region PtrMut Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<Ptr<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(int));
    #endregion

    #region PtrPtr Extensions
    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<byte, byte>, byte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<sbyte, sbyte>, sbyte> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<ushort, ushort>, ushort> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<short, short>, short> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<char, char>, char> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<uint, uint>, uint> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of strings contained in the string array.</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<int, int>, int> @this, int length) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<Ptr<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRef<PtrToConst<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<Ptr<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<Ptr<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
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
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<byte, byte>, byte>, byte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(byte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<sbyte, sbyte>, sbyte>, sbyte> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(sbyte));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<ushort, ushort>, ushort>, ushort> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(ushort));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<short, short>, short>, short> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(short));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<char, char>, char>, char> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(char));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<uint, uint>, uint>, uint> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(uint));

    /// <summary>
    /// Reads this pointer as a string array.
    /// </summary>
    /// <param name="length">The number of arrays contained in the top-level array.</param>
    /// <param name="lengths">The number of strings in the array</param>
    /// <param name="this"></param>
    /// <returns>The string array.</returns>
    public static string?[]?[]? ReadToStringArray(this PtrRefToConst<PtrToConst<PtrToConst<int, int>, int>, int> @this, int length, int[] lengths) =>
        SilkMarshal.NativeToStringArray(new((byte*)@this, length),
            lengths, sizeof(int));
    #endregion
    #endregion
    #endregion
}
