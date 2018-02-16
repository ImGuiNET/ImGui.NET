namespace ImGuiNET
{
    public unsafe struct ImGuiTextEditState
    {
        public uint Id;                         // widget id owning the text state
        public ImVector Text;                       // edit buffer, we need to persist but can't guarantee the persistence of the user-provided buffer. so we copy into own buffer.
        public ImVector InitialText;                // backup of end-user buffer at the time of focus (in UTF-8, unaltered)
        public ImVector TempTextBuffer;
        public int CurLenA, CurLenW;           // we need to maintain our buffer length in both UTF-8 and wchar format.
        public int BufSizeA;                   // end-user buffer size
        public float ScrollX;
        public STB_TexteditState StbState;
        public float CursorAnim;
        public byte CursorFollow;
        public byte SelectedAllMouseLock;
    }

    public unsafe struct STB_TexteditState
    {
        /////////////////////
        //
        // public data
        //

        public int cursor;
        // position of the text cursor within the string

        public int select_start;          // selection start point
        public int select_end;
        // selection start and end point in characters; if equal, no selection.
        // note that start may be less than or greater than end (e.g. when
        // dragging the mouse, start is where the initial click was, and you
        // can drag in either direction)

        public byte insert_mode;
        // each textfield keeps its own insert mode state. to keep an app-wide
        // insert mode, copy this value in/out of the app state

        /////////////////////
        //
        // private data
        //
        public byte cursor_at_end_of_line; // not implemented yet
        public byte initialized;
        public byte has_preferred_x;
        public byte single_line;
        public byte padding1, padding2, padding3;
        public float preferred_x; // this determines where the cursor up/down tries to seek to along x
        public StbUndoState undostate;
    }

    public unsafe struct StbUndoState
    {
        const int STB_TEXTEDIT_UNDOSTATECOUNT = 99;
        const int STB_TEXTEDIT_UNDOCHARCOUNT = 999;

        // private data
        public fixed byte undo_rec[STB_TEXTEDIT_UNDOSTATECOUNT * (4 + 2 + 2)];
        public fixed int undo_char[STB_TEXTEDIT_UNDOCHARCOUNT];
        public short undo_point, redo_point;
        public short undo_char_point, redo_char_point;
    }

    public struct StbUndoRecord
    {
        // private data
        public int where;
        public short insert_length;
        public short delete_length;
        public short char_storage;
    }
}
