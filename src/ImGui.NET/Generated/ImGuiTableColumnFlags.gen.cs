namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTableColumnFlags
    {
        None = 0,
        Disabled = 1,
        DefaultHide = 2,
        DefaultSort = 4,
        WidthStretch = 8,
        WidthFixed = 16,
        NoResize = 32,
        NoReorder = 64,
        NoHide = 128,
        NoClip = 256,
        NoSort = 512,
        NoSortAscending = 1024,
        NoSortDescending = 2048,
        NoHeaderLabel = 4096,
        NoHeaderWidth = 8192,
        PreferSortAscending = 16384,
        PreferSortDescending = 32768,
        IndentEnable = 65536,
        IndentDisable = 131072,
        AngledHeader = 262144,
        IsEnabled = 16777216,
        IsVisible = 33554432,
        IsSorted = 67108864,
        IsHovered = 134217728,
        WidthMask = 24,
        IndentMask = 196608,
        StatusMask = 251658240,
        NoDirectResize = 1073741824,
    }
}
