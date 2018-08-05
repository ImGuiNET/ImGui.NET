using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Drawing.Imaging;
using System.IO;
using Num = System.Numerics;

namespace ImGuiNET.SampleProgram.FNA
{
    /// <summary>
    /// Simple FNA + ImGui example
    /// Note that in order to run this, the FNA dependencies should first be downloaded from https://github.com/FNA-XNA/FNA/wiki/3:-Distributing-FNA-Games
    /// </summary>
    public class SampleGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private ImGuiRenderer _imGuiRenderer;

        private Texture2D _xnaTexture;
        private IntPtr _imGuiTexture;
        private float _textureRatio;

        public SampleGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 768;
            _graphics.PreferMultiSampling = true;

            _imGuiRenderer = new ImGuiRenderer(GraphicsDevice);

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _imGuiRenderer.RebuildFontAtlas();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Texture loading example
            using (var stream = new MemoryStream())
            {
                // First, load the texture as a Texture2D (can also be done using the XNA/FNA content pipeline)
                Assets.FNA_Logo.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                _textureRatio = (float)Assets.FNA_Logo.Width / (float)Assets.FNA_Logo.Height;

                _xnaTexture = Texture2D.FromStream(GraphicsDevice, stream);

                // Then, bind it to an ImGui-friendly pointer, that we can use during regular ImGui.** calls (see below)
                _imGuiTexture = _imGuiRenderer.BindTexture(_xnaTexture);
            }

            base.LoadContent();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(clear_color.X, clear_color.Y, clear_color.Z));

            // Call BeforeLayout first to set things up
            _imGuiRenderer.BeforeLayout(gameTime);

            // Draw our UI
            ImGuiLayout();

            // Call AfterLayout now to finish up and draw all the things
            _imGuiRenderer.AfterLayout();

            base.Draw(gameTime);
        }

        // Direct port of the example at https://github.com/ocornut/imgui/blob/master/examples/sdl_opengl2_example/main.cpp
        private float f = 0.0f;

        private bool show_test_window = false;
        private bool show_another_window = false;
        private Num.Vector3 clear_color = new Num.Vector3(114f / 255f, 144f / 255f, 154f / 255f);
        private byte[] _textBuffer = new byte[100];

        protected virtual void ImGuiLayout()
        {
            // 1. Show a simple window
            // Tip: if we don't call ImGui.Begin()/ImGui.End() the widgets appears in a window automatically called "Debug"
            {
                ImGui.Text("Hello, world!");
                ImGui.SliderFloat("float", ref f, 0.0f, 1.0f, null, 1f);
                ImGui.ColorEdit3("clear color", ref clear_color);
                if (ImGui.Button("Test Window")) show_test_window = !show_test_window;
                if (ImGui.Button("Another Window")) show_another_window = !show_another_window;
                ImGui.Text(string.Format("Application average {0:F3} ms/frame ({1:F1} FPS)", 1000f / ImGui.GetIO().Framerate, ImGui.GetIO().Framerate));

                ImGui.InputText("Text input", _textBuffer, 100, InputTextFlags.Default, null);
                ImGui.Image(_imGuiTexture, new Num.Vector2(100 * _textureRatio, 100), Num.Vector2.Zero, Num.Vector2.One, Num.Vector4.One, Num.Vector4.One); // Here, the previously loaded texture is used
            }

            // 2. Show another simple window, this time using an explicit Begin/End pair
            if (show_another_window)
            {
                ImGui.SetNextWindowSize(new Num.Vector2(200, 100), Condition.FirstUseEver);
                ImGui.BeginWindow("Another Window", ref show_another_window, WindowFlags.Default);
                ImGui.Text("Hello");
                ImGui.EndWindow();
            }

            // 3. Show the ImGui test window. Most of the sample code is in ImGui.ShowTestWindow()
            if (show_test_window)
            {
                ImGui.SetNextWindowPos(new Num.Vector2(650, 20), Condition.FirstUseEver);
                ImGuiNative.igShowDemoWindow(ref show_test_window);
            }
        }
    }
}