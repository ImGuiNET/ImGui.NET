namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotLineFlags
    {
        None = 0,
        Segments = 1024,
        Loop = 2048,
        SkipNaN = 4096,
        NoClip = 8192,
        Shaded = 16384,
    }
}
