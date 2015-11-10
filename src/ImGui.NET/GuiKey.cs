namespace ImGuiNET
{
    /// <summary>
    /// User fill ImGuiIO.KeyMap[] array with indices into the ImGuiIO.KeysDown[512] array
    /// </summary>
    public enum GuiKey : int
    {
        /// <summary>
        /// for tabbing through fields
        /// </summary>
        Tab,
        /// <summary>
        /// for text edit
        /// </summary>
        LeftArrow,
        /// <summary>
        /// for text edit
        /// </summary>
        RightArrow,
        /// <summary>
        /// for text edit
        /// </summary>
        UpArrow,
        /// <summary>
        /// for text edit
        /// </summary>
        DownArrow,
        PageUp,
        PageDown,
        /// <summary>
        /// for text edit
        /// </summary>
        Home,
        /// <summary>
        /// for text edit
        /// </summary>
        End,
        /// <summary>
        /// for text edit
        /// </summary>
        Delete,
        /// <summary>
        /// for text edit
        /// </summary>
        Backspace,
        /// <summary>
        /// for text edit
        /// </summary>
        Enter,
        /// <summary>
        /// for text edit
        /// </summary>
        Escape,
        /// <summary>
        /// for text edit CTRL+A: select all
        /// </summary>
        A,
        /// <summary>
        /// for text edit CTRL+C: copy
        /// </summary>
        C,
        /// <summary>
        /// for text edit CTRL+V: paste
        /// </summary>
        V,
        /// <summary>
        /// for text edit CTRL+X: cut
        /// </summary>
        X,
        /// <summary>
        /// for text edit CTRL+Y: redo
        /// </summary>
        Y,
        /// <summary>
        /// for text edit CTRL+Z: undo
        /// </summary>
        Z,
        Count
    }
}
