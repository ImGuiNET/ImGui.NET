using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiInputTextCallbackData
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
    public unsafe struct ImGuiInputTextCallbackDataPtr
    {
        public ImGuiInputTextCallbackData* NativePtr { get; }
        public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
        public ref ImGuiInputTextFlags EventFlag => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->EventFlag);
        public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);
        public void* UserData { get => NativePtr->UserData; set => NativePtr->UserData = value; }
        public ref ushort EventChar => ref Unsafe.AsRef<ushort>(&NativePtr->EventChar);
        public ref ImGuiKey EventKey => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->EventKey);
        public byte* Buf { get => NativePtr->Buf; set => NativePtr->Buf = value; }
        public ref int BufTextLen => ref Unsafe.AsRef<int>(&NativePtr->BufTextLen);
        public ref int BufSize => ref Unsafe.AsRef<int>(&NativePtr->BufSize);
        public ref byte BufDirty => ref Unsafe.AsRef<byte>(&NativePtr->BufDirty);
        public ref int CursorPos => ref Unsafe.AsRef<int>(&NativePtr->CursorPos);
        public ref int SelectionStart => ref Unsafe.AsRef<int>(&NativePtr->SelectionStart);
        public ref int SelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->SelectionEnd);
        public void ImGuiInputTextCallbackData()
        {
            ImGuiNative.ImGuiInputTextCallbackData_ImGuiInputTextCallbackData(NativePtr);
        }
        public void DeleteChars(int pos, int bytes_count)
        {
            ImGuiNative.ImGuiInputTextCallbackData_DeleteChars(NativePtr, pos, bytes_count);
        }
        public bool HasSelection()
        {
            byte ret = ImGuiNative.ImGuiInputTextCallbackData_HasSelection(NativePtr);
            return ret != 0;
        }
        public void InsertChars(int pos, string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, native_text_end);
        }
        public void InsertChars(int pos, string text, string text_end)
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
            ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, native_text_end);
        }
    }
}
