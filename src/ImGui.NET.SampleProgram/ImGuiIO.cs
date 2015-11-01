using System;
using System.Runtime.InteropServices;
using ImVec2 = System.Numerics.Vector2;
using ImWchar = System.UInt16;

namespace ImGui
{
    //void        (* RenderDrawListsFn)(ImDrawData* data);
    // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void RenderDrawListsFn(ImDrawData* data);

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct ImGuiIO
    {
        //------------------------------------------------------------------
        // Settings (fill once)                 // Default value:
        //------------------------------------------------------------------

        public ImVec2 DisplaySize;              // <unset>              // Display size, in pixels. For clamping windows positions.
        public float DeltaTime;                // = 1.0f/60.0f         // Time elapsed since last frame, in seconds.
        public float IniSavingRate;            // = 5.0f               // Maximum time between saving positions/sizes to .ini file, in seconds.
        public IntPtr IniFilename;              // = "imgui.ini"        // Path to .ini file. NULL to disable .ini saving.
        public IntPtr LogFilename;              // = "imgui_log.txt"    // Path to .log file (default parameter to ImGui::LogToFile when no file is specified).
        public float MouseDoubleClickTime;     // = 0.30f              // Time for a double-click, in seconds.
        public float MouseDoubleClickMaxDist;  // = 6.0f               // Distance threshold to stay in to validate a double-click, in pixels.
        public float MouseDragThreshold;       // = 6.0f               // Distance threshold before considering we are dragging

        public fixed int KeyMap[Constants.ImGuiKey_COUNT];   // <unset>              // Map of indices into the KeysDown[512] entries array
        public float KeyRepeatDelay;           // = 0.250f             // When holding a key/button, time before it starts repeating, in seconds. (for actions where 'repeat' is active)
        public float KeyRepeatRate;            // = 0.020f             // When holding a key/button, rate at which it repeats, in seconds.
        public IntPtr UserData;                 // = NULL               // Store your own data for retrieval by callbacks.

        public ImFontAtlas* Fonts;                    // <auto>               // Load and assemble one or more fonts into a single tightly packed texture. Output to Fonts array.
        public float FontGlobalScale;          // = 1.0f               // Global scale all fonts
        public byte FontAllowUserScaling;     // = false              // Allow user scaling text of individual window with CTRL+Wheel.
        public ImVec2 DisplayFramebufferScale;  // = (1.0f,1.0f)        // For retina display or other situations where window coordinates are different from framebuffer coordinates. User storage only, presently not used by ImGui.
        public ImVec2 DisplayVisibleMin;        // <unset> (0.0f,0.0f)  // If you use DisplaySize as a virtual space larger than your screen, set DisplayVisibleMin/Max to the visible area.
        public ImVec2 DisplayVisibleMax;        // <unset> (0.0f,0.0f)  // If the values are the same, we defaults to Min=(0.0f) and Max=DisplaySize

        //------------------------------------------------------------------
        // User Functions
        //------------------------------------------------------------------

        // Rendering function, will be called in Render(). 
        // Alternatively you can keep this to NULL and call GetDrawData() after Render() to get the same pointer.
        // See example applications if you are unsure of how to implement this.

        //public RenderDrawListsFn RenderFunction;
        public IntPtr RenderDrawListsFn;

        // Optional: access OS clipboard
        // (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)
        // const char* (*GetClipboardTextFn)();
        public IntPtr GetClipboardTextFn;
        // void        (*SetClipboardTextFn)(const char* text);
        public IntPtr SetClipboardTextFn;

        // Optional: override memory allocations. MemFreeFn() may be called with a NULL pointer.
        // (default to posix malloc/free)
        // void*       (*MemAllocFn)(size_t sz);
        public IntPtr MemAllocFn;
        // void        (*MemFreeFn)(void* ptr);
        public IntPtr MemFreeFn;

        // Optional: notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME in Windows)
        // (default to use native imm32 api on Windows)
        //void        (*ImeSetInputScreenPosFn)(int x, int y);
        public IntPtr ImeSetInputScreenPosFn;
        public IntPtr ImeWindowHandle;            // (Windows) Set this to your HWND to get automatic IME cursor positioning.

        //------------------------------------------------------------------
        // Input - Fill before calling NewFrame()
        //------------------------------------------------------------------

        public ImVec2 MousePos;                   // Mouse position, in pixels (set to -1,-1 if no mouse / on another screen, etc.)
        public fixed byte MouseDown[5];               // Mouse buttons: left, right, middle + extras. ImGui itself mostly only uses left button (BeginPopupContext** are using right button). Others buttons allows us to track if the mouse is being used by your application + available to user as a convenience via IsMouse** API.
        public float MouseWheel;                 // Mouse wheel: 1 unit scrolls about 5 lines text.
        public byte MouseDrawCursor;            // Request ImGui to draw a mouse cursor for you (if you are on a platform without a mouse cursor).
        public byte KeyCtrl;                    // Keyboard modifier pressed: Control
        public byte KeyShift;                   // Keyboard modifier pressed: Shift
        public byte KeyAlt;                     // Keyboard modifier pressed: Alt
        public fixed byte KeysDown[512];              // Keyboard keys that are pressed (in whatever storage order you naturally have access to keyboard data)
        public fixed ImWchar InputCharacters[16 + 1];      // List of characters input (translated by user from keypress+keyboard state). Fill using AddInputCharacter() helper.

        // Functions
        /*
        IMGUI_API void AddInputCharacter(ImWchar c);                    // Helper to add a new character into InputCharacters[]
        IMGUI_API void AddInputCharactersUTF8(const char* utf8_chars);  // Helper to add new characters into InputCharacters[] from an UTF-8 string
        */

        //------------------------------------------------------------------
        // Output - Retrieve after calling NewFrame(), you can use them to discard inputs or hide them from the rest of your application
        //------------------------------------------------------------------

        public byte WantCaptureMouse;           // Mouse is hovering a window or widget is active (= ImGui will use your mouse input)
        public byte WantCaptureKeyboard;        // Widget is active (= ImGui will use your keyboard input)
        public byte WantTextInput;              // Some text input widget is active, which will read input characters from the InputCharacters array.
        public float Framerate;                  // Framerate estimation, in frame per second. Rolling average estimation based on IO.DeltaTime over 120 frames
        public int MetricsAllocs;              // Number of active memory allocations
        public int MetricsRenderVertices;      // Vertices output during last call to Render()
        public int MetricsRenderIndices;       // Indices output during last call to Render() = number of triangles * 3
        public int MetricsActiveWindows;       // Number of visible windows (exclude child windows)

        //------------------------------------------------------------------
        // [Internal] ImGui will maintain those fields for you
        //------------------------------------------------------------------

        public ImVec2 MousePosPrev;               // Previous mouse position
        public ImVec2 MouseDelta;                 // Mouse delta. Note that this is zero if either current or previous position are negative to allow mouse enabling/disabling.
        public fixed byte MouseClicked[5];            // Mouse button went from !Down to Down
        //fixed ImVec2 MouseClickedPos[5];         // Position at time of clicking
        public ImVec2 MouseClickedPos0, MouseClickedPos1, MouseClickedPos2, MouseClickedPos3, MouseClickedPos4;
        public fixed float MouseClickedTime[5];        // Time of last click (used to figure out double-click)
        public fixed byte MouseDoubleClicked[5];      // Has mouse button been double-clicked?
        public fixed byte MouseReleased[5];           // Mouse button went from Down to !Down
        public fixed byte MouseDownOwned[5];          // Track if button was clicked inside a window. We don't request mouse capture from the application if click started outside ImGui bounds.
        public fixed float MouseDownDuration[5];       // Duration the mouse button has been down (0.0f == just clicked)
        public fixed float MouseDownDurationPrev[5];   // Previous time the mouse button has been down
        public fixed float MouseDragMaxDistanceSqr[5]; // Squared maximum distance of how much mouse has traveled from the click point
        public fixed float KeysDownDuration[512];      // Duration the keyboard key has been down (0.0f == just pressed)
        public fixed float KeysDownDurationPrev[512];  // Previous duration the key has been down
        /*
        IMGUI_API ImGuiIO();
        */
    }

