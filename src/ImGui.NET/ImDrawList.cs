using System;
using System.Runtime.InteropServices;

namespace ImGui
{
    // Draw command list
    // This is the low-level list of polygons that ImGui functions are filling. At the end of the frame, all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.
    // At the moment, each ImGui window contains its own ImDrawList but they could potentially be merged in the future.
    // If you want to add custom rendering within a window, you can use ImGui::GetWindowDrawList() to access the current draw list and add your own primitives.
    // You can interleave normal ImGui:: calls and adding primitives to the current draw list.
    // All positions are in screen coordinates (0,0=top-left, 1 pixel per unit). Primitives are always added to the list and not culled (culling is done at render time and at a higher-level by ImGui:: functions).
    // Note that this only gives you access to rendering polygons. If your intent is to create custom widgets and the publicly exposed functions/data aren't sufficient, you can add code in imgui_user.inl
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImDrawList
    {
        // This is what you have to render
        // ImVector<ImDrawCmd> CmdBuffer;          // Commands. Typically 1 command = 1 gpu draw call.
        // ImVector<ImDrawIdx> IdxBuffer;          // Index buffer. Each command consume ImDrawCmd::ElemCount of those
        // ImVector<ImDrawVert> VtxBuffer;          // Vertex buffer.

        /// <summary>
        /// ImVector(ImDrawCmd)
        /// </summary>
        public ImVector CmdBuffer;          // Commands. Typically 1 command = 1 gpu draw call.
        /// <summary>
        /// ImVector(ImDrawIdx)
        /// </summary>
        public ImVector IdxBuffer;          // Index buffer. Each command consume ImDrawCmd::ElemCount of those
        /// <summary>
        /// ImVector(ImDrawVert)
        /// </summary>
        public ImVector VtxBuffer;          // Vertex buffer.

        // [Internal, used while building lists]
        public IntPtr _OwnerName;         // Pointer to owner window's name (if any) for debugging
        public uint _VtxCurrentIdx;     // [Internal] == VtxBuffer.Size

        //ImDrawVert* _VtxWritePtr;       // [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)
        //ImDrawIdx* _IdxWritePtr;       // [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)

        public IntPtr _VtxWritePtr;       // [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)
        public IntPtr _IdxWritePtr;       // [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)

        //ImVector<ImVec4> _ClipRectStack;     // [Internal]
        //ImVector<ImTextureID> _TextureIdStack;    // [Internal]
        //ImVector<ImVec2> _Path;              // [Internal] current path building

        public ImVector _ClipRectStack;     // [Internal]
        public ImVector _TextureIdStack;    // [Internal]
        public ImVector _Path;              // [Internal] current path building


        public int _ChannelsCurrent;   // [Internal] current channel number (0)
        public int _ChannelsCount;     // [Internal] number of active channels (1+)

        //ImVector<ImDrawChannel> _Channels;          // [Internal] draw channels for columns API (not resized down so _ChannelsCount may be smaller than _Channels.Size)
        public ImVector _Channels;          // [Internal] draw channels for columns API (not resized down so _ChannelsCount may be smaller than _Channels.Size)

        /*
        ImDrawList() { _OwnerName = NULL; Clear(); }
        ~ImDrawList() { ClearFreeMemory(); }
        IMGUI_API void Clear();
        IMGUI_API void ClearFreeMemory();
        IMGUI_API void PushClipRect(const ImVec4& clip_rect);          // Scissoring. The values are x1, y1, x2, y2.
        IMGUI_API void PushClipRectFullScreen();
        IMGUI_API void PopClipRect();
        IMGUI_API void PushTextureID(const ImTextureID& texture_id);
        IMGUI_API void PopTextureID();

        // Primitives
        IMGUI_API void AddLine(const ImVec2& a, const ImVec2& b, ImU32 col, float thickness = 1.0f);
        IMGUI_API void AddRect(const ImVec2& a, const ImVec2& b, ImU32 col, float rounding = 0.0f, int rounding_corners = 0x0F);
        IMGUI_API void AddRectFilled(const ImVec2& a, const ImVec2& b, ImU32 col, float rounding = 0.0f, int rounding_corners = 0x0F);
        IMGUI_API void AddRectFilledMultiColor(const ImVec2& a, const ImVec2& b, ImU32 col_upr_left, ImU32 col_upr_right, ImU32 col_bot_right, ImU32 col_bot_left);
        IMGUI_API void AddTriangleFilled(const ImVec2& a, const ImVec2& b, const ImVec2& c, ImU32 col);
        IMGUI_API void AddCircle(const ImVec2& centre, float radius, ImU32 col, int num_segments = 12);
        IMGUI_API void AddCircleFilled(const ImVec2& centre, float radius, ImU32 col, int num_segments = 12);
        IMGUI_API void AddText(const ImVec2& pos, ImU32 col, const char* text_begin, const char* text_end = NULL);
        IMGUI_API void AddText(const ImFont* font, float font_size, const ImVec2& pos, ImU32 col, const char* text_begin, const char* text_end = NULL, float wrap_width = 0.0f, const ImVec4* cpu_fine_clip_rect = NULL);
        IMGUI_API void AddImage(ImTextureID user_texture_id, const ImVec2& a, const ImVec2& b, const ImVec2& uv0 = ImVec2(0,0), const ImVec2& uv1 = ImVec2(1,1), ImU32 col = 0xFFFFFFFF);
        IMGUI_API void AddPolyline(const ImVec2* points, const int num_points, ImU32 col, bool closed, float thickness, bool anti_aliased);
        IMGUI_API void AddConvexPolyFilled(const ImVec2* points, const int num_points, ImU32 col, bool anti_aliased);
        IMGUI_API void AddBezierCurve(const ImVec2& pos0, const ImVec2& cp0, const ImVec2& cp1, const ImVec2& pos1, ImU32 col, float thickness, int num_segments = 0);

        // Stateful path API, add points then finish with PathFill() or PathStroke()
        inline void PathClear() { _Path.resize(0); }
        inline void PathLineTo(const ImVec2& pos)                               { _Path.push_back(pos); }
        inline void PathLineToMergeDuplicate(const ImVec2& pos) { if (_Path.Size == 0 || _Path[_Path.Size - 1].x != pos.x || _Path[_Path.Size - 1].y != pos.y) _Path.push_back(pos); }
        inline void PathFill(ImU32 col) { AddConvexPolyFilled(_Path.Data, _Path.Size, col, true); PathClear(); }
        inline void PathStroke(ImU32 col, bool closed, float thickness = 1.0f) { AddPolyline(_Path.Data, _Path.Size, col, closed, thickness, true); PathClear(); }
        IMGUI_API void PathArcTo(const ImVec2& centre, float radius, float a_min, float a_max, int num_segments = 10);
        IMGUI_API void PathArcToFast(const ImVec2& centre, float radius, int a_min_of_12, int a_max_of_12);                 // Use precomputed angles for a 12 steps circle
        IMGUI_API void PathBezierCurveTo(const ImVec2& p1, const ImVec2& p2, const ImVec2& p3, int num_segments = 0);
        IMGUI_API void PathRect(const ImVec2& rect_min, const ImVec2& rect_max, float rounding = 0.0f, int rounding_corners = 0x0F);

        // Channels
        // - Use to simulate layers. By switching channels to can render out-of-order (e.g. submit foreground primitives before background primitives)
        // - Use to minimize draw calls (e.g. if going back-and-forth between multiple non-overlapping clipping rectangles, prefer to append into separate channels then merge at the end)
        IMGUI_API void ChannelsSplit(int channels_count);
        IMGUI_API void ChannelsMerge();
        IMGUI_API void ChannelsSetCurrent(int channel_index);

        // Advanced
        IMGUI_API void AddCallback(ImDrawCallback callback, void* callback_data);  // Your rendering function must check for 'UserCallback' in ImDrawCmd and call the function instead of rendering triangles.
        IMGUI_API void AddDrawCmd();                                               // This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible

        // Internal helpers
        // NB: all primitives needs to be reserved via PrimReserve() beforehand!
        IMGUI_API void PrimReserve(int idx_count, int vtx_count);
        IMGUI_API void PrimRect(const ImVec2& a, const ImVec2& b, ImU32 col);
        IMGUI_API void PrimRectUV(const ImVec2& a, const ImVec2& b, const ImVec2& uv_a, const ImVec2& uv_b, ImU32 col);
        inline void PrimVtx(const ImVec2& pos, const ImVec2& uv, ImU32 col) { PrimWriteIdx((ImDrawIdx)_VtxCurrentIdx); PrimWriteVtx(pos, uv, col); }
        inline void PrimWriteVtx(const ImVec2& pos, const ImVec2& uv, ImU32 col) { _VtxWritePtr->pos = pos; _VtxWritePtr->uv = uv; _VtxWritePtr->col = col; _VtxWritePtr++; _VtxCurrentIdx++; }
        inline void PrimWriteIdx(ImDrawIdx idx) { *_IdxWritePtr = idx; _IdxWritePtr++; }
        IMGUI_API void UpdateClipRect();
        IMGUI_API void UpdateTextureID();
    */
    };
}
