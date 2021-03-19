namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiBackendFlags
    {
        None = 0,
        HasGamepad = 1,
        HasMouseCursors = 2,
        HasSetMousePos = 4,
        RendererHasVtxOffset = 8,
        PlatformHasViewports = 1024,
        HasMouseHoveredViewport = 2048,
        RendererHasViewports = 4096,
    }
}
