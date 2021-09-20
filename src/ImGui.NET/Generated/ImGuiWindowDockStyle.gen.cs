using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiWindowDockStyle
    {
        public fixed uint Colors[6];
    }
    public unsafe partial struct ImGuiWindowDockStylePtr
    {
        public ImGuiWindowDockStyle* NativePtr { get; }
        public ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* nativePtr) => NativePtr = nativePtr;
        public ImGuiWindowDockStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowDockStyle*)nativePtr;
        public static implicit operator ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* nativePtr) => new ImGuiWindowDockStylePtr(nativePtr);
        public static implicit operator ImGuiWindowDockStyle* (ImGuiWindowDockStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiWindowDockStylePtr(IntPtr nativePtr) => new ImGuiWindowDockStylePtr(nativePtr);
        public RangeAccessor<uint> Colors => new RangeAccessor<uint>(NativePtr->Colors, 6);
    }
}
