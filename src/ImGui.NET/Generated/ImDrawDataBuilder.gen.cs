using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawDataBuilder
    {
        public ImVector Layers_0;
        public ImVector Layers_1;
    }
    public unsafe partial struct ImDrawDataBuilderPtr
    {
        public ImDrawDataBuilder* NativePtr { get; }
        public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
        public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => new ImDrawDataBuilderPtr(nativePtr);
        public static implicit operator ImDrawDataBuilder* (ImDrawDataBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataBuilderPtr(IntPtr nativePtr) => new ImDrawDataBuilderPtr(nativePtr);
        public RangeAccessor<ImVector> Layers => new RangeAccessor<ImVector>(&NativePtr->Layers_0, 2);
        public void Clear()
        {
            ImGuiNative.ImDrawDataBuilder_Clear((ImDrawDataBuilder*)(NativePtr));
        }
        public void ClearFreeMemory()
        {
            ImGuiNative.ImDrawDataBuilder_ClearFreeMemory((ImDrawDataBuilder*)(NativePtr));
        }
        public void FlattenIntoSingleLayer()
        {
            ImGuiNative.ImDrawDataBuilder_FlattenIntoSingleLayer((ImDrawDataBuilder*)(NativePtr));
        }
        public int GetDrawListCount()
        {
            int ret = ImGuiNative.ImDrawDataBuilder_GetDrawListCount((ImDrawDataBuilder*)(NativePtr));
            return ret;
        }
    }
}
