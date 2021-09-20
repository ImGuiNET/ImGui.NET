namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiHoveredFlags
    {
        None = 0,
        ChildWindows = 1,
        RootWindow = 2,
        AnyWindow = 4,
        DockHierarchy = 8,
        AllowWhenBlockedByPopup = 16,
        AllowWhenBlockedByActiveItem = 32,
        AllowWhenOverlapped = 64,
        AllowWhenDisabled = 128,
        RectOnly = 112,
        RootAndChildWindows = 3,
    }
}
