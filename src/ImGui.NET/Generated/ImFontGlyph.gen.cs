using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontGlyph
    {
        public uint _bitField_0;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
    }
    public unsafe partial struct ImFontGlyphPtr
    {
        public ImFontGlyph* NativePtr { get; }
        public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
        public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
        public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) => new ImFontGlyphPtr(nativePtr);
        public static implicit operator ImFontGlyph* (ImFontGlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) => new ImFontGlyphPtr(nativePtr);
        public uint Colored
        {
            get => (uint)Util.GetBits(NativePtr->_bitField_0, 0, 1);
            set => NativePtr->_bitField_0 = Util.SetBits(NativePtr->_bitField_0, 0, 1, (uint)value);
        }
        public uint Visible
        {
            get => (uint)Util.GetBits(NativePtr->_bitField_0, 1, 1);
            set => NativePtr->_bitField_0 = Util.SetBits(NativePtr->_bitField_0, 1, 1, (uint)value);
        }
        public uint Codepoint
        {
            get => (uint)Util.GetBits(NativePtr->_bitField_0, 2, 30);
            set => NativePtr->_bitField_0 = Util.SetBits(NativePtr->_bitField_0, 2, 30, (uint)value);
        }
        public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);
        public ref float X0 => ref Unsafe.AsRef<float>(&NativePtr->X0);
        public ref float Y0 => ref Unsafe.AsRef<float>(&NativePtr->Y0);
        public ref float X1 => ref Unsafe.AsRef<float>(&NativePtr->X1);
        public ref float Y1 => ref Unsafe.AsRef<float>(&NativePtr->Y1);
        public ref float U0 => ref Unsafe.AsRef<float>(&NativePtr->U0);
        public ref float V0 => ref Unsafe.AsRef<float>(&NativePtr->V0);
        public ref float U1 => ref Unsafe.AsRef<float>(&NativePtr->U1);
        public ref float V1 => ref Unsafe.AsRef<float>(&NativePtr->V1);
    }
}
