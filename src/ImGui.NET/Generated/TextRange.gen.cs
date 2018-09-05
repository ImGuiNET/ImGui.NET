using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct TextRange
    {
        public byte* b;
        public byte* e;
    }
    public unsafe struct TextRangePtr
    {
        public TextRange* NativePtr { get; }
        public TextRangePtr(TextRange* nativePtr) => NativePtr = nativePtr;
        public byte* b { get => NativePtr->b; set => NativePtr->b = value; }
        public byte* e { get => NativePtr->e; set => NativePtr->e = value; }
        public void split(byte separator, ref ImVector @out)
        {
            ImVector native_out_val = @out;
            ImVector* native_out = &native_out_val;
            ImGuiNative.TextRange_split(NativePtr, separator, native_out);
            @out = native_out_val;
        }
        public byte* end()
        {
            byte* ret = ImGuiNative.TextRange_end(NativePtr);
            return ret;
        }
        public byte* begin()
        {
            byte* ret = ImGuiNative.TextRange_begin(NativePtr);
            return ret;
        }
        public void TextRange()
        {
            ImGuiNative.TextRange_TextRange(NativePtr);
        }
        public void TextRange(string _b, string _e)
        {
            int _b_byteCount = Encoding.UTF8.GetByteCount(_b);
            byte* native__b = stackalloc byte[_b_byteCount + 1];
            fixed (char* _b_ptr = _b)
            {
                int native__b_offset = Encoding.UTF8.GetBytes(_b_ptr, _b.Length, native__b, _b_byteCount);
                native__b[native__b_offset] = 0;
            }
            int _e_byteCount = Encoding.UTF8.GetByteCount(_e);
            byte* native__e = stackalloc byte[_e_byteCount + 1];
            fixed (char* _e_ptr = _e)
            {
                int native__e_offset = Encoding.UTF8.GetBytes(_e_ptr, _e.Length, native__e, _e_byteCount);
                native__e[native__e_offset] = 0;
            }
            ImGuiNative.TextRange_TextRangeStr(NativePtr, native__b, native__e);
        }
        public bool empty()
        {
            byte ret = ImGuiNative.TextRange_empty(NativePtr);
            return ret != 0;
        }
    }
}
