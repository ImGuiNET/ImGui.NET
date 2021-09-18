using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public struct ImGuiStyleMod
    {
        public ImGuiStyleVar VarIdx;
        public StyleModUnionValue Value;
    }

    public unsafe struct ImGuiStyleModPtr
    {
        public ImGuiStyleMod* NativePtr { get; }
        public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
        public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
        public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public static implicit operator ImGuiStyleMod*(ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
        
        public void Destroy()
        {
            ImGuiNative.ImGuiStyleMod_destroy((ImGuiStyleMod*)(NativePtr));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StyleModUnionValue
    {
        [FieldOffset(0)]
        public int BackupI32;
        [FieldOffset(0)]
        public float BackupF32;
    }
}
