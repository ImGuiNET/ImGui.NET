using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotPoint
    {
        public double x;
        public double y;
    }
    public unsafe partial struct ImPlotPointPtr
    {
        public ImPlotPoint* NativePtr { get; }
        public ImPlotPointPtr(ImPlotPoint* nativePtr) => NativePtr = nativePtr;
        public ImPlotPointPtr(IntPtr nativePtr) => NativePtr = (ImPlotPoint*)nativePtr;
        public static implicit operator ImPlotPointPtr(ImPlotPoint* nativePtr) => new ImPlotPointPtr(nativePtr);
        public static implicit operator ImPlotPoint* (ImPlotPointPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotPointPtr(IntPtr nativePtr) => new ImPlotPointPtr(nativePtr);
        public ref double x => ref Unsafe.AsRef<double>(&NativePtr->x);
        public ref double y => ref Unsafe.AsRef<double>(&NativePtr->y);
        public void Destroy()
        {
            ImPlotNative.ImPlotPoint_destroy((ImPlotPoint*)(NativePtr));
        }
    }
}
