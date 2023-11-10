namespace Silk.NET.GLFW;

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;

[SupportedApiProfile("test1")]
[SupportedApiProfile("test2")]
public unsafe partial struct Gammaramp
{
    [NativeTypeName("unsigned short *")]
    [SupportedApiProfile("test2")]
    [SupportedApiProfile("test1")]
    public ushort* Red;

    [NativeTypeName("unsigned short *")]
    [SupportedApiProfile("test2")]
    [SupportedApiProfile("test1")]
    public ushort* Green;

    [NativeTypeName("unsigned short *")]
    [SupportedApiProfile("test2")]
    [SupportedApiProfile("test1")]
    public ushort* Blue;

    [NativeTypeName("unsigned int")]
    [SupportedApiProfile("test2")]
    [SupportedApiProfile("test1")]
    public uint Size;
}
