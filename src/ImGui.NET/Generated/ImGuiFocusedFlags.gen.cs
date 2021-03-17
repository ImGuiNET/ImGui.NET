namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiFocusedFlags
    {
        None = 0,
        ChildWindows = 1,
        RootWindow = 2,
        AnyWindow = 4,
        RootAndChildWindows = 3,
    }
}
