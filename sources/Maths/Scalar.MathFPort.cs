// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if SSE || AdvSIMD
using System.Runtime.Intrinsics;
#endif
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

// it doesn't like default because it may be null
#pragma warning disable 8603

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // This partial contains the helper methods which forward to MathF or Math, used a lot within Silk.NET.Maths
        //
        // For the most part, these are pretty direct forwards. However there are a lot of unnecessary up-casts in a lot
        // of places. Possible tasks could be:
        // a) TODO identifying where we're up-casting unnecessarily
        //    (it's done a lot throughout this file as System.Math pretty much only supports double)
        // b) TODO removing unnecessary up-casts with dedicated, managed methods.
        // c) TODO implement any unimplemented methods
        //    Ctrl+F for ThrowOpUnsupportedPrecision
        //
        // These should be done around 2.0 Preview 5 time, but if you're reading this comment after 2.0's initial
        // release then feel free to PR in some of these changes as we clearly have failed.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        /// <param name="x">The value to get the absolute of</param>
        /// <typeparam name="T">The type of <paramref name="x"/> </typeparam>
        /// <returns>The absolute of the given value</returns>
        [MethodImpl(MaxOpt)]
        public static unsafe T Abs<T>(T x) where T : unmanaged, INumberBase<T>
        {
            return T.Abs(x);
        }

        /// <summary>
        /// Returns the angle whose cosine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a cosine, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        ///An angle, θ, measured in radians, such that 0 ≤ θ ≤ π.
        ///
        /// -or-
        ///
        /// NaN if x &lt; -1 or x &gt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Acos<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Acos(x);
        }

        /// <summary>
        /// Returns the angle whose hyperbolic cosine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic cosine, where <paramref name="x"/> must be greater than or equal to 1, but less than or equal to <see cref="Scalar{T}.PositiveInfinity"/>.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that 0 ≤ θ ≤ ∞.
        ///
        /// -or-
        ///
        /// NaN if x &lt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Acosh<T>(T x) where T : notnull, IHyperbolicFunctions<T>
        {
            return T.Acosh(x);
        }

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a sine, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2.
        ///
        /// -or-
        ///
        /// NaN if x &lt; -1 or x &gt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Asin<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Asin(x);
        }

        /// <summary>
        /// Returns the angle whose hyperbolic sine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic sine, where <paramref name="x"/> must be greater than or equal to <see cref="Scalar{T}.NegativeInfinity"/>, but less than or equal to <see cref="Scalar{T}.PositiveInfinity"/>.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(MaxOpt)]
        public static T Asinh<T>(T x) where T : notnull, IHyperbolicFunctions<T>
        {
            return T.Asinh(x);
        }

        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="x">A number representing a tangent.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        ///An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2.
        ///
        /// -or-
        ///
        /// NaN if <paramref name="x"/> equals <see cref="Scalar{T}.NaN"/>, -π/2 rounded to double precision (-1.5707963267949) if <paramref name="x"/> equals <see cref="Scalar{T}.NegativeInfinity"/>, or π/2 rounded to double precision (1.5707963267949) if <paramref name="x"/> equals <see cref="Scalar{T}.PositiveInfinity"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Atan<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Atan(x);
        }

        /// <summary>
        /// Returns the angle whose hyperbolic tangent is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic tangent, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that -∞ &lt; θ &lt; -1, or 1 &lt; θ &lt; ∞.
        ///
        /// -or-
        ///
        /// <see cref="Scalar{T}.NaN"/> if x &lt; -1 or x &gt; 1 or x equals <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Atanh<T>(T x) where T : notnull, IHyperbolicFunctions<T>
        {
            return T.Atanh(x);
        }

        /// <summary>
        /// Returns the cube root of a specified number.
        /// </summary>
        /// <param name="x">The number whose cube root is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        /// The cube root of <paramref name="x"/>.
        ///
        /// -or-
        ///
        /// <see cref="Scalar{T}.NaN"/> if <paramref name="x"/> is equals <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Cbrt<T>(T x) where T : notnull, IRootFunctions<T>
        {
            return T.Cbrt(x);
        }

        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type.</returns>
        [MethodImpl(MaxOpt)]
        public static T Ceiling<T>(T x) where T : notnull, IFloatingPoint<T>
        {
            return T.Ceiling(x);
        }

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The cosine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Cos<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Cos(x);
        }

        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic cosine of <paramref name="x"/>. If <paramref name="x"/> equal to <see cref="Scalar{T}.NegativeInfinity"/> or <see cref="Scalar{T}.PositiveInfinity"/>, <see cref="Scalar{T}.PositiveInfinity"/> is returned. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Cosh<T>(T x) where T : notnull, IHyperbolicFunctions<T>
        {
            return T.Cosh(x);
        }

        /// <summary>
        /// Returns <c>e</c> raised to the specified power.
        /// </summary>
        /// <param name="x">A number specifying a power.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number <c>e</c> raised to the power <paramref name="x"/>. If <paramref name="x"/> equals <see cref="Scalar{T}.NaN"/> or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned. If <paramref name="x"/> equals <see cref="Scalar{T}.NegativeInfinity"/>, 0 is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Exp<T>(T x) where T : notnull, IExponentialFunctions<T>
        {
            return T.Exp(x);
        }

        /// <summary>
        /// Returns the largest integral value less than or equal to the specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The largest integral value less than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Floor<T>(T x) where T : notnull, IFloatingPoint<T>
        {
            return T.Floor(x);
        }

        /// <summary>
        /// Returns an integer that indicates the sign of a single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        /// A number that indicates the sign of <paramref name="x"/>, as shown in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term>Return value</term>
        /// <description>Meaning</description>
        /// </listheader>
        /// <item>
        /// <term>-1</term>
        /// <description><paramref name="x"/> is less than zero.</description>
        /// </item>
        /// <item>
        /// <term>0</term>
        /// <description><paramref name="x"/> is equal to zero.</description>
        /// </item>
        /// <item>
        /// <term>1</term>
        /// <description><paramref name="x"/> is greater than zero.</description>
        /// </item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// For unsigned numbers this will never return -1, but will return 0 when <paramref name="x"/> is 0
        /// </remarks>
        /// <exception cref="ArithmeticException"><paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/></exception>
        [MethodImpl(MaxOpt)]
        public static int Sign<T>(T x) where T : notnull, INumber<T>
        {
            return T.Sign(x);
        }

        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The sine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Sin<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Sin(x);
        }

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">Type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic sine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NegativeInfinity"/>, <see cref="Scalar{T}.PositiveInfinity"/>, or <see cref="Scalar{T}.NaN"/> this method returns <paramref name="x"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Sinh<T>(T x) where T : notnull, IHyperbolicFunctions<T>
        {
            return T.Sinh(x);
        }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="x">The number whose square root is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Zero or positive</term>
        /// <description>The positive square root of <paramref name="x"/>.</description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equals <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equals <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Sqrt<T>(T x) where T : notnull, IRootFunctions<T>
        {
            return T.Sqrt(x);
        }

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The tangent of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Tan<T>(T x) where T : notnull, ITrigonometricFunctions<T>
        {
            return T.Tan(x);
        }

        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic tangent of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NegativeInfinity"/>, this method returns -1. If <paramref name="x"/> is equal to <see cref="Scalar{T}.PositiveInfinity"/>, this method returns 1. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Tanh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Tanh((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Tanh((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Tanh((float) (object) x);
