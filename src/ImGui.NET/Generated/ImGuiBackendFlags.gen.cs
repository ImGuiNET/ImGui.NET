namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiBackendFlags
    {
        HasGamepad = 1 << 0,
        HasMouseCursors = 1 << 1,
        HasSetMousePos = 1 << 2,
    }
}
