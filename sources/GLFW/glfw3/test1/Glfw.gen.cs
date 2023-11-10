// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

[SupportedApiProfile("test1")]
public unsafe partial class Glfw : IGlfw, IGlfw.Static<Glfw>
{
    public partial class DllImport : IGlfw.Static<DllImport>
    {
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        )
        {
            fixed (Image* __dsl_image = image)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
                [SupportedApiProfile("test1")]
                static extern Cursor* __DSL_glfwCreateCursor(
                    [NativeTypeName("const GLFWimage *")] Image* image,
                    int xhot,
                    int yhot
                );
                return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public static Ptr<Cursor> CreateStandardCursor(int shape)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
            [SupportedApiProfile("test1")]
            static extern Cursor* __DSL_glfwCreateStandardCursor(int shape);
            return __DSL_glfwCreateStandardCursor(shape);
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        )
        {
            fixed (Window* __dsl_share = share)
            fixed (Monitor* __dsl_monitor = monitor)
            fixed (sbyte* __dsl_title = title)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
                [SupportedApiProfile("test1")]
                static extern Window* __DSL_glfwCreateWindow(
                    int width,
                    int height,
                    [NativeTypeName("const char *")] sbyte* title,
                    Monitor* monitor,
                    Window* share
                );
                return __DSL_glfwCreateWindow(
                    width,
                    height,
                    __dsl_title,
                    __dsl_monitor,
                    __dsl_share
                );
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDefaultWindowHints")]
        [SupportedApiProfile("test1")]
        public static extern void DefaultWindowHints();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwDestroyCursor(Cursor* cursor);
                __DSL_glfwDestroyCursor(__dsl_cursor);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwDestroyWindow(Window* window);
                __DSL_glfwDestroyWindow(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
        {
            fixed (sbyte* __dsl_extension = extension)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwExtensionSupported(
                    [NativeTypeName("const char *")] sbyte* extension
                );
                return __DSL_glfwExtensionSupported(__dsl_extension);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwFocusWindow(Window* window);
                __DSL_glfwFocusWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static Ptr<sbyte> GetClipboardString(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
                [return: NativeTypeName("const char *")]
                [SupportedApiProfile("test1")]
                static extern sbyte* __DSL_glfwGetClipboardString(Window* window);
                return __DSL_glfwGetClipboardString(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Ptr<Window> GetCurrentContext()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
            [SupportedApiProfile("test1")]
            static extern Window* __DSL_glfwGetCurrentContext();
            return __DSL_glfwGetCurrentContext();
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
        {
            fixed (double* __dsl_ypos = ypos)
            fixed (double* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetCursorPos(
                    Window* window,
                    double* xpos,
                    double* ypos
                );
                __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
        {
            fixed (sbyte** __dsl_description = description)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetError(
                    [NativeTypeName("const char **")] sbyte** description
                );
                return __DSL_glfwGetError(__dsl_description);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetFramebufferSize(
                    Window* window,
                    int* width,
                    int* height
                );
                __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public static Ptr<sbyte> GetGamepadName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
            [return: NativeTypeName("const char *")]
            [SupportedApiProfile("test1")]
            static extern sbyte* __DSL_glfwGetGamepadName(int jid);
            return __DSL_glfwGetGamepadName(jid);
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Ref<Gamepadstate> state)
        {
            fixed (Gamepadstate* __dsl_state = state)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state);
                return __DSL_glfwGetGamepadState(jid, __dsl_state);
            }
        }

        [return: NativeTypeName("const GLFWgammaramp *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
                [return: NativeTypeName("const GLFWgammaramp *")]
                [SupportedApiProfile("test1")]
                static extern Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor);
                return __DSL_glfwGetGammaRamp(__dsl_monitor);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Ref<Window> window, int mode)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetInputMode(Window* window, int mode);
                return __DSL_glfwGetInputMode(__dsl_window, mode);
            }
        }

        [return: NativeTypeName("const float *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
                [return: NativeTypeName("const float *")]
                [SupportedApiProfile("test1")]
                static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
                return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
                [return: NativeTypeName("const unsigned char *")]
                [SupportedApiProfile("test1")]
                static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
                return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static Ptr<sbyte> GetJoystickGuid(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
            [return: NativeTypeName("const char *")]
            [SupportedApiProfile("test1")]
            static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
            return __DSL_glfwGetJoystickGUID(jid);
        }

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
                [return: NativeTypeName("const unsigned char *")]
                [SupportedApiProfile("test1")]
                static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
                return __DSL_glfwGetJoystickHats(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static Ptr<sbyte> GetJoystickName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
            [return: NativeTypeName("const char *")]
            [SupportedApiProfile("test1")]
            static extern sbyte* __DSL_glfwGetJoystickName(int jid);
            return __DSL_glfwGetJoystickName(jid);
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static Ptr GetJoystickUserPointer(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
            [SupportedApiProfile("test1")]
            static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
            return __DSL_glfwGetJoystickUserPointer(jid);
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Ref<Window> window, int key)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetKey(Window* window, int key);
                return __DSL_glfwGetKey(__dsl_window, key);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static Ptr<sbyte> GetKeyName(int key, int scancode)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
            [return: NativeTypeName("const char *")]
            [SupportedApiProfile("test1")]
            static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
            return __DSL_glfwGetKeyName(key, scancode);
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyScancode")]
        [SupportedApiProfile("test1")]
        public static extern int GetKeyScancode(int key);

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetMonitorContentScale(
                    Monitor* monitor,
                    float* xscale,
                    float* yscale
                );
                __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
                [return: NativeTypeName("const char *")]
                [SupportedApiProfile("test1")]
                static extern sbyte* __DSL_glfwGetMonitorName(Monitor* monitor);
                return __DSL_glfwGetMonitorName(__dsl_monitor);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        )
        {
            fixed (int* __dsl_heightMM = heightMM)
            fixed (int* __dsl_widthMM = widthMM)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetMonitorPhysicalSize(
                    Monitor* monitor,
                    int* widthMM,
                    int* heightMM
                );
                __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos);
                __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static Ptr2D<Monitor> GetMonitors(Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
                [SupportedApiProfile("test1")]
                static extern Monitor** __DSL_glfwGetMonitors(int* count);
                return __DSL_glfwGetMonitors(__dsl_count);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
                [SupportedApiProfile("test1")]
                static extern void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor);
                return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        )
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetMonitorWorkarea(
                    Monitor* monitor,
                    int* xpos,
                    int* ypos,
                    int* width,
                    int* height
                );
                __DSL_glfwGetMonitorWorkarea(
                    __dsl_monitor,
                    __dsl_xpos,
                    __dsl_ypos,
                    __dsl_width,
                    __dsl_height
                );
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Ref<Window> window, int button)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetMouseButton(Window* window, int button);
                return __DSL_glfwGetMouseButton(__dsl_window, button);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPlatform")]
        [SupportedApiProfile("test1")]
        public static extern int GetPlatform();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Ptr<Monitor> GetPrimaryMonitor()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
            [SupportedApiProfile("test1")]
            static extern Monitor* __DSL_glfwGetPrimaryMonitor();
            return __DSL_glfwGetPrimaryMonitor();
        }

        [return: NativeTypeName("GLFWglproc")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        )
        {
            fixed (sbyte* __dsl_procname = procname)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
                [return: NativeTypeName("GLFWglproc")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                    [NativeTypeName("const char *")] sbyte* procname
                );
                return __DSL_glfwGetProcAddress(__dsl_procname);
            }
        }

        [return: NativeTypeName("const char **")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        )
        {
            fixed (uint* __dsl_count = count)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwGetRequiredInstanceExtensions"
                )]
                [return: NativeTypeName("const char **")]
                [SupportedApiProfile("test1")]
                static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                    [NativeTypeName("uint32_t *")] uint* count
                );
                return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTime")]
        [SupportedApiProfile("test1")]
        public static extern double GetTime();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerFrequency")]
        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        public static extern ulong GetTimerFrequency();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerValue")]
        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        public static extern ulong GetTimerValue();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
        {
            fixed (int* __dsl_rev = rev)
            fixed (int* __dsl_minor = minor)
            fixed (int* __dsl_major = major)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
                __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
            }
        }

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public static Ptr<sbyte> GetVersionString()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
            [return: NativeTypeName("const char *")]
            [SupportedApiProfile("test1")]
            static extern sbyte* __DSL_glfwGetVersionString();
            return __DSL_glfwGetVersionString();
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
                [return: NativeTypeName("const GLFWvidmode *")]
                [SupportedApiProfile("test1")]
                static extern Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor);
                return __DSL_glfwGetVideoMode(__dsl_monitor);
            }
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
                [return: NativeTypeName("const GLFWvidmode *")]
                [SupportedApiProfile("test1")]
                static extern Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count);
                return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Ref<Window> window, int attrib)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwGetWindowAttrib(Window* window, int attrib);
                return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetWindowContentScale(
                    Window* window,
                    float* xscale,
                    float* yscale
                );
                __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        )
        {
            fixed (int* __dsl_bottom = bottom)
            fixed (int* __dsl_right = right)
            fixed (int* __dsl_top = top)
            fixed (int* __dsl_left = left)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetWindowFrameSize(
                    Window* window,
                    int* left,
                    int* top,
                    int* right,
                    int* bottom
                );
                __DSL_glfwGetWindowFrameSize(
                    __dsl_window,
                    __dsl_left,
                    __dsl_top,
                    __dsl_right,
                    __dsl_bottom
                );
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
                [SupportedApiProfile("test1")]
                static extern Monitor* __DSL_glfwGetWindowMonitor(Window* window);
                return __DSL_glfwGetWindowMonitor(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
                [SupportedApiProfile("test1")]
                static extern float __DSL_glfwGetWindowOpacity(Window* window);
                return __DSL_glfwGetWindowOpacity(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos);
                __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwGetWindowSize(Window* window, int* width, int* height);
                __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static Ptr GetWindowUserPointer(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
                [SupportedApiProfile("test1")]
                static extern void* __DSL_glfwGetWindowUserPointer(Window* window);
                return __DSL_glfwGetWindowUserPointer(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwHideWindow(Window* window);
                __DSL_glfwHideWindow(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwIconifyWindow(Window* window);
                __DSL_glfwIconifyWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInit")]
        [SupportedApiProfile("test1")]
        public static extern int Init();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        )
        {
            fixed (Allocator* __dsl_allocator = allocator)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwInitAllocator(
                    [NativeTypeName("const GLFWallocator *")] Allocator* allocator
                );
                __DSL_glfwInitAllocator(__dsl_allocator);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitHint")]
        [SupportedApiProfile("test1")]
        public static extern void InitHint(int hint, int value);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickIsGamepad")]
        [SupportedApiProfile("test1")]
        public static extern int JoystickIsGamepad(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickPresent")]
        [SupportedApiProfile("test1")]
        public static extern int JoystickPresent(int jid);

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwMakeContextCurrent(Window* window);
                __DSL_glfwMakeContextCurrent(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwMaximizeWindow(Window* window);
                __DSL_glfwMaximizeWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPlatformSupported")]
        [SupportedApiProfile("test1")]
        public static extern int PlatformSupported(int platform);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPollEvents")]
        [SupportedApiProfile("test1")]
        public static extern void PollEvents();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPostEmptyEvent")]
        [SupportedApiProfile("test1")]
        public static extern void PostEmptyEvent();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRawMouseMotionSupported")]
        [SupportedApiProfile("test1")]
        public static extern int RawMouseMotionSupported();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwRequestWindowAttention(Window* window);
                __DSL_glfwRequestWindowAttention(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwRestoreWindow(Window* window);
                __DSL_glfwRestoreWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("GLFWcharfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
                [return: NativeTypeName("GLFWcharfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
                    Window* window,
                    [NativeTypeName("GLFWcharfun")]
                        delegate* unmanaged<Window*, uint, void> callback
                );
                return __DSL_glfwSetCharCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWcharmodsfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
                [return: NativeTypeName("GLFWcharmodsfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    uint,
                    int,
                    void> __DSL_glfwSetCharModsCallback(
                    Window* window,
                    [NativeTypeName("GLFWcharmodsfun")]
                        delegate* unmanaged<Window*, uint, int, void> callback
                );
                return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public static void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetClipboardString(
                    Window* window,
                    [NativeTypeName("const char *")] sbyte* @string
                );
                __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetCursor(Window* window, Cursor* cursor);
                __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
            }
        }

        [return: NativeTypeName("GLFWcursorenterfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
                [return: NativeTypeName("GLFWcursorenterfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetCursorEnterCallback(
                    Window* window,
                    [NativeTypeName("GLFWcursorenterfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public static void SetCursorPos(Ref<Window> window, double xpos, double ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos);
                __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWcursorposfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
                [return: NativeTypeName("GLFWcursorposfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    double,
                    double,
                    void> __DSL_glfwSetCursorPosCallback(
                    Window* window,
                    [NativeTypeName("GLFWcursorposfun")]
                        delegate* unmanaged<Window*, double, double, void> callback
                );
                return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWdropfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
                [return: NativeTypeName("GLFWdropfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    sbyte**,
                    void> __DSL_glfwSetDropCallback(
                    Window* window,
                    [NativeTypeName("GLFWdropfun")]
                        delegate* unmanaged<Window*, int, sbyte**, void> callback
                );
                return __DSL_glfwSetDropCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetErrorCallback")]
        [return: NativeTypeName("GLFWerrorfun")]
        [SupportedApiProfile("test1")]
        public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetFramebufferSizeCallback"
                )]
                [return: NativeTypeName("GLFWframebuffersizefun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetFramebufferSizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWframebuffersizefun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public static void SetGamma(Ref<Monitor> monitor, float gamma)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetGamma(Monitor* monitor, float gamma);
                __DSL_glfwSetGamma(__dsl_monitor, gamma);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        )
        {
            fixed (Gammaramp* __dsl_ramp = ramp)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetGammaRamp(
                    Monitor* monitor,
                    [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
                );
                __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public static void SetInputMode(Ref<Window> window, int mode, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetInputMode(Window* window, int mode, int value);
                __DSL_glfwSetInputMode(__dsl_window, mode, value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickCallback")]
        [return: NativeTypeName("GLFWjoystickfun")]
        [SupportedApiProfile("test1")]
        public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
                __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWkeyfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
                [return: NativeTypeName("GLFWkeyfun")]
                [SupportedApiProfile("test1")]
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
                return __DSL_glfwSetKeyCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorCallback")]
        [return: NativeTypeName("GLFWmonitorfun")]
        [SupportedApiProfile("test1")]
        public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);
                __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
                [return: NativeTypeName("GLFWmousebuttonfun")]
                [SupportedApiProfile("test1")]
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
                return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWscrollfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
                [return: NativeTypeName("GLFWscrollfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    double,
                    double,
                    void> __DSL_glfwSetScrollCallback(
                    Window* window,
                    [NativeTypeName("GLFWscrollfun")]
                        delegate* unmanaged<Window*, double, double, void> callback
                );
                return __DSL_glfwSetScrollCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetTime")]
        [SupportedApiProfile("test1")]
        public static extern void SetTime(double time);

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowAspectRatio(
                    Window* window,
                    int numer,
                    int denom
                );
                __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Ref<Window> window, int attrib, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value);
                __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
            }
        }

        [return: NativeTypeName("GLFWwindowclosefun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
                [return: NativeTypeName("GLFWwindowclosefun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowclosefun")]
                        delegate* unmanaged<Window*, void> callback
                );
                return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowContentScaleCallback"
                )]
                [return: NativeTypeName("GLFWwindowcontentscalefun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    float,
                    float,
                    void> __DSL_glfwSetWindowContentScaleCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowcontentscalefun")]
                        delegate* unmanaged<Window*, float, float, void> callback
                );
                return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
                [return: NativeTypeName("GLFWwindowfocusfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowFocusCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowfocusfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public static void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        )
        {
            fixed (Image* __dsl_images = images)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowIcon(
                    Window* window,
                    int count,
                    [NativeTypeName("const GLFWimage *")] Image* images
                );
                __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
            }
        }

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowIconifyCallback"
                )]
                [return: NativeTypeName("GLFWwindowiconifyfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowIconifyCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowiconifyfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowMaximizeCallback"
                )]
                [return: NativeTypeName("GLFWwindowmaximizefun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowMaximizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowmaximizefun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public static void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        )
        {
            fixed (Monitor* __dsl_monitor = monitor)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowMonitor(
                    Window* window,
                    Monitor* monitor,
                    int xpos,
                    int ypos,
                    int width,
                    int height,
                    int refreshRate
                );
                __DSL_glfwSetWindowMonitor(
                    __dsl_window,
                    __dsl_monitor,
                    xpos,
                    ypos,
                    width,
                    height,
                    refreshRate
                );
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public static void SetWindowOpacity(Ref<Window> window, float opacity)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowOpacity(Window* window, float opacity);
                __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Ref<Window> window, int xpos, int ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos);
                __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWwindowposfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
                [return: NativeTypeName("GLFWwindowposfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetWindowPosCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowposfun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowRefreshCallback"
                )]
                [return: NativeTypeName("GLFWwindowrefreshfun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowrefreshfun")]
                        delegate* unmanaged<Window*, void> callback
                );
                return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public static void SetWindowShouldClose(Ref<Window> window, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowShouldClose(Window* window, int value);
                __DSL_glfwSetWindowShouldClose(__dsl_window, value);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Ref<Window> window, int width, int height)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowSize(Window* window, int width, int height);
                __DSL_glfwSetWindowSize(__dsl_window, width, height);
            }
        }

        [return: NativeTypeName("GLFWwindowsizefun")]
        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
                [return: NativeTypeName("GLFWwindowsizefun")]
                [SupportedApiProfile("test1")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetWindowSizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowsizefun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public static void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowSizeLimits(
                    Window* window,
                    int minwidth,
                    int minheight,
                    int maxwidth,
                    int maxheight
                );
                __DSL_glfwSetWindowSizeLimits(
                    __dsl_window,
                    minwidth,
                    minheight,
                    maxwidth,
                    maxheight
                );
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public static void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        )
        {
            fixed (sbyte* __dsl_title = title)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowTitle(
                    Window* window,
                    [NativeTypeName("const char *")] sbyte* title
                );
                __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Ref<Window> window, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer);
                __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwShowWindow(Window* window);
                __DSL_glfwShowWindow(__dsl_window);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwSwapBuffers(Window* window);
                __DSL_glfwSwapBuffers(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapInterval")]
        [SupportedApiProfile("test1")]
        public static extern void SwapInterval(int interval);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwTerminate")]
        [SupportedApiProfile("test1")]
        public static extern void Terminate();

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
        {
            fixed (sbyte* __dsl_string = @string)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwUpdateGamepadMappings(
                    [NativeTypeName("const char *")] sbyte* @string
                );
                return __DSL_glfwUpdateGamepadMappings(__dsl_string);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwVulkanSupported")]
        [SupportedApiProfile("test1")]
        public static extern int VulkanSupported();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEvents")]
        [SupportedApiProfile("test1")]
        public static extern void WaitEvents();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEventsTimeout")]
        [SupportedApiProfile("test1")]
        public static extern void WaitEventsTimeout(double timeout);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHint")]
        [SupportedApiProfile("test1")]
        public static extern void WindowHint(int hint, int value);

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        )
        {
            fixed (sbyte* __dsl_value = value)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
                [SupportedApiProfile("test1")]
                static extern void __DSL_glfwWindowHintString(
                    int hint,
                    [NativeTypeName("const char *")] sbyte* value
                );
                __DSL_glfwWindowHintString(hint, __dsl_value);
            }
        }

        [SupportedApiProfile("test1")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
                [SupportedApiProfile("test1")]
                static extern int __DSL_glfwWindowShouldClose(Window* window);
                return __DSL_glfwWindowShouldClose(__dsl_window);
            }
        }
    }

    public partial class StaticWrapper<T> : IGlfw
        where T : IGlfw.Static<T>
    {
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        ) => T.CreateCursor(image, xhot, yhot);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public Ptr<Cursor> CreateStandardCursor(int shape) => T.CreateStandardCursor(shape);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        ) => T.CreateWindow(width, height, title, monitor, share);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        public void DefaultWindowHints() => T.DefaultWindowHints();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public void DestroyCursor(Ref<Cursor> cursor) => T.DestroyCursor(cursor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public void DestroyWindow(Ref<Window> window) => T.DestroyWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension) =>
            T.ExtensionSupported(extension);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public void FocusWindow(Ref<Window> window) => T.FocusWindow(window);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public Ptr<sbyte> GetClipboardString(Ref<Window> window) => T.GetClipboardString(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public Ptr<Window> GetCurrentContext() => T.GetCurrentContext();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos) =>
            T.GetCursorPos(window, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description) =>
            T.GetError(description);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
            T.GetFramebufferSize(window, width, height);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public Ptr<sbyte> GetGamepadName(int jid) => T.GetGamepadName(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public int GetGamepadState(int jid, Ref<Gamepadstate> state) =>
            T.GetGamepadState(jid, state);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor) => T.GetGammaRamp(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public int GetInputMode(Ref<Window> window, int mode) => T.GetInputMode(window, mode);

        [return: NativeTypeName("const float *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public Ptr<float> GetJoystickAxes(int jid, Ref<int> count) => T.GetJoystickAxes(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public Ptr<byte> GetJoystickButtons(int jid, Ref<int> count) =>
            T.GetJoystickButtons(jid, count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public Ptr<sbyte> GetJoystickGuid(int jid) => T.GetJoystickGuid(jid);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public Ptr<byte> GetJoystickHats(int jid, Ref<int> count) => T.GetJoystickHats(jid, count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public Ptr<sbyte> GetJoystickName(int jid) => T.GetJoystickName(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public Ptr GetJoystickUserPointer(int jid) => T.GetJoystickUserPointer(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public int GetKey(Ref<Window> window, int key) => T.GetKey(window, key);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public Ptr<sbyte> GetKeyName(int key, int scancode) => T.GetKeyName(key, scancode);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        public int GetKeyScancode(int key) => T.GetKeyScancode(key);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        ) => T.GetMonitorContentScale(monitor, xscale, yscale);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor) => T.GetMonitorName(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        ) => T.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos) =>
            T.GetMonitorPos(monitor, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public Ptr2D<Monitor> GetMonitors(Ref<int> count) => T.GetMonitors(count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public Ptr GetMonitorUserPointer(Ref<Monitor> monitor) => T.GetMonitorUserPointer(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        ) => T.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public int GetMouseButton(Ref<Window> window, int button) =>
            T.GetMouseButton(window, button);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        public int GetPlatform() => T.GetPlatform();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public Ptr<Monitor> GetPrimaryMonitor() => T.GetPrimaryMonitor();

        [return: NativeTypeName("GLFWglproc")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        ) => T.GetProcAddress(procname);

        [return: NativeTypeName("const char **")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        ) => T.GetRequiredInstanceExtensions(count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        public double GetTime() => T.GetTime();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        public ulong GetTimerFrequency() => T.GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        public ulong GetTimerValue() => T.GetTimerValue();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev) =>
            T.GetVersion(major, minor, rev);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public Ptr<sbyte> GetVersionString() => T.GetVersionString();

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor) => T.GetVideoMode(monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count) =>
            T.GetVideoModes(monitor, count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public int GetWindowAttrib(Ref<Window> window, int attrib) =>
            T.GetWindowAttrib(window, attrib);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        ) => T.GetWindowContentScale(window, xscale, yscale);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        ) => T.GetWindowFrameSize(window, left, top, right, bottom);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public Ptr<Monitor> GetWindowMonitor(Ref<Window> window) => T.GetWindowMonitor(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public float GetWindowOpacity(Ref<Window> window) => T.GetWindowOpacity(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos) =>
            T.GetWindowPos(window, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
            T.GetWindowSize(window, width, height);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public Ptr GetWindowUserPointer(Ref<Window> window) => T.GetWindowUserPointer(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public void HideWindow(Ref<Window> window) => T.HideWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public void IconifyWindow(Ref<Window> window) => T.IconifyWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        public int Init() => T.Init();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        ) => T.InitAllocator(allocator);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        public void InitHint(int hint, int value) => T.InitHint(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        public int JoystickIsGamepad(int jid) => T.JoystickIsGamepad(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        public int JoystickPresent(int jid) => T.JoystickPresent(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public void MakeContextCurrent(Ref<Window> window) => T.MakeContextCurrent(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public void MaximizeWindow(Ref<Window> window) => T.MaximizeWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        public int PlatformSupported(int platform) => T.PlatformSupported(platform);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        public void PollEvents() => T.PollEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        public void PostEmptyEvent() => T.PostEmptyEvent();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        public int RawMouseMotionSupported() => T.RawMouseMotionSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public void RequestWindowAttention(Ref<Window> window) => T.RequestWindowAttention(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public void RestoreWindow(Ref<Window> window) => T.RestoreWindow(window);

        [return: NativeTypeName("GLFWcharfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) => T.SetCharCallback(window, callback);

        [return: NativeTypeName("GLFWcharmodsfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) => T.SetCharModsCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        ) => T.SetClipboardString(window, @string);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public void SetCursor(Ref<Window> window, Ref<Cursor> cursor) =>
            T.SetCursor(window, cursor);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetCursorEnterCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public void SetCursorPos(Ref<Window> window, double xpos, double ypos) =>
            T.SetCursorPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWcursorposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetCursorPosCallback(window, callback);

        [return: NativeTypeName("GLFWdropfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) => T.SetDropCallback(window, callback);

        [return: NativeTypeName("GLFWerrorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        public delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        ) => T.SetErrorCallback(callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetFramebufferSizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public void SetGamma(Ref<Monitor> monitor, float gamma) => T.SetGamma(monitor, gamma);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        ) => T.SetGammaRamp(monitor, ramp);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public void SetInputMode(Ref<Window> window, int mode, int value) =>
            T.SetInputMode(window, mode, value);

        [return: NativeTypeName("GLFWjoystickfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        public delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        ) => T.SetJoystickCallback(callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public void SetJoystickUserPointer(int jid, Ref pointer) =>
            T.SetJoystickUserPointer(jid, pointer);

        [return: NativeTypeName("GLFWkeyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) => T.SetKeyCallback(window, callback);

        [return: NativeTypeName("GLFWmonitorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        public delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        ) => T.SetMonitorCallback(callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer) =>
            T.SetMonitorUserPointer(monitor, pointer);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) => T.SetMouseButtonCallback(window, callback);

        [return: NativeTypeName("GLFWscrollfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetScrollCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        public void SetTime(double time) => T.SetTime(time);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public void SetWindowAspectRatio(Ref<Window> window, int numer, int denom) =>
            T.SetWindowAspectRatio(window, numer, denom);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public void SetWindowAttrib(Ref<Window> window, int attrib, int value) =>
            T.SetWindowAttrib(window, attrib, value);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowCloseCallback(window, callback);

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) => T.SetWindowContentScaleCallback(window, callback);

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowFocusCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        ) => T.SetWindowIcon(window, count, images);

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowIconifyCallback(window, callback);

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowMaximizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) => T.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public void SetWindowOpacity(Ref<Window> window, float opacity) =>
            T.SetWindowOpacity(window, opacity);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public void SetWindowPos(Ref<Window> window, int xpos, int ypos) =>
            T.SetWindowPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWwindowposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowPosCallback(window, callback);

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowRefreshCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public void SetWindowShouldClose(Ref<Window> window, int value) =>
            T.SetWindowShouldClose(window, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public void SetWindowSize(Ref<Window> window, int width, int height) =>
            T.SetWindowSize(window, width, height);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowSizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) => T.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        ) => T.SetWindowTitle(window, title);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public void SetWindowUserPointer(Ref<Window> window, Ref pointer) =>
            T.SetWindowUserPointer(window, pointer);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public void ShowWindow(Ref<Window> window) => T.ShowWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public void SwapBuffers(Ref<Window> window) => T.SwapBuffers(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        public void SwapInterval(int interval) => T.SwapInterval(interval);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        public void Terminate() => T.Terminate();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string) =>
            T.UpdateGamepadMappings(@string);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        public int VulkanSupported() => T.VulkanSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        public void WaitEvents() => T.WaitEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        public void WaitEventsTimeout(double timeout) => T.WaitEventsTimeout(timeout);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        public void WindowHint(int hint, int value) => T.WindowHint(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public void WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value) =>
            T.WindowHintString(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public int WindowShouldClose(Ref<Window> window) => T.WindowShouldClose(window);
    }

    public partial class ThisThread
    {
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        ) => Underlying.Value!.CreateCursor(image, xhot, yhot);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public static Ptr<Cursor> CreateStandardCursor(int shape) =>
            Underlying.Value!.CreateStandardCursor(shape);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        ) => Underlying.Value!.CreateWindow(width, height, title, monitor, share);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        public static void DefaultWindowHints() => Underlying.Value!.DefaultWindowHints();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Ref<Cursor> cursor) =>
            Underlying.Value!.DestroyCursor(cursor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Ref<Window> window) =>
            Underlying.Value!.DestroyWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported(
            [NativeTypeName("const char *")] Ref<sbyte> extension
        ) => Underlying.Value!.ExtensionSupported(extension);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Ref<Window> window) => Underlying.Value!.FocusWindow(window);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static Ptr<sbyte> GetClipboardString(Ref<Window> window) =>
            Underlying.Value!.GetClipboardString(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Ptr<Window> GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos) =>
            Underlying.Value!.GetCursorPos(window, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description) =>
            Underlying.Value!.GetError(description);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(
            Ref<Window> window,
            Ref<int> width,
            Ref<int> height
        ) => Underlying.Value!.GetFramebufferSize(window, width, height);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public static Ptr<sbyte> GetGamepadName(int jid) => Underlying.Value!.GetGamepadName(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Ref<Gamepadstate> state) =>
            Underlying.Value!.GetGamepadState(jid, state);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor) =>
            Underlying.Value!.GetGammaRamp(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Ref<Window> window, int mode) =>
            Underlying.Value!.GetInputMode(window, mode);

        [return: NativeTypeName("const float *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count) =>
            Underlying.Value!.GetJoystickAxes(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count) =>
            Underlying.Value!.GetJoystickButtons(jid, count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static Ptr<sbyte> GetJoystickGuid(int jid) => Underlying.Value!.GetJoystickGuid(jid);

        [return: NativeTypeName("const unsigned char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count) =>
            Underlying.Value!.GetJoystickHats(jid, count);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static Ptr<sbyte> GetJoystickName(int jid) => Underlying.Value!.GetJoystickName(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static Ptr GetJoystickUserPointer(int jid) =>
            Underlying.Value!.GetJoystickUserPointer(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Ref<Window> window, int key) =>
            Underlying.Value!.GetKey(window, key);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static Ptr<sbyte> GetKeyName(int key, int scancode) =>
            Underlying.Value!.GetKeyName(key, scancode);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        public static int GetKeyScancode(int key) => Underlying.Value!.GetKeyScancode(key);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        ) => Underlying.Value!.GetMonitorContentScale(monitor, xscale, yscale);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor) =>
            Underlying.Value!.GetMonitorName(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        ) => Underlying.Value!.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos) =>
            Underlying.Value!.GetMonitorPos(monitor, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static Ptr2D<Monitor> GetMonitors(Ref<int> count) =>
            Underlying.Value!.GetMonitors(count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor) =>
            Underlying.Value!.GetMonitorUserPointer(monitor);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        ) => Underlying.Value!.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Ref<Window> window, int button) =>
            Underlying.Value!.GetMouseButton(window, button);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        public static int GetPlatform() => Underlying.Value!.GetPlatform();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Ptr<Monitor> GetPrimaryMonitor() => Underlying.Value!.GetPrimaryMonitor();

        [return: NativeTypeName("GLFWglproc")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        ) => Underlying.Value!.GetProcAddress(procname);

        [return: NativeTypeName("const char **")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        ) => Underlying.Value!.GetRequiredInstanceExtensions(count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        public static double GetTime() => Underlying.Value!.GetTime();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        public static ulong GetTimerFrequency() => Underlying.Value!.GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        public static ulong GetTimerValue() => Underlying.Value!.GetTimerValue();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev) =>
            Underlying.Value!.GetVersion(major, minor, rev);

        [return: NativeTypeName("const char *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public static Ptr<sbyte> GetVersionString() => Underlying.Value!.GetVersionString();

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor) =>
            Underlying.Value!.GetVideoMode(monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count) =>
            Underlying.Value!.GetVideoModes(monitor, count);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Ref<Window> window, int attrib) =>
            Underlying.Value!.GetWindowAttrib(window, attrib);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        ) => Underlying.Value!.GetWindowContentScale(window, xscale, yscale);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        ) => Underlying.Value!.GetWindowFrameSize(window, left, top, right, bottom);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window) =>
            Underlying.Value!.GetWindowMonitor(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Ref<Window> window) =>
            Underlying.Value!.GetWindowOpacity(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos) =>
            Underlying.Value!.GetWindowPos(window, xpos, ypos);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
            Underlying.Value!.GetWindowSize(window, width, height);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static Ptr GetWindowUserPointer(Ref<Window> window) =>
            Underlying.Value!.GetWindowUserPointer(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Ref<Window> window) => Underlying.Value!.HideWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Ref<Window> window) =>
            Underlying.Value!.IconifyWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        public static int Init() => Underlying.Value!.Init();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        ) => Underlying.Value!.InitAllocator(allocator);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        public static void InitHint(int hint, int value) => Underlying.Value!.InitHint(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        public static int JoystickIsGamepad(int jid) => Underlying.Value!.JoystickIsGamepad(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        public static int JoystickPresent(int jid) => Underlying.Value!.JoystickPresent(jid);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Ref<Window> window) =>
            Underlying.Value!.MakeContextCurrent(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Ref<Window> window) =>
            Underlying.Value!.MaximizeWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        public static int PlatformSupported(int platform) =>
            Underlying.Value!.PlatformSupported(platform);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        public static void PollEvents() => Underlying.Value!.PollEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        public static void PostEmptyEvent() => Underlying.Value!.PostEmptyEvent();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        public static int RawMouseMotionSupported() => Underlying.Value!.RawMouseMotionSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Ref<Window> window) =>
            Underlying.Value!.RequestWindowAttention(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Ref<Window> window) =>
            Underlying.Value!.RestoreWindow(window);

        [return: NativeTypeName("GLFWcharfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) => Underlying.Value!.SetCharCallback(window, callback);

        [return: NativeTypeName("GLFWcharmodsfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) => Underlying.Value!.SetCharModsCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public static void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        ) => Underlying.Value!.SetClipboardString(window, @string);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor) =>
            Underlying.Value!.SetCursor(window, cursor);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetCursorEnterCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public static void SetCursorPos(Ref<Window> window, double xpos, double ypos) =>
            Underlying.Value!.SetCursorPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWcursorposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => Underlying.Value!.SetCursorPosCallback(window, callback);

        [return: NativeTypeName("GLFWdropfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) => Underlying.Value!.SetDropCallback(window, callback);

        [return: NativeTypeName("GLFWerrorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        public static delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        ) => Underlying.Value!.SetErrorCallback(callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetFramebufferSizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public static void SetGamma(Ref<Monitor> monitor, float gamma) =>
            Underlying.Value!.SetGamma(monitor, gamma);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        ) => Underlying.Value!.SetGammaRamp(monitor, ramp);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public static void SetInputMode(Ref<Window> window, int mode, int value) =>
            Underlying.Value!.SetInputMode(window, mode, value);

        [return: NativeTypeName("GLFWjoystickfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        public static delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        ) => Underlying.Value!.SetJoystickCallback(callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, Ref pointer) =>
            Underlying.Value!.SetJoystickUserPointer(jid, pointer);

        [return: NativeTypeName("GLFWkeyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) => Underlying.Value!.SetKeyCallback(window, callback);

        [return: NativeTypeName("GLFWmonitorfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        public static delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        ) => Underlying.Value!.SetMonitorCallback(callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer) =>
            Underlying.Value!.SetMonitorUserPointer(monitor, pointer);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) => Underlying.Value!.SetMouseButtonCallback(window, callback);

        [return: NativeTypeName("GLFWscrollfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => Underlying.Value!.SetScrollCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        public static void SetTime(double time) => Underlying.Value!.SetTime(time);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom) =>
            Underlying.Value!.SetWindowAspectRatio(window, numer, denom);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Ref<Window> window, int attrib, int value) =>
            Underlying.Value!.SetWindowAttrib(window, attrib, value);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) => Underlying.Value!.SetWindowCloseCallback(window, callback);

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) => Underlying.Value!.SetWindowContentScaleCallback(window, callback);

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowFocusCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public static void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        ) => Underlying.Value!.SetWindowIcon(window, count, images);

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowIconifyCallback(window, callback);

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowMaximizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public static void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) =>
            Underlying.Value!.SetWindowMonitor(
                window,
                monitor,
                xpos,
                ypos,
                width,
                height,
                refreshRate
            );

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public static void SetWindowOpacity(Ref<Window> window, float opacity) =>
            Underlying.Value!.SetWindowOpacity(window, opacity);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Ref<Window> window, int xpos, int ypos) =>
            Underlying.Value!.SetWindowPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWwindowposfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetWindowPosCallback(window, callback);

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) => Underlying.Value!.SetWindowRefreshCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public static void SetWindowShouldClose(Ref<Window> window, int value) =>
            Underlying.Value!.SetWindowShouldClose(window, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Ref<Window> window, int width, int height) =>
            Underlying.Value!.SetWindowSize(window, width, height);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetWindowSizeCallback(window, callback);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public static void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) =>
            Underlying.Value!.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public static void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        ) => Underlying.Value!.SetWindowTitle(window, title);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Ref<Window> window, Ref pointer) =>
            Underlying.Value!.SetWindowUserPointer(window, pointer);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Ref<Window> window) => Underlying.Value!.ShowWindow(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Ref<Window> window) => Underlying.Value!.SwapBuffers(window);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        public static void SwapInterval(int interval) => Underlying.Value!.SwapInterval(interval);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        public static void Terminate() => Underlying.Value!.Terminate();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings(
            [NativeTypeName("const char *")] Ref<sbyte> @string
        ) => Underlying.Value!.UpdateGamepadMappings(@string);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        public static int VulkanSupported() => Underlying.Value!.VulkanSupported();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        public static void WaitEvents() => Underlying.Value!.WaitEvents();

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        public static void WaitEventsTimeout(double timeout) =>
            Underlying.Value!.WaitEventsTimeout(timeout);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        public static void WindowHint(int hint, int value) =>
            Underlying.Value!.WindowHint(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        ) => Underlying.Value!.WindowHintString(hint, value);

        [SupportedApiProfile("test1")]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Ref<Window> window) =>
            Underlying.Value!.WindowShouldClose(window);
    };

    [NativeTypeName("#define GLFW_VERSION_MAJOR 3")]
    [SupportedApiProfile("test1")]
    public const int VersionMajor = 3;

    [NativeTypeName("#define GLFW_VERSION_MINOR 4")]
    [SupportedApiProfile("test1")]
    public const int VersionMinor = 4;

    [NativeTypeName("#define GLFW_VERSION_REVISION 0")]
    [SupportedApiProfile("test1")]
    public const int VersionRevision = 0;

    [NativeTypeName("#define GLFW_TRUE 1")]
    [SupportedApiProfile("test1")]
    public const int True = 1;

    [NativeTypeName("#define GLFW_FALSE 0")]
    [SupportedApiProfile("test1")]
    public const int False = 0;

    [NativeTypeName("#define GLFW_RELEASE 0")]
    [SupportedApiProfile("test1")]
    public const int Release = 0;

    [NativeTypeName("#define GLFW_PRESS 1")]
    [SupportedApiProfile("test1")]
    public const int Press = 1;

    [NativeTypeName("#define GLFW_REPEAT 2")]
    [SupportedApiProfile("test1")]
    public const int Repeat = 2;

    [NativeTypeName("#define GLFW_HAT_CENTERED 0")]
    [SupportedApiProfile("test1")]
    public const int HatCentered = 0;

    [NativeTypeName("#define GLFW_HAT_UP 1")]
    [SupportedApiProfile("test1")]
    public const int HatUp = 1;

    [NativeTypeName("#define GLFW_HAT_RIGHT 2")]
    [SupportedApiProfile("test1")]
    public const int HatRight = 2;

    [NativeTypeName("#define GLFW_HAT_DOWN 4")]
    [SupportedApiProfile("test1")]
    public const int HatDown = 4;

    [NativeTypeName("#define GLFW_HAT_LEFT 8")]
    [SupportedApiProfile("test1")]
    public const int HatLeft = 8;

    [NativeTypeName("#define GLFW_HAT_RIGHT_UP (GLFW_HAT_RIGHT | GLFW_HAT_UP)")]
    [SupportedApiProfile("test1")]
    public const int HatRightUp = (2 | 1);

    [NativeTypeName("#define GLFW_HAT_RIGHT_DOWN (GLFW_HAT_RIGHT | GLFW_HAT_DOWN)")]
    [SupportedApiProfile("test1")]
    public const int HatRightDown = (2 | 4);

    [NativeTypeName("#define GLFW_HAT_LEFT_UP (GLFW_HAT_LEFT  | GLFW_HAT_UP)")]
    [SupportedApiProfile("test1")]
    public const int HatLeftUp = (8 | 1);

    [NativeTypeName("#define GLFW_HAT_LEFT_DOWN (GLFW_HAT_LEFT  | GLFW_HAT_DOWN)")]
    [SupportedApiProfile("test1")]
    public const int HatLeftDown = (8 | 4);

    [NativeTypeName("#define GLFW_KEY_UNKNOWN -1")]
    [SupportedApiProfile("test1")]
    public const int KeyUnknown = -1;

    [NativeTypeName("#define GLFW_KEY_SPACE 32")]
    [SupportedApiProfile("test1")]
    public const int KeySpace = 32;

    [NativeTypeName("#define GLFW_KEY_APOSTROPHE 39")]
    [SupportedApiProfile("test1")]
    public const int KeyApostrophe = 39;

    [NativeTypeName("#define GLFW_KEY_COMMA 44")]
    [SupportedApiProfile("test1")]
    public const int KeyComma = 44;

    [NativeTypeName("#define GLFW_KEY_MINUS 45")]
    [SupportedApiProfile("test1")]
    public const int KeyMinus = 45;

    [NativeTypeName("#define GLFW_KEY_PERIOD 46")]
    [SupportedApiProfile("test1")]
    public const int KeyPeriod = 46;

    [NativeTypeName("#define GLFW_KEY_SLASH 47")]
    [SupportedApiProfile("test1")]
    public const int KeySlash = 47;

    [NativeTypeName("#define GLFW_KEY_0 48")]
    [SupportedApiProfile("test1")]
    public const int Key0 = 48;

    [NativeTypeName("#define GLFW_KEY_1 49")]
    [SupportedApiProfile("test1")]
    public const int Key1 = 49;

    [NativeTypeName("#define GLFW_KEY_2 50")]
    [SupportedApiProfile("test1")]
    public const int Key2 = 50;

    [NativeTypeName("#define GLFW_KEY_3 51")]
    [SupportedApiProfile("test1")]
    public const int Key3 = 51;

    [NativeTypeName("#define GLFW_KEY_4 52")]
    [SupportedApiProfile("test1")]
    public const int Key4 = 52;

    [NativeTypeName("#define GLFW_KEY_5 53")]
    [SupportedApiProfile("test1")]
    public const int Key5 = 53;

    [NativeTypeName("#define GLFW_KEY_6 54")]
    [SupportedApiProfile("test1")]
    public const int Key6 = 54;

    [NativeTypeName("#define GLFW_KEY_7 55")]
    [SupportedApiProfile("test1")]
    public const int Key7 = 55;

    [NativeTypeName("#define GLFW_KEY_8 56")]
    [SupportedApiProfile("test1")]
    public const int Key8 = 56;

    [NativeTypeName("#define GLFW_KEY_9 57")]
    [SupportedApiProfile("test1")]
    public const int Key9 = 57;

    [NativeTypeName("#define GLFW_KEY_SEMICOLON 59")]
    [SupportedApiProfile("test1")]
    public const int KeySemicolon = 59;

    [NativeTypeName("#define GLFW_KEY_EQUAL 61")]
    [SupportedApiProfile("test1")]
    public const int KeyEqual = 61;

    [NativeTypeName("#define GLFW_KEY_A 65")]
    [SupportedApiProfile("test1")]
    public const int KeyA = 65;

    [NativeTypeName("#define GLFW_KEY_B 66")]
    [SupportedApiProfile("test1")]
    public const int KeyB = 66;

    [NativeTypeName("#define GLFW_KEY_C 67")]
    [SupportedApiProfile("test1")]
    public const int KeyC = 67;

    [NativeTypeName("#define GLFW_KEY_D 68")]
    [SupportedApiProfile("test1")]
    public const int KeyD = 68;

    [NativeTypeName("#define GLFW_KEY_E 69")]
    [SupportedApiProfile("test1")]
    public const int KeyE = 69;

    [NativeTypeName("#define GLFW_KEY_F 70")]
    [SupportedApiProfile("test1")]
    public const int KeyF = 70;

    [NativeTypeName("#define GLFW_KEY_G 71")]
    [SupportedApiProfile("test1")]
    public const int KeyG = 71;

    [NativeTypeName("#define GLFW_KEY_H 72")]
    [SupportedApiProfile("test1")]
    public const int KeyH = 72;

    [NativeTypeName("#define GLFW_KEY_I 73")]
    [SupportedApiProfile("test1")]
    public const int KeyI = 73;

    [NativeTypeName("#define GLFW_KEY_J 74")]
    [SupportedApiProfile("test1")]
    public const int KeyJ = 74;

    [NativeTypeName("#define GLFW_KEY_K 75")]
    [SupportedApiProfile("test1")]
    public const int KeyK = 75;

    [NativeTypeName("#define GLFW_KEY_L 76")]
    [SupportedApiProfile("test1")]
    public const int KeyL = 76;

    [NativeTypeName("#define GLFW_KEY_M 77")]
    [SupportedApiProfile("test1")]
    public const int KeyM = 77;

    [NativeTypeName("#define GLFW_KEY_N 78")]
    [SupportedApiProfile("test1")]
    public const int KeyN = 78;

    [NativeTypeName("#define GLFW_KEY_O 79")]
    [SupportedApiProfile("test1")]
    public const int KeyO = 79;

    [NativeTypeName("#define GLFW_KEY_P 80")]
    [SupportedApiProfile("test1")]
    public const int KeyP = 80;

    [NativeTypeName("#define GLFW_KEY_Q 81")]
    [SupportedApiProfile("test1")]
    public const int KeyQ = 81;

    [NativeTypeName("#define GLFW_KEY_R 82")]
    [SupportedApiProfile("test1")]
    public const int KeyR = 82;

    [NativeTypeName("#define GLFW_KEY_S 83")]
    [SupportedApiProfile("test1")]
    public const int KeyS = 83;

    [NativeTypeName("#define GLFW_KEY_T 84")]
    [SupportedApiProfile("test1")]
    public const int KeyT = 84;

    [NativeTypeName("#define GLFW_KEY_U 85")]
    [SupportedApiProfile("test1")]
    public const int KeyU = 85;

    [NativeTypeName("#define GLFW_KEY_V 86")]
    [SupportedApiProfile("test1")]
    public const int KeyV = 86;

    [NativeTypeName("#define GLFW_KEY_W 87")]
    [SupportedApiProfile("test1")]
    public const int KeyW = 87;

    [NativeTypeName("#define GLFW_KEY_X 88")]
    [SupportedApiProfile("test1")]
    public const int KeyX = 88;

    [NativeTypeName("#define GLFW_KEY_Y 89")]
    [SupportedApiProfile("test1")]
    public const int KeyY = 89;

    [NativeTypeName("#define GLFW_KEY_Z 90")]
    [SupportedApiProfile("test1")]
    public const int KeyZ = 90;

    [NativeTypeName("#define GLFW_KEY_LEFT_BRACKET 91")]
    [SupportedApiProfile("test1")]
    public const int KeyLeftBracket = 91;

    [NativeTypeName("#define GLFW_KEY_BACKSLASH 92")]
    [SupportedApiProfile("test1")]
    public const int KeyBackslash = 92;

    [NativeTypeName("#define GLFW_KEY_RIGHT_BRACKET 93")]
    [SupportedApiProfile("test1")]
    public const int KeyRightBracket = 93;

    [NativeTypeName("#define GLFW_KEY_GRAVE_ACCENT 96")]
    [SupportedApiProfile("test1")]
    public const int KeyGraveAccent = 96;

    [NativeTypeName("#define GLFW_KEY_WORLD_1 161")]
    [SupportedApiProfile("test1")]
    public const int KeyWorld1 = 161;

    [NativeTypeName("#define GLFW_KEY_WORLD_2 162")]
    [SupportedApiProfile("test1")]
    public const int KeyWorld2 = 162;

    [NativeTypeName("#define GLFW_KEY_ESCAPE 256")]
    [SupportedApiProfile("test1")]
    public const int KeyEscape = 256;

    [NativeTypeName("#define GLFW_KEY_ENTER 257")]
    [SupportedApiProfile("test1")]
    public const int KeyEnter = 257;

    [NativeTypeName("#define GLFW_KEY_TAB 258")]
    [SupportedApiProfile("test1")]
    public const int KeyTab = 258;

    [NativeTypeName("#define GLFW_KEY_BACKSPACE 259")]
    [SupportedApiProfile("test1")]
    public const int KeyBackspace = 259;

    [NativeTypeName("#define GLFW_KEY_INSERT 260")]
    [SupportedApiProfile("test1")]
    public const int KeyInsert = 260;

    [NativeTypeName("#define GLFW_KEY_DELETE 261")]
    [SupportedApiProfile("test1")]
    public const int KeyDelete = 261;

    [NativeTypeName("#define GLFW_KEY_RIGHT 262")]
    [SupportedApiProfile("test1")]
    public const int KeyRight = 262;

    [NativeTypeName("#define GLFW_KEY_LEFT 263")]
    [SupportedApiProfile("test1")]
    public const int KeyLeft = 263;

    [NativeTypeName("#define GLFW_KEY_DOWN 264")]
    [SupportedApiProfile("test1")]
    public const int KeyDown = 264;

    [NativeTypeName("#define GLFW_KEY_UP 265")]
    [SupportedApiProfile("test1")]
    public const int KeyUp = 265;

    [NativeTypeName("#define GLFW_KEY_PAGE_UP 266")]
    [SupportedApiProfile("test1")]
    public const int KeyPageUp = 266;

    [NativeTypeName("#define GLFW_KEY_PAGE_DOWN 267")]
    [SupportedApiProfile("test1")]
    public const int KeyPageDown = 267;

    [NativeTypeName("#define GLFW_KEY_HOME 268")]
    [SupportedApiProfile("test1")]
    public const int KeyHome = 268;

    [NativeTypeName("#define GLFW_KEY_END 269")]
    [SupportedApiProfile("test1")]
    public const int KeyEnd = 269;

    [NativeTypeName("#define GLFW_KEY_CAPS_LOCK 280")]
    [SupportedApiProfile("test1")]
    public const int KeyCapsLock = 280;

    [NativeTypeName("#define GLFW_KEY_SCROLL_LOCK 281")]
    [SupportedApiProfile("test1")]
    public const int KeyScrollLock = 281;

    [NativeTypeName("#define GLFW_KEY_NUM_LOCK 282")]
    [SupportedApiProfile("test1")]
    public const int KeyNumLock = 282;

    [NativeTypeName("#define GLFW_KEY_PRINT_SCREEN 283")]
    [SupportedApiProfile("test1")]
    public const int KeyPrintScreen = 283;

    [NativeTypeName("#define GLFW_KEY_PAUSE 284")]
    [SupportedApiProfile("test1")]
    public const int KeyPause = 284;

    [NativeTypeName("#define GLFW_KEY_F1 290")]
    [SupportedApiProfile("test1")]
    public const int KeyF1 = 290;

    [NativeTypeName("#define GLFW_KEY_F2 291")]
    [SupportedApiProfile("test1")]
    public const int KeyF2 = 291;

    [NativeTypeName("#define GLFW_KEY_F3 292")]
    [SupportedApiProfile("test1")]
    public const int KeyF3 = 292;

    [NativeTypeName("#define GLFW_KEY_F4 293")]
    [SupportedApiProfile("test1")]
    public const int KeyF4 = 293;

    [NativeTypeName("#define GLFW_KEY_F5 294")]
    [SupportedApiProfile("test1")]
    public const int KeyF5 = 294;

    [NativeTypeName("#define GLFW_KEY_F6 295")]
    [SupportedApiProfile("test1")]
    public const int KeyF6 = 295;

    [NativeTypeName("#define GLFW_KEY_F7 296")]
    [SupportedApiProfile("test1")]
    public const int KeyF7 = 296;

    [NativeTypeName("#define GLFW_KEY_F8 297")]
    [SupportedApiProfile("test1")]
    public const int KeyF8 = 297;

    [NativeTypeName("#define GLFW_KEY_F9 298")]
    [SupportedApiProfile("test1")]
    public const int KeyF9 = 298;

    [NativeTypeName("#define GLFW_KEY_F10 299")]
    [SupportedApiProfile("test1")]
    public const int KeyF10 = 299;

    [NativeTypeName("#define GLFW_KEY_F11 300")]
    [SupportedApiProfile("test1")]
    public const int KeyF11 = 300;

    [NativeTypeName("#define GLFW_KEY_F12 301")]
    [SupportedApiProfile("test1")]
    public const int KeyF12 = 301;

    [NativeTypeName("#define GLFW_KEY_F13 302")]
    [SupportedApiProfile("test1")]
    public const int KeyF13 = 302;

    [NativeTypeName("#define GLFW_KEY_F14 303")]
    [SupportedApiProfile("test1")]
    public const int KeyF14 = 303;

    [NativeTypeName("#define GLFW_KEY_F15 304")]
    [SupportedApiProfile("test1")]
    public const int KeyF15 = 304;

    [NativeTypeName("#define GLFW_KEY_F16 305")]
    [SupportedApiProfile("test1")]
    public const int KeyF16 = 305;

    [NativeTypeName("#define GLFW_KEY_F17 306")]
    [SupportedApiProfile("test1")]
    public const int KeyF17 = 306;

    [NativeTypeName("#define GLFW_KEY_F18 307")]
    [SupportedApiProfile("test1")]
    public const int KeyF18 = 307;

    [NativeTypeName("#define GLFW_KEY_F19 308")]
    [SupportedApiProfile("test1")]
    public const int KeyF19 = 308;

    [NativeTypeName("#define GLFW_KEY_F20 309")]
    [SupportedApiProfile("test1")]
    public const int KeyF20 = 309;

    [NativeTypeName("#define GLFW_KEY_F21 310")]
    [SupportedApiProfile("test1")]
    public const int KeyF21 = 310;

    [NativeTypeName("#define GLFW_KEY_F22 311")]
    [SupportedApiProfile("test1")]
    public const int KeyF22 = 311;

    [NativeTypeName("#define GLFW_KEY_F23 312")]
    [SupportedApiProfile("test1")]
    public const int KeyF23 = 312;

    [NativeTypeName("#define GLFW_KEY_F24 313")]
    [SupportedApiProfile("test1")]
    public const int KeyF24 = 313;

    [NativeTypeName("#define GLFW_KEY_F25 314")]
    [SupportedApiProfile("test1")]
    public const int KeyF25 = 314;

    [NativeTypeName("#define GLFW_KEY_KP_0 320")]
    [SupportedApiProfile("test1")]
    public const int KeyKp0 = 320;

    [NativeTypeName("#define GLFW_KEY_KP_1 321")]
    [SupportedApiProfile("test1")]
    public const int KeyKp1 = 321;

    [NativeTypeName("#define GLFW_KEY_KP_2 322")]
    [SupportedApiProfile("test1")]
    public const int KeyKp2 = 322;

    [NativeTypeName("#define GLFW_KEY_KP_3 323")]
    [SupportedApiProfile("test1")]
    public const int KeyKp3 = 323;

    [NativeTypeName("#define GLFW_KEY_KP_4 324")]
    [SupportedApiProfile("test1")]
    public const int KeyKp4 = 324;

    [NativeTypeName("#define GLFW_KEY_KP_5 325")]
    [SupportedApiProfile("test1")]
    public const int KeyKp5 = 325;

    [NativeTypeName("#define GLFW_KEY_KP_6 326")]
    [SupportedApiProfile("test1")]
    public const int KeyKp6 = 326;

    [NativeTypeName("#define GLFW_KEY_KP_7 327")]
    [SupportedApiProfile("test1")]
    public const int KeyKp7 = 327;

    [NativeTypeName("#define GLFW_KEY_KP_8 328")]
    [SupportedApiProfile("test1")]
    public const int KeyKp8 = 328;

    [NativeTypeName("#define GLFW_KEY_KP_9 329")]
    [SupportedApiProfile("test1")]
    public const int KeyKp9 = 329;

    [NativeTypeName("#define GLFW_KEY_KP_DECIMAL 330")]
    [SupportedApiProfile("test1")]
    public const int KeyKpDecimal = 330;

    [NativeTypeName("#define GLFW_KEY_KP_DIVIDE 331")]
    [SupportedApiProfile("test1")]
    public const int KeyKpDivide = 331;

    [NativeTypeName("#define GLFW_KEY_KP_MULTIPLY 332")]
    [SupportedApiProfile("test1")]
    public const int KeyKpMultiply = 332;

    [NativeTypeName("#define GLFW_KEY_KP_SUBTRACT 333")]
    [SupportedApiProfile("test1")]
    public const int KeyKpSubtract = 333;

    [NativeTypeName("#define GLFW_KEY_KP_ADD 334")]
    [SupportedApiProfile("test1")]
    public const int KeyKpAdd = 334;

    [NativeTypeName("#define GLFW_KEY_KP_ENTER 335")]
    [SupportedApiProfile("test1")]
    public const int KeyKpEnter = 335;

    [NativeTypeName("#define GLFW_KEY_KP_EQUAL 336")]
    [SupportedApiProfile("test1")]
    public const int KeyKpEqual = 336;

    [NativeTypeName("#define GLFW_KEY_LEFT_SHIFT 340")]
    [SupportedApiProfile("test1")]
    public const int KeyLeftShift = 340;

    [NativeTypeName("#define GLFW_KEY_LEFT_CONTROL 341")]
    [SupportedApiProfile("test1")]
    public const int KeyLeftControl = 341;

    [NativeTypeName("#define GLFW_KEY_LEFT_ALT 342")]
    [SupportedApiProfile("test1")]
    public const int KeyLeftAlt = 342;

    [NativeTypeName("#define GLFW_KEY_LEFT_SUPER 343")]
    [SupportedApiProfile("test1")]
    public const int KeyLeftSuper = 343;

    [NativeTypeName("#define GLFW_KEY_RIGHT_SHIFT 344")]
    [SupportedApiProfile("test1")]
    public const int KeyRightShift = 344;

    [NativeTypeName("#define GLFW_KEY_RIGHT_CONTROL 345")]
    [SupportedApiProfile("test1")]
    public const int KeyRightControl = 345;

    [NativeTypeName("#define GLFW_KEY_RIGHT_ALT 346")]
    [SupportedApiProfile("test1")]
    public const int KeyRightAlt = 346;

    [NativeTypeName("#define GLFW_KEY_RIGHT_SUPER 347")]
    [SupportedApiProfile("test1")]
    public const int KeyRightSuper = 347;

    [NativeTypeName("#define GLFW_KEY_MENU 348")]
    [SupportedApiProfile("test1")]
    public const int KeyMenu = 348;

    [NativeTypeName("#define GLFW_KEY_LAST GLFW_KEY_MENU")]
    [SupportedApiProfile("test1")]
    public const int KeyLast = 348;

    [NativeTypeName("#define GLFW_MOD_SHIFT 0x0001")]
    [SupportedApiProfile("test1")]
    public const int ModShift = 0x0001;

    [NativeTypeName("#define GLFW_MOD_CONTROL 0x0002")]
    [SupportedApiProfile("test1")]
    public const int ModControl = 0x0002;

    [NativeTypeName("#define GLFW_MOD_ALT 0x0004")]
    [SupportedApiProfile("test1")]
    public const int ModAlt = 0x0004;

    [NativeTypeName("#define GLFW_MOD_SUPER 0x0008")]
    [SupportedApiProfile("test1")]
    public const int ModSuper = 0x0008;

    [NativeTypeName("#define GLFW_MOD_CAPS_LOCK 0x0010")]
    [SupportedApiProfile("test1")]
    public const int ModCapsLock = 0x0010;

    [NativeTypeName("#define GLFW_MOD_NUM_LOCK 0x0020")]
    [SupportedApiProfile("test1")]
    public const int ModNumLock = 0x0020;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_1 0")]
    [SupportedApiProfile("test1")]
    public const int MouseButton1 = 0;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_2 1")]
    [SupportedApiProfile("test1")]
    public const int MouseButton2 = 1;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_3 2")]
    [SupportedApiProfile("test1")]
    public const int MouseButton3 = 2;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_4 3")]
    [SupportedApiProfile("test1")]
    public const int MouseButton4 = 3;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_5 4")]
    [SupportedApiProfile("test1")]
    public const int MouseButton5 = 4;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_6 5")]
    [SupportedApiProfile("test1")]
    public const int MouseButton6 = 5;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_7 6")]
    [SupportedApiProfile("test1")]
    public const int MouseButton7 = 6;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_8 7")]
    [SupportedApiProfile("test1")]
    public const int MouseButton8 = 7;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LAST GLFW_MOUSE_BUTTON_8")]
    [SupportedApiProfile("test1")]
    public const int MouseButtonLast = 7;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LEFT GLFW_MOUSE_BUTTON_1")]
    [SupportedApiProfile("test1")]
    public const int MouseButtonLeft = 0;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_RIGHT GLFW_MOUSE_BUTTON_2")]
    [SupportedApiProfile("test1")]
    public const int MouseButtonRight = 1;

    [NativeTypeName("#define GLFW_MOUSE_BUTTON_MIDDLE GLFW_MOUSE_BUTTON_3")]
    [SupportedApiProfile("test1")]
    public const int MouseButtonMiddle = 2;

    [NativeTypeName("#define GLFW_JOYSTICK_1 0")]
    [SupportedApiProfile("test1")]
    public const int Joystick1 = 0;

    [NativeTypeName("#define GLFW_JOYSTICK_2 1")]
    [SupportedApiProfile("test1")]
    public const int Joystick2 = 1;

    [NativeTypeName("#define GLFW_JOYSTICK_3 2")]
    [SupportedApiProfile("test1")]
    public const int Joystick3 = 2;

    [NativeTypeName("#define GLFW_JOYSTICK_4 3")]
    [SupportedApiProfile("test1")]
    public const int Joystick4 = 3;

    [NativeTypeName("#define GLFW_JOYSTICK_5 4")]
    [SupportedApiProfile("test1")]
    public const int Joystick5 = 4;

    [NativeTypeName("#define GLFW_JOYSTICK_6 5")]
    [SupportedApiProfile("test1")]
    public const int Joystick6 = 5;

    [NativeTypeName("#define GLFW_JOYSTICK_7 6")]
    [SupportedApiProfile("test1")]
    public const int Joystick7 = 6;

    [NativeTypeName("#define GLFW_JOYSTICK_8 7")]
    [SupportedApiProfile("test1")]
    public const int Joystick8 = 7;

    [NativeTypeName("#define GLFW_JOYSTICK_9 8")]
    [SupportedApiProfile("test1")]
    public const int Joystick9 = 8;

    [NativeTypeName("#define GLFW_JOYSTICK_10 9")]
    [SupportedApiProfile("test1")]
    public const int Joystick10 = 9;

    [NativeTypeName("#define GLFW_JOYSTICK_11 10")]
    [SupportedApiProfile("test1")]
    public const int Joystick11 = 10;

    [NativeTypeName("#define GLFW_JOYSTICK_12 11")]
    [SupportedApiProfile("test1")]
    public const int Joystick12 = 11;

    [NativeTypeName("#define GLFW_JOYSTICK_13 12")]
    [SupportedApiProfile("test1")]
    public const int Joystick13 = 12;

    [NativeTypeName("#define GLFW_JOYSTICK_14 13")]
    [SupportedApiProfile("test1")]
    public const int Joystick14 = 13;

    [NativeTypeName("#define GLFW_JOYSTICK_15 14")]
    [SupportedApiProfile("test1")]
    public const int Joystick15 = 14;

    [NativeTypeName("#define GLFW_JOYSTICK_16 15")]
    [SupportedApiProfile("test1")]
    public const int Joystick16 = 15;

    [NativeTypeName("#define GLFW_JOYSTICK_LAST GLFW_JOYSTICK_16")]
    [SupportedApiProfile("test1")]
    public const int JoystickLast = 15;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_A 0")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonA = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_B 1")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonB = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_X 2")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonX = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_Y 3")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonY = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_BUMPER 4")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonLeftBumper = 4;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER 5")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonRightBumper = 5;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_BACK 6")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonBack = 6;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_START 7")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonStart = 7;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_GUIDE 8")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonGuide = 8;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_THUMB 9")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonLeftThumb = 9;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_THUMB 10")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonRightThumb = 10;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_UP 11")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonDpadUp = 11;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_RIGHT 12")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonDpadRight = 12;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_DOWN 13")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonDpadDown = 13;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_LEFT 14")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonDpadLeft = 14;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LAST GLFW_GAMEPAD_BUTTON_DPAD_LEFT")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonLast = 14;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CROSS GLFW_GAMEPAD_BUTTON_A")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonCross = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CIRCLE GLFW_GAMEPAD_BUTTON_B")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonCircle = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_SQUARE GLFW_GAMEPAD_BUTTON_X")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonSquare = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_TRIANGLE GLFW_GAMEPAD_BUTTON_Y")]
    [SupportedApiProfile("test1")]
    public const int GamepadButtonTriangle = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_X 0")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisLeftX = 0;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_Y 1")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisLeftY = 1;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_X 2")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisRightX = 2;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_Y 3")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisRightY = 3;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_TRIGGER 4")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisLeftTrigger = 4;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER 5")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisRightTrigger = 5;

    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LAST GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER")]
    [SupportedApiProfile("test1")]
    public const int GamepadAxisLast = 5;

    [NativeTypeName("#define GLFW_NO_ERROR 0")]
    [SupportedApiProfile("test1")]
    public const int NoError = 0;

    [NativeTypeName("#define GLFW_NOT_INITIALIZED 0x00010001")]
    [SupportedApiProfile("test1")]
    public const int NotInitialized = 0x00010001;

    [NativeTypeName("#define GLFW_NO_CURRENT_CONTEXT 0x00010002")]
    [SupportedApiProfile("test1")]
    public const int NoCurrentContext = 0x00010002;

    [NativeTypeName("#define GLFW_INVALID_ENUM 0x00010003")]
    [SupportedApiProfile("test1")]
    public const int InvalidEnum = 0x00010003;

    [NativeTypeName("#define GLFW_INVALID_VALUE 0x00010004")]
    [SupportedApiProfile("test1")]
    public const int InvalidValue = 0x00010004;

    [NativeTypeName("#define GLFW_OUT_OF_MEMORY 0x00010005")]
    [SupportedApiProfile("test1")]
    public const int OutOfMemory = 0x00010005;

    [NativeTypeName("#define GLFW_API_UNAVAILABLE 0x00010006")]
    [SupportedApiProfile("test1")]
    public const int ApiUnavailable = 0x00010006;

    [NativeTypeName("#define GLFW_VERSION_UNAVAILABLE 0x00010007")]
    [SupportedApiProfile("test1")]
    public const int VersionUnavailable = 0x00010007;

    [NativeTypeName("#define GLFW_PLATFORM_ERROR 0x00010008")]
    [SupportedApiProfile("test1")]
    public const int PlatformError = 0x00010008;

    [NativeTypeName("#define GLFW_FORMAT_UNAVAILABLE 0x00010009")]
    [SupportedApiProfile("test1")]
    public const int FormatUnavailable = 0x00010009;

    [NativeTypeName("#define GLFW_NO_WINDOW_CONTEXT 0x0001000A")]
    [SupportedApiProfile("test1")]
    public const int NoWindowContext = 0x0001000A;

    [NativeTypeName("#define GLFW_CURSOR_UNAVAILABLE 0x0001000B")]
    [SupportedApiProfile("test1")]
    public const int CursorUnavailable = 0x0001000B;

    [NativeTypeName("#define GLFW_FEATURE_UNAVAILABLE 0x0001000C")]
    [SupportedApiProfile("test1")]
    public const int FeatureUnavailable = 0x0001000C;

    [NativeTypeName("#define GLFW_FEATURE_UNIMPLEMENTED 0x0001000D")]
    [SupportedApiProfile("test1")]
    public const int FeatureUnimplemented = 0x0001000D;

    [NativeTypeName("#define GLFW_PLATFORM_UNAVAILABLE 0x0001000E")]
    [SupportedApiProfile("test1")]
    public const int PlatformUnavailable = 0x0001000E;

    [NativeTypeName("#define GLFW_FOCUSED 0x00020001")]
    [SupportedApiProfile("test1")]
    public const int Focused = 0x00020001;

    [NativeTypeName("#define GLFW_ICONIFIED 0x00020002")]
    [SupportedApiProfile("test1")]
    public const int Iconified = 0x00020002;

    [NativeTypeName("#define GLFW_RESIZABLE 0x00020003")]
    [SupportedApiProfile("test1")]
    public const int Resizable = 0x00020003;

    [NativeTypeName("#define GLFW_VISIBLE 0x00020004")]
    [SupportedApiProfile("test1")]
    public const int Visible = 0x00020004;

    [NativeTypeName("#define GLFW_DECORATED 0x00020005")]
    [SupportedApiProfile("test1")]
    public const int Decorated = 0x00020005;

    [NativeTypeName("#define GLFW_AUTO_ICONIFY 0x00020006")]
    [SupportedApiProfile("test1")]
    public const int AutoIconify = 0x00020006;

    [NativeTypeName("#define GLFW_FLOATING 0x00020007")]
    [SupportedApiProfile("test1")]
    public const int Floating = 0x00020007;

    [NativeTypeName("#define GLFW_MAXIMIZED 0x00020008")]
    [SupportedApiProfile("test1")]
    public const int Maximized = 0x00020008;

    [NativeTypeName("#define GLFW_CENTER_CURSOR 0x00020009")]
    [SupportedApiProfile("test1")]
    public const int CenterCursor = 0x00020009;

    [NativeTypeName("#define GLFW_TRANSPARENT_FRAMEBUFFER 0x0002000A")]
    [SupportedApiProfile("test1")]
    public const int TransparentFramebuffer = 0x0002000A;

    [NativeTypeName("#define GLFW_HOVERED 0x0002000B")]
    [SupportedApiProfile("test1")]
    public const int Hovered = 0x0002000B;

    [NativeTypeName("#define GLFW_FOCUS_ON_SHOW 0x0002000C")]
    [SupportedApiProfile("test1")]
    public const int FocusOnShow = 0x0002000C;

    [NativeTypeName("#define GLFW_MOUSE_PASSTHROUGH 0x0002000D")]
    [SupportedApiProfile("test1")]
    public const int MousePassthrough = 0x0002000D;

    [NativeTypeName("#define GLFW_POSITION_X 0x0002000E")]
    [SupportedApiProfile("test1")]
    public const int PositionX = 0x0002000E;

    [NativeTypeName("#define GLFW_POSITION_Y 0x0002000F")]
    [SupportedApiProfile("test1")]
    public const int PositionY = 0x0002000F;

    [NativeTypeName("#define GLFW_RED_BITS 0x00021001")]
    [SupportedApiProfile("test1")]
    public const int RedBits = 0x00021001;

    [NativeTypeName("#define GLFW_GREEN_BITS 0x00021002")]
    [SupportedApiProfile("test1")]
    public const int GreenBits = 0x00021002;

    [NativeTypeName("#define GLFW_BLUE_BITS 0x00021003")]
    [SupportedApiProfile("test1")]
    public const int BlueBits = 0x00021003;

    [NativeTypeName("#define GLFW_ALPHA_BITS 0x00021004")]
    [SupportedApiProfile("test1")]
    public const int AlphaBits = 0x00021004;

    [NativeTypeName("#define GLFW_DEPTH_BITS 0x00021005")]
    [SupportedApiProfile("test1")]
    public const int DepthBits = 0x00021005;

    [NativeTypeName("#define GLFW_STENCIL_BITS 0x00021006")]
    [SupportedApiProfile("test1")]
    public const int StencilBits = 0x00021006;

    [NativeTypeName("#define GLFW_ACCUM_RED_BITS 0x00021007")]
    [SupportedApiProfile("test1")]
    public const int AccumRedBits = 0x00021007;

    [NativeTypeName("#define GLFW_ACCUM_GREEN_BITS 0x00021008")]
    [SupportedApiProfile("test1")]
    public const int AccumGreenBits = 0x00021008;

    [NativeTypeName("#define GLFW_ACCUM_BLUE_BITS 0x00021009")]
    [SupportedApiProfile("test1")]
    public const int AccumBlueBits = 0x00021009;

    [NativeTypeName("#define GLFW_ACCUM_ALPHA_BITS 0x0002100A")]
    [SupportedApiProfile("test1")]
    public const int AccumAlphaBits = 0x0002100A;

    [NativeTypeName("#define GLFW_AUX_BUFFERS 0x0002100B")]
    [SupportedApiProfile("test1")]
    public const int AuxBuffers = 0x0002100B;

    [NativeTypeName("#define GLFW_STEREO 0x0002100C")]
    [SupportedApiProfile("test1")]
    public const int Stereo = 0x0002100C;

    [NativeTypeName("#define GLFW_SAMPLES 0x0002100D")]
    [SupportedApiProfile("test1")]
    public const int Samples = 0x0002100D;

    [NativeTypeName("#define GLFW_SRGB_CAPABLE 0x0002100E")]
    [SupportedApiProfile("test1")]
    public const int SrgbCapable = 0x0002100E;

    [NativeTypeName("#define GLFW_REFRESH_RATE 0x0002100F")]
    [SupportedApiProfile("test1")]
    public const int RefreshRate = 0x0002100F;

    [NativeTypeName("#define GLFW_DOUBLEBUFFER 0x00021010")]
    [SupportedApiProfile("test1")]
    public const int Doublebuffer = 0x00021010;

    [NativeTypeName("#define GLFW_CLIENT_API 0x00022001")]
    [SupportedApiProfile("test1")]
    public const int ClientApi = 0x00022001;

    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MAJOR 0x00022002")]
    [SupportedApiProfile("test1")]
    public const int ContextVersionMajor = 0x00022002;

    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MINOR 0x00022003")]
    [SupportedApiProfile("test1")]
    public const int ContextVersionMinor = 0x00022003;

    [NativeTypeName("#define GLFW_CONTEXT_REVISION 0x00022004")]
    [SupportedApiProfile("test1")]
    public const int ContextRevision = 0x00022004;

    [NativeTypeName("#define GLFW_CONTEXT_ROBUSTNESS 0x00022005")]
    [SupportedApiProfile("test1")]
    public const int ContextRobustness = 0x00022005;

    [NativeTypeName("#define GLFW_OPENGL_FORWARD_COMPAT 0x00022006")]
    [SupportedApiProfile("test1")]
    public const int OpenglForwardCompat = 0x00022006;

    [NativeTypeName("#define GLFW_CONTEXT_DEBUG 0x00022007")]
    [SupportedApiProfile("test1")]
    public const int ContextDebug = 0x00022007;

    [NativeTypeName("#define GLFW_OPENGL_DEBUG_CONTEXT GLFW_CONTEXT_DEBUG")]
    [SupportedApiProfile("test1")]
    public const int OpenglDebugContext = 0x00022007;

    [NativeTypeName("#define GLFW_OPENGL_PROFILE 0x00022008")]
    [SupportedApiProfile("test1")]
    public const int OpenglProfile = 0x00022008;

    [NativeTypeName("#define GLFW_CONTEXT_RELEASE_BEHAVIOR 0x00022009")]
    [SupportedApiProfile("test1")]
    public const int ContextReleaseBehavior = 0x00022009;

    [NativeTypeName("#define GLFW_CONTEXT_NO_ERROR 0x0002200A")]
    [SupportedApiProfile("test1")]
    public const int ContextNoError = 0x0002200A;

    [NativeTypeName("#define GLFW_CONTEXT_CREATION_API 0x0002200B")]
    [SupportedApiProfile("test1")]
    public const int ContextCreationApi = 0x0002200B;

    [NativeTypeName("#define GLFW_SCALE_TO_MONITOR 0x0002200C")]
    [SupportedApiProfile("test1")]
    public const int ScaleToMonitor = 0x0002200C;

    [NativeTypeName("#define GLFW_COCOA_RETINA_FRAMEBUFFER 0x00023001")]
    [SupportedApiProfile("test1")]
    public const int CocoaRetinaFramebuffer = 0x00023001;

    [NativeTypeName("#define GLFW_COCOA_FRAME_NAME 0x00023002")]
    [SupportedApiProfile("test1")]
    public const int CocoaFrameName = 0x00023002;

    [NativeTypeName("#define GLFW_COCOA_GRAPHICS_SWITCHING 0x00023003")]
    [SupportedApiProfile("test1")]
    public const int CocoaGraphicsSwitching = 0x00023003;

    [NativeTypeName("#define GLFW_X11_CLASS_NAME 0x00024001")]
    [SupportedApiProfile("test1")]
    public const int X11ClassName = 0x00024001;

    [NativeTypeName("#define GLFW_X11_INSTANCE_NAME 0x00024002")]
    [SupportedApiProfile("test1")]
    public const int X11InstanceName = 0x00024002;

    [NativeTypeName("#define GLFW_WIN32_KEYBOARD_MENU 0x00025001")]
    [SupportedApiProfile("test1")]
    public const int Win32KeyboardMenu = 0x00025001;

    [NativeTypeName("#define GLFW_WAYLAND_APP_ID 0x00026001")]
    [SupportedApiProfile("test1")]
    public const int WaylandAppId = 0x00026001;

    [NativeTypeName("#define GLFW_NO_API 0")]
    [SupportedApiProfile("test1")]
    public const int NoApi = 0;

    [NativeTypeName("#define GLFW_OPENGL_API 0x00030001")]
    [SupportedApiProfile("test1")]
    public const int OpenglApi = 0x00030001;

    [NativeTypeName("#define GLFW_OPENGL_ES_API 0x00030002")]
    [SupportedApiProfile("test1")]
    public const int OpenglEsApi = 0x00030002;

    [NativeTypeName("#define GLFW_NO_ROBUSTNESS 0")]
    [SupportedApiProfile("test1")]
    public const int NoRobustness = 0;

    [NativeTypeName("#define GLFW_NO_RESET_NOTIFICATION 0x00031001")]
    [SupportedApiProfile("test1")]
    public const int NoResetNotification = 0x00031001;

    [NativeTypeName("#define GLFW_LOSE_CONTEXT_ON_RESET 0x00031002")]
    [SupportedApiProfile("test1")]
    public const int LoseContextOnReset = 0x00031002;

    [NativeTypeName("#define GLFW_OPENGL_ANY_PROFILE 0")]
    [SupportedApiProfile("test1")]
    public const int OpenglAnyProfile = 0;

    [NativeTypeName("#define GLFW_OPENGL_CORE_PROFILE 0x00032001")]
    [SupportedApiProfile("test1")]
    public const int OpenglCoreProfile = 0x00032001;

    [NativeTypeName("#define GLFW_OPENGL_COMPAT_PROFILE 0x00032002")]
    [SupportedApiProfile("test1")]
    public const int OpenglCompatProfile = 0x00032002;

    [NativeTypeName("#define GLFW_CURSOR 0x00033001")]
    [SupportedApiProfile("test1")]
    public const int Cursor = 0x00033001;

    [NativeTypeName("#define GLFW_STICKY_KEYS 0x00033002")]
    [SupportedApiProfile("test1")]
    public const int StickyKeys = 0x00033002;

    [NativeTypeName("#define GLFW_STICKY_MOUSE_BUTTONS 0x00033003")]
    [SupportedApiProfile("test1")]
    public const int StickyMouseButtons = 0x00033003;

    [NativeTypeName("#define GLFW_LOCK_KEY_MODS 0x00033004")]
    [SupportedApiProfile("test1")]
    public const int LockKeyMods = 0x00033004;

    [NativeTypeName("#define GLFW_RAW_MOUSE_MOTION 0x00033005")]
    [SupportedApiProfile("test1")]
    public const int RawMouseMotion = 0x00033005;

    [NativeTypeName("#define GLFW_CURSOR_NORMAL 0x00034001")]
    [SupportedApiProfile("test1")]
    public const int CursorNormal = 0x00034001;

    [NativeTypeName("#define GLFW_CURSOR_HIDDEN 0x00034002")]
    [SupportedApiProfile("test1")]
    public const int CursorHidden = 0x00034002;

    [NativeTypeName("#define GLFW_CURSOR_DISABLED 0x00034003")]
    [SupportedApiProfile("test1")]
    public const int CursorDisabled = 0x00034003;

    [NativeTypeName("#define GLFW_CURSOR_CAPTURED 0x00034004")]
    [SupportedApiProfile("test1")]
    public const int CursorCaptured = 0x00034004;

    [NativeTypeName("#define GLFW_ANY_RELEASE_BEHAVIOR 0")]
    [SupportedApiProfile("test1")]
    public const int AnyReleaseBehavior = 0;

    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_FLUSH 0x00035001")]
    [SupportedApiProfile("test1")]
    public const int ReleaseBehaviorFlush = 0x00035001;

    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_NONE 0x00035002")]
    [SupportedApiProfile("test1")]
    public const int ReleaseBehaviorNone = 0x00035002;

    [NativeTypeName("#define GLFW_NATIVE_CONTEXT_API 0x00036001")]
    [SupportedApiProfile("test1")]
    public const int NativeContextApi = 0x00036001;

    [NativeTypeName("#define GLFW_EGL_CONTEXT_API 0x00036002")]
    [SupportedApiProfile("test1")]
    public const int EglContextApi = 0x00036002;

    [NativeTypeName("#define GLFW_OSMESA_CONTEXT_API 0x00036003")]
    [SupportedApiProfile("test1")]
    public const int OsmesaContextApi = 0x00036003;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_NONE 0x00037001")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeNone = 0x00037001;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGL 0x00037002")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeOpengl = 0x00037002;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGLES 0x00037003")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeOpengles = 0x00037003;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D9 0x00037004")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeD3d9 = 0x00037004;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeD3d11 = 0x00037005;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_VULKAN 0x00037007")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeVulkan = 0x00037007;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_METAL 0x00037008")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformTypeMetal = 0x00037008;

    [NativeTypeName("#define GLFW_WAYLAND_PREFER_LIBDECOR 0x00038001")]
    [SupportedApiProfile("test1")]
    public const int WaylandPreferLibdecor = 0x00038001;

    [NativeTypeName("#define GLFW_WAYLAND_DISABLE_LIBDECOR 0x00038002")]
    [SupportedApiProfile("test1")]
    public const int WaylandDisableLibdecor = 0x00038002;

    [NativeTypeName("#define GLFW_ANY_POSITION 0x80000000")]
    [SupportedApiProfile("test1")]
    public const uint AnyPosition = 0x80000000;

    [NativeTypeName("#define GLFW_ARROW_CURSOR 0x00036001")]
    [SupportedApiProfile("test1")]
    public const int ArrowCursor = 0x00036001;

    [NativeTypeName("#define GLFW_IBEAM_CURSOR 0x00036002")]
    [SupportedApiProfile("test1")]
    public const int IbeamCursor = 0x00036002;

    [NativeTypeName("#define GLFW_CROSSHAIR_CURSOR 0x00036003")]
    [SupportedApiProfile("test1")]
    public const int CrosshairCursor = 0x00036003;

    [NativeTypeName("#define GLFW_POINTING_HAND_CURSOR 0x00036004")]
    [SupportedApiProfile("test1")]
    public const int PointingHandCursor = 0x00036004;

    [NativeTypeName("#define GLFW_RESIZE_EW_CURSOR 0x00036005")]
    [SupportedApiProfile("test1")]
    public const int ResizeEwCursor = 0x00036005;

    [NativeTypeName("#define GLFW_RESIZE_NS_CURSOR 0x00036006")]
    [SupportedApiProfile("test1")]
    public const int ResizeNsCursor = 0x00036006;

    [NativeTypeName("#define GLFW_RESIZE_NWSE_CURSOR 0x00036007")]
    [SupportedApiProfile("test1")]
    public const int ResizeNwseCursor = 0x00036007;

    [NativeTypeName("#define GLFW_RESIZE_NESW_CURSOR 0x00036008")]
    [SupportedApiProfile("test1")]
    public const int ResizeNeswCursor = 0x00036008;

    [NativeTypeName("#define GLFW_RESIZE_ALL_CURSOR 0x00036009")]
    [SupportedApiProfile("test1")]
    public const int ResizeAllCursor = 0x00036009;

    [NativeTypeName("#define GLFW_NOT_ALLOWED_CURSOR 0x0003600A")]
    [SupportedApiProfile("test1")]
    public const int NotAllowedCursor = 0x0003600A;

    [NativeTypeName("#define GLFW_HRESIZE_CURSOR GLFW_RESIZE_EW_CURSOR")]
    [SupportedApiProfile("test1")]
    public const int HresizeCursor = 0x00036005;

    [NativeTypeName("#define GLFW_VRESIZE_CURSOR GLFW_RESIZE_NS_CURSOR")]
    [SupportedApiProfile("test1")]
    public const int VresizeCursor = 0x00036006;

    [NativeTypeName("#define GLFW_HAND_CURSOR GLFW_POINTING_HAND_CURSOR")]
    [SupportedApiProfile("test1")]
    public const int HandCursor = 0x00036004;

    [NativeTypeName("#define GLFW_CONNECTED 0x00040001")]
    [SupportedApiProfile("test1")]
    public const int Connected = 0x00040001;

    [NativeTypeName("#define GLFW_DISCONNECTED 0x00040002")]
    [SupportedApiProfile("test1")]
    public const int Disconnected = 0x00040002;

    [NativeTypeName("#define GLFW_JOYSTICK_HAT_BUTTONS 0x00050001")]
    [SupportedApiProfile("test1")]
    public const int JoystickHatButtons = 0x00050001;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE 0x00050002")]
    [SupportedApiProfile("test1")]
    public const int AnglePlatformType = 0x00050002;

    [NativeTypeName("#define GLFW_PLATFORM 0x00050003")]
    [SupportedApiProfile("test1")]
    public const int Platform = 0x00050003;

    [NativeTypeName("#define GLFW_COCOA_CHDIR_RESOURCES 0x00051001")]
    [SupportedApiProfile("test1")]
    public const int CocoaChdirResources = 0x00051001;

    [NativeTypeName("#define GLFW_COCOA_MENUBAR 0x00051002")]
    [SupportedApiProfile("test1")]
    public const int CocoaMenubar = 0x00051002;

    [NativeTypeName("#define GLFW_X11_XCB_VULKAN_SURFACE 0x00052001")]
    [SupportedApiProfile("test1")]
    public const int X11XcbVulkanSurface = 0x00052001;

    [NativeTypeName("#define GLFW_WAYLAND_LIBDECOR 0x00053001")]
    [SupportedApiProfile("test1")]
    public const int WaylandLibdecor = 0x00053001;

    [NativeTypeName("#define GLFW_ANY_PLATFORM 0x00060000")]
    [SupportedApiProfile("test1")]
    public const int AnyPlatform = 0x00060000;

    [NativeTypeName("#define GLFW_PLATFORM_WIN32 0x00060001")]
    [SupportedApiProfile("test1")]
    public const int PlatformWin32 = 0x00060001;

    [NativeTypeName("#define GLFW_PLATFORM_COCOA 0x00060002")]
    [SupportedApiProfile("test1")]
    public const int PlatformCocoa = 0x00060002;

    [NativeTypeName("#define GLFW_PLATFORM_WAYLAND 0x00060003")]
    [SupportedApiProfile("test1")]
    public const int PlatformWayland = 0x00060003;

    [NativeTypeName("#define GLFW_PLATFORM_X11 0x00060004")]
    [SupportedApiProfile("test1")]
    public const int PlatformX11 = 0x00060004;

    [NativeTypeName("#define GLFW_PLATFORM_NULL 0x00060005")]
    [SupportedApiProfile("test1")]
    public const int PlatformNull = 0x00060005;

    [NativeTypeName("#define GLFW_DONT_CARE -1")]
    [SupportedApiProfile("test1")]
    public const int DontCare = -1;

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Ptr<Cursor> IGlfw.CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    )
    {
        fixed (Image* __dsl_image = image)
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
            return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    public static Ptr<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    ) => DllImport.CreateCursor(image, xhot, yhot);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Ptr<Cursor> IGlfw.CreateStandardCursor(int shape)
    {
        Cursor* __DSL_glfwCreateStandardCursor(int shape) =>
            (
                (delegate* unmanaged<int, Cursor*>)
                    nativeContext.LoadFunction("glfwCreateStandardCursor", "glfw")
            )(shape);
        return __DSL_glfwCreateStandardCursor(shape);
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    public static Ptr<Cursor> CreateStandardCursor(int shape) =>
        DllImport.CreateStandardCursor(shape);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Ptr<Window> IGlfw.CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        Ref<Monitor> monitor,
        Ref<Window> share
    )
    {
        fixed (Window* __dsl_share = share)
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (sbyte* __dsl_title = title)
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
            return __DSL_glfwCreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    public static Ptr<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        Ref<Monitor> monitor,
        Ref<Window> share
    ) => DllImport.CreateWindow(width, height, title, monitor, share);

    void IGlfw.DefaultWindowHints() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwDefaultWindowHints", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    public static void DefaultWindowHints() => DllImport.DefaultWindowHints();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void IGlfw.DestroyCursor(Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        {
            void __DSL_glfwDestroyCursor(Cursor* cursor) =>
                (
                    (delegate* unmanaged<Cursor*, void>)
                        nativeContext.LoadFunction("glfwDestroyCursor", "glfw")
                )(cursor);
            __DSL_glfwDestroyCursor(__dsl_cursor);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    public static void DestroyCursor(Ref<Cursor> cursor) => DllImport.DestroyCursor(cursor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void IGlfw.DestroyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwDestroyWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwDestroyWindow", "glfw")
                )(window);
            __DSL_glfwDestroyWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    public static void DestroyWindow(Ref<Window> window) => DllImport.DestroyWindow(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int IGlfw.ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            int __DSL_glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
                (
                    (delegate* unmanaged<sbyte*, int>)
                        nativeContext.LoadFunction("glfwExtensionSupported", "glfw")
                )(extension);
            return __DSL_glfwExtensionSupported(__dsl_extension);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    public static int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension) =>
        DllImport.ExtensionSupported(extension);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void IGlfw.FocusWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwFocusWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwFocusWindow", "glfw")
                )(window);
            __DSL_glfwFocusWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    public static void FocusWindow(Ref<Window> window) => DllImport.FocusWindow(window);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    Ptr<sbyte> IGlfw.GetClipboardString(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            sbyte* __DSL_glfwGetClipboardString(Window* window) =>
                (
                    (delegate* unmanaged<Window*, sbyte*>)
                        nativeContext.LoadFunction("glfwGetClipboardString", "glfw")
                )(window);
            return __DSL_glfwGetClipboardString(__dsl_window);
        }
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    public static Ptr<sbyte> GetClipboardString(Ref<Window> window) =>
        DllImport.GetClipboardString(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Ptr<Window> IGlfw.GetCurrentContext()
    {
        Window* __DSL_glfwGetCurrentContext() =>
            (
                (delegate* unmanaged<Window*>)
                    nativeContext.LoadFunction("glfwGetCurrentContext", "glfw")
            )();
        return __DSL_glfwGetCurrentContext();
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    public static Ptr<Window> GetCurrentContext() => DllImport.GetCurrentContext();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void IGlfw.GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos) =>
                (
                    (delegate* unmanaged<Window*, double*, double*, void>)
                        nativeContext.LoadFunction("glfwGetCursorPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos) =>
        DllImport.GetCursorPos(window, xpos, ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int IGlfw.GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            int __DSL_glfwGetError([NativeTypeName("const char **")] sbyte** description) =>
                (
                    (delegate* unmanaged<sbyte**, int>)
                        nativeContext.LoadFunction("glfwGetError", "glfw")
                )(description);
            return __DSL_glfwGetError(__dsl_description);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description) =>
        DllImport.GetError(description);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void IGlfw.GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetFramebufferSize(Window* window, int* width, int* height) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetFramebufferSize", "glfw")
                )(window, width, height);
            __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    public static void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
        DllImport.GetFramebufferSize(window, width, height);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    Ptr<sbyte> IGlfw.GetGamepadName(int jid)
    {
        sbyte* __DSL_glfwGetGamepadName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetGamepadName", "glfw")
            )(jid);
        return __DSL_glfwGetGamepadName(jid);
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    public static Ptr<sbyte> GetGamepadName(int jid) => DllImport.GetGamepadName(jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int IGlfw.GetGamepadState(int jid, Ref<Gamepadstate> state)
    {
        fixed (Gamepadstate* __dsl_state = state)
        {
            int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state) =>
                (
                    (delegate* unmanaged<int, Gamepadstate*, int>)
                        nativeContext.LoadFunction("glfwGetGamepadState", "glfw")
                )(jid, state);
            return __DSL_glfwGetGamepadState(jid, __dsl_state);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    public static int GetGamepadState(int jid, Ref<Gamepadstate> state) =>
        DllImport.GetGamepadState(jid, state);

    [return: NativeTypeName("const GLFWgammaramp *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Ptr<Gammaramp> IGlfw.GetGammaRamp(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, Gammaramp*>)
                        nativeContext.LoadFunction("glfwGetGammaRamp", "glfw")
                )(monitor);
            return __DSL_glfwGetGammaRamp(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor) =>
        DllImport.GetGammaRamp(monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int IGlfw.GetInputMode(Ref<Window> window, int mode)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetInputMode(Window* window, int mode) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetInputMode", "glfw")
                )(window, mode);
            return __DSL_glfwGetInputMode(__dsl_window, mode);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    public static int GetInputMode(Ref<Window> window, int mode) =>
        DllImport.GetInputMode(window, mode);

    [return: NativeTypeName("const float *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    Ptr<float> IGlfw.GetJoystickAxes(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            float* __DSL_glfwGetJoystickAxes(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, float*>)
                        nativeContext.LoadFunction("glfwGetJoystickAxes", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const float *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count) =>
        DllImport.GetJoystickAxes(jid, count);

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    Ptr<byte> IGlfw.GetJoystickButtons(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            byte* __DSL_glfwGetJoystickButtons(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, byte*>)
                        nativeContext.LoadFunction("glfwGetJoystickButtons", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count) =>
        DllImport.GetJoystickButtons(jid, count);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    Ptr<sbyte> IGlfw.GetJoystickGuid(int jid)
    {
        sbyte* __DSL_glfwGetJoystickGUID(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickGUID", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickGUID(jid);
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    public static Ptr<sbyte> GetJoystickGuid(int jid) => DllImport.GetJoystickGuid(jid);

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    Ptr<byte> IGlfw.GetJoystickHats(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            byte* __DSL_glfwGetJoystickHats(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, byte*>)
                        nativeContext.LoadFunction("glfwGetJoystickHats", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickHats(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count) =>
        DllImport.GetJoystickHats(jid, count);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    Ptr<sbyte> IGlfw.GetJoystickName(int jid)
    {
        sbyte* __DSL_glfwGetJoystickName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickName", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickName(jid);
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    public static Ptr<sbyte> GetJoystickName(int jid) => DllImport.GetJoystickName(jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Ptr IGlfw.GetJoystickUserPointer(int jid)
    {
        void* __DSL_glfwGetJoystickUserPointer(int jid) =>
            (
                (delegate* unmanaged<int, void*>)
                    nativeContext.LoadFunction("glfwGetJoystickUserPointer", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickUserPointer(jid);
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    public static Ptr GetJoystickUserPointer(int jid) => DllImport.GetJoystickUserPointer(jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int IGlfw.GetKey(Ref<Window> window, int key)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetKey(Window* window, int key) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetKey", "glfw")
                )(window, key);
            return __DSL_glfwGetKey(__dsl_window, key);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    public static int GetKey(Ref<Window> window, int key) => DllImport.GetKey(window, key);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    Ptr<sbyte> IGlfw.GetKeyName(int key, int scancode)
    {
        sbyte* __DSL_glfwGetKeyName(int key, int scancode) =>
            (
                (delegate* unmanaged<int, int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetKeyName", "glfw")
            )(key, scancode);
        return __DSL_glfwGetKeyName(key, scancode);
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    public static Ptr<sbyte> GetKeyName(int key, int scancode) =>
        DllImport.GetKeyName(key, scancode);

    int IGlfw.GetKeyScancode(int key) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwGetKeyScancode", "glfw"))(
            key
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    public static int GetKeyScancode(int key) => DllImport.GetKeyScancode(key);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void IGlfw.GetMonitorContentScale(Ref<Monitor> monitor, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
                (
                    (delegate* unmanaged<Monitor*, float*, float*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorContentScale", "glfw")
                )(monitor, xscale, yscale);
            __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    public static void GetMonitorContentScale(
        Ref<Monitor> monitor,
        Ref<float> xscale,
        Ref<float> yscale
    ) => DllImport.GetMonitorContentScale(monitor, xscale, yscale);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    Ptr<sbyte> IGlfw.GetMonitorName(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            sbyte* __DSL_glfwGetMonitorName(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, sbyte*>)
                        nativeContext.LoadFunction("glfwGetMonitorName", "glfw")
                )(monitor);
            return __DSL_glfwGetMonitorName(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor) =>
        DllImport.GetMonitorName(monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void IGlfw.GetMonitorPhysicalSize(Ref<Monitor> monitor, Ref<int> widthMM, Ref<int> heightMM)
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
                (
                    (delegate* unmanaged<Monitor*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorPhysicalSize", "glfw")
                )(monitor, widthMM, heightMM);
            __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    public static void GetMonitorPhysicalSize(
        Ref<Monitor> monitor,
        Ref<int> widthMM,
        Ref<int> heightMM
    ) => DllImport.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void IGlfw.GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
                (
                    (delegate* unmanaged<Monitor*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorPos", "glfw")
                )(monitor, xpos, ypos);
            __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos) =>
        DllImport.GetMonitorPos(monitor, xpos, ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Ptr2D<Monitor> IGlfw.GetMonitors(Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            Monitor** __DSL_glfwGetMonitors(int* count) =>
                (
                    (delegate* unmanaged<int*, Monitor**>)
                        nativeContext.LoadFunction("glfwGetMonitors", "glfw")
                )(count);
            return __DSL_glfwGetMonitors(__dsl_count);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    public static Ptr2D<Monitor> GetMonitors(Ref<int> count) => DllImport.GetMonitors(count);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Ptr IGlfw.GetMonitorUserPointer(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, void*>)
                        nativeContext.LoadFunction("glfwGetMonitorUserPointer", "glfw")
                )(monitor);
            return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor) =>
        DllImport.GetMonitorUserPointer(monitor);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void IGlfw.GetMonitorWorkarea(
        Ref<Monitor> monitor,
        Ref<int> xpos,
        Ref<int> ypos,
        Ref<int> width,
        Ref<int> height
    )
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
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
            __DSL_glfwGetMonitorWorkarea(
                __dsl_monitor,
                __dsl_xpos,
                __dsl_ypos,
                __dsl_width,
                __dsl_height
            );
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    public static void GetMonitorWorkarea(
        Ref<Monitor> monitor,
        Ref<int> xpos,
        Ref<int> ypos,
        Ref<int> width,
        Ref<int> height
    ) => DllImport.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int IGlfw.GetMouseButton(Ref<Window> window, int button)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetMouseButton(Window* window, int button) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetMouseButton", "glfw")
                )(window, button);
            return __DSL_glfwGetMouseButton(__dsl_window, button);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    public static int GetMouseButton(Ref<Window> window, int button) =>
        DllImport.GetMouseButton(window, button);

    int IGlfw.GetPlatform() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwGetPlatform", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    public static int GetPlatform() => DllImport.GetPlatform();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Ptr<Monitor> IGlfw.GetPrimaryMonitor()
    {
        Monitor* __DSL_glfwGetPrimaryMonitor() =>
            (
                (delegate* unmanaged<Monitor*>)
                    nativeContext.LoadFunction("glfwGetPrimaryMonitor", "glfw")
            )();
        return __DSL_glfwGetPrimaryMonitor();
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    public static Ptr<Monitor> GetPrimaryMonitor() => DllImport.GetPrimaryMonitor();

    [return: NativeTypeName("GLFWglproc")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> IGlfw.GetProcAddress(
        [NativeTypeName("const char *")] Ref<sbyte> procname
    )
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                [NativeTypeName("const char *")] sbyte* procname
            ) =>
                (
                    (delegate* unmanaged<sbyte*, delegate* unmanaged<void>>)
                        nativeContext.LoadFunction("glfwGetProcAddress", "glfw")
                )(procname);
            return __DSL_glfwGetProcAddress(__dsl_procname);
        }
    }

    [return: NativeTypeName("GLFWglproc")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    public static delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] Ref<sbyte> procname
    ) => DllImport.GetProcAddress(procname);

    [return: NativeTypeName("const char **")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    Ptr2D<sbyte> IGlfw.GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Ref<uint> count)
    {
        fixed (uint* __dsl_count = count)
        {
            sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                [NativeTypeName("uint32_t *")] uint* count
            ) =>
                (
                    (delegate* unmanaged<uint*, sbyte**>)
                        nativeContext.LoadFunction("glfwGetRequiredInstanceExtensions", "glfw")
                )(count);
            return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
        }
    }

    [return: NativeTypeName("const char **")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Ref<uint> count
    ) => DllImport.GetRequiredInstanceExtensions(count);

    double IGlfw.GetTime() =>
        ((delegate* unmanaged<double>)nativeContext.LoadFunction("glfwGetTime", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    public static double GetTime() => DllImport.GetTime();

    ulong IGlfw.GetTimerFrequency() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerFrequency", "glfw"))();

    [return: NativeTypeName("uint64_t")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    public static ulong GetTimerFrequency() => DllImport.GetTimerFrequency();

    ulong IGlfw.GetTimerValue() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerValue", "glfw"))();

    [return: NativeTypeName("uint64_t")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    public static ulong GetTimerValue() => DllImport.GetTimerValue();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void IGlfw.GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            void __DSL_glfwGetVersion(int* major, int* minor, int* rev) =>
                (
                    (delegate* unmanaged<int*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetVersion", "glfw")
                )(major, minor, rev);
            __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev) =>
        DllImport.GetVersion(major, minor, rev);

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    Ptr<sbyte> IGlfw.GetVersionString()
    {
        sbyte* __DSL_glfwGetVersionString() =>
            (
                (delegate* unmanaged<sbyte*>)
                    nativeContext.LoadFunction("glfwGetVersionString", "glfw")
            )();
        return __DSL_glfwGetVersionString();
    }

    [return: NativeTypeName("const char *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    public static Ptr<sbyte> GetVersionString() => DllImport.GetVersionString();

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Ptr<Vidmode> IGlfw.GetVideoMode(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, Vidmode*>)
                        nativeContext.LoadFunction("glfwGetVideoMode", "glfw")
                )(monitor);
            return __DSL_glfwGetVideoMode(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor) =>
        DllImport.GetVideoMode(monitor);

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Ptr<Vidmode> IGlfw.GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count) =>
                (
                    (delegate* unmanaged<Monitor*, int*, Vidmode*>)
                        nativeContext.LoadFunction("glfwGetVideoModes", "glfw")
                )(monitor, count);
            return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count) =>
        DllImport.GetVideoModes(monitor, count);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int IGlfw.GetWindowAttrib(Ref<Window> window, int attrib)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetWindowAttrib(Window* window, int attrib) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetWindowAttrib", "glfw")
                )(window, attrib);
            return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    public static int GetWindowAttrib(Ref<Window> window, int attrib) =>
        DllImport.GetWindowAttrib(window, attrib);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void IGlfw.GetWindowContentScale(Ref<Window> window, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowContentScale(Window* window, float* xscale, float* yscale) =>
                (
                    (delegate* unmanaged<Window*, float*, float*, void>)
                        nativeContext.LoadFunction("glfwGetWindowContentScale", "glfw")
                )(window, xscale, yscale);
            __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    public static void GetWindowContentScale(
        Ref<Window> window,
        Ref<float> xscale,
        Ref<float> yscale
    ) => DllImport.GetWindowContentScale(window, xscale, yscale);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void IGlfw.GetWindowFrameSize(
        Ref<Window> window,
        Ref<int> left,
        Ref<int> top,
        Ref<int> right,
        Ref<int> bottom
    )
    {
        fixed (int* __dsl_bottom = bottom)
        fixed (int* __dsl_right = right)
        fixed (int* __dsl_top = top)
        fixed (int* __dsl_left = left)
        fixed (Window* __dsl_window = window)
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
            __DSL_glfwGetWindowFrameSize(
                __dsl_window,
                __dsl_left,
                __dsl_top,
                __dsl_right,
                __dsl_bottom
            );
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    public static void GetWindowFrameSize(
        Ref<Window> window,
        Ref<int> left,
        Ref<int> top,
        Ref<int> right,
        Ref<int> bottom
    ) => DllImport.GetWindowFrameSize(window, left, top, right, bottom);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Ptr<Monitor> IGlfw.GetWindowMonitor(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            Monitor* __DSL_glfwGetWindowMonitor(Window* window) =>
                (
                    (delegate* unmanaged<Window*, Monitor*>)
                        nativeContext.LoadFunction("glfwGetWindowMonitor", "glfw")
                )(window);
            return __DSL_glfwGetWindowMonitor(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window) =>
        DllImport.GetWindowMonitor(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float IGlfw.GetWindowOpacity(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            float __DSL_glfwGetWindowOpacity(Window* window) =>
                (
                    (delegate* unmanaged<Window*, float>)
                        nativeContext.LoadFunction("glfwGetWindowOpacity", "glfw")
                )(window);
            return __DSL_glfwGetWindowOpacity(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    public static float GetWindowOpacity(Ref<Window> window) => DllImport.GetWindowOpacity(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void IGlfw.GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetWindowPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos) =>
        DllImport.GetWindowPos(window, xpos, ypos);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void IGlfw.GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowSize(Window* window, int* width, int* height) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetWindowSize", "glfw")
                )(window, width, height);
            __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
        DllImport.GetWindowSize(window, width, height);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Ptr IGlfw.GetWindowUserPointer(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void* __DSL_glfwGetWindowUserPointer(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void*>)
                        nativeContext.LoadFunction("glfwGetWindowUserPointer", "glfw")
                )(window);
            return __DSL_glfwGetWindowUserPointer(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    public static Ptr GetWindowUserPointer(Ref<Window> window) =>
        DllImport.GetWindowUserPointer(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void IGlfw.HideWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwHideWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwHideWindow", "glfw")
                )(window);
            __DSL_glfwHideWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    public static void HideWindow(Ref<Window> window) => DllImport.HideWindow(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IGlfw.IconifyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwIconifyWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwIconifyWindow", "glfw")
                )(window);
            __DSL_glfwIconifyWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    public static void IconifyWindow(Ref<Window> window) => DllImport.IconifyWindow(window);

    int IGlfw.Init() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwInit", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    public static int Init() => DllImport.Init();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void IGlfw.InitAllocator([NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator)
    {
        fixed (Allocator* __dsl_allocator = allocator)
        {
            void __DSL_glfwInitAllocator(
                [NativeTypeName("const GLFWallocator *")] Allocator* allocator
            ) =>
                (
                    (delegate* unmanaged<Allocator*, void>)
                        nativeContext.LoadFunction("glfwInitAllocator", "glfw")
                )(allocator);
            __DSL_glfwInitAllocator(__dsl_allocator);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    public static void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
    ) => DllImport.InitAllocator(allocator);

    void IGlfw.InitHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwInitHint", "glfw"))(
            hint,
            value
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    public static void InitHint(int hint, int value) => DllImport.InitHint(hint, value);

    int IGlfw.JoystickIsGamepad(int jid) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwJoystickIsGamepad", "glfw")
        )(jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    public static int JoystickIsGamepad(int jid) => DllImport.JoystickIsGamepad(jid);

    int IGlfw.JoystickPresent(int jid) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwJoystickPresent", "glfw"))(
            jid
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    public static int JoystickPresent(int jid) => DllImport.JoystickPresent(jid);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void IGlfw.MakeContextCurrent(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwMakeContextCurrent(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwMakeContextCurrent", "glfw")
                )(window);
            __DSL_glfwMakeContextCurrent(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    public static void MakeContextCurrent(Ref<Window> window) =>
        DllImport.MakeContextCurrent(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void IGlfw.MaximizeWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwMaximizeWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwMaximizeWindow", "glfw")
                )(window);
            __DSL_glfwMaximizeWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    public static void MaximizeWindow(Ref<Window> window) => DllImport.MaximizeWindow(window);

    int IGlfw.PlatformSupported(int platform) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwPlatformSupported", "glfw")
        )(platform);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    public static int PlatformSupported(int platform) => DllImport.PlatformSupported(platform);

    void IGlfw.PollEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPollEvents", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    public static void PollEvents() => DllImport.PollEvents();

    void IGlfw.PostEmptyEvent() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPostEmptyEvent", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    public static void PostEmptyEvent() => DllImport.PostEmptyEvent();

    int IGlfw.RawMouseMotionSupported() =>
        (
            (delegate* unmanaged<int>)
                nativeContext.LoadFunction("glfwRawMouseMotionSupported", "glfw")
        )();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    public static int RawMouseMotionSupported() => DllImport.RawMouseMotionSupported();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void IGlfw.RequestWindowAttention(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwRequestWindowAttention(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwRequestWindowAttention", "glfw")
                )(window);
            __DSL_glfwRequestWindowAttention(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    public static void RequestWindowAttention(Ref<Window> window) =>
        DllImport.RequestWindowAttention(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void IGlfw.RestoreWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwRestoreWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwRestoreWindow", "glfw")
                )(window);
            __DSL_glfwRestoreWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    public static void RestoreWindow(Ref<Window> window) => DllImport.RestoreWindow(window);

    [return: NativeTypeName("GLFWcharfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> IGlfw.SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetCharCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    ) => DllImport.SetCharCallback(window, callback);

    [return: NativeTypeName("GLFWcharmodsfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> IGlfw.SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    ) => DllImport.SetCharModsCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void IGlfw.SetClipboardString(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> @string
    )
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetClipboardString(
                Window* window,
                [NativeTypeName("const char *")] sbyte* @string
            ) =>
                (
                    (delegate* unmanaged<Window*, sbyte*, void>)
                        nativeContext.LoadFunction("glfwSetClipboardString", "glfw")
                )(window, @string);
            __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    public static void SetClipboardString(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> @string
    ) => DllImport.SetClipboardString(window, @string);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void IGlfw.SetCursor(Ref<Window> window, Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetCursor(Window* window, Cursor* cursor) =>
                (
                    (delegate* unmanaged<Window*, Cursor*, void>)
                        nativeContext.LoadFunction("glfwSetCursor", "glfw")
                )(window, cursor);
            __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor) =>
        DllImport.SetCursor(window, cursor);

    [return: NativeTypeName("GLFWcursorenterfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
                Window* window,
                [NativeTypeName("GLFWcursorenterfun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetCursorEnterCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetCursorEnterCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void IGlfw.SetCursorPos(Ref<Window> window, double xpos, double ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos) =>
                (
                    (delegate* unmanaged<Window*, double, double, void>)
                        nativeContext.LoadFunction("glfwSetCursorPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    public static void SetCursorPos(Ref<Window> window, double xpos, double ypos) =>
        DllImport.SetCursorPos(window, xpos, ypos);

    [return: NativeTypeName("GLFWcursorposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetCursorPosCallback(window, callback);

    [return: NativeTypeName("GLFWdropfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> IGlfw.SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetDropCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWdropfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    ) => DllImport.SetDropCallback(window, callback);

    delegate* unmanaged<int, sbyte*, void> IGlfw.SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, sbyte*, void>,
                delegate* unmanaged<int, sbyte*, void>>)
                nativeContext.LoadFunction("glfwSetErrorCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWerrorfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    public static delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) => DllImport.SetErrorCallback(callback);

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetFramebufferSizeCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void IGlfw.SetGamma(Ref<Monitor> monitor, float gamma)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetGamma(Monitor* monitor, float gamma) =>
                (
                    (delegate* unmanaged<Monitor*, float, void>)
                        nativeContext.LoadFunction("glfwSetGamma", "glfw")
                )(monitor, gamma);
            __DSL_glfwSetGamma(__dsl_monitor, gamma);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    public static void SetGamma(Ref<Monitor> monitor, float gamma) =>
        DllImport.SetGamma(monitor, gamma);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void IGlfw.SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    )
    {
        fixed (Gammaramp* __dsl_ramp = ramp)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetGammaRamp(
                Monitor* monitor,
                [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
            ) =>
                (
                    (delegate* unmanaged<Monitor*, Gammaramp*, void>)
                        nativeContext.LoadFunction("glfwSetGammaRamp", "glfw")
                )(monitor, ramp);
            __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    public static void SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    ) => DllImport.SetGammaRamp(monitor, ramp);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void IGlfw.SetInputMode(Ref<Window> window, int mode, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetInputMode(Window* window, int mode, int value) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetInputMode", "glfw")
                )(window, mode, value);
            __DSL_glfwSetInputMode(__dsl_window, mode, value);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    public static void SetInputMode(Ref<Window> window, int mode, int value) =>
        DllImport.SetInputMode(window, mode, value);

    delegate* unmanaged<int, int, void> IGlfw.SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, int, void>,
                delegate* unmanaged<int, int, void>>)
                nativeContext.LoadFunction("glfwSetJoystickCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWjoystickfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    public static delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) => DllImport.SetJoystickCallback(callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void IGlfw.SetJoystickUserPointer(int jid, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer) =>
                (
                    (delegate* unmanaged<int, void*, void>)
                        nativeContext.LoadFunction("glfwSetJoystickUserPointer", "glfw")
                )(jid, pointer);
            __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    public static void SetJoystickUserPointer(int jid, Ref pointer) =>
        DllImport.SetJoystickUserPointer(jid, pointer);

    [return: NativeTypeName("GLFWkeyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> IGlfw.SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetKeyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    ) => DllImport.SetKeyCallback(window, callback);

    delegate* unmanaged<Monitor*, int, void> IGlfw.SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<Monitor*, int, void>,
                delegate* unmanaged<Monitor*, int, void>>)
                nativeContext.LoadFunction("glfwSetMonitorCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWmonitorfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    public static delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) => DllImport.SetMonitorCallback(callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void IGlfw.SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer) =>
                (
                    (delegate* unmanaged<Monitor*, void*, void>)
                        nativeContext.LoadFunction("glfwSetMonitorUserPointer", "glfw")
                )(monitor, pointer);
            __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer) =>
        DllImport.SetMonitorUserPointer(monitor, pointer);

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> IGlfw.SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    ) => DllImport.SetMouseButtonCallback(window, callback);

    [return: NativeTypeName("GLFWscrollfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetScrollCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetScrollCallback(window, callback);

    void IGlfw.SetTime(double time) =>
        ((delegate* unmanaged<double, void>)nativeContext.LoadFunction("glfwSetTime", "glfw"))(
            time
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    public static void SetTime(double time) => DllImport.SetTime(time);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void IGlfw.SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowAspectRatio", "glfw")
                )(window, numer, denom);
            __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom) =>
        DllImport.SetWindowAspectRatio(window, numer, denom);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void IGlfw.SetWindowAttrib(Ref<Window> window, int attrib, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowAttrib", "glfw")
                )(window, attrib, value);
            __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    public static void SetWindowAttrib(Ref<Window> window, int attrib, int value) =>
        DllImport.SetWindowAttrib(window, attrib, value);

    [return: NativeTypeName("GLFWwindowclosefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowCloseCallback(window, callback);

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> IGlfw.SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<
                Window*,
                float,
                float,
                void> __DSL_glfwSetWindowContentScaleCallback(
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
            return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    public static delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    ) => DllImport.SetWindowContentScaleCallback(window, callback);

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
                Window* window,
                [NativeTypeName("GLFWwindowfocusfun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowFocusCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowFocusCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void IGlfw.SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    )
    {
        fixed (Image* __dsl_images = images)
        fixed (Window* __dsl_window = window)
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
            __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    public static void SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    ) => DllImport.SetWindowIcon(window, count, images);

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowIconifyCallback(window, callback);

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowMaximizeCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void IGlfw.SetWindowMonitor(
        Ref<Window> window,
        Ref<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    )
    {
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (Window* __dsl_window = window)
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
            __DSL_glfwSetWindowMonitor(
                __dsl_window,
                __dsl_monitor,
                xpos,
                ypos,
                width,
                height,
                refreshRate
            );
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    public static void SetWindowMonitor(
        Ref<Window> window,
        Ref<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    ) => DllImport.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void IGlfw.SetWindowOpacity(Ref<Window> window, float opacity)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowOpacity(Window* window, float opacity) =>
                (
                    (delegate* unmanaged<Window*, float, void>)
                        nativeContext.LoadFunction("glfwSetWindowOpacity", "glfw")
                )(window, opacity);
            __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    public static void SetWindowOpacity(Ref<Window> window, float opacity) =>
        DllImport.SetWindowOpacity(window, opacity);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void IGlfw.SetWindowPos(Ref<Window> window, int xpos, int ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    public static void SetWindowPos(Ref<Window> window, int xpos, int ypos) =>
        DllImport.SetWindowPos(window, xpos, ypos);

    [return: NativeTypeName("GLFWwindowposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowPosCallback(window, callback);

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowRefreshCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void IGlfw.SetWindowShouldClose(Ref<Window> window, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowShouldClose(Window* window, int value) =>
                (
                    (delegate* unmanaged<Window*, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowShouldClose", "glfw")
                )(window, value);
            __DSL_glfwSetWindowShouldClose(__dsl_window, value);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    public static void SetWindowShouldClose(Ref<Window> window, int value) =>
        DllImport.SetWindowShouldClose(window, value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void IGlfw.SetWindowSize(Ref<Window> window, int width, int height)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowSize(Window* window, int width, int height) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowSize", "glfw")
                )(window, width, height);
            __DSL_glfwSetWindowSize(__dsl_window, width, height);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    public static void SetWindowSize(Ref<Window> window, int width, int height) =>
        DllImport.SetWindowSize(window, width, height);

    [return: NativeTypeName("GLFWwindowsizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
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
            return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowSizeCallback(window, callback);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void IGlfw.SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        fixed (Window* __dsl_window = window)
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
            __DSL_glfwSetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    public static void SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    ) => DllImport.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void IGlfw.SetWindowTitle(Ref<Window> window, [NativeTypeName("const char *")] Ref<sbyte> title)
    {
        fixed (sbyte* __dsl_title = title)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowTitle(
                Window* window,
                [NativeTypeName("const char *")] sbyte* title
            ) =>
                (
                    (delegate* unmanaged<Window*, sbyte*, void>)
                        nativeContext.LoadFunction("glfwSetWindowTitle", "glfw")
                )(window, title);
            __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    public static void SetWindowTitle(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> title
    ) => DllImport.SetWindowTitle(window, title);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void IGlfw.SetWindowUserPointer(Ref<Window> window, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer) =>
                (
                    (delegate* unmanaged<Window*, void*, void>)
                        nativeContext.LoadFunction("glfwSetWindowUserPointer", "glfw")
                )(window, pointer);
            __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    public static void SetWindowUserPointer(Ref<Window> window, Ref pointer) =>
        DllImport.SetWindowUserPointer(window, pointer);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void IGlfw.ShowWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwShowWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwShowWindow", "glfw")
                )(window);
            __DSL_glfwShowWindow(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    public static void ShowWindow(Ref<Window> window) => DllImport.ShowWindow(window);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void IGlfw.SwapBuffers(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSwapBuffers(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwSwapBuffers", "glfw")
                )(window);
            __DSL_glfwSwapBuffers(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    public static void SwapBuffers(Ref<Window> window) => DllImport.SwapBuffers(window);

    void IGlfw.SwapInterval(int interval) =>
        ((delegate* unmanaged<int, void>)nativeContext.LoadFunction("glfwSwapInterval", "glfw"))(
            interval
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    public static void SwapInterval(int interval) => DllImport.SwapInterval(interval);

    void IGlfw.Terminate() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwTerminate", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    public static void Terminate() => DllImport.Terminate();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int IGlfw.UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            int __DSL_glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
                (
                    (delegate* unmanaged<sbyte*, int>)
                        nativeContext.LoadFunction("glfwUpdateGamepadMappings", "glfw")
                )(@string);
            return __DSL_glfwUpdateGamepadMappings(__dsl_string);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string) =>
        DllImport.UpdateGamepadMappings(@string);

    int IGlfw.VulkanSupported() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwVulkanSupported", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    public static int VulkanSupported() => DllImport.VulkanSupported();

    void IGlfw.WaitEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwWaitEvents", "glfw"))();

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    public static void WaitEvents() => DllImport.WaitEvents();

    void IGlfw.WaitEventsTimeout(double timeout) =>
        (
            (delegate* unmanaged<double, void>)
                nativeContext.LoadFunction("glfwWaitEventsTimeout", "glfw")
        )(timeout);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    public static void WaitEventsTimeout(double timeout) => DllImport.WaitEventsTimeout(timeout);

    void IGlfw.WindowHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwWindowHint", "glfw"))(
            hint,
            value
        );

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    public static void WindowHint(int hint, int value) => DllImport.WindowHint(hint, value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void IGlfw.WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            void __DSL_glfwWindowHintString(
                int hint,
                [NativeTypeName("const char *")] sbyte* value
            ) =>
                (
                    (delegate* unmanaged<int, sbyte*, void>)
                        nativeContext.LoadFunction("glfwWindowHintString", "glfw")
                )(hint, value);
            __DSL_glfwWindowHintString(hint, __dsl_value);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    public static void WindowHintString(
        int hint,
        [NativeTypeName("const char *")] Ref<sbyte> value
    ) => DllImport.WindowHintString(hint, value);

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int IGlfw.WindowShouldClose(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwWindowShouldClose(Window* window) =>
                (
                    (delegate* unmanaged<Window*, int>)
                        nativeContext.LoadFunction("glfwWindowShouldClose", "glfw")
                )(window);
            return __DSL_glfwWindowShouldClose(__dsl_window);
        }
    }

    [SupportedApiProfile("test1")]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    public static int WindowShouldClose(Ref<Window> window) => DllImport.WindowShouldClose(window);
}
