using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct STB_TexteditState
    {
        public int cursor;
        public int select_start;
        public int select_end;
        public byte insert_mode;
        public int row_count_per_page;
        public byte cursor_at_end_of_line;
        public byte initialized;
        public byte has_preferred_x;
        public byte single_line;
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public float preferred_x;
        public StbUndoState undostate;
    }
    public unsafe partial struct STB_TexteditStatePtr
    {
        public STB_TexteditState* NativePtr { get; }
        public STB_TexteditStatePtr(STB_TexteditState* nativePtr) => NativePtr = nativePtr;
        public STB_TexteditStatePtr(IntPtr nativePtr) => NativePtr = (STB_TexteditState*)nativePtr;
        public static implicit operator STB_TexteditStatePtr(STB_TexteditState* nativePtr) => new STB_TexteditStatePtr(nativePtr);
        public static implicit operator STB_TexteditState* (STB_TexteditStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator STB_TexteditStatePtr(IntPtr nativePtr) => new STB_TexteditStatePtr(nativePtr);
        public ref int cursor => ref Unsafe.AsRef<int>(&NativePtr->cursor);
        public ref int select_start => ref Unsafe.AsRef<int>(&NativePtr->select_start);
        public ref int select_end => ref Unsafe.AsRef<int>(&NativePtr->select_end);
        public ref byte insert_mode => ref Unsafe.AsRef<byte>(&NativePtr->insert_mode);
        public ref int row_count_per_page => ref Unsafe.AsRef<int>(&NativePtr->row_count_per_page);
        public ref byte cursor_at_end_of_line => ref Unsafe.AsRef<byte>(&NativePtr->cursor_at_end_of_line);
        public ref byte initialized => ref Unsafe.AsRef<byte>(&NativePtr->initialized);
        public ref byte has_preferred_x => ref Unsafe.AsRef<byte>(&NativePtr->has_preferred_x);
        public ref byte single_line => ref Unsafe.AsRef<byte>(&NativePtr->single_line);
        public ref byte padding1 => ref Unsafe.AsRef<byte>(&NativePtr->padding1);
        public ref byte padding2 => ref Unsafe.AsRef<byte>(&NativePtr->padding2);
        public ref byte padding3 => ref Unsafe.AsRef<byte>(&NativePtr->padding3);
        public ref float preferred_x => ref Unsafe.AsRef<float>(&NativePtr->preferred_x);
        public ref StbUndoState undostate => ref Unsafe.AsRef<StbUndoState>(&NativePtr->undostate);
    }
}
