namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiNextWindowDataFlags
    {
        None = 0,
        HasPos = 1,
        HasSize = 2,
        HasContentSize = 4,
        HasCollapsed = 8,
        HasSizeConstraint = 16,
        HasFocus = 32,
        HasBgAlpha = 64,
        HasScroll = 128,
        HasViewport = 256,
        HasDock = 512,
        HasWindowClass = 1024,
    }
}
