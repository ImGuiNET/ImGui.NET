namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiWindowFlags
    {
        None = 0,
        NoTitleBar = 1 << 0,
        NoResize = 1 << 1,
        NoMove = 1 << 2,
        NoScrollbar = 1 << 3,
        NoScrollWithMouse = 1 << 4,
        NoCollapse = 1 << 5,
        AlwaysAutoResize = 1 << 6,
        NoBackground = 1 << 7,
        NoSavedSettings = 1 << 8,
        NoMouseInputs = 1 << 9,
        MenuBar = 1 << 10,
        HorizontalScrollbar = 1 << 11,
        NoFocusOnAppearing = 1 << 12,
        NoBringToFrontOnFocus = 1 << 13,
        AlwaysVerticalScrollbar = 1 << 14,
        AlwaysHorizontalScrollbar = 1<< 15,
        AlwaysUseWindowPadding = 1 << 16,
        NoNavInputs = 1 << 18,
        NoNavFocus = 1 << 19,
        UnsavedDocument = 1 << 20,
        NoNav = NoNavInputs | NoNavFocus,
        NoDecoration = NoTitleBar | NoResize | NoScrollbar | NoCollapse,
        NoInputs = NoMouseInputs | NoNavInputs | NoNavFocus,
        NavFlattened = 1 << 23,
        ChildWindow = 1 << 24,
        Tooltip = 1 << 25,
        Popup = 1 << 26,
        Modal = 1 << 27,
        ChildMenu = 1 << 28,
    }
}
