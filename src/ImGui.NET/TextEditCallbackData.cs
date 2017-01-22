using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TextEditCallbackData
    {
        /// <summary>
        /// One of InputTextFlags.*. Read-only.
        /// </summary>
        public InputTextFlags EventFlag;
        /// <summary>
        /// What user passed to InputText(). Read-only.
        /// </summary>
        public InputTextFlags Flags;
        /// <summary>
        /// What user passed to InputText(). Read-only.
        /// </summary>
        public IntPtr UserData;
        private byte _ReadOnly;
        /// <summary>
        /// Read-only mode. Read-only.
        /// </summary>
        public bool ReadOnly { get { return _ReadOnly == 1; } }

        // CharFilter event:
        /// <summary>
        /// Character input. Read-write (replace character or set to zero).
        /// </summary>
        public ushort EventChar;

        // Completion,History,Always events:
        /// <summary>
        /// Key pressed (Up/Down/Tab). Read-only.
        /// </summary>
        public GuiKey EventKey;
        /// <summary>
        /// Current text. Read-write (pointed data only). char* in native code.
        /// </summary>
        public IntPtr Buf;

        public int BufTextLen;
        /// <summary>
        /// Read-only.
        /// </summary>
        public int BufSize;
        /// <summary>
        /// Must set if you modify Buf directly. Write-only.
        /// </summary>
        public byte BufDirty;
        /// <summary>
        /// Read-write.
        /// </summary>
        public int CursorPos;
        /// <summary>
        /// Read-write. (Equal to SelectionEnd when no selection)
        /// </summary>
        public int SelectionStart;
        /// <summary>
        /// Read-write.
        /// </summary>
        public int SelectionEnd;
        
        public bool HasSelection() { return SelectionStart != SelectionEnd; }
    }
}
