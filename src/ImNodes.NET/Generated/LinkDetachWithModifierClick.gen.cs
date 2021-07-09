using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct LinkDetachWithModifierClick
    {
        public byte* Modifier;
    }
    public unsafe partial struct LinkDetachWithModifierClickPtr
    {
        public LinkDetachWithModifierClick* NativePtr { get; }
        public LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* nativePtr) => NativePtr = nativePtr;
        public LinkDetachWithModifierClickPtr(IntPtr nativePtr) => NativePtr = (LinkDetachWithModifierClick*)nativePtr;
        public static implicit operator LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* nativePtr) => new LinkDetachWithModifierClickPtr(nativePtr);
        public static implicit operator LinkDetachWithModifierClick* (LinkDetachWithModifierClickPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator LinkDetachWithModifierClickPtr(IntPtr nativePtr) => new LinkDetachWithModifierClickPtr(nativePtr);
        public IntPtr Modifier { get => (IntPtr)NativePtr->Modifier; set => NativePtr->Modifier = (byte*)value; }
        public void Destroy()
        {
            imnodesNative.LinkDetachWithModifierClick_destroy((LinkDetachWithModifierClick*)(NativePtr));
        }
    }
}
