using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImVec2 = System.Numerics.Vector2;
using ImVec4 = System.Numerics.Vector4;
using ImGuiAlign = System.Int32;
using System.Runtime.InteropServices;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct ImGuiStyle
    {
        float Alpha;                      // Global alpha applies to everything in ImGui
        ImVec2 WindowPadding;              // Padding within a window
        ImVec2 WindowMinSize;              // Minimum window size
        float WindowRounding;             // Radius of window corners rounding. Set to 0.0f to have rectangular windows
        ImGuiAlign WindowTitleAlign;           // Alignment for title bar text
        float ChildWindowRounding;        // Radius of child window corners rounding. Set to 0.0f to have rectangular windows
        ImVec2 FramePadding;               // Padding within a framed rectangle (used by most widgets)
        float FrameRounding;              // Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets).
        ImVec2 ItemSpacing;                // Horizontal and vertical spacing between widgets/lines
        ImVec2 ItemInnerSpacing;           // Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label)
        ImVec2 TouchExtraPadding;          // Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!
        float WindowFillAlphaDefault;     // Default alpha of window background, if not specified in ImGui::Begin()
        float IndentSpacing;              // Horizontal indentation when e.g. entering a tree node
        float ColumnsMinSpacing;          // Minimum horizontal spacing between two columns
        float ScrollbarSize;              // Width of the vertical scrollbar, Height of the horizontal scrollbar
        float ScrollbarRounding;          // Radius of grab corners for scrollbar
        float GrabMinSize;                // Minimum width/height of a grab box for slider/scrollbar
        float GrabRounding;               // Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
        ImVec2 DisplayWindowPadding;       // Window positions are clamped to be visible within the display area by at least this amount. Only covers regular windows.
        ImVec2 DisplaySafeAreaPadding;     // If you cannot see the edge of your screen (e.g. on a TV) increase the safe area padding. Covers popups/tooltips as well regular windows.
        bool AntiAliasedLines;           // Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
        bool AntiAliasedShapes;          // Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
        float CurveTessellationTol;       // Tessellation tolerance. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.
        //fixed ImVec4 Colors[Constants.ImGuiCol.ImGuiCol_COUNT];
        fixed float Colors[Constants.ImGuiCol.ImGuiCol_COUNT * 4];

        /*
        IMGUI_API ImGuiStyle();
        */
    };
}
