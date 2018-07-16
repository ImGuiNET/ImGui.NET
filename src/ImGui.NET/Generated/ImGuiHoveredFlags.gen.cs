namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiHoveredFlags
    {
        None = 0,
        ChildWindows = 1 << 0,
        RootWindow = 1 << 1,
        AnyWindow = 1 << 2,
        AllowWhenBlockedByPopup = 1 << 3,
        AllowWhenBlockedByActiveItem = 1 << 5,
        AllowWhenOverlapped = 1 << 6,
        AllowWhenDisabled = 1 << 7,
        RectOnly = AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | AllowWhenOverlapped,
        RootAndChildWindows = RootWindow | ChildWindows,
    }
}
