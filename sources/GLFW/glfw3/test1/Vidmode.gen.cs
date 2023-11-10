// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
namespace Silk.NET.GLFW;

[SupportedApiProfile("test1")]
public partial struct Vidmode
{
    [SupportedApiProfile("test1")]
    public int Width;

    [SupportedApiProfile("test1")]
    public int Height;

    [SupportedApiProfile("test1")]
    public int RedBits;

    [SupportedApiProfile("test1")]
    public int GreenBits;

    [SupportedApiProfile("test1")]
    public int BlueBits;

    [SupportedApiProfile("test1")]
    public int RefreshRate;
}
