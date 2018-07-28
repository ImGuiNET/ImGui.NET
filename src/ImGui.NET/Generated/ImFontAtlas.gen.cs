using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImFontAtlas
    {
        public ImFontAtlasFlags Flags;
        public IntPtr TexID;
        public int TexDesiredWidth;
        public int TexGlyphPadding;
        public byte* TexPixelsAlpha8;
        public uint* TexPixelsRGBA32;
        public int TexWidth;
        public int TexHeight;
        public Vector2 TexUvScale;
        public Vector2 TexUvWhitePixel;
        public ImVector/*<ImFont*>*/ Fonts;
        public ImVector/*<CustomRect>*/ CustomRects;
        public ImVector/*<ImFontConfig>*/ ConfigData;
        public fixed int CustomRectIds[1];
    }
}
