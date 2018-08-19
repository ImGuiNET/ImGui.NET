using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImFontGlyph
    {
        public ushort Codepoint;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
    }
}
