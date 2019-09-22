namespace ImGuiNET
{
    [System.Flags]
    public enum ImDrawCornerFlags
    {
        None = 0,
        TopLeft = 1 << 0,
        TopRight = 1 << 1,
        BotLeft = 1 << 2,
        BotRight = 1 << 3,
        Top = TopLeft | TopRight,
        Bot = BotLeft | BotRight,
        Left = TopLeft | BotLeft,
        Right = TopRight | BotRight,
        All = 0xF,
    }
}
