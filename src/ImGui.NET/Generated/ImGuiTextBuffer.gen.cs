using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTextBuffer
    {
        public ImVector Buf;
    }
    public unsafe partial struct ImGuiTextBufferPtr
    {
        public ImGuiTextBuffer* NativePtr { get; }
        public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
        public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
        public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => new ImGuiTextBufferPtr(nativePtr);
        public static implicit operator ImGuiTextBuffer* (ImGuiTextBufferPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTextBufferPtr(IntPtr nativePtr) => new ImGuiTextBufferPtr(nativePtr);
        public ImVector<byte> Buf => new ImVector<byte>(NativePtr->Buf);
        public void clear()
        {
            ImGuiNative.ImGuiTextBuffer_clear(NativePtr);
        }
        public void appendf(string fmt)
        {
            byte* native_fmt;
            if (fmt != null)
            {
                int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                native_fmt = native_fmt_stackBytes;
                fixed (char* fmt_ptr = fmt)
                {
                    int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                    native_fmt[native_fmt_offset] = 0;
                }
            }
            else { native_fmt = null; }
            ImGuiNative.ImGuiTextBuffer_appendf(NativePtr, native_fmt);
        }
        public string c_str()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_c_str(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public void reserve(int capacity)
        {
            ImGuiNative.ImGuiTextBuffer_reserve(NativePtr, capacity);
        }
        public bool empty()
        {
            byte ret = ImGuiNative.ImGuiTextBuffer_empty(NativePtr);
            return ret != 0;
        }
        public int size()
        {
            int ret = ImGuiNative.ImGuiTextBuffer_size(NativePtr);
            return ret;
        }
        public string begin()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_begin(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public string end()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_end(NativePtr);
            return Util.StringFromPtr(ret);
        }
    }
}
