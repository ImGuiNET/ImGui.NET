using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTextFilter
    {
        public fixed byte InputBuf[256];
        public ImVector Filters;
        public int CountGrep;
    }
    public unsafe partial struct ImGuiTextFilterPtr
    {
        public ImGuiTextFilter* NativePtr { get; }
        public ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => NativePtr = nativePtr;
        public ImGuiTextFilterPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextFilter*)nativePtr;
        public static implicit operator ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => new ImGuiTextFilterPtr(nativePtr);
        public static implicit operator ImGuiTextFilter* (ImGuiTextFilterPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTextFilterPtr(IntPtr nativePtr) => new ImGuiTextFilterPtr(nativePtr);
        public RangeAccessor<byte> InputBuf => new RangeAccessor<byte>(NativePtr->InputBuf, 256);
        public ImVector<TextRange> Filters => new ImVector<TextRange>(NativePtr->Filters);
        public ref int CountGrep => ref Unsafe.AsRef<int>(&NativePtr->CountGrep);
        public void Build()
        {
            ImGuiNative.ImGuiTextFilter_Build(NativePtr);
        }
        public bool Draw()
        {
            byte* native_label;
            if ("Filter(inc,-exc)" != null)
            {
                int label_byteCount = Encoding.UTF8.GetByteCount("Filter(inc,-exc)");
                byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                native_label = native_label_stackBytes;
                fixed (char* label_ptr = "Filter(inc,-exc)")
                {
                    int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, "Filter(inc,-exc)".Length, native_label, label_byteCount);
                    native_label[native_label_offset] = 0;
                }
            }
            else { native_label = null; }
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public bool Draw(string label)
        {
            byte* native_label;
            if (label != null)
            {
                int label_byteCount = Encoding.UTF8.GetByteCount(label);
                byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                native_label = native_label_stackBytes;
                fixed (char* label_ptr = label)
                {
                    int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                    native_label[native_label_offset] = 0;
                }
            }
            else { native_label = null; }
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public bool Draw(string label, float width)
        {
            byte* native_label;
            if (label != null)
            {
                int label_byteCount = Encoding.UTF8.GetByteCount(label);
                byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                native_label = native_label_stackBytes;
                fixed (char* label_ptr = label)
                {
                    int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                    native_label[native_label_offset] = 0;
                }
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public bool IsActive()
        {
            byte ret = ImGuiNative.ImGuiTextFilter_IsActive(NativePtr);
            return ret != 0;
        }
        public void Clear()
        {
            ImGuiNative.ImGuiTextFilter_Clear(NativePtr);
        }
        public bool PassFilter(string text)
        {
            byte* native_text;
            if (text != null)
            {
                int text_byteCount = Encoding.UTF8.GetByteCount(text);
                byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                native_text = native_text_stackBytes;
                fixed (char* text_ptr = text)
                {
                    int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                    native_text[native_text_offset] = 0;
                }
            }
            else { native_text = null; }
            byte* native_text_end = null;
            byte ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, native_text_end);
            return ret != 0;
        }
    }
}
