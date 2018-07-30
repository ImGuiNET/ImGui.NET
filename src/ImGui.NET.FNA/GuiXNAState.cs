using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ImGuiNET.FNA
{
    // TODO: Comments
    // TODO: Check style against Veldrid renderer
    // TODO: Test more (with ImGui demo?)
    public class ImGuiRenderer
    {
        // Graphics
        private GraphicsDevice _graphicsDevice;

        private BasicEffect _effect;
        private RasterizerState _rasterizerState;

        // Textures
        private object _lock = new object();

        private Dictionary<IntPtr, Texture2D> _loadedTextures = new Dictionary<IntPtr, Texture2D>();
        private int _textureId = 1;
        private IntPtr? _fontTextureId;

        // Input
        private int _scrollWheelValue;

        private List<int> _keys = new List<int>();

        public ImGuiRenderer(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice ?? throw new ArgumentNullException(nameof(graphicsDevice));

            _rasterizerState = new RasterizerState()
            {
                CullMode = CullMode.None,
                DepthBias = 0,
                FillMode = FillMode.Solid,
                MultiSampleAntiAlias = false,
                ScissorTestEnable = true,
                SlopeScaleDepthBias = 0
            };

            SetupKeyMapping();

            TextInputEXT.TextInput += c =>
            {
                if (c == '\t') return;

                ImGui.AddInputCharacter(c);
            };

            ImGui.GetIO().FontAtlas.AddDefaultFont();
        }

        #region ImGuiRenderer

        public virtual void RebuildFontAtlas()
        {
            // Get font texture from ImGui
            var io = ImGui.GetIO();
            var texData = io.FontAtlas.GetTexDataAsRGBA32();

            var pixels = new byte[texData.Width * texData.Height * texData.BytesPerPixel];
            unsafe { Marshal.Copy(new IntPtr(texData.Pixels), pixels, 0, pixels.Length); }

            // Create and register the texture as an XNA texture
            var tex2d = new Texture2D(_graphicsDevice, texData.Width, texData.Height, false, SurfaceFormat.Color);
            tex2d.SetData(pixels);

            if (_fontTextureId.HasValue) UnbindTexture(_fontTextureId.Value);

            _fontTextureId = BindTexture(tex2d);

            io.FontAtlas.SetTexID(_fontTextureId.Value);
            io.FontAtlas.ClearTexData(); // Clears CPU side texture data.
        }

        public virtual IntPtr BindTexture(object texture)
        {
            var tex2d = texture as Texture2D;
            if (tex2d == null) throw new InvalidOperationException($"Only textures of type '{nameof(Texture2D)}' are supported");

            lock (_lock)
            {
                var id = new IntPtr(_textureId++);

                _loadedTextures.Add(id, tex2d);

                return id;
            }
        }

        public virtual void UnbindTexture(IntPtr textureId)
        {
            lock (_lock) { _loadedTextures.Remove(textureId); }
        }

        public virtual void BeforeLayout(GameTime gameTime)
        {
            ImGui.GetIO().DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            UpdateInput();

            ImGui.NewFrame();
        }

        public virtual void AfterLayout()
        {
            ImGui.Render();

            if (ImGui.GetIO().RenderDrawListsFn == IntPtr.Zero)
            {
                unsafe { RenderDrawData(ImGui.GetDrawData()); }
            }
        }

        #endregion ImGuiRenderer

        #region Setup & Update

        protected virtual void SetupKeyMapping()
        {
            var io = ImGui.GetIO();

            _keys.Add(io.KeyMap[GuiKey.Tab] = (int)Keys.Tab);
            _keys.Add(io.KeyMap[GuiKey.LeftArrow] = (int)Keys.Left);
            _keys.Add(io.KeyMap[GuiKey.RightArrow] = (int)Keys.Right);
            _keys.Add(io.KeyMap[GuiKey.UpArrow] = (int)Keys.Up);
            _keys.Add(io.KeyMap[GuiKey.DownArrow] = (int)Keys.Down);
            _keys.Add(io.KeyMap[GuiKey.PageUp] = (int)Keys.PageUp);
            _keys.Add(io.KeyMap[GuiKey.PageDown] = (int)Keys.PageDown);
            _keys.Add(io.KeyMap[GuiKey.Home] = (int)Keys.Home);
            _keys.Add(io.KeyMap[GuiKey.End] = (int)Keys.End);
            _keys.Add(io.KeyMap[GuiKey.Delete] = (int)Keys.Delete);
            _keys.Add(io.KeyMap[GuiKey.Backspace] = (int)Keys.Back);
            _keys.Add(io.KeyMap[GuiKey.Enter] = (int)Keys.Enter);
            _keys.Add(io.KeyMap[GuiKey.Escape] = (int)Keys.Escape);
            _keys.Add(io.KeyMap[GuiKey.A] = (int)Keys.A);
            _keys.Add(io.KeyMap[GuiKey.C] = (int)Keys.C);
            _keys.Add(io.KeyMap[GuiKey.V] = (int)Keys.V);
            _keys.Add(io.KeyMap[GuiKey.X] = (int)Keys.X);
            _keys.Add(io.KeyMap[GuiKey.Y] = (int)Keys.Y);
            _keys.Add(io.KeyMap[GuiKey.Z] = (int)Keys.Z);
        }

        protected virtual Effect UpdateEffect(Texture2D texture)
        {
            _effect = _effect ?? new BasicEffect(_graphicsDevice);

            var io = ImGui.GetIO();

            _effect.World = Matrix.Identity;
            _effect.View = Matrix.Identity;
            _effect.Projection = Matrix.CreateOrthographicOffCenter(0f, io.DisplaySize.X + 0f, io.DisplaySize.Y + 0f, 0f, -1f, 1f);
            _effect.TextureEnabled = true;
            _effect.Texture = texture;
            _effect.VertexColorEnabled = true;

            return _effect;
        }

        private void UpdateInput()
        {
            var io = ImGui.GetIO();

            var mouse = Mouse.GetState();
            var keyboard = Keyboard.GetState();

            for (int i = 0; i < _keys.Count; i++)
            {
                io.KeysDown[_keys[i]] = keyboard.IsKeyDown((Keys)_keys[i]);
            }

            io.ShiftPressed = keyboard.IsKeyDown(Keys.LeftShift) || keyboard.IsKeyDown(Keys.RightShift);
            io.CtrlPressed = keyboard.IsKeyDown(Keys.LeftControl) || keyboard.IsKeyDown(Keys.RightControl);
            io.AltPressed = keyboard.IsKeyDown(Keys.LeftAlt) || keyboard.IsKeyDown(Keys.RightAlt);
            io.SuperPressed = keyboard.IsKeyDown(Keys.LeftWindows) || keyboard.IsKeyDown(Keys.RightWindows);

            io.DisplaySize = new System.Numerics.Vector2(_graphicsDevice.PresentationParameters.BackBufferWidth, _graphicsDevice.PresentationParameters.BackBufferHeight);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(1f, 1f);

            io.MousePosition = new System.Numerics.Vector2(mouse.X, mouse.Y);

            io.MouseDown[0] = mouse.LeftButton == ButtonState.Pressed;
            io.MouseDown[1] = mouse.RightButton == ButtonState.Pressed;
            io.MouseDown[2] = mouse.MiddleButton == ButtonState.Pressed;

            var scrollDelta = mouse.ScrollWheelValue - _scrollWheelValue;
            io.MouseWheel = scrollDelta > 0 ? 1 : scrollDelta < 0 ? -1 : 0;
            _scrollWheelValue = mouse.ScrollWheelValue;
        }

        #endregion Setup & Update

        #region Internals

        private unsafe void RenderDrawData(DrawData* drawData)
        {
            // Setup render state: alpha-blending enabled, no face culling, no depth testing, scissor enabled, vertex/texcoord/color pointers.
            var lastViewport = _graphicsDevice.Viewport;
            var lastScissorBox = _graphicsDevice.ScissorRectangle;

            _graphicsDevice.BlendFactor = Color.White;
            _graphicsDevice.BlendState = BlendState.NonPremultiplied;
            _graphicsDevice.RasterizerState = _rasterizerState;
            _graphicsDevice.DepthStencilState = DepthStencilState.DepthRead;

            // Handle cases of screen coordinates != from framebuffer coordinates (e.g. retina displays)
            ImGui.ScaleClipRects(drawData, ImGui.GetIO().DisplayFramebufferScale);

            // Setup projection
            _graphicsDevice.Viewport = new Viewport(0, 0, _graphicsDevice.PresentationParameters.BackBufferWidth, _graphicsDevice.PresentationParameters.BackBufferHeight);

            // Render command lists
            for (int n = 0; n < drawData->CmdListsCount; n++)
            {
                var cmdList = drawData->CmdLists[n];

                var vtxBuffer = new ImVector<DrawVertXNA>(&cmdList->VtxBuffer);
                var vtxArray = new DrawVertXNA[vtxBuffer.Size];
                for (int i = 0; i < vtxBuffer.Size; i++)
                {
                    vtxArray[i] = vtxBuffer[i];
                }

                var idxBuffer = new ImVector<short>(&cmdList->IdxBuffer);

                uint offset = 0;
                for (int cmdi = 0; cmdi < cmdList->CmdBuffer.Size; cmdi++)
                {
                    var pcmd = &(((DrawCmd*)cmdList->CmdBuffer.Data)[cmdi]);
                    if (pcmd->UserCallback != IntPtr.Zero) throw new NotImplementedException();

                    // Instead of uploading the complete idxBuffer again and again, just upload what's required.
                    var idxArray = new short[pcmd->ElemCount];
                    for (int i = 0; i < pcmd->ElemCount; i++)
                    {
                        idxArray[i] = idxBuffer[(int)offset + i];
                    }

                    if (!_loadedTextures.ContainsKey(pcmd->TextureId)) throw new InvalidOperationException($"Could not find a texture with id '{pcmd->TextureId}', please check your bindings");

                    var effect = UpdateEffect(_loadedTextures[pcmd->TextureId]);

                    _graphicsDevice.ScissorRectangle = new Rectangle(
                        (int)pcmd->ClipRect.X,
                        (int)pcmd->ClipRect.Y,
                        (int)(pcmd->ClipRect.Z - pcmd->ClipRect.X),
                        (int)(pcmd->ClipRect.W - pcmd->ClipRect.Y)
                    );

                    foreach (var pass in effect.CurrentTechnique.Passes)
                    {
                        pass.Apply();

                        _graphicsDevice.DrawUserIndexedPrimitives(
                            PrimitiveType.TriangleList,
                            vtxArray, 0, vtxBuffer.Size,
                            idxArray, 0, (int)pcmd->ElemCount / 3,
                            DrawVertXNA._VertexDeclaration
                        );
                    }

                    offset += pcmd->ElemCount;
                }
            }

            // Restore modified state
            _graphicsDevice.Viewport = lastViewport;
            _graphicsDevice.ScissorRectangle = lastScissorBox;
        }

        #endregion Internals
    }
}