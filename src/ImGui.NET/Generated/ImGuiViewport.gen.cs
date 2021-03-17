using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiViewport
    {
        public ImGuiViewportFlags Flags;
        public Vector2 Pos;
        public Vector2 Size;
        public Vector2 WorkPos;
        public Vector2 WorkSize;
    }
    public unsafe partial struct ImGuiViewportPtr
    {
        public ImGuiViewport* NativePtr { get; }
        public ImGuiViewportPtr(ImGuiViewport* nativePtr) => NativePtr = nativePtr;
        public ImGuiViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewport*)nativePtr;
        public static implicit operator ImGuiViewportPtr(ImGuiViewport* nativePtr) => new ImGuiViewportPtr(nativePtr);
        public static implicit operator ImGuiViewport* (ImGuiViewportPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiViewportPtr(IntPtr nativePtr) => new ImGuiViewportPtr(nativePtr);
        public ref ImGuiViewportFlags Flags => ref Unsafe.AsRef<ImGuiViewportFlags>(&NativePtr->Flags);
        public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
        public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);
        public ref Vector2 WorkPos => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkPos);
        public ref Vector2 WorkSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkSize);
        public void Destroy()
        {
            ImGuiNative.ImGuiViewport_destroy((ImGuiViewport*)(NativePtr));
        }
        public Vector2 GetCenter()
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewport_GetCenter(&__retval, (ImGuiViewport*)(NativePtr));
            return __retval;
        }
        public Vector2 GetWorkCenter()
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewport_GetWorkCenter(&__retval, (ImGuiViewport*)(NativePtr));
            return __retval;
        }
    }
}
