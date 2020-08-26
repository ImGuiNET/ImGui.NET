namespace ImGuiNET
{
    [System.Flags]
    public enum ImDrawListFlags
    {
        None = 0,
        AntiAliasedLines = 1 << 0,
        AntiAliasedLinesUseTex = 1 << 1,
        AntiAliasedFill = 1 << 2,
        AllowVtxOffset = 1 << 3,
    }
}
