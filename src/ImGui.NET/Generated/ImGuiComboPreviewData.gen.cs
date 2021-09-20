using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiComboPreviewData
    {
        public ImRect PreviewRect;
        public Vector2 BackupCursorPos;
        public Vector2 BackupCursorMaxPos;
        public Vector2 BackupCursorPosPrevLine;
        public float BackupPrevLineTextBaseOffset;
        public ImGuiLayoutType BackupLayout;
    }
    public unsafe partial struct ImGuiComboPreviewDataPtr
    {
        public ImGuiComboPreviewData* NativePtr { get; }
        public ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => NativePtr = nativePtr;
        public ImGuiComboPreviewDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiComboPreviewData*)nativePtr;
        public static implicit operator ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => new ImGuiComboPreviewDataPtr(nativePtr);
        public static implicit operator ImGuiComboPreviewData* (ImGuiComboPreviewDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiComboPreviewDataPtr(IntPtr nativePtr) => new ImGuiComboPreviewDataPtr(nativePtr);
        public ref ImRect PreviewRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PreviewRect);
        public ref Vector2 BackupCursorPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorPos);
        public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorMaxPos);
        public ref Vector2 BackupCursorPosPrevLine => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorPosPrevLine);
        public ref float BackupPrevLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->BackupPrevLineTextBaseOffset);
        public ref ImGuiLayoutType BackupLayout => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->BackupLayout);
        public void Destroy()
        {
            ImGuiNative.ImGuiComboPreviewData_destroy((ImGuiComboPreviewData*)(NativePtr));
        }
    }
}
