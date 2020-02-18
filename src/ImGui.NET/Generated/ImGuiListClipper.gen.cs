using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiListClipper
    {
        public int DisplayStart;
        public int DisplayEnd;
        public int ItemsCount;
        public int StepNo;
        public float ItemsHeight;
        public float StartPosY;
    }
    public unsafe partial struct ImGuiListClipperPtr
    {
        public ImGuiListClipper* NativePtr { get; }
        public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
        public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
        public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public ref int DisplayStart => ref Unsafe.AsRef<int>(&NativePtr->DisplayStart);
        public ref int DisplayEnd => ref Unsafe.AsRef<int>(&NativePtr->DisplayEnd);
        public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);
        public ref int StepNo => ref Unsafe.AsRef<int>(&NativePtr->StepNo);
        public ref float ItemsHeight => ref Unsafe.AsRef<float>(&NativePtr->ItemsHeight);
        public ref float StartPosY => ref Unsafe.AsRef<float>(&NativePtr->StartPosY);
        public void Begin(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Begin(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiListClipper_destroy(NativePtr);
        }
        public void End()
        {
            ImGuiNative.ImGuiListClipper_End(NativePtr);
        }
        public bool Step()
        {
            byte ret = ImGuiNative.ImGuiListClipper_Step(NativePtr);
            return ret != 0;
        }
    }
}
