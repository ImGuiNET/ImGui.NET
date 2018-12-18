using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct GlyphRangesBuilder
    {
        public ImVector UsedChars;
    }
    public unsafe partial struct GlyphRangesBuilderPtr
    {
        public GlyphRangesBuilder* NativePtr { get; }
        public GlyphRangesBuilderPtr(GlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
        public GlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (GlyphRangesBuilder*)nativePtr;
        public static implicit operator GlyphRangesBuilderPtr(GlyphRangesBuilder* nativePtr) => new GlyphRangesBuilderPtr(nativePtr);
        public static implicit operator GlyphRangesBuilder* (GlyphRangesBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator GlyphRangesBuilderPtr(IntPtr nativePtr) => new GlyphRangesBuilderPtr(nativePtr);
        public ImVector<byte> UsedChars => new ImVector<byte>(NativePtr->UsedChars);
        public void AddChar(ushort c)
        {
            ImGuiNative.GlyphRangesBuilder_AddChar(NativePtr, c);
        }
        public void AddRanges(IntPtr ranges)
        {
            ushort* native_ranges = (ushort*)ranges.ToPointer();
            ImGuiNative.GlyphRangesBuilder_AddRanges(NativePtr, native_ranges);
        }
        public void AddText(string text)
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
            byte* native_text_end = null;
            ImGuiNative.GlyphRangesBuilder_AddText(NativePtr, native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public void BuildRanges(out ImVector out_ranges)
        {
            fixed (ImVector* native_out_ranges = &out_ranges)
            {
                ImGuiNative.GlyphRangesBuilder_BuildRanges(NativePtr, native_out_ranges);
            }
        }
        public bool GetBit(int n)
        {
            byte ret = ImGuiNative.GlyphRangesBuilder_GetBit(NativePtr, n);
            return ret != 0;
        }
        public void SetBit(int n)
        {
            ImGuiNative.GlyphRangesBuilder_SetBit(NativePtr, n);
        }
    }
}
