namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiNavMoveFlags
    {
        None = 0,
        LoopX = 1,
        LoopY = 2,
        WrapX = 4,
        WrapY = 8,
        AllowCurrentNavId = 16,
        AlsoScoreVisibleSet = 32,
        ScrollToEdge = 64,
        Forwarded = 128,
        DebugNoResult = 256,
    }
}
