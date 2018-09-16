using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiOnceUponAFrame
    {
        public int RefFrame;
    }
    public unsafe struct ImGuiOnceUponAFramePtr
    {
        public ImGuiOnceUponAFrame* NativePtr { get; }
        public ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => NativePtr = nativePtr;
        public static implicit operator ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => new ImGuiOnceUponAFramePtr(nativePtr);
        public static implicit operator ImGuiOnceUponAFrame* (ImGuiOnceUponAFramePtr wrappedPtr) => wrappedPtr.NativePtr;
        public ref int RefFrame => ref Unsafe.AsRef<int>(&NativePtr->RefFrame);
        public void ImGuiOnceUponAFrame()
        {
            ImGuiNative.ImGuiOnceUponAFrame_ImGuiOnceUponAFrame(NativePtr);
        }
    }
}
