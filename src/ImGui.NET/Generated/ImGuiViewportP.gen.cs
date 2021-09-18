using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiViewportP
    {
        public ImGuiViewport _ImGuiViewport;
        public int Idx;
        public int LastFrameActive;
        public int LastFrontMostStampCount;
        public uint LastNameHash;
        public Vector2 LastPos;
        public float Alpha;
        public float LastAlpha;
        public short PlatformMonitor;
        public byte PlatformWindowCreated;
        public ImGuiWindow* Window;
        public fixed int DrawListsLastFrame[2];
        public ImDrawList* DrawLists_0;
        public ImDrawList* DrawLists_1;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 LastPlatformPos;
        public Vector2 LastPlatformSize;
        public Vector2 LastRendererSize;
        public Vector2 WorkOffsetMin;
        public Vector2 WorkOffsetMax;
        public Vector2 BuildWorkOffsetMin;
        public Vector2 BuildWorkOffsetMax;
    }
    public unsafe partial struct ImGuiViewportPPtr
    {
        public ImGuiViewportP* NativePtr { get; }
        public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
        public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
        public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public static implicit operator ImGuiViewportP* (ImGuiViewportPPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiViewportPPtr(IntPtr nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public ref ImGuiViewport _ImGuiViewport => ref Unsafe.AsRef<ImGuiViewport>(&NativePtr->_ImGuiViewport);
        public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);
        public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
        public ref int LastFrontMostStampCount => ref Unsafe.AsRef<int>(&NativePtr->LastFrontMostStampCount);
        public ref uint LastNameHash => ref Unsafe.AsRef<uint>(&NativePtr->LastNameHash);
        public ref Vector2 LastPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPos);
        public ref float Alpha => ref Unsafe.AsRef<float>(&NativePtr->Alpha);
        public ref float LastAlpha => ref Unsafe.AsRef<float>(&NativePtr->LastAlpha);
        public ref short PlatformMonitor => ref Unsafe.AsRef<short>(&NativePtr->PlatformMonitor);
        public ref bool PlatformWindowCreated => ref Unsafe.AsRef<bool>(&NativePtr->PlatformWindowCreated);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public RangeAccessor<int> DrawListsLastFrame => new RangeAccessor<int>(NativePtr->DrawListsLastFrame, 2);
        public RangeAccessor<ImDrawList> DrawLists => new RangeAccessor<ImDrawList>(&NativePtr->DrawLists_0, 2);
        public ref ImDrawData DrawDataP => ref Unsafe.AsRef<ImDrawData>(&NativePtr->DrawDataP);
        public ref ImDrawDataBuilder DrawDataBuilder => ref Unsafe.AsRef<ImDrawDataBuilder>(&NativePtr->DrawDataBuilder);
        public ref Vector2 LastPlatformPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformPos);
        public ref Vector2 LastPlatformSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformSize);
        public ref Vector2 LastRendererSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastRendererSize);
        public ref Vector2 WorkOffsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkOffsetMin);
        public ref Vector2 WorkOffsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkOffsetMax);
        public ref Vector2 BuildWorkOffsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkOffsetMin);
        public ref Vector2 BuildWorkOffsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkOffsetMax);
        public Vector2 CalcWorkRectPos(Vector2 off_min)
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewportP_CalcWorkRectPos(&__retval, (ImGuiViewportP*)(NativePtr), off_min);
            return __retval;
        }
        public Vector2 CalcWorkRectSize(Vector2 off_min, Vector2 off_max)
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewportP_CalcWorkRectSize(&__retval, (ImGuiViewportP*)(NativePtr), off_min, off_max);
            return __retval;
        }
        public void ClearRequestFlags()
        {
            ImGuiNative.ImGuiViewportP_ClearRequestFlags((ImGuiViewportP*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiViewportP_destroy((ImGuiViewportP*)(NativePtr));
        }
        public ImRect GetBuildWorkRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetBuildWorkRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public ImRect GetMainRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetMainRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public ImRect GetWorkRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetWorkRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public void UpdateWorkRect()
        {
            ImGuiNative.ImGuiViewportP_UpdateWorkRect((ImGuiViewportP*)(NativePtr));
        }
    }
}
