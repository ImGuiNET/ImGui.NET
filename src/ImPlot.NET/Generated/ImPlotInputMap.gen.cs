using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotInputMap
    {
        public ImGuiMouseButton PanButton;
        public ImGuiKeyModFlags PanMod;
        public ImGuiMouseButton FitButton;
        public ImGuiMouseButton ContextMenuButton;
        public ImGuiMouseButton BoxSelectButton;
        public ImGuiKeyModFlags BoxSelectMod;
        public ImGuiMouseButton BoxSelectCancelButton;
        public ImGuiMouseButton QueryButton;
        public ImGuiKeyModFlags QueryMod;
        public ImGuiKeyModFlags QueryToggleMod;
        public ImGuiKeyModFlags HorizontalMod;
        public ImGuiKeyModFlags VerticalMod;
    }
    public unsafe partial struct ImPlotInputMapPtr
    {
        public ImPlotInputMap* NativePtr { get; }
        public ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => NativePtr = nativePtr;
        public ImPlotInputMapPtr(IntPtr nativePtr) => NativePtr = (ImPlotInputMap*)nativePtr;
        public static implicit operator ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public static implicit operator ImPlotInputMap* (ImPlotInputMapPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotInputMapPtr(IntPtr nativePtr) => new ImPlotInputMapPtr(nativePtr);
        public ref ImGuiMouseButton PanButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->PanButton);
        public ref ImGuiKeyModFlags PanMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->PanMod);
        public ref ImGuiMouseButton FitButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->FitButton);
        public ref ImGuiMouseButton ContextMenuButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->ContextMenuButton);
        public ref ImGuiMouseButton BoxSelectButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->BoxSelectButton);
        public ref ImGuiKeyModFlags BoxSelectMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->BoxSelectMod);
        public ref ImGuiMouseButton BoxSelectCancelButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->BoxSelectCancelButton);
        public ref ImGuiMouseButton QueryButton => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->QueryButton);
        public ref ImGuiKeyModFlags QueryMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->QueryMod);
        public ref ImGuiKeyModFlags QueryToggleMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->QueryToggleMod);
        public ref ImGuiKeyModFlags HorizontalMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->HorizontalMod);
        public ref ImGuiKeyModFlags VerticalMod => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->VerticalMod);
        public void Destroy()
        {
            ImPlotNative.ImPlotInputMap_destroy((ImPlotInputMap*)(NativePtr));
        }
    }
}
