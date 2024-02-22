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
        NoInitialFit = 16,
        NoMenus = 32,
        NoSideSwitch = 64,
        NoHighlight = 128,
        Opposite = 256,
        Foreground = 512,
        Invert = 1024,
        AutoFit = 2048,
        RangeFit = 4096,
        PanStretch = 8192,
        LockMin = 16384,
        LockMax = 32768,
        Lock = 49152,
        NoDecorations = 15,
        AuxDefault = 258,
    }
}
