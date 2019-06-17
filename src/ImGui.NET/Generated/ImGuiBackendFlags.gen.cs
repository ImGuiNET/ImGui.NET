namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiBackendFlags
    {
        None = 0,
        HasGamepad = 1 << 0,
        HasMouseCursors = 1 << 1,
        HasSetMousePos = 1 << 2,
        RendererHasVtxOffset = 1 << 3,
    }
}
