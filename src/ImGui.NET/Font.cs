using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe class Font
    {
        public Font(NativeFont* nativePtr)
        {
            NativeFont = nativePtr;
        }

        public NativeFont* NativeFont { get; }
    }

    /// <summary>
    /// Font runtime data and rendering.
    /// ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeFont
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Glyph
        {
            public ushort Codepoint;
            public float XAdvance;
            public float X0, Y0, X1, Y1;
            public float U0, V0, U1, V1;     // Texture coordinates
        };

        // Members: Hot ~62/78 bytes
        /// <summary>
        /// Height of characters, set during loading (don't change after loading).
        /// Default value: [user-set]
        /// </summary>
        public float FontSize;
        /// <summary>
        /// Base font scale, multiplied by the per-window font scale which you can adjust with SetFontScale()
        /// Default value: 1.0f.
        /// </summary>
        public float Scale;
        /// <summary>
        /// Offset font rendering by xx pixels.
        /// Default value: (0.0f, 1.0f)
        /// </summary>
        public Vector2 DisplayOffset;
        /// <summary>
        /// ImVector(Glyph)
        /// </summary>
        public ImVector Glyphs;

        /// <summary>
        /// Sparse. Glyphs->XAdvance directly indexable (more cache-friendly that reading from Glyphs,
        /// for CalcTextSize functions which are often bottleneck in large UI).
        /// </summary>
        public ImVector IndexXAdvance;

        /// <summary>
        /// Sparse. Index glyphs by Unicode code-point.
        /// </summary>
        public ImVector IndexLookup;

        /// <summary>
        /// Equivalent to FindGlyph(FontFallbackChar)
        /// </summary>
        public Glyph* FallbackGlyph;
        public float FallbackXAdvance;

        /// <summary>
        /// Replacement glyph if one isn't found. Only set via SetFallbackChar()
        /// Default value: '?'
        /// </summary>
        public ushort FallbackChar;

        // Members: Cold ~18/26 bytes
        public int ConfigDataCount;

        /// <summary>
        /// ImFontConfig*. Pointer within ImFontAtlas->ConfigData
        /// </summary>
        public IntPtr ConfigData;

        /// <summary>
        /// ImFontAtlas*
        /// </summary>
        public IntPtr ContainerAtlas;     // What we has been loaded into

        /// <summary>
        /// Ascent: distance from top to bottom of e.g. 'A' [0..FontSize]
        /// </summary>
        public float Ascent, Descent;
    };
}
