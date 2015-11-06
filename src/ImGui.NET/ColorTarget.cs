namespace ImGuiNET
{
    /// <summary>
    /// Enumeration for PushStyleColor() / PopStyleColor()
    /// </summary>
    public enum ColorTarget
    {
        Text,
        TextDisabled,
        WindowBg,
        ChildWindowBg,
        Border,
        BorderShadow,
        /// <summary>
        /// Background of checkbox, radio button, plot, slider, text input
        /// </summary>
        FrameBg,
        FrameBgHovered,
        FrameBgActive,
        TitleBg,
        TitleBgCollapsed,
        TitleBgActive,
        MenuBarBg,
        ScrollbarBg,
        ScrollbarGrab,
        ScrollbarGrabHovered,
        ScrollbarGrabActive,
        ComboBg,
        CheckMark,
        SliderGrab,
        SliderGrabActive,
        Button,
        ButtonHovered,
        ButtonActive,
        Header,
        HeaderHovered,
        HeaderActive,
        Column,
        ColumnHovered,
        ColumnActive,
        ResizeGrip,
        ResizeGripHovered,
        ResizeGripActive,
        CloseButton,
        CloseButtonHovered,
        CloseButtonActive,
        PlotLines,
        PlotLinesHovered,
        PlotHistogram,
        PlotHistogramHovered,
        TextSelectedBg,
        TooltipBg,
        /// <summary>
        /// darken entire screen when a modal window is active
        /// </summary>
        ModalWindowDarkening,
        Count,
    };
}
