using System.Runtime.InteropServices;
using System;
using System.Numerics;

namespace ImGui
{
    // Load and rasterize multiple TTF fonts into a same texture.
    // Sharing a texture for multiple fonts allows us to reduce the number of draw calls during rendering.
    // We also add custom graphic data into the texture that serves for ImGui.
    //  1. (Optional) Call AddFont*** functions. If you don't call any, the default font will be loaded for you.
    //  2. Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.
    //  3. Upload the pixels data into a texture within your graphics system.
    //  4. Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture. This value will be passed back to you during rendering to identify the texture.
    //  5. Call ClearTexData() to free textures memory on the heap.
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FontAtlas
    {
        /*
        public ImFont* AddFont(ImFontConfig* font_cfg) { }
        public ImFont* AddFontDefault(ImFontConfig* font_cfg = null) { }
        public ImFont* AddFontFromFileTTF(char* filename, float size_pixels, ImFontConfig* font_cfg = null, ImWchar* glyph_ranges = null) { }
        public ImFont* AddFontFromMemoryTTF(void* ttf_data, int ttf_size, float size_pixels, ImFontConfig* font_cfg = null, ImWchar* glyph_ranges = null);                                        // Transfer ownership of 'ttf_data' to ImFontAtlas, will be deleted after Build()
        public ImFont* AddFontFromMemoryCompressedTTF(void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, ImFontConfig* font_cfg = null, ImWchar* glyph_ranges = null);  // 'compressed_ttf_data' still owned by caller. Compress with binary_to_compressed_c.cpp
        public ImFont* AddFontFromMemoryCompressedBase85TTF(char* compressed_ttf_data_base85, float size_pixels, ImFontConfig* font_cfg = null, ImWchar* glyph_ranges = null);              // 'compressed_ttf_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 paramaeter
        public void ClearTexData();             // Clear the CPU-side texture data. Saves RAM once the texture has been copied to graphics memory.
        public void ClearInputData();           // Clear the input TTF data (inc sizes, glyph ranges)
        public void ClearFonts();               // Clear the ImGui-side font data (glyphs storage, UV coordinates)
        public void Clear() { }                    // Clear all

        // Retrieve texture data
        // User is in charge of copying the pixels into graphics memory, then call SetTextureUserID()
        // After loading the texture into your graphic system, store your texture handle in 'TexID' (ignore if you aren't using multiple fonts nor images)
        // RGBA32 format is provided for convenience and high compatibility, but note that all RGB pixels are white, so 75% of the memory is wasted.
        // Pitch = Width * BytesPerPixels
        public void GetTexDataAsAlpha8(unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel = null);  // 1 byte per-pixel
        public void GetTexDataAsRGBA32(unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel = null);  // 4 bytes-per-pixel
        void SetTexID(void* id) { TexID = id; }

        // Helpers to retrieve list of common Unicode ranges (2 value per range, values are inclusive, zero-terminated list)
        // (Those functions could be static but aren't so most users don't have to refer to the ImFontAtlas:: name ever if in their code; just using io.Fonts->)
        public ImWchar* GetGlyphRangesDefault();    // Basic Latin, Extended Latin
        public ImWchar* GetGlyphRangesKorean();     // Default + Korean characters
        public ImWchar* GetGlyphRangesJapanese();   // Default + Hiragana, Katakana, Half-Width, Selection of 1946 Ideographs
        public ImWchar* GetGlyphRangesChinese();    // Japanese + full set of about 21000 CJK Unified Ideographs
        public ImWchar* GetGlyphRangesCyrillic();   // Default + about 400 Cyrillic characters
        */

        // Members
        // (Access texture data via GetTexData*() calls which will setup a default font for you.)
        public void* TexID;              // User data to refer to the texture once it has been uploaded to user's graphic systems. It ia passed back to you during rendering.
        public byte* TexPixelsAlpha8;    // 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight
        public UIntPtr TexPixelsRGBA32;    // 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4
        public IntPtr TexWidth;           // Texture width calculated during Build().
        public IntPtr TexHeight;          // Texture height calculated during Build().
        public IntPtr TexDesiredWidth;    // Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.
        public Vector2 TexUvWhitePixel;    // Texture coordinates to a white pixel (part of the TexExtraData block)

        /// <summary>
        /// (ImVector(ImFont*)
        /// </summary>
        public ImVector Fonts;

        // Private
        /// <summary>
        /// ImVector(ImFontConfig)
        /// </summary>
        public ImVector ConfigData;         // Internal data
        /*
        public bool Build();            // Build pixels data. This is automatically for you by the GetTexData*** functions.
        */
    }
}
