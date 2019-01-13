using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDockFamily
    {
        public uint FamilyId;
        public byte CompatibleWithFamilyZero;
    }
    public unsafe partial struct ImGuiDockFamilyPtr
    {
        public ImGuiDockFamily* NativePtr { get; }
        public ImGuiDockFamilyPtr(ImGuiDockFamily* nativePtr) => NativePtr = nativePtr;
        public ImGuiDockFamilyPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockFamily*)nativePtr;
        public static implicit operator ImGuiDockFamilyPtr(ImGuiDockFamily* nativePtr) => new ImGuiDockFamilyPtr(nativePtr);
        public static implicit operator ImGuiDockFamily* (ImGuiDockFamilyPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDockFamilyPtr(IntPtr nativePtr) => new ImGuiDockFamilyPtr(nativePtr);
        public ref uint FamilyId => ref Unsafe.AsRef<uint>(&NativePtr->FamilyId);
        public ref bool CompatibleWithFamilyZero => ref Unsafe.AsRef<bool>(&NativePtr->CompatibleWithFamilyZero);
    }
}
