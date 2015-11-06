namespace ImGuiNET
{
    /// <summary>
    /// Enumeration for PushStyleVar() / PopStyleVar()
    /// NB: the enum only refers to fields of ImGuiStyle() which makes sense to be pushed/poped in UI code. Feel free to add others.
    /// </summary>
    public enum StyleVar
    {
        /// <summary>
        /// float
        /// </summary>
        Alpha,
        /// <summary>
        /// System.Numerics.Vector2
        /// </summary>
        WindowPadding,
        /// <summary>
        /// float
        /// </summary>
        WindowRounding,
        /// <summary>
        /// System.Numerics.Vector2
        /// </summary>
        WindowMinSize,
        /// <summary>
        /// float
        /// </summary>
        ChildWindowRounding,
        /// <summary>
        /// System.Numerics.Vector2
        /// </summary>
        FramePadding,
        /// <summary>
        /// float
        /// </summary>
        FrameRounding,
        /// <summary>
        /// System.Numerics.Vector2
        /// </summary>
        ItemSpacing,
        /// <summary>
        /// System.Numerics.Vector2
        /// </summary>
        ItemInnerSpacing,
        /// <summary>
        /// float
        /// </summary>
        IndentSpacing,
        /// <summary>
        /// float
        /// </summary>
        GrabMinSize
    };
}
