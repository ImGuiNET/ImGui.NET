using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace ImGuiNET.SampleProgram.XNA
{
	/// <summary>
	/// Simple FNA + ImGui example
	/// </summary>
	public class SampleGame : Game
	{
		private GraphicsDeviceManager _graphics;
		private ImGuiRenderer _imGuiRenderer;

		private Texture2D _xnaTexture;
		private IntPtr _imGuiTexture;

		public SampleGame()
		{
			_graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = 1024,
				PreferredBackBufferHeight = 768,
				PreferMultiSampling = true
			};

			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			_imGuiRenderer = new ImGuiRenderer(this);
			_imGuiRenderer.RebuildFontAtlas();

			base.Initialize();
		}

		protected override void LoadContent()
		{
			// Texture loading example

			// First, load the texture as a Texture2D (can also be done using the XNA/FNA content pipeline)
			_xnaTexture = CreateTexture(GraphicsDevice, 300, 150, pixel =>
			{
				var red = (pixel % 300) / 2;
				return new Color(red, 1, 1);
			});

			// Then, bind it to an ImGui-friendly pointer, that we can use during regular ImGui.** calls (see below)
			_imGuiTexture = _imGuiRenderer.BindTexture(_xnaTexture);

			base.LoadContent();
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(new Color(clear_color.x, clear_color.y, clear_color.z));

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
		private Vector3 clear_color = new Vector3(114f / 255f, 144f / 255f, 154f / 255f);
		private byte[] _textBuffer = new byte[100];

		protected virtual void ImGuiLayout()
		{
			// 1. Show a simple window
			// Tip: if we don't call ImGui.Begin()/ImGui.End() the widgets appears in a window automatically called "Debug"
			{
				ImGui.Text("Hello, world!");
				ImGui.SliderFloat("float", ref f, 0.0f, 1.0f, string.Empty);
				ImGui.ColorEdit3("clear color", ref clear_color);
				if (ImGui.Button("Test Window")) show_test_window = !show_test_window;
				if (ImGui.Button("Another Window")) show_another_window = !show_another_window;
				ImGui.Text(string.Format("Application average {0:F3} ms/frame ({1:F1} FPS)", 1000f / ImGui.GetIO().Framerate, ImGui.GetIO().Framerate));

				ImGui.InputText("Text input", _textBuffer, 100);

				ImGui.Text("Texture sample");
				ImGui.Image(_imGuiTexture, new Vector2(300, 150), Vector2.zero, Vector2.one, Vector4.one, Vector4.one); // Here, the previously loaded texture is used
			}

			// 2. Show another simple window, this time using an explicit Begin/End pair
			if (show_another_window)
			{
				ImGui.SetNextWindowSize(new Vector2(200, 100), ImGuiCond.FirstUseEver);
				ImGui.Begin("Another Window", ref show_another_window);
				ImGui.Text("Hello");
				ImGui.End();
			}

			// 3. Show the ImGui test window. Most of the sample code is in ImGui.ShowTestWindow()
			if (show_test_window)
			{
				ImGui.SetNextWindowPos(new Vector2(650, 20), ImGuiCond.FirstUseEver);
				ImGui.ShowDemoWindow(ref show_test_window);
			}
		}

		public static Texture2D CreateTexture(GraphicsDevice device, int width, int height, Func<int, Color> paint)
		{
			//initialize a texture
			var texture = new Texture2D(device, width, height);

			//the array holds the color for each pixel in the texture
			Color[] data = new Color[width * height];
			for (var pixel = 0; pixel < data.Length; pixel++)
			{
				//the function applies the color according to the specified pixel
				data[pixel] = paint(pixel);
			}

			//set the color
			texture.SetData(data);

			return texture;
		}
	}
}