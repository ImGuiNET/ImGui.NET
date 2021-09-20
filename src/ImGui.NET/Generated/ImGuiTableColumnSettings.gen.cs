using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableColumnSettings
    {
        public float WidthOrWeight;
        public uint UserID;
        public sbyte Index;
        public sbyte DisplayOrder;
        public sbyte SortOrder;
        public byte SortDirection;
        public byte IsEnabled;
        public byte IsStretch;
    }
    public unsafe partial struct ImGuiTableColumnSettingsPtr
    {
        public ImGuiTableColumnSettings* NativePtr { get; }
        public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
        public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);
        public static implicit operator ImGuiTableColumnSettings* (ImGuiTableColumnSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);
        public ref float WidthOrWeight => ref Unsafe.AsRef<float>(&NativePtr->WidthOrWeight);
        public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);
        public ref sbyte Index => ref Unsafe.AsRef<sbyte>(&NativePtr->Index);
        public ref sbyte DisplayOrder => ref Unsafe.AsRef<sbyte>(&NativePtr->DisplayOrder);
        public ref sbyte SortOrder => ref Unsafe.AsRef<sbyte>(&NativePtr->SortOrder);
        public ref byte SortDirection => ref Unsafe.AsRef<byte>(&NativePtr->SortDirection);
        public ref byte IsEnabled => ref Unsafe.AsRef<byte>(&NativePtr->IsEnabled);
        public ref byte IsStretch => ref Unsafe.AsRef<byte>(&NativePtr->IsStretch);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableColumnSettings_destroy((ImGuiTableColumnSettings*)(NativePtr));
        }
    }
}
