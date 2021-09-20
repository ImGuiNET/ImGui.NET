using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableSettings
    {
        public uint ID;
        public ImGuiTableFlags SaveFlags;
        public float RefScale;
        public sbyte ColumnsCount;
        public sbyte ColumnsCountMax;
        public byte WantApply;
    }
    public unsafe partial struct ImGuiTableSettingsPtr
    {
        public ImGuiTableSettings* NativePtr { get; }
        public ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSettings*)nativePtr;
        public static implicit operator ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => new ImGuiTableSettingsPtr(nativePtr);
        public static implicit operator ImGuiTableSettings* (ImGuiTableSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableSettingsPtr(IntPtr nativePtr) => new ImGuiTableSettingsPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiTableFlags SaveFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SaveFlags);
        public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);
        public ref sbyte ColumnsCount => ref Unsafe.AsRef<sbyte>(&NativePtr->ColumnsCount);
        public ref sbyte ColumnsCountMax => ref Unsafe.AsRef<sbyte>(&NativePtr->ColumnsCountMax);
        public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableSettings_destroy((ImGuiTableSettings*)(NativePtr));
        }
        public ImGuiTableColumnSettingsPtr GetColumnSettings()
        {
            ImGuiTableColumnSettings* ret = ImGuiNative.ImGuiTableSettings_GetColumnSettings((ImGuiTableSettings*)(NativePtr));
            return new ImGuiTableColumnSettingsPtr(ret);
        }
    }
}
