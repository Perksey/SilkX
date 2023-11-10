// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public unsafe partial interface IGlfw
{
    public partial interface Static<TSelf>
        where TSelf : Static<TSelf>
    {
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        static abstract Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static abstract Ptr<Cursor> CreateStandardCursor(int shape);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static abstract Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        static abstract void DefaultWindowHints();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static abstract void DestroyCursor(Ref<Cursor> cursor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static abstract void DestroyWindow(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static abstract int ExtensionSupported(
            [NativeTypeName("const char *")] Ref<sbyte> extension
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static abstract void FocusWindow(Ref<Window> window);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static abstract Ptr<sbyte> GetClipboardString(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static abstract Ptr<Window> GetCurrentContext();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static abstract void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static abstract int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static abstract void GetFramebufferSize(
            Ref<Window> window,
            Ref<int> width,
            Ref<int> height
        );

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static abstract Ptr<sbyte> GetGamepadName(int jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static abstract int GetGamepadState(int jid, Ref<Gamepadstate> state);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static abstract Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static abstract int GetInputMode(Ref<Window> window, int mode);

        [return: NativeTypeName("const float *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static abstract Ptr<float> GetJoystickAxes(int jid, Ref<int> count);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static abstract Ptr<byte> GetJoystickButtons(int jid, Ref<int> count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static abstract Ptr<sbyte> GetJoystickGuid(int jid);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static abstract Ptr<byte> GetJoystickHats(int jid, Ref<int> count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static abstract Ptr<sbyte> GetJoystickName(int jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static abstract Ptr GetJoystickUserPointer(int jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static abstract int GetKey(Ref<Window> window, int key);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static abstract Ptr<sbyte> GetKeyName(int key, int scancode);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        static abstract int GetKeyScancode(int key);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static abstract void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        );

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static abstract Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static abstract void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static abstract void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static abstract Ptr2D<Monitor> GetMonitors(Ref<int> count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static abstract Ptr GetMonitorUserPointer(Ref<Monitor> monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static abstract void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static abstract int GetMouseButton(Ref<Window> window, int button);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        static abstract int GetPlatform();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static abstract Ptr<Monitor> GetPrimaryMonitor();

        [return: NativeTypeName("GLFWglproc")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static abstract delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        );

        [return: NativeTypeName("const char **")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static abstract Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        static abstract double GetTime();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        static abstract ulong GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        static abstract ulong GetTimerValue();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static abstract void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static abstract Ptr<sbyte> GetVersionString();

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static abstract Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static abstract Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static abstract int GetWindowAttrib(Ref<Window> window, int attrib);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static abstract void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static abstract void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static abstract Ptr<Monitor> GetWindowMonitor(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static abstract float GetWindowOpacity(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static abstract void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static abstract void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static abstract Ptr GetWindowUserPointer(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static abstract void HideWindow(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static abstract void IconifyWindow(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        static abstract int Init();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static abstract void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        static abstract void InitHint(int hint, int value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        static abstract int JoystickIsGamepad(int jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        static abstract int JoystickPresent(int jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static abstract void MakeContextCurrent(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static abstract void MaximizeWindow(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        static abstract int PlatformSupported(int platform);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        static abstract void PollEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        static abstract void PostEmptyEvent();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        static abstract int RawMouseMotionSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static abstract void RequestWindowAttention(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static abstract void RestoreWindow(Ref<Window> window);

        [return: NativeTypeName("GLFWcharfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static abstract delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [return: NativeTypeName("GLFWcharmodsfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static abstract delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static abstract void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static abstract void SetCursor(Ref<Window> window, Ref<Cursor> cursor);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static abstract void SetCursorPos(Ref<Window> window, double xpos, double ypos);

        [return: NativeTypeName("GLFWcursorposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWdropfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static abstract delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [return: NativeTypeName("GLFWerrorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        static abstract delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static abstract void SetGamma(Ref<Monitor> monitor, float gamma);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static abstract void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static abstract void SetInputMode(Ref<Window> window, int mode, int value);

        [return: NativeTypeName("GLFWjoystickfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        static abstract delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static abstract void SetJoystickUserPointer(int jid, Ref pointer);

        [return: NativeTypeName("GLFWkeyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWmonitorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        static abstract delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static abstract void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWscrollfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        static abstract void SetTime(double time);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static abstract void SetWindowAspectRatio(Ref<Window> window, int numer, int denom);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static abstract void SetWindowAttrib(Ref<Window> window, int attrib, int value);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static abstract delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static abstract void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        );

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static abstract void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static abstract void SetWindowOpacity(Ref<Window> window, float opacity);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static abstract void SetWindowPos(Ref<Window> window, int xpos, int ypos);

        [return: NativeTypeName("GLFWwindowposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static abstract void SetWindowShouldClose(Ref<Window> window, int value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static abstract void SetWindowSize(Ref<Window> window, int width, int height);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static abstract void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static abstract void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static abstract void SetWindowUserPointer(Ref<Window> window, Ref pointer);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static abstract void ShowWindow(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static abstract void SwapBuffers(Ref<Window> window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        static abstract void SwapInterval(int interval);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        static abstract void Terminate();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static abstract int UpdateGamepadMappings(
            [NativeTypeName("const char *")] Ref<sbyte> @string
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        static abstract int VulkanSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        static abstract void WaitEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        static abstract void WaitEventsTimeout(double timeout);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        static abstract void WindowHint(int hint, int value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        static abstract void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static abstract int WindowShouldClose(Ref<Window> window);
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Ptr<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Ptr<Cursor> CreateStandardCursor(int shape);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Ptr<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        Ref<Monitor> monitor,
        Ref<Window> share
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    void DefaultWindowHints();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(Ref<Cursor> cursor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(Ref<Window> window);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    Ptr<sbyte> GetClipboardString(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Ptr<Window> GetCurrentContext();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    Ptr<sbyte> GetGamepadName(int jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, Ref<Gamepadstate> state);

    [return: NativeTypeName("const GLFWgammaramp *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(Ref<Window> window, int mode);

    [return: NativeTypeName("const float *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    Ptr<float> GetJoystickAxes(int jid, Ref<int> count);

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    Ptr<byte> GetJoystickButtons(int jid, Ref<int> count);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    Ptr<sbyte> GetJoystickGuid(int jid);

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    Ptr<byte> GetJoystickHats(int jid, Ref<int> count);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    Ptr<sbyte> GetJoystickName(int jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Ptr GetJoystickUserPointer(int jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(Ref<Window> window, int key);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    Ptr<sbyte> GetKeyName(int key, int scancode);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    int GetKeyScancode(int key);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(Ref<Monitor> monitor, Ref<float> xscale, Ref<float> yscale);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(Ref<Monitor> monitor, Ref<int> widthMM, Ref<int> heightMM);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Ptr2D<Monitor> GetMonitors(Ref<int> count);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Ptr GetMonitorUserPointer(Ref<Monitor> monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(
        Ref<Monitor> monitor,
        Ref<int> xpos,
        Ref<int> ypos,
        Ref<int> width,
        Ref<int> height
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(Ref<Window> window, int button);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    int GetPlatform();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Ptr<Monitor> GetPrimaryMonitor();

    [return: NativeTypeName("GLFWglproc")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress([NativeTypeName("const char *")] Ref<sbyte> procname);

    [return: NativeTypeName("const char **")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    Ptr2D<sbyte> GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Ref<uint> count);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    double GetTime();

    [return: NativeTypeName("uint64_t")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    ulong GetTimerFrequency();

    [return: NativeTypeName("uint64_t")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    ulong GetTimerValue();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    Ptr<sbyte> GetVersionString();

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor);

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(Ref<Window> window, int attrib);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(Ref<Window> window, Ref<float> xscale, Ref<float> yscale);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(
        Ref<Window> window,
        Ref<int> left,
        Ref<int> top,
        Ref<int> right,
        Ref<int> bottom
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Ptr<Monitor> GetWindowMonitor(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Ptr GetWindowUserPointer(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    int Init();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator([NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    void InitHint(int hint, int value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    int JoystickIsGamepad(int jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    int JoystickPresent(int jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    int PlatformSupported(int platform);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    void PollEvents();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    void PostEmptyEvent();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    int RawMouseMotionSupported();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(Ref<Window> window);

    [return: NativeTypeName("GLFWcharfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    );

    [return: NativeTypeName("GLFWcharmodsfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> @string
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(Ref<Window> window, Ref<Cursor> cursor);

    [return: NativeTypeName("GLFWcursorenterfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(Ref<Window> window, double xpos, double ypos);

    [return: NativeTypeName("GLFWcursorposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [return: NativeTypeName("GLFWdropfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    );

    [return: NativeTypeName("GLFWerrorfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(Ref<Monitor> monitor, float gamma);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(Ref<Window> window, int mode, int value);

    [return: NativeTypeName("GLFWjoystickfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, Ref pointer);

    [return: NativeTypeName("GLFWkeyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWmonitorfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer);

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWscrollfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    void SetTime(double time);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(Ref<Window> window, int numer, int denom);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(Ref<Window> window, int attrib, int value);

    [return: NativeTypeName("GLFWwindowclosefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    );

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    );

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    );

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        Ref<Window> window,
        Ref<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(Ref<Window> window, float opacity);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(Ref<Window> window, int xpos, int ypos);

    [return: NativeTypeName("GLFWwindowposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(Ref<Window> window, int value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(Ref<Window> window, int width, int height);

    [return: NativeTypeName("GLFWwindowsizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(Ref<Window> window, [NativeTypeName("const char *")] Ref<sbyte> title);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(Ref<Window> window, Ref pointer);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(Ref<Window> window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    void SwapInterval(int interval);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    void Terminate();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    int VulkanSupported();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    void WaitEvents();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    void WaitEventsTimeout(double timeout);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    void WindowHint(int hint, int value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(Ref<Window> window);
}
