using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Runtime.InteropServices;
using System.Threading;

#if NETFRAMEWORK
using System.Drawing;
#endif

namespace ImGuiNET
{
    public class SampleWindow
    {
        private NativeWindow _nativeWindow;
        private GraphicsContext _graphicsContext;
        private int s_fontTexture;
        private int _pressCount;
        private IntPtr _textInputBuffer;
        private int _textInputBufferLength;
        private float _wheelPosition;
        private float _sliderVal;
        private System.Numerics.Vector4 _buttonColor = new System.Numerics.Vector4(55f / 255f, 155f / 255f, 1f, 1f);
        private bool _mainWindowOpened;
        private static double s_desiredFrameLength = 1f / 60.0f;
        private DateTime _previousFrameStartTime;
        private float _scaleFactor;
        private System.Numerics.Vector3 _positionValue = new System.Numerics.Vector3(500);

        private MemoryEditor _memoryEditor = new MemoryEditor();
        private byte[] _memoryEditorData;

        public unsafe SampleWindow()
        {
            int desiredWidth = 960, desiredHeight = 540;
            _nativeWindow = new NativeWindow(desiredWidth, desiredHeight, "ImGui.NET", GameWindowFlags.Default, OpenTK.Graphics.GraphicsMode.Default, DisplayDevice.Default);
            _scaleFactor = _nativeWindow.Width / desiredWidth;

            GraphicsContextFlags flags = GraphicsContextFlags.Default;
            _graphicsContext = new GraphicsContext(GraphicsMode.Default, _nativeWindow.WindowInfo, 3, 0, flags);
            _graphicsContext.MakeCurrent(_nativeWindow.WindowInfo);
            ((IGraphicsContextInternal)_graphicsContext).LoadAll(); // wtf is this?
            GL.ClearColor(Color.Black);
            _nativeWindow.Visible = true;
            _nativeWindow.X = _nativeWindow.X; // Work around OpenTK bug (?) on Ubuntu.

            _nativeWindow.KeyDown += OnKeyDown;
            _nativeWindow.KeyUp += OnKeyUp;
            _nativeWindow.KeyPress += OnKeyPress;

            ImGui.GetIO().FontAtlas.AddDefaultFont();

            SetOpenTKKeyMappings();

            _textInputBufferLength = 1024;
            _textInputBuffer = Marshal.AllocHGlobal(_textInputBufferLength);
            long* ptr = (long*)_textInputBuffer.ToPointer();
            for (int i = 0; i < 1024 / sizeof(long); i++)
            {
                ptr[i] = 0;
            }

            _memoryEditorData = new byte[1024];
            var rnd = new Random();
            for (int i = 0; i < _memoryEditorData.Length; i++)
            {
                _memoryEditorData[i] = (byte) rnd.Next(255);
            }

            CreateDeviceObjects();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.Write("Char typed: " + e.KeyChar);
            ImGui.AddInputCharacter(e.KeyChar);
        }

        private static unsafe void SetOpenTKKeyMappings()
        {
            IO io = ImGui.GetIO();
            io.KeyMap[GuiKey.Tab] = (int)Key.Tab;
            io.KeyMap[GuiKey.LeftArrow] = (int)Key.Left;
            io.KeyMap[GuiKey.RightArrow] = (int)Key.Right;
            io.KeyMap[GuiKey.UpArrow] = (int)Key.Up;
            io.KeyMap[GuiKey.DownArrow] = (int)Key.Down;
            io.KeyMap[GuiKey.PageUp] = (int)Key.PageUp;
            io.KeyMap[GuiKey.PageDown] = (int)Key.PageDown;
            io.KeyMap[GuiKey.Home] = (int)Key.Home;
            io.KeyMap[GuiKey.End] = (int)Key.End;
            io.KeyMap[GuiKey.Delete] = (int)Key.Delete;
            io.KeyMap[GuiKey.Backspace] = (int)Key.BackSpace;
            io.KeyMap[GuiKey.Enter] = (int)Key.Enter;
            io.KeyMap[GuiKey.Escape] = (int)Key.Escape;
            io.KeyMap[GuiKey.A] = (int)Key.A;
            io.KeyMap[GuiKey.C] = (int)Key.C;
            io.KeyMap[GuiKey.V] = (int)Key.V;
            io.KeyMap[GuiKey.X] = (int)Key.X;
            io.KeyMap[GuiKey.Y] = (int)Key.Y;
            io.KeyMap[GuiKey.Z] = (int)Key.Z;
        }

