using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiLastItemData
    {
        public uint ID;
        public ImGuiItemFlags InFlags;
        public ImGuiItemStatusFlags StatusFlags;
        public ImRect Rect;
        public ImRect NavRect;
        public ImRect DisplayRect;
    }
    public unsafe partial struct ImGuiLastItemDataPtr
    {
        public ImGuiLastItemData* NativePtr { get; }
        public ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => NativePtr = nativePtr;
        public ImGuiLastItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiLastItemData*)nativePtr;
        public static implicit operator ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => new ImGuiLastItemDataPtr(nativePtr);
        public static implicit operator ImGuiLastItemData* (ImGuiLastItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiLastItemDataPtr(IntPtr nativePtr) => new ImGuiLastItemDataPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiItemFlags InFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->InFlags);
        public ref ImGuiItemStatusFlags StatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->StatusFlags);
        public ref ImRect Rect => ref Unsafe.AsRef<ImRect>(&NativePtr->Rect);
        public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);
        public ref ImRect DisplayRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DisplayRect);
        public void Destroy()
        {
            ImGuiNative.ImGuiLastItemData_destroy((ImGuiLastItemData*)(NativePtr));
        }
    }
}
