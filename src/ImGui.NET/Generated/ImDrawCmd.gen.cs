using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawCmd
    {
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public uint VtxOffset;
        public uint IdxOffset;
        public uint ElemCount;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
    public unsafe partial struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
        public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new ImDrawCmdPtr(nativePtr);
        public ref Vector4 ClipRect => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRect);
        public ref IntPtr TextureId => ref Unsafe.AsRef<IntPtr>(&NativePtr->TextureId);
        public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);
        public ref uint IdxOffset => ref Unsafe.AsRef<uint>(&NativePtr->IdxOffset);
        public ref uint ElemCount => ref Unsafe.AsRef<uint>(&NativePtr->ElemCount);
        public ref IntPtr UserCallback => ref Unsafe.AsRef<IntPtr>(&NativePtr->UserCallback);
        public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImDrawCmd_destroy((ImDrawCmd*)(NativePtr));
        }
        public IntPtr GetTexID()
        {
            IntPtr ret = ImGuiNative.ImDrawCmd_GetTexID((ImDrawCmd*)(NativePtr));
            return ret;
        }
    }
}
