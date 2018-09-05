using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImFontAtlas
    {
        public byte Locked;
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
    public unsafe struct ImFontAtlasPtr
    {
        public ImFontAtlas* NativePtr { get; }
        public ImFontAtlasPtr(ImFontAtlas* nativePtr) => NativePtr = nativePtr;
        public ref byte Locked => ref Unsafe.AsRef<byte>(&NativePtr->Locked);
        public ref ImFontAtlasFlags Flags => ref Unsafe.AsRef<ImFontAtlasFlags>(&NativePtr->Flags);
        public ref IntPtr TexID => ref Unsafe.AsRef<IntPtr>(&NativePtr->TexID);
        public ref int TexDesiredWidth => ref Unsafe.AsRef<int>(&NativePtr->TexDesiredWidth);
        public ref int TexGlyphPadding => ref Unsafe.AsRef<int>(&NativePtr->TexGlyphPadding);
        public byte* TexPixelsAlpha8 { get => NativePtr->TexPixelsAlpha8; set => NativePtr->TexPixelsAlpha8 = value; }
        public uint* TexPixelsRGBA32 { get => NativePtr->TexPixelsRGBA32; set => NativePtr->TexPixelsRGBA32 = value; }
        public ref int TexWidth => ref Unsafe.AsRef<int>(&NativePtr->TexWidth);
        public ref int TexHeight => ref Unsafe.AsRef<int>(&NativePtr->TexHeight);
        public ref Vector2 TexUvScale => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvScale);
        public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);
        public ref ImVector/*<ImFont*>*/ Fonts => ref Unsafe.AsRef<ImVector/*<ImFont*>*/>(&NativePtr->Fonts);
        public ref ImVector/*<CustomRect>*/ CustomRects => ref Unsafe.AsRef<ImVector/*<CustomRect>*/>(&NativePtr->CustomRects);
        public ref ImVector/*<ImFontConfig>*/ ConfigData => ref Unsafe.AsRef<ImVector/*<ImFontConfig>*/>(&NativePtr->ConfigData);
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels)
        {
            int compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
            byte* native_compressed_font_data_base85 = stackalloc byte[compressed_font_data_base85_byteCount + 1];
            fixed (char* compressed_font_data_base85_ptr = compressed_font_data_base85)
            {
                int native_compressed_font_data_base85_offset = Encoding.UTF8.GetBytes(compressed_font_data_base85_ptr, compressed_font_data_base85.Length, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ref ImFontConfig font_cfg)
        {
            int compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
            byte* native_compressed_font_data_base85 = stackalloc byte[compressed_font_data_base85_byteCount + 1];
            fixed (char* compressed_font_data_base85_ptr = compressed_font_data_base85)
            {
                int native_compressed_font_data_base85_offset = Encoding.UTF8.GetBytes(compressed_font_data_base85_ptr, compressed_font_data_base85.Length, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, native_font_cfg, glyph_ranges);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges)
        {
            int compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
            byte* native_compressed_font_data_base85 = stackalloc byte[compressed_font_data_base85_byteCount + 1];
            fixed (char* compressed_font_data_base85_ptr = compressed_font_data_base85)
            {
                int native_compressed_font_data_base85_offset = Encoding.UTF8.GetBytes(compressed_font_data_base85_ptr, compressed_font_data_base85.Length, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort native_glyph_ranges_val = glyph_ranges;
            ushort* native_glyph_ranges = &native_glyph_ranges_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, native_font_cfg, native_glyph_ranges);
            font_cfg = native_font_cfg_val;
            glyph_ranges = native_glyph_ranges_val;
            return new ImFontPtr(ret);
        }
        public bool Build()
        {
            byte ret = ImGuiNative.ImFontAtlas_Build(NativePtr);
            return ret != 0;
        }
        public ImFontPtr AddFont(ref ImFontConfig font_cfg)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFont(NativePtr, native_font_cfg);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public void CalcCustomRectUV(ref CustomRect rect, out Vector2 out_uv_min, out Vector2 out_uv_max)
        {
            CustomRect native_rect_val = rect;
            CustomRect* native_rect = &native_rect_val;
            Vector2 native_out_uv_min_val;
            Vector2* native_out_uv_min = &native_out_uv_min_val;
            Vector2 native_out_uv_max_val;
            Vector2* native_out_uv_max = &native_out_uv_max_val;
            ImGuiNative.ImFontAtlas_CalcCustomRectUV(NativePtr, native_rect, native_out_uv_min, native_out_uv_max);
            rect = native_rect_val;
            out_uv_min = native_out_uv_min_val;
            out_uv_max = native_out_uv_max_val;
        }
        public CustomRect* GetCustomRectByIndex(int index)
        {
            CustomRect* ret = ImGuiNative.ImFontAtlas_GetCustomRectByIndex(NativePtr, index);
            return ret;
        }
        public int AddCustomRectRegular(uint id, int width, int height)
        {
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectRegular(NativePtr, id, width, height);
            return ret;
        }
        public bool IsBuilt()
        {
            byte ret = ImGuiNative.ImFontAtlas_IsBuilt(NativePtr);
            return ret != 0;
        }
        public ushort* GetGlyphRangesThai()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesThai(NativePtr);
            return ret;
        }
        public ushort* GetGlyphRangesCyrillic()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesCyrillic(NativePtr);
            return ret;
        }
        public ushort* GetGlyphRangesChineseSimplifiedCommon()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(NativePtr);
            return ret;
        }
        public ushort* GetGlyphRangesChineseFull()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseFull(NativePtr);
            return ret;
        }
        public ushort* GetGlyphRangesDefault()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesDefault(NativePtr);
            return ret;
        }
        public void SetTexID(IntPtr id)
        {
            ImGuiNative.ImFontAtlas_SetTexID(NativePtr, id);
        }
        public void ClearTexData()
        {
            ImGuiNative.ImFontAtlas_ClearTexData(NativePtr);
        }
        public void ClearFonts()
        {
            ImGuiNative.ImFontAtlas_ClearFonts(NativePtr);
        }
        public void Clear()
        {
            ImGuiNative.ImFontAtlas_Clear(NativePtr);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(void* compressed_font_data, int compressed_font_size, float size_pixels)
        {
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, compressed_font_data, compressed_font_size, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(void* compressed_font_data, int compressed_font_size, float size_pixels, ref ImFontConfig font_cfg)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, compressed_font_data, compressed_font_size, size_pixels, native_font_cfg, glyph_ranges);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(void* compressed_font_data, int compressed_font_size, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort native_glyph_ranges_val = glyph_ranges;
            ushort* native_glyph_ranges = &native_glyph_ranges_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, compressed_font_data, compressed_font_size, size_pixels, native_font_cfg, native_glyph_ranges);
            font_cfg = native_font_cfg_val;
            glyph_ranges = native_glyph_ranges_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(void* font_data, int font_size, float size_pixels)
        {
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, font_data, font_size, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(void* font_data, int font_size, float size_pixels, ref ImFontConfig font_cfg)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, font_data, font_size, size_pixels, native_font_cfg, glyph_ranges);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(void* font_data, int font_size, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort native_glyph_ranges_val = glyph_ranges;
            ushort* native_glyph_ranges = &native_glyph_ranges_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, font_data, font_size, size_pixels, native_font_cfg, native_glyph_ranges);
            font_cfg = native_font_cfg_val;
            glyph_ranges = native_glyph_ranges_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels)
        {
            int filename_byteCount = Encoding.UTF8.GetByteCount(filename);
            byte* native_filename = stackalloc byte[filename_byteCount + 1];
            fixed (char* filename_ptr = filename)
            {
                int native_filename_offset = Encoding.UTF8.GetBytes(filename_ptr, filename.Length, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ref ImFontConfig font_cfg)
        {
            int filename_byteCount = Encoding.UTF8.GetByteCount(filename);
            byte* native_filename = stackalloc byte[filename_byteCount + 1];
            fixed (char* filename_ptr = filename)
            {
                int native_filename_offset = Encoding.UTF8.GetBytes(filename_ptr, filename.Length, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, native_font_cfg, glyph_ranges);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges)
        {
            int filename_byteCount = Encoding.UTF8.GetByteCount(filename);
            byte* native_filename = stackalloc byte[filename_byteCount + 1];
            fixed (char* filename_ptr = filename)
            {
                int native_filename_offset = Encoding.UTF8.GetBytes(filename_ptr, filename.Length, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ushort native_glyph_ranges_val = glyph_ranges;
            ushort* native_glyph_ranges = &native_glyph_ranges_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, native_font_cfg, native_glyph_ranges);
            font_cfg = native_font_cfg_val;
            glyph_ranges = native_glyph_ranges_val;
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontDefault()
        {
            ImFontConfig* font_cfg = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, font_cfg);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontDefault(ref ImFontConfig font_cfg)
        {
            ImFontConfig native_font_cfg_val = font_cfg;
            ImFontConfig* native_font_cfg = &native_font_cfg_val;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, native_font_cfg);
            font_cfg = native_font_cfg_val;
            return new ImFontPtr(ret);
        }
        public ushort* GetGlyphRangesJapanese()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesJapanese(NativePtr);
            return ret;
        }
        public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height)
        {
            byte* native_out_pixels_val;
            byte** native_out_pixels = &native_out_pixels_val;
            int native_out_width_val;
            int* native_out_width = &native_out_width_val;
            int native_out_height_val;
            int* native_out_height = &native_out_height_val;
            int* out_bytes_per_pixel = null;
            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
            out_pixels = native_out_pixels_val;
            out_width = native_out_width_val;
            out_height = native_out_height_val;
        }
        public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            byte* native_out_pixels_val;
            byte** native_out_pixels = &native_out_pixels_val;
            int native_out_width_val;
            int* native_out_width = &native_out_width_val;
            int native_out_height_val;
            int* native_out_height = &native_out_height_val;
            int native_out_bytes_per_pixel_val;
            int* native_out_bytes_per_pixel = &native_out_bytes_per_pixel_val;
            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
            out_pixels = native_out_pixels_val;
            out_width = native_out_width_val;
            out_height = native_out_height_val;
            out_bytes_per_pixel = native_out_bytes_per_pixel_val;
        }
        public void ClearInputData()
        {
            ImGuiNative.ImFontAtlas_ClearInputData(NativePtr);
        }
        public bool GetMouseCursorTexData(ImGuiMouseCursor cursor, out Vector2 out_offset, out Vector2 out_size, Vector2* out_uv_border, Vector2* out_uv_fill)
        {
            Vector2 native_out_offset_val;
            Vector2* native_out_offset = &native_out_offset_val;
            Vector2 native_out_size_val;
            Vector2* native_out_size = &native_out_size_val;
            byte ret = ImGuiNative.ImFontAtlas_GetMouseCursorTexData(NativePtr, cursor, native_out_offset, native_out_size, out_uv_border, out_uv_fill);
            out_offset = native_out_offset_val;
            out_size = native_out_size_val;
            return ret != 0;
        }
        public ushort* GetGlyphRangesKorean()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesKorean(NativePtr);
            return ret;
        }
        public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height)
        {
            byte* native_out_pixels_val;
            byte** native_out_pixels = &native_out_pixels_val;
            int native_out_width_val;
            int* native_out_width = &native_out_width_val;
            int native_out_height_val;
            int* native_out_height = &native_out_height_val;
            int* out_bytes_per_pixel = null;
            ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
            out_pixels = native_out_pixels_val;
            out_width = native_out_width_val;
            out_height = native_out_height_val;
        }
        public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            byte* native_out_pixels_val;
            byte** native_out_pixels = &native_out_pixels_val;
            int native_out_width_val;
            int* native_out_width = &native_out_width_val;
            int native_out_height_val;
            int* native_out_height = &native_out_height_val;
            int native_out_bytes_per_pixel_val;
            int* native_out_bytes_per_pixel = &native_out_bytes_per_pixel_val;
            ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
            out_pixels = native_out_pixels_val;
            out_width = native_out_width_val;
            out_height = native_out_height_val;
            out_bytes_per_pixel = native_out_bytes_per_pixel_val;
        }
        public int AddCustomRectFontGlyph(ref ImFont font, ushort id, int width, int height, float advance_x)
        {
            ImFont native_font_val = font;
            ImFont* native_font = &native_font_val;
            Vector2 offset = new Vector2();
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, native_font, id, width, height, advance_x, offset);
            font = native_font_val;
            return ret;
        }
        public int AddCustomRectFontGlyph(ref ImFont font, ushort id, int width, int height, float advance_x, Vector2 offset)
        {
            ImFont native_font_val = font;
            ImFont* native_font = &native_font_val;
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, native_font, id, width, height, advance_x, offset);
            font = native_font_val;
            return ret;
        }
        public void ImFontAtlas()
        {
            ImGuiNative.ImFontAtlas_ImFontAtlas(NativePtr);
        }
    }
}
