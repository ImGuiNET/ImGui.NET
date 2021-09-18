using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiOldColumnData
    {
        public float OffsetNorm;
        public float OffsetNormBeforeResize;
        public ImGuiOldColumnFlags Flags;
        public ImRect ClipRect;
    }
    public unsafe partial struct ImGuiOldColumnDataPtr
    {
        public ImGuiOldColumnData* NativePtr { get; }
        public ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => NativePtr = nativePtr;
        public ImGuiOldColumnDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumnData*)nativePtr;
        public static implicit operator ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => new ImGuiOldColumnDataPtr(nativePtr);
        public static implicit operator ImGuiOldColumnData* (ImGuiOldColumnDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiOldColumnDataPtr(IntPtr nativePtr) => new ImGuiOldColumnDataPtr(nativePtr);
        public ref float OffsetNorm => ref Unsafe.AsRef<float>(&NativePtr->OffsetNorm);
        public ref float OffsetNormBeforeResize => ref Unsafe.AsRef<float>(&NativePtr->OffsetNormBeforeResize);
        public ref ImGuiOldColumnFlags Flags => ref Unsafe.AsRef<ImGuiOldColumnFlags>(&NativePtr->Flags);
        public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
        public void Destroy()
        {
            ImGuiNative.ImGuiOldColumnData_destroy((ImGuiOldColumnData*)(NativePtr));
        }
    }
}
