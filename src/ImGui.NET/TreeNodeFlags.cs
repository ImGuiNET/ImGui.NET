using System;

namespace ImGuiNET
{
    [Flags]
    public enum TreeNodeFlags : int
    {
        /// <summary>
        /// Draw as selected
        /// </summary>
        Selected = 1 << 0,
        /// <summary>
        /// Full colored frame (e.g. for CollapsingHeader)
        /// </summary>
        Framed = 1 << 1,
        /// <summary>
        /// Hit testing to allow subsequent widgets to overlap this one
        /// </summary>
        AllowItemOverlap = 1 << 2,
        /// <summary>
        /// Don't do a TreePush() when open (e.g. for CollapsingHeader) = no extra indent nor pushing on ID stack
        /// </summary>
        NoTreePushOnOpen = 1 << 3,
        /// <summary>
        /// Don't automatically and temporarily open node when Logging is active (by default logging will automatically open tree nodes)
        /// </summary>
        NoAutoOpenOnLog = 1 << 4,
        /// <summary>
        /// Default node to be open
        /// </summary>
        DefaultOpen = 1 << 5,
        /// <summary>
        /// Need double-click to open node
        /// </summary>
        OpenOnDoubleClick = 1 << 6,
        /// <summary>
        /// Only open when clicking on the arrow part. If ImGuiTreeNodeFlags_OpenOnDoubleClick is also set, single-click arrow or double-click all box to open.
        /// </summary>
        OpenOnArrow = 1 << 7,
        /// <summary>
        /// No collapsing, no arrow (use as a convenience for leaf nodes).
        /// </summary>
        Leaf = 1 << 8,
        /// <summary>
        /// Display a bullet instead of arrow
        /// </summary>
        Bullet = 1 << 9,
        /// <summary>
        /// Use FramePadding (even for an unframed text node) to vertically align text baseline
        /// </summary>
        FramePadding = 1 << 10,
        CollapsingHeader = Framed | NoAutoOpenOnLog
    };
}
