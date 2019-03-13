using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawData
    {
        public byte Valid;
        public ImDrawList** CmdLists;
        public int CmdListsCount;
        public int TotalIdxCount;
        public int TotalVtxCount;
        public Vector2 DisplayPos;
        public Vector2 DisplaySize;
        public Vector2 FramebufferScale;
    }
    public unsafe partial struct ImDrawDataPtr
    {
        public ImDrawData* NativePtr { get; }
        public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
        public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new ImDrawDataPtr(nativePtr);
        public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new ImDrawDataPtr(nativePtr);
        public ref bool Valid => ref Unsafe.AsRef<bool>(&NativePtr->Valid);
        public IntPtr CmdLists { get => (IntPtr)NativePtr->CmdLists; set => NativePtr->CmdLists = (ImDrawList**)value; }
        public ref int CmdListsCount => ref Unsafe.AsRef<int>(&NativePtr->CmdListsCount);
        public ref int TotalIdxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalIdxCount);
        public ref int TotalVtxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalVtxCount);
        public ref Vector2 DisplayPos => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayPos);
        public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);
        public ref Vector2 FramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->FramebufferScale);
        public void Clear()
        {
            ImGuiNative.ImDrawData_Clear(NativePtr);
        }
        public void DeIndexAllBuffers()
        {
            ImGuiNative.ImDrawData_DeIndexAllBuffers(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawData_destroy(NativePtr);
        }
        public void ScaleClipRects(Vector2 fb_scale)
        {
            ImGuiNative.ImDrawData_ScaleClipRects(NativePtr, fb_scale);
        }
    }
}
