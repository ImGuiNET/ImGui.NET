using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiShrinkWidthItem
    {
        public int Index;
        public float Width;
    }
    public unsafe partial struct ImGuiShrinkWidthItemPtr
    {
        public ImGuiShrinkWidthItem* NativePtr { get; }
        public ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => NativePtr = nativePtr;
        public ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiShrinkWidthItem*)nativePtr;
        public static implicit operator ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => new ImGuiShrinkWidthItemPtr(nativePtr);
        public static implicit operator ImGuiShrinkWidthItem* (ImGuiShrinkWidthItemPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => new ImGuiShrinkWidthItemPtr(nativePtr);
        public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);
        public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
    }
}
