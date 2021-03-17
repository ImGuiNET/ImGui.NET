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
    }
}
