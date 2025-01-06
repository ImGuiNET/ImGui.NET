using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFont
    {
        public ImVector IndexAdvanceX;
        public float FallbackAdvanceX;
        public float FontSize;
        public ImVector IndexLookup;
        public ImVector Glyphs;
        public ImFontGlyph* FallbackGlyph;
        public ImFontAtlas* ContainerAtlas;
        public ImFontConfig* ConfigData;
        public short ConfigDataCount;
        public short EllipsisCharCount;
        public ushort EllipsisChar;
        public ushort FallbackChar;
        public float EllipsisWidth;
        public float EllipsisCharStep;
        public byte DirtyLookupTables;
        public float Scale;
        public float Ascent;
        public float Descent;
        public int MetricsTotalSurface;
        public fixed byte Used4kPagesMap[2];
    }
    public unsafe partial struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
        public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
        public static implicit operator ImFontPtr(ImFont* nativePtr) => new ImFontPtr(nativePtr);
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontPtr(IntPtr nativePtr) => new ImFontPtr(nativePtr);
        public ImVector<float> IndexAdvanceX => new ImVector<float>(NativePtr->IndexAdvanceX);
        public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);
        public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
        public ImVector<ushort> IndexLookup => new ImVector<ushort>(NativePtr->IndexLookup);
        public ImPtrVector<ImFontGlyphPtr> Glyphs => new ImPtrVector<ImFontGlyphPtr>(NativePtr->Glyphs, Unsafe.SizeOf<ImFontGlyph>());
        public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);
        public ref short ConfigDataCount => ref Unsafe.AsRef<short>(&NativePtr->ConfigDataCount);
        public ref short EllipsisCharCount => ref Unsafe.AsRef<short>(&NativePtr->EllipsisCharCount);
        public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
        public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
        public ref float EllipsisWidth => ref Unsafe.AsRef<float>(&NativePtr->EllipsisWidth);
        public ref float EllipsisCharStep => ref Unsafe.AsRef<float>(&NativePtr->EllipsisCharStep);
        public ref bool DirtyLookupTables => ref Unsafe.AsRef<bool>(&NativePtr->DirtyLookupTables);
        public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);
        public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);
        public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);
        public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);
        public RangeAccessor<byte> Used4kPagesMap => new RangeAccessor<byte>(NativePtr->Used4kPagesMap, 2);
        public void AddGlyph(ImFontConfigPtr src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
        {
            ImFontConfig* native_src_cfg = src_cfg.NativePtr;
            ImGuiNative.ImFont_AddGlyph((ImFont*)(NativePtr), native_src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
        }
        public void AddRemapChar(ushort dst, ushort src)
        {
            byte overwrite_dst = 1;
            ImGuiNative.ImFont_AddRemapChar((ImFont*)(NativePtr), dst, src, overwrite_dst);
        }
        public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
        {
            byte native_overwrite_dst = overwrite_dst ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_AddRemapChar((ImFont*)(NativePtr), dst, src, native_overwrite_dst);
        }
        public void BuildLookupTable()
        {
            ImGuiNative.ImFont_BuildLookupTable((ImFont*)(NativePtr));
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, ReadOnlySpan<char> text_begin)
        {
            Vector2 __retval;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte** remaining = null;
            ImGuiNative.ImFont_CalcTextSizeA(&__retval, (ImFont*)(NativePtr), size, max_width, wrap_width, native_text_begin, native_text_begin+text_begin_byteCount, remaining);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
            return __retval;
        }
#endif
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin)
        {
            Vector2 __retval;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte** remaining = null;
            ImGuiNative.ImFont_CalcTextSizeA(&__retval, (ImFont*)(NativePtr), size, max_width, wrap_width, native_text_begin, native_text_begin+text_begin_byteCount, remaining);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
            return __retval;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, ReadOnlySpan<char> text_begin, ref byte* remaining)
        {
            Vector2 __retval;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            fixed (byte** native_remaining = &remaining)
            {
                ImGuiNative.ImFont_CalcTextSizeA(&__retval, (ImFont*)(NativePtr), size, max_width, wrap_width, native_text_begin, native_text_begin+text_begin_byteCount, native_remaining);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text_begin);
                }
                return __retval;
            }
        }
#endif
        public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, ref byte* remaining)
        {
            Vector2 __retval;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            fixed (byte** native_remaining = &remaining)
            {
                ImGuiNative.ImFont_CalcTextSizeA(&__retval, (ImFont*)(NativePtr), size, max_width, wrap_width, native_text_begin, native_text_begin+text_begin_byteCount, native_remaining);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text_begin);
                }
                return __retval;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public string CalcWordWrapPositionA(float scale, ReadOnlySpan<char> text, float wrap_width)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* ret = ImGuiNative.ImFont_CalcWordWrapPositionA((ImFont*)(NativePtr), scale, native_text, native_text+text_byteCount, wrap_width);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
            return Util.StringFromPtr(ret);
        }
#endif
        public string CalcWordWrapPositionA(float scale, string text, float wrap_width)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* ret = ImGuiNative.ImFont_CalcWordWrapPositionA((ImFont*)(NativePtr), scale, native_text, native_text+text_byteCount, wrap_width);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
            return Util.StringFromPtr(ret);
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData((ImFont*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImFont_destroy((ImFont*)(NativePtr));
        }
        public ImFontGlyphPtr FindGlyph(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyph((ImFont*)(NativePtr), c);
            return new ImFontGlyphPtr(ret);
        }
        public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyphNoFallback((ImFont*)(NativePtr), c);
            return new ImFontGlyphPtr(ret);
        }
        public float GetCharAdvance(ushort c)
        {
            float ret = ImGuiNative.ImFont_GetCharAdvance((ImFont*)(NativePtr), c);
            return ret;
        }
        public string GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName((ImFont*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public void GrowIndex(int new_size)
        {
            ImGuiNative.ImFont_GrowIndex((ImFont*)(NativePtr), new_size);
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded((ImFont*)(NativePtr));
            return ret != 0;
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImFont_RenderChar((ImFont*)(NativePtr), native_draw_list, size, pos, col, c);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            float wrap_width = 0.0f;
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            float wrap_width = 0.0f;
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin, float wrap_width)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin, float wrap_width)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte cpu_fine_clip = 0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin, float wrap_width, bool cpu_fine_clip)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte native_cpu_fine_clip = cpu_fine_clip ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, native_cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, string text_begin, float wrap_width, bool cpu_fine_clip)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            byte native_cpu_fine_clip = cpu_fine_clip ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_RenderText((ImFont*)(NativePtr), native_draw_list, size, pos, col, clip_rect, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, native_cpu_fine_clip);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
        public void SetGlyphVisible(ushort c, bool visible)
        {
            byte native_visible = visible ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_SetGlyphVisible((ImFont*)(NativePtr), c, native_visible);
        }
    }
}
