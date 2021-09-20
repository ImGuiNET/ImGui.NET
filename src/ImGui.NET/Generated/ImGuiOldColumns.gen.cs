using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiOldColumns
    {
        public uint ID;
        public ImGuiOldColumnFlags Flags;
        public byte IsFirstFrame;
        public byte IsBeingResized;
        public int Current;
        public int Count;
        public float OffMinX;
        public float OffMaxX;
        public float LineMinY;
        public float LineMaxY;
        public float HostCursorPosY;
        public float HostCursorMaxPosX;
        public ImRect HostInitialClipRect;
        public ImRect HostBackupClipRect;
        public ImRect HostBackupParentWorkRect;
        public ImVector Columns;
        public ImDrawListSplitter Splitter;
    }
    public unsafe partial struct ImGuiOldColumnsPtr
    {
        public ImGuiOldColumns* NativePtr { get; }
        public ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => NativePtr = nativePtr;
        public ImGuiOldColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumns*)nativePtr;
        public static implicit operator ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => new ImGuiOldColumnsPtr(nativePtr);
        public static implicit operator ImGuiOldColumns* (ImGuiOldColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiOldColumnsPtr(IntPtr nativePtr) => new ImGuiOldColumnsPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiOldColumnFlags Flags => ref Unsafe.AsRef<ImGuiOldColumnFlags>(&NativePtr->Flags);
        public ref bool IsFirstFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsFirstFrame);
        public ref bool IsBeingResized => ref Unsafe.AsRef<bool>(&NativePtr->IsBeingResized);
        public ref int Current => ref Unsafe.AsRef<int>(&NativePtr->Current);
        public ref int Count => ref Unsafe.AsRef<int>(&NativePtr->Count);
        public ref float OffMinX => ref Unsafe.AsRef<float>(&NativePtr->OffMinX);
        public ref float OffMaxX => ref Unsafe.AsRef<float>(&NativePtr->OffMaxX);
        public ref float LineMinY => ref Unsafe.AsRef<float>(&NativePtr->LineMinY);
        public ref float LineMaxY => ref Unsafe.AsRef<float>(&NativePtr->LineMaxY);
        public ref float HostCursorPosY => ref Unsafe.AsRef<float>(&NativePtr->HostCursorPosY);
        public ref float HostCursorMaxPosX => ref Unsafe.AsRef<float>(&NativePtr->HostCursorMaxPosX);
        public ref ImRect HostInitialClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostInitialClipRect);
        public ref ImRect HostBackupClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupClipRect);
        public ref ImRect HostBackupParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupParentWorkRect);
        public ImPtrVector<ImGuiOldColumnDataPtr> Columns => new ImPtrVector<ImGuiOldColumnDataPtr>(NativePtr->Columns, Unsafe.SizeOf<ImGuiOldColumnData>());
        public ref ImDrawListSplitter Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->Splitter);
        public void Destroy()
        {
            ImGuiNative.ImGuiOldColumns_destroy((ImGuiOldColumns*)(NativePtr));
        }
    }
}
