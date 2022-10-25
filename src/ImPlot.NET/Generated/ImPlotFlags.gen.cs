namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotFlags
    {
        None = 0,
        NoTitle = 1,
        NoLegend = 2,
        NoMouseText = 4,
        NoInputs = 8,
        NoMenus = 16,
        NoBoxSelect = 32,
        NoChild = 64,
        NoFrame = 128,
        Equal = 256,
        Crosshairs = 512,
        CanvasOnly = 55,
    }
}
