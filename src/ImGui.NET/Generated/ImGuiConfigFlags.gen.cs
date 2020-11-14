namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiConfigFlags
    {
        None = 0,
        NavEnableKeyboard = 1 << 0,
        NavEnableGamepad = 1 << 1,
        NavEnableSetMousePos = 1 << 2,
        NavNoCaptureKeyboard = 1 << 3,
        NoMouse = 1 << 4,
        NoMouseCursorChange = 1 << 5,
        DockingEnable = 1 << 6,
        ViewportsEnable = 1 << 10,
        DpiEnableScaleViewports = 1 << 14,
        DpiEnableScaleFonts = 1 << 15,
        IsSRGB = 1 << 20,
        IsTouchScreen = 1 << 21,
    }
}
