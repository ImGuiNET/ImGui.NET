namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiPopupFlags
    {
        None = 0,
        MouseButtonLeft = 0,
        MouseButtonRight = 1,
        MouseButtonMiddle = 2,
        MouseButtonMask = 0x1F,
        MouseButtonDefault = 1,
        NoOpenOverExistingPopup = 1 << 5,
        NoOpenOverItems = 1 << 6,
        AnyPopupId = 1 << 7,
        AnyPopupLevel = 1 << 8,
        AnyPopup = AnyPopupId | AnyPopupLevel,
    }
}
