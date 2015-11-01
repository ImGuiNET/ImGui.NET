using System.Runtime.InteropServices;
using ImVec2 = System.Numerics.Vector2;
using ImWchar = System.UInt16;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct ImFontConfig
    {
        public void* FontData;                   //          // TTF data
        public int FontDataSize;               //          // TTF data size
        public bool FontDataOwnedByAtlas;       // true     // TTF data ownership taken by the container ImFontAtlas (will delete memory itself). Set to true
        public int FontNo;                     // 0        // Index of font within TTF file
        public float SizePixels;                 //          // Size in pixels for rasterizer
        public int OversampleH, OversampleV;   // 3, 1     // Rasterize at higher quality for sub-pixel positioning. We don't use sub-pixel positions on the Y axis.
        public bool PixelSnapH;                 // false    // Align every character to pixel boundary (if enabled, set OversampleH/V to 1)
        public ImVec2 GlyphExtraSpacing;          // 0, 0     // Extra spacing (in pixels) between glyphs
        public ImWchar* GlyphRanges;                //          // List of Unicode range (2 value per range, values are inclusive, zero-terminated list)
        public bool MergeMode;                  // false    // Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs).
        public bool MergeGlyphCenterV;          // false    // When merging (multiple ImFontInput for one ImFont), vertically center new glyphs instead of aligning their baseline

        // [Internal]
        public fixed char Name[32];                               // Name (strictly for debugging)
        public ImFont* DstFont;
    };
}
