using System;
using System.Numerics;

namespace ImGuiNET
{
    public delegate void Platform_CreateWindow(ImGuiViewportPtr vp);                    // Create a new platform window for the given viewport
    public delegate void Platform_DestroyWindow(ImGuiViewportPtr vp);
    public delegate void Platform_ShowWindow(ImGuiViewportPtr vp);                      // Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them first
    public delegate void Platform_SetWindowPos(ImGuiViewportPtr vp, Vector2 pos);
    public unsafe delegate void Platform_GetWindowPos(ImGuiViewportPtr vp, Vector2* outPos);
    public delegate void Platform_SetWindowSize(ImGuiViewportPtr vp, Vector2 size);
    public unsafe delegate void Platform_GetWindowSize(ImGuiViewportPtr vp, Vector2* outSize);
    public delegate void Platform_SetWindowFocus(ImGuiViewportPtr vp);                  // Move window to front and set input focus
    public delegate byte Platform_GetWindowFocus(ImGuiViewportPtr vp);
    public delegate byte Platform_GetWindowMinimized(ImGuiViewportPtr vp);
    public delegate void Platform_SetWindowTitle(ImGuiViewportPtr vp, IntPtr title);
}
