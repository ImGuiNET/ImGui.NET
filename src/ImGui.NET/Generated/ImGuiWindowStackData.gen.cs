using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiWindowStackData
    {
        public ImGuiWindow* Window;
        public ImGuiLastItemData ParentLastItemDataBackup;
    }
    public unsafe partial struct ImGuiWindowStackDataPtr
    {
        public ImGuiWindowStackData* NativePtr { get; }
        public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
        public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);
        public static implicit operator ImGuiWindowStackData* (ImGuiWindowStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiWindowStackDataPtr(IntPtr nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref ImGuiLastItemData ParentLastItemDataBackup => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->ParentLastItemDataBackup);
    }
}
