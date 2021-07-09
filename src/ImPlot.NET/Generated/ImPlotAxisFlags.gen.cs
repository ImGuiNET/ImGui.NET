namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotAxisFlags
    {
        None = 0,
        NoLabel = 1,
        NoGridLines = 2,
        NoTickMarks = 4,
        NoTickLabels = 8,
        Foreground = 16,
        LogScale = 32,
        Time = 64,
        Invert = 128,
        NoInitialFit = 256,
        AutoFit = 512,
        RangeFit = 1024,
        LockMin = 2048,
        LockMax = 4096,
        Lock = 6144,
        NoDecorations = 15,
    }
}
