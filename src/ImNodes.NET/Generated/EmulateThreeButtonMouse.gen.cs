using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct EmulateThreeButtonMouse
    {
        public byte* Modifier;
    }
    public unsafe partial struct EmulateThreeButtonMousePtr
    {
        public EmulateThreeButtonMouse* NativePtr { get; }
        public EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => NativePtr = nativePtr;
        public EmulateThreeButtonMousePtr(IntPtr nativePtr) => NativePtr = (EmulateThreeButtonMouse*)nativePtr;
        public static implicit operator EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => new EmulateThreeButtonMousePtr(nativePtr);
        public static implicit operator EmulateThreeButtonMouse* (EmulateThreeButtonMousePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator EmulateThreeButtonMousePtr(IntPtr nativePtr) => new EmulateThreeButtonMousePtr(nativePtr);
        public IntPtr Modifier { get => (IntPtr)NativePtr->Modifier; set => NativePtr->Modifier = (byte*)value; }
        public void Destroy()
        {
            imnodesNative.EmulateThreeButtonMouse_destroy((EmulateThreeButtonMouse*)(NativePtr));
        }
    }
}
