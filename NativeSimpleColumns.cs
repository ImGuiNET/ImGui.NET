namespace ImGuiNET
{
    public unsafe struct NativeSimpleColumns
    {
        public int Count;
        public float Spacing;
        public float Width, NextWidth;
        public fixed float Pos[8], NextWidths[8];
    };
}
