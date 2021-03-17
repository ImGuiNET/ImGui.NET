using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotStyle
    {
        public float LineWeight;
        public int Marker;
        public float MarkerSize;
        public float MarkerWeight;
        public float FillAlpha;
        public float ErrorBarSize;
        public float ErrorBarWeight;
        public float DigitalBitHeight;
        public float DigitalBitGap;
        public float PlotBorderSize;
        public float MinorAlpha;
        public Vector2 MajorTickLen;
        public Vector2 MinorTickLen;
        public Vector2 MajorTickSize;
        public Vector2 MinorTickSize;
        public Vector2 MajorGridSize;
        public Vector2 MinorGridSize;
        public Vector2 PlotPadding;
        public Vector2 LabelPadding;
        public Vector2 LegendPadding;
        public Vector2 LegendInnerPadding;
        public Vector2 LegendSpacing;
        public Vector2 MousePosPadding;
        public Vector2 AnnotationPadding;
        public Vector2 FitPadding;
        public Vector2 PlotDefaultSize;
        public Vector2 PlotMinSize;
        public Vector4 Colors_0;
        public Vector4 Colors_1;
        public Vector4 Colors_2;
        public Vector4 Colors_3;
        public Vector4 Colors_4;
        public Vector4 Colors_5;
        public Vector4 Colors_6;
        public Vector4 Colors_7;
        public Vector4 Colors_8;
        public Vector4 Colors_9;
        public Vector4 Colors_10;
        public Vector4 Colors_11;
        public Vector4 Colors_12;
        public Vector4 Colors_13;
        public Vector4 Colors_14;
        public Vector4 Colors_15;
        public Vector4 Colors_16;
        public Vector4 Colors_17;
        public Vector4 Colors_18;
        public Vector4 Colors_19;
        public Vector4 Colors_20;
        public Vector4 Colors_21;
        public Vector4 Colors_22;
        public Vector4 Colors_23;
        public byte AntiAliasedLines;
        public byte UseLocalTime;
        public byte UseISO8601;
        public byte Use24HourClock;
    }
    public unsafe partial struct ImPlotStylePtr
    {
        public ImPlotStyle* NativePtr { get; }
        public ImPlotStylePtr(ImPlotStyle* nativePtr) => NativePtr = nativePtr;
        public ImPlotStylePtr(IntPtr nativePtr) => NativePtr = (ImPlotStyle*)nativePtr;
        public static implicit operator ImPlotStylePtr(ImPlotStyle* nativePtr) => new ImPlotStylePtr(nativePtr);
        public static implicit operator ImPlotStyle* (ImPlotStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotStylePtr(IntPtr nativePtr) => new ImPlotStylePtr(nativePtr);
        public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
        public ref int Marker => ref Unsafe.AsRef<int>(&NativePtr->Marker);
        public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
        public ref float MarkerWeight => ref Unsafe.AsRef<float>(&NativePtr->MarkerWeight);
        public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
        public ref float ErrorBarSize => ref Unsafe.AsRef<float>(&NativePtr->ErrorBarSize);
        public ref float ErrorBarWeight => ref Unsafe.AsRef<float>(&NativePtr->ErrorBarWeight);
        public ref float DigitalBitHeight => ref Unsafe.AsRef<float>(&NativePtr->DigitalBitHeight);
        public ref float DigitalBitGap => ref Unsafe.AsRef<float>(&NativePtr->DigitalBitGap);
        public ref float PlotBorderSize => ref Unsafe.AsRef<float>(&NativePtr->PlotBorderSize);
        public ref float MinorAlpha => ref Unsafe.AsRef<float>(&NativePtr->MinorAlpha);
        public ref Vector2 MajorTickLen => ref Unsafe.AsRef<Vector2>(&NativePtr->MajorTickLen);
        public ref Vector2 MinorTickLen => ref Unsafe.AsRef<Vector2>(&NativePtr->MinorTickLen);
        public ref Vector2 MajorTickSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MajorTickSize);
        public ref Vector2 MinorTickSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MinorTickSize);
        public ref Vector2 MajorGridSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MajorGridSize);
        public ref Vector2 MinorGridSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MinorGridSize);
        public ref Vector2 PlotPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotPadding);
        public ref Vector2 LabelPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LabelPadding);
        public ref Vector2 LegendPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendPadding);
        public ref Vector2 LegendInnerPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendInnerPadding);
        public ref Vector2 LegendSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendSpacing);
        public ref Vector2 MousePosPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePosPadding);
        public ref Vector2 AnnotationPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->AnnotationPadding);
        public ref Vector2 FitPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->FitPadding);
        public ref Vector2 PlotDefaultSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotDefaultSize);
        public ref Vector2 PlotMinSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotMinSize);
        public RangeAccessor<Vector4> Colors => new RangeAccessor<Vector4>(&NativePtr->Colors_0, 24);
        public ref bool AntiAliasedLines => ref Unsafe.AsRef<bool>(&NativePtr->AntiAliasedLines);
        public ref bool UseLocalTime => ref Unsafe.AsRef<bool>(&NativePtr->UseLocalTime);
        public ref bool UseISO8601 => ref Unsafe.AsRef<bool>(&NativePtr->UseISO8601);
        public ref bool Use24HourClock => ref Unsafe.AsRef<bool>(&NativePtr->Use24HourClock);
        public void Destroy()
        {
            ImPlotNative.ImPlotStyle_destroy((ImPlotStyle*)(NativePtr));
        }
    }
}
