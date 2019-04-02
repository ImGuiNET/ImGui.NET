namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiColorEditFlags
    {
        None = 0,
        NoAlpha = 1 << 1,
        NoPicker = 1 << 2,
        NoOptions = 1 << 3,
        NoSmallPreview = 1 << 4,
        NoInputs = 1 << 5,
        NoTooltip = 1 << 6,
        NoLabel = 1 << 7,
        NoSidePreview = 1 << 8,
        NoDragDrop = 1 << 9,
        AlphaBar = 1 << 16,
        AlphaPreview = 1 << 17,
        AlphaPreviewHalf = 1 << 18,
        HDR = 1 << 19,
        DisplayRGB = 1 << 20,
        DisplayHSV = 1 << 21,
        DisplayHex = 1 << 22,
        Uint8 = 1 << 23,
        Float = 1 << 24,
        PickerHueBar = 1 << 25,
        PickerHueWheel = 1 << 26,
        InputRGB = 1 << 27,
        InputHSV = 1 << 28,
        _OptionsDefault = Uint8|DisplayRGB|InputRGB|PickerHueBar,
        _DisplayMask = DisplayRGB|DisplayHSV|DisplayHex,
        _DataTypeMask = Uint8|Float,
        _PickerMask = PickerHueWheel|PickerHueBar,
        _InputMask = InputRGB|InputHSV,
    }
}
