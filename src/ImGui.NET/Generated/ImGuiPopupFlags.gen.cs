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
        NoReopen = 32,
        NoOpenOverExistingPopup = 128,
        NoOpenOverItems = 256,
        AnyPopupId = 1024,
        AnyPopupLevel = 2048,
        AnyPopup = 3072,
    }
}
