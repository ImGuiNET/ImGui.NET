namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiViewportFlags
    {
        None = 0,
        NoDecoration = 1 << 0,
        NoFocusOnAppearing = 1 << 1,
        NoInputs = 1 << 2,
        NoTaskBarIcon = 1 << 3,
        NoRendererClear = 1 << 4,
        TopMost = 1 << 5,
    }
}
