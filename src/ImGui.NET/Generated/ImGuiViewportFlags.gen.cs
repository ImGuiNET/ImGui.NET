namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiViewportFlags
    {
        None = 0,
        IsPlatformWindow = 1,
        IsPlatformMonitor = 2,
        OwnedByApp = 4,
        NoDecoration = 8,
        NoTaskBarIcon = 16,
        NoFocusOnAppearing = 32,
        NoFocusOnClick = 64,
        NoInputs = 128,
        NoRendererClear = 256,
        NoAutoMerge = 512,
        TopMost = 1024,
        CanHostOtherWindows = 2048,
        IsMinimized = 4096,
        IsFocused = 8192,
    }
}
