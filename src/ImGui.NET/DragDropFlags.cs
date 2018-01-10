namespace ImGuiNET
{
    public enum DragDropFlags
    {
        // BeginDragDropSource() flags

        /// <summary>
        /// By default, a successful call to BeginDragDropSource opens a tooltip so you can display a preview or description of the source contents. This flag disable this behavior.
        /// </summary>
        SourceNoPreviewTooltip = 1 << 0,
        /// <summary>
        /// By default, when dragging we clear data so that IsItemHovered() will return true, to avoid subsequent user code submitting tooltips. This flag disable this behavior so you can still call IsItemHovered() on the source item.
        /// </summary>
        SourceNoDisableHover = 1 << 1,
        /// <summary>
        /// Disable the behavior that allows to open tree nodes and collapsing header by holding over them while dragging a source item.
        /// </summary>
        SourceNoHoldToOpenOthers = 1 << 2,
        /// <summary>
        /// Allow items such as Text(), Image() that have no unique identifier to be used as drag source, by manufacturing a temporary identifier based on their window-relative position. This is extremely unusual within the dear imgui ecosystem and so we made it explicit.
        /// </summary>
        SourceAllowNullID = 1 << 3,
        /// <summary>
        /// External source (from outside of imgui), won't attempt to read current item/window info. Will always return true. Only one Extern source can be active simultaneously.
        /// </summary>
        SourceExtern = 1 << 4,

        // AcceptDragDropPayload() flags

        /// <summary>
        /// AcceptDragDropPayload() will returns true even before the mouse button is released. You can then call IsDelivery() to test if the payload needs to be delivered.
        /// </summary>
        AcceptBeforeDelivery = 1 << 10,
        /// <summary>
        /// Do not draw the default highlight rectangle when hovering over target.
        /// </summary>
        AcceptNoDrawDefaultRect = 1 << 11,
        /// <summary>
        /// For peeking ahead and inspecting the payload before delivery.
        /// </summary>
        AcceptPeekOnly = AcceptBeforeDelivery | AcceptNoDrawDefaultRect
    }
}
