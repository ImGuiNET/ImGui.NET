using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImGuiListClipper
    {
        public float StartPosY;
        public float ItemsHeight;
        public int ItemsCount;
        public int StepNo;
        public int DisplayStart;
        public int DisplayEnd;
    }
}
