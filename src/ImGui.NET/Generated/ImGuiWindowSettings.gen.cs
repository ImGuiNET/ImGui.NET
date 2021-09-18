using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiWindowSettings
    {
        public uint ID;
        public ImVec2ih Pos;
        public ImVec2ih Size;
        public ImVec2ih ViewportPos;
        public uint ViewportId;
        public uint DockId;
        public uint ClassId;
        public short DockOrder;
        public byte Collapsed;
        public byte WantApply;
    }
    public unsafe partial struct ImGuiWindowSettingsPtr
    {
        public ImGuiWindowSettings* NativePtr { get; }
        public ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => NativePtr = nativePtr;
        public ImGuiWindowSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowSettings*)nativePtr;
        public static implicit operator ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => new ImGuiWindowSettingsPtr(nativePtr);
        public static implicit operator ImGuiWindowSettings* (ImGuiWindowSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiWindowSettingsPtr(IntPtr nativePtr) => new ImGuiWindowSettingsPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImVec2ih Pos => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->Pos);
        public ref ImVec2ih Size => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->Size);
        public ref ImVec2ih ViewportPos => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->ViewportPos);
        public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);
        public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);
        public ref uint ClassId => ref Unsafe.AsRef<uint>(&NativePtr->ClassId);
        public ref short DockOrder => ref Unsafe.AsRef<short>(&NativePtr->DockOrder);
        public ref bool Collapsed => ref Unsafe.AsRef<bool>(&NativePtr->Collapsed);
        public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);
        public void Destroy()
        {
            ImGuiNative.ImGuiWindowSettings_destroy((ImGuiWindowSettings*)(NativePtr));
        }
        public string GetName()
        {
            byte* ret = ImGuiNative.ImGuiWindowSettings_GetName((ImGuiWindowSettings*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
    }
}
