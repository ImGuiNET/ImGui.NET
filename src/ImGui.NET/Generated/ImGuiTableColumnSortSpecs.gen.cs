using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableColumnSortSpecs
    {
        public uint ColumnUserID;
        public short ColumnIndex;
        public short SortOrder;
        public byte _bitField_0;
    }
    public unsafe partial struct ImGuiTableColumnSortSpecsPtr
    {
        public ImGuiTableColumnSortSpecs* NativePtr { get; }
        public ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSortSpecs*)nativePtr;
        public static implicit operator ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);
        public static implicit operator ImGuiTableColumnSortSpecs* (ImGuiTableColumnSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);
        public ref uint ColumnUserID => ref Unsafe.AsRef<uint>(&NativePtr->ColumnUserID);
        public ref short ColumnIndex => ref Unsafe.AsRef<short>(&NativePtr->ColumnIndex);
        public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);
        public ImGuiSortDirection SortDirection
        {
            get => (ImGuiSortDirection)Util.GetBits(NativePtr->_bitField_0, 0, 8);
            set => NativePtr->_bitField_0 = Util.SetBits(NativePtr->_bitField_0, 0, 8, (byte)value);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiTableColumnSortSpecs_destroy((ImGuiTableColumnSortSpecs*)(NativePtr));
        }
    }
}
