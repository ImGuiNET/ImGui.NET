namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSliderFlags
    {
        None = 0,
        Logarithmic = 32,
        NoRoundToFormat = 64,
        NoInput = 128,
        WrapAround = 256,
        ClampOnInput = 512,
        ClampZeroRange = 1024,
        AlwaysClamp = 1536,
        InvalidMask = 1879048207,
    }
}
