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
        public uint _VtxCurrentIdx;
        public IntPtr _Data;
        public byte* _OwnerName;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector _ClipRectStack;
        public ImVector _TextureIdStack;
        public ImVector _Path;
        public ImDrawCmdHeader _CmdHeader;
        public ImDrawListSplitter _Splitter;
        public float _FringeScale;
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
        public ref uint _VtxCurrentIdx => ref Unsafe.AsRef<uint>(&NativePtr->_VtxCurrentIdx);
        public ref IntPtr _Data => ref Unsafe.AsRef<IntPtr>(&NativePtr->_Data);
        public NullTerminatedString _OwnerName => new NullTerminatedString(NativePtr->_OwnerName);
        public ImDrawVertPtr _VtxWritePtr => new ImDrawVertPtr(NativePtr->_VtxWritePtr);
        public IntPtr _IdxWritePtr { get => (IntPtr)NativePtr->_IdxWritePtr; set => NativePtr->_IdxWritePtr = (ushort*)value; }
        public ImVector<Vector4> _ClipRectStack => new ImVector<Vector4>(NativePtr->_ClipRectStack);
        public ImVector<IntPtr> _TextureIdStack => new ImVector<IntPtr>(NativePtr->_TextureIdStack);
        public ImVector<Vector2> _Path => new ImVector<Vector2>(NativePtr->_Path);
        public ref ImDrawCmdHeader _CmdHeader => ref Unsafe.AsRef<ImDrawCmdHeader>(&NativePtr->_CmdHeader);
        public ref ImDrawListSplitter _Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->_Splitter);
        public ref float _FringeScale => ref Unsafe.AsRef<float>(&NativePtr->_FringeScale);
        public int _CalcCircleAutoSegmentCount(float radius)
        {
            int ret = ImGuiNative.ImDrawList__CalcCircleAutoSegmentCount((ImDrawList*)(NativePtr), radius);
            return ret;
        }
        public void _ClearFreeMemory()
        {
            ImGuiNative.ImDrawList__ClearFreeMemory((ImDrawList*)(NativePtr));
        }
        public void _OnChangedClipRect()
        {
            ImGuiNative.ImDrawList__OnChangedClipRect((ImDrawList*)(NativePtr));
        }
        public void _OnChangedTextureID()
        {
            ImGuiNative.ImDrawList__OnChangedTextureID((ImDrawList*)(NativePtr));
        }
        public void _OnChangedVtxOffset()
        {
            ImGuiNative.ImDrawList__OnChangedVtxOffset((ImDrawList*)(NativePtr));
        }
        public void _PathArcToFastEx(Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step)
        {
            ImGuiNative.ImDrawList__PathArcToFastEx((ImDrawList*)(NativePtr), center, radius, a_min_sample, a_max_sample, a_step);
        }
        public void _PathArcToN(Vector2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList__PathArcToN((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void _PopUnusedDrawCmd()
        {
            ImGuiNative.ImDrawList__PopUnusedDrawCmd((ImDrawList*)(NativePtr));
        }
        public void _ResetForNewFrame()
        {
            ImGuiNative.ImDrawList__ResetForNewFrame((ImDrawList*)(NativePtr));
        }
        public void _TryMergeDrawCmds()
        {
            ImGuiNative.ImDrawList__TryMergeDrawCmds((ImDrawList*)(NativePtr));
        }
        public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierCubic((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierCubic((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierQuadratic((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness, num_segments);
        }
        public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierQuadratic((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness, num_segments);
        }
        public void AddCallback(IntPtr callback, IntPtr callback_data)
        {
            void* native_callback_data = (void*)callback_data.ToPointer();
            ImGuiNative.ImDrawList_AddCallback((ImDrawList*)(NativePtr), callback, native_callback_data);
        }
        public void AddCircle(Vector2 center, float radius, uint col)
        {
            int num_segments = 0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircle(Vector2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircle(Vector2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircleFilled(Vector2 center, float radius, uint col)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddCircleFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddCircleFilled(Vector2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddCircleFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddConvexPolyFilled(ref Vector2 points, int num_points, uint col)
        {
            fixed (Vector2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddConvexPolyFilled((ImDrawList*)(NativePtr), native_points, num_points, col);
            }
        }
        public void AddDrawCmd()
        {
            ImGuiNative.ImDrawList_AddDrawCmd((ImDrawList*)(NativePtr));
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max)
        {
            Vector2 uv_min = new Vector2();
            Vector2 uv_max = new Vector2(1, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min)
        {
            Vector2 uv_max = new Vector2(1, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max)
        {
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col)
        {
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            Vector2 uv1 = new Vector2();
            Vector2 uv2 = new Vector2(1, 0);
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1)
        {
            Vector2 uv2 = new Vector2(1, 0);
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2)
        {
            Vector2 uv3 = new Vector2(1, 1);
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3)
        {
            Vector2 uv4 = new Vector2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4)
        {
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
        {
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddImageRounded((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
        }
        public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_AddImageRounded((ImDrawList*)(NativePtr), user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
        }
        public void AddLine(Vector2 p1, Vector2 p2, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddLine((ImDrawList*)(NativePtr), p1, p2, col, thickness);
        }
        public void AddLine(Vector2 p1, Vector2 p2, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddLine((ImDrawList*)(NativePtr), p1, p2, col, thickness);
        }
        public void AddNgon(Vector2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddNgon((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddNgon(Vector2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddNgon((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddNgonFilled(Vector2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddNgonFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddPolyline(ref Vector2 points, int num_points, uint col, ImDrawFlags flags, float thickness)
        {
            fixed (Vector2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddPolyline((ImDrawList*)(NativePtr), native_points, num_points, col, flags, thickness);
            }
        }
        public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddQuad((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness);
        }
        public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddQuad((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness);
        }
        public void AddQuadFilled(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
        {
            ImGuiNative.ImDrawList_AddQuadFilled((ImDrawList*)(NativePtr), p1, p2, p3, p4, col);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness)
        {
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilledMultiColor(Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
        {
            ImGuiNative.ImDrawList_AddRectFilledMultiColor((ImDrawList*)(NativePtr), p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
        }
        public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddTriangle((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness);
        }
        public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddTriangle((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness);
        }
        public void AddTriangleFilled(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
        {
            ImGuiNative.ImDrawList_AddTriangleFilled((ImDrawList*)(NativePtr), p1, p2, p3, col);
        }
        public void ChannelsMerge()
        {
            ImGuiNative.ImDrawList_ChannelsMerge((ImDrawList*)(NativePtr));
        }
        public void ChannelsSetCurrent(int n)
        {
            ImGuiNative.ImDrawList_ChannelsSetCurrent((ImDrawList*)(NativePtr), n);
        }
        public void ChannelsSplit(int count)
        {
            ImGuiNative.ImDrawList_ChannelsSplit((ImDrawList*)(NativePtr), count);
        }
        public ImDrawListPtr CloneOutput()
        {
            ImDrawList* ret = ImGuiNative.ImDrawList_CloneOutput((ImDrawList*)(NativePtr));
            return new ImDrawListPtr(ret);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawList_destroy((ImDrawList*)(NativePtr));
        }
        public Vector2 GetClipRectMax()
        {
            Vector2 __retval;
            ImGuiNative.ImDrawList_GetClipRectMax(&__retval, (ImDrawList*)(NativePtr));
            return __retval;
        }
        public Vector2 GetClipRectMin()
        {
            Vector2 __retval;
            ImGuiNative.ImDrawList_GetClipRectMin(&__retval, (ImDrawList*)(NativePtr));
            return __retval;
        }
        public void PathArcTo(Vector2 center, float radius, float a_min, float a_max)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathArcTo((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void PathArcTo(Vector2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList_PathArcTo((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void PathArcToFast(Vector2 center, float radius, int a_min_of_12, int a_max_of_12)
        {
            ImGuiNative.ImDrawList_PathArcToFast((ImDrawList*)(NativePtr), center, radius, a_min_of_12, a_max_of_12);
        }
        public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierCubicCurveTo((ImDrawList*)(NativePtr), p2, p3, p4, num_segments);
        }
        public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierCubicCurveTo((ImDrawList*)(NativePtr), p2, p3, p4, num_segments);
        }
        public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo((ImDrawList*)(NativePtr), p2, p3, num_segments);
        }
        public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo((ImDrawList*)(NativePtr), p2, p3, num_segments);
        }
        public void PathClear()
        {
            ImGuiNative.ImDrawList_PathClear((ImDrawList*)(NativePtr));
        }
        public void PathFillConvex(uint col)
        {
            ImGuiNative.ImDrawList_PathFillConvex((ImDrawList*)(NativePtr), col);
        }
        public void PathLineTo(Vector2 pos)
        {
            ImGuiNative.ImDrawList_PathLineTo((ImDrawList*)(NativePtr), pos);
        }
        public void PathLineToMergeDuplicate(Vector2 pos)
        {
            ImGuiNative.ImDrawList_PathLineToMergeDuplicate((ImDrawList*)(NativePtr), pos);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathStroke(uint col)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PathStroke(uint col, ImDrawFlags flags)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PathStroke(uint col, ImDrawFlags flags, float thickness)
        {
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PopClipRect()
        {
            ImGuiNative.ImDrawList_PopClipRect((ImDrawList*)(NativePtr));
        }
        public void PopTextureID()
        {
            ImGuiNative.ImDrawList_PopTextureID((ImDrawList*)(NativePtr));
        }
        public void PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col)
        {
            ImGuiNative.ImDrawList_PrimQuadUV((ImDrawList*)(NativePtr), a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
        }
        public void PrimRect(Vector2 a, Vector2 b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRect((ImDrawList*)(NativePtr), a, b, col);
        }
        public void PrimRectUV(Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRectUV((ImDrawList*)(NativePtr), a, b, uv_a, uv_b, col);
        }
        public void PrimReserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimReserve((ImDrawList*)(NativePtr), idx_count, vtx_count);
        }
        public void PrimUnreserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimUnreserve((ImDrawList*)(NativePtr), idx_count, vtx_count);
        }
        public void PrimVtx(Vector2 pos, Vector2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimVtx((ImDrawList*)(NativePtr), pos, uv, col);
        }
        public void PrimWriteIdx(ushort idx)
        {
            ImGuiNative.ImDrawList_PrimWriteIdx((ImDrawList*)(NativePtr), idx);
        }
        public void PrimWriteVtx(Vector2 pos, Vector2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimWriteVtx((ImDrawList*)(NativePtr), pos, uv, col);
        }
        public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max)
        {
            byte intersect_with_current_clip_rect = 0;
            ImGuiNative.ImDrawList_PushClipRect((ImDrawList*)(NativePtr), clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
        }
        public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PushClipRect((ImDrawList*)(NativePtr), clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public void PushClipRectFullScreen()
        {
            ImGuiNative.ImDrawList_PushClipRectFullScreen((ImDrawList*)(NativePtr));
        }
        public void PushTextureID(IntPtr texture_id)
        {
            ImGuiNative.ImDrawList_PushTextureID((ImDrawList*)(NativePtr), texture_id);
        }
    }
}
