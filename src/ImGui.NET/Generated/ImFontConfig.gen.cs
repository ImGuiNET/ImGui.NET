using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImFontConfig
    {
        public void* FontData;
        public int FontDataSize;
        public byte FontDataOwnedByAtlas;
        public int FontNo;
        public float SizePixels;
        public int OversampleH;
        public int OversampleV;
        public byte PixelSnapH;
        public Vector2 GlyphExtraSpacing;
        public Vector2 GlyphOffset;
        public ushort* GlyphRanges;
        public float GlyphMinAdvanceX;
        public float GlyphMaxAdvanceX;
        public byte MergeMode;
        public uint RasterizerFlags;
        public float RasterizerMultiply;
        public fixed byte Name[40];
        public ImFont* DstFont;
    }
    public unsafe struct ImFontConfigPtr
    {
        public ImFontConfig* NativePtr { get; }
        public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
        public void* FontData { get => NativePtr->FontData; set => NativePtr->FontData = value; }
        public ref int FontDataSize => ref Unsafe.AsRef<int>(&NativePtr->FontDataSize);
        public ref byte FontDataOwnedByAtlas => ref Unsafe.AsRef<byte>(&NativePtr->FontDataOwnedByAtlas);
        public ref int FontNo => ref Unsafe.AsRef<int>(&NativePtr->FontNo);
        public ref float SizePixels => ref Unsafe.AsRef<float>(&NativePtr->SizePixels);
        public ref int OversampleH => ref Unsafe.AsRef<int>(&NativePtr->OversampleH);
        public ref int OversampleV => ref Unsafe.AsRef<int>(&NativePtr->OversampleV);
        public ref byte PixelSnapH => ref Unsafe.AsRef<byte>(&NativePtr->PixelSnapH);
        public ref Vector2 GlyphExtraSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphExtraSpacing);
        public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);
        public ushort* GlyphRanges { get => NativePtr->GlyphRanges; set => NativePtr->GlyphRanges = value; }
        public ref float GlyphMinAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMinAdvanceX);
        public ref float GlyphMaxAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMaxAdvanceX);
        public ref byte MergeMode => ref Unsafe.AsRef<byte>(&NativePtr->MergeMode);
        public ref uint RasterizerFlags => ref Unsafe.AsRef<uint>(&NativePtr->RasterizerFlags);
        public ref float RasterizerMultiply => ref Unsafe.AsRef<float>(&NativePtr->RasterizerMultiply);
        public ImFontPtr DstFont => new ImFontPtr(NativePtr->DstFont);
        public void ImFontConfig()
        {
            ImGuiNative.ImFontConfig_ImFontConfig(NativePtr);
        }
    }
}
