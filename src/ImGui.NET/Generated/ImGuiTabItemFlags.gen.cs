namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTabItemFlags
    {
        None = 0,
        UnsavedDocument = 1,
        SetSelected = 2,
        NoCloseWithMiddleMouseButton = 4,
        NoPushId = 8,
        NoTooltip = 16,
        NoReorder = 32,
        Leading = 64,
        Trailing = 128,
    }
}
