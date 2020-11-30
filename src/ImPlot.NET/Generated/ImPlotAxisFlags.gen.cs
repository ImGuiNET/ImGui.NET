namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotAxisFlags
    {
        None = 0,
        NoGridLines = 1 << 0,
        NoTickMarks = 1 << 1,
        NoTickLabels = 1 << 2,
        LogScale = 1 << 3,
        Time = 1 << 4,
        Invert = 1 << 5,
        LockMin = 1 << 6,
        LockMax = 1 << 7,
        Lock = LockMin | LockMax,
        NoDecorations = NoGridLines | NoTickMarks | NoTickLabels,
    }
}
