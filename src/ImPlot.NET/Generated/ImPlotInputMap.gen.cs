using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotInputMap
    {
        public ImGuiMouseButton Pan;
        public ImGuiModFlags PanMod;
        public ImGuiMouseButton Fit;
        public ImGuiMouseButton Select;
        public ImGuiMouseButton SelectCancel;
        public ImGuiModFlags SelectMod;
        public ImGuiModFlags SelectHorzMod;
        public ImGuiModFlags SelectVertMod;
        public ImGuiMouseButton Menu;
        public ImGuiModFlags OverrideMod;
        public ImGuiModFlags ZoomMod;
        public float ZoomRate;
    }
    public unsafe partial struct ImPlotInputMapPtr
    {
        public ImPlotInputMap* NativePtr { get; }
        public ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => NativePtr = nativePtr;
        public ImPlotInputMapPtr(IntPtr nativePtr) => NativePtr = (ImPlotInputMap*)nativePtr;
        public static implicit operator ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public static implicit operator ImPlotInputMap* (ImPlotInputMapPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotInputMapPtr(IntPtr nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public ref ImGuiMouseButton Pan => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Pan);
        public ref ImGuiModFlags PanMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->PanMod);
        public ref ImGuiMouseButton Fit => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Fit);
        public ref ImGuiMouseButton Select => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Select);
        public ref ImGuiMouseButton SelectCancel => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->SelectCancel);
        public ref ImGuiModFlags SelectMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->SelectMod);
        public ref ImGuiModFlags SelectHorzMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->SelectHorzMod);
        public ref ImGuiModFlags SelectVertMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->SelectVertMod);
        public ref ImGuiMouseButton Menu => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Menu);
        public ref ImGuiModFlags OverrideMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->OverrideMod);
        public ref ImGuiModFlags ZoomMod => ref Unsafe.AsRef<ImGuiModFlags>(&NativePtr->ZoomMod);
        public ref float ZoomRate => ref Unsafe.AsRef<float>(&NativePtr->ZoomRate);
        public void Destroy()
        {
            ImPlotNative.ImPlotInputMap_destroy((ImPlotInputMap*)(NativePtr));
        }
    }
}
