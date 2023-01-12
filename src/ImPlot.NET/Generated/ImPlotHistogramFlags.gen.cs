namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotHistogramFlags
    {
        None = 0,
        Horizontal = 1024,
        Cumulative = 2048,
        Density = 4096,
        NoOutliers = 8192,
        ColMajor = 16384,
    }
}
