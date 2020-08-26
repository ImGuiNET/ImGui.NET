using ImGuiNET;
using System;
using System.Runtime.InteropServices;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

namespace ImGui.NET.SampleProgram
{
    public class VeldridImGuiWindow : IDisposable
    {
        private readonly GCHandle _gcHandle;
        private readonly GraphicsDevice _gd;
        private readonly ImGuiViewportPtr _vp;
        private readonly Sdl2Window _window;
        private readonly Swapchain _sc;

        public Sdl2Window Window => _window;
        public Swapchain Swapchain => _sc;

        public VeldridImGuiWindow(GraphicsDevice gd, ImGuiViewportPtr vp)
        {
            _gcHandle = GCHandle.Alloc(this);
            _gd = gd;
            _vp = vp;

            SDL_WindowFlags flags = SDL_WindowFlags.Hidden;
            if ((vp.Flags & ImGuiViewportFlags.NoTaskBarIcon) != 0)
            {
                flags |= SDL_WindowFlags.SkipTaskbar;
            }
            if ((vp.Flags & ImGuiViewportFlags.NoDecoration) != 0)
            {
                flags |= SDL_WindowFlags.Borderless;
            }
            else
            {
                flags |= SDL_WindowFlags.Resizable;
            }

            if ((vp.Flags & ImGuiViewportFlags.TopMost) != 0)
            {
                flags |= SDL_WindowFlags.AlwaysOnTop;
            }

            _window = new Sdl2Window(
                "No Title Yet",
                (int)vp.Pos.X, (int)vp.Pos.Y,
                (int)vp.Size.X, (int)vp.Size.Y,
                flags,
                false);
            _window.Resized += () => _vp.PlatformRequestResize = true;
            _window.Moved += p => _vp.PlatformRequestMove = true;
            _window.Closed += () => _vp.PlatformRequestClose = true;

            SwapchainSource scSource = VeldridStartup.GetSwapchainSource(_window);
            SwapchainDescription scDesc = new SwapchainDescription(scSource, (uint)_window.Width, (uint)_window.Height, null, true, false);
            _sc = _gd.ResourceFactory.CreateSwapchain(scDesc);
            _window.Resized += () => _sc.Resize((uint)_window.Width, (uint)_window.Height);

            vp.PlatformUserData = (IntPtr)_gcHandle;
        }

        public VeldridImGuiWindow(GraphicsDevice gd, ImGuiViewportPtr vp, Sdl2Window window)
        {
            _gcHandle = GCHandle.Alloc(this);
            _gd = gd;
            _vp = vp;
            _window = window;
            vp.PlatformUserData = (IntPtr)_gcHandle;
        }

        public void Update()
        {
            _window.PumpEvents();
        }

        public void Dispose()
        {
            _gd.WaitForIdle(); // TODO: Shouldn't be necessary, but Vulkan backend trips a validation error (swapchain in use when disposed).
            _sc.Dispose();
            _window.Close();
            _gcHandle.Free();
        }
    }
}
