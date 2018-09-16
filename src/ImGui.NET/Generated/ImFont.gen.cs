using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

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
        public ushort FallbackChar;
        public short ConfigDataCount;
        public ImFontConfig* ConfigData;
        public ImFontAtlas* ContainerAtlas;
        public float Ascent;
        public float Descent;
        public byte DirtyLookupTables;
        public int MetricsTotalSurface;
    }
    public unsafe struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
        public static implicit operator ImFontPtr(ImFont* nativePtr) => new ImFontPtr(nativePtr);
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
        public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
        public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);
        public ref Vector2 DisplayOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayOffset);
        public ref ImVector/*<ImFontGlyph>*/ Glyphs => ref Unsafe.AsRef<ImVector/*<ImFontGlyph>*/>(&NativePtr->Glyphs);
        public ref ImVector/*<float>*/ IndexAdvanceX => ref Unsafe.AsRef<ImVector/*<float>*/>(&NativePtr->IndexAdvanceX);
        public ref ImVector/*<unsigned short>*/ IndexLookup => ref Unsafe.AsRef<ImVector/*<unsigned short>*/>(&NativePtr->IndexLookup);
        public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);
        public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);
        public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
        public ref short ConfigDataCount => ref Unsafe.AsRef<short>(&NativePtr->ConfigDataCount);
        public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);
        public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);
        public ref byte DirtyLookupTables => ref Unsafe.AsRef<byte>(&NativePtr->DirtyLookupTables);
        public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);
        public void AddRemapChar(ushort dst, ushort src)
        {
            byte overwrite_dst = 1;
            ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, overwrite_dst);
        }
        public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
        {
            byte native_overwrite_dst = overwrite_dst ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, native_overwrite_dst);
        }
        public void AddGlyph(ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
        {
            ImGuiNative.ImFont_AddGlyph(NativePtr, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
        }
        public void GrowIndex(int new_size)
        {
            ImGuiNative.ImFont_GrowIndex(NativePtr, new_size);
        }
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin, string text_end)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            float wrap_width = 0.0f;
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText(NativePtr, native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, cpu_fine_clip);
        }
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin, string text_end, float wrap_width)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText(NativePtr, native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, cpu_fine_clip);
        }
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin, string text_end, float wrap_width, bool cpu_fine_clip)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte native_cpu_fine_clip = cpu_fine_clip ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_RenderText(NativePtr, native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, native_cpu_fine_clip);
        }
        public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyphNoFallback(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public byte* CalcWordWrapPositionA(float scale, string text, string text_end, float wrap_width)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte* ret = ImGuiNative.ImFont_CalcWordWrapPositionA(NativePtr, scale, native_text, native_text_end, wrap_width);
            return ret;
        }
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin)
        {
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            byte* native_text_end = null;
            byte** remaining = null;
            Vector2 ret = ImGuiNative.ImFont_CalcTextSizeA(NativePtr, size, max_width, wrap_width, native_text_begin, native_text_end, remaining);
            return ret;
        }
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, string text_end)
        {
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte** remaining = null;
            Vector2 ret = ImGuiNative.ImFont_CalcTextSizeA(NativePtr, size, max_width, wrap_width, native_text_begin, native_text_end, remaining);
            return ret;
        }
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, string text_end, ref byte* remaining)
        {
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte* native_remaining_val = remaining;
            byte** native_remaining = &native_remaining_val;
            Vector2 ret = ImGuiNative.ImFont_CalcTextSizeA(NativePtr, size, max_width, wrap_width, native_text_begin, native_text_end, native_remaining);
            remaining = native_remaining_val;
            return ret;
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded(NativePtr);
            return ret != 0;
        }
        public float GetCharAdvance(ushort c)
        {
            float ret = ImGuiNative.ImFont_GetCharAdvance(NativePtr, c);
            return ret;
        }
        public void SetFallbackChar(ushort c)
        {
            ImGuiNative.ImFont_SetFallbackChar(NativePtr, c);
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImFont_RenderChar(NativePtr, native_draw_list, size, pos, col, c);
        }
        public ImFontGlyphPtr FindGlyph(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyph(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public void ImFont()
        {
            ImGuiNative.ImFont_ImFont(NativePtr);
        }
        public byte* GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName(NativePtr);
            return ret;
        }
        public void BuildLookupTable()
        {
            ImGuiNative.ImFont_BuildLookupTable(NativePtr);
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData(NativePtr);
        }
    }
}
