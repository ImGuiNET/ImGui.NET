using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawChannel
    {
        public ImVector/*<ImDrawCmd>*/ CmdBuffer;
        public ImVector/*<ImDrawIdx>*/ IdxBuffer;
    }
    public unsafe partial struct ImDrawChannelPtr
    {
        public ImDrawChannel* NativePtr { get; }
        public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
        public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
        public static implicit operator ImDrawChannelPtr(ImDrawChannel* nativePtr) => new ImDrawChannelPtr(nativePtr);
        public static implicit operator ImDrawChannel* (ImDrawChannelPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawChannelPtr(IntPtr nativePtr) => new ImDrawChannelPtr(nativePtr);
        public ref ImVector/*<ImDrawCmd>*/ CmdBuffer => ref Unsafe.AsRef<ImVector/*<ImDrawCmd>*/>(&NativePtr->CmdBuffer);
        public ref ImVector/*<ImDrawIdx>*/ IdxBuffer => ref Unsafe.AsRef<ImVector/*<ImDrawIdx>*/>(&NativePtr->IdxBuffer);
    }
}
