// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
// ReSharper disable CompareOfFloatsByEqualityOperator

// casting into non-nullable, unboxing from nullable
#pragma warning disable 8600
#pragma warning disable 8605

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        internal const MethodImplOptions MaxOpt = MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512;

        internal static void ThrowUnsupportedType()
            => throw new NotSupportedException("The given type is unsupported for generic maths.");

        internal static void ThrowOpUnsupportedType()
            => throw new NotSupportedException("This operation is not applicable for the given type.");

        internal static void ThrowOpUnsupportedPrecision()
            => throw new NotImplementedException
            (
                "This operation is not applicable for the given type due to a high-enough precision algorithm not " +
                "being available."
            );

        private static void ThrowIndexOutOfRange() => throw new IndexOutOfRangeException();

        /// <summary>
        /// Indicates whether members are hardware accelerated. Not all members support hardware acceleration.
        /// </summary>
        public static bool IsHardwareAccelerated => false
#if SSE
        || Sse.IsSupported
#endif
#if AdvSIMD
        || AdvSimd.IsSupported
#endif
        ;

        /// <summary>
        /// Determines whether the specified value is finite (zero, subnormal, or normal).
        /// </summary>
        /// <param name="f">A number.</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is finite (zero, subnormal or normal); <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsFinite<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsFinite(f);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsInfinity<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsInfinity(f);
        }

        /// <summary>
        /// Returns a value that indicates whether the specified value is not a number (<see cref="Scalar{T}.NaN"/>).
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.NaN"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNaN<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsNaN(f);
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is negative; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNegative<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsNegative(f);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.NegativeInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNegativeInfinity<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsNegativeInfinity(f);
        }

        /// <summary>
        /// Determines whether the specified value is normal.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is normal; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNormal<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsNormal(f);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.PositiveInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsPositiveInfinity<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsPositiveInfinity(f);
        }

        /// <summary>
        /// Determines whether the specified value is subnormal.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is subnormal; <code>false</code> otherwise.</returns>
        /// <remarks>This function will throw for types other then <see cref="Half"/>, <see cref="float"/>, <see cref="double"/>, because subnormality cannot be determined for other types.</remarks>
        [MethodImpl(MaxOpt)]
        public static bool IsSubnormal<T>(T f) where T : notnull, INumberBase<T>
        {
            return T.IsSubnormal(f);
        }

        /// <summary>
        /// Returns a value that indicates whether two specified values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool Equal<T>(T left, T right) where T : notnull,  IEqualityOperators<T, T, bool>
        {
            return left == right;
        }

        /// <summary>
        /// Returns a value that indicates whether two specified values are not equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool NotEqual<T>(T left, T right) where T : notnull, IEqualityOperators<T, T, bool>
        {
            return left != right;
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is greater than another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool GreaterThan<T>(T left, T right) where T : notnull, IComparisonOperators<T, T, bool>
        {
            return left > right;
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is greater than or equal to another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool GreaterThanOrEqual<T>(T left, T right) where T : notnull, IComparisonOperators<T, T, bool>
        {
            return left >= right;
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is less than another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is less than <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool LessThan<T>(T left, T right) where T : notnull, IComparisonOperators<T, T, bool>
        {
            return left < right;
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is less than or equal to another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool LessThanOrEqual<T>(T left, T right) where T : notnull, IComparisonOperators<T, T, bool>
        {
            return left <= right;
        }

        /// <summary>
        /// Adds two specified values.
        /// </summary>
        /// <param name="left">The first value to add.</param>
        /// <param name="right">The second value to add.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Add<T>(T left, T right) where T : notnull, IAdditionOperators<T, T, T>
        {
            return left + right;


        }

        /// <summary>
        /// Subtracts two specified values.
        /// </summary>
        /// <param name="left">The minuend.</param>
        /// <param name="right">The subtrahend.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of subtracting <paramref name="left"/> from <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Subtract<T>(T left, T right) where T : notnull, ISubtractionOperators<T, T, T>
        {
            return left - right;
        }

        /// <summary>
        /// Multiplies two specified values.
        /// </summary>
        /// <param name="left">The first value to multiply.</param>
        /// <param name="right">The second value to multiply.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Multiply<T>(T left, T right) where T : notnull, IMultiplyOperators<T, T, T>
        {
            return left * right;
        }

        /// <summary>
        /// Divides two specified values.
        /// </summary>
        /// <param name="left">The dividend.</param>
        /// <param name="right">The divisor.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of dividing <paramref name="left"/> by <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Divide<T>(T left, T right) where T : notnull, IDivisionOperators<T, T, T>
        {
            return left / right;
        }

        /// <summary>
        /// Returns the result of multiplying the specified value by negative one.
        /// </summary>
        /// <param name="x">The value to negate</param>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <returns>
        /// A number with the value of <paramref name="x"/>, but the opposite sign.
        /// -or-
        /// Zero, if <paramref name="x"/> is zero.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Negate<T>(T x)
            where T : notnull, IUnaryNegationOperators<T, T> => -x;
    }
}
