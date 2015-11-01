using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ImGui
{
    // Font runtime data and rendering
    // ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImFont
    {
        // Members: Settings
        public float FontSize;           // <user set>      // Height of characters, set during loading (don't change after loading)
        public float Scale;              // = 1.0f          // Base font scale, multiplied by the per-window font scale which you can adjust with SetFontScale()
        public Vector2 DisplayOffset;      // = (0.0f,1.0f)   // Offset font rendering by xx pixels
        public ushort FallbackChar;       // = '?'           // Replacement glyph if one isn't found. Only set via SetFallbackChar()

        /// <summary>
        /// ImFontConfig*
        /// </summary>
        public IntPtr ConfigData;         //                 // Pointer within ImFontAtlas->ConfigData
        public int ConfigDataCount;    //

        // Members: Runtime data
        [StructLayout(LayoutKind.Sequential)]
        public struct Glyph
        {
            ushort Codepoint;
            float XAdvance;
            float X0, Y0, X1, Y1;
            float U0, V0, U1, V1;     // Texture coordinates
        };

        public float Ascent, Descent;    // Ascent: distance from top to bottom of e.g. 'A' [0..FontSize]

        /// <summary>
        /// ImFontAtlas*
        /// </summary>
        public IntPtr ContainerAtlas;     // What we has been loaded into

        /// <summary>
        /// ImVector(Glyph)
        /// </summary>
        public ImVector Glyphs;

        public Glyph* FallbackGlyph;      // == FindGlyph(FontFallbackChar)
        public float FallbackXAdvance;   //

        //ImVector<float> IndexXAdvance;      // Sparse. Glyphs->XAdvance directly indexable (more cache-friendly that reading from Glyphs, for CalcTextSize functions which are often bottleneck in large UI)
        //ImVector<int> IndexLookup;        // Sparse. Index glyphs by Unicode code-point.

        public ImVector IndexXAdvance;      // Sparse. Glyphs->XAdvance directly indexable (more cache-friendly that reading from Glyphs, for CalcTextSize functions which are often bottleneck in large UI)
        public ImVector IndexLookup;        // Sparse. Index glyphs by Unicode code-point.

        // Methods
        /*
        IMGUI_API ImFont();
        IMGUI_API ~ImFont();
        IMGUI_API void Clear();
        IMGUI_API void BuildLookupTable();
        IMGUI_API const Glyph* FindGlyph(unsigned short c) const;
        IMGUI_API void SetFallbackChar(ImWchar c);
        float GetCharAdvance(unsigned short c) const  { return ((int)c<IndexXAdvance.Size) ? IndexXAdvance[(int)c] : FallbackXAdvance; }
        bool IsLoaded() const                        { return ContainerAtlas != NULL; }

        // 'max_width' stops rendering after a certain width (could be turned into a 2d size). FLT_MAX to disable.
        // 'wrap_width' enable automatic word-wrapping across multiple lines to fit into given width. 0.0f to disable.
        IMGUI_API ImVec2            CalcTextSizeA(float size, float max_width, float wrap_width, const char* text_begin, const char* text_end = NULL, const char** remaining = NULL) const; // utf8
        IMGUI_API const char* CalcWordWrapPositionA(float scale, const char* text, const char* text_end, float wrap_width) const;
        IMGUI_API void RenderText(float size, ImVec2 pos, ImU32 col, const ImVec4& clip_rect, const char* text_begin, const char* text_end, ImDrawList* draw_list, float wrap_width = 0.0f, bool cpu_fine_clip = false) const;
        */

    };
}
