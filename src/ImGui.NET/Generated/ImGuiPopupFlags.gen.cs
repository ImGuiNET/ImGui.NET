namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiPopupFlags
    {
        None = 0,
        MouseButtonLeft = 0,
        MouseButtonRight = 1,
        MouseButtonMiddle = 2,
        MouseButtonMask = 31,
        MouseButtonDefault = 1,
        NoOpenOverExistingPopup = 32,
        NoOpenOverItems = 64,
        AnyPopupId = 128,
        AnyPopupLevel = 256,
        AnyPopup = 384,
    }
}
