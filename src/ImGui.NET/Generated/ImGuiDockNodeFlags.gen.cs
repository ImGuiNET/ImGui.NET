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
		DockSpace = 128,
		CentralNode = 256,
		NoTabBar = 512,
		HiddenTabBar = 1024,
		NoWindowMenuButton = 2048,
		NoCloseButton = 4096,
		NoDocking = 8192,
		NoDockingSplitMe = 16384,
		NoDockingSplitOther = 32768,
		NoDockingOverMe = 65536,
		NoDockingOverOther = 131072,
		NoResizeX = 262144,
		NoResizeY = 524288
    }
}
