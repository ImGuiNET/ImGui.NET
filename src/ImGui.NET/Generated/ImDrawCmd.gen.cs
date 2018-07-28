using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImDrawCmd
    {
        public uint ElemCount;
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
}
