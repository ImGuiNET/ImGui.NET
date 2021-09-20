using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableTempData
    {
        public int TableIndex;
        public float LastTimeActive;
        public Vector2 UserOuterSize;
        public ImDrawListSplitter DrawSplitter;
        public ImRect HostBackupWorkRect;
        public ImRect HostBackupParentWorkRect;
        public Vector2 HostBackupPrevLineSize;
        public Vector2 HostBackupCurrLineSize;
        public Vector2 HostBackupCursorMaxPos;
        public ImVec1 HostBackupColumnsOffset;
        public float HostBackupItemWidth;
        public int HostBackupItemWidthStackSize;
    }
    public unsafe partial struct ImGuiTableTempDataPtr
    {
        public ImGuiTableTempData* NativePtr { get; }
        public ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableTempData*)nativePtr;
        public static implicit operator ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => new ImGuiTableTempDataPtr(nativePtr);
        public static implicit operator ImGuiTableTempData* (ImGuiTableTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableTempDataPtr(IntPtr nativePtr) => new ImGuiTableTempDataPtr(nativePtr);
        public ref int TableIndex => ref Unsafe.AsRef<int>(&NativePtr->TableIndex);
        public ref float LastTimeActive => ref Unsafe.AsRef<float>(&NativePtr->LastTimeActive);
        public ref Vector2 UserOuterSize => ref Unsafe.AsRef<Vector2>(&NativePtr->UserOuterSize);
        public ref ImDrawListSplitter DrawSplitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->DrawSplitter);
        public ref ImRect HostBackupWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupWorkRect);
        public ref ImRect HostBackupParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupParentWorkRect);
        public ref Vector2 HostBackupPrevLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupPrevLineSize);
        public ref Vector2 HostBackupCurrLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCurrLineSize);
        public ref Vector2 HostBackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCursorMaxPos);
        public ref ImVec1 HostBackupColumnsOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->HostBackupColumnsOffset);
        public ref float HostBackupItemWidth => ref Unsafe.AsRef<float>(&NativePtr->HostBackupItemWidth);
        public ref int HostBackupItemWidthStackSize => ref Unsafe.AsRef<int>(&NativePtr->HostBackupItemWidthStackSize);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableTempData_destroy((ImGuiTableTempData*)(NativePtr));
        }
    }
}
