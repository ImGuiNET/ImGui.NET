using System;
using System.Numerics;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawListPtr
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
#else
        public void AddText(Vector2 pos, uint col, string text_begin)
#endif
        {
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            byte* native_text_end = null;
            ImGuiNative.ImDrawList_AddText_Vec2(NativePtr, pos, col, native_text_begin, native_text_end);
        }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
#else
	    public void AddText(ImFontPtr font, float font_size, Vector2 pos, uint col, string text_begin)
#endif
        {
            ImFont* native_font = font.NativePtr;
            int text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
            byte* native_text_begin = stackalloc byte[text_begin_byteCount + 1];
            fixed (char* text_begin_ptr = text_begin)
            {
                int native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            }
            byte* native_text_end = null;
            float wrap_width = 0.0f;
            Vector4* cpu_fine_clip_rect = null;
            ImGuiNative.ImDrawList_AddText_FontPtr(NativePtr, native_font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, cpu_fine_clip_rect);
        }
    }
}
