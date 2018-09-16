using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImDrawCmd
    {
        public uint ElemCount;
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
    public unsafe struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public ref uint ElemCount => ref Unsafe.AsRef<uint>(&NativePtr->ElemCount);
        public ref Vector4 ClipRect => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRect);
        public ref IntPtr TextureId => ref Unsafe.AsRef<IntPtr>(&NativePtr->TextureId);
        public ref IntPtr UserCallback => ref Unsafe.AsRef<IntPtr>(&NativePtr->UserCallback);
        public void* UserCallbackData { get => NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = value; }
        public void ImDrawCmd()
        {
            ImGuiNative.ImDrawCmd_ImDrawCmd(NativePtr);
        }
    }
}
