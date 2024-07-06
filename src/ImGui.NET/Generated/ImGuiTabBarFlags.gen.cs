namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTabBarFlags
    {
        None = 0,
        Reorderable = 1,
        AutoSelectNewTabs = 2,
        TabListPopupButton = 4,
        NoCloseWithMiddleMouseButton = 8,
        NoTabListScrollingButtons = 16,
        NoTooltip = 32,
        DrawSelectedOverline = 64,
        FittingPolicyResizeDown = 128,
        FittingPolicyScroll = 256,
        FittingPolicyMask = 384,
        FittingPolicyDefault = 128,
    }
}
