namespace ImGuiNET
{
    // Flags for ImGui::IsWindowFocused()
    public enum FocusedFlags
    {
        ChildWindows = 1 << 0,   // IsWindowFocused(): Return true if any children of the window is focused
        RootWindow = 1 << 1,   // IsWindowFocused(): Test from root window (top most parent of the current hierarchy)
        RootAndChildWindows = RootWindow | ChildWindows
    }
}
