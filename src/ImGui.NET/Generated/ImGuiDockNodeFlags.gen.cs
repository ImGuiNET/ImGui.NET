namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1,
        NoDockingOverCentralNode = 4,
        PassthruCentralNode = 8,
        NoDockingSplit = 16,
        NoResize = 32,
        AutoHideTabBar = 64,
        NoUndocking = 128,
    }
}
