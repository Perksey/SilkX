using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class PtrTests
{
    [Test]
    public void SingleStringUtf8()
    {
        PtrRef<byte, byte> thing = STR_1;
        string thingBack = (string)thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16()
    {
        PtrRef<char, char> thing = STR_1;
        string thingBack = (string)thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32()
    {
        PtrRef<uint, uint> thing = STR_1;
        string thingBack = (string)thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromByteArray()
    {
        PtrRef<byte, byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromSpan()
    {
        PtrRef<byte, byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0").AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromReadOnlySpan()
    {
        PtrRef<byte, byte> thing = (ReadOnlySpan<byte>) Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf8FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            PtrRef<byte, byte> thing = ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf16FromByteArray()
    {
        PtrRef<char, char> thing = STR_1.ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromSpan()
    {
        PtrRef<char, char> thing = STR_1.AsSpan().ToArray().AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromReadOnlySpan()
    {
        PtrRef<char, char> thing = (ReadOnlySpan<char>) STR_1;
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf16FromRawPointer()
    {
        fixed (byte* ptr = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            PtrRef<char, char> thing = (char*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf32FromByteArray()
    {
        PtrRef<uint, uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromSpan()
    {
        PtrRef<uint, uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromReadOnlySpan()
    {
        PtrRef<uint, uint> thing = (ReadOnlySpan<uint>)MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf32FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            PtrRef<uint, uint> thing = (uint*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void StringWithNonStringPointer()
    {
        nint dummy = 0x12345678;
        Assert.Throws<InvalidCastException>(() => _ = (PtrRef<nint, nint>)"Hello");
        Assert.Throws<InvalidCastException>(() => _ = (string)dummy.AsPtr());
    }

    [Test]
    public unsafe void NullIsNull()
    {
        PtrRef<nint, nint> ptr = nullptr;
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Ref)));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])));
        Assert.True((nint*) ptr is null);
        Assert.True((void*) ptr is null);
    }
}
