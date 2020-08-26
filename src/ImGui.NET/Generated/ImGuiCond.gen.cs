namespace ImGuiNET
{
    public enum ImGuiCond
    {
        None = 0,
        Always = 1 << 0,
        Once = 1 << 1,
        FirstUseEver = 1 << 2,
        Appearing = 1 << 3,
    }
}
