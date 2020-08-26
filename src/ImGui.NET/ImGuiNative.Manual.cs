using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Set_Platform_GetWindowPos(ImGuiPlatformIO* platform_io, IntPtr funcPtr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Set_Platform_GetWindowSize(ImGuiPlatformIO* platform_io, IntPtr funcPtr);
    }
}
