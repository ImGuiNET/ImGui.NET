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
        public ImPtrVector<ImGuiTextRangePtr> Filters => new ImPtrVector<ImGuiTextRangePtr>(NativePtr->Filters, Unsafe.SizeOf<ImGuiTextRange>());
        public ref int CountGrep => ref Unsafe.AsRef<int>(&NativePtr->CountGrep);
        public void Build()
        {
            ImGuiNative.ImGuiTextFilter_Build(NativePtr);
        }
        public void Clear()
        {
            ImGuiNative.ImGuiTextFilter_Clear(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiTextFilter_destroy(NativePtr);
        }
        public bool Draw()
        {
            byte* native_label;
            int label_byteCount = 0;
                label_byteCount = Encoding.UTF8.GetByteCount("Filter(inc,-exc)");
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8("Filter(inc,-exc)", native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public bool Draw(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public bool Draw(string label, float width)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public bool IsActive()
        {
            byte ret = ImGuiNative.ImGuiTextFilter_IsActive(NativePtr);
            return ret != 0;
        }
        public bool PassFilter(string text)
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
            byte ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
            return ret != 0;
        }
    }
}
