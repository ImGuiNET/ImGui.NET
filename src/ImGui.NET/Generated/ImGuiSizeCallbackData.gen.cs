using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImGuiSizeCallbackData
    {
        public void* UserData;
        public Vector2 Pos;
        public Vector2 CurrentSize;
        public Vector2 DesiredSize;
    }
}
