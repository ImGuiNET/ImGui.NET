namespace ImGuiNET
{
    // Flags for ImGui::IsItemHovered(), ImGui::IsWindowHovered()
    public enum HoveredFlags
    {
        Default = 0,        // Return true if directly over the item/window, not obstructed by another window, not obstructed by an active popup or modal blocking inputs under them.
        ChildWindows = 1 << 0,   // IsWindowHovered() only: Return true if any children of the window is hovered
        RootWindow = 1 << 1,   // IsWindowHovered() only: Test from root window (top most parent of the current hierarchy)
        AllowWhenBlockedByPopup = 1 << 2,   // Return true even if a popup window is normally blocking access to this item/window
        AllowWhenBlockedByActiveItem = 1 << 4,   // Return true even if an active item is blocking access to this item/window. Useful for Drag and Drop patterns.
        AllowWhenOverlapped = 1 << 5,   // Return true even if the position is overlapped by another window
        RectOnly = AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | AllowWhenOverlapped,
        RootAndChildWindows = RootWindow | ChildWindows
    }
}
