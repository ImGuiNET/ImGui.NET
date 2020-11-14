namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiButtonFlags
    {
        None = 0,
        MouseButtonLeft = 1 << 0,
        MouseButtonRight = 1 << 1,
        MouseButtonMiddle = 1 << 2,
        MouseButtonMask = MouseButtonLeft | MouseButtonRight | MouseButtonMiddle,
        MouseButtonDefault = MouseButtonLeft,
    }
}
