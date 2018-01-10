using System.Runtime.InteropServices;
using System.Numerics;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeStyle
    {
        /// <summary>
        /// Global alpha applies to everything in ImGui.
        /// </summary>
        public float Alpha;
        /// <summary>
        /// Padding within a window.
        /// </summary>
        public Vector2 WindowPadding;
        /// <summary>
        /// Radius of window corners rounding. Set to 0.0f to have rectangular windows.
        /// </summary>
        public float WindowRounding;
        /// <summary>
        /// Thickness of border around windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly)
        /// </summary>
        public float WindowBorderSize;
        /// <summary>
        /// Minimum window size.
        /// </summary>
        public Vector2 WindowMinSize;
        /// <summary>
        /// Alignment for title bar text.
        /// </summary>
        public Vector2 WindowTitleAlign;
        /// <summary>
        /// Radius of child window corners rounding. Set to 0.0f to have rectangular windows.
        /// </summary>
        public float ChildRounding;
        /// <summary>
        /// Thickness of border around child windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly)
        /// </summary>
        public float ChildBorderSize;
        /// <summary>
        /// Radius of popup window corners rounding.
        /// </summary>
        public float PopupRounding;
        /// <summary>
        /// Thickness of border around popup windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly)
        /// </summary>
        public float PopupBorderSize;
        /// <summary>
        /// Padding within a framed rectangle (used by most widgets).
        /// </summary>
        public Vector2 FramePadding;
        /// <summary>
        /// Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets). 
        /// </summary>
        public float FrameRounding;
        /// <summary>
        /// Thickness of border around frames. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly)
        /// </summary>
        public float FrameBorderSize;
        /// <summary>
        /// Horizontal and vertical spacing between widgets/lines.
        /// </summary>
        public Vector2 ItemSpacing;
        /// <summary>
        /// Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label).
        /// </summary>
        public Vector2 ItemInnerSpacing;
        /// <summary>
        /// Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!
        /// </summary>
        public Vector2 TouchExtraPadding;
        /// <summary>
        /// Horizontal indentation when e.g. entering a tree node
        /// </summary>
        public float IndentSpacing;
        /// <summary>
        /// Minimum horizontal spacing between two columns
        /// </summary>
        public float ColumnsMinSpacing;
        /// <summary>
        /// Width of the vertical scrollbar, Height of the horizontal scrollbar
        /// </summary>
        public float ScrollbarSize;
        /// <summary>
        /// Radius of grab corners for scrollbar
        /// </summary>
        public float ScrollbarRounding;
        /// <summary>
        /// Minimum width/height of a grab box for slider/scrollbar
        /// </summary>
        public float GrabMinSize;
        /// <summary>
        /// Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
        /// </summary>
        public float GrabRounding;
        /// <summary>
        /// Alignment of button text when button is larger than text. Defaults to (0.5f,0.5f) for horizontally+vertically centered.
        /// </summary>
        public Vector2 ButtonTextAlign;
        /// <summary>
        /// Window positions are clamped to be visible within the display area by at least this amount. Only covers regular windows.
        /// </summary>
        public Vector2 DisplayWindowPadding;
        /// <summary>
        /// If you cannot see the edge of your screen (e.g. on a TV) increase the safe area padding. Covers popups/tooltips as well regular windows.
        /// </summary>
        public Vector2 DisplaySafeAreaPadding;
        /// <summary>
        /// Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
        /// </summary>
        public byte AntiAliasedLines;
        /// <summary>
        /// Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
        /// </summary>
        public byte AntiAliasedFill;
        /// <summary>
        /// Tessellation tolerance. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.
        /// </summary>
        public float CurveTessellationTol;
        public fixed float Colors[(int)ColorTarget.Count * 4];
    };
}