    public static class Constants
    {
        public const int intImGuiKey_Tab = 0;       // for tabbing through fields
        public const int ImGuiKey_LeftArrow = 1;    // for text edit
        public const int ImGuiKey_RightArrow = 2;   // for text edit
        public const int ImGuiKey_UpArrow = 3;      // for text edit
        public const int ImGuiKey_DownArrow = 4;    // for text edit
        public const int ImGuiKey_PageUp = 5;
        public const int ImGuiKey_PageDown = 6;
        public const int ImGuiKey_Home = 7;         // for text edit
        public const int ImGuiKey_End = 8;          // for text edit
        public const int ImGuiKey_Delete = 9;       // for text edit
        public const int ImGuiKey_Backspace = 10;   // for text edit
        public const int ImGuiKey_Enter = 11;       // for text edit
        public const int ImGuiKey_Escape = 12;      // for text edit
        public const int ImGuiKey_A = 13;           // for text edit CTRL+A: select all
        public const int ImGuiKey_C = 14;           // for text edit CTRL+C: copy
        public const int ImGuiKey_V = 15;           // for text edit CTRL+V: paste
        public const int ImGuiKey_X = 16;           // for text edit CTRL+X: cut
        public const int ImGuiKey_Y = 17;           // for text edit CTRL+Y: redo
        public const int ImGuiKey_Z = 18;           // for text edit CTRL+Z: undo
        public const int ImGuiKey_COUNT = 19;


