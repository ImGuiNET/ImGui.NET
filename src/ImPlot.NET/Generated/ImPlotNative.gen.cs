using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImPlotNET
{
    public static unsafe partial class ImPlotNative
    {
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateStr(double x, double y, Vector2 pix_offset, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateVec4(double x, double y, Vector2 pix_offset, Vector4 color, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateClampedStr(double x, double y, Vector2 pix_offset, byte* fmt);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AnnotateClampedVec4(double x, double y, Vector2 pix_offset, Vector4 color, byte* fmt);
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
        public static extern void ImPlot_ItemIconVec4(Vector4 col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIconU32(uint col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_LerpColormapFloat(Vector4* pOut, float t);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_LinkNextPlotLimits(double* xmin, double* xmax, double* ymin, double* ymax, double* ymin2, double* ymax2, double* ymin3, double* ymax3);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_NextColormapColor(Vector4* pOut);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlotVec2(ImPlotPoint* pOut, Vector2 pix, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlotFloat(ImPlotPoint* pOut, float x, float y, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsFloatPtrInt(byte* label_id, float* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsdoublePtrInt(byte* label_id, double* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS8PtrInt(byte* label_id, sbyte* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU8PtrInt(byte* label_id, byte* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS16PtrInt(byte* label_id, short* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU16PtrInt(byte* label_id, ushort* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS32PtrInt(byte* label_id, int* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU32PtrInt(byte* label_id, uint* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS64PtrInt(byte* label_id, long* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU64PtrInt(byte* label_id, ulong* values, int count, double width, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double width, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHFloatPtrInt(byte* label_id, float* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHdoublePtrInt(byte* label_id, double* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS8PtrInt(byte* label_id, sbyte* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU8PtrInt(byte* label_id, byte* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS16PtrInt(byte* label_id, short* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU16PtrInt(byte* label_id, ushort* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS32PtrInt(byte* label_id, int* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU32PtrInt(byte* label_id, uint* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS64PtrInt(byte* label_id, long* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU64PtrInt(byte* label_id, ulong* values, int count, double height, double shift, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsHU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double height, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitaldoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDummy(byte* label_id);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsdoublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsdoublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHFloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHdoublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHFloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHdoublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHS64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBarsHU64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapFloatPtr(byte* label_id, float* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapdoublePtr(byte* label_id, double* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapS8Ptr(byte* label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapU8Ptr(byte* label_id, byte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapS16Ptr(byte* label_id, short* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapU16Ptr(byte* label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapS32Ptr(byte* label_id, int* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapU32Ptr(byte* label_id, uint* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapS64Ptr(byte* label_id, long* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmapU64Ptr(byte* label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesFloatPtr(byte* label_id, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesdoublePtr(byte* label_id, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesS8Ptr(byte* label_id, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesU8Ptr(byte* label_id, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesS16Ptr(byte* label_id, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesU16Ptr(byte* label_id, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesS32Ptr(byte* label_id, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesU32Ptr(byte* label_id, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesS64Ptr(byte* label_id, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHLinesU64Ptr(byte* label_id, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotImage(byte* label_id, IntPtr user_texture_id, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineFloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLinedoublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLinedoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartFloatPtr(byte** label_ids, float* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartdoublePtr(byte** label_ids, double* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartS8Ptr(byte** label_ids, sbyte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartU8Ptr(byte** label_ids, byte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartS16Ptr(byte** label_ids, short* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartU16Ptr(byte** label_ids, ushort* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartS32Ptr(byte** label_ids, int* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartU32Ptr(byte** label_ids, uint* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartS64Ptr(byte** label_ids, long* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChartU64Ptr(byte** label_ids, ulong* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterFloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterdoublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedFloatPtrInt(byte* label_id, float* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadeddoublePtrInt(byte* label_id, double* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS8PtrInt(byte* label_id, sbyte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU8PtrInt(byte* label_id, byte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS16PtrInt(byte* label_id, short* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU16PtrInt(byte* label_id, ushort* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS32PtrInt(byte* label_id, int* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU32PtrInt(byte* label_id, uint* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS64PtrInt(byte* label_id, long* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU64PtrInt(byte* label_id, ulong* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadeddoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys1, float* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadeddoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys1, double* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys1, byte* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys1, short* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys1, int* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys1, uint* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys1, long* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsFloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsdoublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsFloatPtrInt(byte* label_id, float* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsdoublePtrInt(byte* label_id, double* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS8PtrInt(byte* label_id, sbyte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU8PtrInt(byte* label_id, byte* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS16PtrInt(byte* label_id, short* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU16PtrInt(byte* label_id, ushort* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS32PtrInt(byte* label_id, int* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU32PtrInt(byte* label_id, uint* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS64PtrInt(byte* label_id, long* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU64PtrInt(byte* label_id, ulong* values, int count, double y_ref, double xscale, double x0, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsS64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStemsU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double y_ref, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotText(byte* text, double x, double y, byte vertical, Vector2 pix_offset);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixelsPlotPoInt(Vector2* pOut, ImPlotPoint plt, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixelsdouble(Vector2* pOut, double x, double y, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesFloatPtr(byte* label_id, float* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesdoublePtr(byte* label_id, double* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesS8Ptr(byte* label_id, sbyte* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesU8Ptr(byte* label_id, byte* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesS16Ptr(byte* label_id, short* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesU16Ptr(byte* label_id, ushort* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesS32Ptr(byte* label_id, int* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesU32Ptr(byte* label_id, uint* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesS64Ptr(byte* label_id, long* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotVLinesU64Ptr(byte* label_id, ulong* xs, int count, int offset, int stride);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopColormap(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopPlotClipRect();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleColor(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleVar(int count);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormapPlotColormap(ImPlotColormap colormap);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormapVec4Ptr(Vector4* colormap, int size);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushPlotClipRect();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColorU32(ImPlotCol idx, uint col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColorVec4(ImPlotCol idx, Vector4 col);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVarFloat(ImPlotStyleVar idx, float val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVarInt(ImPlotStyleVar idx, int val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVarVec2(ImPlotStyleVar idx, Vector2 val);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetColormapVec4Ptr(Vector4* colormap, int size);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetColormapPlotColormap(ImPlotColormap colormap, int samples);
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
        public static extern void ImPlot_SetNextPlotTicksXdoublePtr(double* values, int n_ticks, byte** labels, byte show_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksXdouble(double x_min, double x_max, int n_ticks, byte** labels, byte show_default);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksYdoublePtr(double* values, int n_ticks, byte** labels, byte show_default, ImPlotYAxis y_axis);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextPlotTicksYdouble(double y_min, double y_max, int n_ticks, byte** labels, byte show_default, ImPlotYAxis y_axis);
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
        public static extern byte ImPlotLimits_ContainsPlotPoInt(ImPlotLimits* self, ImPlotPoint p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotLimits_Containsdouble(ImPlotLimits* self, double x, double y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPoint_destroy(ImPlotPoint* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPointNil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPointdouble(double _x, double _y);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPointVec2(Vector2 p);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRange_Contains(ImPlotRange* self, double value);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRange_destroy(ImPlotRange* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRangeNil();
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRangedouble(double _min, double _max);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotRange_Size(ImPlotRange* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotStyle_destroy(ImPlotStyle* self);
        [DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlotStyle_ImPlotStyle();
    }
}
