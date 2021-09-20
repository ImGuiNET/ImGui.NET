using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImBitVector
    {
        public ImVector Storage;
    }
    public unsafe partial struct ImBitVectorPtr
    {
        public ImBitVector* NativePtr { get; }
        public ImBitVectorPtr(ImBitVector* nativePtr) => NativePtr = nativePtr;
        public ImBitVectorPtr(IntPtr nativePtr) => NativePtr = (ImBitVector*)nativePtr;
        public static implicit operator ImBitVectorPtr(ImBitVector* nativePtr) => new ImBitVectorPtr(nativePtr);
        public static implicit operator ImBitVector* (ImBitVectorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImBitVectorPtr(IntPtr nativePtr) => new ImBitVectorPtr(nativePtr);
        public ImVector<uint> Storage => new ImVector<uint>(NativePtr->Storage);
        public void Clear()
        {
            ImGuiNative.ImBitVector_Clear((ImBitVector*)(NativePtr));
        }
        public void ClearBit(int n)
        {
            ImGuiNative.ImBitVector_ClearBit((ImBitVector*)(NativePtr), n);
        }
        public void Create(int sz)
        {
            ImGuiNative.ImBitVector_Create((ImBitVector*)(NativePtr), sz);
        }
        public void SetBit(int n)
        {
            ImGuiNative.ImBitVector_SetBit((ImBitVector*)(NativePtr), n);
        }
        public bool TestBit(int n)
        {
            byte ret = ImGuiNative.ImBitVector_TestBit((ImBitVector*)(NativePtr), n);
            return ret != 0;
        }
    }
}
