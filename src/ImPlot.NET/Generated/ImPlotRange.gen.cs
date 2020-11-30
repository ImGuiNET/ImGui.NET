using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotRange
    {
        public double Min;
        public double Max;
    }
    public unsafe partial struct ImPlotRangePtr
    {
        public ImPlotRange* NativePtr { get; }
        public ImPlotRangePtr(ImPlotRange* nativePtr) => NativePtr = nativePtr;
        public ImPlotRangePtr(IntPtr nativePtr) => NativePtr = (ImPlotRange*)nativePtr;
        public static implicit operator ImPlotRangePtr(ImPlotRange* nativePtr) => new ImPlotRangePtr(nativePtr);
        public static implicit operator ImPlotRange* (ImPlotRangePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotRangePtr(IntPtr nativePtr) => new ImPlotRangePtr(nativePtr);
        public ref double Min => ref Unsafe.AsRef<double>(&NativePtr->Min);
        public ref double Max => ref Unsafe.AsRef<double>(&NativePtr->Max);
        public bool Contains(double value)
        {
            byte ret = ImPlotNative.ImPlotRange_Contains((ImPlotRange*)(NativePtr), value);
            return ret != 0;
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotRange_destroy((ImPlotRange*)(NativePtr));
        }
        public double Size()
        {
            double ret = ImPlotNative.ImPlotRange_Size((ImPlotRange*)(NativePtr));
            return ret;
        }
    }
}
