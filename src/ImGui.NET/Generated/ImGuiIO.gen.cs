using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiIO
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
        public byte ConfigMacOSXBehaviors;
        public byte ConfigCursorBlink;
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
        public byte MouseDrawCursor;
        public byte KeyCtrl;
        public byte KeyShift;
        public byte KeyAlt;
        public byte KeySuper;
        public fixed byte KeysDown[512];
        public ushort InputCharacters_0;
        public ushort InputCharacters_1;
        public ushort InputCharacters_2;
        public ushort InputCharacters_3;
        public ushort InputCharacters_4;
        public ushort InputCharacters_5;
        public ushort InputCharacters_6;
        public ushort InputCharacters_7;
        public ushort InputCharacters_8;
        public ushort InputCharacters_9;
        public ushort InputCharacters_10;
        public ushort InputCharacters_11;
        public ushort InputCharacters_12;
        public ushort InputCharacters_13;
        public ushort InputCharacters_14;
        public ushort InputCharacters_15;
        public ushort InputCharacters_16;
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
        public double MouseClickedTime_0;
        public double MouseClickedTime_1;
        public double MouseClickedTime_2;
        public double MouseClickedTime_3;
        public double MouseClickedTime_4;
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
    public unsafe struct ImGuiIOPtr
    {
        public ImGuiIO* NativePtr { get; }
        public ImGuiIOPtr(ImGuiIO* nativePtr) => NativePtr = nativePtr;
        public ref ImGuiConfigFlags ConfigFlags => ref Unsafe.AsRef<ImGuiConfigFlags>(&NativePtr->ConfigFlags);
        public ref ImGuiBackendFlags BackendFlags => ref Unsafe.AsRef<ImGuiBackendFlags>(&NativePtr->BackendFlags);
        public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);
        public ref float DeltaTime => ref Unsafe.AsRef<float>(&NativePtr->DeltaTime);
        public ref float IniSavingRate => ref Unsafe.AsRef<float>(&NativePtr->IniSavingRate);
        public byte* IniFilename { get => NativePtr->IniFilename; set => NativePtr->IniFilename = value; }
        public byte* LogFilename { get => NativePtr->LogFilename; set => NativePtr->LogFilename = value; }
        public ref float MouseDoubleClickTime => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickTime);
        public ref float MouseDoubleClickMaxDist => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickMaxDist);
        public ref float MouseDragThreshold => ref Unsafe.AsRef<float>(&NativePtr->MouseDragThreshold);
        public ref float KeyRepeatDelay => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatDelay);
        public ref float KeyRepeatRate => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatRate);
        public void* UserData { get => NativePtr->UserData; set => NativePtr->UserData = value; }
        public ImFontAtlasPtr Fonts => new ImFontAtlasPtr(NativePtr->Fonts);
        public ref float FontGlobalScale => ref Unsafe.AsRef<float>(&NativePtr->FontGlobalScale);
        public ref byte FontAllowUserScaling => ref Unsafe.AsRef<byte>(&NativePtr->FontAllowUserScaling);
        public ImFontPtr FontDefault => new ImFontPtr(NativePtr->FontDefault);
        public ref Vector2 DisplayFramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayFramebufferScale);
        public ref Vector2 DisplayVisibleMin => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayVisibleMin);
        public ref Vector2 DisplayVisibleMax => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayVisibleMax);
        public ref byte ConfigMacOSXBehaviors => ref Unsafe.AsRef<byte>(&NativePtr->ConfigMacOSXBehaviors);
        public ref byte ConfigCursorBlink => ref Unsafe.AsRef<byte>(&NativePtr->ConfigCursorBlink);
        public ref byte ConfigResizeWindowsFromEdges => ref Unsafe.AsRef<byte>(&NativePtr->ConfigResizeWindowsFromEdges);
        public ref IntPtr GetClipboardTextFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->GetClipboardTextFn);
        public ref IntPtr SetClipboardTextFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->SetClipboardTextFn);
        public void* ClipboardUserData { get => NativePtr->ClipboardUserData; set => NativePtr->ClipboardUserData = value; }
        public ref IntPtr ImeSetInputScreenPosFn => ref Unsafe.AsRef<IntPtr>(&NativePtr->ImeSetInputScreenPosFn);
        public void* ImeWindowHandle { get => NativePtr->ImeWindowHandle; set => NativePtr->ImeWindowHandle = value; }
        public void* RenderDrawListsFnUnused { get => NativePtr->RenderDrawListsFnUnused; set => NativePtr->RenderDrawListsFnUnused = value; }
        public ref Vector2 MousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePos);
        public ref float MouseWheel => ref Unsafe.AsRef<float>(&NativePtr->MouseWheel);
        public ref float MouseWheelH => ref Unsafe.AsRef<float>(&NativePtr->MouseWheelH);
        public ref byte MouseDrawCursor => ref Unsafe.AsRef<byte>(&NativePtr->MouseDrawCursor);
        public ref byte KeyCtrl => ref Unsafe.AsRef<byte>(&NativePtr->KeyCtrl);
        public ref byte KeyShift => ref Unsafe.AsRef<byte>(&NativePtr->KeyShift);
        public ref byte KeyAlt => ref Unsafe.AsRef<byte>(&NativePtr->KeyAlt);
        public ref byte KeySuper => ref Unsafe.AsRef<byte>(&NativePtr->KeySuper);
        public ref byte WantCaptureMouse => ref Unsafe.AsRef<byte>(&NativePtr->WantCaptureMouse);
        public ref byte WantCaptureKeyboard => ref Unsafe.AsRef<byte>(&NativePtr->WantCaptureKeyboard);
        public ref byte WantTextInput => ref Unsafe.AsRef<byte>(&NativePtr->WantTextInput);
        public ref byte WantSetMousePos => ref Unsafe.AsRef<byte>(&NativePtr->WantSetMousePos);
        public ref byte WantSaveIniSettings => ref Unsafe.AsRef<byte>(&NativePtr->WantSaveIniSettings);
        public ref byte NavActive => ref Unsafe.AsRef<byte>(&NativePtr->NavActive);
        public ref byte NavVisible => ref Unsafe.AsRef<byte>(&NativePtr->NavVisible);
        public ref float Framerate => ref Unsafe.AsRef<float>(&NativePtr->Framerate);
        public ref int MetricsRenderVertices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderVertices);
        public ref int MetricsRenderIndices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderIndices);
        public ref int MetricsRenderWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderWindows);
        public ref int MetricsActiveWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsActiveWindows);
        public ref int MetricsActiveAllocations => ref Unsafe.AsRef<int>(&NativePtr->MetricsActiveAllocations);
        public ref Vector2 MouseDelta => ref Unsafe.AsRef<Vector2>(&NativePtr->MouseDelta);
        public ref Vector2 MousePosPrev => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePosPrev);
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
        public void ImGuiIO()
        {
            ImGuiNative.ImGuiIO_ImGuiIO(NativePtr);
        }
        public void AddInputCharacter(ushort c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(NativePtr, c);
        }
    }
}
