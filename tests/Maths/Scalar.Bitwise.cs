// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class ScalarBitwiseTest
    {
        [Fact]
        public void RotateLeft1()
        {
            Assert.Equal((byte)0b1110_0001, IBinaryInteger<byte>.RotateLeft((byte)0b1111_0000, 1)); 
        }
        
        [Fact]
        public void RotateLeft2()
        {
            Assert.Equal((ushort)0b1100_1000_0000_0011, IBinaryInteger<ushort>.RotateLeft((ushort)0b1111_0010_0000_0000, 2)); 
        }
        
        [Fact]
        public void RotateRight1()
        {
            Assert.Equal((byte)0b1111_0000, IBinaryInteger<byte>.RotateRight((byte)0b1110_0001, 1)); 
        }
        
        [Fact]
        public void RotateRight2()
        {
            Assert.Equal((ushort)0b1111_0010_0000_0000, IBinaryInteger<ushort>.RotateRight((ushort)0b1100_1000_0000_0011, 2)); 
        }
        
        [Fact]
        public void And1()
        {
            Assert.Equal(0b1010, 0b1110 & 0b1011);
        }
        
        [Fact]
        public void And2()
        {
            Assert.Equal((byte)0b1010, (byte)((byte)0b1110 & (byte)0b1011));
        }
        
        [Fact]
        public void And3()
        {
            Assert.Equal((long)0b1010, (long)0b1110 & (long)0b1011);
        }
        
        [Fact]
        public void Or1()
        {
            Assert.Equal(0b1111, 0b1110 | 0b1011);
        }
        
        [Fact]
        public void Or2()
        {
            Assert.Equal((byte)0b1111, (byte)((byte)0b1110 | (byte)0b1011));
        }
        
        [Fact]
        public void Or3()
        {
            Assert.Equal((long)0b1111, (long)0b1110 | (long)0b1011);
        }
        
        [Fact]
        public void Xor1()
        {
            Assert.Equal(0b0101, 0b1110 ^ 0b1011);
        }
        
        [Fact]
        public void Xor2()
        {
            Assert.Equal((byte)0b0101, (byte)((byte)0b1110 ^ (byte)0b1011));
        }
        
        [Fact]
        public void Xor3()
        {
            Assert.Equal((long)0b0101, (long)0b1110 ^ (long)0b1011);
        }
        
        [Fact]
        public void Not1()
        {
            Assert.Equal(~0b1110, ~0b1110);
        }
        
        [Fact]
        public void Not2()
        {
            var b = ~(byte)0b1110;
            // ReSharper disable once IntVariableOverflowInUncheckedContext
            Assert.Equal((byte)b, (byte)~(byte)0b1110);
        }
        
        [Fact]
        public void Not3()
        {
            Assert.Equal(~(ulong)0b1110, ~(ulong)0b1110);
        }
    }
}