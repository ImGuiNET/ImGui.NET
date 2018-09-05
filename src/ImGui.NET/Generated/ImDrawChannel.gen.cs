using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImDrawChannel
    {
        public ImVector/*<ImDrawCmd>*/ CmdBuffer;
        public ImVector/*<ImDrawIdx>*/ IdxBuffer;
    }
    public unsafe struct ImDrawChannelPtr
    {
        public ImDrawChannel* NativePtr { get; }
        public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
        public ref ImVector/*<ImDrawCmd>*/ CmdBuffer => ref Unsafe.AsRef<ImVector/*<ImDrawCmd>*/>(&NativePtr->CmdBuffer);
        public ref ImVector/*<ImDrawIdx>*/ IdxBuffer => ref Unsafe.AsRef<ImVector/*<ImDrawIdx>*/>(&NativePtr->IdxBuffer);
    }
}
