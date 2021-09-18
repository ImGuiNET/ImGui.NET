namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiButtonFlagsPrivate
    {
        ImGuiButtonFlags_PressedOnClick = 16,
        ImGuiButtonFlags_PressedOnClickRelease = 32,
        ImGuiButtonFlags_PressedOnClickReleaseAnywhere = 64,
        ImGuiButtonFlags_PressedOnRelease = 128,
        ImGuiButtonFlags_PressedOnDoubleClick = 256,
        ImGuiButtonFlags_PressedOnDragDropHold = 512,
        ImGuiButtonFlags_Repeat = 1024,
        ImGuiButtonFlags_FlattenChildren = 2048,
        ImGuiButtonFlags_AllowItemOverlap = 4096,
        ImGuiButtonFlags_DontClosePopups = 8192,
        ImGuiButtonFlags_AlignTextBaseLine = 32768,
        ImGuiButtonFlags_NoKeyModifiers = 65536,
        ImGuiButtonFlags_NoHoldingActiveId = 131072,
        ImGuiButtonFlags_NoNavFocus = 262144,
        ImGuiButtonFlags_NoHoveredOnFocus = 524288,
        ImGuiButtonFlags_PressedOnMask = 1008,
        ImGuiButtonFlags_PressedOnDefault = 32,
    }
}
