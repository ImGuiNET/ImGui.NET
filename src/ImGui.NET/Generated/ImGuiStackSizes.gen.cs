using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStackSizes
    {
        public short SizeOfIDStack;
        public short SizeOfColorStack;
        public short SizeOfStyleVarStack;
        public short SizeOfFontStack;
        public short SizeOfFocusScopeStack;
        public short SizeOfGroupStack;
        public short SizeOfBeginPopupStack;
    }
    public unsafe partial struct ImGuiStackSizesPtr
    {
        public ImGuiStackSizes* NativePtr { get; }
        public ImGuiStackSizesPtr(ImGuiStackSizes* nativePtr) => NativePtr = nativePtr;
        public ImGuiStackSizesPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackSizes*)nativePtr;
        public static implicit operator ImGuiStackSizesPtr(ImGuiStackSizes* nativePtr) => new ImGuiStackSizesPtr(nativePtr);
        public static implicit operator ImGuiStackSizes* (ImGuiStackSizesPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStackSizesPtr(IntPtr nativePtr) => new ImGuiStackSizesPtr(nativePtr);
        public ref short SizeOfIDStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfIDStack);
        public ref short SizeOfColorStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfColorStack);
        public ref short SizeOfStyleVarStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfStyleVarStack);
        public ref short SizeOfFontStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFontStack);
        public ref short SizeOfFocusScopeStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFocusScopeStack);
        public ref short SizeOfGroupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfGroupStack);
        public ref short SizeOfBeginPopupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfBeginPopupStack);
        public void CompareWithCurrentState()
        {
            ImGuiNative.ImGuiStackSizes_CompareWithCurrentState((ImGuiStackSizes*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiStackSizes_destroy((ImGuiStackSizes*)(NativePtr));
        }
        public void SetToCurrentState()
        {
            ImGuiNative.ImGuiStackSizes_SetToCurrentState((ImGuiStackSizes*)(NativePtr));
        }
    }
}
