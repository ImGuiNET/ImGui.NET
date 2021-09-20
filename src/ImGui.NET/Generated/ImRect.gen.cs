using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImRect
    {
        public Vector2 Min;
        public Vector2 Max;
    }
    public unsafe partial struct ImRectPtr
    {
        public ImRect* NativePtr { get; }
        public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
        public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
        public static implicit operator ImRectPtr(ImRect* nativePtr) => new ImRectPtr(nativePtr);
        public static implicit operator ImRect* (ImRectPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImRectPtr(IntPtr nativePtr) => new ImRectPtr(nativePtr);
        public ref Vector2 Min => ref Unsafe.AsRef<Vector2>(&NativePtr->Min);
        public ref Vector2 Max => ref Unsafe.AsRef<Vector2>(&NativePtr->Max);
        public void Add(Vector2 p)
        {
            ImGuiNative.ImRect_Add_Vec2((ImRect*)(NativePtr), p);
        }
        public void Add(ImRect r)
        {
            ImGuiNative.ImRect_Add_Rect((ImRect*)(NativePtr), r);
        }
        public void ClipWith(ImRect r)
        {
            ImGuiNative.ImRect_ClipWith((ImRect*)(NativePtr), r);
        }
        public void ClipWithFull(ImRect r)
        {
            ImGuiNative.ImRect_ClipWithFull((ImRect*)(NativePtr), r);
        }
        public bool Contains(Vector2 p)
        {
            byte ret = ImGuiNative.ImRect_Contains_Vec2((ImRect*)(NativePtr), p);
            return ret != 0;
        }
        public bool Contains(ImRect r)
        {
            byte ret = ImGuiNative.ImRect_Contains_Rect((ImRect*)(NativePtr), r);
            return ret != 0;
        }
        public void Destroy()
        {
            ImGuiNative.ImRect_destroy((ImRect*)(NativePtr));
        }
        public void Expand(float amount)
        {
            ImGuiNative.ImRect_Expand_Float((ImRect*)(NativePtr), amount);
        }
        public void Expand(Vector2 amount)
        {
            ImGuiNative.ImRect_Expand_Vec2((ImRect*)(NativePtr), amount);
        }
        public void Floor()
        {
            ImGuiNative.ImRect_Floor((ImRect*)(NativePtr));
        }
        public float GetArea()
        {
            float ret = ImGuiNative.ImRect_GetArea((ImRect*)(NativePtr));
            return ret;
        }
        public Vector2 GetBL()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetBL(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public Vector2 GetBR()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetBR(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public Vector2 GetCenter()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetCenter(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public float GetHeight()
        {
            float ret = ImGuiNative.ImRect_GetHeight((ImRect*)(NativePtr));
            return ret;
        }
        public Vector2 GetSize()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetSize(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public Vector2 GetTL()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetTL(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public Vector2 GetTR()
        {
            Vector2 __retval;
            ImGuiNative.ImRect_GetTR(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public float GetWidth()
        {
            float ret = ImGuiNative.ImRect_GetWidth((ImRect*)(NativePtr));
            return ret;
        }
        public bool IsInverted()
        {
            byte ret = ImGuiNative.ImRect_IsInverted((ImRect*)(NativePtr));
            return ret != 0;
        }
        public bool Overlaps(ImRect r)
        {
            byte ret = ImGuiNative.ImRect_Overlaps((ImRect*)(NativePtr), r);
            return ret != 0;
        }
        public Vector4 ToVec4()
        {
            Vector4 __retval;
            ImGuiNative.ImRect_ToVec4(&__retval, (ImRect*)(NativePtr));
            return __retval;
        }
        public void Translate(Vector2 d)
        {
            ImGuiNative.ImRect_Translate((ImRect*)(NativePtr), d);
        }
        public void TranslateX(float dx)
        {
            ImGuiNative.ImRect_TranslateX((ImRect*)(NativePtr), dx);
        }
        public void TranslateY(float dy)
        {
            ImGuiNative.ImRect_TranslateY((ImRect*)(NativePtr), dy);
        }
    }
}
