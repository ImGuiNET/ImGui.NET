using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionExternalStorage
    {
        public void* UserData;
        public IntPtr AdapterSetItemSelected;
    }
    public unsafe partial struct ImGuiSelectionExternalStoragePtr
    {
        public ImGuiSelectionExternalStorage* NativePtr { get; }
        public ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionExternalStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionExternalStorage*)nativePtr;
        public static implicit operator ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* nativePtr) => new ImGuiSelectionExternalStoragePtr(nativePtr);
        public static implicit operator ImGuiSelectionExternalStorage* (ImGuiSelectionExternalStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionExternalStoragePtr(IntPtr nativePtr) => new ImGuiSelectionExternalStoragePtr(nativePtr);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ref IntPtr AdapterSetItemSelected => ref Unsafe.AsRef<IntPtr>(&NativePtr->AdapterSetItemSelected);
        public void ApplyRequests(ImGuiMultiSelectIOPtr ms_io)
        {
            ImGuiMultiSelectIO* native_ms_io = ms_io.NativePtr;
            ImGuiNative.ImGuiSelectionExternalStorage_ApplyRequests((ImGuiSelectionExternalStorage*)(NativePtr), native_ms_io);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiSelectionExternalStorage_destroy((ImGuiSelectionExternalStorage*)(NativePtr));
        }
    }
}
