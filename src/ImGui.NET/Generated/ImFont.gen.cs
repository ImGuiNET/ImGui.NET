using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImFont
    {
        public float FontSize;
        public float Scale;
        public Vector2 DisplayOffset;
        public ImVector/*<ImFontGlyph>*/ Glyphs;
        public ImVector/*<float>*/ IndexAdvanceX;
        public ImVector/*<unsigned short>*/ IndexLookup;
        public ImFontGlyph* FallbackGlyph;
        public float FallbackAdvanceX;
        public char FallbackChar;
        public short ConfigDataCount;
        public ImFontConfig* ConfigData;
        public ImFontAtlas* ContainerAtlas;
        public float Ascent;
        public float Descent;
        public byte DirtyLookupTables;
        public int MetricsTotalSurface;
    }
}
