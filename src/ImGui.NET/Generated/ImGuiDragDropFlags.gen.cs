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
        PayloadAutoExpire = 32,
        PayloadNoCrossContext = 64,
        PayloadNoCrossProcess = 128,
        AcceptBeforeDelivery = 1024,
        AcceptNoDrawDefaultRect = 2048,
        AcceptNoPreviewTooltip = 4096,
        AcceptPeekOnly = 3072,
    }
}
