using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImDrawVert
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;
    }
    public unsafe struct ImDrawVertPtr
    {
        public ImDrawVert* NativePtr { get; }
        public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
        public ref Vector2 pos => ref Unsafe.AsRef<Vector2>(&NativePtr->pos);
        public ref Vector2 uv => ref Unsafe.AsRef<Vector2>(&NativePtr->uv);
        public ref uint col => ref Unsafe.AsRef<uint>(&NativePtr->col);
    }
}
