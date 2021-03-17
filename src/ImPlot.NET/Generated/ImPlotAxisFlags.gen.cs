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
        LogScale = 16,
        Time = 32,
        Invert = 64,
        LockMin = 128,
        LockMax = 256,
        Lock = 384,
        NoDecorations = 15,
    }
}
