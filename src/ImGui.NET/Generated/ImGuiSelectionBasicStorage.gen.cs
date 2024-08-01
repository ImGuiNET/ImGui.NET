using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionBasicStorage
    {
        public int Size;
        public byte PreserveOrder;
        public void* UserData;
        public IntPtr AdapterIndexToStorageId;
        public int _SelectionOrder;
        public ImGuiStorage _Storage;
    }
    public unsafe partial struct ImGuiSelectionBasicStoragePtr
    {
        public ImGuiSelectionBasicStorage* NativePtr { get; }
        public ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionBasicStorage*)nativePtr;
        public static implicit operator ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);
        public static implicit operator ImGuiSelectionBasicStorage* (ImGuiSelectionBasicStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public ref bool PreserveOrder => ref Unsafe.AsRef<bool>(&NativePtr->PreserveOrder);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ref IntPtr AdapterIndexToStorageId => ref Unsafe.AsRef<IntPtr>(&NativePtr->AdapterIndexToStorageId);
        public ref int _SelectionOrder => ref Unsafe.AsRef<int>(&NativePtr->_SelectionOrder);
        public ref ImGuiStorage _Storage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->_Storage);
        public void ApplyRequests(ImGuiMultiSelectIOPtr ms_io)
        {
            ImGuiMultiSelectIO* native_ms_io = ms_io.NativePtr;
            ImGuiNative.ImGuiSelectionBasicStorage_ApplyRequests((ImGuiSelectionBasicStorage*)(NativePtr), native_ms_io);
        }
        public void Clear()
        {
            ImGuiNative.ImGuiSelectionBasicStorage_Clear((ImGuiSelectionBasicStorage*)(NativePtr));
        }
        public bool Contains(uint id)
        {
            byte ret = ImGuiNative.ImGuiSelectionBasicStorage_Contains((ImGuiSelectionBasicStorage*)(NativePtr), id);
            return ret != 0;
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiSelectionBasicStorage_destroy((ImGuiSelectionBasicStorage*)(NativePtr));
        }
        public bool GetNextSelectedItem(ref void* opaque_it, out uint out_id)
        {
            fixed (void** native_opaque_it = &opaque_it)
            {
                fixed (uint* native_out_id = &out_id)
                {
                    byte ret = ImGuiNative.ImGuiSelectionBasicStorage_GetNextSelectedItem((ImGuiSelectionBasicStorage*)(NativePtr), native_opaque_it, native_out_id);
                    return ret != 0;
                }
            }
        }
        public uint GetStorageIdFromIndex(int idx)
        {
            uint ret = ImGuiNative.ImGuiSelectionBasicStorage_GetStorageIdFromIndex((ImGuiSelectionBasicStorage*)(NativePtr), idx);
            return ret;
        }
        public void SetItemSelected(uint id, bool selected)
        {
            byte native_selected = selected ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiSelectionBasicStorage_SetItemSelected((ImGuiSelectionBasicStorage*)(NativePtr), id, native_selected);
        }
        public void Swap(ImGuiSelectionBasicStoragePtr r)
        {
            ImGuiSelectionBasicStorage* native_r = r.NativePtr;
            ImGuiNative.ImGuiSelectionBasicStorage_Swap((ImGuiSelectionBasicStorage*)(NativePtr), native_r);
        }
    }
}
