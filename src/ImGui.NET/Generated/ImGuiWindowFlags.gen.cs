namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiWindowFlags
    {
        None = 0,
        NoTitleBar = 1,
        NoResize = 2,
        NoMove = 4,
        NoScrollbar = 8,
        NoScrollWithMouse = 16,
        NoCollapse = 32,
        AlwaysAutoResize = 64,
        NoBackground = 128,
        NoSavedSettings = 256,
        NoMouseInputs = 512,
        MenuBar = 1024,
        HorizontalScrollbar = 2048,
        NoFocusOnAppearing = 4096,
        NoBringToFrontOnFocus = 8192,
        AlwaysVerticalScrollbar = 16384,
        AlwaysHorizontalScrollbar = 32768,
        NoNavInputs = 65536,
        NoNavFocus = 131072,
        UnsavedDocument = 262144,
        NoDocking = 524288,
        NoNav = 196608,
        NoDecoration = 43,
        NoInputs = 197120,
        ChildWindow = 16777216,
        Tooltip = 33554432,
        Popup = 67108864,
        Modal = 134217728,
        ChildMenu = 268435456,
        DockNodeHost = 536870912,
    }
}
