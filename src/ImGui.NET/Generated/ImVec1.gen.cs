using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImVec1
    {
        public float x;
    }
    public unsafe partial struct ImVec1Ptr
    {
        public ImVec1* NativePtr { get; }
        public ImVec1Ptr(ImVec1* nativePtr) => NativePtr = nativePtr;
        public ImVec1Ptr(IntPtr nativePtr) => NativePtr = (ImVec1*)nativePtr;
        public static implicit operator ImVec1Ptr(ImVec1* nativePtr) => new ImVec1Ptr(nativePtr);
        public static implicit operator ImVec1* (ImVec1Ptr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImVec1Ptr(IntPtr nativePtr) => new ImVec1Ptr(nativePtr);
        public ref float x => ref Unsafe.AsRef<float>(&NativePtr->x);
        public void Destroy()
        {
            ImGuiNative.ImVec1_destroy((ImVec1*)(NativePtr));
        }
    }
}
