using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImPlotNET
{
    public static unsafe partial class ImPlotNative
    {
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotate_Str(double x, double y, Vector2 pix_offset, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotate_Vec4(double x, double y, Vector2 pix_offset, Vector4 color, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateClamped_Str(double x, double y, Vector2 pix_offset, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateClamped_Vec4(double x, double y, Vector2 pix_offset, Vector4 color, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSource(ImGuiKeyModFlags key_mods, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceItem(byte* label_id, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceX(ImGuiKeyModFlags key_mods, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceY(ImPlotYAxis axis, ImGuiKeyModFlags key_mods, ImGuiDragDropFlags flags);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTarget();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetLegend();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetX();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetY(ImPlotYAxis axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginLegendPopup(byte* label_id, ImGuiMouseButton mouse_button);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginPlot(byte* title_id, byte* x_label, byte* y_label, Vector2 size, ImPlotFlags flags, ImPlotAxisFlags x_flags, ImPlotAxisFlags y_flags, ImPlotAxisFlags y2_flags, ImPlotAxisFlags y3_flags, byte* y2_label, byte* y3_label);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_CreateContext();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_DestroyContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineX(byte* id, double* x_value, byte show_label, Vector4 col, float thickness);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineY(byte* id, double* y_value, byte show_label, Vector4 col, float thickness);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragPoint(byte* id, double* x, double* y, byte show_label, Vector4 col, float radius);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropSource();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropTarget();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndLegendPopup();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndPlot();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FitNextPlotAxes(byte x, byte y, byte y2, byte y3);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetColormapColor(Vector4* pOut, int index);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetColormapName(ImPlotColormap colormap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetColormapSize();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_GetCurrentContext();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetLastItemColor(Vector4* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetMarkerName(ImPlotMarker idx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImPlot_GetPlotDrawList();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotLimits(ImPlotLimits* pOut, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotMousePos(ImPlotPoint* pOut, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotPos(Vector2* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotQuery(ImPlotLimits* pOut, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotSize(Vector2* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlot_GetStyle();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetStyleColorName(ImPlotCol idx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_HideNextItem(byte hidden, ImGuiCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsLegendEntryHovered(byte* label_id);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotHovered();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotQueried();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotXAxisHovered();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotYAxisHovered(ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_Vec4(Vector4 col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_U32(uint col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_LerpColormap_Float(Vector4* pOut, float t);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_LinkNextPlotLimits(double* xmin, double* xmax, double* ymin, double* ymax, double* ymin2, double* ymax2, double* ymin3, double* ymax3);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_NextColormapColor(Vector4* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Vec2(ImPlotPoint* pOut, Vector2 pix, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Float(ImPlotPoint* pOut, float x, float y, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrInt(byte* label_id, float* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrInt(byte* label_id, double* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrInt(byte* label_id, sbyte* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrInt(byte* label_id, byte* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrInt(byte* label_id, short* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrInt(byte* label_id, ushort* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrInt(byte* label_id, int* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrInt(byte* label_id, uint* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrInt(byte* label_id, long* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrInt(byte* label_id, ulong* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_FloatPtrInt(byte* label_id, float* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_doublePtrInt(byte* label_id, double* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S8PtrInt(byte* label_id, sbyte* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U8PtrInt(byte* label_id, byte* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S16PtrInt(byte* label_id, short* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U16PtrInt(byte* label_id, ushort* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S32PtrInt(byte* label_id, int* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U32PtrInt(byte* label_id, uint* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S64PtrInt(byte* label_id, long* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U64PtrInt(byte* label_id, ulong* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsH_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_FloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_doublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDummy(byte* label_id);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_FloatPtr(byte* label_id, float* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_doublePtr(byte* label_id, double* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S8Ptr(byte* label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U8Ptr(byte* label_id, byte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S16Ptr(byte* label_id, short* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U16Ptr(byte* label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S32Ptr(byte* label_id, int* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U32Ptr(byte* label_id, uint* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S64Ptr(byte* label_id, long* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U64Ptr(byte* label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_FloatPtr(byte* label_id, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_doublePtr(byte* label_id, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_S8Ptr(byte* label_id, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_U8Ptr(byte* label_id, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_S16Ptr(byte* label_id, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_U16Ptr(byte* label_id, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_S32Ptr(byte* label_id, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_U32Ptr(byte* label_id, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_S64Ptr(byte* label_id, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLines_U64Ptr(byte* label_id, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotImage(byte* label_id, IntPtr user_texture_id, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_FloatPtr(byte** label_ids, float* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_doublePtr(byte** label_ids, double* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S8Ptr(byte** label_ids, sbyte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U8Ptr(byte** label_ids, byte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S16Ptr(byte** label_ids, short* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U16Ptr(byte** label_ids, ushort* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S32Ptr(byte** label_ids, int* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U32Ptr(byte** label_ids, uint* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S64Ptr(byte** label_ids, long* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U64Ptr(byte** label_ids, ulong* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrInt(byte* label_id, float* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrInt(byte* label_id, double* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrInt(byte* label_id, sbyte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrInt(byte* label_id, byte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrInt(byte* label_id, short* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrInt(byte* label_id, ushort* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrInt(byte* label_id, int* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrInt(byte* label_id, uint* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrInt(byte* label_id, long* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrInt(byte* label_id, ulong* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrInt(byte* label_id, short* xs, short* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrInt(byte* label_id, long* xs, long* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys1, float* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys1, double* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys1, byte* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys1, short* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys1, int* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys1, uint* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys1, long* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrInt(byte* label_id, float* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrInt(byte* label_id, double* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrInt(byte* label_id, sbyte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrInt(byte* label_id, byte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrInt(byte* label_id, short* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrInt(byte* label_id, ushort* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrInt(byte* label_id, int* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrInt(byte* label_id, uint* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrInt(byte* label_id, long* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrInt(byte* label_id, ulong* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotText(byte* text, double x, double y, byte vertical, Vector2 pix_offset);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_PlotPoInt(Vector2* pOut, ImPlotPoint plt, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_double(Vector2* pOut, double x, double y, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_FloatPtr(byte* label_id, float* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_doublePtr(byte* label_id, double* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_S8Ptr(byte* label_id, sbyte* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_U8Ptr(byte* label_id, byte* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_S16Ptr(byte* label_id, short* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_U16Ptr(byte* label_id, ushort* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_S32Ptr(byte* label_id, int* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_U32Ptr(byte* label_id, uint* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_S64Ptr(byte* label_id, long* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLines_U64Ptr(byte* label_id, ulong* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopColormap(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopPlotClipRect();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleColor(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleVar(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_PlotColormap(ImPlotColormap colormap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_Vec4Ptr(Vector4* colormap, int size);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushPlotClipRect();
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
        public static extern void ImPlot_SetColormap_Vec4Ptr(Vector4* colormap, int size);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetColormap_PlotColormap(ImPlotColormap colormap, int samples);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetCurrentContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetImGuiContext(IntPtr ctx);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetLegendLocation(ImPlotLocation location, ImPlotOrientation orientation, byte outside);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetMousePosLocation(ImPlotLocation location);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextErrorBarStyle(Vector4 col, float size, float weight);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextFillStyle(Vector4 col, float alpha_mod);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextLineStyle(Vector4 col, float weight);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotLimits(double xmin, double xmax, double ymin, double ymax, ImGuiCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotLimitsX(double xmin, double xmax, ImGuiCond cond);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotLimitsY(double ymin, double ymax, ImGuiCond cond, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksX_doublePtr(double* values, int n_ticks, byte** labels, byte show_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksX_double(double x_min, double x_max, int n_ticks, byte** labels, byte show_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksY_doublePtr(double* values, int n_ticks, byte** labels, byte show_default, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksY_double(double y_min, double y_max, int n_ticks, byte** labels, byte show_default, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetPlotYAxis(ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowColormapScale(double scale_min, double scale_max, Vector2 size);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowColormapSelector(byte* label);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowDemoWindow(byte* p_open);
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
        public static extern byte ImPlotLimits_Contains_PlotPoInt(ImPlotLimits* self, ImPlotPoint p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotLimits_Contains_double(ImPlotLimits* self, double x, double y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPoint_destroy(ImPlotPoint* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Nil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_double(double _x, double _y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Vec2(Vector2 p);
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
        public static extern void ImPlotStyle_destroy(ImPlotStyle* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlotStyle_ImPlotStyle();
    }
}
