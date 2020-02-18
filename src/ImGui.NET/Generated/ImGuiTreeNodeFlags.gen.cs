namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTreeNodeFlags
    {
        None = 0,
        Selected = 1 << 0,
        Framed = 1 << 1,
        AllowItemOverlap = 1 << 2,
        NoTreePushOnOpen = 1 << 3,
        NoAutoOpenOnLog = 1 << 4,
        DefaultOpen = 1 << 5,
        OpenOnDoubleClick = 1 << 6,
        OpenOnArrow = 1 << 7,
        Leaf = 1 << 8,
        Bullet = 1 << 9,
        FramePadding = 1 << 10,
        SpanAvailWidth = 1 << 11,
        SpanFullWidth = 1 << 12,
        NavLeftJumpsBackHere = 1 << 13,
        CollapsingHeader = Framed | NoTreePushOnOpen | NoAutoOpenOnLog,
    }
}