#else
                    return (T) (object) MathF.Tanh((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Tanh((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Tanh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Tanh((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Tanh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Tanh((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Tanh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Tanh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Tanh((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Tanh((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Tanh((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Calculates the integral part of a specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number to truncate.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>
        /// The integral part of <paramref name="x"/>; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/></term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term><see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term><see cref="Scalar{T}.NegativeInfinity"/></term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term><see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Truncate<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Truncate((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Truncate((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Truncate((float) (object) x);
#else
                    return (T) (object) MathF.Truncate((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Truncate((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Truncate((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the natural (base <c>e</c>) logarithm of a specified number.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Positive</term>
        /// <description>The natural logarithm of <paramref name="x"/>; that is, ln <paramref name="x"/>, or log e <paramref name="x"/></description>
        /// </item>
        /// <item>
        /// <term>Zero</term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastLog((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastLog((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Log((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Positive</term>
        /// <description>The base 10 log of <paramref name="x"/>; that is log 10 <paramref name="x"/></description>
        /// </item>
        /// <item>
        /// <term>Zero</term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log10<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Log10((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Log10((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Log10((float) (object) x);
#else
                    return (T) (object) MathF.Log10((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log10((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log10((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log10((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log10((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log10((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log10((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log10((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log10((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Log10((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log10((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type
        /// </returns>
        /// <remarks>
        /// This method uses the default rounding convention of <see cref="MidpointRounding.ToEven"/>.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Round((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        return (T)(object)(float)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(float)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((float)(object)x)).ToScalar();
                    }
#endif
#if !MATHF
                    return (T) (object) (float) Math.Round((float) (object) x);
#else
                    return (T) (object) MathF.Round((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        return (T)(object)(double)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(double)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                    }
#endif
                    return (T) (object) (double) Math.Round((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Round((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by another specified number.
        /// </summary>
        /// <param name="x">A dividend.</param>
        /// <param name="y">A divisor.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>
        /// A number equal to <paramref name="x"/> - (<paramref name="y"/> Q), where Q is the quotient of <paramref name="x"/> / <paramref name="y"/> rounded to the nearest integer (if <paramref name="x"/> / <paramref name="y"/> falls halfway between two integers, the even integer is returned).
        ///
        /// If <paramref name="x"/> - (<paramref name="y"/> Q) is zero, the value +0 is returned if <paramref name="x"/> is positive, or -0 if <paramref name="x"/> is negative.
        ///
        /// If <paramref name="y"/> = 0, NaN is returned.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T IEEERemainder<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.IEEERemainder
                    ((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.IEEERemainder((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.IEEERemainder((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.IEEERemainder((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.IEEERemainder((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.IEEERemainder((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.IEEERemainder((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.IEEERemainder((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.IEEERemainder((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.IEEERemainder((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.IEEERemainder((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.IEEERemainder((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.IEEERemainder((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <param name="y">The base.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table. (+Infinity denotes <see cref="Scalar{T}.PositiveInfinity"/>, -Infinity denotes <see cref="Scalar{T}.NegativeInfinity"/>, and NaN denotes <see cref="Scalar{T}.NaN"/>.)
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/></term>
        /// <description><c>newBase</c></description>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term><paramref name="x"/>&gt;0</term>
        /// <description>(0&lt;<c>newBase</c>&lt;1) -or- (<c>newBase</c>&gt;1)</description>
        /// <description>lognewBase(a)</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/>&lt;0</term>
        /// <description>(any value)</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c>&lt;0</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> != 1</term>
        /// <description><c>newBase</c> = 0</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> != 1</term>
        /// <description><c>newBase</c> = +Infinity</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = NaN</term>
        /// <description>(any value)</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c> = NaN</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c> = 1</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 0</term>
        /// <description>0 &lt; <c>newBase</c> &lt; 1</description>
        /// <description>+Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 0</term>
        /// <description><c>newBase</c> &gt; 1</description>
        /// <description>-Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = +Infinity</term>
        /// <description>0 &lt; <c>newBase</c> &lt; 1</description>
        /// <description>-Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = +Infinity</term>
        /// <description><c>newBase</c> &gt; 1</description>
        /// <description>+Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 1</term>
        /// <description><c>newBase</c> = 0</description>
        /// <description>0</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 1</term>
        /// <description><c>newBase</c> = +Infinity</description>
        /// <description>0</description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Log((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Log((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Log((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Log((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Log((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x, (long) (object) y);
                }

                return Complex(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x, T y)
            {
                if (typeof(T) == typeof(Complex))
                {
                    // Complex.Log is not defined on two complex numbers
                    var baseValue = (Complex) (object) y;
                    if (baseValue.Imaginary is 0)
                        return (T) (object) (Complex) System.Numerics.Complex.Log((Complex) (object) x, baseValue.Real);
                    // log(x, y) = log(x) / log(y)
                    return (T) (object) (System.Numerics.Complex.Log((Complex) (object) x) / System.Numerics.Complex.Log(baseValue));
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        /// <param name="x">The first of two numbers to compare.</param>
        /// <param name="y">The second of two numbers to compare.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>Parameter <paramref name="x"/> or <paramref name="y"/>, whichever is larger. If <paramref name="x"/>, or <paramref name="y"/>, or both <paramref name="x"/> and <paramref name="y"/> are equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Max<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Max((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Max((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Max((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Max((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Max((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Max((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Max((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Max((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Max((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Max((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Max((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Max((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Max((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Max((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        /// <param name="x">The first of two numbers to compare.</param>
        /// <param name="y">The second of two numbers to compare.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>Parameter <paramref name="x"/> or <paramref name="y"/>, whichever is smaller. If <paramref name="x"/>, or <paramref name="y"/>, or both <paramref name="x"/> and <paramref name="y"/> are equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Min<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Min((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Min((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Min((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Min((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Min((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Min((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Min((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Min((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Min((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Min((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Min((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Min((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Min((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Min((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A number to be raised to a power.</param>
        /// <param name="y">A number that specifies a power.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>The number <paramref name="x"/> raised to the power <paramref name="y"/>.</returns>
        ///         <remarks>
        ///         <format type="text/markdown"><![CDATA[
        ///
        /// ## Remarks
        ///             The following table indicates the return value when various values or ranges of values are specified for the `x` and `y` parameters. For more information, see <xref:System.Single.PositiveInfinity?displayProperty=nameWithType>, <xref:System.Single.NegativeInfinity?displayProperty=nameWithType>, and <xref:System.Single.NaN?displayProperty=nameWithType>.
        ///
        ///         |Parameters|Return value|
        ///         |----------------|------------------|
        ///         |`x` or `y` = `NaN`.|`NaN`|
        ///         |`x` = Any value except `NaN`; `y` = 0.|1|
        ///         |`x` = `NegativeInfinity`; `y` < 0.|0|
        ///         |`x` = `NegativeInfinity`; `y` is a positive odd integer.|`NegativeInfinity`|
        ///         |`x` = `NegativeInfinity`; `y` is positive but not an odd integer.|`PositiveInfinity`|
        ///         |`x` < 0 but not `NegativeInfinity`; `y` is not an integer, `NegativeInfinity`, or `PositiveInfinity`.|`NaN`|
        ///         |`x` = -1; `y` = `NegativeInfinity` or `PositiveInfinity`.|`NaN`|
        ///         |-1 < `x` < 1; `y` = `NegativeInfinity`.|`PositiveInfinity`|
        ///         |-1 < `x` < 1; `y` = `PositiveInfinity`.|0|
        ///         |`x` < -1 or `x` > 1; `y` = `NegativeInfinity`.|0|
        ///         |`x` < -1 or `x` > 1; `y` = `PositiveInfinity`.|`PositiveInfinity`|
        ///         |`x` = 0; `y` < 0.|`PositiveInfinity`|
        ///         |`x` = 0; `y` > 0.|0|
        ///         |`x` = 1; `y` is any value except `NaN`.|1|
        ///         |`x` = `PositiveInfinity`; `y` < 0.|0|
        ///         |`x` = `PositiveInfinity`; `y` > 0.|`PositiveInfinity`|
        ///
        ///         ]]></format>
        ///         </remarks>
        [MethodImpl(MaxOpt)]
        public static T Pow<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastPow((float) (Half) (object) x, (float) (Half) (object) y);
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastPow((float) (object) x, (float) (object) y);
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Pow((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    var py = (sbyte) (object) y;
                    var px = (sbyte) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        sbyte result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (sbyte) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (sbyte) 1;
                        else return (T) (object) (sbyte) 0;
                    }
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    var py = (byte) (object) y;
                    var px = (byte) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        byte result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (byte) 1;
                        else return (T) (object) (byte) 0;
                    }
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    var py = (short) (object) y;
                    var px = (short) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        short result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (short) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (short) 1;
                        else return (T) (object) (short) 0;
                    }
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    var py = (ushort) (object) y;
                    var px = (ushort) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        ushort result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (ushort) 1;
                        else return (T) (object) (ushort) 0;
                    }
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    var py = (int) (object) y;
                    var px = (int) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        int result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (int) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (int) 1;
                        else return (T) (object) (int) 0;
                    }
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    var py = (uint) (object) y;
                    var px = (uint) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        uint result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (uint) 1;
                        else return (T) (object) (uint) 0;
                    }
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    var py = (long) (object) y;
                    var px = (long) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        long result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (long) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (long) 1;
                        else return (T) (object) (long) 0;
                    }
                }

                return Complex(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x, T y)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Pow((Complex) (object) x, (Complex) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    var py = (ulong) (object) y;
                    var px = (ulong) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        ulong result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (ulong) 1;
                        else return (T) (object) (ulong) 0;
                    }
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <typeparam name="T">The type of <paramref name="y"/> and <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that -π ≤ θ ≤ π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane. Observe the following:
        /// <list type="bullet">
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 1, 0 &lt; θ &lt; π/2.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 2, π/2 &lt; θ ≤ π.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 3, -π &lt; θ &lt; -π/2.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 4, -π/2 &lt; θ &lt; 0.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description>If y is 0 and x is not negative, θ = 0.</description></item>
        /// <item><description>If y is 0 and x is negative, θ = π.</description></item>
        /// <item><description>If y is positive and x is 0, θ = π/2.</description></item>
        /// <item><description>If y is 0 and x is 0, θ = -π/2.</description></item>
        /// </list>
        /// If <paramref name="x"/> or <paramref name="y"/> is <see cref="Scalar{T}.NaN"/>, or if <paramref name="x"/> and <paramref name="y"/> are either <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        /// <remarks>
        /// The return value is the angle in the Cartesian plane formed by the x-axis, and a vector starting from the origin, (0,0), and terminating at the point, (x,y).
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Atan2<T>(T y, T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Atan2((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Atan2((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Atan2((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Atan2((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Atan2((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Atan2((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Atan2((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Atan2((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Atan2((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Atan2((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Atan2((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Atan2((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Atan2((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number nearest to <paramref name="x"/> that contains a number of fractional digits equal to digits.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="digits"/> is less than 0 or greater than the maximum number of integral and fractional digits supported by the <typeparamref name="T"/> type.</exception>
        /// <remarks>
        /// This method uses the default rounding convention of <see cref="MidpointRounding.ToEven"/>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if MATHF
                return (T) (object) (Half) (float) MathF.Round((float)(Half) (object) x, digits);
#else
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, digits);
#endif
            }

            return Float(x, digits);

            [MethodImpl(MaxOpt)]
            static T Float(T x, int digits)
            {
                if (typeof(T) == typeof(float))
                {
#if MATHF
                    return (T) (object) (float) MathF.Round((float)(object) x, digits);
#else
                    return (T) (object) (float) Math.Round((float) (object) x, digits);
#endif
                }

                return Double(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, int digits)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Round((double) (object) x, digits);
                }

                return Decimal(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, int digits)
            {
                if (typeof(T) == typeof(decimal))
                    ThrowOpUnsupportedPrecision();

                return Other(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T x, int digits)
            {
                if (typeof(T) == typeof(sbyte)
                || typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(long)
                )
                    return x;

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to a specified number of fractional digits, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <param name="mode">Specification for how to round <paramref name="x"/> if it is midway between two other numbers.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number nearest to <paramref name="x"/> that contains a number of fractional digits equal to digits. If <paramref name="x"/> has fewer fractional digits than <paramref name="digits"/>, <paramref name="x"/> is returned unchanged.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="digits"/> is less than 0 or greater than the maximum number of integral and fractional digits supported by the <typeparamref name="T"/> type.</exception>
        /// <remarks>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits, System.MidpointRounding mode) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if MATHF
                return (T) (object) (Half) (float) MathF.Round((float)(Half) (object) x, digits, mode);
#else
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, digits, mode);
#endif
            }

            return Float(x, digits, mode);

            [MethodImpl(MaxOpt)]
            static T Float(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(float))
                {
#if MATHF
                    return (T) (object) (float) MathF.Round((float)(object) x, digits, mode);
#else
                    return (T) (object) (float) Math.Round((float) (object) x, digits, mode);
#endif
                }

                return Double(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Round((double) (object) x, digits, mode);
                }

                return Decimal(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(decimal))
                    ThrowOpUnsupportedPrecision();

                return Other(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(sbyte)
                || typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(long)

                )
                    return x;

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to the nearest integer, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="x">A single-precision floating-point number to be rounded.</param>
        /// <param name="mode">Specification for how to round x if it is midway between two other numbers.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The integer nearest <paramref name="x"/>. If <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then mode determines which of the two is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type.</returns>
        /// <exception cref="ArgumentException"><paramref name="mode"/> is not a valid value of <see cref="MidpointRounding"/>.</exception>
        /// <remarks>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// \</remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, System.MidpointRounding mode) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, mode);
#else
                return (T) (object) (Half) MathF.Round((float) (Half) (object) x, mode);
#endif
            }

            return Float(x, mode);

            [MethodImpl(MaxOpt)]
            static T Float(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(float)Sse41.RoundToZeroScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(float)Sse41.RoundToPositiveInfinityScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(float)Sse41.RoundToNegativeInfinityScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(float)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(float)AdvSimd.RoundToZeroScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(float)AdvSimd.RoundToPositiveInfinityScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(float)AdvSimd.RoundToNegativeInfinityScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(float)AdvSimd.RoundToNearestScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if !MATHF
                    return (T) (object) (float) Math.Round((float) (object) x, mode);
#else
                    return (T) (object) MathF.Round((float) (object) x, mode);
#endif
                }

                return Double(x, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(double)Sse41.RoundToZeroScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(double)Sse41.RoundToPositiveInfinityScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(double)Sse41.RoundToNegativeInfinityScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(double)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(double)AdvSimd.RoundToZeroScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(double)AdvSimd.RoundToPositiveInfinityScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(double)AdvSimd.RoundToNegativeInfinityScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();

                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(double)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                    }
#endif
                    return (T) (object) (double) Math.Round((double) (object) x, mode);
                }

                return Decimal(x, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Round((decimal) (object) x, mode);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }
    }
}
