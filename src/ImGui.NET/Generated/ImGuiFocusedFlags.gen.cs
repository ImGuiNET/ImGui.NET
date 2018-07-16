namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiFocusedFlags
    {
        None = 0,
        ChildWindows = 1 << 0,
        RootWindow = 1 << 1,
        AnyWindow = 1 << 2,
        RootAndChildWindows = RootWindow | ChildWindows,
    }
}