        public static class ImGuiCol
        {
            public const int ImGuiCol_Text = 0;
            public const int ImGuiCol_TextDisabled = 1;
            public const int ImGuiCol_WindowBg = 2;
            public const int ImGuiCol_ChildWindowBg = 3;
            public const int ImGuiCol_Border = 4;
            public const int ImGuiCol_BorderShadow = 5;
            public const int ImGuiCol_FrameBg = 6;               // Background of checkbox = 0; radio button = 0; plot = 0; slider = 0; text input
            public const int ImGuiCol_FrameBgHovered = 7;
            public const int ImGuiCol_FrameBgActive = 8;
            public const int ImGuiCol_TitleBg = 9;
            public const int ImGuiCol_TitleBgCollapsed = 10;
            public const int ImGuiCol_TitleBgActive = 11;
            public const int ImGuiCol_MenuBarBg = 12;
            public const int ImGuiCol_ScrollbarBg = 13;
            public const int ImGuiCol_ScrollbarGrab = 14;
            public const int ImGuiCol_ScrollbarGrabHovered = 15;
            public const int ImGuiCol_ScrollbarGrabActive = 16;
            public const int ImGuiCol_ComboBg = 17;
            public const int ImGuiCol_CheckMark = 18;
            public const int ImGuiCol_SliderGrab = 19;
            public const int ImGuiCol_SliderGrabActive = 20;
            public const int ImGuiCol_Button = 21;
            public const int ImGuiCol_ButtonHovered = 22;
            public const int ImGuiCol_ButtonActive = 23;
            public const int ImGuiCol_Header = 24;
            public const int ImGuiCol_HeaderHovered = 25;
            public const int ImGuiCol_HeaderActive = 26;
            public const int ImGuiCol_Column = 27;
            public const int ImGuiCol_ColumnHovered = 28;
            public const int ImGuiCol_ColumnActive = 29;
            public const int ImGuiCol_ResizeGrip = 30;
            public const int ImGuiCol_ResizeGripHovered = 31;
            public const int ImGuiCol_ResizeGripActive = 32;
            public const int ImGuiCol_CloseButton = 33;
            public const int ImGuiCol_CloseButtonHovered = 34;
            public const int ImGuiCol_CloseButtonActive = 35;
            public const int ImGuiCol_PlotLines = 36;
            public const int ImGuiCol_PlotLinesHovered = 37;
            public const int ImGuiCol_PlotHistogram = 38;
            public const int ImGuiCol_PlotHistogramHovered = 39;
            public const int ImGuiCol_TextSelectedBg = 40;
            public const int ImGuiCol_TooltipBg = 41;
            public const int ImGuiCol_ModalWindowDarkening = 42;  // darken entire screen when a modal window is active
            public const int ImGuiCol_COUNT = 43;
        }
    }
}
