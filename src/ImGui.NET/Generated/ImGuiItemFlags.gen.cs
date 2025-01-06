namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiItemFlags
    {
        None = 0,
        NoTabStop = 1,
        NoNav = 2,
        NoNavDefaultFocus = 4,
        ButtonRepeat = 8,
        AutoClosePopups = 16,
        AllowDuplicateId = 32,
    }
}
