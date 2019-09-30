namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiViewportFlags
    {
        None = 0,
        NoDecoration = 1 << 0,
        NoTaskBarIcon = 1 << 1,
        NoFocusOnAppearing = 1 << 2,
        NoFocusOnClick = 1 << 3,
        NoInputs = 1 << 4,
        NoRendererClear = 1 << 5,
        TopMost = 1 << 6,
        Minimized = 1 << 7,
        NoAutoMerge = 1 << 8,
        CanHostOtherWindows = 1 << 9,
    }
}
