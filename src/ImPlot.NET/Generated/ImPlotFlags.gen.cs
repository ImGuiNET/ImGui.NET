namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotFlags
    {
        None = 0,
        NoTitle = 1,
        NoLegend = 2,
        NoMenus = 4,
        NoBoxSelect = 8,
        NoMousePos = 16,
        NoHighlight = 32,
        NoChild = 64,
        Equal = 128,
        YAxis2 = 256,
        YAxis3 = 512,
        Query = 1024,
        Crosshairs = 2048,
        AntiAliased = 4096,
        CanvasOnly = 31,
    }
}
