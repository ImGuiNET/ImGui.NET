namespace ImGuiNET
{
    public enum ComboFlags
    {
        /// <summary>
        /// Align the popup toward the left by default
        /// </summary>
        PopupAlignLeft = 1 << 0,
        /// <summary>
        /// Max ~4 items visible. Tip: If you want your combo popup to be a specific size you can use SetNextWindowSizeConstraints() prior to calling BeginCombo()
        /// </summary>
        HeightSmall = 1 << 1,
        /// <summary>
        /// Max ~8 items visible (default)
        /// </summary>
        HeightRegular = 1 << 2,
        /// <summary>
        /// Max ~20 items visible
        /// </summary>
        HeightLarge = 1 << 3,
        /// <summary>
        /// As many fitting items as possible
        /// </summary>
        HeightLargest = 1 << 4,
        HeightMask_ = HeightSmall | HeightRegular | HeightLarge | HeightLargest
    }
}
