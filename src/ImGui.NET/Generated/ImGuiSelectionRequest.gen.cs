using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionRequest
    {
        public ImGuiSelectionRequestType Type;
        public byte Selected;
        public sbyte RangeDirection;
        public long RangeFirstItem;
        public long RangeLastItem;
    }
    public unsafe partial struct ImGuiSelectionRequestPtr
    {
        public ImGuiSelectionRequest* NativePtr { get; }
        public ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionRequest*)nativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public static implicit operator ImGuiSelectionRequest* (ImGuiSelectionRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(IntPtr nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public ref ImGuiSelectionRequestType Type => ref Unsafe.AsRef<ImGuiSelectionRequestType>(&NativePtr->Type);
        public ref bool Selected => ref Unsafe.AsRef<bool>(&NativePtr->Selected);
        public ref sbyte RangeDirection => ref Unsafe.AsRef<sbyte>(&NativePtr->RangeDirection);
        public ref long RangeFirstItem => ref Unsafe.AsRef<long>(&NativePtr->RangeFirstItem);
        public ref long RangeLastItem => ref Unsafe.AsRef<long>(&NativePtr->RangeLastItem);
    }
}
