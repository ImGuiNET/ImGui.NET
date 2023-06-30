using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiPlatformMonitor
    {
        public Vector2 MainPos;
        public Vector2 MainSize;
        public Vector2 WorkPos;
        public Vector2 WorkSize;
        public float DpiScale;
        public void* PlatformHandle;
    }
    public unsafe partial struct ImGuiPlatformMonitorPtr
    {
        public ImGuiPlatformMonitor* NativePtr { get; }
        public ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => NativePtr = nativePtr;
        public ImGuiPlatformMonitorPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformMonitor*)nativePtr;
        public static implicit operator ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => new ImGuiPlatformMonitorPtr(nativePtr);
        public static implicit operator ImGuiPlatformMonitor* (ImGuiPlatformMonitorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPlatformMonitorPtr(IntPtr nativePtr) => new ImGuiPlatformMonitorPtr(nativePtr);
        public ref Vector2 MainPos => ref Unsafe.AsRef<Vector2>(&NativePtr->MainPos);
        public ref Vector2 MainSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MainSize);
        public ref Vector2 WorkPos => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkPos);
        public ref Vector2 WorkSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkSize);
        public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);
        public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImGuiPlatformMonitor_destroy((ImGuiPlatformMonitor*)(NativePtr));
        }
    }
}
