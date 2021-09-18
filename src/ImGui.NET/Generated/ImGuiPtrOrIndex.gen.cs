using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiPtrOrIndex
    {
        public void* Ptr;
        public int Index;
    }
    public unsafe partial struct ImGuiPtrOrIndexPtr
    {
        public ImGuiPtrOrIndex* NativePtr { get; }
        public ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => NativePtr = nativePtr;
        public ImGuiPtrOrIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiPtrOrIndex*)nativePtr;
        public static implicit operator ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => new ImGuiPtrOrIndexPtr(nativePtr);
        public static implicit operator ImGuiPtrOrIndex* (ImGuiPtrOrIndexPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPtrOrIndexPtr(IntPtr nativePtr) => new ImGuiPtrOrIndexPtr(nativePtr);
        public IntPtr Ptr { get => (IntPtr)NativePtr->Ptr; set => NativePtr->Ptr = (void*)value; }
        public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);
        public void Destroy()
        {
            ImGuiNative.ImGuiPtrOrIndex_destroy((ImGuiPtrOrIndex*)(NativePtr));
        }
    }
}
