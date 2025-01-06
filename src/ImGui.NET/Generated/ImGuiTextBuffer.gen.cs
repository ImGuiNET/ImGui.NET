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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void append(ReadOnlySpan<char> str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.ImGuiTextBuffer_append((ImGuiTextBuffer*)(NativePtr), native_str, native_str+str_byteCount);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
#endif
        public void append(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.ImGuiTextBuffer_append((ImGuiTextBuffer*)(NativePtr), native_str, native_str+str_byteCount);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void appendf(ref ImGuiTextBuffer buffer, ReadOnlySpan<char> fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            fixed (ImGuiTextBuffer* native_buffer = &buffer)
            {
                ImGuiNative.ImGuiTextBuffer_appendf(native_buffer, native_fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_fmt);
                }
            }
        }
#endif
        public void appendf(ref ImGuiTextBuffer buffer, string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            fixed (ImGuiTextBuffer* native_buffer = &buffer)
            {
                ImGuiNative.ImGuiTextBuffer_appendf(native_buffer, native_fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_fmt);
                }
            }
        }
        public string begin()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_begin((ImGuiTextBuffer*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public string c_str()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_c_str((ImGuiTextBuffer*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public void clear()
        {
            ImGuiNative.ImGuiTextBuffer_clear((ImGuiTextBuffer*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiTextBuffer_destroy((ImGuiTextBuffer*)(NativePtr));
        }
        public bool empty()
        {
            byte ret = ImGuiNative.ImGuiTextBuffer_empty((ImGuiTextBuffer*)(NativePtr));
            return ret != 0;
        }
        public string end()
        {
            byte* ret = ImGuiNative.ImGuiTextBuffer_end((ImGuiTextBuffer*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public void reserve(int capacity)
        {
            ImGuiNative.ImGuiTextBuffer_reserve((ImGuiTextBuffer*)(NativePtr), capacity);
        }
        public int size()
        {
            int ret = ImGuiNative.ImGuiTextBuffer_size((ImGuiTextBuffer*)(NativePtr));
            return ret;
        }
    }
}
