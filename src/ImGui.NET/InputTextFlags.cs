namespace ImGuiNET
{
    /// <summary>
    /// Flags for ImGui.InputText()
    /// </summary>
    public enum InputTextFlags : int
    {
        Default = 0,
        /// <summary>
        /// Allow 0123456789.+-*/
        /// </summary>
        CharsDecimal = 1 << 0,
        /// <summary>
        /// Allow 0123456789ABCDEFabcdef
        /// </summary>
        CharsHexadecimal = 1 << 1,
        /// <summary>
        /// Turn a..z into A..Z
        /// </summary>
        CharsUppercase = 1 << 2,
        /// <summary>
        /// Filter out spaces, tabs
        /// </summary>
        CharsNoBlank = 1 << 3,
        /// <summary>
        /// Select entire text when first taking mouse focus
        /// </summary>
        AutoSelectAll = 1 << 4,
        /// <summary>
        /// Return 'true' when Enter is pressed (as opposed to when the value was modified)
        /// </summary>
        EnterReturnsTrue = 1 << 5,
        /// <summary>
        /// Call user function on pressing TAB (for completion handling)
        /// </summary>
        CallbackCompletion = 1 << 6,
        /// <summary>
        /// Call user function on pressing Up/Down arrows (for history handling)
        /// </summary>
        CallbackHistory = 1 << 7,
        /// <summary>
        /// Call user function every time
        /// </summary>
        CallbackAlways = 1 << 8,
        /// <summary>
        /// Call user function to filter character. Modify data->EventChar to replace/filter input, or return 1 to discard character.
        /// </summary>
        CallbackCharFilter = 1 << 9,
        /// <summary>
        /// Pressing TAB input a '\t' character into the text field
        /// </summary>
        AllowTabInput = 1 << 10,
        /// <summary>
        /// In multi-line mode, allow exiting edition by pressing Enter. Ctrl+Enter to add new line (by default adds new lines with Enter).
        /// </summary>
        CtrlEnterForNewLine = 1 << 11,
        /// <summary>
        /// Disable following the cursor horizontally
        /// </summary>
        NoHorizontalScroll = 1 << 12,
        /// <summary>
        /// Insert mode
        /// </summary>
        AlwaysInsertMode = 1 << 13,
        /// <summary>
        /// Read-only mode
        /// </summary>
        ReadOnly = 1 << 14,
        /// <summary>
        /// Password mode, display all characters as '*'
        /// </summary>
        Password,
        /// <summary>
        /// Disable undo/redo. Note that input text owns the text data while active, if you want to provide your own undo/redo stack you need e.g. to call ClearActiveID().
        /// </summary>
        NoUndoRedo,
        /// <summary>
        /// For internal use by InputTextMultiline()
        /// </summary>
        Multiline = 1 << 20
    }
}
