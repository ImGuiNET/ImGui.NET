using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawList
    {
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
        public ImVector VtxBuffer;
        public ImDrawListFlags Flags;
        public IntPtr _Data;
        public byte* _OwnerName;
        public uint _VtxCurrentOffset;
        public uint _VtxCurrentIdx;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector _ClipRectStack;
        public ImVector _TextureIdStack;
        public ImVector _Path;
        public ImDrawListSplitter _Splitter;
    }
    public unsafe partial struct ImDrawListPtr
    {
        public ImDrawList* NativePtr { get; }
        public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
        public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
        public static implicit operator ImDrawListPtr(ImDrawList* nativePtr) => new ImDrawListPtr(nativePtr);
        public static implicit operator ImDrawList* (ImDrawListPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawListPtr(IntPtr nativePtr) => new ImDrawListPtr(nativePtr);
        public ImPtrVector<ImDrawCmdPtr> CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->CmdBuffer, Unsafe.SizeOf<ImDrawCmd>());
        public ImVector<ushort> IdxBuffer => new ImVector<ushort>(NativePtr->IdxBuffer);
        public ImPtrVector<ImDrawVertPtr> VtxBuffer => new ImPtrVector<ImDrawVertPtr>(NativePtr->VtxBuffer, Unsafe.SizeOf<ImDrawVert>());
        public ref ImDrawListFlags Flags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->Flags);
        public ref IntPtr _Data => ref Unsafe.AsRef<IntPtr>(&NativePtr->_Data);
        public NullTerminatedString _OwnerName => new NullTerminatedString(NativePtr->_OwnerName);
        public ref uint _VtxCurrentOffset => ref Unsafe.AsRef<uint>(&NativePtr->_VtxCurrentOffset);
        public ref uint _VtxCurrentIdx => ref Unsafe.AsRef<uint>(&NativePtr->_VtxCurrentIdx);
        public ImDrawVertPtr _VtxWritePtr => new ImDrawVertPtr(NativePtr->_VtxWritePtr);
        public IntPtr _IdxWritePtr { get => (IntPtr)NativePtr->_IdxWritePtr; set => NativePtr->_IdxWritePtr = (ushort*)value; }
        public ImVector<Vector4> _ClipRectStack => new ImVector<Vector4>(NativePtr->_ClipRectStack);
        public ImVector<IntPtr> _TextureIdStack => new ImVector<IntPtr>(NativePtr->_TextureIdStack);
        public ImVector<Vector2> _Path => new ImVector<Vector2>(NativePtr->_Path);
        public ref ImDrawListSplitter _Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->_Splitter);
        public void AddBezierCurve(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierCurve(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierCurve(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierCurve(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddCallback(IntPtr callback, IntPtr callback_data)
        {
            void* native_callback_data = (void*)callback_data.ToPointer();
            ImGuiNative.ImDrawList_AddCallback(NativePtr, callback, native_callback_data);
        }
        public void AddCircle(Vector2 center, float radius, uint col)
        {
            int num_segments = 12;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircle(Vector2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircle(Vector2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddCircleFilled(Vector2 center, float radius, uint col)
        {
            int num_segments = 12;
            ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddCircleFilled(Vector2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddConvexPolyFilled(ref Vector2 points, int num_points, uint col)
        {
            fixed (Vector2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddConvexPolyFilled(NativePtr, native_points, num_points, col);
            }
        }
        public void AddDrawCmd()
        {
            ImGuiNative.ImDrawList_AddDrawCmd(NativePtr);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max)
        {
            Vector2 uv_min = new Vector2();
            Vector2 uv_max = new Vector2(1, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min)
        {
            Vector2 uv_max = new Vector2(1, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max)
        {
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col)
        {
            ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            Vector2 uv1 = new Vector2();
            Vector2 uv2 = new Vector2(1, 0);
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1)
        {
            Vector2 uv2 = new Vector2(1, 0);
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2)
        {
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3)
        {
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4)
        {
            uint col = 0xFFFFFFFF;
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
        {
            ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners);
        }
        public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners);
        }
        public void AddLine(Vector2 p1, Vector2 p2, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddLine(NativePtr, p1, p2, col, thickness);
        }
        public void AddLine(Vector2 p1, Vector2 p2, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddLine(NativePtr, p1, p2, col, thickness);
        }
        public void AddNgon(Vector2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddNgon(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddNgon(Vector2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddNgon(NativePtr, center, radius, col, num_segments, thickness);
        }
        public void AddNgonFilled(Vector2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddNgonFilled(NativePtr, center, radius, col, num_segments);
        }
        public void AddPolyline(ref Vector2 points, int num_points, uint col, bool closed, float thickness)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            fixed (Vector2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddPolyline(NativePtr, native_points, num_points, col, native_closed, thickness);
            }
        }
        public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
        }
        public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
        }
        public void AddQuadFilled(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
        {
            ImGuiNative.ImDrawList_AddQuadFilled(NativePtr, p1, p2, p3, p4, col);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness)
        {
            ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col, rounding, rounding_corners, thickness);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col, rounding, rounding_corners);
        }
        public void AddRectFilledMultiColor(Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
        {
            ImGuiNative.ImDrawList_AddRectFilledMultiColor(NativePtr, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
        }
        public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddTriangle(NativePtr, p1, p2, p3, col, thickness);
        }
        public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddTriangle(NativePtr, p1, p2, p3, col, thickness);
        }
        public void AddTriangleFilled(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
        {
            ImGuiNative.ImDrawList_AddTriangleFilled(NativePtr, p1, p2, p3, col);
        }
        public void ChannelsMerge()
        {
            ImGuiNative.ImDrawList_ChannelsMerge(NativePtr);
        }
        public void ChannelsSetCurrent(int n)
        {
            ImGuiNative.ImDrawList_ChannelsSetCurrent(NativePtr, n);
        }
        public void ChannelsSplit(int count)
        {
            ImGuiNative.ImDrawList_ChannelsSplit(NativePtr, count);
        }
        public void Clear()
        {
            ImGuiNative.ImDrawList_Clear(NativePtr);
        }
        public void ClearFreeMemory()
        {
            ImGuiNative.ImDrawList_ClearFreeMemory(NativePtr);
        }
        public ImDrawListPtr CloneOutput()
        {
            ImDrawList* ret = ImGuiNative.ImDrawList_CloneOutput(NativePtr);
            return new ImDrawListPtr(ret);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawList_destroy(NativePtr);
        }
        public Vector2 GetClipRectMax()
        {
            Vector2 ret = ImGuiNative.ImDrawList_GetClipRectMax(NativePtr);
            return ret;
        }
        public Vector2 GetClipRectMin()
        {
            Vector2 ret = ImGuiNative.ImDrawList_GetClipRectMin(NativePtr);
            return ret;
        }
        public void PathArcTo(Vector2 center, float radius, float a_min, float a_max)
        {
            int num_segments = 10;
            ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
        }
        public void PathArcTo(Vector2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
        }
        public void PathArcToFast(Vector2 center, float radius, int a_min_of_12, int a_max_of_12)
        {
            ImGuiNative.ImDrawList_PathArcToFast(NativePtr, center, radius, a_min_of_12, a_max_of_12);
        }
        public void PathBezierCurveTo(Vector2 p2, Vector2 p3, Vector2 p4)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierCurveTo(NativePtr, p2, p3, p4, num_segments);
        }
        public void PathBezierCurveTo(Vector2 p2, Vector2 p3, Vector2 p4, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierCurveTo(NativePtr, p2, p3, p4, num_segments);
        }
        public void PathClear()
        {
            ImGuiNative.ImDrawList_PathClear(NativePtr);
        }
        public void PathFillConvex(uint col)
        {
            ImGuiNative.ImDrawList_PathFillConvex(NativePtr, col);
        }
        public void PathLineTo(Vector2 pos)
        {
            ImGuiNative.ImDrawList_PathLineTo(NativePtr, pos);
        }
        public void PathLineToMergeDuplicate(Vector2 pos)
        {
            ImGuiNative.ImDrawList_PathLineToMergeDuplicate(NativePtr, pos);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max)
        {
            float rounding = 0.0f;
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding)
        {
            ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All;
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners)
        {
            ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, rounding_corners);
        }
        public void PathStroke(uint col, bool closed)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke(NativePtr, col, native_closed, thickness);
        }
        public void PathStroke(uint col, bool closed, float thickness)
        {
            byte native_closed = closed ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PathStroke(NativePtr, col, native_closed, thickness);
        }
        public void PopClipRect()
        {
            ImGuiNative.ImDrawList_PopClipRect(NativePtr);
        }
        public void PopTextureID()
        {
            ImGuiNative.ImDrawList_PopTextureID(NativePtr);
        }
        public void PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col)
        {
            ImGuiNative.ImDrawList_PrimQuadUV(NativePtr, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
        }
        public void PrimRect(Vector2 a, Vector2 b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRect(NativePtr, a, b, col);
        }
        public void PrimRectUV(Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRectUV(NativePtr, a, b, uv_a, uv_b, col);
        }
        public void PrimReserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimReserve(NativePtr, idx_count, vtx_count);
        }
        public void PrimUnreserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimUnreserve(NativePtr, idx_count, vtx_count);
        }
        public void PrimVtx(Vector2 pos, Vector2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimVtx(NativePtr, pos, uv, col);
        }
        public void PrimWriteIdx(ushort idx)
        {
            ImGuiNative.ImDrawList_PrimWriteIdx(NativePtr, idx);
        }
        public void PrimWriteVtx(Vector2 pos, Vector2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimWriteVtx(NativePtr, pos, uv, col);
        }
        public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max)
        {
            byte intersect_with_current_clip_rect = 0;
            ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
        }
        public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public void PushClipRectFullScreen()
        {
            ImGuiNative.ImDrawList_PushClipRectFullScreen(NativePtr);
        }
        public void PushTextureID(IntPtr texture_id)
        {
            ImGuiNative.ImDrawList_PushTextureID(NativePtr, texture_id);
        }
        public void UpdateClipRect()
        {
            ImGuiNative.ImDrawList_UpdateClipRect(NativePtr);
        }
        public void UpdateTextureID()
        {
            ImGuiNative.ImDrawList_UpdateTextureID(NativePtr);
        }
    }
}
