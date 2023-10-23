// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public unsafe partial interface IGlfw
{
    public partial interface Static
    {
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        static abstract Ptr<Cursor, Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> image,
            int xhot,
            int yhot
        );

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static abstract Ptr<Cursor, Cursor> CreateStandardCursor(int shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static abstract Ptr<Window, Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title,
            Ptr<Monitor, Monitor> monitor,
            Ptr<Window, Window> share
        );

        [NativeFunction("glfw", EntryPoint = "DefaultWindowHints")]
        static abstract void DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static abstract void DestroyCursor(Ptr<Cursor, Cursor> cursor);

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static abstract void DestroyWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static abstract int ExtensionSupported(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> extension
        );

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static abstract void FocusWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static abstract PtrToConst<sbyte, sbyte> GetClipboardString(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static abstract Ptr<Window, Window> GetCurrentContext();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static abstract void GetCursorPos(
            Ptr<Window, Window> window,
            Ptr<double, double> xpos,
            Ptr<double, double> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static abstract int GetError(
            [NativeTypeName("const char **")]
                PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> description
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static abstract void GetFramebufferSize(
            Ptr<Window, Window> window,
            Ptr<int, int> width,
            Ptr<int, int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static abstract PtrToConst<sbyte, sbyte> GetGamepadName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static abstract int GetGamepadState(int jid, Ptr<Gamepadstate, Gamepadstate> state);

        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static abstract PtrToConst<Gammaramp, Gammaramp> GetGammaRamp(
            Ptr<Monitor, Monitor> monitor
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static abstract int GetInputMode(Ptr<Window, Window> window, int mode);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static abstract PtrToConst<float, float> GetJoystickAxes(int jid, Ptr<int, int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static abstract PtrToConst<byte, byte> GetJoystickButtons(int jid, Ptr<int, int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static abstract PtrToConst<sbyte, sbyte> GetJoystickGuid(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static abstract PtrToConst<byte, byte> GetJoystickHats(int jid, Ptr<int, int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static abstract PtrToConst<sbyte, sbyte> GetJoystickName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static abstract Ptr GetJoystickUserPointer(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static abstract int GetKey(Ptr<Window, Window> window, int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static abstract PtrToConst<sbyte, sbyte> GetKeyName(int key, int scancode);

        [NativeFunction("glfw", EntryPoint = "GetKeyScancode")]
        static abstract int GetKeyScancode(int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static abstract void GetMonitorContentScale(
            Ptr<Monitor, Monitor> monitor,
            Ptr<float, float> xscale,
            Ptr<float, float> yscale
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static abstract PtrToConst<sbyte, sbyte> GetMonitorName(Ptr<Monitor, Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static abstract void GetMonitorPhysicalSize(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> widthMM,
            Ptr<int, int> heightMM
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static abstract void GetMonitorPos(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static abstract Ptr<Ptr<Monitor, Monitor>, Monitor> GetMonitors(Ptr<int, int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static abstract Ptr GetMonitorUserPointer(Ptr<Monitor, Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static abstract void GetMonitorWorkarea(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos,
            Ptr<int, int> width,
            Ptr<int, int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static abstract int GetMouseButton(Ptr<Window, Window> window, int button);

        [NativeFunction("glfw", EntryPoint = "GetPlatform")]
        static abstract int GetPlatform();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static abstract Ptr<Monitor, Monitor> GetPrimaryMonitor();

        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static abstract delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> procname
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static abstract PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ptr<uint, uint> count
        );

        [NativeFunction("glfw", EntryPoint = "GetTime")]
        static abstract double GetTime();

        [NativeFunction("glfw", EntryPoint = "GetTimerFrequency")]
        static abstract ulong GetTimerFrequency();

        [NativeFunction("glfw", EntryPoint = "GetTimerValue")]
        static abstract ulong GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static abstract void GetVersion(
            Ptr<int, int> major,
            Ptr<int, int> minor,
            Ptr<int, int> rev
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static abstract PtrToConst<sbyte, sbyte> GetVersionString();

        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static abstract PtrToConst<Vidmode, Vidmode> GetVideoMode(Ptr<Monitor, Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static abstract PtrToConst<Vidmode, Vidmode> GetVideoModes(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> count
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static abstract int GetWindowAttrib(Ptr<Window, Window> window, int attrib);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static abstract void GetWindowContentScale(
            Ptr<Window, Window> window,
            Ptr<float, float> xscale,
            Ptr<float, float> yscale
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static abstract void GetWindowFrameSize(
            Ptr<Window, Window> window,
            Ptr<int, int> left,
            Ptr<int, int> top,
            Ptr<int, int> right,
            Ptr<int, int> bottom
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static abstract Ptr<Monitor, Monitor> GetWindowMonitor(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static abstract float GetWindowOpacity(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static abstract void GetWindowPos(
            Ptr<Window, Window> window,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static abstract void GetWindowSize(
            Ptr<Window, Window> window,
            Ptr<int, int> width,
            Ptr<int, int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static abstract Ptr GetWindowUserPointer(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static abstract void HideWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static abstract void IconifyWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "Init")]
        static abstract int Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static abstract void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] PtrToConst<Allocator, Allocator> allocator
        );

        [NativeFunction("glfw", EntryPoint = "InitHint")]
        static abstract void InitHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "JoystickIsGamepad")]
        static abstract int JoystickIsGamepad(int jid);

        [NativeFunction("glfw", EntryPoint = "JoystickPresent")]
        static abstract int JoystickPresent(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static abstract void MakeContextCurrent(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static abstract void MaximizeWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "PlatformSupported")]
        static abstract int PlatformSupported(int platform);

        [NativeFunction("glfw", EntryPoint = "PollEvents")]
        static abstract void PollEvents();

        [NativeFunction("glfw", EntryPoint = "PostEmptyEvent")]
        static abstract void PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "RawMouseMotionSupported")]
        static abstract int RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static abstract void RequestWindowAttention(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static abstract void RestoreWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static abstract delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static abstract delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static abstract void SetClipboardString(
            Ptr<Window, Window> window,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static abstract void SetCursor(Ptr<Window, Window> window, Ptr<Cursor, Cursor> cursor);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static abstract void SetCursorPos(Ptr<Window, Window> window, double xpos, double ypos);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static abstract delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "SetErrorCallback")]
        static abstract delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static abstract void SetGamma(Ptr<Monitor, Monitor> monitor, float gamma);

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static abstract void SetGammaRamp(
            Ptr<Monitor, Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] PtrToConst<Gammaramp, Gammaramp> ramp
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static abstract void SetInputMode(Ptr<Window, Window> window, int mode, int value);

        [NativeFunction("glfw", EntryPoint = "SetJoystickCallback")]
        static abstract delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static abstract void SetJoystickUserPointer(int jid, Ptr pointer);

        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "SetMonitorCallback")]
        static abstract delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static abstract void SetMonitorUserPointer(Ptr<Monitor, Monitor> monitor, Ptr pointer);

        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "SetTime")]
        static abstract void SetTime(double time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static abstract void SetWindowAspectRatio(Ptr<Window, Window> window, int numer, int denom);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static abstract void SetWindowAttrib(Ptr<Window, Window> window, int attrib, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static abstract delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static abstract void SetWindowIcon(
            Ptr<Window, Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> images
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static abstract void SetWindowMonitor(
            Ptr<Window, Window> window,
            Ptr<Monitor, Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static abstract void SetWindowOpacity(Ptr<Window, Window> window, float opacity);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static abstract void SetWindowPos(Ptr<Window, Window> window, int xpos, int ypos);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static abstract void SetWindowShouldClose(Ptr<Window, Window> window, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static abstract void SetWindowSize(Ptr<Window, Window> window, int width, int height);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static abstract void SetWindowSizeLimits(
            Ptr<Window, Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static abstract void SetWindowTitle(
            Ptr<Window, Window> window,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static abstract void SetWindowUserPointer(Ptr<Window, Window> window, Ptr pointer);

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static abstract void ShowWindow(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static abstract void SwapBuffers(Ptr<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "SwapInterval")]
        static abstract void SwapInterval(int interval);

        [NativeFunction("glfw", EntryPoint = "Terminate")]
        static abstract void Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static abstract int UpdateGamepadMappings(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "VulkanSupported")]
        static abstract int VulkanSupported();

        [NativeFunction("glfw", EntryPoint = "WaitEvents")]
        static abstract void WaitEvents();

        [NativeFunction("glfw", EntryPoint = "WaitEventsTimeout")]
        static abstract void WaitEventsTimeout(double timeout);

        [NativeFunction("glfw", EntryPoint = "WindowHint")]
        static abstract void WindowHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        static abstract void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> value
        );

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static abstract int WindowShouldClose(Ptr<Window, Window> window);
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Ptr<Cursor, Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> image,
        int xhot,
        int yhot
    );

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Ptr<Cursor, Cursor> CreateStandardCursor(int shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Ptr<Window, Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title,
        Ptr<Monitor, Monitor> monitor,
        Ptr<Window, Window> share
    );

    [NativeFunction("glfw", EntryPoint = "DefaultWindowHints")]
    void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(Ptr<Cursor, Cursor> cursor);

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> extension);

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    PtrToConst<sbyte, sbyte> GetClipboardString(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Ptr<Window, Window> GetCurrentContext();

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(
        Ptr<Window, Window> window,
        Ptr<double, double> xpos,
        Ptr<double, double> ypos
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError(
        [NativeTypeName("const char **")] PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> description
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(Ptr<Window, Window> window, Ptr<int, int> width, Ptr<int, int> height);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    PtrToConst<sbyte, sbyte> GetGamepadName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, Ptr<Gamepadstate, Gamepadstate> state);

    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    PtrToConst<Gammaramp, Gammaramp> GetGammaRamp(Ptr<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(Ptr<Window, Window> window, int mode);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    PtrToConst<float, float> GetJoystickAxes(int jid, Ptr<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    PtrToConst<byte, byte> GetJoystickButtons(int jid, Ptr<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    PtrToConst<sbyte, sbyte> GetJoystickGuid(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    PtrToConst<byte, byte> GetJoystickHats(int jid, Ptr<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    PtrToConst<sbyte, sbyte> GetJoystickName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Ptr GetJoystickUserPointer(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(Ptr<Window, Window> window, int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    PtrToConst<sbyte, sbyte> GetKeyName(int key, int scancode);

    [NativeFunction("glfw", EntryPoint = "GetKeyScancode")]
    int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(
        Ptr<Monitor, Monitor> monitor,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    PtrToConst<sbyte, sbyte> GetMonitorName(Ptr<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> widthMM,
        Ptr<int, int> heightMM
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(Ptr<Monitor, Monitor> monitor, Ptr<int, int> xpos, Ptr<int, int> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Ptr<Ptr<Monitor, Monitor>, Monitor> GetMonitors(Ptr<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Ptr GetMonitorUserPointer(Ptr<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> xpos,
        Ptr<int, int> ypos,
        Ptr<int, int> width,
        Ptr<int, int> height
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(Ptr<Window, Window> window, int button);

    [NativeFunction("glfw", EntryPoint = "GetPlatform")]
    int GetPlatform();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Ptr<Monitor, Monitor> GetPrimaryMonitor();

    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> procname
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Ptr<uint, uint> count
    );

    [NativeFunction("glfw", EntryPoint = "GetTime")]
    double GetTime();

    [NativeFunction("glfw", EntryPoint = "GetTimerFrequency")]
    ulong GetTimerFrequency();

    [NativeFunction("glfw", EntryPoint = "GetTimerValue")]
    ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(Ptr<int, int> major, Ptr<int, int> minor, Ptr<int, int> rev);

    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    PtrToConst<sbyte, sbyte> GetVersionString();

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    PtrToConst<Vidmode, Vidmode> GetVideoMode(Ptr<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    PtrToConst<Vidmode, Vidmode> GetVideoModes(Ptr<Monitor, Monitor> monitor, Ptr<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(Ptr<Window, Window> window, int attrib);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(
        Ptr<Window, Window> window,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(
        Ptr<Window, Window> window,
        Ptr<int, int> left,
        Ptr<int, int> top,
        Ptr<int, int> right,
        Ptr<int, int> bottom
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Ptr<Monitor, Monitor> GetWindowMonitor(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(Ptr<Window, Window> window, Ptr<int, int> xpos, Ptr<int, int> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(Ptr<Window, Window> window, Ptr<int, int> width, Ptr<int, int> height);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Ptr GetWindowUserPointer(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "Init")]
    int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] PtrToConst<Allocator, Allocator> allocator
    );

    [NativeFunction("glfw", EntryPoint = "InitHint")]
    void InitHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "JoystickIsGamepad")]
    int JoystickIsGamepad(int jid);

    [NativeFunction("glfw", EntryPoint = "JoystickPresent")]
    int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "PlatformSupported")]
    int PlatformSupported(int platform);

    [NativeFunction("glfw", EntryPoint = "PollEvents")]
    void PollEvents();

    [NativeFunction("glfw", EntryPoint = "PostEmptyEvent")]
    void PostEmptyEvent();

    [NativeFunction("glfw", EntryPoint = "RawMouseMotionSupported")]
    int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(Ptr<Window, Window> window, Ptr<Cursor, Cursor> cursor);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(Ptr<Window, Window> window, double xpos, double ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "SetErrorCallback")]
    delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(Ptr<Monitor, Monitor> monitor, float gamma);

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(
        Ptr<Monitor, Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] PtrToConst<Gammaramp, Gammaramp> ramp
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(Ptr<Window, Window> window, int mode, int value);

    [NativeFunction("glfw", EntryPoint = "SetJoystickCallback")]
    delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, Ptr pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "SetMonitorCallback")]
    delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(Ptr<Monitor, Monitor> monitor, Ptr pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "SetTime")]
    void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(Ptr<Window, Window> window, int numer, int denom);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(Ptr<Window, Window> window, int attrib, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        Ptr<Window, Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> images
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        Ptr<Window, Window> window,
        Ptr<Monitor, Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(Ptr<Window, Window> window, float opacity);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(Ptr<Window, Window> window, int xpos, int ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(Ptr<Window, Window> window, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(Ptr<Window, Window> window, int width, int height);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        Ptr<Window, Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(Ptr<Window, Window> window, Ptr pointer);

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(Ptr<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "SwapInterval")]
    void SwapInterval(int interval);

    [NativeFunction("glfw", EntryPoint = "Terminate")]
    void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string);

    [NativeFunction("glfw", EntryPoint = "VulkanSupported")]
    int VulkanSupported();

    [NativeFunction("glfw", EntryPoint = "WaitEvents")]
    void WaitEvents();

    [NativeFunction("glfw", EntryPoint = "WaitEventsTimeout")]
    void WaitEventsTimeout(double timeout);

    [NativeFunction("glfw", EntryPoint = "WindowHint")]
    void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(
        int hint,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> value
    );

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(Ptr<Window, Window> window);
}
