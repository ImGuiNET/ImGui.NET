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

        public unsafe SampleWindow()
        {
            _nativeWindow = new NativeWindow(960, 540, "ImGui.NET", GameWindowFlags.Default, OpenTK.Graphics.GraphicsMode.Default, DisplayDevice.Default);
            _nativeWindow.WindowBorder = WindowBorder.Resizable;
            GraphicsContextFlags flags = GraphicsContextFlags.Default;
            _graphicsContext = new GraphicsContext(GraphicsMode.Default, _nativeWindow.WindowInfo, 3, 0, flags);
            _graphicsContext.MakeCurrent(_nativeWindow.WindowInfo);
            _graphicsContext.LoadAll(); // wtf is this?
            GL.ClearColor(Color.Black);
            _nativeWindow.Visible = true;

            _nativeWindow.KeyDown += OnKeyDown;
            _nativeWindow.KeyUp += OnKeyUp;
            _nativeWindow.KeyPress += OnKeyPress;

            IO* io = ImGuiNative.igGetIO();
            ImGuiNative.ImFontAtlas_AddFontDefault(io->FontAtlas);

            SetOpenTKKeyMappings(io);

            _textInputBufferLength = 1024;
            _textInputBuffer = Marshal.AllocHGlobal(_textInputBufferLength);
            long* ptr = (long*)_textInputBuffer.ToPointer();
            for (int i = 0; i < 1024 / sizeof(long); i++)
            {
                ptr[i] = 0;
            }

            CreateDeviceObjects();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(e.KeyChar);
        }

        private static unsafe void SetOpenTKKeyMappings(IO* io)
        {
            io->KeyMap[(int)GuiKey.Tab] = (int)Key.Tab;
            io->KeyMap[(int)GuiKey.LeftArrow] = (int)Key.Left;
            io->KeyMap[(int)GuiKey.RightArrow] = (int)Key.Right;
            io->KeyMap[(int)GuiKey.UpArrow] = (int)Key.Up;
            io->KeyMap[(int)GuiKey.DownArrow] = (int)Key.Down;
            io->KeyMap[(int)GuiKey.PageUp] = (int)Key.PageUp;
            io->KeyMap[(int)GuiKey.PageDown] = (int)Key.PageDown;
            io->KeyMap[(int)GuiKey.Home] = (int)Key.Home;
            io->KeyMap[(int)GuiKey.End] = (int)Key.End;
            io->KeyMap[(int)GuiKey.Delete] = (int)Key.Delete;
            io->KeyMap[(int)GuiKey.Backspace] = (int)Key.BackSpace;
            io->KeyMap[(int)GuiKey.Enter] = (int)Key.Enter;
            io->KeyMap[(int)GuiKey.Escape] = (int)Key.Escape;
            io->KeyMap[(int)GuiKey.A] = (int)Key.A;
            io->KeyMap[(int)GuiKey.C] = (int)Key.C;
            io->KeyMap[(int)GuiKey.V] = (int)Key.V;
            io->KeyMap[(int)GuiKey.X] = (int)Key.X;
            io->KeyMap[(int)GuiKey.Y] = (int)Key.Y;
            io->KeyMap[(int)GuiKey.Z] = (int)Key.Z;
        }

        private unsafe void OnKeyDown(object sender, KeyboardKeyEventArgs e)
        {
            var ptr = ImGuiNative.igGetIO();
            ptr->KeysDown[(int)e.Key] = 1;
            UpdateModifiers(e, ptr);
        }

        private unsafe void OnKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            var ptr = ImGuiNative.igGetIO();
            ptr->KeysDown[(int)e.Key] = 0;
            UpdateModifiers(e, ptr);
        }

        private static unsafe void UpdateModifiers(KeyboardKeyEventArgs e, IO* ptr)
        {
            ptr->KeyAlt = e.Alt ? (byte)1 : (byte)0;
            ptr->KeyCtrl = e.Control ? (byte)1 : (byte)0;
            ptr->KeyShift = e.Shift ? (byte)1 : (byte)0;
        }

        private unsafe void CreateDeviceObjects()
        {
            IO* io = ImGuiNative.igGetIO();

            // Build texture atlas
            byte* pixels;
            int width, height;
            ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(io->FontAtlas, &pixels, &width, &height, null);

            // Create OpenGL texture
            s_fontTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, s_fontTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Linear);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Alpha, width, height, 0, PixelFormat.Alpha, PixelType.UnsignedByte, new IntPtr(pixels));

            // Store the texture identifier in the ImFontAtlas substructure.
            io->FontAtlas->TexID = new IntPtr(s_fontTexture).ToPointer();

            // Cleanup (don't clear the input data if you want to append new fonts later)
            //io.Fonts->ClearInputData();
            ImGuiNative.ImFontAtlas_ClearTexData(io->FontAtlas);
            GL.BindTexture(TextureTarget.Texture2D, 0);
        }

        public void RunWindowLoop()
        {
            while (_nativeWindow.Visible)
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
                    Thread.Sleep((int)(sleepTime * 1000));
                }
            }
        }

        private unsafe void RenderFrame()
        {
            IO* io = ImGuiNative.igGetIO();
            io->DisplaySize = new System.Numerics.Vector2(_nativeWindow.Width, _nativeWindow.Height);
            io->DisplayFramebufferScale = new System.Numerics.Vector2(1, 1);
            io->DeltaTime = (1f / 60f);

            UpdateImGuiInput(io);

            ImGuiNative.igNewFrame();

            SubmitImGuiStiff();

            ImGuiNative.igRender();

            DrawData* data = ImGuiNative.igGetDrawData();
            RenderImDrawData(data);
        }

        private unsafe void SubmitImGuiStiff()
        {
            ImGuiNative.igGetStyle()->WindowRounding = 0;

            ImGuiNative.igSetNextWindowSize(new System.Numerics.Vector2(_nativeWindow.Width - 10, _nativeWindow.Height - 20), SetCondition.Always);
            ImGuiNative.igSetNextWindowPosCenter(SetCondition.Always);
            ImGuiNative.igBegin("ImGUI.NET Sample Program", ref _mainWindowOpened, WindowFlags.NoResize | WindowFlags.NoTitleBar | WindowFlags.NoMove);

            ImGuiNative.igBeginMainMenuBar();
            if (ImGuiNative.igBeginMenu("Help"))
            {
                if (ImGuiNative.igMenuItem("About", "Ctrl-Alt-A", false, true))
                {

                }
                ImGuiNative.igEndMenu();
            }
            ImGuiNative.igEndMainMenuBar();

            ImGuiNative.igText("Hello,");
            ImGuiNative.igText("World!");
            ImGuiNative.igText("From ImGui.NET. ...Did that work?");
            var pos = ImGuiNative.igGetIO()->MousePos;
            bool leftPressed = ImGuiNative.igGetIO()->MouseDown[0] == 1;
            ImGuiNative.igText("Current mouse position: " + pos + ". Pressed=" + leftPressed);

            if (ImGuiNative.igButton("Press me!", new System.Numerics.Vector2(120, 30)))
            {
                _pressCount += 1;
            }

            ImGuiNative.igTextColored(new System.Numerics.Vector4(0, 1, 1, 1), $"Button pressed {_pressCount} times.");

            ImGuiNative.igInputTextMultiline("Input some numbers:",
                _textInputBuffer, (uint)_textInputBufferLength,
                new System.Numerics.Vector2(360, 240),
                InputTextFlags.CharsDecimal,
                OnTextEdited, null);

            ImGuiNative.igSliderFloat("SlidableValue", ref _sliderVal, -50f, 100f, $"{_sliderVal.ToString("##0.00")}", 1);

            if (ImGuiNative.igTreeNode("First Item"))
            {
                ImGuiNative.igText("Word!");
                ImGuiNative.igTreePop();
            }
            if (ImGuiNative.igTreeNode("Second Item"))
            {
                ImGuiNative.igColorButton(_buttonColor, false, true);
                if (ImGui.Button("Push me to change color", new System.Numerics.Vector2(120, 30)))
                {
                    _buttonColor = new System.Numerics.Vector4(_buttonColor.Y + .25f, _buttonColor.Z, _buttonColor.X, _buttonColor.W);
                    if (_buttonColor.X > 1.0f)
                    {
                        _buttonColor.X -= 1.0f;
                    }
                }

                ImGuiNative.igTreePop();
            }

            ImGuiNative.igEnd();
        }

        private unsafe int OnTextEdited(TextEditCallbackData* data)
        {
            char currentEventChar = (char)data->EventChar;
            Console.WriteLine("Event char: " + currentEventChar);
            return 0;
        }

        private unsafe void UpdateImGuiInput(IO* io)
        {
            MouseState cursorState = Mouse.GetCursorState();
            MouseState mouseState = Mouse.GetState();

            if (_nativeWindow.Bounds.Contains(cursorState.X, cursorState.Y))
            {
                Point windowPoint = _nativeWindow.PointToClient(new Point(cursorState.X, cursorState.Y));
                io->MousePos = new System.Numerics.Vector2(windowPoint.X, windowPoint.Y);
            }
            else
            {
                io->MousePos = new System.Numerics.Vector2(-1f, -1f);
            }

            io->MouseDown[0] = (mouseState.LeftButton == ButtonState.Pressed) ? (byte)255 : (byte)0; // Left
            io->MouseDown[1] = (mouseState.RightButton == ButtonState.Pressed) ? (byte)255 : (byte)0; // Right
            io->MouseDown[2] = (mouseState.MiddleButton == ButtonState.Pressed) ? (byte)255 : (byte)0; // Middle

            float newWheelPos = mouseState.WheelPrecise;
            float delta = newWheelPos - _wheelPosition;
            _wheelPosition = newWheelPos;
            io->MouseWheel = delta;
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
            IO* io = ImGuiNative.igGetIO();
            float fb_height = io->DisplaySize.Y * io->DisplayFramebufferScale.Y;
            ImGui.ScaleClipRects(draw_data, io->DisplayFramebufferScale);

            // Setup orthographic projection matrix
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(0.0f, io->DisplaySize.X, io->DisplaySize.Y, 0.0f, -1.0f, 1.0f);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();

            // Render command lists

            for (int n = 0; n < draw_data->CmdListsCount; n++)
            {
                DrawList* cmd_list = draw_data->CmdLists[n];
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
                            (int)(fb_height - pcmd->ClipRect.W),
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
