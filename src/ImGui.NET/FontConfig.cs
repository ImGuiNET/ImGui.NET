using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FontConfig
    {
        /// <summary>
        /// TTF data
        /// </summary>
        public IntPtr FontData;
        /// <summary>
        /// TTF data size
        /// </summary>
        public int FontDataSize;
        /// <summary>
        /// TTF data ownership taken by the container ImFontAtlas (will delete memory itself).
        /// Set to true.
        /// </summary>
        public byte FontDataOwnedByAtlas;
        /// <summary>
        /// 0.
        /// Index of font within TTF file
        /// </summary>
        public int FontNo;
        /// <summary>
        /// Size in pixels for rasterizer.
        /// </summary>
        public float SizePixels;
        /// <summary>
        /// Rasterize at higher quality for sub-pixel positioning. We don't use sub-pixel positions on the Y axis.
        /// Set to 3.
        /// </summary>
        public int OversampleH;
        /// <summary>
        /// Rasterize at higher quality for sub-pixel positioning. We don't use sub-pixel positions on the Y axis.
        /// Set to 1.
        /// </summary>
        public int OversampleV;
        /// <summary>
        /// Align every character to pixel boundary (if enabled, set OversampleH/V to 1).
        /// Set to false.
        /// </summary>
        public byte PixelSnapH;
        /// <summary>
        /// Extra spacing (in pixels) between glyphs.
        /// Set to (0, 0).
        /// </summary>
        public Vector2 GlyphExtraSpacing;
        /// <summary>
        /// Offset all glyphs from this font input.
        /// Set to (0, 0).
        /// </summary>
        public Vector2 GlyphOffset;
        /// <summary>
        /// List of Unicode range (2 value per range, values are inclusive, zero-terminated list).
        /// </summary>
        public char* GlyphRanges;
        /// <summary>
        /// Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs).
        /// Set to false.
        /// </summary>
        public byte MergeMode;
        /// <summary>
        /// Settings for custom font rasterizer (e.g. ImGuiFreeType). Leave as zero if you aren't using one.
        /// Defaults to 0.
        /// </summary>
        public uint RasterizerFlags;
        /// <summary>
        /// Brighten (&gt;1.0f) or darken (&lt;1.0f) font output. Brightening small fonts may be a good workaround to make them more readable.
        /// Defaults to 1.0.
        /// </summary>
        public float RasterizerMultiply;

        // [Internal]
        /// <summary>
        /// [Internal Use Only] Name (strictly for debugging)
        /// </summary>
        public fixed char Name[32];
        /// <summary>
        /// [Internal Use Only]
        /// </summary>
        public IntPtr DstFont;
    };
}
