using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiColorMod
    {
        public ImGuiCol Col;
        public Vector4 BackupValue;
    }
    public unsafe partial struct ImGuiColorModPtr
    {
        public ImGuiColorMod* NativePtr { get; }
        public ImGuiColorModPtr(ImGuiColorMod* nativePtr) => NativePtr = nativePtr;
        public ImGuiColorModPtr(IntPtr nativePtr) => NativePtr = (ImGuiColorMod*)nativePtr;
        public static implicit operator ImGuiColorModPtr(ImGuiColorMod* nativePtr) => new ImGuiColorModPtr(nativePtr);
        public static implicit operator ImGuiColorMod* (ImGuiColorModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiColorModPtr(IntPtr nativePtr) => new ImGuiColorModPtr(nativePtr);
        public ref ImGuiCol Col => ref Unsafe.AsRef<ImGuiCol>(&NativePtr->Col);
        public ref Vector4 BackupValue => ref Unsafe.AsRef<Vector4>(&NativePtr->BackupValue);
    }
}
