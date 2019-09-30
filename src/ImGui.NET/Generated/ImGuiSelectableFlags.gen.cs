namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSelectableFlags
    {
        None = 0,
        DontClosePopups = 1 << 0,
        SpanAllColumns = 1 << 1,
        AllowDoubleClick = 1 << 2,
        Disabled = 1 << 3,
        AllowItemOverlap = 1 << 4,
    }
}
