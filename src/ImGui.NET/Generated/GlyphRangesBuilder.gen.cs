using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct GlyphRangesBuilder
    {
        public ImVector/*<unsigned char>*/ UsedChars;
    }
    public unsafe struct GlyphRangesBuilderPtr
    {
        public GlyphRangesBuilder* NativePtr { get; }
        public GlyphRangesBuilderPtr(GlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
        public static implicit operator GlyphRangesBuilderPtr(GlyphRangesBuilder* nativePtr) => new GlyphRangesBuilderPtr(nativePtr);
        public static implicit operator GlyphRangesBuilder* (GlyphRangesBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public ref ImVector/*<unsigned char>*/ UsedChars => ref Unsafe.AsRef<ImVector/*<unsigned char>*/>(&NativePtr->UsedChars);
        public void SetBit(int n)
        {
            ImGuiNative.GlyphRangesBuilder_SetBit(NativePtr, n);
        }
        public void AddText(string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            ImGuiNative.GlyphRangesBuilder_AddText(NativePtr, native_text, native_text_end);
        }
        public void AddText(string text, string text_end)
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
            ImGuiNative.GlyphRangesBuilder_AddText(NativePtr, native_text, native_text_end);
        }
        public void AddRanges(ref ushort ranges)
        {
            ushort native_ranges_val = ranges;
            ushort* native_ranges = &native_ranges_val;
            ImGuiNative.GlyphRangesBuilder_AddRanges(NativePtr, native_ranges);
            ranges = native_ranges_val;
        }
        public void GlyphRangesBuilder()
        {
            ImGuiNative.GlyphRangesBuilder_GlyphRangesBuilder(NativePtr);
        }
        public void BuildRanges(out ImVector out_ranges)
        {
            ImVector native_out_ranges_val;
            ImVector* native_out_ranges = &native_out_ranges_val;
            ImGuiNative.GlyphRangesBuilder_BuildRanges(NativePtr, native_out_ranges);
            out_ranges = native_out_ranges_val;
        }
        public bool GetBit(int n)
        {
            byte ret = ImGuiNative.GlyphRangesBuilder_GetBit(NativePtr, n);
            return ret != 0;
        }
        public void AddChar(ushort c)
        {
            ImGuiNative.GlyphRangesBuilder_AddChar(NativePtr, c);
        }
    }
}
