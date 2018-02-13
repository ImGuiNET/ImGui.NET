using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public unsafe class IO
    {
        private NativeIO* _nativePtr;

        internal IO(NativeIO* nativePtr)
        {
            _nativePtr = nativePtr;
            MouseDown = new MouseDownStates(nativePtr);
            KeyMap = new KeyMap(_nativePtr);
            KeysDown = new KeyDownStates(_nativePtr);
            FontAtlas = new FontAtlas(_nativePtr->FontAtlas);
        }

        public NativeIO* GetNativePointer() => _nativePtr;

        /// <summary>
        /// Display size, in pixels. For clamping windows positions.
        /// Default value: [unset]
        /// </summary>
        public Vector2 DisplaySize
        {
            get { return _nativePtr->DisplaySize; }
            set { _nativePtr->DisplaySize = value; }
        }

        /// <summary>
        /// Time elapsed since last frame, in seconds.
        /// Default value: 1.0f / 10.0f.
        /// </summary>
        public float DeltaTime
        {
            get { return _nativePtr->DeltaTime; }
            set { _nativePtr->DeltaTime = value; }
        }

        /// <summary>
        /// For retina display or other situations where window coordinates are different from framebuffer coordinates.
        /// User storage only, presently not used by ImGui.
        /// Default value: (1.0f, 1.0f).
        /// </summary>
        public Vector2 DisplayFramebufferScale
        {
            get { return _nativePtr->DisplayFramebufferScale; }
            set { _nativePtr->DisplayFramebufferScale = value; }
        }

        /// <summary>
        /// Mouse position, in pixels (set to -1,-1 if no mouse / on another screen, etc.).
        /// </summary>
        public Vector2 MousePosition
        {
            get { return _nativePtr->MousePos; }
            set { _nativePtr->MousePos = value; }
        }

        /// <summary>
        /// Mouse wheel: 1 unit scrolls about 5 lines text.
        /// </summary>
        public float MouseWheel
        {
            get { return _nativePtr->MouseWheel; }
            set { _nativePtr->MouseWheel = value; }
        }

        /// <summary>
        /// Mouse buttons: left, right, middle + extras.
        /// ImGui itself mostly only uses left button (BeginPopupContext** are using right button).
        /// Others buttons allows us to track if the mouse is being used by your application + available to user as a convenience via IsMouse** API.
        /// </summary>
        public MouseDownStates MouseDown { get; }

        /// <summary>
        /// Map of indices into the KeysDown[512] entries array.
        /// Default values: [unset]
        /// </summary>
        public KeyMap KeyMap { get; }

        /// <summary>
        /// Keyboard keys that are pressed (in whatever storage order you naturally have access to keyboard data)
        /// </summary>
        public KeyDownStates KeysDown { get; }

        public FontAtlas FontAtlas { get; }

        public bool FontAllowUserScaling
        {
            get { return _nativePtr->FontAllowUserScaling != 0; }
            set { _nativePtr->FontAllowUserScaling = value ? (byte)1 : (byte)0; }
        }

        /// <summary>
        /// Keyboard modifier pressed: Control.
        /// </summary>
        public bool CtrlPressed
        {
            get { return _nativePtr->KeyCtrl == 1; }
            set { _nativePtr->KeyCtrl = value ? (byte)1 : (byte)0; }
        }

        /// <summary>
        /// Keyboard modifier pressed: Shift
        /// </summary>
        public bool ShiftPressed
        {
            get { return _nativePtr->KeyShift == 1; }
            set { _nativePtr->KeyShift = value ? (byte)1 : (byte)0; }
        }

        /// <summary>
        /// Keyboard modifier pressed: Alt
        /// </summary>
        public bool AltPressed
        {
            get { return _nativePtr->KeyAlt == 1; }
            set { _nativePtr->KeyAlt = value ? (byte)1 : (byte)0; }
        }

        public bool WantCaptureMouse
        {
            get { return _nativePtr->WantCaptureMouse == 1; }
            set { _nativePtr->WantCaptureMouse = value ? (byte)1 : (byte)0; }
        }

        public bool WantCaptureKeyboard
        {
            get { return _nativePtr->WantCaptureKeyboard == 1; }
            set { _nativePtr->WantCaptureKeyboard = value ? (byte)1 : (byte)0; }
        }

        public bool WantTextInput
        {
            get { return _nativePtr->WantTextInput == 1; }
            set { _nativePtr->WantTextInput = value ? (byte)1 : (byte)0; }
        }
    }

    public unsafe class KeyMap
    {
        private readonly NativeIO* _nativePtr;

        public KeyMap(NativeIO* nativePtr)
        {
            _nativePtr = nativePtr;
        }

        public int this[GuiKey key]
        {
            get
            {
                return _nativePtr->KeyMap[(int)key];
            }
            set
            {
                _nativePtr->KeyMap[(int)key] = value;
            }
        }
    }

    public unsafe class MouseDownStates
    {
        private readonly NativeIO* _nativePtr;

        public MouseDownStates(NativeIO* nativePtr)
        {
            _nativePtr = nativePtr;
        }

        public bool this[int button]
        {
            get
            {
                if (button < 0 || button > 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(button));
                }

                return _nativePtr->MouseDown[button] == 1;
            }
            set
            {
                if (button < 0 || button > 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(button));
                }

                byte pressed = value ? (byte)1 : (byte)0;
                _nativePtr->MouseDown[button] = pressed;
            }
        }
    }

    public unsafe class KeyDownStates
    {
        private readonly NativeIO* _nativePtr;

        public KeyDownStates(NativeIO* nativePtr)
        {
            _nativePtr = nativePtr;
        }

        public bool this[int key]
        {
            get
            {
                if (key < 0 || key > 512)
                {
                    throw new ArgumentOutOfRangeException(nameof(key));
                }

                return _nativePtr->KeysDown[key] == 1;
            }
            set
            {
                if (key < 0 || key > 512)
                {
                    throw new ArgumentOutOfRangeException(nameof(key));
                }

                byte pressed = value ? (byte)1 : (byte)0;
                _nativePtr->KeysDown[key] = pressed;
            }
        }
    }

    public unsafe class FontAtlas
    {
        private readonly NativeFontAtlas* _atlasPtr;

        public FontAtlas(NativeFontAtlas* atlasPtr)
        {
            _atlasPtr = atlasPtr;
        }

        public FontTextureData GetTexDataAsAlpha8()
        {
            byte* pixels;
            int width, height;
            int bytesPerPixel;
            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(_atlasPtr, &pixels, &width, &height, &bytesPerPixel);

            return new FontTextureData(pixels, width, height, bytesPerPixel);
        }

        public FontTextureData GetTexDataAsRGBA32()
        {
            byte* pixels;
            int width, height;
            int bytesPerPixel;
            ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(_atlasPtr, &pixels, &width, &height, &bytesPerPixel);

            return new FontTextureData(pixels, width, height, bytesPerPixel);
        }

        public void SetTexID(int textureID)
        {
            SetTexID(new IntPtr(textureID));
        }

        public void SetTexID(IntPtr textureID)
        {
            ImGuiNative.ImFontAtlas_SetTexID(_atlasPtr, textureID.ToPointer());
        }

        public void Clear()
        {
            ImGuiNative.ImFontAtlas_Clear(_atlasPtr);
        }

        public void ClearTexData()
        {
            ImGuiNative.ImFontAtlas_ClearTexData(_atlasPtr);
        }

        public Font AddDefaultFont()
        {
            NativeFont* nativeFontPtr = ImGuiNative.ImFontAtlas_AddFontDefault(_atlasPtr);
            return new Font(nativeFontPtr);
        }

        public Font AddFontFromFileTTF(string fileName, float pixelSize)
        {
            NativeFont* nativeFontPtr = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(_atlasPtr, fileName, pixelSize, IntPtr.Zero, null);
            return new Font(nativeFontPtr);
        }

        public Font AddFontFromMemoryTTF(IntPtr ttfData, int ttfDataSize, float pixelSize)
        {
            NativeFont* nativeFontPtr = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(_atlasPtr, ttfData.ToPointer(), ttfDataSize, pixelSize, IntPtr.Zero, null);
            return new Font(nativeFontPtr);
        }

        public Font AddFontFromMemoryTTF(IntPtr ttfData, int ttfDataSize, float pixelSize, IntPtr fontConfig)
        {
            NativeFont* nativeFontPtr = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(_atlasPtr, ttfData.ToPointer(), ttfDataSize, pixelSize, fontConfig, null);
            return new Font(nativeFontPtr);
        }

    }

    public unsafe struct FontTextureData
    {
        public readonly byte* Pixels;
        public readonly int Width;
        public readonly int Height;
        public readonly int BytesPerPixel;

        public FontTextureData(byte* pixels, int width, int height, int bytesPerPixel)
        {
            Pixels = pixels;
            Width = width;
            Height = height;
            BytesPerPixel = bytesPerPixel;
        }
    }
}
