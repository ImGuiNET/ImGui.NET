using System.Numerics;

namespace ImGuiNET
{
    // Transient per-window data, reset at the beginning of the frame
    public unsafe struct NativeDrawContext
    {
        public Vector2 CursorPos;
        public Vector2 CursorPosPrevLine;
        public Vector2 CursorStartPos;
        public Vector2 CursorMaxPos;           // Implicitly calculate the size of our contents, always extending. Saved into window->SizeContents at the end of the frame
        public float CurrentLineHeight;
        public float CurrentLineTextBaseOffset;
        public float PrevLineHeight;
        public float PrevLineTextBaseOffset;
        public float LogLinePosY;
        public int TreeDepth;
        public uint LastItemId;
        public ImRect LastItemRect;
        public byte LastItemHoveredAndUsable;  // Item rectangle is hovered, and its window is currently interactable with (not blocked by a popup preventing access to the window)
        public byte LastItemHoveredRect;       // Item rectangle is hovered, but its window may or not be currently interactable with (might be blocked by a popup preventing access to the window)
        public byte MenuBarAppending;
        public float MenuBarOffsetX;
        public ImVector ChildWindows;
        public Storage StateStorage;
        public int LayoutType;

        // We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.
        public float ItemWidth;              // == ItemWidthStack.back(). 0.0: default, >0.0: width in pixels, <0.0: align xx pixels to the right of window
        public float TextWrapPos;            // == TextWrapPosStack.back() [empty == -1.0f]
        public byte AllowKeyboardFocus;     // == AllowKeyboardFocusStack.back() [empty == true]
        public byte ButtonRepeat;           // == ButtonRepeatStack.back() [empty == false]
        public ImVector ItemWidthStack;
        public ImVector TextWrapPosStack;
        public ImVector AllowKeyboardFocusStack;
        public ImVector ButtonRepeatStack;
        public ImVector GroupStack;
        public ColorEditFlags ColorEditMode;
        public fixed int StackSizesBackup[6];    // Store size of various stacks for asserting

        public float IndentX;                // Indentation / start position from left of window (increased by TreePush/TreePop, etc.)
        public float GroupOffsetX;
        public float ColumnsOffsetX;         // Offset to the current column (if ColumnsCurrent > 0).
        public int ColumnsCurrent;
        public int ColumnsCount;
        public float ColumnsMinX;
        public float ColumnsMaxX;
        public float ColumnsStartPosY;
        public float ColumnsCellMinY;
        public float ColumnsCellMaxY;
        public byte ColumnsShowBorders;
        public uint ColumnsSetId;
        public ImVector ColumnsData;
    }
}
