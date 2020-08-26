namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSliderFlags
    {
        None = 0,
        ClampOnInput = 1 << 4,
        Logarithmic = 1 << 5,
        NoRoundToFormat = 1 << 6,
        NoInput = 1 << 7,
        InvalidMask = 0x7000000F,
    }
}
