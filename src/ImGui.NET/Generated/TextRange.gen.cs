using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct TextRange
    {
        public byte* b;
        public byte* e;
    }
    public unsafe partial struct TextRangePtr
    {
        public TextRange* NativePtr { get; }
        public TextRangePtr(TextRange* nativePtr) => NativePtr = nativePtr;
        public TextRangePtr(IntPtr nativePtr) => NativePtr = (TextRange*)nativePtr;
        public static implicit operator TextRangePtr(TextRange* nativePtr) => new TextRangePtr(nativePtr);
        public static implicit operator TextRange* (TextRangePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator TextRangePtr(IntPtr nativePtr) => new TextRangePtr(nativePtr);
        public IntPtr b { get => (IntPtr)NativePtr->b; set => NativePtr->b = (byte*)value; }
        public IntPtr e { get => (IntPtr)NativePtr->e; set => NativePtr->e = (byte*)value; }
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
        public bool empty()
        {
            byte ret = ImGuiNative.TextRange_empty(NativePtr);
            return ret != 0;
        }
    }
}
