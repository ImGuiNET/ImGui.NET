using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiInputTextCallbackData
    {
        public ImGuiInputTextFlags EventFlag;
        public ImGuiInputTextFlags Flags;
        public void* UserData;
        public ushort EventChar;
        public ImGuiKey EventKey;
        public byte* Buf;
        public int BufTextLen;
        public int BufSize;
        public byte BufDirty;
        public int CursorPos;
        public int SelectionStart;
        public int SelectionEnd;
    }
    public unsafe partial struct ImGuiInputTextCallbackDataPtr
    {
        public ImGuiInputTextCallbackData* NativePtr { get; }
        public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextCallbackData*)nativePtr;
        public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiInputTextCallbackData* (ImGuiInputTextCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);
        public ref ImGuiInputTextFlags EventFlag => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->EventFlag);
        public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ref ushort EventChar => ref Unsafe.AsRef<ushort>(&NativePtr->EventChar);
        public ref ImGuiKey EventKey => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->EventKey);
        public IntPtr Buf { get => (IntPtr)NativePtr->Buf; set => NativePtr->Buf = (byte*)value; }
        public ref int BufTextLen => ref Unsafe.AsRef<int>(&NativePtr->BufTextLen);
        public ref int BufSize => ref Unsafe.AsRef<int>(&NativePtr->BufSize);
        public ref bool BufDirty => ref Unsafe.AsRef<bool>(&NativePtr->BufDirty);
        public ref int CursorPos => ref Unsafe.AsRef<int>(&NativePtr->CursorPos);
        public ref int SelectionStart => ref Unsafe.AsRef<int>(&NativePtr->SelectionStart);
        public ref int SelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->SelectionEnd);
        public void ClearSelection()
        {
            ImGuiNative.ImGuiInputTextCallbackData_ClearSelection((ImGuiInputTextCallbackData*)(NativePtr));
        }
        public void DeleteChars(int pos, int bytes_count)
        {
            ImGuiNative.ImGuiInputTextCallbackData_DeleteChars((ImGuiInputTextCallbackData*)(NativePtr), pos, bytes_count);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiInputTextCallbackData_destroy((ImGuiInputTextCallbackData*)(NativePtr));
        }
        public bool HasSelection()
        {
            byte ret = ImGuiNative.ImGuiInputTextCallbackData_HasSelection((ImGuiInputTextCallbackData*)(NativePtr));
            return ret != 0;
        }
        public void InsertChars(int pos, string text)
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
            ImGuiNative.ImGuiInputTextCallbackData_InsertChars((ImGuiInputTextCallbackData*)(NativePtr), pos, native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public void SelectAll()
        {
            ImGuiNative.ImGuiInputTextCallbackData_SelectAll((ImGuiInputTextCallbackData*)(NativePtr));
        }
    }
}
