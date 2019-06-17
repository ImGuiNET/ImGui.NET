namespace ImGuiNET
{
    [System.Flags]
    public enum ImDrawListFlags
    {
        None = 0,
        AntiAliasedLines = 1 << 0,
        AntiAliasedFill = 1 << 1,
        AllowVtxOffset = 1 << 2,
    }
}
