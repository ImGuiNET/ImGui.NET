using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeContext
    {
        public byte Initialized;
        public NativeIO IO;
        public NativeStyle Style;
        public NativeFont* Font;                         // (Shortcut) == FontStack.empty() ? IO.Font : FontStack.back()
        public float FontSize;                           // (Shortcut) == FontBaseSize * g.CurrentWindow->FontWindowScale == window->FontSize(). Text height for current window.
        public float FontBaseSize;                       // (Shortcut) == IO.FontGlobalScale * Font->Scale * Font->FontSize. Base text height.
        public NativeDrawListSharedData DrawListSharedData;

        public float Time;
        public int FrameCount;
        public int FrameCountEnded;
        public int FrameCountRendered;
        public ImVector Windows;
        public ImVector WindowsSortBuffer;
        public ImVector CurrentWindowStack;
        public Storage WindowsById;
        public int WindowsActiveCount;
        public NativeWindow* CurrentWindow;                      // Being drawn into
        public NativeWindow* NavWindow;                          // Nav/focused window for navigation
        public NativeWindow* HoveredWindow;                      // Will catch mouse inputs
        public NativeWindow* HoveredRootWindow;                  // Will catch mouse inputs (for focus/move only)
        public uint HoveredId;                          // Hovered widget
        public byte HoveredIdAllowOverlap;
        public uint HoveredIdPreviousFrame;
        public float HoveredIdTimer;
        public uint ActiveId;                           // Active widget
        public uint ActiveIdPreviousFrame;
        public float ActiveIdTimer;
        public byte ActiveIdIsAlive;                    // Active widget has been seen this frame
        public byte ActiveIdIsJustActivated;            // Set at the time of activation for one frame
        public byte ActiveIdAllowOverlap;               // Active widget allows another widget to steal active id (generally for overlapping widgets, but not always)
        public Vector2 ActiveIdClickOffset;                // Clicked offset from upper-left corner, if applicable (currently only set by ButtonBehavior)
        public NativeWindow* ActiveIdWindow;
        public NativeWindow* MovingWindow;                       // Track the child window we clicked on to move a window.
        public uint MovingWindowMoveId;                 // == MovingWindow->MoveId
        public ImVector ColorModifiers;                     // Stack for PushStyleColor()/PopStyleColor()
        public ImVector StyleModifiers;                     // Stack for PushStyleVar()/PopStyleVar()
        public ImVector FontStack;                          // Stack for PushFont()/PopFont()
        public ImVector OpenPopupStack;                     // Which popups are open (persistent)
        public ImVector CurrentPopupStack;                  // Which level of BeginPopup() we are in (reset every frame)

        // Storage for SetNexWindow** and SetNextTreeNode*** functions
        public Vector2 SetNextWindowPosVal;
        public Vector2 SetNextWindowPosPivot;
        public Vector2 SetNextWindowSizeVal;
        public Vector2 SetNextWindowContentSizeVal;
        public byte SetNextWindowCollapsedVal;
        public Condition SetNextWindowPosCond;
        public Condition SetNextWindowSizeCond;
        public Condition SetNextWindowContentSizeCond;
        public Condition SetNextWindowCollapsedCond;
        public ImRect SetNextWindowSizeConstraintRect;           // Valid if 'SetNextWindowSizeConstraint' is true
        public IntPtr SetNextWindowSizeConstraintCallback;
        public void* SetNextWindowSizeConstraintCallbackUserData;
        public byte SetNextWindowSizeConstraint;
        public byte SetNextWindowFocus;
        public byte SetNextTreeNodeOpenVal;
        public Condition SetNextTreeNodeOpenCond;

        // Render
        public DrawData RenderDrawData;                     // Main ImDrawData instance to pass render information to the user
        public ImVector RenderDrawLists0;
        public ImVector RenderDrawLists1;
        public ImVector RenderDrawLists2;
        public float ModalWindowDarkeningRatio;
        public DrawList OverlayDrawList;                    // Optional software render of mouse cursors, if io.MouseDrawCursor is set + a few debug overlays
        public int MouseCursor;
        public fixed byte MouseCursorData[7 * (4 + 8 + 8 + 16 + 16)];

        // Drag and Drop
        public byte DragDropActive;
        public int DragDropSourceFlags;
        public int DragDropMouseButton;
        public NativePayload DragDropPayload;
        public ImRect DragDropTargetRect;
        public uint DragDropTargetId;
        public float DragDropAcceptIdCurrRectSurface;
        public uint DragDropAcceptIdCurr;               // Target item id (set at the time of accepting the payload)
        public uint DragDropAcceptIdPrev;               // Target item id from previous frame (we need to store this to allow for overlapping drag and drop targets)
        public int DragDropAcceptFrameCount;           // Last time a target expressed a desire to accept the source
        public ImVector DragDropPayloadBufHeap;             // We don't expose the ImVector<> directly
        public fixed byte DragDropPayloadBufLocal[8];

        // Widget state
        public ImGuiTextEditState InputTextState;
        public NativeFont InputTextPasswordFont;
        public uint ScalarAsInputTextId;                // Temporary text input when CTRL+clicking on a slider, etc.
        public int ColorEditOptions;                   // Store user options for color edit widgets
        public Vector4 ColorPickerRef;
        public float DragCurrentValue;                   // Currently dragged value, always float, not rounded by end-user precision settings
        public Vector2 DragLastMouseDelta;
        public float DragSpeedDefaultRatio;              // If speed == 0.0f, uses (max-min) * DragSpeedDefaultRatio
        public float DragSpeedScaleSlow;
        public float DragSpeedScaleFast;
        public Vector2 ScrollbarClickDeltaToGrabCenter;    // Distance between mouse and center of grab box, normalized in parent space. Use storage?
        public int TooltipOverrideCount;
        public ImVector PrivateClipboard;                   // If no custom clipboard handler is defined
        public Vector2 OsImePosRequest, OsImePosSet;       // Cursor position request & last passed to the OS Input Method Editor

        // Settings
        public float SettingsDirtyTimer;          // Save .ini Settings on disk when time reaches zero
        public ImVector SettingsWindows;             // .ini settings for NativeWindow
        public ImVector SettingsHandlers;            // List of .ini settings handlers

        // Logging
        public byte LogEnabled;
        public void* LogFile;                            // If != NULL log to stdout/ file
        public void* LogClipboard;                       // Else log to clipboard. This is pointer so our GImGui static constructor doesn't call heap allocators.
        public int LogStartDepth;
        public int LogAutoExpandMaxDepth;

        // Misc
        public fixed float FramerateSecPerFrame[120];          // calculate estimate of framerate for user
        public int FramerateSecPerFrameIdx;
        public float FramerateSecPerFrameAccum;
        public int WantCaptureMouseNextFrame;          // explicit capture via CaptureInputs() sets those flags
        public int WantCaptureKeyboardNextFrame;
        public int WantTextInputNextFrame;
        public fixed byte TempBuffer[1024 * 3 + 1];               // temporary text buffer
    }

    public unsafe struct NativeDrawListSharedData
    {
        public Vector2 TexUvWhitePixel;            // UV of white pixel in the atlas
        public NativeFont* Font;                       // Current/default font (optional, for simplified AddText overload)
        public float FontSize;                   // Current/default font size (optional, for simplified AddText overload)
        public float CurveTessellationTol;
        public Vector4 ClipRectFullscreen;         // Value for PushClipRectFullscreen()

        // Const data
        public fixed float CircleVtx12[12 * 2];
    }
}
