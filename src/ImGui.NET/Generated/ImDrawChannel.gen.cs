using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawChannel
    {
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
    }
    public unsafe partial struct ImDrawChannelPtr
    {
        public ImDrawChannel* NativePtr { get; }
        public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
        public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
        public static implicit operator ImDrawChannelPtr(ImDrawChannel* nativePtr) => new ImDrawChannelPtr(nativePtr);
        public static implicit operator ImDrawChannel* (ImDrawChannelPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawChannelPtr(IntPtr nativePtr) => new ImDrawChannelPtr(nativePtr);
        public ImPtrVector<ImDrawCmdPtr> CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->CmdBuffer, Unsafe.SizeOf<ImDrawCmd>());
        public ImVector<ushort> IdxBuffer => new ImVector<ushort>(NativePtr->IdxBuffer);
    }
}
