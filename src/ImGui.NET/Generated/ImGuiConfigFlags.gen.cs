namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiConfigFlags
    {
        None = 0,
        NavEnableKeyboard = 1,
        NavEnableGamepad = 2,
        NoMouse = 16,
        NoMouseCursorChange = 32,
        NoKeyboard = 64,
        DockingEnable = 128,
        ViewportsEnable = 1024,
        DpiEnableScaleViewports = 16384,
        DpiEnableScaleFonts = 32768,
        IsSRGB = 1048576,
        IsTouchScreen = 2097152,
    }
}
