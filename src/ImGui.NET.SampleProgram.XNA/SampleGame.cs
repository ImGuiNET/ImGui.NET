using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Num = System.Numerics;

namespace ImGuiNET.SampleProgram.XNA
{
    /// <summary>
    /// Simple FNA + ImGui example
    /// </summary>
    public class SampleGame : Game
    {
        private bool _showMainWindow = true;
        private bool _showSimpleWindow = false;
        private bool _showDockBuilderWindow = false;
        private bool _showDemoWindow = false;

        private bool _swapTexture = false;
        private bool _dockingEnabled = true;

        private Num.Vector3 _colorBackground = new Num.Vector3(0.44f, 0.44f, 0.60f);

        private GraphicsDeviceManager _graphics;
        private ImGuiRenderer _imGuiRenderer;

        private Texture2D _textureLogo;
        private IntPtr _textureHandleLogo;

        private Texture2D _textureManual;
        private IntPtr _textureManualHandle;

        /// <summary>
        /// Flags to style the DockBuilder window to not look or behave like a window.
        /// </summary>
        private ImGuiWindowFlags _windowFlagsDockBuilderWindow = ImGuiWindowFlags.NoTitleBar
            | ImGuiWindowFlags.NoCollapse
            | ImGuiWindowFlags.NoResize
            | ImGuiWindowFlags.NoMove
            | ImGuiWindowFlags.NoBringToFrontOnFocus
            | ImGuiWindowFlags.NoNavFocus;

        /// <summary>
        /// The size for the rendered image, 16:9 resolutions recommended.
        /// </summary>
        private readonly Num.Vector2 _imageSize = new Num.Vector2(240.0f, 135.0f);

        /// <summary>
        /// Used for centering windows.
        /// </summary>
        private readonly Num.Vector2 _pivotCenter = new Num.Vector2(0.5f, 0.5f);

        public SampleGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 768;
            _graphics.PreferMultiSampling = true;

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _imGuiRenderer = new ImGuiRenderer(this);
            _imGuiRenderer.RebuildFontAtlas();

            if (_dockingEnabled)
            {
                ImGui.GetIO().ConfigFlags |= ImGuiConfigFlags.DockingEnable;
            }

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a color fade texture by calculating individual pixel color values
            _textureManual = CreateTexture(GraphicsDevice, 240, 135, pixel =>
			{
				int red = (pixel % 240) / 2;
				return new Color(red, 1, 1);
			});

            // Load a texture from the file system
            _textureLogo = Texture2D.FromStream(GraphicsDevice, new FileStream("assets/logo.png", FileMode.Open));

            // Then, bind it to an ImGui-friendly pointer, that we can use during regular ImGui.** calls (see below)
            _textureManualHandle = _imGuiRenderer.BindTexture(_textureManual);
            _textureHandleLogo = _imGuiRenderer.BindTexture(_textureLogo);

            base.LoadContent();

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(_colorBackground.X, _colorBackground.Y, _colorBackground.Z));

            // Call BeforeLayout first to set things up
            _imGuiRenderer.BeforeLayout(gameTime);

            // Draw our UI
            ImGuiLayout();

            // Call AfterLayout now to finish up and draw all the things
            _imGuiRenderer.AfterLayout();