        private unsafe void OnKeyDown(object sender, KeyboardKeyEventArgs e)
        {
            ImGui.GetIO().KeysDown[(int)e.Key] = true;
            UpdateModifiers(e);
        }

        private unsafe void OnKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            ImGui.GetIO().KeysDown[(int)e.Key] = false;
            UpdateModifiers(e);
        }

        private static unsafe void UpdateModifiers(KeyboardKeyEventArgs e)
        {
            IO io = ImGui.GetIO();
            io.AltPressed = e.Alt;
            io.CtrlPressed = e.Control;
            io.ShiftPressed = e.Shift;
        }

        private unsafe void CreateDeviceObjects()
        {
            IO io = ImGui.GetIO();

            // Build texture atlas
            FontTextureData texData = io.FontAtlas.GetTexDataAsAlpha8();

            // Create OpenGL texture
            s_fontTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, s_fontTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Linear);
            GL.TexImage2D(
                TextureTarget.Texture2D,
                0,
                PixelInternalFormat.Alpha,
                texData.Width,
                texData.Height,
                0,
                PixelFormat.Alpha,
                PixelType.UnsignedByte,
                new IntPtr(texData.Pixels));

            // Store the texture identifier in the ImFontAtlas substructure.
            io.FontAtlas.SetTexID(s_fontTexture);

