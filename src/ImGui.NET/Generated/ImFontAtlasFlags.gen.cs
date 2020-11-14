namespace ImGuiNET
{
    [System.Flags]
    public enum ImFontAtlasFlags
    {
        None = 0,
        NoPowerOfTwoHeight = 1 << 0,
        NoMouseCursors = 1 << 1,
        NoBakedLines = 1 << 2,
    }
}
