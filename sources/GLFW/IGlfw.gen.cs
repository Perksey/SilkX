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
        static abstract PtrRef<Cursor, Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] PtrRefToConst<Image, Image> image,
            int xhot,
            int yhot
        );

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static abstract PtrRef<Cursor, Cursor> CreateStandardCursor(int shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static abstract PtrRef<Window, Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> title,
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<Window, Window> share
        );

        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        static abstract void DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static abstract void DestroyCursor(PtrRef<Cursor, Cursor> cursor);

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static abstract void DestroyWindow(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static abstract int ExtensionSupported(
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> extension
        );

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static abstract void FocusWindow(PtrRef<Window, Window> window);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static abstract PtrRefToConst<sbyte, sbyte> GetClipboardString(
            PtrRef<Window, Window> window
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static abstract PtrRef<Window, Window> GetCurrentContext();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static abstract void GetCursorPos(
            PtrRef<Window, Window> window,
            PtrRef<double, double> xpos,
            PtrRef<double, double> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static abstract int GetError(
            [NativeTypeName("const char **")]
                PtrRefToConst<PtrToConst<sbyte, sbyte>, sbyte> description
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static abstract void GetFramebufferSize(
            PtrRef<Window, Window> window,
            PtrRef<int, int> width,
            PtrRef<int, int> height
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static abstract PtrRefToConst<sbyte, sbyte> GetGamepadName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static abstract int GetGamepadState(int jid, PtrRef<Gamepadstate, Gamepadstate> state);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static abstract PtrRefToConst<Gammaramp, Gammaramp> GetGammaRamp(
            PtrRef<Monitor, Monitor> monitor
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static abstract int GetInputMode(PtrRef<Window, Window> window, int mode);

        [return: NativeTypeName("const float *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static abstract PtrRefToConst<float, float> GetJoystickAxes(
            int jid,
            PtrRef<int, int> count
        );

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static abstract PtrRefToConst<byte, byte> GetJoystickButtons(
            int jid,
            PtrRef<int, int> count
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static abstract PtrRefToConst<sbyte, sbyte> GetJoystickGuid(int jid);

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static abstract PtrRefToConst<byte, byte> GetJoystickHats(int jid, PtrRef<int, int> count);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static abstract PtrRefToConst<sbyte, sbyte> GetJoystickName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static abstract PtrRef GetJoystickUserPointer(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static abstract int GetKey(PtrRef<Window, Window> window, int key);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static abstract PtrRefToConst<sbyte, sbyte> GetKeyName(int key, int scancode);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        static abstract int GetKeyScancode(int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static abstract void GetMonitorContentScale(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<float, float> xscale,
            PtrRef<float, float> yscale
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static abstract PtrRefToConst<sbyte, sbyte> GetMonitorName(
            PtrRef<Monitor, Monitor> monitor
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static abstract void GetMonitorPhysicalSize(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<int, int> widthMM,
            PtrRef<int, int> heightMM
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static abstract void GetMonitorPos(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<int, int> xpos,
            PtrRef<int, int> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static abstract PtrRef<Ptr<Monitor, Monitor>, Monitor> GetMonitors(PtrRef<int, int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static abstract PtrRef GetMonitorUserPointer(PtrRef<Monitor, Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static abstract void GetMonitorWorkarea(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<int, int> xpos,
            PtrRef<int, int> ypos,
            PtrRef<int, int> width,
            PtrRef<int, int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static abstract int GetMouseButton(PtrRef<Window, Window> window, int button);

        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        static abstract int GetPlatform();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static abstract PtrRef<Monitor, Monitor> GetPrimaryMonitor();

        [return: NativeTypeName("GLFWglproc")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static abstract delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> procname
        );

        [return: NativeTypeName("const char **")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static abstract PtrRefToConst<
            PtrToConst<sbyte, sbyte>,
            sbyte
        > GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] PtrRef<uint, uint> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        static abstract double GetTime();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        static abstract ulong GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        static abstract ulong GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static abstract void GetVersion(
            PtrRef<int, int> major,
            PtrRef<int, int> minor,
            PtrRef<int, int> rev
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static abstract PtrRefToConst<sbyte, sbyte> GetVersionString();

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static abstract PtrRefToConst<Vidmode, Vidmode> GetVideoMode(
            PtrRef<Monitor, Monitor> monitor
        );

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static abstract PtrRefToConst<Vidmode, Vidmode> GetVideoModes(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef<int, int> count
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static abstract int GetWindowAttrib(PtrRef<Window, Window> window, int attrib);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static abstract void GetWindowContentScale(
            PtrRef<Window, Window> window,
            PtrRef<float, float> xscale,
            PtrRef<float, float> yscale
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static abstract void GetWindowFrameSize(
            PtrRef<Window, Window> window,
            PtrRef<int, int> left,
            PtrRef<int, int> top,
            PtrRef<int, int> right,
            PtrRef<int, int> bottom
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static abstract PtrRef<Monitor, Monitor> GetWindowMonitor(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static abstract float GetWindowOpacity(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static abstract void GetWindowPos(
            PtrRef<Window, Window> window,
            PtrRef<int, int> xpos,
            PtrRef<int, int> ypos
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static abstract void GetWindowSize(
            PtrRef<Window, Window> window,
            PtrRef<int, int> width,
            PtrRef<int, int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static abstract PtrRef GetWindowUserPointer(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static abstract void HideWindow(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static abstract void IconifyWindow(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        static abstract int Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static abstract void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] PtrRefToConst<Allocator, Allocator> allocator
        );

        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        static abstract void InitHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        static abstract int JoystickIsGamepad(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        static abstract int JoystickPresent(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static abstract void MakeContextCurrent(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static abstract void MaximizeWindow(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        static abstract int PlatformSupported(int platform);

        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        static abstract void PollEvents();

        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        static abstract void PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        static abstract int RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static abstract void RequestWindowAttention(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static abstract void RestoreWindow(PtrRef<Window, Window> window);

        [return: NativeTypeName("GLFWcharfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static abstract delegate* unmanaged<Window*, uint, void> SetCharCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [return: NativeTypeName("GLFWcharmodsfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static abstract delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static abstract void SetClipboardString(
            PtrRef<Window, Window> window,
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static abstract void SetCursor(
            PtrRef<Window, Window> window,
            PtrRef<Cursor, Cursor> cursor
        );

        [return: NativeTypeName("GLFWcursorenterfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static abstract void SetCursorPos(PtrRef<Window, Window> window, double xpos, double ypos);

        [return: NativeTypeName("GLFWcursorposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWdropfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static abstract delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [return: NativeTypeName("GLFWerrorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        static abstract delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static abstract void SetGamma(PtrRef<Monitor, Monitor> monitor, float gamma);

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static abstract void SetGammaRamp(
            PtrRef<Monitor, Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] PtrRefToConst<Gammaramp, Gammaramp> ramp
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static abstract void SetInputMode(PtrRef<Window, Window> window, int mode, int value);

        [return: NativeTypeName("GLFWjoystickfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        static abstract delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static abstract void SetJoystickUserPointer(int jid, PtrRef pointer);

        [return: NativeTypeName("GLFWkeyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWmonitorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        static abstract delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static abstract void SetMonitorUserPointer(
            PtrRef<Monitor, Monitor> monitor,
            PtrRef pointer
        );

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWscrollfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        static abstract void SetTime(double time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static abstract void SetWindowAspectRatio(
            PtrRef<Window, Window> window,
            int numer,
            int denom
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static abstract void SetWindowAttrib(PtrRef<Window, Window> window, int attrib, int value);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static abstract delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static abstract void SetWindowIcon(
            PtrRef<Window, Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] PtrRefToConst<Image, Image> images
        );

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static abstract void SetWindowMonitor(
            PtrRef<Window, Window> window,
            PtrRef<Monitor, Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static abstract void SetWindowOpacity(PtrRef<Window, Window> window, float opacity);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static abstract void SetWindowPos(PtrRef<Window, Window> window, int xpos, int ypos);

        [return: NativeTypeName("GLFWwindowposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static abstract void SetWindowShouldClose(PtrRef<Window, Window> window, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static abstract void SetWindowSize(PtrRef<Window, Window> window, int width, int height);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            PtrRef<Window, Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static abstract void SetWindowSizeLimits(
            PtrRef<Window, Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static abstract void SetWindowTitle(
            PtrRef<Window, Window> window,
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> title
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static abstract void SetWindowUserPointer(PtrRef<Window, Window> window, PtrRef pointer);

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static abstract void ShowWindow(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static abstract void SwapBuffers(PtrRef<Window, Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        static abstract void SwapInterval(int interval);

        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        static abstract void Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static abstract int UpdateGamepadMappings(
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        static abstract int VulkanSupported();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        static abstract void WaitEvents();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        static abstract void WaitEventsTimeout(double timeout);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        static abstract void WindowHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        static abstract void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> value
        );

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static abstract int WindowShouldClose(PtrRef<Window, Window> window);
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    PtrRef<Cursor, Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] PtrRefToConst<Image, Image> image,
        int xhot,
        int yhot
    );

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    PtrRef<Cursor, Cursor> CreateStandardCursor(int shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    PtrRef<Window, Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> title,
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<Window, Window> share
    );

    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(PtrRef<Cursor, Cursor> cursor);

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> extension);

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(PtrRef<Window, Window> window);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    PtrRefToConst<sbyte, sbyte> GetClipboardString(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    PtrRef<Window, Window> GetCurrentContext();

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(
        PtrRef<Window, Window> window,
        PtrRef<double, double> xpos,
        PtrRef<double, double> ypos
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError(
        [NativeTypeName("const char **")] PtrRefToConst<PtrToConst<sbyte, sbyte>, sbyte> description
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(
        PtrRef<Window, Window> window,
        PtrRef<int, int> width,
        PtrRef<int, int> height
    );

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    PtrRefToConst<sbyte, sbyte> GetGamepadName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, PtrRef<Gamepadstate, Gamepadstate> state);

    [return: NativeTypeName("const GLFWgammaramp *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    PtrRefToConst<Gammaramp, Gammaramp> GetGammaRamp(PtrRef<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(PtrRef<Window, Window> window, int mode);

    [return: NativeTypeName("const float *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    PtrRefToConst<float, float> GetJoystickAxes(int jid, PtrRef<int, int> count);

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    PtrRefToConst<byte, byte> GetJoystickButtons(int jid, PtrRef<int, int> count);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    PtrRefToConst<sbyte, sbyte> GetJoystickGuid(int jid);

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    PtrRefToConst<byte, byte> GetJoystickHats(int jid, PtrRef<int, int> count);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    PtrRefToConst<sbyte, sbyte> GetJoystickName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    PtrRef GetJoystickUserPointer(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(PtrRef<Window, Window> window, int key);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    PtrRefToConst<sbyte, sbyte> GetKeyName(int key, int scancode);

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<float, float> xscale,
        PtrRef<float, float> yscale
    );

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    PtrRefToConst<sbyte, sbyte> GetMonitorName(PtrRef<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<int, int> widthMM,
        PtrRef<int, int> heightMM
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<int, int> xpos,
        PtrRef<int, int> ypos
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    PtrRef<Ptr<Monitor, Monitor>, Monitor> GetMonitors(PtrRef<int, int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    PtrRef GetMonitorUserPointer(PtrRef<Monitor, Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<int, int> xpos,
        PtrRef<int, int> ypos,
        PtrRef<int, int> width,
        PtrRef<int, int> height
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(PtrRef<Window, Window> window, int button);

    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    int GetPlatform();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    PtrRef<Monitor, Monitor> GetPrimaryMonitor();

    [return: NativeTypeName("GLFWglproc")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> procname
    );

    [return: NativeTypeName("const char **")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    PtrRefToConst<PtrToConst<sbyte, sbyte>, sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] PtrRef<uint, uint> count
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    double GetTime();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    ulong GetTimerFrequency();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(PtrRef<int, int> major, PtrRef<int, int> minor, PtrRef<int, int> rev);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    PtrRefToConst<sbyte, sbyte> GetVersionString();

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    PtrRefToConst<Vidmode, Vidmode> GetVideoMode(PtrRef<Monitor, Monitor> monitor);

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    PtrRefToConst<Vidmode, Vidmode> GetVideoModes(
        PtrRef<Monitor, Monitor> monitor,
        PtrRef<int, int> count
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(PtrRef<Window, Window> window, int attrib);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(
        PtrRef<Window, Window> window,
        PtrRef<float, float> xscale,
        PtrRef<float, float> yscale
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(
        PtrRef<Window, Window> window,
        PtrRef<int, int> left,
        PtrRef<int, int> top,
        PtrRef<int, int> right,
        PtrRef<int, int> bottom
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    PtrRef<Monitor, Monitor> GetWindowMonitor(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(PtrRef<Window, Window> window, PtrRef<int, int> xpos, PtrRef<int, int> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(
        PtrRef<Window, Window> window,
        PtrRef<int, int> width,
        PtrRef<int, int> height
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    PtrRef GetWindowUserPointer(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] PtrRefToConst<Allocator, Allocator> allocator
    );

    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    void InitHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    int JoystickIsGamepad(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    int PlatformSupported(int platform);

    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    void PollEvents();

    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    void PostEmptyEvent();

    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(PtrRef<Window, Window> window);

    [return: NativeTypeName("GLFWcharfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    );

    [return: NativeTypeName("GLFWcharmodsfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(
        PtrRef<Window, Window> window,
        [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> @string
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(PtrRef<Window, Window> window, PtrRef<Cursor, Cursor> cursor);

    [return: NativeTypeName("GLFWcursorenterfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(PtrRef<Window, Window> window, double xpos, double ypos);

    [return: NativeTypeName("GLFWcursorposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [return: NativeTypeName("GLFWdropfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    );

    [return: NativeTypeName("GLFWerrorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(PtrRef<Monitor, Monitor> monitor, float gamma);

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(
        PtrRef<Monitor, Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] PtrRefToConst<Gammaramp, Gammaramp> ramp
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(PtrRef<Window, Window> window, int mode, int value);

    [return: NativeTypeName("GLFWjoystickfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, PtrRef pointer);

    [return: NativeTypeName("GLFWkeyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWmonitorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(PtrRef<Monitor, Monitor> monitor, PtrRef pointer);

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWscrollfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(PtrRef<Window, Window> window, int numer, int denom);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(PtrRef<Window, Window> window, int attrib, int value);

    [return: NativeTypeName("GLFWwindowclosefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    );

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    );

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        PtrRef<Window, Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] PtrRefToConst<Image, Image> images
    );

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        PtrRef<Window, Window> window,
        PtrRef<Monitor, Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(PtrRef<Window, Window> window, float opacity);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(PtrRef<Window, Window> window, int xpos, int ypos);

    [return: NativeTypeName("GLFWwindowposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(PtrRef<Window, Window> window, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(PtrRef<Window, Window> window, int width, int height);

    [return: NativeTypeName("GLFWwindowsizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        PtrRef<Window, Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        PtrRef<Window, Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(
        PtrRef<Window, Window> window,
        [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> title
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(PtrRef<Window, Window> window, PtrRef pointer);

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(PtrRef<Window, Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    void SwapInterval(int interval);

    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> @string);

    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    int VulkanSupported();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    void WaitEvents();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    void WaitEventsTimeout(double timeout);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(
        int hint,
        [NativeTypeName("const char *")] PtrRefToConst<sbyte, sbyte> value
    );

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(PtrRef<Window, Window> window);
}
