using System.Runtime.InteropServices;
using System.Numerics;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Style
    {
        public float Alpha;                      // Global alpha applies to everything in ImGui
        public Vector2 WindowPadding;              // Padding within a window
        public Vector2 WindowMinSize;              // Minimum window size
        public float WindowRounding;             // Radius of window corners rounding. Set to 0.0f to have rectangular windows
        public Align WindowTitleAlign;           // Alignment for title bar text
        public float ChildWindowRounding;        // Radius of child window corners rounding. Set to 0.0f to have rectangular windows
        public Vector2 FramePadding;               // Padding within a framed rectangle (used by most widgets)
        public float FrameRounding;              // Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets).
        public Vector2 ItemSpacing;                // Horizontal and vertical spacing between widgets/lines
        public Vector2 ItemInnerSpacing;           // Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label)
        public Vector2 TouchExtraPadding;          // Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!
        public float WindowFillAlphaDefault;     // Default alpha of window background, if not specified in ImGui::Begin()
        public float IndentSpacing;              // Horizontal indentation when e.g. entering a tree node
        public float ColumnsMinSpacing;          // Minimum horizontal spacing between two columns
        public float ScrollbarSize;              // Width of the vertical scrollbar, Height of the horizontal scrollbar
        public float ScrollbarRounding;          // Radius of grab corners for scrollbar
        public float GrabMinSize;                // Minimum width/height of a grab box for slider/scrollbar
        public float GrabRounding;               // Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
        public Vector2 DisplayWindowPadding;       // Window positions are clamped to be visible within the display area by at least this amount. Only covers regular windows.
        public Vector2 DisplaySafeAreaPadding;     // If you cannot see the edge of your screen (e.g. on a TV) increase the safe area padding. Covers popups/tooltips as well regular windows.
        public byte AntiAliasedLines;           // Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
        public byte AntiAliasedShapes;          // Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
        public float CurveTessellationTol;       // Tessellation tolerance. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.
        public fixed float Colors[(int)ColorTarget.Count * 4];
    };
}
