namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiHoveredFlags
    {
        None = 0,
        ChildWindows = 1,
        RootWindow = 2,
        AnyWindow = 4,
        NoPopupHierarchy = 8,
        DockHierarchy = 16,
        AllowWhenBlockedByPopup = 32,
        AllowWhenBlockedByActiveItem = 128,
        AllowWhenOverlapped = 256,
        AllowWhenDisabled = 512,
        NoNavOverride = 1024,
        RectOnly = 416,
        RootAndChildWindows = 3,
        DelayNormal = 2048,
        DelayShort = 4096,
        NoSharedDelay = 8192,
    }
}
