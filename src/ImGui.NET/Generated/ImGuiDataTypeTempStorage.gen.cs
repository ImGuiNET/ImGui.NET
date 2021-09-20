using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDataTypeTempStorage
    {
        public fixed byte Data[8];
    }
    public unsafe partial struct ImGuiDataTypeTempStoragePtr
    {
        public ImGuiDataTypeTempStorage* NativePtr { get; }
        public ImGuiDataTypeTempStoragePtr(ImGuiDataTypeTempStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiDataTypeTempStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeTempStorage*)nativePtr;
        public static implicit operator ImGuiDataTypeTempStoragePtr(ImGuiDataTypeTempStorage* nativePtr) => new ImGuiDataTypeTempStoragePtr(nativePtr);
        public static implicit operator ImGuiDataTypeTempStorage* (ImGuiDataTypeTempStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDataTypeTempStoragePtr(IntPtr nativePtr) => new ImGuiDataTypeTempStoragePtr(nativePtr);
        public RangeAccessor<byte> Data => new RangeAccessor<byte>(NativePtr->Data, 8);
    }
}
