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
        FittingPolicyResizeDown = 64,
        FittingPolicyScroll = 128,
        FittingPolicyMask = 192,
        FittingPolicyDefault = 64,
    }
}
