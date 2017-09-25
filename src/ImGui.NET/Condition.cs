namespace ImGuiNET
{
    /// <summary>
    /// Condition flags for ImGui::SetWindow***(), SetNextWindow***(), SetNextTreeNode***() functions.
    /// All those functions treat 0 as a shortcut to Always.
    /// </summary>
    public enum Condition
    {
        /// <summary>
        /// Set the variable.
        /// </summary>
        Always = 1 << 0,
        /// <summary>
        /// Only set the variable on the first call per runtime session
        /// </summary>
        Once = 1 << 1,
        /// <summary>
        /// Only set the variable if the window doesn't exist in the .ini file
        /// </summary>
        FirstUseEver = 1 << 2,
        /// <summary>
        /// Only set the variable if the window is appearing after being inactive (or the first time)
        /// </summary>
        Appearing = 1 << 3
    }
}
