using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiSizeCallbackData
    {
        public void* UserData;
        public Vector2 Pos;
        public Vector2 CurrentSize;
        public Vector2 DesiredSize;
    }
    public unsafe struct ImGuiSizeCallbackDataPtr
    {
        public ImGuiSizeCallbackData* NativePtr { get; }
        public ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => NativePtr = nativePtr;
        public static implicit operator ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiSizeCallbackData* (ImGuiSizeCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public void* UserData { get => NativePtr->UserData; set => NativePtr->UserData = value; }
        public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
        public ref Vector2 CurrentSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrentSize);
        public ref Vector2 DesiredSize => ref Unsafe.AsRef<Vector2>(&NativePtr->DesiredSize);
    }
}
