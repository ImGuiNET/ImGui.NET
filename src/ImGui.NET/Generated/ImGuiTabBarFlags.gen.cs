namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTabBarFlags
    {
        None = 0,
        Reorderable = 1 << 0,
        AutoSelectNewTabs = 1 << 1,
        NoCloseWithMiddleMouseButton = 1 << 2,
        NoTabListPopupButton = 1 << 3,
        NoTabListScrollingButtons = 1 << 4,
        NoTooltip = 1 << 5,
        FittingPolicyResizeDown = 1 << 6,
        FittingPolicyScroll = 1 << 7,
        FittingPolicyMask = FittingPolicyResizeDown | FittingPolicyScroll,
        FittingPolicyDefault = FittingPolicyResizeDown,
    }
}
