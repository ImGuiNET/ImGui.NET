namespace ImGuiNET
{
    /// <summary>
    /// Enumeration for GetMouseCursor()
    /// </summary>
    public enum MouseCursorKind
    {
        Arrow = 0,
        /// <summary>
        /// When hovering over InputText, etc.
        /// </summary>
        TextInput,
        /// <summary>
        /// Unused
        /// </summary>
        Move,
        /// <summary>
        /// Unused
        /// </summary>
        ResizeNS,
        /// <summary>
        /// When hovering over a column
        /// </summary>
        ResizeEW,
        /// <summary>
        /// Unused
        /// </summary>
        ResizeNESW,
        /// <summary>
        /// When hovering over the bottom-right corner of a window
        /// </summary>
        ResizeNWSE,
    }
}
