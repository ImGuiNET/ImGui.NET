namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiFreeTypeBuilderFlags
    {
        NoHinting = 1,
        NoAutoHint = 2,
        ForceAutoHint = 4,
        LightHinting = 8,
        MonoHinting = 16,
        Bold = 32,
        Oblique = 64,
        Monochrome = 128,
        LoadColor = 256,
        Bitmap = 512,
    }
}
