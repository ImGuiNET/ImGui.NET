using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImVec2ih
    {
        public short x;
        public short y;
    }
    public unsafe partial struct ImVec2ihPtr
    {
        public ImVec2ih* NativePtr { get; }
        public ImVec2ihPtr(ImVec2ih* nativePtr) => NativePtr = nativePtr;
        public ImVec2ihPtr(IntPtr nativePtr) => NativePtr = (ImVec2ih*)nativePtr;
        public static implicit operator ImVec2ihPtr(ImVec2ih* nativePtr) => new ImVec2ihPtr(nativePtr);
        public static implicit operator ImVec2ih* (ImVec2ihPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImVec2ihPtr(IntPtr nativePtr) => new ImVec2ihPtr(nativePtr);
        public ref short x => ref Unsafe.AsRef<short>(&NativePtr->x);
        public ref short y => ref Unsafe.AsRef<short>(&NativePtr->y);
        public void Destroy()
        {
            ImGuiNative.ImVec2ih_destroy((ImVec2ih*)(NativePtr));
        }
    }
}
