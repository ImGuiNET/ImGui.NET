using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableSortSpecs
    {
        public ImGuiTableColumnSortSpecs* Specs;
        public int SpecsCount;
        public byte SpecsDirty;
    }
    public unsafe partial struct ImGuiTableSortSpecsPtr
    {
        public ImGuiTableSortSpecs* NativePtr { get; }
        public ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSortSpecs*)nativePtr;
        public static implicit operator ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);
        public static implicit operator ImGuiTableSortSpecs* (ImGuiTableSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);
        public ImGuiTableColumnSortSpecsPtr Specs => new ImGuiTableColumnSortSpecsPtr(NativePtr->Specs);
        public ref int SpecsCount => ref Unsafe.AsRef<int>(&NativePtr->SpecsCount);
        public ref bool SpecsDirty => ref Unsafe.AsRef<bool>(&NativePtr->SpecsDirty);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableSortSpecs_destroy((ImGuiTableSortSpecs*)(NativePtr));
        }
    }
}
