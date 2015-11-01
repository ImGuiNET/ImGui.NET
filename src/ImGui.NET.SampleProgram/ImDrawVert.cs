using ImVec2 = System.Numerics.Vector2;
using System.Runtime.InteropServices;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct ImDrawVert
    {
        public ImVec2 pos;
        public ImVec2 uv;
        public uint col;

        public const int PosOffset = 0;
        public const int UVOffset = 8;
        public const int ColOffset = 16;
    };
}
