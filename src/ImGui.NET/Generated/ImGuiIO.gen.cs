using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiIO
    {
        public ImGuiConfigFlags ConfigFlags;
        public ImGuiBackendFlags BackendFlags;
        public Vector2 DisplaySize;
        public float DeltaTime;
        public float IniSavingRate;
        public byte* IniFilename;
        public byte* LogFilename;
        public float MouseDoubleClickTime;
        public float MouseDoubleClickMaxDist;
        public float MouseDragThreshold;
        public fixed int KeyMap[21];
        public float KeyRepeatDelay;
        public float KeyRepeatRate;
        public void* UserData;
        public ImFontAtlas* Fonts;
        public float FontGlobalScale;
        public byte FontAllowUserScaling;
        public ImFont* FontDefault;
        public Vector2 DisplayFramebufferScale;
        public Vector2 DisplayVisibleMin;
        public Vector2 DisplayVisibleMax;
        public byte MouseDrawCursor;
        public byte ConfigMacOSXBehaviors;
        public byte ConfigInputTextCursorBlink;
        public byte ConfigResizeWindowsFromEdges;
        public IntPtr GetClipboardTextFn;
        public IntPtr SetClipboardTextFn;
        public void* ClipboardUserData;
        public IntPtr ImeSetInputScreenPosFn;
        public void* ImeWindowHandle;
        public void* RenderDrawListsFnUnused;
        public Vector2 MousePos;
        public fixed byte MouseDown[5];
        public float MouseWheel;
        public float MouseWheelH;
        public byte KeyCtrl;
        public byte KeyShift;
        public byte KeyAlt;
        public byte KeySuper;
        public fixed byte KeysDown[512];
        public fixed ushort InputCharacters[17];
        public fixed float NavInputs[21];
        public byte WantCaptureMouse;
        public byte WantCaptureKeyboard;
        public byte WantTextInput;
        public byte WantSetMousePos;
        public byte WantSaveIniSettings;
        public byte NavActive;
        public byte NavVisible;
        public float Framerate;
        public int MetricsRenderVertices;
        public int MetricsRenderIndices;
        public int MetricsRenderWindows;
        public int MetricsActiveWindows;
        public int MetricsActiveAllocations;
        public Vector2 MouseDelta;
        public Vector2 MousePosPrev;
        public Vector2 MouseClickedPos_0;
        public Vector2 MouseClickedPos_1;
        public Vector2 MouseClickedPos_2;
        public Vector2 MouseClickedPos_3;
        public Vector2 MouseClickedPos_4;
        public fixed double MouseClickedTime[5];
        public fixed byte MouseClicked[5];
        public fixed byte MouseDoubleClicked[5];
        public fixed byte MouseReleased[5];
        public fixed byte MouseDownOwned[5];
        public fixed float MouseDownDuration[5];
        public fixed float MouseDownDurationPrev[5];
        public Vector2 MouseDragMaxDistanceAbs_0;
        public Vector2 MouseDragMaxDistanceAbs_1;
        public Vector2 MouseDragMaxDistanceAbs_2;
        public Vector2 MouseDragMaxDistanceAbs_3;
        public Vector2 MouseDragMaxDistanceAbs_4;
        public fixed float MouseDragMaxDistanceSqr[5];
        public fixed float KeysDownDuration[512];
        public fixed float KeysDownDurationPrev[512];
        public fixed float NavInputsDownDuration[21];
        public fixed float NavInputsDownDurationPrev[21];
    }
    public unsafe partial struct ImGuiIOPtr
    {
        public ImGuiIO* NativePtr { get; }
        public ImGuiIOPtr(ImGuiIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiIO*)nativePtr;
        public static implicit operator ImGuiIOPtr(ImGuiIO* nativePtr) => new ImGuiIOPtr(nativePtr);
        public static implicit operator ImGuiIO* (ImGuiIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiIOPtr(IntPtr nativePtr) => new ImGuiIOPtr(nativePtr);
        public ref ImGuiConfigFlags ConfigFlags => ref Unsafe.AsRef<ImGuiConfigFlags>(&NativePtr->ConfigFlags);
        public ref ImGuiBackendFlags BackendFlags => ref Unsafe.AsRef<ImGuiBackendFlags>(&NativePtr->BackendFlags);
        public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);
        public ref float DeltaTime => ref Unsafe.AsRef<float>(&NativePtr->DeltaTime);
        public ref float IniSavingRate => ref Unsafe.AsRef<float>(&NativePtr->IniSavingRate);
        public NullTerminatedString IniFilename => new NullTerminatedString(NativePtr->IniFilename);
        public NullTerminatedString LogFilename => new NullTerminatedString(NativePtr->LogFilename);
        public ref float MouseDoubleClickTime => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickTime);
        public ref float MouseDoubleClickMaxDist => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickMaxDist);
        public ref float MouseDragThreshold => ref Unsafe.AsRef<float>(&NativePtr->MouseDragThreshold);
        public RangeAccessor<int> KeyMap => new RangeAccessor<int>(NativePtr->KeyMap, 21);
        public ref float KeyRepeatDelay => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatDelay);
        public ref float KeyRepeatRate => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatRate);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ImFontAtlasPtr Fonts => new ImFontAtlasPtr(NativePtr->Fonts);
        public ref float FontGlobalScale => ref Unsafe.AsRef<float>(&NativePtr->FontGlobalScale);
        public ref Bool8 FontAllowUserScaling => ref Unsafe.AsRef<Bool8>(&NativePtr->FontAllowUserScaling);
        public ImFontPtr FontDefault => new ImFontPtr(NativePtr->FontDefault);
        public ref Vector2 DisplayFramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayFramebufferScale);
        public ref Vector2 DisplayVisibleMin => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayVisibleMin);
        public ref Vector2 DisplayVisibleMax => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayVisibleMax);
        public ref Bool8 MouseDrawCursor => ref Unsafe.AsRef<Bool8>(&NativePtr->MouseDrawCursor);
        public ref Bool8 ConfigMacOSXBehaviors => ref Unsafe.AsRef<Bool8>(&NativePtr->ConfigMacOSXBehaviors);
        public ref Bool8 ConfigInputTextCursorBlink => ref Unsafe.AsRef<Bool8>(&NativePtr->ConfigInputTextCursorBlink);
        public ref Bool8 ConfigResizeWindowsFromEdges => ref Unsafe.AsRef<Bool8>(&NativePtr->ConfigResizeWindowsFromEdges);
        public ref IntPtr GetClipboardTextFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->GetClipboardTextFn);
        public ref IntPtr SetClipboardTextFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->SetClipboardTextFn);
        public IntPtr ClipboardUserData { get => (IntPtr)NativePtr->ClipboardUserData; set => NativePtr->ClipboardUserData = (void*)value; }
        public ref IntPtr ImeSetInputScreenPosFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ImeSetInputScreenPosFn);
        public IntPtr ImeWindowHandle { get => (IntPtr)NativePtr->ImeWindowHandle; set => NativePtr->ImeWindowHandle = (void*)value; }
        public IntPtr RenderDrawListsFnUnused { get => (IntPtr)NativePtr->RenderDrawListsFnUnused; set => NativePtr->RenderDrawListsFnUnused = (void*)value; }
        public ref Vector2 MousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePos);
        public RangeAccessor<Bool8> MouseDown => new RangeAccessor<Bool8>(NativePtr->MouseDown, 5);
        public ref float MouseWheel => ref Unsafe.AsRef<float>(&NativePtr->MouseWheel);
        public ref float MouseWheelH => ref Unsafe.AsRef<float>(&NativePtr->MouseWheelH);
        public ref Bool8 KeyCtrl => ref Unsafe.AsRef<Bool8>(&NativePtr->KeyCtrl);
        public ref Bool8 KeyShift => ref Unsafe.AsRef<Bool8>(&NativePtr->KeyShift);
        public ref Bool8 KeyAlt => ref Unsafe.AsRef<Bool8>(&NativePtr->KeyAlt);
        public ref Bool8 KeySuper => ref Unsafe.AsRef<Bool8>(&NativePtr->KeySuper);
        public RangeAccessor<Bool8> KeysDown => new RangeAccessor<Bool8>(NativePtr->KeysDown, 512);
        public RangeAccessor<ushort> InputCharacters => new RangeAccessor<ushort>(NativePtr->InputCharacters, 17);
        public RangeAccessor<float> NavInputs => new RangeAccessor<float>(NativePtr->NavInputs, 21);
        public ref Bool8 WantCaptureMouse => ref Unsafe.AsRef<Bool8>(&NativePtr->WantCaptureMouse);
        public ref Bool8 WantCaptureKeyboard => ref Unsafe.AsRef<Bool8>(&NativePtr->WantCaptureKeyboard);
        public ref Bool8 WantTextInput => ref Unsafe.AsRef<Bool8>(&NativePtr->WantTextInput);
        public ref Bool8 WantSetMousePos => ref Unsafe.AsRef<Bool8>(&NativePtr->WantSetMousePos);
        public ref Bool8 WantSaveIniSettings => ref Unsafe.AsRef<Bool8>(&NativePtr->WantSaveIniSettings);
        public ref Bool8 NavActive => ref Unsafe.AsRef<Bool8>(&NativePtr->NavActive);
        public ref Bool8 NavVisible => ref Unsafe.AsRef<Bool8>(&NativePtr->NavVisible);
        public ref float Framerate => ref Unsafe.AsRef<float>(&NativePtr->Framerate);
        public ref int MetricsRenderVertices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderVertices);
        public ref int MetricsRenderIndices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderIndices);
        public ref int MetricsRenderWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderWindows);
        public ref int MetricsActiveWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsActiveWindows);
        public ref int MetricsActiveAllocations => ref Unsafe.AsRef<int>(&NativePtr->MetricsActiveAllocations);
        public ref Vector2 MouseDelta => ref Unsafe.AsRef<Vector2>(&NativePtr->MouseDelta);
        public ref Vector2 MousePosPrev => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePosPrev);
        public RangeAccessor<Vector2> MouseClickedPos => new RangeAccessor<Vector2>(&NativePtr->MouseClickedPos_0, 5);
        public RangeAccessor<double> MouseClickedTime => new RangeAccessor<double>(NativePtr->MouseClickedTime, 5);
        public RangeAccessor<Bool8> MouseClicked => new RangeAccessor<Bool8>(NativePtr->MouseClicked, 5);
        public RangeAccessor<Bool8> MouseDoubleClicked => new RangeAccessor<Bool8>(NativePtr->MouseDoubleClicked, 5);
        public RangeAccessor<Bool8> MouseReleased => new RangeAccessor<Bool8>(NativePtr->MouseReleased, 5);
        public RangeAccessor<Bool8> MouseDownOwned => new RangeAccessor<Bool8>(NativePtr->MouseDownOwned, 5);
        public RangeAccessor<float> MouseDownDuration => new RangeAccessor<float>(NativePtr->MouseDownDuration, 5);
        public RangeAccessor<float> MouseDownDurationPrev => new RangeAccessor<float>(NativePtr->MouseDownDurationPrev, 5);
        public RangeAccessor<Vector2> MouseDragMaxDistanceAbs => new RangeAccessor<Vector2>(&NativePtr->MouseDragMaxDistanceAbs_0, 5);
        public RangeAccessor<float> MouseDragMaxDistanceSqr => new RangeAccessor<float>(NativePtr->MouseDragMaxDistanceSqr, 5);
        public RangeAccessor<float> KeysDownDuration => new RangeAccessor<float>(NativePtr->KeysDownDuration, 512);
        public RangeAccessor<float> KeysDownDurationPrev => new RangeAccessor<float>(NativePtr->KeysDownDurationPrev, 512);
        public RangeAccessor<float> NavInputsDownDuration => new RangeAccessor<float>(NativePtr->NavInputsDownDuration, 21);
        public RangeAccessor<float> NavInputsDownDurationPrev => new RangeAccessor<float>(NativePtr->NavInputsDownDurationPrev, 21);
        public void AddInputCharactersUTF8(string utf8_chars)
        {
            int utf8_chars_byteCount = Encoding.UTF8.GetByteCount(utf8_chars);
            byte* native_utf8_chars = stackalloc byte[utf8_chars_byteCount + 1];
            fixed (char* utf8_chars_ptr = utf8_chars)
            {
                int native_utf8_chars_offset = Encoding.UTF8.GetBytes(utf8_chars_ptr, utf8_chars.Length, native_utf8_chars, utf8_chars_byteCount);
                native_utf8_chars[native_utf8_chars_offset] = 0;
            }
            ImGuiNative.ImGuiIO_AddInputCharactersUTF8(NativePtr, native_utf8_chars);
        }
        public void ClearInputCharacters()
        {
            ImGuiNative.ImGuiIO_ClearInputCharacters(NativePtr);
        }
        public void AddInputCharacter(ushort c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(NativePtr, c);
        }
    }
}
