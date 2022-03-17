using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFont
    {
        public ImVector IndexAdvanceX;
        public float FallbackAdvanceX;
        public float FontSize;
        public ImVector IndexLookup;
        public ImVector Glyphs;
        public ImFontGlyph* FallbackGlyph;
        public ImFontAtlas* ContainerAtlas;
        public ImFontConfig* ConfigData;
        public short ConfigDataCount;
        public ushort FallbackChar;
        public ushort EllipsisChar;
        public ushort DotChar;
        public byte DirtyLookupTables;
        public float Scale;
        public float Ascent;
        public float Descent;
        public int MetricsTotalSurface;
        public fixed byte Used4kPagesMap[2];
    }
    public unsafe partial struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
        public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
        public static implicit operator ImFontPtr(ImFont* nativePtr) => new ImFontPtr(nativePtr);
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontPtr(IntPtr nativePtr) => new ImFontPtr(nativePtr);
        public ImVector<float> IndexAdvanceX => new ImVector<float>(NativePtr->IndexAdvanceX);
        public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);
        public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
        public ImVector<ushort> IndexLookup => new ImVector<ushort>(NativePtr->IndexLookup);
        public ImPtrVector<ImFontGlyphPtr> Glyphs => new ImPtrVector<ImFontGlyphPtr>(NativePtr->Glyphs, Unsafe.SizeOf<ImFontGlyph>());
        public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);
        public ref short ConfigDataCount => ref Unsafe.AsRef<short>(&NativePtr->ConfigDataCount);
        public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
        public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
        public ref ushort DotChar => ref Unsafe.AsRef<ushort>(&NativePtr->DotChar);
        public ref bool DirtyLookupTables => ref Unsafe.AsRef<bool>(&NativePtr->DirtyLookupTables);
        public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);
        public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);
        public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);
        public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);
        public RangeAccessor<byte> Used4kPagesMap => new RangeAccessor<byte>(NativePtr->Used4kPagesMap, 2);
        public void AddGlyph(ImFontConfigPtr src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
        {
            ImFontConfig* native_src_cfg = src_cfg.NativePtr;
            ImGuiNative.ImFont_AddGlyph((ImFont*)(NativePtr), native_src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
        }
        public void AddRemapChar(ushort dst, ushort src)
        {
            byte overwrite_dst = 1;
            ImGuiNative.ImFont_AddRemapChar((ImFont*)(NativePtr), dst, src, overwrite_dst);
        }
        public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
        {
            byte native_overwrite_dst = overwrite_dst ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_AddRemapChar((ImFont*)(NativePtr), dst, src, native_overwrite_dst);
        }
        public void BuildLookupTable()
        {
            ImGuiNative.ImFont_BuildLookupTable((ImFont*)(NativePtr));
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData((ImFont*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImFont_destroy((ImFont*)(NativePtr));
        }
        public ImFontGlyphPtr FindGlyph(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyph((ImFont*)(NativePtr), c);
            return new ImFontGlyphPtr(ret);
        }
        public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyphNoFallback((ImFont*)(NativePtr), c);
            return new ImFontGlyphPtr(ret);
        }
        public float GetCharAdvance(ushort c)
        {
            float ret = ImGuiNative.ImFont_GetCharAdvance((ImFont*)(NativePtr), c);
            return ret;
        }
        public string GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName((ImFont*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public void GrowIndex(int new_size)
        {
            ImGuiNative.ImFont_GrowIndex((ImFont*)(NativePtr), new_size);
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded((ImFont*)(NativePtr));
            return ret != 0;
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImFont_RenderChar((ImFont*)(NativePtr), native_draw_list, size, pos, col, c);
        }
        public void SetGlyphVisible(ushort c, bool visible)
        {
            byte native_visible = visible ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_SetGlyphVisible((ImFont*)(NativePtr), c, native_visible);
        }
    }
}