            // Cleanup (don't clear the input data if you want to append new fonts later)
            //io.Fonts->ClearInputData();
            io.FontAtlas.ClearTexData();
            GL.BindTexture(TextureTarget.Texture2D, 0);
        }

        public void RunWindowLoop()
        {
            _nativeWindow.Visible = true;
            while (_nativeWindow.Exists)
            {
                _previousFrameStartTime = DateTime.UtcNow;

                RenderFrame();

                _nativeWindow.ProcessEvents();

                DateTime afterFrameTime = DateTime.UtcNow;
                double elapsed = (afterFrameTime - _previousFrameStartTime).TotalSeconds;
                double sleepTime = s_desiredFrameLength - elapsed;
                if (sleepTime > 0.0)
                {
                    DateTime finishTime = afterFrameTime + TimeSpan.FromSeconds(sleepTime);
                    while (DateTime.UtcNow < finishTime)
                    {
                        Thread.Sleep(0);
                    }
                }
            }
        }

        private unsafe void RenderFrame()
        {
            IO io = ImGui.GetIO();
            io.DisplaySize = new System.Numerics.Vector2(_nativeWindow.Width, _nativeWindow.Height);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(_scaleFactor);
            io.DeltaTime = (1f / 60f);

            UpdateImGuiInput(io);

            ImGui.NewFrame();

            SubmitImGuiStuff();

            ImGui.Render();

            DrawData* data = ImGui.GetDrawData();
            RenderImDrawData(data);
        }

        private unsafe void SubmitImGuiStuff()
        {
            ImGui.GetStyle().WindowRounding = 0;

            ImGui.SetNextWindowSize(new System.Numerics.Vector2(_nativeWindow.Width - 10, _nativeWindow.Height - 20), Condition.Always);
            ImGui.SetNextWindowPosCenter(Condition.Always);
            ImGui.BeginWindow("ImGUI.NET Sample Program", ref _mainWindowOpened, WindowFlags.NoResize | WindowFlags.NoTitleBar | WindowFlags.NoMove);

            ImGui.BeginMainMenuBar();
            if (ImGui.BeginMenu("Help"))
            {
                if (ImGui.MenuItem("About", "Ctrl-Alt-A", false, true))
                {

                }
                ImGui.EndMenu();
            }
            ImGui.EndMainMenuBar();

            ImGui.Text("Hello,");
            ImGui.Text("World!");
            ImGui.Text("From ImGui.NET. ...Did that work?");
            var pos = ImGui.GetIO().MousePosition;
            bool leftPressed = ImGui.GetIO().MouseDown[0];
            ImGui.Text("Current mouse position: " + pos + ". Pressed=" + leftPressed);

            if (ImGui.Button("Increment the counter."))
            {
                _pressCount += 1;
            }

            ImGui.Text($"Button pressed {_pressCount} times.", new System.Numerics.Vector4(0, 1, 1, 1));

            ImGui.InputTextMultiline("Input some text:",
                _textInputBuffer, (uint)_textInputBufferLength,
                new System.Numerics.Vector2(360, 240),
                InputTextFlags.Default,
                OnTextEdited);

            ImGui.SliderFloat("SlidableValue", ref _sliderVal, -50f, 100f, $"{_sliderVal.ToString("##0.00")}", 1.0f);
            ImGui.DragVector3("Vector3", ref _positionValue, -100, 100);

            if (ImGui.TreeNode("First Item"))
            {
                ImGui.Text("Word!");
                ImGui.TreePop();
            }
            if (ImGui.TreeNode("Second Item"))
            {
                ImGui.ColorButton("Color button", _buttonColor, ColorEditFlags.Default, new System.Numerics.Vector2(0, 0));
                if (ImGui.Button("Push me to change color", new System.Numerics.Vector2(0, 30)))
                {
                    _buttonColor = new System.Numerics.Vector4(_buttonColor.Y + .25f, _buttonColor.Z, _buttonColor.X, _buttonColor.W);
                    if (_buttonColor.X > 1.0f)
                    {
                        _buttonColor.X -= 1.0f;
                    }
                }

                ImGui.TreePop();
            }

            if (ImGui.Button("Press me!", new System.Numerics.Vector2(100, 30)))
            {
                ImGuiNative.igOpenPopup("SmallButtonPopup");
            }

            if (ImGui.BeginPopup("SmallButtonPopup"))
            {
                ImGui.Text("Here's a popup menu.");
                ImGui.Text("With two lines.");

                ImGui.EndPopup();
            }

            if (ImGui.Button("Open Modal window"))
            {
                ImGui.OpenPopup("ModalPopup");
            }
            if (ImGui.BeginPopupModal("ModalPopup"))
            {
                ImGui.Text("You can't press on anything else right now.");
                ImGui.Text("You are stuck here.");
                if (ImGui.Button("OK", new System.Numerics.Vector2(0, 0))) { }
                ImGui.SameLine();
                ImGui.Dummy(100f, 0f);
                ImGui.SameLine();
                if (ImGui.Button("Please go away", new System.Numerics.Vector2(0, 0))) { ImGui.CloseCurrentPopup(); }

                ImGui.EndPopup();
            }

            ImGui.Text("I have a context menu.");
            if (ImGui.BeginPopupContextItem("ItemContextMenu"))
            {
                if (ImGui.Selectable("How's this for a great menu?")) { }
                ImGui.Selectable("Just click somewhere to get rid of me.");
                ImGui.EndPopup();
            }

            ImGui.EndWindow();

            _memoryEditor.Draw("Memory editor", _memoryEditorData, _memoryEditorData.Length);

            if (ImGui.GetIO().AltPressed && ImGui.GetIO().KeysDown[(int)Key.F4])
            {
                _nativeWindow.Close();
            }
        }

        private unsafe int OnTextEdited(TextEditCallbackData* data)
        {
            char currentEventChar = (char)data->EventChar;
            return 0;
        }

        private unsafe void UpdateImGuiInput(IO io)
        {
            MouseState cursorState = Mouse.GetCursorState();
            MouseState mouseState = Mouse.GetState();

            if (_nativeWindow.Focused)
            {
                Point windowPoint = _nativeWindow.PointToClient(new Point(cursorState.X, cursorState.Y));
                io.MousePosition = new System.Numerics.Vector2(windowPoint.X / io.DisplayFramebufferScale.X, windowPoint.Y / io.DisplayFramebufferScale.Y);
            }
            else
            {
                io.MousePosition = new System.Numerics.Vector2(-1f, -1f);
            }

            io.MouseDown[0] = mouseState.LeftButton == ButtonState.Pressed;
            io.MouseDown[1] = mouseState.RightButton == ButtonState.Pressed;
            io.MouseDown[2] = mouseState.MiddleButton == ButtonState.Pressed;

            float newWheelPos = mouseState.WheelPrecise;
            float delta = newWheelPos - _wheelPosition;
            _wheelPosition = newWheelPos;
            io.MouseWheel = delta;
        }

        private unsafe void RenderImDrawData(DrawData* draw_data)
        {
            // Rendering
            int display_w, display_h;
            display_w = _nativeWindow.Width;
            display_h = _nativeWindow.Height;

            Vector4 clear_color = new Vector4(114f / 255f, 144f / 255f, 154f / 255f, 1.0f);
            GL.Viewport(0, 0, display_w, display_h);
            GL.ClearColor(clear_color.X, clear_color.Y, clear_color.Z, clear_color.W);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // We are using the OpenGL fixed pipeline to make the example code simpler to read!
            // Setup render state: alpha-blending enabled, no face culling, no depth testing, scissor enabled, vertex/texcoord/color pointers.
            int last_texture;
            GL.GetInteger(GetPName.TextureBinding2D, out last_texture);
            GL.PushAttrib(AttribMask.EnableBit | AttribMask.ColorBufferBit | AttribMask.TransformBit);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.DepthTest);
            GL.Enable(EnableCap.ScissorTest);
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.EnableClientState(ArrayCap.TextureCoordArray);
            GL.EnableClientState(ArrayCap.ColorArray);
            GL.Enable(EnableCap.Texture2D);

            GL.UseProgram(0);

            // Handle cases of screen coordinates != from framebuffer coordinates (e.g. retina displays)
            IO io = ImGui.GetIO();
            ImGui.ScaleClipRects(draw_data, io.DisplayFramebufferScale);

            // Setup orthographic projection matrix
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(
                0.0f,
                io.DisplaySize.X / io.DisplayFramebufferScale.X,
                io.DisplaySize.Y / io.DisplayFramebufferScale.Y,
                0.0f,
                -1.0f,
                1.0f);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();

            // Render command lists

            for (int n = 0; n < draw_data->CmdListsCount; n++)
            {
                NativeDrawList* cmd_list = draw_data->CmdLists[n];
                byte* vtx_buffer = (byte*)cmd_list->VtxBuffer.Data;
                ushort* idx_buffer = (ushort*)cmd_list->IdxBuffer.Data;

                DrawVert vert0 = *((DrawVert*)vtx_buffer);
                DrawVert vert1 = *(((DrawVert*)vtx_buffer) + 1);
                DrawVert vert2 = *(((DrawVert*)vtx_buffer) + 2);

                GL.VertexPointer(2, VertexPointerType.Float, sizeof(DrawVert), new IntPtr(vtx_buffer + DrawVert.PosOffset));
                GL.TexCoordPointer(2, TexCoordPointerType.Float, sizeof(DrawVert), new IntPtr(vtx_buffer + DrawVert.UVOffset));
                GL.ColorPointer(4, ColorPointerType.UnsignedByte, sizeof(DrawVert), new IntPtr(vtx_buffer + DrawVert.ColOffset));

                for (int cmd_i = 0; cmd_i < cmd_list->CmdBuffer.Size; cmd_i++)
                {
                    DrawCmd* pcmd = &(((DrawCmd*)cmd_list->CmdBuffer.Data)[cmd_i]);
                    if (pcmd->UserCallback != IntPtr.Zero)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        GL.BindTexture(TextureTarget.Texture2D, pcmd->TextureId.ToInt32());
                        GL.Scissor(
                            (int)pcmd->ClipRect.X,
                            (int)(io.DisplaySize.Y - pcmd->ClipRect.W),
                            (int)(pcmd->ClipRect.Z - pcmd->ClipRect.X),
                            (int)(pcmd->ClipRect.W - pcmd->ClipRect.Y));
                        ushort[] indices = new ushort[pcmd->ElemCount];
                        for (int i = 0; i < indices.Length; i++) { indices[i] = idx_buffer[i]; }
                        GL.DrawElements(PrimitiveType.Triangles, (int)pcmd->ElemCount, DrawElementsType.UnsignedShort, new IntPtr(idx_buffer));
                    }
                    idx_buffer += pcmd->ElemCount;
                }
            }

            // Restore modified state
            GL.DisableClientState(ArrayCap.ColorArray);
            GL.DisableClientState(ArrayCap.TextureCoordArray);
            GL.DisableClientState(ArrayCap.VertexArray);
            GL.BindTexture(TextureTarget.Texture2D, last_texture);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            GL.PopAttrib();

            _graphicsContext.SwapBuffers();
        }
    }
}
