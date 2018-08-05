﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ImGuiNET.SampleProgram.FNA
{
    /// <summary>
    /// ImGui renderer for use with FNA
    /// </summary>
    public class ImGuiRenderer
    {
        // Graphics
        private GraphicsDevice _graphicsDevice;

        private BasicEffect _effect;
        private RasterizerState _rasterizerState;

        private VertexBuffer _vertexBuffer;
        private int _vertexBufferSize;

        private IndexBuffer _indexBuffer;
        private int _indexBufferSize;

        // Textures
        private Dictionary<IntPtr, Texture2D> _loadedTextures;

        private int _textureId;

        private IntPtr? _fontTextureId;

        // Input
        private int _scrollWheelValue;

        private List<int> _keys = new List<int>();

        public ImGuiRenderer(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice ?? throw new ArgumentNullException(nameof(graphicsDevice));

            _loadedTextures = new Dictionary<IntPtr, Texture2D>();

            _rasterizerState = new RasterizerState()
            {
                CullMode = CullMode.None,
                DepthBias = 0,
                FillMode = FillMode.Solid,
                MultiSampleAntiAlias = false,
                ScissorTestEnable = true,
                SlopeScaleDepthBias = 0
            };

            SetupInput();
        }

        #region ImGuiRenderer

        /// <summary>
        /// Creates a texture and loads the font data from ImGui. Should be called when the <see cref="GraphicsDevice" /> is initialized but before any rendering is done
        /// </summary>
        public virtual void RebuildFontAtlas()
        {
            // Get font texture from ImGui
            var io = ImGui.GetIO();
            var texData = io.FontAtlas.GetTexDataAsRGBA32();

            // Copy the data to a managed array
            var pixels = new byte[texData.Width * texData.Height * texData.BytesPerPixel];
            unsafe { Marshal.Copy(new IntPtr(texData.Pixels), pixels, 0, pixels.Length); }

            // Create and register the texture as an XNA texture
            var tex2d = new Texture2D(_graphicsDevice, texData.Width, texData.Height, false, SurfaceFormat.Color);
            tex2d.SetData(pixels);

            // Should a texture already have been build previously, unbind it first so it can be deallocated
            if (_fontTextureId.HasValue) UnbindTexture(_fontTextureId.Value);

            // Bind the new texture to an ImGui-friendly id
            _fontTextureId = BindTexture(tex2d);

            // Let ImGui know where to find the texture
            io.FontAtlas.SetTexID(_fontTextureId.Value);
            io.FontAtlas.ClearTexData(); // Clears CPU side texture data
        }

        /// <summary>
        /// Creates a pointer to a texture, which can be passed through ImGui calls such as <see cref="ImGui.Image" />. That pointer is then used by ImGui to let us know what texture to draw
        /// </summary>
        public virtual IntPtr BindTexture(object texture)
        {
            // Since this is an XNA-specific renderer, we only support the native Texture2D
            var tex2d = texture as Texture2D;
            if (tex2d == null) throw new InvalidOperationException($"Only textures of type '{nameof(Texture2D)}' are supported");

            var id = new IntPtr(_textureId++);

            _loadedTextures.Add(id, tex2d);

            return id;
        }

        /// <summary>
        /// Removes a previously created texture pointer, releasing its reference and allowing it to be deallocated
        /// </summary>
        public virtual void UnbindTexture(IntPtr textureId)
        {
            _loadedTextures.Remove(textureId);
        }

        /// <summary>
        /// Sets up ImGui for a new frame, should be called at frame start
        /// </summary>
        public virtual void BeforeLayout(GameTime gameTime)
        {
            ImGui.GetIO().DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            UpdateInput();

            ImGui.NewFrame();
        }

        /// <summary>
        /// Asks ImGui for the generated geometry data and sends it to the graphics pipeline, should be called after the UI is drawn using ImGui.** calls
        /// </summary>
        public virtual void AfterLayout()
        {
            ImGui.Render();

            unsafe { RenderDrawData(ImGui.GetDrawData()); }
        }

        #endregion ImGuiRenderer

        #region Setup & Update

        /// <summary>
        /// Maps ImGui keys to FNA keys. We use this later on to tell ImGui what keys were pressed
        /// </summary>
        protected virtual void SetupInput()
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

            TextInputEXT.TextInput += c =>
            {
                if (c == '\t') return;

                ImGui.AddInputCharacter(c);
            };

            ImGui.GetIO().FontAtlas.AddDefaultFont();
        }

        /// <summary>
        /// Updates the <see cref="Effect" /> to the current matrices and texture
        /// </summary>
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

        /// <summary>
        /// Sends FNA input state to ImGui
        /// </summary>
        protected virtual void UpdateInput()
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

        /// <summary>
        /// Gets the geometry as set up by ImGui and sends it to the graphics device
        /// </summary>
        private unsafe void RenderDrawData(DrawData* drawData)
        {
            // Setup render state: alpha-blending enabled, no face culling, no depth testing, scissor enabled, vertex/texcoord/color pointers
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

            UpdateBuffers(drawData);

            RenderCommandLists(drawData);

            // Restore modified state
            _graphicsDevice.Viewport = lastViewport;
            _graphicsDevice.ScissorRectangle = lastScissorBox;
        }

        private unsafe void UpdateBuffers(DrawData* drawData)
        {
            // Expand buffers if we need more room
            if (drawData->TotalVtxCount > _vertexBufferSize)
            {
                _vertexBuffer?.Dispose();

                _vertexBufferSize = (int)(drawData->TotalVtxCount * 1.5f);
                _vertexBuffer = new VertexBuffer(_graphicsDevice, DrawVertDeclaration.Declaration, _vertexBufferSize, BufferUsage.None);
            }

            if (drawData->TotalIdxCount > _indexBufferSize)
            {
                _indexBuffer?.Dispose();

                _indexBufferSize = (int)(drawData->TotalIdxCount * 1.5f);
                _indexBuffer = new IndexBuffer(_graphicsDevice, IndexElementSize.SixteenBits, _indexBufferSize, BufferUsage.None);
            }

            // Update buffers with the latest data from ImGui
            int vtxOffset = 0;
            int idxOffset = 0;

            for (int n = 0; n < drawData->CmdListsCount; n++)
            {
                var cmdList = drawData->CmdLists[n];

                _vertexBuffer.SetDataPointerEXT(vtxOffset * DrawVertDeclaration.Size, (IntPtr)cmdList->VtxBuffer.Data, cmdList->VtxBuffer.Size * DrawVertDeclaration.Size, SetDataOptions.None);
                _indexBuffer.SetDataPointerEXT(idxOffset * (int)sizeof(ushort), (IntPtr)cmdList->IdxBuffer.Data, cmdList->IdxBuffer.Size * sizeof(ushort), SetDataOptions.None);

                vtxOffset += cmdList->VtxBuffer.Size;
                idxOffset += cmdList->IdxBuffer.Size;
            }
        }

        private unsafe void RenderCommandLists(DrawData* drawData)
        {
            _graphicsDevice.SetVertexBuffer(_vertexBuffer);
            _graphicsDevice.Indices = _indexBuffer;

            int vtxOffset = 0;
            int idxOffset = 0;

            for (int n = 0; n < drawData->CmdListsCount; n++)
            {
                var cmdList = drawData->CmdLists[n];

                for (int cmdi = 0; cmdi < cmdList->CmdBuffer.Size; cmdi++)
                {
                    var drawCmd = &(((DrawCmd*)cmdList->CmdBuffer.Data)[cmdi]);

                    if (!_loadedTextures.ContainsKey(drawCmd->TextureId)) throw new InvalidOperationException($"Could not find a texture with id '{drawCmd->TextureId}', please check your bindings");

                    _graphicsDevice.ScissorRectangle = new Rectangle(
                        (int)drawCmd->ClipRect.X,
                        (int)drawCmd->ClipRect.Y,
                        (int)(drawCmd->ClipRect.Z - drawCmd->ClipRect.X),
                        (int)(drawCmd->ClipRect.W - drawCmd->ClipRect.Y)
                    );

                    var effect = UpdateEffect(_loadedTextures[drawCmd->TextureId]);

                    foreach (var pass in effect.CurrentTechnique.Passes)
                    {
                        pass.Apply();

                        _graphicsDevice.DrawIndexedPrimitives(
                            primitiveType: PrimitiveType.TriangleList,
                            baseVertex: vtxOffset,
                            minVertexIndex: 0,
                            numVertices: cmdList->VtxBuffer.Size,
                            startIndex: idxOffset,
                            primitiveCount: (int)drawCmd->ElemCount / 3
                        );
                    }

                    idxOffset += (int)drawCmd->ElemCount;
                }

                vtxOffset += cmdList->VtxBuffer.Size;
            }
        }

        #endregion Internals
    }
}