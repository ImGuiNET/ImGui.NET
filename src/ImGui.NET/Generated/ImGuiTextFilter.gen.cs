using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImGuiTextFilter
    {
        public fixed byte InputBuf[256];
        public ImVector/*<TextRange>*/ Filters;
        public int CountGrep;
    }
}
