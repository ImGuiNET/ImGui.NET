using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImPlotNET
{
    public static unsafe partial class ImPlotNative
    {
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_AddColormap_Vec4Ptr(byte* name, Vector4* cols, int size, byte qual);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_AddColormap_U32Ptr(byte* name, uint* cols, int size, byte qual);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotation_Bool(double x, double y, Vector4 col, Vector2 pix_offset, byte clamp, byte round);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotation_Str(double x, double y, Vector4 col, Vector2 pix_offset, byte clamp, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginAlignedPlots(byte* group_id, byte vertical);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceItem(byte* label_id, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourcePlot(ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetAxis(ImAxis axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetLegend();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetPlot();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginLegendPopup(byte* label_id, ImGuiMouseButton mouse_button);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginPlot(byte* title_id, Vector2 size, ImPlotFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginSubplots(byte* title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, float* row_ratios, float* col_ratios);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_BustColorCache(byte* plot_title_id);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CancelPlotSelection();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ColormapButton(byte* label, Vector2 size, ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ColormapIcon(ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ColormapScale(byte* label, double scale_min, double scale_max, Vector2 size, byte* format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ColormapSlider(byte* label, float* t, Vector4* @out, byte* format, ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_CreateContext();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_DestroyContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineX(int id, double* x, Vector4 col, float thickness, ImPlotDragToolFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineY(int id, double* y, Vector4 col, float thickness, ImPlotDragToolFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragPoint(int id, double* x, double* y, Vector4 col, float size, ImPlotDragToolFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragRect(int id, double* x1, double* y1, double* x2, double* y2, Vector4 col, ImPlotDragToolFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndAlignedPlots();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropSource();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropTarget();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndLegendPopup();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndPlot();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndSubplots();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetColormapColor(Vector4* pOut, int idx, ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetColormapCount();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_GetColormapIndex(byte* name);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetColormapName(ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetColormapSize(ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_GetCurrentContext();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotInputMap* ImPlot_GetInputMap();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetLastItemColor(Vector4* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetMarkerName(ImPlotMarker idx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImPlot_GetPlotDrawList();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect ImPlot_GetPlotLimits(ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotMousePos(ImPlotPoint* pOut, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotPos(Vector2* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect ImPlot_GetPlotSelection(ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotSize(Vector2* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlot_GetStyle();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetStyleColorName(ImPlotCol idx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_HideNextItem(byte hidden, ImPlotCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsAxisHovered(ImAxis axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsLegendEntryHovered(byte* label_id);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotHovered();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotSelected();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsSubplotsHovered();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_Vec4(Vector4 col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_U32(uint col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MapInputDefault(ImPlotInputMap* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MapInputReverse(ImPlotInputMap* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_NextColormapColor(Vector4* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Vec2(ImPlotPoint* pOut, Vector2 pix, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Float(ImPlotPoint* pOut, float x, float y, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_FloatPtr(byte** label_ids, float* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_doublePtr(byte** label_ids, double* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S8Ptr(byte** label_ids, sbyte* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U8Ptr(byte** label_ids, byte* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S16Ptr(byte** label_ids, short* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U16Ptr(byte** label_ids, ushort* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S32Ptr(byte** label_ids, int* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U32Ptr(byte** label_ids, uint* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S64Ptr(byte** label_ids, long* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U64Ptr(byte** label_ids, ulong* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrInt(byte* label_id, float* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrInt(byte* label_id, double* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrInt(byte* label_id, sbyte* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrInt(byte* label_id, byte* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrInt(byte* label_id, short* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrInt(byte* label_id, ushort* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrInt(byte* label_id, int* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrInt(byte* label_id, uint* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrInt(byte* label_id, long* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrInt(byte* label_id, ulong* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsG(byte* label_id, IntPtr getter, void* data, int count, double bar_size, ImPlotBarsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_FloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_doublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalG(byte* label_id, IntPtr getter, void* data, int count, ImPlotDigitalFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDummy(byte* label_id, ImPlotDummyFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_FloatPtr(byte* label_id, float* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_doublePtr(byte* label_id, double* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S8Ptr(byte* label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U8Ptr(byte* label_id, byte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S16Ptr(byte* label_id, short* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U16Ptr(byte* label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S32Ptr(byte* label_id, int* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U32Ptr(byte* label_id, uint* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S64Ptr(byte* label_id, long* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U64Ptr(byte* label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_FloatPtr(byte* label_id, float* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_doublePtr(byte* label_id, double* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S8Ptr(byte* label_id, sbyte* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U8Ptr(byte* label_id, byte* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S16Ptr(byte* label_id, short* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U16Ptr(byte* label_id, ushort* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S32Ptr(byte* label_id, int* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U32Ptr(byte* label_id, uint* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S64Ptr(byte* label_id, long* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U64Ptr(byte* label_id, ulong* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_FloatPtr(byte* label_id, float* xs, float* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_doublePtr(byte* label_id, double* xs, double* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S16Ptr(byte* label_id, short* xs, short* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S32Ptr(byte* label_id, int* xs, int* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S64Ptr(byte* label_id, long* xs, long* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotImage(byte* label_id, IntPtr user_texture_id, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col, ImPlotImageFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_FloatPtr(byte* label_id, float* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_doublePtr(byte* label_id, double* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S8Ptr(byte* label_id, sbyte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U8Ptr(byte* label_id, byte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S16Ptr(byte* label_id, short* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U16Ptr(byte* label_id, ushort* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S32Ptr(byte* label_id, int* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U32Ptr(byte* label_id, uint* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S64Ptr(byte* label_id, long* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U64Ptr(byte* label_id, ulong* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineG(byte* label_id, IntPtr getter, void* data, int count, ImPlotLineFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_FloatPtr(byte** label_ids, float* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_doublePtr(byte** label_ids, double* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S8Ptr(byte** label_ids, sbyte* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U8Ptr(byte** label_ids, byte* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S16Ptr(byte** label_ids, short* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U16Ptr(byte** label_ids, ushort* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S32Ptr(byte** label_ids, int* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U32Ptr(byte** label_ids, uint* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S64Ptr(byte** label_ids, long* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U64Ptr(byte** label_ids, ulong* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterG(byte* label_id, IntPtr getter, void* data, int count, ImPlotScatterFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrInt(byte* label_id, float* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrInt(byte* label_id, double* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrInt(byte* label_id, sbyte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrInt(byte* label_id, byte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrInt(byte* label_id, short* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrInt(byte* label_id, ushort* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrInt(byte* label_id, int* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrInt(byte* label_id, uint* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrInt(byte* label_id, long* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrInt(byte* label_id, ulong* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrInt(byte* label_id, short* xs, short* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrInt(byte* label_id, long* xs, long* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys1, float* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys1, double* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys1, byte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys1, short* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys1, int* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys1, uint* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys1, long* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedG(byte* label_id, IntPtr getter1, void* data1, IntPtr getter2, void* data2, int count, ImPlotShadedFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsG(byte* label_id, IntPtr getter, void* data, int count, ImPlotStairsFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrInt(byte* label_id, float* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrInt(byte* label_id, double* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrInt(byte* label_id, sbyte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrInt(byte* label_id, byte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrInt(byte* label_id, short* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrInt(byte* label_id, ushort* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrInt(byte* label_id, int* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrInt(byte* label_id, uint* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrInt(byte* label_id, long* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrInt(byte* label_id, ulong* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotText(byte* text, double x, double y, Vector2 pix_offset, ImPlotTextFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_PlotPoInt(Vector2* pOut, ImPlotPoint plt, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_double(Vector2* pOut, double x, double y, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopColormap(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopPlotClipRect();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleColor(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleVar(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_PlotColormap(ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_Str(byte* name);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushPlotClipRect(float expand);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColor_U32(ImPlotCol idx, uint col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColor_Vec4(ImPlotCol idx, Vector4 col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Float(ImPlotStyleVar idx, float val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Int(ImPlotStyleVar idx, int val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Vec2(ImPlotStyleVar idx, Vector2 val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SampleColormap(Vector4* pOut, float t, ImPlotColormap cmap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetAxes(ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetAxis(ImAxis axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetCurrentContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetImGuiContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxesToFit();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisLinks(ImAxis axis, double* link_min, double* link_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisToFit(ImAxis axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextErrorBarStyle(Vector4 col, float size, float weight);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextFillStyle(Vector4 col, float alpha_mod);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextLineStyle(Vector4 col, float weight);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxes(byte* x_label, byte* y_label, ImPlotAxisFlags x_flags, ImPlotAxisFlags y_flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxis(ImAxis axis, byte* label, ImPlotAxisFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisFormat_Str(ImAxis axis, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisFormat_PlotFormatter(ImAxis axis, IntPtr formatter, void* data);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLimitsConstraints(ImAxis axis, double v_min, double v_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLinks(ImAxis axis, double* link_min, double* link_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisScale_PlotScale(ImAxis axis, ImPlotScale scale);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisScale_PlotTransform(ImAxis axis, IntPtr forward, IntPtr inverse, void* data);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisTicks_doublePtr(ImAxis axis, double* values, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisTicks_double(ImAxis axis, double v_min, double v_max, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisZoomConstraints(ImAxis axis, double z_min, double z_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupFinish();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowColormapSelector(byte* label);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowDemoWindow(byte* p_open);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowInputMapSelector(byte* label);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowMetricsWindow(byte* p_popen);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowStyleEditor(ImPlotStyle* @ref);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowStyleSelector(byte* label);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowUserGuide();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsAuto(ImPlotStyle* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsClassic(ImPlotStyle* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsDark(ImPlotStyle* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsLight(ImPlotStyle* dst);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagX_Bool(double x, Vector4 col, byte round);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagX_Str(double x, Vector4 col, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagY_Bool(double y, Vector4 col, byte round);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagY_Str(double y, Vector4 col, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotInputMap_destroy(ImPlotInputMap* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotInputMap* ImPlotInputMap_ImPlotInputMap();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPoint_destroy(ImPlotPoint* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Nil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_double(double _x, double _y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Vec2(Vector2 p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotRange_Clamp(ImPlotRange* self, double value);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRange_Contains(ImPlotRange* self, double value);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRange_destroy(ImPlotRange* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRange_Nil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRange_double(double _min, double _max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotRange_Size(ImPlotRange* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Clamp_PlotPoInt(ImPlotPoint* pOut, ImPlotRect* self, ImPlotPoint p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Clamp_double(ImPlotPoint* pOut, ImPlotRect* self, double x, double y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRect_Contains_PlotPoInt(ImPlotRect* self, ImPlotPoint p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRect_Contains_double(ImPlotRect* self, double x, double y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_destroy(ImPlotRect* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect* ImPlotRect_ImPlotRect_Nil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect* ImPlotRect_ImPlotRect_double(double x_min, double x_max, double y_min, double y_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Max(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Min(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Size(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotStyle_destroy(ImPlotStyle* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlotStyle_ImPlotStyle();
    }
}
