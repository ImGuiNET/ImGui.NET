using System.Numerics;

namespace ImGuiNET
{
    public unsafe class Style
    {
        private readonly NativeStyle* _stylePtr;

        public Style(NativeStyle* style)
        {
            _stylePtr = style;
        }

        /// <summary>
        /// Global alpha applies to everything in ImGui.
        /// </summary>
        public float Alpha
        {
            get { return _stylePtr->Alpha; }
            set { _stylePtr->Alpha = value; }
        }

        /// <summary>
        /// Padding within a window.
        /// </summary>
        public Vector2 WindowPadding
        {
            get { return _stylePtr->WindowPadding; }
            set { _stylePtr->WindowPadding = value; }
        }

        /// <summary>
        /// Minimum window size.
        /// </summary>
        public Vector2 WindowMinSize
        {
            get { return _stylePtr->WindowMinSize; }
            set { _stylePtr->WindowMinSize = value; }
        }

        /// <summary>
        /// Radius of window corners rounding. Set to 0.0f to have rectangular windows.
        /// </summary>
        public float WindowRounding
        {
            get { return _stylePtr->WindowRounding; }
            set { _stylePtr->WindowRounding = value; }
        }

        /// <summary>
        /// Alignment for title bar text.
        /// </summary>
        public Align WindowTitleAlign
        {
            get { return _stylePtr->WindowTitleAlign; }
            set { _stylePtr->WindowTitleAlign = value; }
        }

        /// <summary>
        /// Radius of child window corners rounding. Set to 0.0f to have rectangular windows.
        /// </summary>
        public float ChildWindowRounding
        {
            get { return _stylePtr->ChildWindowRounding; }
            set { _stylePtr->ChildWindowRounding = value; }
        }

        /// <summary>
        /// Padding within a framed rectangle (used by most widgets).
        /// </summary>
        public Vector2 FramePadding
        {
            get { return _stylePtr->FramePadding; }
            set { _stylePtr->FramePadding = value; }
        }

        /// <summary>
        /// Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets). 
        /// </summary>
        public float FrameRounding
        {
            get { return _stylePtr->FrameRounding; }
            set { _stylePtr->FrameRounding = value; }
        }

        /// <summary>
        /// Horizontal and vertical spacing between widgets/lines.
        /// </summary>
        public Vector2 ItemSpacing
        {
            get { return _stylePtr->ItemSpacing; }
            set { _stylePtr->ItemSpacing = value; }
        }

        /// <summary>
        /// Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label).
        /// </summary>
        public Vector2 ItemInnerSpacing
        {
            get { return _stylePtr->ItemInnerSpacing; }
            set { _stylePtr->ItemInnerSpacing = value; }
        }

        /// <summary>
        /// Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!
        /// </summary>
        public Vector2 TouchExtraPadding
        {
            get { return _stylePtr->TouchExtraPadding; }
            set { _stylePtr->TouchExtraPadding = value; }
        }

        /// <summary>
        /// Default alpha of window background, if not specified in ImGui::Begin().
        /// </summary>
        public float WindowFillAlphaDefault
        {
            get { return _stylePtr->WindowFillAlphaDefault; }
            set { _stylePtr->WindowFillAlphaDefault = value; }
        }

        /// <summary>
        /// Horizontal indentation when e.g. entering a tree node
        /// </summary>
        public float IndentSpacing
        {
            get { return _stylePtr->IndentSpacing; }
            set { _stylePtr->IndentSpacing = value; }
        }

        /// <summary>
        /// Minimum horizontal spacing between two columns
        /// </summary>
        public float ColumnsMinSpacing
        {
            get { return _stylePtr->ColumnsMinSpacing; }
            set { _stylePtr->ColumnsMinSpacing = value; }
        }

        /// <summary>
        /// Width of the vertical scrollbar, Height of the horizontal scrollbar
        /// </summary>
        public float ScrollbarSize
        {
            get { return _stylePtr->ScrollbarSize; }
            set { _stylePtr->ScrollbarSize = value; }
        }

        /// <summary>
        /// Radius of grab corners for scrollbar
        /// </summary>
        public float ScrollbarRounding
        {
            get { return _stylePtr->ScrollbarRounding; }
            set { _stylePtr->ScrollbarRounding = value; }
        }

        /// <summary>
        /// Minimum width/height of a grab box for slider/scrollbar
        /// </summary>
        public float GrabMinSize
        {
            get { return _stylePtr->GrabMinSize; }
            set { _stylePtr->GrabMinSize = value; }
        }

        /// <summary>
        /// Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
        /// </summary>
        public float GrabRounding
        {
            get { return _stylePtr->GrabRounding; }
            set { _stylePtr->GrabRounding = value; }
        }

        /// <summary>
        /// Window positions are clamped to be visible within the display area by at least this amount. Only covers regular windows.
        /// </summary>
        public Vector2 DisplayWindowPadding
        {
            get { return _stylePtr->DisplayWindowPadding; }
            set { _stylePtr->DisplayWindowPadding = value; }
        }

        /// <summary>
        /// If you cannot see the edge of your screen (e.g. on a TV) increase the safe area padding. Covers popups/tooltips as well regular windows.
        /// </summary>
        public Vector2 DisplaySafeAreaPadding
        {
            get { return _stylePtr->DisplaySafeAreaPadding; }
            set { _stylePtr->DisplaySafeAreaPadding = value; }
        }

        /// <summary>
        /// Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
        /// </summary>
        public bool AntiAliasedLines
        {
            get { return _stylePtr->AntiAliasedLines == 1; }
            set { _stylePtr->AntiAliasedLines = value ? (byte)1 : (byte)0; }
        }

        /// <summary>
        /// Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
        /// </summary>
        public bool AntiAliasedShapes
        {
            get { return _stylePtr->AntiAliasedShapes == 1; }
            set { _stylePtr->AntiAliasedShapes = value ? (byte)1 : (byte)0; }
        }

        /// <summary>
        /// Tessellation tolerance. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.
        /// </summary>
        public float CurveTessellationTolerance
        {
            get { return _stylePtr->CurveTessellationTol; }
            set { _stylePtr->CurveTessellationTol = value; }
        }

        /// <summary>
        /// Gets the current style color for the given UI element type.
        /// </summary>
        /// <param name="target">The type of UI element.</param>
        /// <returns>The element's color as currently configured.</returns>
        public float GetColor(ColorTarget target) => _stylePtr->Colors[(int)target];

        /// <summary>
        /// Sets the style color for a particular UI element type.
        /// </summary>
        /// <param name="target">The type of UI element.</param>
        /// <param name="value">The new color.</param>
        public void SetColor(ColorTarget target, float value) => _stylePtr->Colors[(int)target] = value;
    }
}
