using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlas
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
        public ImVector Fonts;
        public ImVector CustomRects;
        public ImVector ConfigData;
        public fixed int CustomRectIds[1];
    }
    public unsafe partial struct ImFontAtlasPtr
    {
        public ImFontAtlas* NativePtr { get; }
        public ImFontAtlasPtr(ImFontAtlas* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlas*)nativePtr;
        public static implicit operator ImFontAtlasPtr(ImFontAtlas* nativePtr) => new ImFontAtlasPtr(nativePtr);
        public static implicit operator ImFontAtlas* (ImFontAtlasPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasPtr(IntPtr nativePtr) => new ImFontAtlasPtr(nativePtr);
        public ref bool Locked => ref Unsafe.AsRef<bool>(&NativePtr->Locked);
        public ref ImFontAtlasFlags Flags => ref Unsafe.AsRef<ImFontAtlasFlags>(&NativePtr->Flags);
        public ref IntPtr TexID => ref Unsafe.AsRef<IntPtr>(&NativePtr->TexID);
        public ref int TexDesiredWidth => ref Unsafe.AsRef<int>(&NativePtr->TexDesiredWidth);
        public ref int TexGlyphPadding => ref Unsafe.AsRef<int>(&NativePtr->TexGlyphPadding);
        public IntPtr TexPixelsAlpha8 { get => (IntPtr)NativePtr->TexPixelsAlpha8; set => NativePtr->TexPixelsAlpha8 = (byte*)value; }
        public IntPtr TexPixelsRGBA32 { get => (IntPtr)NativePtr->TexPixelsRGBA32; set => NativePtr->TexPixelsRGBA32 = (uint*)value; }
        public ref int TexWidth => ref Unsafe.AsRef<int>(&NativePtr->TexWidth);
        public ref int TexHeight => ref Unsafe.AsRef<int>(&NativePtr->TexHeight);
        public ref Vector2 TexUvScale => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvScale);
        public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);
        public ImVector<ImFontPtr> Fonts => new ImVector<ImFontPtr>(NativePtr->Fonts);
        public ImPtrVector<ImFontAtlasCustomRectPtr> CustomRects => new ImPtrVector<ImFontAtlasCustomRectPtr>(NativePtr->CustomRects, Unsafe.SizeOf<ImFontAtlasCustomRect>());
        public ImPtrVector<ImFontConfigPtr> ConfigData => new ImPtrVector<ImFontConfigPtr>(NativePtr->ConfigData, Unsafe.SizeOf<ImFontConfig>());
        public RangeAccessor<int> CustomRectIds => new RangeAccessor<int>(NativePtr->CustomRectIds, 1);
        public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x)
        {
            ImFont* native_font = font.NativePtr;
            Vector2 offset = new Vector2();
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, native_font, id, width, height, advance_x, offset);
            return ret;
        }
        public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x, Vector2 offset)
        {
            ImFont* native_font = font.NativePtr;
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, native_font, id, width, height, advance_x, offset);
            return ret;
        }
        public int AddCustomRectRegular(uint id, int width, int height)
        {
            int ret = ImGuiNative.ImFontAtlas_AddCustomRectRegular(NativePtr, id, width, height);
            return ret;
        }
        public ImFontPtr AddFont(ImFontConfigPtr font_cfg)
        {
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFont(NativePtr, native_font_cfg);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontDefault()
        {
            ImFontConfig* font_cfg = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, font_cfg);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontDefault(ImFontConfigPtr font_cfg)
        {
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, native_font_cfg);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, font_cfg, glyph_ranges);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ImFontConfigPtr font_cfg)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, native_font_cfg, glyph_ranges);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, native_font_cfg, native_glyph_ranges);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels)
        {
            byte* native_compressed_font_data_base85;
            int compressed_font_data_base85_byteCount = 0;
            if (compressed_font_data_base85 != null)
            {
                compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
                if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
                }
                else
                {
                    byte* native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
                    native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
                }
                int native_compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            else { native_compressed_font_data_base85 = null; }
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, font_cfg, glyph_ranges);
            if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_compressed_font_data_base85);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg)
        {
            byte* native_compressed_font_data_base85;
            int compressed_font_data_base85_byteCount = 0;
            if (compressed_font_data_base85 != null)
            {
                compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
                if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
                }
                else
                {
                    byte* native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
                    native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
                }
                int native_compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            else { native_compressed_font_data_base85 = null; }
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, native_font_cfg, glyph_ranges);
            if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_compressed_font_data_base85);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
        {
            byte* native_compressed_font_data_base85;
            int compressed_font_data_base85_byteCount = 0;
            if (compressed_font_data_base85 != null)
            {
                compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
                if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
                }
                else
                {
                    byte* native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
                    native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
                }
                int native_compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
                native_compressed_font_data_base85[native_compressed_font_data_base85_offset] = 0;
            }
            else { native_compressed_font_data_base85 = null; }
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, native_font_cfg, native_glyph_ranges);
            if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_compressed_font_data_base85);
            }
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_size, float size_pixels)
        {
            void* native_compressed_font_data = (void*)compressed_font_data.ToPointer();
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_size, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfigPtr font_cfg)
        {
            void* native_compressed_font_data = (void*)compressed_font_data.ToPointer();
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_size, size_pixels, native_font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
        {
            void* native_compressed_font_data = (void*)compressed_font_data.ToPointer();
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_size, size_pixels, native_font_cfg, native_glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_size, float size_pixels)
        {
            void* native_font_data = (void*)font_data.ToPointer();
            ImFontConfig* font_cfg = null;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_size, size_pixels, font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_size, float size_pixels, ImFontConfigPtr font_cfg)
        {
            void* native_font_data = (void*)font_data.ToPointer();
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* glyph_ranges = null;
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_size, size_pixels, native_font_cfg, glyph_ranges);
            return new ImFontPtr(ret);
        }
        public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_size, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
        {
            void* native_font_data = (void*)font_data.ToPointer();
            ImFontConfig* native_font_cfg = font_cfg.NativePtr;
            ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();
            ImFont* ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_size, size_pixels, native_font_cfg, native_glyph_ranges);
            return new ImFontPtr(ret);
        }
        public bool Build()
        {
            byte ret = ImGuiNative.ImFontAtlas_Build(NativePtr);
            return ret != 0;
        }
        public void CalcCustomRectUV(ImFontAtlasCustomRectPtr rect, out Vector2 out_uv_min, out Vector2 out_uv_max)
        {
            ImFontAtlasCustomRect* native_rect = rect.NativePtr;
            fixed (Vector2* native_out_uv_min = &out_uv_min)
            {
                fixed (Vector2* native_out_uv_max = &out_uv_max)
                {
                    ImGuiNative.ImFontAtlas_CalcCustomRectUV(NativePtr, native_rect, native_out_uv_min, native_out_uv_max);
                }
            }
        }
        public void Clear()
        {
            ImGuiNative.ImFontAtlas_Clear(NativePtr);
        }
        public void ClearFonts()
        {
            ImGuiNative.ImFontAtlas_ClearFonts(NativePtr);
        }
        public void ClearInputData()
        {
            ImGuiNative.ImFontAtlas_ClearInputData(NativePtr);
        }
        public void ClearTexData()
        {
            ImGuiNative.ImFontAtlas_ClearTexData(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImFontAtlas_destroy(NativePtr);
        }
        public ImFontAtlasCustomRectPtr GetCustomRectByIndex(int index)
        {
            ImFontAtlasCustomRect* ret = ImGuiNative.ImFontAtlas_GetCustomRectByIndex(NativePtr, index);
            return new ImFontAtlasCustomRectPtr(ret);
        }
        public IntPtr GetGlyphRangesChineseFull()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseFull(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesChineseSimplifiedCommon()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesCyrillic()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesCyrillic(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesDefault()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesDefault(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesJapanese()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesJapanese(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesKorean()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesKorean(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesThai()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesThai(NativePtr);
            return (IntPtr)ret;
        }
        public IntPtr GetGlyphRangesVietnamese()
        {
            ushort* ret = ImGuiNative.ImFontAtlas_GetGlyphRangesVietnamese(NativePtr);
            return (IntPtr)ret;
        }
        public bool GetMouseCursorTexData(ImGuiMouseCursor cursor, out Vector2 out_offset, out Vector2 out_size, out Vector2 out_uv_border, out Vector2 out_uv_fill)
        {
            fixed (Vector2* native_out_offset = &out_offset)
            {
                fixed (Vector2* native_out_size = &out_size)
                {
                    fixed (Vector2* native_out_uv_border = &out_uv_border)
                    {
                        fixed (Vector2* native_out_uv_fill = &out_uv_fill)
                        {
                            byte ret = ImGuiNative.ImFontAtlas_GetMouseCursorTexData(NativePtr, cursor, native_out_offset, native_out_size, native_out_uv_border, native_out_uv_fill);
                            return ret != 0;
                        }
                    }
                }
            }
        }
        public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height)
        {
            int* out_bytes_per_pixel = null;
            fixed (byte** native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
                    }
                }
            }
        }
        public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            fixed (byte** native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
                        {
                            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
                        }
                    }
                }
            }
        }
        public void GetTexDataAsAlpha8(out IntPtr out_pixels, out int out_width, out int out_height)
        {
            int* out_bytes_per_pixel = null;
            fixed (IntPtr* native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
                    }
                }
            }
        }
        public void GetTexDataAsAlpha8(out IntPtr out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            fixed (IntPtr* native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
                        {
                            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
                        }
                    }
                }
            }
        }
        public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height)
        {
            int* out_bytes_per_pixel = null;
            fixed (byte** native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
                    }
                }
            }
        }
        public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            fixed (byte** native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
                        {
                            ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
                        }
                    }
                }
            }
        }
        public void GetTexDataAsRGBA32(out IntPtr out_pixels, out int out_width, out int out_height)
        {
            int* out_bytes_per_pixel = null;
            fixed (IntPtr* native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
                    }
                }
            }
        }
        public void GetTexDataAsRGBA32(out IntPtr out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
        {
            fixed (IntPtr* native_out_pixels = &out_pixels)
            {
                fixed (int* native_out_width = &out_width)
                {
                    fixed (int* native_out_height = &out_height)
                    {
                        fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
                        {
                            ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
                        }
                    }
                }
            }
        }
        public bool IsBuilt()
        {
            byte ret = ImGuiNative.ImFontAtlas_IsBuilt(NativePtr);
            return ret != 0;
        }
        public void SetTexID(IntPtr id)
        {
            ImGuiNative.ImFontAtlas_SetTexID(NativePtr, id);
        }
    }
}
