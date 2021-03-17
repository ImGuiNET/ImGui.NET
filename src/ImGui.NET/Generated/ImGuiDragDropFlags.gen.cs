namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDragDropFlags
    {
        None = 0,
        SourceNoPreviewTooltip = 1,
        SourceNoDisableHover = 2,
        SourceNoHoldToOpenOthers = 4,
        SourceAllowNullID = 8,
        SourceExtern = 16,
        SourceAutoExpirePayload = 32,
        AcceptBeforeDelivery = 1024,
        AcceptNoDrawDefaultRect = 2048,
        AcceptNoPreviewTooltip = 4096,
        AcceptPeekOnly = 3072,
    }
}
