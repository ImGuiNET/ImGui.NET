using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTabItem
    {
        public uint ID;
        public ImGuiTabItemFlags Flags;
        public ImGuiWindow* Window;
        public int LastFrameVisible;
        public int LastFrameSelected;
        public float Offset;
        public float Width;
        public float ContentWidth;
        public int NameOffset;
        public short BeginOrder;
        public short IndexDuringLayout;
        public byte WantClose;
    }
    public unsafe partial struct ImGuiTabItemPtr
    {
        public ImGuiTabItem* NativePtr { get; }
        public ImGuiTabItemPtr(ImGuiTabItem* nativePtr) => NativePtr = nativePtr;
        public ImGuiTabItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiTabItem*)nativePtr;
        public static implicit operator ImGuiTabItemPtr(ImGuiTabItem* nativePtr) => new ImGuiTabItemPtr(nativePtr);
        public static implicit operator ImGuiTabItem* (ImGuiTabItemPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTabItemPtr(IntPtr nativePtr) => new ImGuiTabItemPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiTabItemFlags Flags => ref Unsafe.AsRef<ImGuiTabItemFlags>(&NativePtr->Flags);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref int LastFrameVisible => ref Unsafe.AsRef<int>(&NativePtr->LastFrameVisible);
        public ref int LastFrameSelected => ref Unsafe.AsRef<int>(&NativePtr->LastFrameSelected);
        public ref float Offset => ref Unsafe.AsRef<float>(&NativePtr->Offset);
        public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
        public ref float ContentWidth => ref Unsafe.AsRef<float>(&NativePtr->ContentWidth);
        public ref int NameOffset => ref Unsafe.AsRef<int>(&NativePtr->NameOffset);
        public ref short BeginOrder => ref Unsafe.AsRef<short>(&NativePtr->BeginOrder);
        public ref short IndexDuringLayout => ref Unsafe.AsRef<short>(&NativePtr->IndexDuringLayout);
        public ref bool WantClose => ref Unsafe.AsRef<bool>(&NativePtr->WantClose);
        public void Destroy()
        {
            ImGuiNative.ImGuiTabItem_destroy((ImGuiTabItem*)(NativePtr));
        }
    }
}
