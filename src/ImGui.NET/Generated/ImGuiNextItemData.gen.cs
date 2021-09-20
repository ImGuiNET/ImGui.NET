using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiNextItemData
    {
        public ImGuiNextItemDataFlags Flags;
        public float Width;
        public uint FocusScopeId;
        public ImGuiCond OpenCond;
        public byte OpenVal;
    }
    public unsafe partial struct ImGuiNextItemDataPtr
    {
        public ImGuiNextItemData* NativePtr { get; }
        public ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => NativePtr = nativePtr;
        public ImGuiNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextItemData*)nativePtr;
        public static implicit operator ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => new ImGuiNextItemDataPtr(nativePtr);
        public static implicit operator ImGuiNextItemData* (ImGuiNextItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiNextItemDataPtr(IntPtr nativePtr) => new ImGuiNextItemDataPtr(nativePtr);
        public ref ImGuiNextItemDataFlags Flags => ref Unsafe.AsRef<ImGuiNextItemDataFlags>(&NativePtr->Flags);
        public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
        public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
        public ref ImGuiCond OpenCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->OpenCond);
        public ref bool OpenVal => ref Unsafe.AsRef<bool>(&NativePtr->OpenVal);
        public void ClearFlags()
        {
            ImGuiNative.ImGuiNextItemData_ClearFlags((ImGuiNextItemData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiNextItemData_destroy((ImGuiNextItemData*)(NativePtr));
        }
    }
}
