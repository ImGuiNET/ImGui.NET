using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeWindow
    {
        public byte* Name;
        public uint ID;                                 // == ImHash(Name)
        public WindowFlags Flags;                              // See enum ImGuiWindowFlags_
        public Vector2 PosFloat;
        public Vector2 Pos;                                // Position rounded-up to nearest pixel
        public Vector2 Size;                               // Current size (==SizeFull or collapsed title bar size)
        public Vector2 SizeFull;                           // Size when non collapsed
        public Vector2 SizeFullAtLastBegin;                // Copy of SizeFull at the end of Begin. This is the reference value we'll use on the next frame to decide if we need scrollbars.
        public Vector2 SizeContents;                       // Size of contents (== extents reach of the drawing cursor) from previous frame. Include decoration, window title, border, menu, etc.
        public Vector2 SizeContentsExplicit;               // Size of contents explicitly set by the user via SetNextWindowContentSize()
        public ImRect ContentsRegionRect;                 // Maximum visible content position in window coordinates. ~~ (SizeContentsExplicit ? SizeContentsExplicit : Size - ScrollbarSizes) - CursorStartPos, per axis
        public Vector2 WindowPadding;                      // Window padding at the time of begin.
        public float WindowRounding;                     // Window rounding at the time of begin.
        public float WindowBorderSize;                   // Window border size at the time of begin.
        public uint MoveId;                             // == window->GetID("#MOVE")
        public Vector2 Scroll;
        public Vector2 ScrollTarget;                       // target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)
        public Vector2 ScrollTargetCenterRatio;            // 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered
        public byte ScrollbarX, ScrollbarY;
        public Vector2 ScrollbarSizes;
        public byte Active;                             // Set to true on Begin()
        public byte WasActive;
        public byte WriteAccessed;                      // Set to true when any widget access the current window
        public byte Collapsed;                          // Set when collapsing window to become only title-bar
        public byte SkipItems;                          // Set when items can safely be all clipped (e.g. window not visible or collapsed)
        public byte Appearing;                          // Set during the frame where the window is appearing (or re-appearing)
        public byte CloseButton;                        // Set when the window has a close button (p_open != NULL)
        public int BeginOrderWithinParent;             // Order within immediate parent window, if we are a child window. Otherwise 0.
        public int BeginOrderWithinContext;            // Order within entire imgui context. This is mostly used for debugging submission order related issues.
        public int BeginCount;                         // Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)
        public uint PopupId;                            // ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)
        public int AutoFitFramesX, AutoFitFramesY;
        public byte AutoFitOnlyGrows;
        public int AutoFitChildAxises;
        public int AutoPosLastDirection;
        public int HiddenFrames;
        public Condition SetWindowPosAllowFlags;             // store condition flags for next SetWindowPos() call.
        public Condition SetWindowSizeAllowFlags;            // store condition flags for next SetWindowSize() call.
        public Condition SetWindowCollapsedAllowFlags;       // store condition flags for next SetWindowCollapsed() call.
        public Vector2 SetWindowPosVal;                    // store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)
        public Vector2 SetWindowPosPivot;                  // store window pivot for positioning. Vector2(0,0) when positioning from top-left corner; Vector2(0.5f,0.5f) for centering; Vector2(1,1) for bottom right.

        public NativeDrawContext DC;                                 // Temporary per-window data, reset at the beginning of the frame
        public ImVector IDStack;                            // ID stack. ID are hashes seeded with the value at the top of the stack
        public ImRect ClipRect;                           // = DrawList->clip_rect_stack.back(). Scissoring / clipping rectangle. x1, y1, x2, y2.
        public ImRect WindowRectClipped;                  // = WindowRect just after setup in Begin(). == window->Rect() for root window.
        public ImRect InnerRect;
        public int LastFrameActive;
        public float ItemWidthDefault;
        public NativeSimpleColumns MenuColumns;                        // Simplified columns storage for menu items
        public Storage StateStorage;
        public ImVector ColumnsStorage;
        public float FontWindowScale;                    // Scale multiplier per-window
        public NativeDrawList* DrawList;
        public NativeWindow* ParentWindow;                       // If we are a child _or_ popup window, this is pointing to our parent. Otherwise NULL.
        public NativeWindow* RootWindow;                         // Generally point to ourself. If we are a child window, this is pointing to the first non-child parent window.
        public NativeWindow* RootNonPopupWindow;                 // Generally point to ourself. Used to display TitleBgActive color and for selecting which window to use for NavWindowing

        // Navigation / Focus
        int FocusIdxAllCounter;                 // Start at -1 and increase as assigned via FocusItemRegister()
        int FocusIdxTabCounter;                 // (same, but only count widgets which you can Tab through)
        int FocusIdxAllRequestCurrent;          // Item being requested for focus
        int FocusIdxTabRequestCurrent;          // Tab-able item being requested for focus
        int FocusIdxAllRequestNext;             // Item being requested for focus, for next update (relies on layout to be stable between the frame pressing TAB and the next frame)
        int FocusIdxTabRequestNext;             // "
    }
}
