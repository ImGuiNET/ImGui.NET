namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1 << 0,
        NoDockingInCentralNode = 1 << 2,
        PassthruCentralNode = 1 << 3,
        NoSplit = 1 << 4,
        NoResize = 1 << 5,
        AutoHideTabBar = 1 << 6,
    }
}