            base.Draw(gameTime);

        }

        protected virtual void ImGuiLayout()
        {
            // 1. Show the demos main window
            if(_showMainWindow) RenderMainWindow();

            // 2. Show a simple window, this time using an explicit Begin/End pair
            if (_showSimpleWindow) RenderSimpleWindow();

            // 3. Show a more advanced window setup using the internal ImGui DockBuilder API
            if (_showDockBuilderWindow) RenderDockBuilderWindow();

            // 4. Show the ImGui demo window
            if(_showDemoWindow) ImGui.ShowDemoWindow(ref _showDemoWindow);
        }

        private void RenderMainWindow()
        {
            ImGui.SetNextWindowPos(ImGui.GetIO().DisplaySize * 0.5f, ImGuiCond.Appearing, _pivotCenter);

			if (ImGui.Begin("Main Window", ref _showMainWindow, ImGuiWindowFlags.NoSavedSettings))
            {
                // Render image centered horizontally while respecting padding
                ImGui.SetCursorPosX(ImGui.GetStyle().WindowPadding.X + MathHelper.Max((ImGui.GetContentRegionAvail().X - _imageSize.X) / 2, 0));
                ImGui.Image(_swapTexture ? _textureManualHandle : _textureHandleLogo, _imageSize, Num.Vector2.Zero, Num.Vector2.One, Num.Vector4.One, Num.Vector4.One);

                ImGui.Checkbox("Swap Texture", ref _swapTexture);
                ImGui.Checkbox("Simple Window", ref _showSimpleWindow);
                ImGui.Checkbox("DockBuilder Window", ref _showDockBuilderWindow);
                if(_showDockBuilderWindow)
				{
                    ImGui.Indent();
                    if(ImGui.Checkbox("ImGuiConfigFlags.DockingEnable", ref _dockingEnabled))
					{
                        ToggleImGuiConfigFlag(ImGuiConfigFlags.DockingEnable);
                    }

                    if (ImGui.Button("Reset DockSpace"))
					{
                        CreateDockSpace(ImGui.GetMainViewport().WorkSize / 2);
                    }

                    ImGui.Unindent();

                }
                ImGui.Checkbox("ImGui Demo Window", ref _showDemoWindow);
                ImGui.ColorEdit3("Clear Color", ref _colorBackground);
                ImGui.Text(string.Format("Application average {0:F3} ms/frame ({1:F1} FPS)", 1000f / ImGui.GetIO().Framerate, ImGui.GetIO().Framerate));

            }
            ImGui.End();
        }

        private void RenderSimpleWindow()
        {
            if(ImGui.Begin("Simple Window"))
			{
                ImGui.Text("Hello, world!");

			}
        }

        private void RenderDockBuilderWindow()
        {
            var vp = ImGui.GetMainViewport();
            var dockspaceSize = vp.WorkSize / 2;
            
            ImGui.SetNextWindowPos(vp.WorkPos);
            ImGui.SetNextWindowSize(dockspaceSize);

            if (ImGui.Begin("DockBuilder Window", _windowFlagsDockBuilderWindow))
			{
                RenderDockSpaceInfoText(dockspaceSize);
                RenderDockSpaceWindows();

            }
		}

        private unsafe void CreateDockSpace(Num.Vector2 dockspaceSize)
		{
            uint dockspaceId = ImGui.GetID("DockSpace");

            // Allow to rebuild/reset nodes
            if (ImGui.DockBuilderGetNode(dockspaceId).NativePtr != null)
            {
                ImGui.DockBuilderRemoveNode(dockspaceId);
            }

            ImGui.DockBuilderAddNode(dockspaceId);
            ImGui.DockBuilderSetNodeSize(dockspaceId, dockspaceSize);

            // Split the dock into half top/bottom and then split
            // the resulting top node into 25% left and 75% right
            ImGui.DockBuilderSplitNode(dockspaceId, ImGuiDir.Up, 0.5f, out uint topId, out uint bottomId);
            ImGui.DockBuilderSplitNode(topId, ImGuiDir.Right, 0.75f, out uint leftId, out uint rightId);

            // Dock specific windows by their name
            ImGui.DockBuilderDockWindow("Left", leftId);
            ImGui.DockBuilderDockWindow("Right", rightId);
            ImGui.DockBuilderDockWindow("Bottom", bottomId);

            ImGui.DockBuilderFinish(dockspaceId);

        }

        private static Texture2D CreateTexture(GraphicsDevice device, int width, int height, Func<int, Color> paint)
		{
			// Initialize a texture
			var texture = new Texture2D(device, width, height);

			// The array holds the color for each pixel in the texture
			Color[] data = new Color[width * height];
			for(var pixel = 0; pixel < data.Length; pixel++)
			{
				// The function applies the color according to the specified pixel
				data[pixel] = paint(pixel);
			}

			// Set the color
			texture.SetData(data);

			return texture;
		}

		#region DockSpace

        private void RenderDockSpaceInfoText(Num.Vector2 dockspaceSize)
        {
            bool dockingEnabled = ImGui.GetIO().ConfigFlags.HasFlag(ImGuiConfigFlags.DockingEnable);

            // Center lines vertically
            int linesToRender = dockingEnabled ? 1 : 3;
            ImGui.SetCursorPosY((dockspaceSize.Y - linesToRender * ImGui.GetFontSize()) / 2);

            RenderTextJustified("This is the DockSpace area.", dockspaceSize.X);

            if (!dockingEnabled)
            {
                RenderTextJustified("You need to enable the ImGuiConfigFlags\n'DockingEnable' or the docked windows are not rendered.", dockspaceSize.X);
            }
        }

        private void RenderDockSpaceWindows()
        {
            // There is no overload function ImGui.Begin(string name, ImGuiWindowFlags flags)
            // and we can't use a null for the ref, so we use a dummy boolean variable.
            bool dummyBool = true;

            ImGui.SetNextWindowPos(new Num.Vector2(450, 50), ImGuiCond.Appearing);
            ImGui.SetNextWindowSize(new Num.Vector2(150, 100), ImGuiCond.Appearing);
            if (ImGui.Begin("Left", ref dummyBool, ImGuiWindowFlags.NoSavedSettings))
                ImGui.Text("Foo");
            ImGui.End();

            ImGui.SetNextWindowPos(new Num.Vector2(450, 200), ImGuiCond.Appearing);
            ImGui.SetNextWindowSize(new Num.Vector2(150, 100), ImGuiCond.Appearing);
            if (ImGui.Begin("Right", ref dummyBool, ImGuiWindowFlags.NoSavedSettings))
                ImGui.Text("Bar");
            ImGui.End();

            ImGui.SetNextWindowPos(new Num.Vector2(450, 350), ImGuiCond.Appearing);
            ImGui.SetNextWindowSize(new Num.Vector2(150, 100), ImGuiCond.Appearing);
            if (ImGui.Begin("Bottom", ref dummyBool, ImGuiWindowFlags.NoSavedSettings))
                ImGui.Text("Baz");
            ImGui.End();
        }

        private void RenderTextJustified(string text, float availableWidth)
        {
            string[] lines = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                ImGui.SetCursorPosX((availableWidth - ImGui.CalcTextSize(line).X) / 2);
                ImGui.Text(line);
            }
        }

        private void ToggleImGuiConfigFlag(ImGuiConfigFlags flag)
        {
            ImGuiIOPtr io = ImGui.GetIO();

            if (!io.ConfigFlags.HasFlag(flag))
            {
                // Add ImGuiConfigFlag
                io.ConfigFlags |= flag;
            }
            else
            {
                // Remove ImGuiConfigFlag
                io.ConfigFlags &= ~flag;
            }
        }
        #endregion
    }
}