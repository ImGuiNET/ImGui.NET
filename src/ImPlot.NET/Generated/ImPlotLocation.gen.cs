namespace ImPlotNET
{
    public enum ImPlotLocation
    {
        Center = 0,
        North = 1 << 0,
        South = 1 << 1,
        West = 1 << 2,
        East = 1 << 3,
        NorthWest = North | West,
        NorthEast = North | East,
        SouthWest = South | West,
        SouthEast = South | East,
    }
}
