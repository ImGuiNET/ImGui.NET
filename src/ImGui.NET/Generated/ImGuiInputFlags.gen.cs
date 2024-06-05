namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiInputFlags
    {
        None = 0,
        Repeat = 1,
        RouteActive = 1024,
        RouteFocused = 2048,
        RouteGlobal = 4096,
        RouteAlways = 8192,
        RouteOverFocused = 16384,
        RouteOverActive = 32768,
        RouteUnlessBgFocused = 65536,
        RouteFromRootWindow = 131072,
        Tooltip = 262144,
    }
}
