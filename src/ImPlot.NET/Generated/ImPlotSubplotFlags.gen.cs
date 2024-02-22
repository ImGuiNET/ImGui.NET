namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotSubplotFlags
    {
        None = 0,
        NoTitle = 1,
        NoLegend = 2,
        NoMenus = 4,
        NoResize = 8,
        NoAlign = 16,
        ShareItems = 32,
        LinkRows = 64,
        LinkCols = 128,
        LinkAllX = 256,
        LinkAllY = 512,
        ColMajor = 1024,
    }
}
