using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImColor
    {
        public Vector4 Value;
    }
    public unsafe partial struct ImColorPtr
    {
        public ImColor* NativePtr { get; }
        public ImColorPtr(ImColor* nativePtr) => NativePtr = nativePtr;
        public ImColorPtr(IntPtr nativePtr) => NativePtr = (ImColor*)nativePtr;
        public static implicit operator ImColorPtr(ImColor* nativePtr) => new ImColorPtr(nativePtr);
        public static implicit operator ImColor* (ImColorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImColorPtr(IntPtr nativePtr) => new ImColorPtr(nativePtr);
        public ref Vector4 Value => ref Unsafe.AsRef<Vector4>(&NativePtr->Value);
        public void Destroy()
        {
            ImGuiNative.ImColor_destroy(NativePtr);
        }
        public ImColor HSV(float h, float s, float v)
        {
            float a = 1.0f;
            ImColor ret = ImGuiNative.ImColor_HSV(NativePtr, h, s, v, a);
            return ret;
        }
        public ImColor HSV(float h, float s, float v, float a)
        {
            ImColor ret = ImGuiNative.ImColor_HSV(NativePtr, h, s, v, a);
            return ret;
        }
        public void SetHSV(float h, float s, float v)
        {
            float a = 1.0f;
            ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
        }
        public void SetHSV(float h, float s, float v, float a)
        {
            ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
        }
    }
}
