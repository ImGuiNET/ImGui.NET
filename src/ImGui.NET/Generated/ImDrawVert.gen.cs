using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawVert
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;
    }
    public unsafe partial struct ImDrawVertPtr
    {
        public ImDrawVert* NativePtr { get; }
        public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
        public ImDrawVertPtr(IntPtr nativePtr) => NativePtr = (ImDrawVert*)nativePtr;
        public static implicit operator ImDrawVertPtr(ImDrawVert* nativePtr) => new ImDrawVertPtr(nativePtr);
        public static implicit operator ImDrawVert* (ImDrawVertPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawVertPtr(IntPtr nativePtr) => new ImDrawVertPtr(nativePtr);
        public ref Vector2 pos => ref Unsafe.AsRef<Vector2>(&NativePtr->pos);
        public ref Vector2 uv => ref Unsafe.AsRef<Vector2>(&NativePtr->uv);
        public ref uint col => ref Unsafe.AsRef<uint>(&NativePtr->col);
    }
}
