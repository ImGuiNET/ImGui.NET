namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSelectableFlags
    {
        None = 0,
        NoAutoClosePopups = 1,
        SpanAllColumns = 2,
        AllowDoubleClick = 4,
        Disabled = 8,
        AllowOverlap = 16,
        Highlight = 32,
    }
}
