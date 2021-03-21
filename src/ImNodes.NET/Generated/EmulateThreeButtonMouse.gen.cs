using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct EmulateThreeButtonMouse
    {
        public byte enabled;
        public byte* modifier;
    }
    public unsafe partial struct EmulateThreeButtonMousePtr
    {
        public EmulateThreeButtonMouse* NativePtr { get; }
        public EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => NativePtr = nativePtr;
        public EmulateThreeButtonMousePtr(IntPtr nativePtr) => NativePtr = (EmulateThreeButtonMouse*)nativePtr;
        public static implicit operator EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => new EmulateThreeButtonMousePtr(nativePtr);
        public static implicit operator EmulateThreeButtonMouse* (EmulateThreeButtonMousePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator EmulateThreeButtonMousePtr(IntPtr nativePtr) => new EmulateThreeButtonMousePtr(nativePtr);
        public ref bool enabled => ref Unsafe.AsRef<bool>(&NativePtr->enabled);
        public IntPtr modifier { get => (IntPtr)NativePtr->modifier; set => NativePtr->modifier = (byte*)value; }
        public void Destroy()
        {
            imnodesNative.EmulateThreeButtonMouse_destroy((EmulateThreeButtonMouse*)(NativePtr));
        }
    }
}
