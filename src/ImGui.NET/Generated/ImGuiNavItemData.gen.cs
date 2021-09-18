using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiNavItemData
    {
        public ImGuiWindow* Window;
        public uint ID;
        public uint FocusScopeId;
        public ImRect RectRel;
        public float DistBox;
        public float DistCenter;
        public float DistAxial;
    }
    public unsafe partial struct ImGuiNavItemDataPtr
    {
        public ImGuiNavItemData* NativePtr { get; }
        public ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => NativePtr = nativePtr;
        public ImGuiNavItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNavItemData*)nativePtr;
        public static implicit operator ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => new ImGuiNavItemDataPtr(nativePtr);
        public static implicit operator ImGuiNavItemData* (ImGuiNavItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiNavItemDataPtr(IntPtr nativePtr) => new ImGuiNavItemDataPtr(nativePtr);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
        public ref ImRect RectRel => ref Unsafe.AsRef<ImRect>(&NativePtr->RectRel);
        public ref float DistBox => ref Unsafe.AsRef<float>(&NativePtr->DistBox);
        public ref float DistCenter => ref Unsafe.AsRef<float>(&NativePtr->DistCenter);
        public ref float DistAxial => ref Unsafe.AsRef<float>(&NativePtr->DistAxial);
        public void Clear()
        {
            ImGuiNative.ImGuiNavItemData_Clear((ImGuiNavItemData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiNavItemData_destroy((ImGuiNavItemData*)(NativePtr));
        }
    }
}
