namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiChildFlags
    {
        None = 0,
        Borders = 1,
        AlwaysUseWindowPadding = 2,
        ResizeX = 4,
        ResizeY = 8,
        AutoResizeX = 16,
        AutoResizeY = 32,
        AlwaysAutoResize = 64,
        FrameStyle = 128,
        NavFlattened = 256,
    }
}
