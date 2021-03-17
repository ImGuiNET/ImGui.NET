namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTableColumnFlags
    {
        None = 0,
        DefaultHide = 1,
        DefaultSort = 2,
        WidthStretch = 4,
        WidthFixed = 8,
        NoResize = 16,
        NoReorder = 32,
        NoHide = 64,
        NoClip = 128,
        NoSort = 256,
        NoSortAscending = 512,
        NoSortDescending = 1024,
        NoHeaderWidth = 2048,
        PreferSortAscending = 4096,
        PreferSortDescending = 8192,
        IndentEnable = 16384,
        IndentDisable = 32768,
        IsEnabled = 1048576,
        IsVisible = 2097152,
        IsSorted = 4194304,
        IsHovered = 8388608,
        WidthMask = 12,
        IndentMask = 49152,
        StatusMask = 15728640,
        NoDirectResize = 1073741824,
    }
}
