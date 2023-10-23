// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public unsafe partial class Glfw : IGlfw, IGlfw.Static
{
    public partial class DllImport : IGlfw.Static
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Ptr<Cursor, Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> image,
            int xhot,
            int yhot
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
            static extern Cursor* __DSL_glfwCreateCursor(
                [NativeTypeName("const GLFWimage *")] Image* image,
                int xhot,
                int yhot
            );
            Cursor* ret = __DSL_glfwCreateCursor(image, xhot, yhot);
            image.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public static Ptr<Cursor, Cursor> CreateStandardCursor(int shape)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
            static extern Cursor* __DSL_glfwCreateStandardCursor(int shape);
            Cursor* ret = __DSL_glfwCreateStandardCursor(shape);
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Ptr<Window, Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title,
            Ptr<Monitor, Monitor> monitor,
            Ptr<Window, Window> share
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
            static extern Window* __DSL_glfwCreateWindow(
                int width,
                int height,
                [NativeTypeName("const char *")] sbyte* title,
                Monitor* monitor,
                Window* share
            );
            Window* ret = __DSL_glfwCreateWindow(width, height, title, monitor, share);
            title.Dispose();
            monitor.Dispose();
            share.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void DefaultWindowHints();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Ptr<Cursor, Cursor> cursor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
            static extern void __DSL_glfwDestroyCursor(Cursor* cursor);
            __DSL_glfwDestroyCursor(cursor);
            cursor.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
            static extern void __DSL_glfwDestroyWindow(Window* window);
            __DSL_glfwDestroyWindow(window);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> extension
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
            static extern int __DSL_glfwExtensionSupported(
                [NativeTypeName("const char *")] sbyte* extension
            );
            int ret = __DSL_glfwExtensionSupported(extension);
            extension.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
            static extern void __DSL_glfwFocusWindow(Window* window);
            __DSL_glfwFocusWindow(window);
            window.Dispose();
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static PtrToConst<sbyte, sbyte> GetClipboardString(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetClipboardString(Window* window);
            sbyte* ret = __DSL_glfwGetClipboardString(window);
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Ptr<Window, Window> GetCurrentContext()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
            static extern Window* __DSL_glfwGetCurrentContext();
            Window* ret = __DSL_glfwGetCurrentContext();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(
            Ptr<Window, Window> window,
            Ptr<double, double> xpos,
            Ptr<double, double> ypos
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
            static extern void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos);
            __DSL_glfwGetCursorPos(window, xpos, ypos);
            window.Dispose();
            xpos.Dispose();
            ypos.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError(
            [NativeTypeName("const char **")]
                PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> description
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
            static extern int __DSL_glfwGetError(
                [NativeTypeName("const char **")] sbyte** description
            );
            int ret = __DSL_glfwGetError(description);
            description.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(
            Ptr<Window, Window> window,
            Ptr<int, int> width,
            Ptr<int, int> height
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
            static extern void __DSL_glfwGetFramebufferSize(
                Window* window,
                int* width,
                int* height
            );
            __DSL_glfwGetFramebufferSize(window, width, height);
            window.Dispose();
            width.Dispose();
            height.Dispose();
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public static PtrToConst<sbyte, sbyte> GetGamepadName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetGamepadName(int jid);
            sbyte* ret = __DSL_glfwGetGamepadName(jid);
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Ptr<Gamepadstate, Gamepadstate> state)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
            static extern int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state);
            int ret = __DSL_glfwGetGamepadState(jid, state);
            state.Dispose();
            return ret;
        }

        [return: NativeTypeName("const GLFWgammaramp *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static PtrToConst<Gammaramp, Gammaramp> GetGammaRamp(Ptr<Monitor, Monitor> monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
            [return: NativeTypeName("const GLFWgammaramp *")]
            static extern Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor);
            Gammaramp* ret = __DSL_glfwGetGammaRamp(monitor);
            monitor.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Ptr<Window, Window> window, int mode)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
            static extern int __DSL_glfwGetInputMode(Window* window, int mode);
            int ret = __DSL_glfwGetInputMode(window, mode);
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("const float *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static PtrToConst<float, float> GetJoystickAxes(int jid, Ptr<int, int> count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
            [return: NativeTypeName("const float *")]
            static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
            float* ret = __DSL_glfwGetJoystickAxes(jid, count);
            count.Dispose();
            return ret;
        }

        [return: NativeTypeName("const unsigned char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static PtrToConst<byte, byte> GetJoystickButtons(int jid, Ptr<int, int> count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
            byte* ret = __DSL_glfwGetJoystickButtons(jid, count);
            count.Dispose();
            return ret;
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static PtrToConst<sbyte, sbyte> GetJoystickGuid(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
            sbyte* ret = __DSL_glfwGetJoystickGUID(jid);
            return ret;
        }

        [return: NativeTypeName("const unsigned char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static PtrToConst<byte, byte> GetJoystickHats(int jid, Ptr<int, int> count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
            byte* ret = __DSL_glfwGetJoystickHats(jid, count);
            count.Dispose();
            return ret;
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static PtrToConst<sbyte, sbyte> GetJoystickName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetJoystickName(int jid);
            sbyte* ret = __DSL_glfwGetJoystickName(jid);
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static Ptr GetJoystickUserPointer(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
            static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
            void* ret = __DSL_glfwGetJoystickUserPointer(jid);
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Ptr<Window, Window> window, int key)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
            static extern int __DSL_glfwGetKey(Window* window, int key);
            int ret = __DSL_glfwGetKey(window, key);
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static PtrToConst<sbyte, sbyte> GetKeyName(int key, int scancode)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
            sbyte* ret = __DSL_glfwGetKeyName(key, scancode);
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int GetKeyScancode(int key);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(
            Ptr<Monitor, Monitor> monitor,
            Ptr<float, float> xscale,
            Ptr<float, float> yscale
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
            static extern void __DSL_glfwGetMonitorContentScale(
                Monitor* monitor,
                float* xscale,
                float* yscale
            );
            __DSL_glfwGetMonitorContentScale(monitor, xscale, yscale);
            monitor.Dispose();
            xscale.Dispose();
            yscale.Dispose();
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public static PtrToConst<sbyte, sbyte> GetMonitorName(Ptr<Monitor, Monitor> monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetMonitorName(Monitor* monitor);
            sbyte* ret = __DSL_glfwGetMonitorName(monitor);
            monitor.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> widthMM,
            Ptr<int, int> heightMM
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
            static extern void __DSL_glfwGetMonitorPhysicalSize(
                Monitor* monitor,
                int* widthMM,
                int* heightMM
            );
            __DSL_glfwGetMonitorPhysicalSize(monitor, widthMM, heightMM);
            monitor.Dispose();
            widthMM.Dispose();
            heightMM.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
            static extern void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos);
            __DSL_glfwGetMonitorPos(monitor, xpos, ypos);
            monitor.Dispose();
            xpos.Dispose();
            ypos.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static Ptr<Ptr<Monitor, Monitor>, Monitor> GetMonitors(Ptr<int, int> count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
            static extern Monitor** __DSL_glfwGetMonitors(int* count);
            Monitor** ret = __DSL_glfwGetMonitors(count);
            count.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static Ptr GetMonitorUserPointer(Ptr<Monitor, Monitor> monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
            static extern void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor);
            void* ret = __DSL_glfwGetMonitorUserPointer(monitor);
            monitor.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos,
            Ptr<int, int> width,
            Ptr<int, int> height
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
            static extern void __DSL_glfwGetMonitorWorkarea(
                Monitor* monitor,
                int* xpos,
                int* ypos,
                int* width,
                int* height
            );
            __DSL_glfwGetMonitorWorkarea(monitor, xpos, ypos, width, height);
            monitor.Dispose();
            xpos.Dispose();
            ypos.Dispose();
            width.Dispose();
            height.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Ptr<Window, Window> window, int button)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
            static extern int __DSL_glfwGetMouseButton(Window* window, int button);
            int ret = __DSL_glfwGetMouseButton(window, button);
            window.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int GetPlatform();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Ptr<Monitor, Monitor> GetPrimaryMonitor()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
            static extern Monitor* __DSL_glfwGetPrimaryMonitor();
            Monitor* ret = __DSL_glfwGetPrimaryMonitor();
            return ret;
        }

        [return: NativeTypeName("GLFWglproc")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> procname
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
            [return: NativeTypeName("GLFWglproc")]
            static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                [NativeTypeName("const char *")] sbyte* procname
            );
            delegate* unmanaged<void> ret = __DSL_glfwGetProcAddress(procname);
            procname.Dispose();
            return ret;
        }

        [return: NativeTypeName("const char **")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ptr<uint, uint> count
        )
        {
            [DllImport(
                "glfw",
                ExactSpelling = true,
                EntryPoint = "glfwGetRequiredInstanceExtensions"
            )]
            [return: NativeTypeName("const char **")]
            static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                [NativeTypeName("uint32_t *")] uint* count
            );
            sbyte** ret = __DSL_glfwGetRequiredInstanceExtensions(count);
            count.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern double GetTime();

        [DllImport("glfw", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong GetTimerFrequency();

        [DllImport("glfw", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong GetTimerValue();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(Ptr<int, int> major, Ptr<int, int> minor, Ptr<int, int> rev)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
            static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
            __DSL_glfwGetVersion(major, minor, rev);
            major.Dispose();
            minor.Dispose();
            rev.Dispose();
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public static PtrToConst<sbyte, sbyte> GetVersionString()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetVersionString();
            sbyte* ret = __DSL_glfwGetVersionString();
            return ret;
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static PtrToConst<Vidmode, Vidmode> GetVideoMode(Ptr<Monitor, Monitor> monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor);
            Vidmode* ret = __DSL_glfwGetVideoMode(monitor);
            monitor.Dispose();
            return ret;
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static PtrToConst<Vidmode, Vidmode> GetVideoModes(
            Ptr<Monitor, Monitor> monitor,
            Ptr<int, int> count
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count);
            Vidmode* ret = __DSL_glfwGetVideoModes(monitor, count);
            monitor.Dispose();
            count.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Ptr<Window, Window> window, int attrib)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
            static extern int __DSL_glfwGetWindowAttrib(Window* window, int attrib);
            int ret = __DSL_glfwGetWindowAttrib(window, attrib);
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(
            Ptr<Window, Window> window,
            Ptr<float, float> xscale,
            Ptr<float, float> yscale
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
            static extern void __DSL_glfwGetWindowContentScale(
                Window* window,
                float* xscale,
                float* yscale
            );
            __DSL_glfwGetWindowContentScale(window, xscale, yscale);
            window.Dispose();
            xscale.Dispose();
            yscale.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
            Ptr<Window, Window> window,
            Ptr<int, int> left,
            Ptr<int, int> top,
            Ptr<int, int> right,
            Ptr<int, int> bottom
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
            static extern void __DSL_glfwGetWindowFrameSize(
                Window* window,
                int* left,
                int* top,
                int* right,
                int* bottom
            );
            __DSL_glfwGetWindowFrameSize(window, left, top, right, bottom);
            window.Dispose();
            left.Dispose();
            top.Dispose();
            right.Dispose();
            bottom.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public static Ptr<Monitor, Monitor> GetWindowMonitor(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
            static extern Monitor* __DSL_glfwGetWindowMonitor(Window* window);
            Monitor* ret = __DSL_glfwGetWindowMonitor(window);
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
            static extern float __DSL_glfwGetWindowOpacity(Window* window);
            float ret = __DSL_glfwGetWindowOpacity(window);
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(
            Ptr<Window, Window> window,
            Ptr<int, int> xpos,
            Ptr<int, int> ypos
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
            static extern void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos);
            __DSL_glfwGetWindowPos(window, xpos, ypos);
            window.Dispose();
            xpos.Dispose();
            ypos.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(
            Ptr<Window, Window> window,
            Ptr<int, int> width,
            Ptr<int, int> height
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
            static extern void __DSL_glfwGetWindowSize(Window* window, int* width, int* height);
            __DSL_glfwGetWindowSize(window, width, height);
            window.Dispose();
            width.Dispose();
            height.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static Ptr GetWindowUserPointer(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
            static extern void* __DSL_glfwGetWindowUserPointer(Window* window);
            void* ret = __DSL_glfwGetWindowUserPointer(window);
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
            static extern void __DSL_glfwHideWindow(Window* window);
            __DSL_glfwHideWindow(window);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
            static extern void __DSL_glfwIconifyWindow(Window* window);
            __DSL_glfwIconifyWindow(window);
            window.Dispose();
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int Init();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] PtrToConst<Allocator, Allocator> allocator
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
            static extern void __DSL_glfwInitAllocator(
                [NativeTypeName("const GLFWallocator *")] Allocator* allocator
            );
            __DSL_glfwInitAllocator(allocator);
            allocator.Dispose();
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void InitHint(int hint, int value);

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int JoystickIsGamepad(int jid);

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int JoystickPresent(int jid);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
            static extern void __DSL_glfwMakeContextCurrent(Window* window);
            __DSL_glfwMakeContextCurrent(window);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
            static extern void __DSL_glfwMaximizeWindow(Window* window);
            __DSL_glfwMaximizeWindow(window);
            window.Dispose();
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int PlatformSupported(int platform);

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void PollEvents();

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void PostEmptyEvent();

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int RawMouseMotionSupported();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
            static extern void __DSL_glfwRequestWindowAttention(Window* window);
            __DSL_glfwRequestWindowAttention(window);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
            static extern void __DSL_glfwRestoreWindow(Window* window);
            __DSL_glfwRestoreWindow(window);
            window.Dispose();
        }

        [return: NativeTypeName("GLFWcharfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
            [return: NativeTypeName("GLFWcharfun")]
            static extern delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
                Window* window,
                [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
            );
            delegate* unmanaged<Window*, uint, void> ret = __DSL_glfwSetCharCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWcharmodsfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
            [return: NativeTypeName("GLFWcharmodsfun")]
            static extern delegate* unmanaged<
                Window*,
                uint,
                int,
                void> __DSL_glfwSetCharModsCallback(
                Window* window,
                [NativeTypeName("GLFWcharmodsfun")]
                    delegate* unmanaged<Window*, uint, int, void> callback
            );
            delegate* unmanaged<Window*, uint, int, void> ret = __DSL_glfwSetCharModsCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public static void SetClipboardString(
            Ptr<Window, Window> window,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
            static extern void __DSL_glfwSetClipboardString(
                Window* window,
                [NativeTypeName("const char *")] sbyte* @string
            );
            __DSL_glfwSetClipboardString(window, @string);
            window.Dispose();
            @string.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Ptr<Window, Window> window, Ptr<Cursor, Cursor> cursor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
            static extern void __DSL_glfwSetCursor(Window* window, Cursor* cursor);
            __DSL_glfwSetCursor(window, cursor);
            window.Dispose();
            cursor.Dispose();
        }

        [return: NativeTypeName("GLFWcursorenterfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
            [return: NativeTypeName("GLFWcursorenterfun")]
            static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
                Window* window,
                [NativeTypeName("GLFWcursorenterfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetCursorEnterCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public static void SetCursorPos(Ptr<Window, Window> window, double xpos, double ypos)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
            static extern void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos);
            __DSL_glfwSetCursorPos(window, xpos, ypos);
            window.Dispose();
        }

        [return: NativeTypeName("GLFWcursorposfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
            [return: NativeTypeName("GLFWcursorposfun")]
            static extern delegate* unmanaged<
                Window*,
                double,
                double,
                void> __DSL_glfwSetCursorPosCallback(
                Window* window,
                [NativeTypeName("GLFWcursorposfun")]
                    delegate* unmanaged<Window*, double, double, void> callback
            );
            delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetCursorPosCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWdropfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
            [return: NativeTypeName("GLFWdropfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                sbyte**,
                void> __DSL_glfwSetDropCallback(
                Window* window,
                [NativeTypeName("GLFWdropfun")]
                    delegate* unmanaged<Window*, int, sbyte**, void> callback
            );
            delegate* unmanaged<Window*, int, sbyte**, void> ret = __DSL_glfwSetDropCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        [return: NativeTypeName("GLFWerrorfun")]
        public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetFramebufferSizeCallback")]
            [return: NativeTypeName("GLFWframebuffersizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetFramebufferSizeCallback(
                Window* window,
                [NativeTypeName("GLFWframebuffersizefun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetFramebufferSizeCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public static void SetGamma(Ptr<Monitor, Monitor> monitor, float gamma)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
            static extern void __DSL_glfwSetGamma(Monitor* monitor, float gamma);
            __DSL_glfwSetGamma(monitor, gamma);
            monitor.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
            Ptr<Monitor, Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] PtrToConst<Gammaramp, Gammaramp> ramp
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
            static extern void __DSL_glfwSetGammaRamp(
                Monitor* monitor,
                [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
            );
            __DSL_glfwSetGammaRamp(monitor, ramp);
            monitor.Dispose();
            ramp.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public static void SetInputMode(Ptr<Window, Window> window, int mode, int value)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
            static extern void __DSL_glfwSetInputMode(Window* window, int mode, int value);
            __DSL_glfwSetInputMode(window, mode, value);
            window.Dispose();
        }

        [DllImport("glfw", ExactSpelling = true)]
        [return: NativeTypeName("GLFWjoystickfun")]
        public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, Ptr pointer)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
            static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
            __DSL_glfwSetJoystickUserPointer(jid, pointer);
            pointer.Dispose();
        }

        [return: NativeTypeName("GLFWkeyfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
            [return: NativeTypeName("GLFWkeyfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                int,
                int,
                void> __DSL_glfwSetKeyCallback(
                Window* window,
                [NativeTypeName("GLFWkeyfun")]
                    delegate* unmanaged<Window*, int, int, int, int, void> callback
            );
            delegate* unmanaged<Window*, int, int, int, int, void> ret = __DSL_glfwSetKeyCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        [return: NativeTypeName("GLFWmonitorfun")]
        public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Ptr<Monitor, Monitor> monitor, Ptr pointer)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
            static extern void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);
            __DSL_glfwSetMonitorUserPointer(monitor, pointer);
            monitor.Dispose();
            pointer.Dispose();
        }

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
            [return: NativeTypeName("GLFWmousebuttonfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                int,
                void> __DSL_glfwSetMouseButtonCallback(
                Window* window,
                [NativeTypeName("GLFWmousebuttonfun")]
                    delegate* unmanaged<Window*, int, int, int, void> callback
            );
            delegate* unmanaged<Window*, int, int, int, void> ret =
                __DSL_glfwSetMouseButtonCallback(window, callback);
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWscrollfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
            [return: NativeTypeName("GLFWscrollfun")]
            static extern delegate* unmanaged<
                Window*,
                double,
                double,
                void> __DSL_glfwSetScrollCallback(
                Window* window,
                [NativeTypeName("GLFWscrollfun")]
                    delegate* unmanaged<Window*, double, double, void> callback
            );
            delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetScrollCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void SetTime(double time);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Ptr<Window, Window> window, int numer, int denom)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
            static extern void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom);
            __DSL_glfwSetWindowAspectRatio(window, numer, denom);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Ptr<Window, Window> window, int attrib, int value)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
            static extern void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value);
            __DSL_glfwSetWindowAttrib(window, attrib, value);
            window.Dispose();
        }

        [return: NativeTypeName("GLFWwindowclosefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
            [return: NativeTypeName("GLFWwindowclosefun")]
            static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
                Window* window,
                [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
            );
            delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowCloseCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        )
        {
            [DllImport(
                "glfw",
                ExactSpelling = true,
                EntryPoint = "glfwSetWindowContentScaleCallback"
            )]
            [return: NativeTypeName("GLFWwindowcontentscalefun")]
            static extern delegate* unmanaged<
                Window*,
                float,
                float,
                void> __DSL_glfwSetWindowContentScaleCallback(
                Window* window,
                [NativeTypeName("GLFWwindowcontentscalefun")]
                    delegate* unmanaged<Window*, float, float, void> callback
            );
            delegate* unmanaged<Window*, float, float, void> ret =
                __DSL_glfwSetWindowContentScaleCallback(window, callback);
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
            [return: NativeTypeName("GLFWwindowfocusfun")]
            static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
                Window* window,
                [NativeTypeName("GLFWwindowfocusfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowFocusCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public static void SetWindowIcon(
            Ptr<Window, Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> images
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
            static extern void __DSL_glfwSetWindowIcon(
                Window* window,
                int count,
                [NativeTypeName("const GLFWimage *")] Image* images
            );
            __DSL_glfwSetWindowIcon(window, count, images);
            window.Dispose();
            images.Dispose();
        }

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIconifyCallback")]
            [return: NativeTypeName("GLFWwindowiconifyfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                void> __DSL_glfwSetWindowIconifyCallback(
                Window* window,
                [NativeTypeName("GLFWwindowiconifyfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowIconifyCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMaximizeCallback")]
            [return: NativeTypeName("GLFWwindowmaximizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                void> __DSL_glfwSetWindowMaximizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowmaximizefun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowMaximizeCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public static void SetWindowMonitor(
            Ptr<Window, Window> window,
            Ptr<Monitor, Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
            static extern void __DSL_glfwSetWindowMonitor(
                Window* window,
                Monitor* monitor,
                int xpos,
                int ypos,
                int width,
                int height,
                int refreshRate
            );
            __DSL_glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
            window.Dispose();
            monitor.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public static void SetWindowOpacity(Ptr<Window, Window> window, float opacity)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
            static extern void __DSL_glfwSetWindowOpacity(Window* window, float opacity);
            __DSL_glfwSetWindowOpacity(window, opacity);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Ptr<Window, Window> window, int xpos, int ypos)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
            static extern void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos);
            __DSL_glfwSetWindowPos(window, xpos, ypos);
            window.Dispose();
        }

        [return: NativeTypeName("GLFWwindowposfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
            [return: NativeTypeName("GLFWwindowposfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetWindowPosCallback(
                Window* window,
                [NativeTypeName("GLFWwindowposfun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowPosCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowRefreshCallback")]
            [return: NativeTypeName("GLFWwindowrefreshfun")]
            static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
                Window* window,
                [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
            );
            delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowRefreshCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public static void SetWindowShouldClose(Ptr<Window, Window> window, int value)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
            static extern void __DSL_glfwSetWindowShouldClose(Window* window, int value);
            __DSL_glfwSetWindowShouldClose(window, value);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Ptr<Window, Window> window, int width, int height)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
            static extern void __DSL_glfwSetWindowSize(Window* window, int width, int height);
            __DSL_glfwSetWindowSize(window, width, height);
            window.Dispose();
        }

        [return: NativeTypeName("GLFWwindowsizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ptr<Window, Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
            [return: NativeTypeName("GLFWwindowsizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetWindowSizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowsizefun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowSizeCallback(
                window,
                callback
            );
            window.Dispose();
            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public static void SetWindowSizeLimits(
            Ptr<Window, Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
            static extern void __DSL_glfwSetWindowSizeLimits(
                Window* window,
                int minwidth,
                int minheight,
                int maxwidth,
                int maxheight
            );
            __DSL_glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public static void SetWindowTitle(
            Ptr<Window, Window> window,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
            static extern void __DSL_glfwSetWindowTitle(
                Window* window,
                [NativeTypeName("const char *")] sbyte* title
            );
            __DSL_glfwSetWindowTitle(window, title);
            window.Dispose();
            title.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Ptr<Window, Window> window, Ptr pointer)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
            static extern void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer);
            __DSL_glfwSetWindowUserPointer(window, pointer);
            window.Dispose();
            pointer.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
            static extern void __DSL_glfwShowWindow(Window* window);
            __DSL_glfwShowWindow(window);
            window.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
            static extern void __DSL_glfwSwapBuffers(Window* window);
            __DSL_glfwSwapBuffers(window);
            window.Dispose();
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void SwapInterval(int interval);

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void Terminate();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings(
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
            static extern int __DSL_glfwUpdateGamepadMappings(
                [NativeTypeName("const char *")] sbyte* @string
            );
            int ret = __DSL_glfwUpdateGamepadMappings(@string);
            @string.Dispose();
            return ret;
        }

        [DllImport("glfw", ExactSpelling = true)]
        public static extern int VulkanSupported();

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void WaitEvents();

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void WaitEventsTimeout(double timeout);

        [DllImport("glfw", ExactSpelling = true)]
        public static extern void WindowHint(int hint, int value);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> value
        )
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
            static extern void __DSL_glfwWindowHintString(
                int hint,
                [NativeTypeName("const char *")] sbyte* value
            );
            __DSL_glfwWindowHintString(hint, value);
            value.Dispose();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Ptr<Window, Window> window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
            static extern int __DSL_glfwWindowShouldClose(Window* window);
            int ret = __DSL_glfwWindowShouldClose(window);
            window.Dispose();
            return ret;
        }
    }

    [NativeTypeName("#define GLFW_VERSION_MAJOR 3")]
    public const int VersionMajor = 3;

    [NativeTypeName("#define GLFW_VERSION_MINOR 4")]
    public const int VersionMinor = 4;

    [NativeTypeName("#define GLFW_VERSION_REVISION 0")]
    public const int VersionRevision = 0;

    [NativeTypeName("#define GLFW_TRUE 1")]
    public const int True = 1;

    [NativeTypeName("#define GLFW_FALSE 0")]
    public const int False = 0;

    [NativeTypeName("#define GLFW_RELEASE 0")]
    public const int Release = 0;

    [NativeTypeName("#define GLFW_PRESS 1")]
    public const int Press = 1;

    [NativeTypeName("#define GLFW_REPEAT 2")]
    public const int Repeat = 2;

    [NativeTypeName("#define GLFW_HAT_CENTERED 0")]
    public const int HatCentered = 0;

    [NativeTypeName("#define GLFW_HAT_UP 1")]
    public const int HatUp = 1;

    [NativeTypeName("#define GLFW_HAT_RIGHT 2")]
    public const int HatRight = 2;

    [NativeTypeName("#define GLFW_HAT_DOWN 4")]
    public const int HatDown = 4;

    [NativeTypeName("#define GLFW_HAT_LEFT 8")]
    public const int HatLeft = 8;

    [NativeTypeName("#define GLFW_HAT_RIGHT_UP (GLFW_HAT_RIGHT | GLFW_HAT_UP)")]
    public const int HatRightUp = (2 | 1);

    [NativeTypeName("#define GLFW_HAT_RIGHT_DOWN (GLFW_HAT_RIGHT | GLFW_HAT_DOWN)")]
    public const int HatRightDown = (2 | 4);

    [NativeTypeName("#define GLFW_HAT_LEFT_UP (GLFW_HAT_LEFT  | GLFW_HAT_UP)")]
    public const int HatLeftUp = (8 | 1);

    [NativeTypeName("#define GLFW_HAT_LEFT_DOWN (GLFW_HAT_LEFT  | GLFW_HAT_DOWN)")]
    public const int HatLeftDown = (8 | 4);

    [NativeTypeName("#define GLFW_KEY_UNKNOWN -1")]
    public const int KeyUnknown = -1;

    [NativeTypeName("#define GLFW_KEY_SPACE 32")]
    public const int KeySpace = 32;

    [NativeTypeName("#define GLFW_KEY_APOSTROPHE 39")]
    public const int KeyApostrophe = 39;

    [NativeTypeName("#define GLFW_KEY_COMMA 44")]
    public const int KeyComma = 44;

    [NativeTypeName("#define GLFW_KEY_MINUS 45")]
    public const int KeyMinus = 45;

    [NativeTypeName("#define GLFW_KEY_PERIOD 46")]
    public const int KeyPeriod = 46;

    [NativeTypeName("#define GLFW_KEY_SLASH 47")]
    public const int KeySlash = 47;

    [NativeTypeName("#define GLFW_KEY_0 48")]
    public const int Key0 = 48;

    [NativeTypeName("#define GLFW_KEY_1 49")]
    public const int Key1 = 49;

    [NativeTypeName("#define GLFW_KEY_2 50")]
    public const int Key2 = 50;

    [NativeTypeName("#define GLFW_KEY_3 51")]
    public const int Key3 = 51;

    [NativeTypeName("#define GLFW_KEY_4 52")]
    public const int Key4 = 52;

    [NativeTypeName("#define GLFW_KEY_5 53")]
    public const int Key5 = 53;

    [NativeTypeName("#define GLFW_KEY_6 54")]
    public const int Key6 = 54;

    [NativeTypeName("#define GLFW_KEY_7 55")]
    public const int Key7 = 55;

    [NativeTypeName("#define GLFW_KEY_8 56")]
    public const int Key8 = 56;

    [NativeTypeName("#define GLFW_KEY_9 57")]
    public const int Key9 = 57;

    [NativeTypeName("#define GLFW_KEY_SEMICOLON 59")]
    public const int KeySemicolon = 59;

    [NativeTypeName("#define GLFW_KEY_EQUAL 61")]
    public const int KeyEqual = 61;

    [NativeTypeName("#define GLFW_KEY_A 65")]
    public const int KeyA = 65;

    [NativeTypeName("#define GLFW_KEY_B 66")]
    public const int KeyB = 66;

    [NativeTypeName("#define GLFW_KEY_C 67")]
    public const int KeyC = 67;

    [NativeTypeName("#define GLFW_KEY_D 68")]
    public const int KeyD = 68;

    [NativeTypeName("#define GLFW_KEY_E 69")]
    public const int KeyE = 69;

    [NativeTypeName("#define GLFW_KEY_F 70")]
    public const int KeyF = 70;

    [NativeTypeName("#define GLFW_KEY_G 71")]
    public const int KeyG = 71;

    [NativeTypeName("#define GLFW_KEY_H 72")]
    public const int KeyH = 72;

    [NativeTypeName("#define GLFW_KEY_I 73")]
    public const int KeyI = 73;

    [NativeTypeName("#define GLFW_KEY_J 74")]
    public const int KeyJ = 74;

    [NativeTypeName("#define GLFW_KEY_K 75")]
    public const int KeyK = 75;

    [NativeTypeName("#define GLFW_KEY_L 76")]
    public const int KeyL = 76;

    [NativeTypeName("#define GLFW_KEY_M 77")]
    public const int KeyM = 77;

    [NativeTypeName("#define GLFW_KEY_N 78")]
    public const int KeyN = 78;

    [NativeTypeName("#define GLFW_KEY_O 79")]
    public const int KeyO = 79;

    [NativeTypeName("#define GLFW_KEY_P 80")]
    public const int KeyP = 80;

    [NativeTypeName("#define GLFW_KEY_Q 81")]
    public const int KeyQ = 81;

    [NativeTypeName("#define GLFW_KEY_R 82")]
    public const int KeyR = 82;

    [NativeTypeName("#define GLFW_KEY_S 83")]
    public const int KeyS = 83;

    [NativeTypeName("#define GLFW_KEY_T 84")]
    public const int KeyT = 84;

    [NativeTypeName("#define GLFW_KEY_U 85")]
    public const int KeyU = 85;

    [NativeTypeName("#define GLFW_KEY_V 86")]
    public const int KeyV = 86;

    [NativeTypeName("#define GLFW_KEY_W 87")]
    public const int KeyW = 87;

    [NativeTypeName("#define GLFW_KEY_X 88")]
    public const int KeyX = 88;

    [NativeTypeName("#define GLFW_KEY_Y 89")]
    public const int KeyY = 89;

    [NativeTypeName("#define GLFW_KEY_Z 90")]
    public const int KeyZ = 90;

    [NativeTypeName("#define GLFW_KEY_LEFT_BRACKET 91")]
    public const int KeyLeftBracket = 91;

    [NativeTypeName("#define GLFW_KEY_BACKSLASH 92")]
    public const int KeyBackslash = 92;

    [NativeTypeName("#define GLFW_KEY_RIGHT_BRACKET 93")]
    public const int KeyRightBracket = 93;

    [NativeTypeName("#define GLFW_KEY_GRAVE_ACCENT 96")]
    public const int KeyGraveAccent = 96;

    [NativeTypeName("#define GLFW_KEY_WORLD_1 161")]
    public const int KeyWorld1 = 161;

    [NativeTypeName("#define GLFW_KEY_WORLD_2 162")]
    public const int KeyWorld2 = 162;

    [NativeTypeName("#define GLFW_KEY_ESCAPE 256")]
    public const int KeyEscape = 256;

    [NativeTypeName("#define GLFW_KEY_ENTER 257")]
    public const int KeyEnter = 257;

    [NativeTypeName("#define GLFW_KEY_TAB 258")]
    public const int KeyTab = 258;

    [NativeTypeName("#define GLFW_KEY_BACKSPACE 259")]
    public const int KeyBackspace = 259;

    [NativeTypeName("#define GLFW_KEY_INSERT 260")]
    public const int KeyInsert = 260;

    [NativeTypeName("#define GLFW_KEY_DELETE 261")]
    public const int KeyDelete = 261;

    [NativeTypeName("#define GLFW_KEY_RIGHT 262")]
    public const int KeyRight = 262;

    [NativeTypeName("#define GLFW_KEY_LEFT 263")]
    public const int KeyLeft = 263;

    [NativeTypeName("#define GLFW_KEY_DOWN 264")]
    public const int KeyDown = 264;

    [NativeTypeName("#define GLFW_KEY_UP 265")]
    public const int KeyUp = 265;

    [NativeTypeName("#define GLFW_KEY_PAGE_UP 266")]
    public const int KeyPageUp = 266;

    [NativeTypeName("#define GLFW_KEY_PAGE_DOWN 267")]
    public const int KeyPageDown = 267;

    [NativeTypeName("#define GLFW_KEY_HOME 268")]
    public const int KeyHome = 268;

    [NativeTypeName("#define GLFW_KEY_END 269")]
    public const int KeyEnd = 269;

    [NativeTypeName("#define GLFW_KEY_CAPS_LOCK 280")]
    public const int KeyCapsLock = 280;

    [NativeTypeName("#define GLFW_KEY_SCROLL_LOCK 281")]
    public const int KeyScrollLock = 281;

    [NativeTypeName("#define GLFW_KEY_NUM_LOCK 282")]
    public const int KeyNumLock = 282;

    [NativeTypeName("#define GLFW_KEY_PRINT_SCREEN 283")]
    public const int KeyPrintScreen = 283;

    [NativeTypeName("#define GLFW_KEY_PAUSE 284")]
    public const int KeyPause = 284;

    [NativeTypeName("#define GLFW_KEY_F1 290")]
    public const int KeyF1 = 290;

    [NativeTypeName("#define GLFW_KEY_F2 291")]
    public const int KeyF2 = 291;

    [NativeTypeName("#define GLFW_KEY_F3 292")]
    public const int KeyF3 = 292;

    [NativeTypeName("#define GLFW_KEY_F4 293")]
    public const int KeyF4 = 293;

    [NativeTypeName("#define GLFW_KEY_F5 294")]
    public const int KeyF5 = 294;

    [NativeTypeName("#define GLFW_KEY_F6 295")]
    public const int KeyF6 = 295;

    [NativeTypeName("#define GLFW_KEY_F7 296")]
    public const int KeyF7 = 296;

    [NativeTypeName("#define GLFW_KEY_F8 297")]
    public const int KeyF8 = 297;

    [NativeTypeName("#define GLFW_KEY_F9 298")]
    public const int KeyF9 = 298;

    [NativeTypeName("#define GLFW_KEY_F10 299")]
    public const int KeyF10 = 299;

    [NativeTypeName("#define GLFW_KEY_F11 300")]
    public const int KeyF11 = 300;

    [NativeTypeName("#define GLFW_KEY_F12 301")]
    public const int KeyF12 = 301;

    [NativeTypeName("#define GLFW_KEY_F13 302")]
    public const int KeyF13 = 302;

    [NativeTypeName("#define GLFW_KEY_F14 303")]
    public const int KeyF14 = 303;

    [NativeTypeName("#define GLFW_KEY_F15 304")]
    public const int KeyF15 = 304;

    [NativeTypeName("#define GLFW_KEY_F16 305")]
    public const int KeyF16 = 305;

    [NativeTypeName("#define GLFW_KEY_F17 306")]
    public const int KeyF17 = 306;

    [NativeTypeName("#define GLFW_KEY_F18 307")]
    public const int KeyF18 = 307;

    [NativeTypeName("#define GLFW_KEY_F19 308")]
    public const int KeyF19 = 308;

    [NativeTypeName("#define GLFW_KEY_F20 309")]
    public const int KeyF20 = 309;

    [NativeTypeName("#define GLFW_KEY_F21 310")]
    public const int KeyF21 = 310;

    [NativeTypeName("#define GLFW_KEY_F22 311")]
    public const int KeyF22 = 311;

    [NativeTypeName("#define GLFW_KEY_F23 312")]
    public const int KeyF23 = 312;

    [NativeTypeName("#define GLFW_KEY_F24 313")]
    public const int KeyF24 = 313;

    [NativeTypeName("#define GLFW_KEY_F25 314")]
    public const int KeyF25 = 314;

    [NativeTypeName("#define GLFW_KEY_KP_0 320")]
    public const int KeyKp0 = 320;

    [NativeTypeName("#define GLFW_KEY_KP_1 321")]
    public const int KeyKp1 = 321;

    [NativeTypeName("#define GLFW_KEY_KP_2 322")]
    public const int KeyKp2 = 322;

    [NativeTypeName("#define GLFW_KEY_KP_3 323")]
    public const int KeyKp3 = 323;

    [NativeTypeName("#define GLFW_KEY_KP_4 324")]
    public const int KeyKp4 = 324;

    [NativeTypeName("#define GLFW_KEY_KP_5 325")]
    public const int KeyKp5 = 325;

    [NativeTypeName("#define GLFW_KEY_KP_6 326")]
    public const int KeyKp6 = 326;

    [NativeTypeName("#define GLFW_KEY_KP_7 327")]
    public const int KeyKp7 = 327;

    [NativeTypeName("#define GLFW_KEY_KP_8 328")]
    public const int KeyKp8 = 328;

    [NativeTypeName("#define GLFW_KEY_KP_9 329")]
    public const int KeyKp9 = 329;

    [NativeTypeName("#define GLFW_KEY_KP_DECIMAL 330")]
    public const int KeyKpDecimal = 330;

    [NativeTypeName("#define GLFW_KEY_KP_DIVIDE 331")]
    public const int KeyKpDivide = 331;

    [NativeTypeName("#define GLFW_KEY_KP_MULTIPLY 332")]
    public const int KeyKpMultiply = 332;

    [NativeTypeName("#define GLFW_KEY_KP_SUBTRACT 333")]
    public const int KeyKpSubtract = 333;

    [NativeTypeName("#define GLFW_KEY_KP_ADD 334")]
    public const int KeyKpAdd = 334;

    [NativeTypeName("#define GLFW_KEY_KP_ENTER 335")]
    public const int KeyKpEnter = 335;

    [NativeTypeName("#define GLFW_KEY_KP_EQUAL 336")]
    public const int KeyKpEqual = 336;

    [NativeTypeName("#define GLFW_KEY_LEFT_SHIFT 340")]
    public const int KeyLeftShift = 340;

    [NativeTypeName("#define GLFW_KEY_LEFT_CONTROL 341")]
    public const int KeyLeftControl = 341;

    [NativeTypeName("#define GLFW_KEY_LEFT_ALT 342")]
    public const int KeyLeftAlt = 342;

    [NativeTypeName("#define GLFW_KEY_LEFT_SUPER 343")]
    public const int KeyLeftSuper = 343;

    [NativeTypeName("#define GLFW_KEY_RIGHT_SHIFT 344")]
    public const int KeyRightShift = 344;

    [NativeTypeName("#define GLFW_KEY_RIGHT_CONTROL 345")]
    public const int KeyRightControl = 345;

    [NativeTypeName("#define GLFW_KEY_RIGHT_ALT 346")]
    public const int KeyRightAlt = 346;

    [NativeTypeName("#define GLFW_KEY_RIGHT_SUPER 347")]
    public const int KeyRightSuper = 347;

    [NativeTypeName("#define GLFW_KEY_MENU 348")]
    public const int KeyMenu = 348;

    [NativeTypeName("#define GLFW_KEY_LAST GLFW_KEY_MENU")]
    public const int KeyLast = 348;

    [NativeTypeName("#define GLFW_MOD_SHIFT 0x0001")]
    public const int ModShift = 0x0001;

    [NativeTypeName("#define GLFW_MOD_CONTROL 0x0002")]
    public const int ModControl = 0x0002;

    [NativeTypeName("#define GLFW_MOD_ALT 0x0004")]
    public const int ModAlt = 0x0004;

    [NativeTypeName("#define GLFW_MOD_SUPER 0x0008")]
    public const int ModSuper = 0x0008;

    [NativeTypeName("#define GLFW_MOD_CAPS_LOCK 0x0010")]
    public const int ModCapsLock = 0x0010;

    [NativeTypeName("#define GLFW_MOD_NUM_LOCK 0x0020")]
    public const int ModNumLock = 0x0020;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_1 0")]
    public const int MouseButton1 = 0;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_2 1")]
    public const int MouseButton2 = 1;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_3 2")]
    public const int MouseButton3 = 2;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_4 3")]
    public const int MouseButton4 = 3;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_5 4")]
    public const int MouseButton5 = 4;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_6 5")]
    public const int MouseButton6 = 5;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_7 6")]
    public const int MouseButton7 = 6;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_8 7")]
    public const int MouseButton8 = 7;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LAST GLFW_MOUSE_BUTTON_8")]
    public const int MouseButtonLast = 7;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LEFT GLFW_MOUSE_BUTTON_1")]
    public const int MouseButtonLeft = 0;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_RIGHT GLFW_MOUSE_BUTTON_2")]
    public const int MouseButtonRight = 1;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_MIDDLE GLFW_MOUSE_BUTTON_3")]
    public const int MouseButtonMiddle = 2;

    [NativeTypeName("#define GLFW_JOYSTICK_1 0")]
    public const int Joystick1 = 0;

    [NativeTypeName("#define GLFW_JOYSTICK_2 1")]
    public const int Joystick2 = 1;

    [NativeTypeName("#define GLFW_JOYSTICK_3 2")]
    public const int Joystick3 = 2;

    [NativeTypeName("#define GLFW_JOYSTICK_4 3")]
    public const int Joystick4 = 3;

    [NativeTypeName("#define GLFW_JOYSTICK_5 4")]
    public const int Joystick5 = 4;

    [NativeTypeName("#define GLFW_JOYSTICK_6 5")]
    public const int Joystick6 = 5;

    [NativeTypeName("#define GLFW_JOYSTICK_7 6")]
    public const int Joystick7 = 6;

    [NativeTypeName("#define GLFW_JOYSTICK_8 7")]
    public const int Joystick8 = 7;

    [NativeTypeName("#define GLFW_JOYSTICK_9 8")]
    public const int Joystick9 = 8;

    [NativeTypeName("#define GLFW_JOYSTICK_10 9")]
    public const int Joystick10 = 9;

    [NativeTypeName("#define GLFW_JOYSTICK_11 10")]
    public const int Joystick11 = 10;

    [NativeTypeName("#define GLFW_JOYSTICK_12 11")]
    public const int Joystick12 = 11;

    [NativeTypeName("#define GLFW_JOYSTICK_13 12")]
    public const int Joystick13 = 12;

    [NativeTypeName("#define GLFW_JOYSTICK_14 13")]
    public const int Joystick14 = 13;

    [NativeTypeName("#define GLFW_JOYSTICK_15 14")]
    public const int Joystick15 = 14;

    [NativeTypeName("#define GLFW_JOYSTICK_16 15")]
    public const int Joystick16 = 15;

    [NativeTypeName("#define GLFW_JOYSTICK_LAST GLFW_JOYSTICK_16")]
    public const int JoystickLast = 15;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_A 0")]
    public const int GamepadButtonA = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_B 1")]
    public const int GamepadButtonB = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_X 2")]
    public const int GamepadButtonX = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_Y 3")]
    public const int GamepadButtonY = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_BUMPER 4")]
    public const int GamepadButtonLeftBumper = 4;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER 5")]
    public const int GamepadButtonRightBumper = 5;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_BACK 6")]
    public const int GamepadButtonBack = 6;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_START 7")]
    public const int GamepadButtonStart = 7;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_GUIDE 8")]
    public const int GamepadButtonGuide = 8;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_THUMB 9")]
    public const int GamepadButtonLeftThumb = 9;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_THUMB 10")]
    public const int GamepadButtonRightThumb = 10;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_UP 11")]
    public const int GamepadButtonDpadUp = 11;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_RIGHT 12")]
    public const int GamepadButtonDpadRight = 12;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_DOWN 13")]
    public const int GamepadButtonDpadDown = 13;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_LEFT 14")]
    public const int GamepadButtonDpadLeft = 14;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LAST GLFW_GAMEPAD_BUTTON_DPAD_LEFT")]
    public const int GamepadButtonLast = 14;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CROSS GLFW_GAMEPAD_BUTTON_A")]
    public const int GamepadButtonCross = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CIRCLE GLFW_GAMEPAD_BUTTON_B")]
    public const int GamepadButtonCircle = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_SQUARE GLFW_GAMEPAD_BUTTON_X")]
    public const int GamepadButtonSquare = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_TRIANGLE GLFW_GAMEPAD_BUTTON_Y")]
    public const int GamepadButtonTriangle = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_X 0")]
    public const int GamepadAxisLeftX = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_Y 1")]
    public const int GamepadAxisLeftY = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_X 2")]
    public const int GamepadAxisRightX = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_Y 3")]
    public const int GamepadAxisRightY = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_TRIGGER 4")]
    public const int GamepadAxisLeftTrigger = 4;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER 5")]
    public const int GamepadAxisRightTrigger = 5;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LAST GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER")]
    public const int GamepadAxisLast = 5;

    [NativeTypeName("#define GLFW_NO_ERROR 0")]
    public const int NoError = 0;

    [NativeTypeName("#define GLFW_NOT_INITIALIZED 0x00010001")]
    public const int NotInitialized = 0x00010001;

    [NativeTypeName("#define GLFW_NO_CURRENT_CONTEXT 0x00010002")]
    public const int NoCurrentContext = 0x00010002;

    [NativeTypeName("#define GLFW_INVALID_ENUM 0x00010003")]
    public const int InvalidEnum = 0x00010003;

    [NativeTypeName("#define GLFW_INVALID_VALUE 0x00010004")]
    public const int InvalidValue = 0x00010004;

    [NativeTypeName("#define GLFW_OUT_OF_MEMORY 0x00010005")]
    public const int OutOfMemory = 0x00010005;

    [NativeTypeName("#define GLFW_API_UNAVAILABLE 0x00010006")]
    public const int ApiUnavailable = 0x00010006;

    [NativeTypeName("#define GLFW_VERSION_UNAVAILABLE 0x00010007")]
    public const int VersionUnavailable = 0x00010007;

    [NativeTypeName("#define GLFW_PLATFORM_ERROR 0x00010008")]
    public const int PlatformError = 0x00010008;

    [NativeTypeName("#define GLFW_FORMAT_UNAVAILABLE 0x00010009")]
    public const int FormatUnavailable = 0x00010009;

    [NativeTypeName("#define GLFW_NO_WINDOW_CONTEXT 0x0001000A")]
    public const int NoWindowContext = 0x0001000A;

    [NativeTypeName("#define GLFW_CURSOR_UNAVAILABLE 0x0001000B")]
    public const int CursorUnavailable = 0x0001000B;

    [NativeTypeName("#define GLFW_FEATURE_UNAVAILABLE 0x0001000C")]
    public const int FeatureUnavailable = 0x0001000C;

    [NativeTypeName("#define GLFW_FEATURE_UNIMPLEMENTED 0x0001000D")]
    public const int FeatureUnimplemented = 0x0001000D;

    [NativeTypeName("#define GLFW_PLATFORM_UNAVAILABLE 0x0001000E")]
    public const int PlatformUnavailable = 0x0001000E;

    [NativeTypeName("#define GLFW_FOCUSED 0x00020001")]
    public const int Focused = 0x00020001;

    [NativeTypeName("#define GLFW_ICONIFIED 0x00020002")]
    public const int Iconified = 0x00020002;

    [NativeTypeName("#define GLFW_RESIZABLE 0x00020003")]
    public const int Resizable = 0x00020003;

    [NativeTypeName("#define GLFW_VISIBLE 0x00020004")]
    public const int Visible = 0x00020004;

    [NativeTypeName("#define GLFW_DECORATED 0x00020005")]
    public const int Decorated = 0x00020005;

    [NativeTypeName("#define GLFW_AUTO_ICONIFY 0x00020006")]
    public const int AutoIconify = 0x00020006;

    [NativeTypeName("#define GLFW_FLOATING 0x00020007")]
    public const int Floating = 0x00020007;

    [NativeTypeName("#define GLFW_MAXIMIZED 0x00020008")]
    public const int Maximized = 0x00020008;

    [NativeTypeName("#define GLFW_CENTER_CURSOR 0x00020009")]
    public const int CenterCursor = 0x00020009;

    [NativeTypeName("#define GLFW_TRANSPARENT_FRAMEBUFFER 0x0002000A")]
    public const int TransparentFramebuffer = 0x0002000A;

    [NativeTypeName("#define GLFW_HOVERED 0x0002000B")]
    public const int Hovered = 0x0002000B;

    [NativeTypeName("#define GLFW_FOCUS_ON_SHOW 0x0002000C")]
    public const int FocusOnShow = 0x0002000C;

    [NativeTypeName("#define GLFW_MOUSE_PASSTHROUGH 0x0002000D")]
    public const int MousePassthrough = 0x0002000D;

    [NativeTypeName("#define GLFW_POSITION_X 0x0002000E")]
    public const int PositionX = 0x0002000E;

    [NativeTypeName("#define GLFW_POSITION_Y 0x0002000F")]
    public const int PositionY = 0x0002000F;

    [NativeTypeName("#define GLFW_RED_BITS 0x00021001")]
    public const int RedBits = 0x00021001;

    [NativeTypeName("#define GLFW_GREEN_BITS 0x00021002")]
    public const int GreenBits = 0x00021002;

    [NativeTypeName("#define GLFW_BLUE_BITS 0x00021003")]
    public const int BlueBits = 0x00021003;

    [NativeTypeName("#define GLFW_ALPHA_BITS 0x00021004")]
    public const int AlphaBits = 0x00021004;

    [NativeTypeName("#define GLFW_DEPTH_BITS 0x00021005")]
    public const int DepthBits = 0x00021005;

    [NativeTypeName("#define GLFW_STENCIL_BITS 0x00021006")]
    public const int StencilBits = 0x00021006;

    [NativeTypeName("#define GLFW_ACCUM_RED_BITS 0x00021007")]
    public const int AccumRedBits = 0x00021007;

    [NativeTypeName("#define GLFW_ACCUM_GREEN_BITS 0x00021008")]
    public const int AccumGreenBits = 0x00021008;

    [NativeTypeName("#define GLFW_ACCUM_BLUE_BITS 0x00021009")]
    public const int AccumBlueBits = 0x00021009;

    [NativeTypeName("#define GLFW_ACCUM_ALPHA_BITS 0x0002100A")]
    public const int AccumAlphaBits = 0x0002100A;

    [NativeTypeName("#define GLFW_AUX_BUFFERS 0x0002100B")]
    public const int AuxBuffers = 0x0002100B;

    [NativeTypeName("#define GLFW_STEREO 0x0002100C")]
    public const int Stereo = 0x0002100C;

    [NativeTypeName("#define GLFW_SAMPLES 0x0002100D")]
    public const int Samples = 0x0002100D;

    [NativeTypeName("#define GLFW_SRGB_CAPABLE 0x0002100E")]
    public const int SrgbCapable = 0x0002100E;

    [NativeTypeName("#define GLFW_REFRESH_RATE 0x0002100F")]
    public const int RefreshRate = 0x0002100F;

    [NativeTypeName("#define GLFW_DOUBLEBUFFER 0x00021010")]
    public const int Doublebuffer = 0x00021010;

    [NativeTypeName("#define GLFW_CLIENT_API 0x00022001")]
    public const int ClientApi = 0x00022001;

    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MAJOR 0x00022002")]
    public const int ContextVersionMajor = 0x00022002;

    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MINOR 0x00022003")]
    public const int ContextVersionMinor = 0x00022003;

    [NativeTypeName("#define GLFW_CONTEXT_REVISION 0x00022004")]
    public const int ContextRevision = 0x00022004;

    [NativeTypeName("#define GLFW_CONTEXT_ROBUSTNESS 0x00022005")]
    public const int ContextRobustness = 0x00022005;

    [NativeTypeName("#define GLFW_OPENGL_FORWARD_COMPAT 0x00022006")]
    public const int OpenglForwardCompat = 0x00022006;

    [NativeTypeName("#define GLFW_CONTEXT_DEBUG 0x00022007")]
    public const int ContextDebug = 0x00022007;

    [NativeTypeName("#define GLFW_OPENGL_DEBUG_CONTEXT GLFW_CONTEXT_DEBUG")]
    public const int OpenglDebugContext = 0x00022007;

    [NativeTypeName("#define GLFW_OPENGL_PROFILE 0x00022008")]
    public const int OpenglProfile = 0x00022008;

    [NativeTypeName("#define GLFW_CONTEXT_RELEASE_BEHAVIOR 0x00022009")]
    public const int ContextReleaseBehavior = 0x00022009;

    [NativeTypeName("#define GLFW_CONTEXT_NO_ERROR 0x0002200A")]
    public const int ContextNoError = 0x0002200A;

    [NativeTypeName("#define GLFW_CONTEXT_CREATION_API 0x0002200B")]
    public const int ContextCreationApi = 0x0002200B;

    [NativeTypeName("#define GLFW_SCALE_TO_MONITOR 0x0002200C")]
    public const int ScaleToMonitor = 0x0002200C;

    [NativeTypeName("#define GLFW_COCOA_RETINA_FRAMEBUFFER 0x00023001")]
    public const int CocoaRetinaFramebuffer = 0x00023001;

    [NativeTypeName("#define GLFW_COCOA_FRAME_NAME 0x00023002")]
    public const int CocoaFrameName = 0x00023002;

    [NativeTypeName("#define GLFW_COCOA_GRAPHICS_SWITCHING 0x00023003")]
    public const int CocoaGraphicsSwitching = 0x00023003;

    [NativeTypeName("#define GLFW_X11_CLASS_NAME 0x00024001")]
    public const int X11ClassName = 0x00024001;

    [NativeTypeName("#define GLFW_X11_INSTANCE_NAME 0x00024002")]
    public const int X11InstanceName = 0x00024002;

    [NativeTypeName("#define GLFW_WIN32_KEYBOARD_MENU 0x00025001")]
    public const int Win32KeyboardMenu = 0x00025001;

    [NativeTypeName("#define GLFW_WAYLAND_APP_ID 0x00026001")]
    public const int WaylandAppId = 0x00026001;

    [NativeTypeName("#define GLFW_NO_API 0")]
    public const int NoApi = 0;

    [NativeTypeName("#define GLFW_OPENGL_API 0x00030001")]
    public const int OpenglApi = 0x00030001;

    [NativeTypeName("#define GLFW_OPENGL_ES_API 0x00030002")]
    public const int OpenglEsApi = 0x00030002;

    [NativeTypeName("#define GLFW_NO_ROBUSTNESS 0")]
    public const int NoRobustness = 0;

    [NativeTypeName("#define GLFW_NO_RESET_NOTIFICATION 0x00031001")]
    public const int NoResetNotification = 0x00031001;

    [NativeTypeName("#define GLFW_LOSE_CONTEXT_ON_RESET 0x00031002")]
    public const int LoseContextOnReset = 0x00031002;

    [NativeTypeName("#define GLFW_OPENGL_ANY_PROFILE 0")]
    public const int OpenglAnyProfile = 0;

    [NativeTypeName("#define GLFW_OPENGL_CORE_PROFILE 0x00032001")]
    public const int OpenglCoreProfile = 0x00032001;

    [NativeTypeName("#define GLFW_OPENGL_COMPAT_PROFILE 0x00032002")]
    public const int OpenglCompatProfile = 0x00032002;

    [NativeTypeName("#define GLFW_CURSOR 0x00033001")]
    public const int Cursor = 0x00033001;

    [NativeTypeName("#define GLFW_STICKY_KEYS 0x00033002")]
    public const int StickyKeys = 0x00033002;

    [NativeTypeName("#define GLFW_STICKY_MOUSE_BUTTONS 0x00033003")]
    public const int StickyMouseButtons = 0x00033003;

    [NativeTypeName("#define GLFW_LOCK_KEY_MODS 0x00033004")]
    public const int LockKeyMods = 0x00033004;

    [NativeTypeName("#define GLFW_RAW_MOUSE_MOTION 0x00033005")]
    public const int RawMouseMotion = 0x00033005;

    [NativeTypeName("#define GLFW_CURSOR_NORMAL 0x00034001")]
    public const int CursorNormal = 0x00034001;

    [NativeTypeName("#define GLFW_CURSOR_HIDDEN 0x00034002")]
    public const int CursorHidden = 0x00034002;

    [NativeTypeName("#define GLFW_CURSOR_DISABLED 0x00034003")]
    public const int CursorDisabled = 0x00034003;

    [NativeTypeName("#define GLFW_CURSOR_CAPTURED 0x00034004")]
    public const int CursorCaptured = 0x00034004;

    [NativeTypeName("#define GLFW_ANY_RELEASE_BEHAVIOR 0")]
    public const int AnyReleaseBehavior = 0;

    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_FLUSH 0x00035001")]
    public const int ReleaseBehaviorFlush = 0x00035001;

    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_NONE 0x00035002")]
    public const int ReleaseBehaviorNone = 0x00035002;

    [NativeTypeName("#define GLFW_NATIVE_CONTEXT_API 0x00036001")]
    public const int NativeContextApi = 0x00036001;

    [NativeTypeName("#define GLFW_EGL_CONTEXT_API 0x00036002")]
    public const int EglContextApi = 0x00036002;

    [NativeTypeName("#define GLFW_OSMESA_CONTEXT_API 0x00036003")]
    public const int OsmesaContextApi = 0x00036003;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_NONE 0x00037001")]
    public const int AnglePlatformTypeNone = 0x00037001;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGL 0x00037002")]
    public const int AnglePlatformTypeOpengl = 0x00037002;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGLES 0x00037003")]
    public const int AnglePlatformTypeOpengles = 0x00037003;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D9 0x00037004")]
    public const int AnglePlatformTypeD3d9 = 0x00037004;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
    public const int AnglePlatformTypeD3d11 = 0x00037005;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_VULKAN 0x00037007")]
    public const int AnglePlatformTypeVulkan = 0x00037007;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_METAL 0x00037008")]
    public const int AnglePlatformTypeMetal = 0x00037008;

    [NativeTypeName("#define GLFW_WAYLAND_PREFER_LIBDECOR 0x00038001")]
    public const int WaylandPreferLibdecor = 0x00038001;

    [NativeTypeName("#define GLFW_WAYLAND_DISABLE_LIBDECOR 0x00038002")]
    public const int WaylandDisableLibdecor = 0x00038002;

    [NativeTypeName("#define GLFW_ANY_POSITION 0x80000000")]
    public const uint AnyPosition = 0x80000000;

    [NativeTypeName("#define GLFW_ARROW_CURSOR 0x00036001")]
    public const int ArrowCursor = 0x00036001;

    [NativeTypeName("#define GLFW_IBEAM_CURSOR 0x00036002")]
    public const int IbeamCursor = 0x00036002;

    [NativeTypeName("#define GLFW_CROSSHAIR_CURSOR 0x00036003")]
    public const int CrosshairCursor = 0x00036003;

    [NativeTypeName("#define GLFW_POINTING_HAND_CURSOR 0x00036004")]
    public const int PointingHandCursor = 0x00036004;

    [NativeTypeName("#define GLFW_RESIZE_EW_CURSOR 0x00036005")]
    public const int ResizeEwCursor = 0x00036005;

    [NativeTypeName("#define GLFW_RESIZE_NS_CURSOR 0x00036006")]
    public const int ResizeNsCursor = 0x00036006;

    [NativeTypeName("#define GLFW_RESIZE_NWSE_CURSOR 0x00036007")]
    public const int ResizeNwseCursor = 0x00036007;

    [NativeTypeName("#define GLFW_RESIZE_NESW_CURSOR 0x00036008")]
    public const int ResizeNeswCursor = 0x00036008;

    [NativeTypeName("#define GLFW_RESIZE_ALL_CURSOR 0x00036009")]
    public const int ResizeAllCursor = 0x00036009;

    [NativeTypeName("#define GLFW_NOT_ALLOWED_CURSOR 0x0003600A")]
    public const int NotAllowedCursor = 0x0003600A;

    [NativeTypeName("#define GLFW_HRESIZE_CURSOR GLFW_RESIZE_EW_CURSOR")]
    public const int HresizeCursor = 0x00036005;

    [NativeTypeName("#define GLFW_VRESIZE_CURSOR GLFW_RESIZE_NS_CURSOR")]
    public const int VresizeCursor = 0x00036006;

    [NativeTypeName("#define GLFW_HAND_CURSOR GLFW_POINTING_HAND_CURSOR")]
    public const int HandCursor = 0x00036004;

    [NativeTypeName("#define GLFW_CONNECTED 0x00040001")]
    public const int Connected = 0x00040001;

    [NativeTypeName("#define GLFW_DISCONNECTED 0x00040002")]
    public const int Disconnected = 0x00040002;

    [NativeTypeName("#define GLFW_JOYSTICK_HAT_BUTTONS 0x00050001")]
    public const int JoystickHatButtons = 0x00050001;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE 0x00050002")]
    public const int AnglePlatformType = 0x00050002;

    [NativeTypeName("#define GLFW_PLATFORM 0x00050003")]
    public const int Platform = 0x00050003;

    [NativeTypeName("#define GLFW_COCOA_CHDIR_RESOURCES 0x00051001")]
    public const int CocoaChdirResources = 0x00051001;

    [NativeTypeName("#define GLFW_COCOA_MENUBAR 0x00051002")]
    public const int CocoaMenubar = 0x00051002;

    [NativeTypeName("#define GLFW_X11_XCB_VULKAN_SURFACE 0x00052001")]
    public const int X11XcbVulkanSurface = 0x00052001;

    [NativeTypeName("#define GLFW_WAYLAND_LIBDECOR 0x00053001")]
    public const int WaylandLibdecor = 0x00053001;

    [NativeTypeName("#define GLFW_ANY_PLATFORM 0x00060000")]
    public const int AnyPlatform = 0x00060000;

    [NativeTypeName("#define GLFW_PLATFORM_WIN32 0x00060001")]
    public const int PlatformWin32 = 0x00060001;

    [NativeTypeName("#define GLFW_PLATFORM_COCOA 0x00060002")]
    public const int PlatformCocoa = 0x00060002;

    [NativeTypeName("#define GLFW_PLATFORM_WAYLAND 0x00060003")]
    public const int PlatformWayland = 0x00060003;

    [NativeTypeName("#define GLFW_PLATFORM_X11 0x00060004")]
    public const int PlatformX11 = 0x00060004;

    [NativeTypeName("#define GLFW_PLATFORM_NULL 0x00060005")]
    public const int PlatformNull = 0x00060005;

    [NativeTypeName("#define GLFW_DONT_CARE -1")]
    public const int DontCare = -1;

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Ptr<Cursor, Cursor> IGlfw.CreateCursor(
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> image,
        int xhot,
        int yhot
    )
    {
        Cursor* __DSL_glfwCreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        ) =>
            (
                (delegate* unmanaged<Image*, int, int, Cursor*>)
                    nativeContext.LoadFunction("glfwCreateCursor", "glfw")
            )(image, xhot, yhot);
        Cursor* ret = __DSL_glfwCreateCursor(image, xhot, yhot);
        image.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    public static Ptr<Cursor, Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> image,
        int xhot,
        int yhot
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
        static extern Cursor* __DSL_glfwCreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        );
        Cursor* ret = __DSL_glfwCreateCursor(image, xhot, yhot);
        image.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Ptr<Cursor, Cursor> IGlfw.CreateStandardCursor(int shape)
    {
        Cursor* __DSL_glfwCreateStandardCursor(int shape) =>
            (
                (delegate* unmanaged<int, Cursor*>)
                    nativeContext.LoadFunction("glfwCreateStandardCursor", "glfw")
            )(shape);
        Cursor* ret = __DSL_glfwCreateStandardCursor(shape);
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    public static Ptr<Cursor, Cursor> CreateStandardCursor(int shape)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
        static extern Cursor* __DSL_glfwCreateStandardCursor(int shape);
        Cursor* ret = __DSL_glfwCreateStandardCursor(shape);
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Ptr<Window, Window> IGlfw.CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title,
        Ptr<Monitor, Monitor> monitor,
        Ptr<Window, Window> share
    )
    {
        Window* __DSL_glfwCreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        ) =>
            (
                (delegate* unmanaged<int, int, sbyte*, Monitor*, Window*, Window*>)
                    nativeContext.LoadFunction("glfwCreateWindow", "glfw")
            )(width, height, title, monitor, share);
        Window* ret = __DSL_glfwCreateWindow(width, height, title, monitor, share);
        title.Dispose();
        monitor.Dispose();
        share.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    public static Ptr<Window, Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title,
        Ptr<Monitor, Monitor> monitor,
        Ptr<Window, Window> share
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
        static extern Window* __DSL_glfwCreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        );
        Window* ret = __DSL_glfwCreateWindow(width, height, title, monitor, share);
        title.Dispose();
        monitor.Dispose();
        share.Dispose();
        return ret;
    }

    void IGlfw.DefaultWindowHints() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("DefaultWindowHints", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void IGlfw.DestroyCursor(Ptr<Cursor, Cursor> cursor)
    {
        void __DSL_glfwDestroyCursor(Cursor* cursor) =>
            (
                (delegate* unmanaged<Cursor*, void>)
                    nativeContext.LoadFunction("glfwDestroyCursor", "glfw")
            )(cursor);
        __DSL_glfwDestroyCursor(cursor);
        cursor.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    public static void DestroyCursor(Ptr<Cursor, Cursor> cursor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
        static extern void __DSL_glfwDestroyCursor(Cursor* cursor);
        __DSL_glfwDestroyCursor(cursor);
        cursor.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void IGlfw.DestroyWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwDestroyWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwDestroyWindow", "glfw")
            )(window);
        __DSL_glfwDestroyWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    public static void DestroyWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
        static extern void __DSL_glfwDestroyWindow(Window* window);
        __DSL_glfwDestroyWindow(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int IGlfw.ExtensionSupported(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> extension
    )
    {
        int __DSL_glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
            (
                (delegate* unmanaged<sbyte*, int>)
                    nativeContext.LoadFunction("glfwExtensionSupported", "glfw")
            )(extension);
        int ret = __DSL_glfwExtensionSupported(extension);
        extension.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    public static int ExtensionSupported(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> extension
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
        static extern int __DSL_glfwExtensionSupported(
            [NativeTypeName("const char *")] sbyte* extension
        );
        int ret = __DSL_glfwExtensionSupported(extension);
        extension.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void IGlfw.FocusWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwFocusWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwFocusWindow", "glfw")
            )(window);
        __DSL_glfwFocusWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    public static void FocusWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
        static extern void __DSL_glfwFocusWindow(Window* window);
        __DSL_glfwFocusWindow(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    PtrToConst<sbyte, sbyte> IGlfw.GetClipboardString(Ptr<Window, Window> window)
    {
        sbyte* __DSL_glfwGetClipboardString(Window* window) =>
            (
                (delegate* unmanaged<Window*, sbyte*>)
                    nativeContext.LoadFunction("glfwGetClipboardString", "glfw")
            )(window);
        sbyte* ret = __DSL_glfwGetClipboardString(window);
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    public static PtrToConst<sbyte, sbyte> GetClipboardString(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetClipboardString(Window* window);
        sbyte* ret = __DSL_glfwGetClipboardString(window);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Ptr<Window, Window> IGlfw.GetCurrentContext()
    {
        Window* __DSL_glfwGetCurrentContext() =>
            (
                (delegate* unmanaged<Window*>)
                    nativeContext.LoadFunction("glfwGetCurrentContext", "glfw")
            )();
        Window* ret = __DSL_glfwGetCurrentContext();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    public static Ptr<Window, Window> GetCurrentContext()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
        static extern Window* __DSL_glfwGetCurrentContext();
        Window* ret = __DSL_glfwGetCurrentContext();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void IGlfw.GetCursorPos(
        Ptr<Window, Window> window,
        Ptr<double, double> xpos,
        Ptr<double, double> ypos
    )
    {
        void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos) =>
            (
                (delegate* unmanaged<Window*, double*, double*, void>)
                    nativeContext.LoadFunction("glfwGetCursorPos", "glfw")
            )(window, xpos, ypos);
        __DSL_glfwGetCursorPos(window, xpos, ypos);
        window.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    public static void GetCursorPos(
        Ptr<Window, Window> window,
        Ptr<double, double> xpos,
        Ptr<double, double> ypos
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
        static extern void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos);
        __DSL_glfwGetCursorPos(window, xpos, ypos);
        window.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int IGlfw.GetError(
        [NativeTypeName("const char **")] PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> description
    )
    {
        int __DSL_glfwGetError([NativeTypeName("const char **")] sbyte** description) =>
            ((delegate* unmanaged<sbyte**, int>)nativeContext.LoadFunction("glfwGetError", "glfw"))(
                description
            );
        int ret = __DSL_glfwGetError(description);
        description.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    public static int GetError(
        [NativeTypeName("const char **")] PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> description
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
        static extern int __DSL_glfwGetError([NativeTypeName("const char **")] sbyte** description);
        int ret = __DSL_glfwGetError(description);
        description.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void IGlfw.GetFramebufferSize(
        Ptr<Window, Window> window,
        Ptr<int, int> width,
        Ptr<int, int> height
    )
    {
        void __DSL_glfwGetFramebufferSize(Window* window, int* width, int* height) =>
            (
                (delegate* unmanaged<Window*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetFramebufferSize", "glfw")
            )(window, width, height);
        __DSL_glfwGetFramebufferSize(window, width, height);
        window.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    public static void GetFramebufferSize(
        Ptr<Window, Window> window,
        Ptr<int, int> width,
        Ptr<int, int> height
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
        static extern void __DSL_glfwGetFramebufferSize(Window* window, int* width, int* height);
        __DSL_glfwGetFramebufferSize(window, width, height);
        window.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    PtrToConst<sbyte, sbyte> IGlfw.GetGamepadName(int jid)
    {
        sbyte* __DSL_glfwGetGamepadName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetGamepadName", "glfw")
            )(jid);
        sbyte* ret = __DSL_glfwGetGamepadName(jid);
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    public static PtrToConst<sbyte, sbyte> GetGamepadName(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetGamepadName(int jid);
        sbyte* ret = __DSL_glfwGetGamepadName(jid);
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int IGlfw.GetGamepadState(int jid, Ptr<Gamepadstate, Gamepadstate> state)
    {
        int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state) =>
            (
                (delegate* unmanaged<int, Gamepadstate*, int>)
                    nativeContext.LoadFunction("glfwGetGamepadState", "glfw")
            )(jid, state);
        int ret = __DSL_glfwGetGamepadState(jid, state);
        state.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    public static int GetGamepadState(int jid, Ptr<Gamepadstate, Gamepadstate> state)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
        static extern int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state);
        int ret = __DSL_glfwGetGamepadState(jid, state);
        state.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    PtrToConst<Gammaramp, Gammaramp> IGlfw.GetGammaRamp(Ptr<Monitor, Monitor> monitor)
    {
        Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor) =>
            (
                (delegate* unmanaged<Monitor*, Gammaramp*>)
                    nativeContext.LoadFunction("glfwGetGammaRamp", "glfw")
            )(monitor);
        Gammaramp* ret = __DSL_glfwGetGammaRamp(monitor);
        monitor.Dispose();
        return ret;
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    public static PtrToConst<Gammaramp, Gammaramp> GetGammaRamp(Ptr<Monitor, Monitor> monitor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
        [return: NativeTypeName("const GLFWgammaramp *")]
        static extern Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor);
        Gammaramp* ret = __DSL_glfwGetGammaRamp(monitor);
        monitor.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int IGlfw.GetInputMode(Ptr<Window, Window> window, int mode)
    {
        int __DSL_glfwGetInputMode(Window* window, int mode) =>
            (
                (delegate* unmanaged<Window*, int, int>)
                    nativeContext.LoadFunction("glfwGetInputMode", "glfw")
            )(window, mode);
        int ret = __DSL_glfwGetInputMode(window, mode);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    public static int GetInputMode(Ptr<Window, Window> window, int mode)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
        static extern int __DSL_glfwGetInputMode(Window* window, int mode);
        int ret = __DSL_glfwGetInputMode(window, mode);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    PtrToConst<float, float> IGlfw.GetJoystickAxes(int jid, Ptr<int, int> count)
    {
        float* __DSL_glfwGetJoystickAxes(int jid, int* count) =>
            (
                (delegate* unmanaged<int, int*, float*>)
                    nativeContext.LoadFunction("glfwGetJoystickAxes", "glfw")
            )(jid, count);
        float* ret = __DSL_glfwGetJoystickAxes(jid, count);
        count.Dispose();
        return ret;
    }

    [return: NativeTypeName("const float *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    public static PtrToConst<float, float> GetJoystickAxes(int jid, Ptr<int, int> count)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
        [return: NativeTypeName("const float *")]
        static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
        float* ret = __DSL_glfwGetJoystickAxes(jid, count);
        count.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    PtrToConst<byte, byte> IGlfw.GetJoystickButtons(int jid, Ptr<int, int> count)
    {
        byte* __DSL_glfwGetJoystickButtons(int jid, int* count) =>
            (
                (delegate* unmanaged<int, int*, byte*>)
                    nativeContext.LoadFunction("glfwGetJoystickButtons", "glfw")
            )(jid, count);
        byte* ret = __DSL_glfwGetJoystickButtons(jid, count);
        count.Dispose();
        return ret;
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    public static PtrToConst<byte, byte> GetJoystickButtons(int jid, Ptr<int, int> count)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
        [return: NativeTypeName("const unsigned char *")]
        static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
        byte* ret = __DSL_glfwGetJoystickButtons(jid, count);
        count.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    PtrToConst<sbyte, sbyte> IGlfw.GetJoystickGuid(int jid)
    {
        sbyte* __DSL_glfwGetJoystickGUID(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickGUID", "glfw")
            )(jid);
        sbyte* ret = __DSL_glfwGetJoystickGUID(jid);
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    public static PtrToConst<sbyte, sbyte> GetJoystickGuid(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
        sbyte* ret = __DSL_glfwGetJoystickGUID(jid);
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    PtrToConst<byte, byte> IGlfw.GetJoystickHats(int jid, Ptr<int, int> count)
    {
        byte* __DSL_glfwGetJoystickHats(int jid, int* count) =>
            (
                (delegate* unmanaged<int, int*, byte*>)
                    nativeContext.LoadFunction("glfwGetJoystickHats", "glfw")
            )(jid, count);
        byte* ret = __DSL_glfwGetJoystickHats(jid, count);
        count.Dispose();
        return ret;
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    public static PtrToConst<byte, byte> GetJoystickHats(int jid, Ptr<int, int> count)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
        [return: NativeTypeName("const unsigned char *")]
        static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
        byte* ret = __DSL_glfwGetJoystickHats(jid, count);
        count.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    PtrToConst<sbyte, sbyte> IGlfw.GetJoystickName(int jid)
    {
        sbyte* __DSL_glfwGetJoystickName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickName", "glfw")
            )(jid);
        sbyte* ret = __DSL_glfwGetJoystickName(jid);
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    public static PtrToConst<sbyte, sbyte> GetJoystickName(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickName(int jid);
        sbyte* ret = __DSL_glfwGetJoystickName(jid);
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Ptr IGlfw.GetJoystickUserPointer(int jid)
    {
        void* __DSL_glfwGetJoystickUserPointer(int jid) =>
            (
                (delegate* unmanaged<int, void*>)
                    nativeContext.LoadFunction("glfwGetJoystickUserPointer", "glfw")
            )(jid);
        void* ret = __DSL_glfwGetJoystickUserPointer(jid);
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    public static Ptr GetJoystickUserPointer(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
        static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
        void* ret = __DSL_glfwGetJoystickUserPointer(jid);
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int IGlfw.GetKey(Ptr<Window, Window> window, int key)
    {
        int __DSL_glfwGetKey(Window* window, int key) =>
            (
                (delegate* unmanaged<Window*, int, int>)
                    nativeContext.LoadFunction("glfwGetKey", "glfw")
            )(window, key);
        int ret = __DSL_glfwGetKey(window, key);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    public static int GetKey(Ptr<Window, Window> window, int key)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
        static extern int __DSL_glfwGetKey(Window* window, int key);
        int ret = __DSL_glfwGetKey(window, key);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    PtrToConst<sbyte, sbyte> IGlfw.GetKeyName(int key, int scancode)
    {
        sbyte* __DSL_glfwGetKeyName(int key, int scancode) =>
            (
                (delegate* unmanaged<int, int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetKeyName", "glfw")
            )(key, scancode);
        sbyte* ret = __DSL_glfwGetKeyName(key, scancode);
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    public static PtrToConst<sbyte, sbyte> GetKeyName(int key, int scancode)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
        sbyte* ret = __DSL_glfwGetKeyName(key, scancode);
        return ret;
    }

    int IGlfw.GetKeyScancode(int key) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("GetKeyScancode", "glfw"))(key);

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void IGlfw.GetMonitorContentScale(
        Ptr<Monitor, Monitor> monitor,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    )
    {
        void __DSL_glfwGetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
            (
                (delegate* unmanaged<Monitor*, float*, float*, void>)
                    nativeContext.LoadFunction("glfwGetMonitorContentScale", "glfw")
            )(monitor, xscale, yscale);
        __DSL_glfwGetMonitorContentScale(monitor, xscale, yscale);
        monitor.Dispose();
        xscale.Dispose();
        yscale.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    public static void GetMonitorContentScale(
        Ptr<Monitor, Monitor> monitor,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
        static extern void __DSL_glfwGetMonitorContentScale(
            Monitor* monitor,
            float* xscale,
            float* yscale
        );
        __DSL_glfwGetMonitorContentScale(monitor, xscale, yscale);
        monitor.Dispose();
        xscale.Dispose();
        yscale.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    PtrToConst<sbyte, sbyte> IGlfw.GetMonitorName(Ptr<Monitor, Monitor> monitor)
    {
        sbyte* __DSL_glfwGetMonitorName(Monitor* monitor) =>
            (
                (delegate* unmanaged<Monitor*, sbyte*>)
                    nativeContext.LoadFunction("glfwGetMonitorName", "glfw")
            )(monitor);
        sbyte* ret = __DSL_glfwGetMonitorName(monitor);
        monitor.Dispose();
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    public static PtrToConst<sbyte, sbyte> GetMonitorName(Ptr<Monitor, Monitor> monitor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetMonitorName(Monitor* monitor);
        sbyte* ret = __DSL_glfwGetMonitorName(monitor);
        monitor.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void IGlfw.GetMonitorPhysicalSize(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> widthMM,
        Ptr<int, int> heightMM
    )
    {
        void __DSL_glfwGetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
            (
                (delegate* unmanaged<Monitor*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetMonitorPhysicalSize", "glfw")
            )(monitor, widthMM, heightMM);
        __DSL_glfwGetMonitorPhysicalSize(monitor, widthMM, heightMM);
        monitor.Dispose();
        widthMM.Dispose();
        heightMM.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    public static void GetMonitorPhysicalSize(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> widthMM,
        Ptr<int, int> heightMM
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
        static extern void __DSL_glfwGetMonitorPhysicalSize(
            Monitor* monitor,
            int* widthMM,
            int* heightMM
        );
        __DSL_glfwGetMonitorPhysicalSize(monitor, widthMM, heightMM);
        monitor.Dispose();
        widthMM.Dispose();
        heightMM.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void IGlfw.GetMonitorPos(Ptr<Monitor, Monitor> monitor, Ptr<int, int> xpos, Ptr<int, int> ypos)
    {
        void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
            (
                (delegate* unmanaged<Monitor*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetMonitorPos", "glfw")
            )(monitor, xpos, ypos);
        __DSL_glfwGetMonitorPos(monitor, xpos, ypos);
        monitor.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static void GetMonitorPos(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> xpos,
        Ptr<int, int> ypos
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
        static extern void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos);
        __DSL_glfwGetMonitorPos(monitor, xpos, ypos);
        monitor.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Ptr<Ptr<Monitor, Monitor>, Monitor> IGlfw.GetMonitors(Ptr<int, int> count)
    {
        Monitor** __DSL_glfwGetMonitors(int* count) =>
            (
                (delegate* unmanaged<int*, Monitor**>)
                    nativeContext.LoadFunction("glfwGetMonitors", "glfw")
            )(count);
        Monitor** ret = __DSL_glfwGetMonitors(count);
        count.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    public static Ptr<Ptr<Monitor, Monitor>, Monitor> GetMonitors(Ptr<int, int> count)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
        static extern Monitor** __DSL_glfwGetMonitors(int* count);
        Monitor** ret = __DSL_glfwGetMonitors(count);
        count.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Ptr IGlfw.GetMonitorUserPointer(Ptr<Monitor, Monitor> monitor)
    {
        void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor) =>
            (
                (delegate* unmanaged<Monitor*, void*>)
                    nativeContext.LoadFunction("glfwGetMonitorUserPointer", "glfw")
            )(monitor);
        void* ret = __DSL_glfwGetMonitorUserPointer(monitor);
        monitor.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    public static Ptr GetMonitorUserPointer(Ptr<Monitor, Monitor> monitor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
        static extern void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor);
        void* ret = __DSL_glfwGetMonitorUserPointer(monitor);
        monitor.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void IGlfw.GetMonitorWorkarea(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> xpos,
        Ptr<int, int> ypos,
        Ptr<int, int> width,
        Ptr<int, int> height
    )
    {
        void __DSL_glfwGetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        ) =>
            (
                (delegate* unmanaged<Monitor*, int*, int*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetMonitorWorkarea", "glfw")
            )(monitor, xpos, ypos, width, height);
        __DSL_glfwGetMonitorWorkarea(monitor, xpos, ypos, width, height);
        monitor.Dispose();
        xpos.Dispose();
        ypos.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    public static void GetMonitorWorkarea(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> xpos,
        Ptr<int, int> ypos,
        Ptr<int, int> width,
        Ptr<int, int> height
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
        static extern void __DSL_glfwGetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        );
        __DSL_glfwGetMonitorWorkarea(monitor, xpos, ypos, width, height);
        monitor.Dispose();
        xpos.Dispose();
        ypos.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int IGlfw.GetMouseButton(Ptr<Window, Window> window, int button)
    {
        int __DSL_glfwGetMouseButton(Window* window, int button) =>
            (
                (delegate* unmanaged<Window*, int, int>)
                    nativeContext.LoadFunction("glfwGetMouseButton", "glfw")
            )(window, button);
        int ret = __DSL_glfwGetMouseButton(window, button);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    public static int GetMouseButton(Ptr<Window, Window> window, int button)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
        static extern int __DSL_glfwGetMouseButton(Window* window, int button);
        int ret = __DSL_glfwGetMouseButton(window, button);
        window.Dispose();
        return ret;
    }

    int IGlfw.GetPlatform() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("GetPlatform", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int GetPlatform();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Ptr<Monitor, Monitor> IGlfw.GetPrimaryMonitor()
    {
        Monitor* __DSL_glfwGetPrimaryMonitor() =>
            (
                (delegate* unmanaged<Monitor*>)
                    nativeContext.LoadFunction("glfwGetPrimaryMonitor", "glfw")
            )();
        Monitor* ret = __DSL_glfwGetPrimaryMonitor();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    public static Ptr<Monitor, Monitor> GetPrimaryMonitor()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
        static extern Monitor* __DSL_glfwGetPrimaryMonitor();
        Monitor* ret = __DSL_glfwGetPrimaryMonitor();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> IGlfw.GetProcAddress(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> procname
    )
    {
        delegate* unmanaged<void> __DSL_glfwGetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        ) =>
            (
                (delegate* unmanaged<sbyte*, delegate* unmanaged<void>>)
                    nativeContext.LoadFunction("glfwGetProcAddress", "glfw")
            )(procname);
        delegate* unmanaged<void> ret = __DSL_glfwGetProcAddress(procname);
        procname.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWglproc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    public static delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> procname
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
        [return: NativeTypeName("GLFWglproc")]
        static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        );
        delegate* unmanaged<void> ret = __DSL_glfwGetProcAddress(procname);
        procname.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> IGlfw.GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Ptr<uint, uint> count
    )
    {
        sbyte** __DSL_glfwGetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] uint* count
        ) =>
            (
                (delegate* unmanaged<uint*, sbyte**>)
                    nativeContext.LoadFunction("glfwGetRequiredInstanceExtensions", "glfw")
            )(count);
        sbyte** ret = __DSL_glfwGetRequiredInstanceExtensions(count);
        count.Dispose();
        return ret;
    }

    [return: NativeTypeName("const char **")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    public static PtrToConst<PtrToConst<sbyte, sbyte>, sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Ptr<uint, uint> count
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetRequiredInstanceExtensions")]
        [return: NativeTypeName("const char **")]
        static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] uint* count
        );
        sbyte** ret = __DSL_glfwGetRequiredInstanceExtensions(count);
        count.Dispose();
        return ret;
    }

    double IGlfw.GetTime() =>
        ((delegate* unmanaged<double>)nativeContext.LoadFunction("GetTime", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern double GetTime();

    ulong IGlfw.GetTimerFrequency() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("GetTimerFrequency", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetTimerFrequency();

    ulong IGlfw.GetTimerValue() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("GetTimerValue", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void IGlfw.GetVersion(Ptr<int, int> major, Ptr<int, int> minor, Ptr<int, int> rev)
    {
        void __DSL_glfwGetVersion(int* major, int* minor, int* rev) =>
            (
                (delegate* unmanaged<int*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetVersion", "glfw")
            )(major, minor, rev);
        __DSL_glfwGetVersion(major, minor, rev);
        major.Dispose();
        minor.Dispose();
        rev.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    public static void GetVersion(Ptr<int, int> major, Ptr<int, int> minor, Ptr<int, int> rev)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
        static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
        __DSL_glfwGetVersion(major, minor, rev);
        major.Dispose();
        minor.Dispose();
        rev.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    PtrToConst<sbyte, sbyte> IGlfw.GetVersionString()
    {
        sbyte* __DSL_glfwGetVersionString() =>
            (
                (delegate* unmanaged<sbyte*>)
                    nativeContext.LoadFunction("glfwGetVersionString", "glfw")
            )();
        sbyte* ret = __DSL_glfwGetVersionString();
        return ret;
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    public static PtrToConst<sbyte, sbyte> GetVersionString()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetVersionString();
        sbyte* ret = __DSL_glfwGetVersionString();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    PtrToConst<Vidmode, Vidmode> IGlfw.GetVideoMode(Ptr<Monitor, Monitor> monitor)
    {
        Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor) =>
            (
                (delegate* unmanaged<Monitor*, Vidmode*>)
                    nativeContext.LoadFunction("glfwGetVideoMode", "glfw")
            )(monitor);
        Vidmode* ret = __DSL_glfwGetVideoMode(monitor);
        monitor.Dispose();
        return ret;
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    public static PtrToConst<Vidmode, Vidmode> GetVideoMode(Ptr<Monitor, Monitor> monitor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
        [return: NativeTypeName("const GLFWvidmode *")]
        static extern Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor);
        Vidmode* ret = __DSL_glfwGetVideoMode(monitor);
        monitor.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    PtrToConst<Vidmode, Vidmode> IGlfw.GetVideoModes(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> count
    )
    {
        Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count) =>
            (
                (delegate* unmanaged<Monitor*, int*, Vidmode*>)
                    nativeContext.LoadFunction("glfwGetVideoModes", "glfw")
            )(monitor, count);
        Vidmode* ret = __DSL_glfwGetVideoModes(monitor, count);
        monitor.Dispose();
        count.Dispose();
        return ret;
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    public static PtrToConst<Vidmode, Vidmode> GetVideoModes(
        Ptr<Monitor, Monitor> monitor,
        Ptr<int, int> count
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
        [return: NativeTypeName("const GLFWvidmode *")]
        static extern Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count);
        Vidmode* ret = __DSL_glfwGetVideoModes(monitor, count);
        monitor.Dispose();
        count.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int IGlfw.GetWindowAttrib(Ptr<Window, Window> window, int attrib)
    {
        int __DSL_glfwGetWindowAttrib(Window* window, int attrib) =>
            (
                (delegate* unmanaged<Window*, int, int>)
                    nativeContext.LoadFunction("glfwGetWindowAttrib", "glfw")
            )(window, attrib);
        int ret = __DSL_glfwGetWindowAttrib(window, attrib);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    public static int GetWindowAttrib(Ptr<Window, Window> window, int attrib)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
        static extern int __DSL_glfwGetWindowAttrib(Window* window, int attrib);
        int ret = __DSL_glfwGetWindowAttrib(window, attrib);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void IGlfw.GetWindowContentScale(
        Ptr<Window, Window> window,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    )
    {
        void __DSL_glfwGetWindowContentScale(Window* window, float* xscale, float* yscale) =>
            (
                (delegate* unmanaged<Window*, float*, float*, void>)
                    nativeContext.LoadFunction("glfwGetWindowContentScale", "glfw")
            )(window, xscale, yscale);
        __DSL_glfwGetWindowContentScale(window, xscale, yscale);
        window.Dispose();
        xscale.Dispose();
        yscale.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    public static void GetWindowContentScale(
        Ptr<Window, Window> window,
        Ptr<float, float> xscale,
        Ptr<float, float> yscale
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
        static extern void __DSL_glfwGetWindowContentScale(
            Window* window,
            float* xscale,
            float* yscale
        );
        __DSL_glfwGetWindowContentScale(window, xscale, yscale);
        window.Dispose();
        xscale.Dispose();
        yscale.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void IGlfw.GetWindowFrameSize(
        Ptr<Window, Window> window,
        Ptr<int, int> left,
        Ptr<int, int> top,
        Ptr<int, int> right,
        Ptr<int, int> bottom
    )
    {
        void __DSL_glfwGetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        ) =>
            (
                (delegate* unmanaged<Window*, int*, int*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetWindowFrameSize", "glfw")
            )(window, left, top, right, bottom);
        __DSL_glfwGetWindowFrameSize(window, left, top, right, bottom);
        window.Dispose();
        left.Dispose();
        top.Dispose();
        right.Dispose();
        bottom.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    public static void GetWindowFrameSize(
        Ptr<Window, Window> window,
        Ptr<int, int> left,
        Ptr<int, int> top,
        Ptr<int, int> right,
        Ptr<int, int> bottom
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
        static extern void __DSL_glfwGetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        );
        __DSL_glfwGetWindowFrameSize(window, left, top, right, bottom);
        window.Dispose();
        left.Dispose();
        top.Dispose();
        right.Dispose();
        bottom.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Ptr<Monitor, Monitor> IGlfw.GetWindowMonitor(Ptr<Window, Window> window)
    {
        Monitor* __DSL_glfwGetWindowMonitor(Window* window) =>
            (
                (delegate* unmanaged<Window*, Monitor*>)
                    nativeContext.LoadFunction("glfwGetWindowMonitor", "glfw")
            )(window);
        Monitor* ret = __DSL_glfwGetWindowMonitor(window);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    public static Ptr<Monitor, Monitor> GetWindowMonitor(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
        static extern Monitor* __DSL_glfwGetWindowMonitor(Window* window);
        Monitor* ret = __DSL_glfwGetWindowMonitor(window);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float IGlfw.GetWindowOpacity(Ptr<Window, Window> window)
    {
        float __DSL_glfwGetWindowOpacity(Window* window) =>
            (
                (delegate* unmanaged<Window*, float>)
                    nativeContext.LoadFunction("glfwGetWindowOpacity", "glfw")
            )(window);
        float ret = __DSL_glfwGetWindowOpacity(window);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    public static float GetWindowOpacity(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
        static extern float __DSL_glfwGetWindowOpacity(Window* window);
        float ret = __DSL_glfwGetWindowOpacity(window);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void IGlfw.GetWindowPos(Ptr<Window, Window> window, Ptr<int, int> xpos, Ptr<int, int> ypos)
    {
        void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos) =>
            (
                (delegate* unmanaged<Window*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetWindowPos", "glfw")
            )(window, xpos, ypos);
        __DSL_glfwGetWindowPos(window, xpos, ypos);
        window.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    public static void GetWindowPos(
        Ptr<Window, Window> window,
        Ptr<int, int> xpos,
        Ptr<int, int> ypos
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
        static extern void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos);
        __DSL_glfwGetWindowPos(window, xpos, ypos);
        window.Dispose();
        xpos.Dispose();
        ypos.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void IGlfw.GetWindowSize(Ptr<Window, Window> window, Ptr<int, int> width, Ptr<int, int> height)
    {
        void __DSL_glfwGetWindowSize(Window* window, int* width, int* height) =>
            (
                (delegate* unmanaged<Window*, int*, int*, void>)
                    nativeContext.LoadFunction("glfwGetWindowSize", "glfw")
            )(window, width, height);
        __DSL_glfwGetWindowSize(window, width, height);
        window.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    public static void GetWindowSize(
        Ptr<Window, Window> window,
        Ptr<int, int> width,
        Ptr<int, int> height
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
        static extern void __DSL_glfwGetWindowSize(Window* window, int* width, int* height);
        __DSL_glfwGetWindowSize(window, width, height);
        window.Dispose();
        width.Dispose();
        height.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Ptr IGlfw.GetWindowUserPointer(Ptr<Window, Window> window)
    {
        void* __DSL_glfwGetWindowUserPointer(Window* window) =>
            (
                (delegate* unmanaged<Window*, void*>)
                    nativeContext.LoadFunction("glfwGetWindowUserPointer", "glfw")
            )(window);
        void* ret = __DSL_glfwGetWindowUserPointer(window);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    public static Ptr GetWindowUserPointer(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
        static extern void* __DSL_glfwGetWindowUserPointer(Window* window);
        void* ret = __DSL_glfwGetWindowUserPointer(window);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void IGlfw.HideWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwHideWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwHideWindow", "glfw")
            )(window);
        __DSL_glfwHideWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    public static void HideWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
        static extern void __DSL_glfwHideWindow(Window* window);
        __DSL_glfwHideWindow(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IGlfw.IconifyWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwIconifyWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwIconifyWindow", "glfw")
            )(window);
        __DSL_glfwIconifyWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    public static void IconifyWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
        static extern void __DSL_glfwIconifyWindow(Window* window);
        __DSL_glfwIconifyWindow(window);
        window.Dispose();
    }

    int IGlfw.Init() => ((delegate* unmanaged<int>)nativeContext.LoadFunction("Init", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void IGlfw.InitAllocator(
        [NativeTypeName("const GLFWallocator *")] PtrToConst<Allocator, Allocator> allocator
    )
    {
        void __DSL_glfwInitAllocator(
            [NativeTypeName("const GLFWallocator *")] Allocator* allocator
        ) =>
            (
                (delegate* unmanaged<Allocator*, void>)
                    nativeContext.LoadFunction("glfwInitAllocator", "glfw")
            )(allocator);
        __DSL_glfwInitAllocator(allocator);
        allocator.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    public static void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] PtrToConst<Allocator, Allocator> allocator
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
        static extern void __DSL_glfwInitAllocator(
            [NativeTypeName("const GLFWallocator *")] Allocator* allocator
        );
        __DSL_glfwInitAllocator(allocator);
        allocator.Dispose();
    }

    void IGlfw.InitHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("InitHint", "glfw"))(
            hint,
            value
        );

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void InitHint(int hint, int value);

    int IGlfw.JoystickIsGamepad(int jid) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("JoystickIsGamepad", "glfw"))(
            jid
        );

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int JoystickIsGamepad(int jid);

    int IGlfw.JoystickPresent(int jid) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("JoystickPresent", "glfw"))(jid);

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void IGlfw.MakeContextCurrent(Ptr<Window, Window> window)
    {
        void __DSL_glfwMakeContextCurrent(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwMakeContextCurrent", "glfw")
            )(window);
        __DSL_glfwMakeContextCurrent(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    public static void MakeContextCurrent(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
        static extern void __DSL_glfwMakeContextCurrent(Window* window);
        __DSL_glfwMakeContextCurrent(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void IGlfw.MaximizeWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwMaximizeWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwMaximizeWindow", "glfw")
            )(window);
        __DSL_glfwMaximizeWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    public static void MaximizeWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
        static extern void __DSL_glfwMaximizeWindow(Window* window);
        __DSL_glfwMaximizeWindow(window);
        window.Dispose();
    }

    int IGlfw.PlatformSupported(int platform) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("PlatformSupported", "glfw"))(
            platform
        );

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int PlatformSupported(int platform);

    void IGlfw.PollEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("PollEvents", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void PollEvents();

    void IGlfw.PostEmptyEvent() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("PostEmptyEvent", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void PostEmptyEvent();

    int IGlfw.RawMouseMotionSupported() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("RawMouseMotionSupported", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void IGlfw.RequestWindowAttention(Ptr<Window, Window> window)
    {
        void __DSL_glfwRequestWindowAttention(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwRequestWindowAttention", "glfw")
            )(window);
        __DSL_glfwRequestWindowAttention(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    public static void RequestWindowAttention(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
        static extern void __DSL_glfwRequestWindowAttention(Window* window);
        __DSL_glfwRequestWindowAttention(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void IGlfw.RestoreWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwRestoreWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwRestoreWindow", "glfw")
            )(window);
        __DSL_glfwRestoreWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    public static void RestoreWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
        static extern void __DSL_glfwRestoreWindow(Window* window);
        __DSL_glfwRestoreWindow(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> IGlfw.SetCharCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, uint, void>,
                    delegate* unmanaged<Window*, uint, void>>)
                    nativeContext.LoadFunction("glfwSetCharCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, uint, void> ret = __DSL_glfwSetCharCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWcharfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
        [return: NativeTypeName("GLFWcharfun")]
        static extern delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );
        delegate* unmanaged<Window*, uint, void> ret = __DSL_glfwSetCharCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> IGlfw.SetCharModsCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        delegate* unmanaged<Window*, uint, int, void> __DSL_glfwSetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, uint, int, void>,
                    delegate* unmanaged<Window*, uint, int, void>>)
                    nativeContext.LoadFunction("glfwSetCharModsCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, uint, int, void> ret = __DSL_glfwSetCharModsCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
        [return: NativeTypeName("GLFWcharmodsfun")]
        static extern delegate* unmanaged<Window*, uint, int, void> __DSL_glfwSetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );
        delegate* unmanaged<Window*, uint, int, void> ret = __DSL_glfwSetCharModsCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void IGlfw.SetClipboardString(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
    )
    {
        void __DSL_glfwSetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        ) =>
            (
                (delegate* unmanaged<Window*, sbyte*, void>)
                    nativeContext.LoadFunction("glfwSetClipboardString", "glfw")
            )(window, @string);
        __DSL_glfwSetClipboardString(window, @string);
        window.Dispose();
        @string.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    public static void SetClipboardString(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
        static extern void __DSL_glfwSetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        );
        __DSL_glfwSetClipboardString(window, @string);
        window.Dispose();
        @string.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void IGlfw.SetCursor(Ptr<Window, Window> window, Ptr<Cursor, Cursor> cursor)
    {
        void __DSL_glfwSetCursor(Window* window, Cursor* cursor) =>
            (
                (delegate* unmanaged<Window*, Cursor*, void>)
                    nativeContext.LoadFunction("glfwSetCursor", "glfw")
            )(window, cursor);
        __DSL_glfwSetCursor(window, cursor);
        window.Dispose();
        cursor.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    public static void SetCursor(Ptr<Window, Window> window, Ptr<Cursor, Cursor> cursor)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
        static extern void __DSL_glfwSetCursor(Window* window, Cursor* cursor);
        __DSL_glfwSetCursor(window, cursor);
        window.Dispose();
        cursor.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetCursorEnterCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, void>,
                    delegate* unmanaged<Window*, int, void>>)
                    nativeContext.LoadFunction("glfwSetCursorEnterCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetCursorEnterCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
        [return: NativeTypeName("GLFWcursorenterfun")]
        static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetCursorEnterCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void IGlfw.SetCursorPos(Ptr<Window, Window> window, double xpos, double ypos)
    {
        void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos) =>
            (
                (delegate* unmanaged<Window*, double, double, void>)
                    nativeContext.LoadFunction("glfwSetCursorPos", "glfw")
            )(window, xpos, ypos);
        __DSL_glfwSetCursorPos(window, xpos, ypos);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    public static void SetCursorPos(Ptr<Window, Window> window, double xpos, double ypos)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
        static extern void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos);
        __DSL_glfwSetCursorPos(window, xpos, ypos);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetCursorPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        delegate* unmanaged<Window*, double, double, void> __DSL_glfwSetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, double, double, void>,
                    delegate* unmanaged<Window*, double, double, void>>)
                    nativeContext.LoadFunction("glfwSetCursorPosCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetCursorPosCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
        [return: NativeTypeName("GLFWcursorposfun")]
        static extern delegate* unmanaged<
            Window*,
            double,
            double,
            void> __DSL_glfwSetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );
        delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetCursorPosCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> IGlfw.SetDropCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        delegate* unmanaged<Window*, int, sbyte**, void> __DSL_glfwSetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, sbyte**, void>,
                    delegate* unmanaged<Window*, int, sbyte**, void>>)
                    nativeContext.LoadFunction("glfwSetDropCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, sbyte**, void> ret = __DSL_glfwSetDropCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWdropfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
        [return: NativeTypeName("GLFWdropfun")]
        static extern delegate* unmanaged<Window*, int, sbyte**, void> __DSL_glfwSetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );
        delegate* unmanaged<Window*, int, sbyte**, void> ret = __DSL_glfwSetDropCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    delegate* unmanaged<int, sbyte*, void> IGlfw.SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, sbyte*, void>,
                delegate* unmanaged<int, sbyte*, void>>)
                nativeContext.LoadFunction("SetErrorCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWerrorfun")]
    public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetFramebufferSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, int, void>,
                    delegate* unmanaged<Window*, int, int, void>>)
                    nativeContext.LoadFunction("glfwSetFramebufferSizeCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetFramebufferSizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetFramebufferSizeCallback")]
        [return: NativeTypeName("GLFWframebuffersizefun")]
        static extern delegate* unmanaged<
            Window*,
            int,
            int,
            void> __DSL_glfwSetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetFramebufferSizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void IGlfw.SetGamma(Ptr<Monitor, Monitor> monitor, float gamma)
    {
        void __DSL_glfwSetGamma(Monitor* monitor, float gamma) =>
            (
                (delegate* unmanaged<Monitor*, float, void>)
                    nativeContext.LoadFunction("glfwSetGamma", "glfw")
            )(monitor, gamma);
        __DSL_glfwSetGamma(monitor, gamma);
        monitor.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    public static void SetGamma(Ptr<Monitor, Monitor> monitor, float gamma)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
        static extern void __DSL_glfwSetGamma(Monitor* monitor, float gamma);
        __DSL_glfwSetGamma(monitor, gamma);
        monitor.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void IGlfw.SetGammaRamp(
        Ptr<Monitor, Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] PtrToConst<Gammaramp, Gammaramp> ramp
    )
    {
        void __DSL_glfwSetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        ) =>
            (
                (delegate* unmanaged<Monitor*, Gammaramp*, void>)
                    nativeContext.LoadFunction("glfwSetGammaRamp", "glfw")
            )(monitor, ramp);
        __DSL_glfwSetGammaRamp(monitor, ramp);
        monitor.Dispose();
        ramp.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    public static void SetGammaRamp(
        Ptr<Monitor, Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] PtrToConst<Gammaramp, Gammaramp> ramp
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
        static extern void __DSL_glfwSetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        );
        __DSL_glfwSetGammaRamp(monitor, ramp);
        monitor.Dispose();
        ramp.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void IGlfw.SetInputMode(Ptr<Window, Window> window, int mode, int value)
    {
        void __DSL_glfwSetInputMode(Window* window, int mode, int value) =>
            (
                (delegate* unmanaged<Window*, int, int, void>)
                    nativeContext.LoadFunction("glfwSetInputMode", "glfw")
            )(window, mode, value);
        __DSL_glfwSetInputMode(window, mode, value);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    public static void SetInputMode(Ptr<Window, Window> window, int mode, int value)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
        static extern void __DSL_glfwSetInputMode(Window* window, int mode, int value);
        __DSL_glfwSetInputMode(window, mode, value);
        window.Dispose();
    }

    delegate* unmanaged<int, int, void> IGlfw.SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, int, void>,
                delegate* unmanaged<int, int, void>>)
                nativeContext.LoadFunction("SetJoystickCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWjoystickfun")]
    public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void IGlfw.SetJoystickUserPointer(int jid, Ptr pointer)
    {
        void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer) =>
            (
                (delegate* unmanaged<int, void*, void>)
                    nativeContext.LoadFunction("glfwSetJoystickUserPointer", "glfw")
            )(jid, pointer);
        __DSL_glfwSetJoystickUserPointer(jid, pointer);
        pointer.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    public static void SetJoystickUserPointer(int jid, Ptr pointer)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
        static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
        __DSL_glfwSetJoystickUserPointer(jid, pointer);
        pointer.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> IGlfw.SetKeyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, int, int, int, void> __DSL_glfwSetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, int, int, int, void>,
                    delegate* unmanaged<Window*, int, int, int, int, void>>)
                    nativeContext.LoadFunction("glfwSetKeyCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, int, int, int, void> ret = __DSL_glfwSetKeyCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
        [return: NativeTypeName("GLFWkeyfun")]
        static extern delegate* unmanaged<
            Window*,
            int,
            int,
            int,
            int,
            void> __DSL_glfwSetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );
        delegate* unmanaged<Window*, int, int, int, int, void> ret = __DSL_glfwSetKeyCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    delegate* unmanaged<Monitor*, int, void> IGlfw.SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<Monitor*, int, void>,
                delegate* unmanaged<Monitor*, int, void>>)
                nativeContext.LoadFunction("SetMonitorCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWmonitorfun")]
    public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void IGlfw.SetMonitorUserPointer(Ptr<Monitor, Monitor> monitor, Ptr pointer)
    {
        void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer) =>
            (
                (delegate* unmanaged<Monitor*, void*, void>)
                    nativeContext.LoadFunction("glfwSetMonitorUserPointer", "glfw")
            )(monitor, pointer);
        __DSL_glfwSetMonitorUserPointer(monitor, pointer);
        monitor.Dispose();
        pointer.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    public static void SetMonitorUserPointer(Ptr<Monitor, Monitor> monitor, Ptr pointer)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
        static extern void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);
        __DSL_glfwSetMonitorUserPointer(monitor, pointer);
        monitor.Dispose();
        pointer.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> IGlfw.SetMouseButtonCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, int, int, void> __DSL_glfwSetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, int, int, void>,
                    delegate* unmanaged<Window*, int, int, int, void>>)
                    nativeContext.LoadFunction("glfwSetMouseButtonCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, int, int, void> ret = __DSL_glfwSetMouseButtonCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
        [return: NativeTypeName("GLFWmousebuttonfun")]
        static extern delegate* unmanaged<
            Window*,
            int,
            int,
            int,
            void> __DSL_glfwSetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );
        delegate* unmanaged<Window*, int, int, int, void> ret = __DSL_glfwSetMouseButtonCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetScrollCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        delegate* unmanaged<Window*, double, double, void> __DSL_glfwSetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, double, double, void>,
                    delegate* unmanaged<Window*, double, double, void>>)
                    nativeContext.LoadFunction("glfwSetScrollCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetScrollCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
        [return: NativeTypeName("GLFWscrollfun")]
        static extern delegate* unmanaged<
            Window*,
            double,
            double,
            void> __DSL_glfwSetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );
        delegate* unmanaged<Window*, double, double, void> ret = __DSL_glfwSetScrollCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    void IGlfw.SetTime(double time) =>
        ((delegate* unmanaged<double, void>)nativeContext.LoadFunction("SetTime", "glfw"))(time);

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void IGlfw.SetWindowAspectRatio(Ptr<Window, Window> window, int numer, int denom)
    {
        void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom) =>
            (
                (delegate* unmanaged<Window*, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowAspectRatio", "glfw")
            )(window, numer, denom);
        __DSL_glfwSetWindowAspectRatio(window, numer, denom);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    public static void SetWindowAspectRatio(Ptr<Window, Window> window, int numer, int denom)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
        static extern void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom);
        __DSL_glfwSetWindowAspectRatio(window, numer, denom);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void IGlfw.SetWindowAttrib(Ptr<Window, Window> window, int attrib, int value)
    {
        void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value) =>
            (
                (delegate* unmanaged<Window*, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowAttrib", "glfw")
            )(window, attrib, value);
        __DSL_glfwSetWindowAttrib(window, attrib, value);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    public static void SetWindowAttrib(Ptr<Window, Window> window, int attrib, int value)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
        static extern void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value);
        __DSL_glfwSetWindowAttrib(window, attrib, value);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowCloseCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, void>,
                    delegate* unmanaged<Window*, void>>)
                    nativeContext.LoadFunction("glfwSetWindowCloseCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowCloseCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
        [return: NativeTypeName("GLFWwindowclosefun")]
        static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );
        delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowCloseCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> IGlfw.SetWindowContentScaleCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        delegate* unmanaged<Window*, float, float, void> __DSL_glfwSetWindowContentScaleCallback(
            Window* window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, float, float, void>,
                    delegate* unmanaged<Window*, float, float, void>>)
                    nativeContext.LoadFunction("glfwSetWindowContentScaleCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, float, float, void> ret =
            __DSL_glfwSetWindowContentScaleCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    public static delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowContentScaleCallback")]
        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        static extern delegate* unmanaged<
            Window*,
            float,
            float,
            void> __DSL_glfwSetWindowContentScaleCallback(
            Window* window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );
        delegate* unmanaged<Window*, float, float, void> ret =
            __DSL_glfwSetWindowContentScaleCallback(window, callback);
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowFocusCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, void>,
                    delegate* unmanaged<Window*, int, void>>)
                    nativeContext.LoadFunction("glfwSetWindowFocusCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowFocusCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
        [return: NativeTypeName("GLFWwindowfocusfun")]
        static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowFocusCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void IGlfw.SetWindowIcon(
        Ptr<Window, Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> images
    )
    {
        void __DSL_glfwSetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        ) =>
            (
                (delegate* unmanaged<Window*, int, Image*, void>)
                    nativeContext.LoadFunction("glfwSetWindowIcon", "glfw")
            )(window, count, images);
        __DSL_glfwSetWindowIcon(window, count, images);
        window.Dispose();
        images.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    public static void SetWindowIcon(
        Ptr<Window, Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] PtrToConst<Image, Image> images
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
        static extern void __DSL_glfwSetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        );
        __DSL_glfwSetWindowIcon(window, count, images);
        window.Dispose();
        images.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowIconifyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, void>,
                    delegate* unmanaged<Window*, int, void>>)
                    nativeContext.LoadFunction("glfwSetWindowIconifyCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowIconifyCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIconifyCallback")]
        [return: NativeTypeName("GLFWwindowiconifyfun")]
        static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowIconifyCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowMaximizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, void>,
                    delegate* unmanaged<Window*, int, void>>)
                    nativeContext.LoadFunction("glfwSetWindowMaximizeCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowMaximizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMaximizeCallback")]
        [return: NativeTypeName("GLFWwindowmaximizefun")]
        static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );
        delegate* unmanaged<Window*, int, void> ret = __DSL_glfwSetWindowMaximizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void IGlfw.SetWindowMonitor(
        Ptr<Window, Window> window,
        Ptr<Monitor, Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    )
    {
        void __DSL_glfwSetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) =>
            (
                (delegate* unmanaged<Window*, Monitor*, int, int, int, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowMonitor", "glfw")
            )(window, monitor, xpos, ypos, width, height, refreshRate);
        __DSL_glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
        window.Dispose();
        monitor.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    public static void SetWindowMonitor(
        Ptr<Window, Window> window,
        Ptr<Monitor, Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
        static extern void __DSL_glfwSetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );
        __DSL_glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
        window.Dispose();
        monitor.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void IGlfw.SetWindowOpacity(Ptr<Window, Window> window, float opacity)
    {
        void __DSL_glfwSetWindowOpacity(Window* window, float opacity) =>
            (
                (delegate* unmanaged<Window*, float, void>)
                    nativeContext.LoadFunction("glfwSetWindowOpacity", "glfw")
            )(window, opacity);
        __DSL_glfwSetWindowOpacity(window, opacity);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    public static void SetWindowOpacity(Ptr<Window, Window> window, float opacity)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
        static extern void __DSL_glfwSetWindowOpacity(Window* window, float opacity);
        __DSL_glfwSetWindowOpacity(window, opacity);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void IGlfw.SetWindowPos(Ptr<Window, Window> window, int xpos, int ypos)
    {
        void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos) =>
            (
                (delegate* unmanaged<Window*, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowPos", "glfw")
            )(window, xpos, ypos);
        __DSL_glfwSetWindowPos(window, xpos, ypos);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    public static void SetWindowPos(Ptr<Window, Window> window, int xpos, int ypos)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
        static extern void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos);
        __DSL_glfwSetWindowPos(window, xpos, ypos);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, int, void>,
                    delegate* unmanaged<Window*, int, int, void>>)
                    nativeContext.LoadFunction("glfwSetWindowPosCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowPosCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
        [return: NativeTypeName("GLFWwindowposfun")]
        static extern delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowPosCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowRefreshCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, void>,
                    delegate* unmanaged<Window*, void>>)
                    nativeContext.LoadFunction("glfwSetWindowRefreshCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowRefreshCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowRefreshCallback")]
        [return: NativeTypeName("GLFWwindowrefreshfun")]
        static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );
        delegate* unmanaged<Window*, void> ret = __DSL_glfwSetWindowRefreshCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void IGlfw.SetWindowShouldClose(Ptr<Window, Window> window, int value)
    {
        void __DSL_glfwSetWindowShouldClose(Window* window, int value) =>
            (
                (delegate* unmanaged<Window*, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowShouldClose", "glfw")
            )(window, value);
        __DSL_glfwSetWindowShouldClose(window, value);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    public static void SetWindowShouldClose(Ptr<Window, Window> window, int value)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
        static extern void __DSL_glfwSetWindowShouldClose(Window* window, int value);
        __DSL_glfwSetWindowShouldClose(window, value);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void IGlfw.SetWindowSize(Ptr<Window, Window> window, int width, int height)
    {
        void __DSL_glfwSetWindowSize(Window* window, int width, int height) =>
            (
                (delegate* unmanaged<Window*, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowSize", "glfw")
            )(window, width, height);
        __DSL_glfwSetWindowSize(window, width, height);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    public static void SetWindowSize(Ptr<Window, Window> window, int width, int height)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
        static extern void __DSL_glfwSetWindowSize(Window* window, int width, int height);
        __DSL_glfwSetWindowSize(window, width, height);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) =>
            (
                (delegate* unmanaged<
                    Window*,
                    delegate* unmanaged<Window*, int, int, void>,
                    delegate* unmanaged<Window*, int, int, void>>)
                    nativeContext.LoadFunction("glfwSetWindowSizeCallback", "glfw")
            )(window, callback);
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowSizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ptr<Window, Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
        [return: NativeTypeName("GLFWwindowsizefun")]
        static extern delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );
        delegate* unmanaged<Window*, int, int, void> ret = __DSL_glfwSetWindowSizeCallback(
            window,
            callback
        );
        window.Dispose();
        return ret;
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void IGlfw.SetWindowSizeLimits(
        Ptr<Window, Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        void __DSL_glfwSetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) =>
            (
                (delegate* unmanaged<Window*, int, int, int, int, void>)
                    nativeContext.LoadFunction("glfwSetWindowSizeLimits", "glfw")
            )(window, minwidth, minheight, maxwidth, maxheight);
        __DSL_glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    public static void SetWindowSizeLimits(
        Ptr<Window, Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
        static extern void __DSL_glfwSetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );
        __DSL_glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void IGlfw.SetWindowTitle(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title
    )
    {
        void __DSL_glfwSetWindowTitle(
            Window* window,
            [NativeTypeName("const char *")] sbyte* title
        ) =>
            (
                (delegate* unmanaged<Window*, sbyte*, void>)
                    nativeContext.LoadFunction("glfwSetWindowTitle", "glfw")
            )(window, title);
        __DSL_glfwSetWindowTitle(window, title);
        window.Dispose();
        title.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    public static void SetWindowTitle(
        Ptr<Window, Window> window,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> title
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
        static extern void __DSL_glfwSetWindowTitle(
            Window* window,
            [NativeTypeName("const char *")] sbyte* title
        );
        __DSL_glfwSetWindowTitle(window, title);
        window.Dispose();
        title.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void IGlfw.SetWindowUserPointer(Ptr<Window, Window> window, Ptr pointer)
    {
        void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer) =>
            (
                (delegate* unmanaged<Window*, void*, void>)
                    nativeContext.LoadFunction("glfwSetWindowUserPointer", "glfw")
            )(window, pointer);
        __DSL_glfwSetWindowUserPointer(window, pointer);
        window.Dispose();
        pointer.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    public static void SetWindowUserPointer(Ptr<Window, Window> window, Ptr pointer)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
        static extern void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer);
        __DSL_glfwSetWindowUserPointer(window, pointer);
        window.Dispose();
        pointer.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void IGlfw.ShowWindow(Ptr<Window, Window> window)
    {
        void __DSL_glfwShowWindow(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwShowWindow", "glfw")
            )(window);
        __DSL_glfwShowWindow(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    public static void ShowWindow(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
        static extern void __DSL_glfwShowWindow(Window* window);
        __DSL_glfwShowWindow(window);
        window.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void IGlfw.SwapBuffers(Ptr<Window, Window> window)
    {
        void __DSL_glfwSwapBuffers(Window* window) =>
            (
                (delegate* unmanaged<Window*, void>)
                    nativeContext.LoadFunction("glfwSwapBuffers", "glfw")
            )(window);
        __DSL_glfwSwapBuffers(window);
        window.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    public static void SwapBuffers(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
        static extern void __DSL_glfwSwapBuffers(Window* window);
        __DSL_glfwSwapBuffers(window);
        window.Dispose();
    }

    void IGlfw.SwapInterval(int interval) =>
        ((delegate* unmanaged<int, void>)nativeContext.LoadFunction("SwapInterval", "glfw"))(
            interval
        );

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void SwapInterval(int interval);

    void IGlfw.Terminate() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("Terminate", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int IGlfw.UpdateGamepadMappings(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
    )
    {
        int __DSL_glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
            (
                (delegate* unmanaged<sbyte*, int>)
                    nativeContext.LoadFunction("glfwUpdateGamepadMappings", "glfw")
            )(@string);
        int ret = __DSL_glfwUpdateGamepadMappings(@string);
        @string.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    public static int UpdateGamepadMappings(
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> @string
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
        static extern int __DSL_glfwUpdateGamepadMappings(
            [NativeTypeName("const char *")] sbyte* @string
        );
        int ret = __DSL_glfwUpdateGamepadMappings(@string);
        @string.Dispose();
        return ret;
    }

    int IGlfw.VulkanSupported() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("VulkanSupported", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern int VulkanSupported();

    void IGlfw.WaitEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("WaitEvents", "glfw"))();

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void WaitEvents();

    void IGlfw.WaitEventsTimeout(double timeout) =>
        (
            (delegate* unmanaged<double, void>)
                nativeContext.LoadFunction("WaitEventsTimeout", "glfw")
        )(timeout);

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void WaitEventsTimeout(double timeout);

    void IGlfw.WindowHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("WindowHint", "glfw"))(
            hint,
            value
        );

    [DllImport("glfw", ExactSpelling = true)]
    public static extern void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void IGlfw.WindowHintString(
        int hint,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> value
    )
    {
        void __DSL_glfwWindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value) =>
            (
                (delegate* unmanaged<int, sbyte*, void>)
                    nativeContext.LoadFunction("glfwWindowHintString", "glfw")
            )(hint, value);
        __DSL_glfwWindowHintString(hint, value);
        value.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    public static void WindowHintString(
        int hint,
        [NativeTypeName("const char *")] PtrToConst<sbyte, sbyte> value
    )
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
        static extern void __DSL_glfwWindowHintString(
            int hint,
            [NativeTypeName("const char *")] sbyte* value
        );
        __DSL_glfwWindowHintString(hint, value);
        value.Dispose();
    }

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int IGlfw.WindowShouldClose(Ptr<Window, Window> window)
    {
        int __DSL_glfwWindowShouldClose(Window* window) =>
            (
                (delegate* unmanaged<Window*, int>)
                    nativeContext.LoadFunction("glfwWindowShouldClose", "glfw")
            )(window);
        int ret = __DSL_glfwWindowShouldClose(window);
        window.Dispose();
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    public static int WindowShouldClose(Ptr<Window, Window> window)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
        static extern int __DSL_glfwWindowShouldClose(Window* window);
        int ret = __DSL_glfwWindowShouldClose(window);
        window.Dispose();
        return ret;
    }
}
