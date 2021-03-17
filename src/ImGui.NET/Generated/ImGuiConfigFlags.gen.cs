namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiConfigFlags
    {
        None = 0,
        NavEnableKeyboard = 1,
        NavEnableGamepad = 2,
        NavEnableSetMousePos = 4,
        NavNoCaptureKeyboard = 8,
        NoMouse = 16,
        NoMouseCursorChange = 32,
        IsSRGB = 1048576,
        IsTouchScreen = 2097152,
    }
}
