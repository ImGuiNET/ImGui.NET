namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiInputTextFlags
    {
        None = 0,
        CharsDecimal = 1,
        CharsHexadecimal = 2,
        CharsScientific = 4,
        CharsUppercase = 8,
        CharsNoBlank = 16,
        AllowTabInput = 32,
        EnterReturnsTrue = 64,
        EscapeClearsAll = 128,
        CtrlEnterForNewLine = 256,
        ReadOnly = 512,
        Password = 1024,
        AlwaysOverwrite = 2048,
        AutoSelectAll = 4096,
        ParseEmptyRefVal = 8192,
        DisplayEmptyRefVal = 16384,
        NoHorizontalScroll = 32768,
        NoUndoRedo = 65536,
        CallbackCompletion = 131072,
        CallbackHistory = 262144,
        CallbackAlways = 524288,
        CallbackCharFilter = 1048576,
        CallbackResize = 2097152,
        CallbackEdit = 4194304,
    }
}
