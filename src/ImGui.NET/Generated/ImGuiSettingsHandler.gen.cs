using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSettingsHandler
    {
        public byte* TypeName;
        public uint TypeHash;
        public IntPtr ClearAllFn;
        public IntPtr ReadInitFn;
        public IntPtr ReadOpenFn;
        public IntPtr ReadLineFn;
        public IntPtr ApplyAllFn;
        public IntPtr WriteAllFn;
        public void* UserData;
    }
    public unsafe partial struct ImGuiSettingsHandlerPtr
    {
        public ImGuiSettingsHandler* NativePtr { get; }
        public ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => NativePtr = nativePtr;
        public ImGuiSettingsHandlerPtr(IntPtr nativePtr) => NativePtr = (ImGuiSettingsHandler*)nativePtr;
        public static implicit operator ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => new ImGuiSettingsHandlerPtr(nativePtr);
        public static implicit operator ImGuiSettingsHandler* (ImGuiSettingsHandlerPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSettingsHandlerPtr(IntPtr nativePtr) => new ImGuiSettingsHandlerPtr(nativePtr);
        public NullTerminatedString TypeName => new NullTerminatedString(NativePtr->TypeName);
        public ref uint TypeHash => ref Unsafe.AsRef<uint>(&NativePtr->TypeHash);
        public ref IntPtr ClearAllFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ClearAllFn);
        public ref IntPtr ReadInitFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ReadInitFn);
        public ref IntPtr ReadOpenFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ReadOpenFn);
        public ref IntPtr ReadLineFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ReadLineFn);
        public ref IntPtr ApplyAllFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ApplyAllFn);
        public ref IntPtr WriteAllFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->WriteAllFn);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImGuiSettingsHandler_destroy((ImGuiSettingsHandler*)(NativePtr));
        }
    }
}
