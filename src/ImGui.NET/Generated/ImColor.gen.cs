using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImColor
    {
        public Vector4 Value;
    }
    public unsafe struct ImColorPtr
    {
        public ImColor* NativePtr { get; }
        public ImColorPtr(ImColor* nativePtr) => NativePtr = nativePtr;
        public static implicit operator ImColorPtr(ImColor* nativePtr) => new ImColorPtr(nativePtr);
        public static implicit operator ImColor* (ImColorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public ref Vector4 Value => ref Unsafe.AsRef<Vector4>(&NativePtr->Value);
        public void SetHSV(float h, float s, float v)
        {
            float a = 1.0f;
            ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
        }
        public void SetHSV(float h, float s, float v, float a)
        {
            ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
        }
        public void ImColor()
        {
            ImGuiNative.ImColor_ImColor(NativePtr);
        }
        public void ImColor(int r, int g, int b)
        {
            int a = 255;
            ImGuiNative.ImColor_ImColorInt(NativePtr, r, g, b, a);
        }
        public void ImColor(int r, int g, int b, int a)
        {
            ImGuiNative.ImColor_ImColorInt(NativePtr, r, g, b, a);
        }
        public void ImColor(uint rgba)
        {
            ImGuiNative.ImColor_ImColorU32(NativePtr, rgba);
        }
        public void ImColor(float r, float g, float b)
        {
            float a = 1.0f;
            ImGuiNative.ImColor_ImColorFloat(NativePtr, r, g, b, a);
        }
        public void ImColor(float r, float g, float b, float a)
        {
            ImGuiNative.ImColor_ImColorFloat(NativePtr, r, g, b, a);
        }
        public void ImColor(Vector4 col)
        {
            ImGuiNative.ImColor_ImColorVec4(NativePtr, col);
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
    }
}
