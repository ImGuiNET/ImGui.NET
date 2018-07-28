using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImDrawChannel
    {
        public ImVector/*<ImDrawCmd>*/ CmdBuffer;
        public ImVector/*<ImDrawIdx>*/ IdxBuffer;
    }
}
