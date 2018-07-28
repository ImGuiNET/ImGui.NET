using Microsoft.Xna.Framework;

namespace ImGuiNET.FNA.SampleProgram
{
    public class SampleGame : Game
    {
        private GraphicsDeviceManager graphics;
        private GuiXNAState ImGuiState;

        public SampleGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferMultiSampling = true;

            ImGuiState = new GuiXNAState(this);

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ImGuiState.BuildTextureAtlas();

            base.Initialize();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            ImGuiState.NewFrame(gameTime);
            ImGuiLayout();

            ImGuiState.Render();

            base.Draw(gameTime);
        }

        // Direct port of the example at https://github.com/ocornut/imgui/blob/master/examples/sdl_opengl2_example/main.cpp
        private float f = 0.0f;

        private bool show_test_window = true;
        private bool show_another_window = false;
        private System.Numerics.Vector3 clear_color = new System.Numerics.Vector3(114f / 255f, 144f / 255f, 154f / 255f);

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
            }

            // 2. Show another simple window, this time using an explicit Begin/End pair
            if (show_another_window)
            {
                ImGui.SetNextWindowSize(new System.Numerics.Vector2(200, 100), Condition.FirstUseEver);
                ImGui.BeginWindow("Another Window", ref show_another_window, WindowFlags.Default);
                ImGui.Text("Hello");
                ImGui.EndWindow();
            }

            // 3. Show the ImGui test window. Most of the sample code is in ImGui.ShowTestWindow()
            if (show_test_window)
            {
                //ImGui.SetNextWindowPos(new System.Numerics.Vector2(650, 20), Condition.FirstUseEver);
                //ImGui.ShowTestWindow(ref show_test_window);
            }
        }
    }
}