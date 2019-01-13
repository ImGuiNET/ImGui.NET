namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1 << 0,
        NoSplit = 1 << 1,
        NoDockingInCentralNode = 1 << 3,
        NoResize = 1 << 5,
        PassthruDockspace = 1 << 6,
    }
}
