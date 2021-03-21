namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiColorEditFlags
    {
        None = 0,
        NoAlpha = 2,
        NoPicker = 4,
        NoOptions = 8,
        NoSmallPreview = 16,
        NoInputs = 32,
        NoTooltip = 64,
        NoLabel = 128,
        NoSidePreview = 256,
        NoDragDrop = 512,
        NoBorder = 1024,
        AlphaBar = 65536,
        AlphaPreview = 131072,
        AlphaPreviewHalf = 262144,
        HDR = 524288,
        DisplayRGB = 1048576,
        DisplayHSV = 2097152,
        DisplayHex = 4194304,
        Uint8 = 8388608,
        Float = 16777216,
        PickerHueBar = 33554432,
        PickerHueWheel = 67108864,
        InputRGB = 134217728,
        InputHSV = 268435456,
        OptionsDefault = 177209344,
        DisplayMask = 7340032,
        DataTypeMask = 25165824,
        PickerMask = 100663296,
        InputMask = 402653184,
    }
}
