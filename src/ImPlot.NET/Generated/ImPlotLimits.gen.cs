using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotLimits
    {
        public ImPlotRange X;
        public ImPlotRange Y;
    }
    public unsafe partial struct ImPlotLimitsPtr
    {
        public ImPlotLimits* NativePtr { get; }
        public ImPlotLimitsPtr(ImPlotLimits* nativePtr) => NativePtr = nativePtr;
        public ImPlotLimitsPtr(IntPtr nativePtr) => NativePtr = (ImPlotLimits*)nativePtr;
        public static implicit operator ImPlotLimitsPtr(ImPlotLimits* nativePtr) => new ImPlotLimitsPtr(nativePtr);
        public static implicit operator ImPlotLimits* (ImPlotLimitsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotLimitsPtr(IntPtr nativePtr) => new ImPlotLimitsPtr(nativePtr);
        public ref ImPlotRange X => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->X);
        public ref ImPlotRange Y => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->Y);
        public bool Contains(ImPlotPoint p)
        {
            byte ret = ImPlotNative.ImPlotLimits_ContainsPlotPoInt((ImPlotLimits*)(NativePtr), p);
            return ret != 0;
        }
        public bool Contains(double x, double y)
        {
            byte ret = ImPlotNative.ImPlotLimits_Containsdouble((ImPlotLimits*)(NativePtr), x, y);
            return ret != 0;
        }
    }
}
