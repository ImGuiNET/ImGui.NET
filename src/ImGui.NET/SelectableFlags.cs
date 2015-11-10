namespace ImGuiNET
{
    /// <summary>
    /// Flags for ImGui::Selectable()
    /// </summary>
    public enum SelectableFlags
    {
        // Default: 0
        Default = 0,
        /// <summary>
        /// Clicking this doesn't close parent popup window
        /// </summary>
        DontClosePopups = 1 << 0,
        /// <summary>
        /// Selectable frame can span all columns (text will still fit in current column)
        /// </summary>
        SpanAllColumns = 1 << 1
    }
}
