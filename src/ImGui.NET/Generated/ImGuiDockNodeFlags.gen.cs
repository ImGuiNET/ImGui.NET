namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1,
        NoDockingInCentralNode = 4,
        PassthruCentralNode = 8,
        NoSplit = 16,
        NoResize = 32,
        AutoHideTabBar = 64,
    }
}
