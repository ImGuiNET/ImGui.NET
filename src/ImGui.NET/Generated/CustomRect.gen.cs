using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct CustomRect
    {
        public uint ID;
        public ushort Width;
        public ushort Height;
        public ushort X;
        public ushort Y;
        public float GlyphAdvanceX;
        public Vector2 GlyphOffset;
        public ImFont* Font;
    }
    public unsafe partial struct CustomRectPtr
    {
        public CustomRect* NativePtr { get; }
        public CustomRectPtr(CustomRect* nativePtr) => NativePtr = nativePtr;
        public CustomRectPtr(IntPtr nativePtr) => NativePtr = (CustomRect*)nativePtr;
        public static implicit operator CustomRectPtr(CustomRect* nativePtr) => new CustomRectPtr(nativePtr);
        public static implicit operator CustomRect* (CustomRectPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CustomRectPtr(IntPtr nativePtr) => new CustomRectPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ushort Width => ref Unsafe.AsRef<ushort>(&NativePtr->Width);
        public ref ushort Height => ref Unsafe.AsRef<ushort>(&NativePtr->Height);
        public ref ushort X => ref Unsafe.AsRef<ushort>(&NativePtr->X);
        public ref ushort Y => ref Unsafe.AsRef<ushort>(&NativePtr->Y);
        public ref float GlyphAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphAdvanceX);
        public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public bool IsPacked()
        {
            byte ret = ImGuiNative.CustomRect_IsPacked(NativePtr);
            return ret != 0;
        }
    }
}
