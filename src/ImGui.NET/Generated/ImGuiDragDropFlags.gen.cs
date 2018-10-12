namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDragDropFlags
    {
        None = 0,
        SourceNoPreviewTooltip = 1 << 0,
        SourceNoDisableHover = 1 << 1,
        SourceNoHoldToOpenOthers = 1 << 2,
        SourceAllowNullID = 1 << 3,
        SourceExtern = 1 << 4,
        SourceAutoExpirePayload = 1 << 5,
        AcceptBeforeDelivery = 1 << 10,
        AcceptNoDrawDefaultRect = 1 << 11,
        AcceptNoPreviewTooltip = 1 << 12,
        AcceptPeekOnly = AcceptBeforeDelivery | AcceptNoDrawDefaultRect,
    }
}
