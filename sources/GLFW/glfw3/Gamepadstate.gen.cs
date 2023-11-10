namespace Silk.NET.GLFW;

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;

[SupportedApiProfile("test1")]
public unsafe partial struct Gamepadstate
{
    [NativeTypeName("unsigned char[15]")]
    [SupportedApiProfile("test1")]
    public fixed byte Buttons[15];

    [NativeTypeName("float[6]")]
    [SupportedApiProfile("test1")]
    public fixed float Axes[6];
}
