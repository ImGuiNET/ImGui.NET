using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct ImNodesIO
    {
        public EmulateThreeButtonMouse EmulateThreeButtonMouse;
        public LinkDetachWithModifierClick LinkDetachWithModifierClick;
        public int AltMouseButton;
    }
    public unsafe partial struct ImNodesIOPtr
    {
        public ImNodesIO* NativePtr { get; }
        public ImNodesIOPtr(ImNodesIO* nativePtr) => NativePtr = nativePtr;
        public ImNodesIOPtr(IntPtr nativePtr) => NativePtr = (ImNodesIO*)nativePtr;
        public static implicit operator ImNodesIOPtr(ImNodesIO* nativePtr) => new ImNodesIOPtr(nativePtr);
        public static implicit operator ImNodesIO* (ImNodesIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImNodesIOPtr(IntPtr nativePtr) => new ImNodesIOPtr(nativePtr);
        public ref EmulateThreeButtonMouse EmulateThreeButtonMouse => ref Unsafe.AsRef<EmulateThreeButtonMouse>(&NativePtr->EmulateThreeButtonMouse);
        public ref LinkDetachWithModifierClick LinkDetachWithModifierClick => ref Unsafe.AsRef<LinkDetachWithModifierClick>(&NativePtr->LinkDetachWithModifierClick);
        public ref int AltMouseButton => ref Unsafe.AsRef<int>(&NativePtr->AltMouseButton);
        public void Destroy()
        {
            imnodesNative.ImNodesIO_destroy((ImNodesIO*)(NativePtr));
        }
    }
}
