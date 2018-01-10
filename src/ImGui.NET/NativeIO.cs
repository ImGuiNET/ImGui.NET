using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeIO
    {
        //------------------------------------------------------------------
        // Settings (fill once)
        //------------------------------------------------------------------

        /// <summary>
        /// Display size, in pixels. For clamping windows positions.
        /// Default value: [unset]
        /// </summary>
        public Vector2 DisplaySize;
        /// <summary>
        /// Time elapsed since last frame, in seconds.
        /// Default value: 1.0f / 10.0f.
        /// </summary>
        public float DeltaTime;
        /// <summary>
        /// Maximum time between saving positions/sizes to .ini file, in seconds.
        /// Default value: 5.0f.
        /// </summary>
        public float IniSavingRate;
        /// <summary>
        /// Path to .ini file. NULL to disable .ini saving.
        /// Default value: "imgui.ini"
        /// </summary>
        public IntPtr IniFilename;
        /// <summary>
        /// Path to .log file (default parameter to ImGui::LogToFile when no file is specified).
        /// Default value: "imgui_log.txt"
        /// </summary>
        public IntPtr LogFilename;
        /// <summary>
        /// Time for a double-click, in seconds.
        /// Default value: 0.30f.
        /// </summary>
        public float MouseDoubleClickTime;
        /// <summary>
        /// Distance threshold to stay in to validate a double-click, in pixels.
        /// Default Value: 6.0f.
        /// </summary>
        public float MouseDoubleClickMaxDist;
        /// <summary>
        /// Distance threshold before considering we are dragging.
        /// Default Value: 6.0f.
        /// </summary>
        public float MouseDragThreshold;

        /// <summary>
        /// Map of indices into the KeysDown[512] entries array.
        /// Default values: [unset]
        /// </summary>
        public fixed int KeyMap[(int)GuiKey.Count];
        /// <summary>
        /// When holding a key/button, time before it starts repeating, in seconds. (for actions where 'repeat' is active).
        /// Default value: 0.250f.
        /// </summary>
        public float KeyRepeatDelay;
        /// <summary>
        /// When holding a key/button, rate at which it repeats, in seconds.
        /// Default value: 0.020f.
        /// </summary>
        public float KeyRepeatRate;
        /// <summary>
        /// Store your own data for retrieval by callbacks.
        /// Default value: IntPtr.Zero.
        /// </summary>
        public IntPtr UserData;

        /// <summary>
        /// Load and assemble one or more fonts into a single tightly packed texture. Output to Fonts array.
        /// Default value: [auto]
        /// </summary>
        public NativeFontAtlas* FontAtlas;
        /// <summary>
        /// Global scale all fonts.
        /// Default value: 1.0f.
        /// </summary>
        public float FontGlobalScale;
        /// <summary>
        /// Allow user scaling text of individual window with CTRL+Wheel.
        /// Default value: false.
        /// </summary>
        public byte FontAllowUserScaling;
        /// <summary>
        /// Font to use on NewFrame(). Use NULL to uses Fonts->Fonts[0].
        /// Default value: null.
        /// </summary>
        public NativeFont* FontDefault;
        /// <summary>
        /// For retina display or other situations where window coordinates are different from framebuffer coordinates.
        /// User storage only, presently not used by ImGui.
        /// Default value: (1.0f, 1.0f).
        /// </summary>
        public Vector2 DisplayFramebufferScale;
        /// <summary>
        /// If you use DisplaySize as a virtual space larger than your screen, set DisplayVisibleMin/Max to the visible area.
        /// Default value: (0.0f, 0.0f)
        /// </summary>
        public Vector2 DisplayVisibleMin;
        /// <summary>
        /// If the values are the same, we defaults to Min=0.0f) and Max=DisplaySize.
        /// Default value: (0.0f, 0.0f).
        /// </summary>
        public Vector2 DisplayVisibleMax;
        /// <summary>
        /// OS X style: Text editing cursor movement using Alt instead of Ctrl,
        /// Shortcuts using Cmd/Super instead of Ctrl,
        /// Line/Text Start and End using Cmd+Arrows instead of Home/End,
        /// Double click selects by word instead of selecting whole text,
        /// Multi-selection in lists uses Cmd/Super instead of Ctrl
        /// Default value: True on OSX; false otherwise.
        /// </summary>
        public byte OptMacOSXBehaviors;
        /// <summary>
        /// Enable blinking cursor, for users who consider it annoying.
        /// Default value: true.
        /// </summary>
        public byte OptCursorBlink;

        //------------------------------------------------------------------
        // User Functions
        //------------------------------------------------------------------

        /// <summary>
        /// Rendering function, will be called in Render(). 
        /// Alternatively you can keep this to NULL and call GetDrawData() after Render() to get the same pointer.
        /// </summary>
        public IntPtr RenderDrawListsFn;

        /// <summary>
        /// Optional: access OS clipboard
        /// (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)
        /// </summary>
        public IntPtr GetClipboardTextFn;
        /// <summary>
        /// Optional: access OS clipboard
        /// (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)
        /// </summary>
        public IntPtr SetClipboardTextFn;
        public IntPtr ClipboardUserData;

        /// <summary>
        /// Optional: override memory allocations. MemFreeFn() may be called with a NULL pointer.
        /// (default to posix malloc/free)
        /// </summary>
        public IntPtr MemAllocFn;
        /// <summary>
        /// Optional: override memory allocations. MemFreeFn() may be called with a NULL pointer.
        /// (default to posix malloc/free)
        /// </summary>
        public IntPtr MemFreeFn;

        /// <summary>
        /// Optional: notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME in Windows)
        /// (default to use native imm32 api on Windows)
        /// </summary>
        public IntPtr ImeSetInputScreenPosFn;
        /// <summary>
        /// (Windows) Set this to your HWND to get automatic IME cursor positioning.
        /// </summary>
        public IntPtr ImeWindowHandle;

        //------------------------------------------------------------------
        // Input - Fill before calling NewFrame()
        //------------------------------------------------------------------

        /// <summary>
        /// Mouse position, in pixels (set to -1,-1 if no mouse / on another screen, etc.).
        /// </summary>
        public Vector2 MousePos;
        /// <summary>
        /// Mouse buttons: left, right, middle + extras.
        /// ImGui itself mostly only uses left button (BeginPopupContext** are using right button).
        /// Others buttons allows us to track if the mouse is being used by your application + available to user as a convenience via IsMouse** API.
        /// </summary>
        public fixed byte MouseDown[5];
        /// <summary>
        /// Mouse wheel: 1 unit scrolls about 5 lines text.
        /// </summary>
        public float MouseWheel;
        /// <summary>
        /// Request ImGui to draw a mouse cursor for you (if you are on a platform without a mouse cursor).
        /// </summary>
        public byte MouseDrawCursor;
        /// <summary>
        /// Keyboard modifier pressed: Control.
        /// </summary>
        public byte KeyCtrl;
        /// <summary>
        /// Keyboard modifier pressed: Shift
        /// </summary>
        public byte KeyShift;
        /// <summary>
        /// Keyboard modifier pressed: Alt
        /// </summary>
        public byte KeyAlt;
        /// <summary>
        /// Keyboard modifier pressed: Cmd/Super/Windows
        /// </summary>
        public byte KeySuper;
        /// <summary>
        /// Keyboard keys that are pressed (in whatever storage order you naturally have access to keyboard data)
        /// </summary>
        public fixed byte KeysDown[512];
        /// <summary>
        /// List of characters input (translated by user from keypress+keyboard state).
        /// Fill using AddInputCharacter() helper.
        /// </summary>
        public fixed ushort InputCharacters[16 + 1];

        //------------------------------------------------------------------
        // Output - Retrieve after calling NewFrame(), you can use them to discard inputs or hide them from the rest of your application
        //------------------------------------------------------------------

        /// <summary>
        /// Mouse is hovering a window or widget is active (= ImGui will use your mouse input).
        /// </summary>
        public byte WantCaptureMouse;
        /// <summary>
        /// Widget is active (= ImGui will use your keyboard input).
        /// </summary>
        public byte WantCaptureKeyboard;
        /// <summary>
        /// Some text input widget is active, which will read input characters from the InputCharacters array.
        /// </summary>
        public byte WantTextInput;
        /// <summary>
        /// MousePos has been altered, back-end should reposition mouse on next frame. Set only when 'NavMovesMouse=true'.
        /// </summary>
        public byte WantMoveMouse;
        /// <summary>
        /// Framerate estimation, in frame per second. Rolling average estimation based on IO.DeltaTime over 120 frames.
        /// </summary>
        public float Framerate;
        /// <summary>
        /// Number of active memory allocations.
        /// </summary>
        public int MetricsAllocs;
        /// <summary>
        /// Vertices output during last call to Render().
        /// </summary>
        public int MetricsRenderVertices;
        /// <summary>
        /// Indices output during last call to Render() = number of triangles * 3
        /// </summary>
        public int MetricsRenderIndices;
        /// <summary>
        /// Number of visible windows (exclude child windows)
        /// </summary>
        public int MetricsActiveWindows;
        /// <summary>
        /// Mouse delta. Note that this is zero if either current or previous position are negative,
        /// so a disappearing/reappearing mouse won't have a huge delta for one frame.
        /// </summary>
        public Vector2 MouseDelta;

        //------------------------------------------------------------------
        // [Internal] ImGui will maintain those fields for you
        //------------------------------------------------------------------

        /// <summary>
        /// Previous mouse position
        /// </summary>
        public Vector2 MousePosPrev;
        /// <summary>
        /// Position at time of clicking
        /// </summary>
        public Vector2 MouseClickedPos0;
        /// <summary>
        /// Position at time of clicking
        /// </summary>
        public Vector2 MouseClickedPos1;
        /// <summary>
        /// Position at time of clicking
        /// </summary>
        public Vector2 MouseClickedPos2;
        /// <summary>
        /// Position at time of clicking
        /// </summary>
        public Vector2 MouseClickedPos3;
        /// <summary>
        /// Position at time of clicking
        /// </summary>
        public Vector2 MouseClickedPos4;
        /// <summary>
        /// Time of last click (used to figure out double-click)
        /// </summary>
        public fixed float MouseClickedTime[5];
        /// <summary>
        /// Mouse button went from !Down to Down
        /// </summary>
        public fixed byte MouseClicked[5];
        /// <summary>
        /// Has mouse button been double-clicked?
        /// </summary>
        public fixed byte MouseDoubleClicked[5];
        /// <summary>
        /// Mouse button went from Down to !Down
        /// </summary>
        public fixed byte MouseReleased[5];
        /// <summary>
        /// Track if button was clicked inside a window.
        /// We don't request mouse capture from the application if click started outside ImGui bounds.
        /// </summary>
        public fixed byte MouseDownOwned[5];
        /// <summary>
        /// Duration the mouse button has been down (0.0f == just clicked).
        /// </summary>
        public fixed float MouseDownDuration[5];
        /// <summary>
        /// Previous time the mouse button has been down
        /// </summary>
        public fixed float MouseDownDurationPrev[5];
        /// <summary>
        /// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point
        /// </summary>
        public Vector2 MouseDragMaxDistanceAbs0;
        /// <summary>
        /// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point
        /// </summary>
        public Vector2 MouseDragMaxDistanceAbs1;
        /// <summary>
        /// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point
        /// </summary>
        public Vector2 MouseDragMaxDistanceAbs2;
        /// <summary>
        /// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point
        /// </summary>
        public Vector2 MouseDragMaxDistanceAbs3;
        /// <summary>
        /// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point
        /// </summary>
        public Vector2 MouseDragMaxDistanceAbs4;
        /// <summary>
        /// Squared maximum distance of how much mouse has traveled from the click point
        /// </summary>
        public fixed float MouseDragMaxDistanceSqr[5];
        /// <summary>
        /// Duration the keyboard key has been down (0.0f == just pressed)
        /// </summary>
        public fixed float KeysDownDuration[512];
        /// <summary>
        /// Previous duration the key has been down
        /// </summary>
        public fixed float KeysDownDurationPrev[512];
    }
}