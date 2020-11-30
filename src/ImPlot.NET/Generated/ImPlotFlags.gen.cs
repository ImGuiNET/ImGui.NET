namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotFlags
    {
        None = 0,
        NoLegend = 1 << 0,
        NoMenus = 1 << 1,
        NoBoxSelect = 1 << 2,
        NoMousePos = 1 << 3,
        NoHighlight = 1 << 4,
        NoChild = 1 << 5,
        YAxis2 = 1 << 6,
        YAxis3 = 1 << 7,
        Query = 1 << 8,
        Crosshairs = 1 << 9,
        AntiAliased = 1 << 10,
        CanvasOnly = NoLegend | NoMenus | NoBoxSelect | NoMousePos,
    }
}
