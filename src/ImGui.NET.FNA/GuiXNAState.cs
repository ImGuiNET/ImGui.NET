using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ImGuiNET.FNA
{
    public class GuiXNAState
    {
        public Game Game;

        public int FontTexture = 0;

        public Effect Effect;

        private RasterizerState RasterizerState = new RasterizerState()
        {
            CullMode = CullMode.None,
            DepthBias = 0,
            FillMode = FillMode.Solid,
            MultiSampleAntiAlias = false,
            ScissorTestEnable = true,
            SlopeScaleDepthBias = 0
        };

        private Dictionary<int, Texture2D> _IdTextureMap = new Dictionary<int, Texture2D>();
        private Dictionary<Texture2D, int> _TextureIdMap = new Dictionary<Texture2D, int>();
        private int _TextureId = 1;

        private double _Time = 0.0f;
        private int _ScrollWheelValue;

        private static bool _Initialized = false;
        public static bool Initialized => _Initialized;

        private static List<int> _Keys = new List<int>();

#if XNA
        private ImGuiXNAFormsHook _FormsHook;
#endif

        public GuiXNAState(Game game)
        {
            Init();
#if XNA
            _FormsHook = new ImGuiXNAFormsHook(game.Window.Handle, (ref Win32.Message msg) => {
                if (msg.Msg != 0x0102)
                    return;
                OnTextInput((char) msg.WParam);
            });
#endif
            Game = game;
        }

        public static void Init()
        {
            if (_Initialized)
                return;
            _Initialized = true;

            IO io = ImGui.GetIO();

            _Keys.Add(io.KeyMap[GuiKey.Tab] = (int)Keys.Tab);
            _Keys.Add(io.KeyMap[GuiKey.LeftArrow] = (int)Keys.Left);
            _Keys.Add(io.KeyMap[GuiKey.RightArrow] = (int)Keys.Right);
            _Keys.Add(io.KeyMap[GuiKey.UpArrow] = (int)Keys.Up);
            _Keys.Add(io.KeyMap[GuiKey.DownArrow] = (int)Keys.Down);
            _Keys.Add(io.KeyMap[GuiKey.PageUp] = (int)Keys.PageUp);
            _Keys.Add(io.KeyMap[GuiKey.PageDown] = (int)Keys.PageDown);
            _Keys.Add(io.KeyMap[GuiKey.Home] = (int)Keys.Home);
            _Keys.Add(io.KeyMap[GuiKey.End] = (int)Keys.End);
            _Keys.Add(io.KeyMap[GuiKey.Delete] = (int)Keys.Delete);
            _Keys.Add(io.KeyMap[GuiKey.Backspace] = (int)Keys.Back);
            _Keys.Add(io.KeyMap[GuiKey.Enter] = (int)Keys.Enter);
            _Keys.Add(io.KeyMap[GuiKey.Escape] = (int)Keys.Escape);
            _Keys.Add(io.KeyMap[GuiKey.A] = (int)Keys.A);
            _Keys.Add(io.KeyMap[GuiKey.C] = (int)Keys.C);
            _Keys.Add(io.KeyMap[GuiKey.V] = (int)Keys.V);
            _Keys.Add(io.KeyMap[GuiKey.X] = (int)Keys.X);
            _Keys.Add(io.KeyMap[GuiKey.Y] = (int)Keys.Y);
            _Keys.Add(io.KeyMap[GuiKey.Z] = (int)Keys.Z);

#if FNA
            TextInputEXT.TextInput += OnTextInput;
            io.SetGetClipboardTextFn(GetClipboardTextFn);
            io.SetSetClipboardTextFn(SetClipboardTextFn);
#endif
            // 1. Text input in XNA depends on the game's window. It thus can't be set up statically.
            // 2. ImGui already handles the Windows clipboard out of the box.

            // If no font added, add default font.
            //if (io.FontAtlas.Fonts.Size == 0)
            io.FontAtlas.AddDefaultFont();
        }

        public static void OnTextInput(char c) => ImGui.AddInputCharacter(c);

#if FNA
        // This would depend on an FNA extension. @flibitijibibo?
        public readonly static GetClipboardTextFn GetClipboardTextFn = (userData) => SDL2.SDL.SDL_GetClipboardText();
        public readonly static SetClipboardTextFn SetClipboardTextFn = (userData, text) => SDL2.SDL.SDL_SetClipboardText(text);
#endif

        public unsafe void BuildTextureAtlas()
        {
            IO io = ImGui.GetIO();
            // ImFontTextureData texData = io.FontAtlas.GetTexDataAsAlpha8();
            // Alpha8 has got some blending issues.
            FontTextureData texData = io.FontAtlas.GetTexDataAsRGBA32();

            Texture2D tex = new Texture2D(Game.GraphicsDevice, texData.Width, texData.Height, false, SurfaceFormat.Color);

            int[] data = new int[texData.Width * texData.Height];
            Marshal.Copy(new IntPtr(texData.Pixels), data, 0, data.Length);
            tex.SetData(data);

            FontTexture = Register(tex);

            io.FontAtlas.SetTexID(FontTexture);
            io.FontAtlas.ClearTexData(); // Clears CPU side texture data.
        }

        public int Register(Texture2D tex)
        {
            int id;
            if (_TextureIdMap.TryGetValue(tex, out id))
                return id;
            id = _TextureId;
            _TextureId++;
            _TextureIdMap[tex] = id;
            _IdTextureMap[id] = tex;
            return id;
        }

        public void Unregister(Texture2D tex)
        {
            int id;
            if (!_TextureIdMap.TryGetValue(tex, out id))
                return;
            _TextureIdMap.Remove(tex);
            _IdTextureMap.Remove(id);
        }

        public void Unregister(int id)
        {
            Texture2D tex;
            if (!_IdTextureMap.TryGetValue(id, out tex))
                return;
            _TextureIdMap.Remove(tex);
            _IdTextureMap.Remove(id);
        }

        public int? GetId(Texture2D tex)
        {
            int id;
            if (_TextureIdMap.TryGetValue(tex, out id))
                return id;
            return null;
        }

        public Texture2D GetTexture(int id)
        {
            Texture2D tex;
            if (_IdTextureMap.TryGetValue(id, out tex))
                return tex;
            return null;
        }

        public Action<GuiXNAState, Effect> SetupEffect = _SetupEffect;

        private static void _SetupEffect(GuiXNAState self, Effect _effect)
        {
            IO io = ImGui.GetIO();

            const float translate = 0f;

            if (_effect is BasicEffect)
            {
                BasicEffect effect = (BasicEffect)_effect;
                effect.World = Matrix.Identity;
                effect.View = Matrix.Identity;
                effect.Projection = Matrix.CreateOrthographicOffCenter(translate, io.DisplaySize.X + translate, io.DisplaySize.Y + translate, translate, -1f, 1f);
                effect.TextureEnabled = true;
                effect.VertexColorEnabled = true;
                return;
            }

            if (_effect is AlphaTestEffect)
            {
                AlphaTestEffect effect = (AlphaTestEffect)_effect;
                effect.World = Matrix.Identity;
                effect.View = Matrix.Identity;
                effect.Projection = Matrix.CreateOrthographicOffCenter(translate, io.DisplaySize.X + translate, io.DisplaySize.Y + translate, translate, -1f, 1f);
                effect.VertexColorEnabled = true;
                return;
            }

            throw new Exception($"Default ImGuiXNAState.SetupEffect can't deal with {_effect.GetType().FullName}, please provide your own delegate.");
        }

        public Action<GuiXNAState, Effect, Texture2D> SetEffectTexture = _SetEffectTexture;

        private static void _SetEffectTexture(GuiXNAState self, Effect _effect, Texture2D texture)
        {
            IO io = ImGui.GetIO();

            if (_effect is BasicEffect)
            {
                BasicEffect effect = (BasicEffect)_effect;
                effect.Texture = texture;
                return;
            }

            if (_effect is AlphaTestEffect)
            {
                AlphaTestEffect effect = (AlphaTestEffect)_effect;
                effect.Texture = texture;
                return;
            }

            throw new Exception($"Default ImGuiXNAState.SetEffectTexture can't deal with {_effect.GetType().FullName}, please provide your own delegate.");
        }

        public void NewFrame(GameTime gameTime)
        {
            IO io = ImGui.GetIO();

            MouseState mouse = Mouse.GetState();
            KeyboardState keyboard = Keyboard.GetState();

            for (int i = 0; i < _Keys.Count; i++)
                io.KeysDown[_Keys[i]] = keyboard.IsKeyDown((Keys)_Keys[i]);

            io.ShiftPressed = keyboard.IsKeyDown(Keys.LeftShift) || keyboard.IsKeyDown(Keys.RightShift);
            io.CtrlPressed = keyboard.IsKeyDown(Keys.LeftControl) || keyboard.IsKeyDown(Keys.RightControl);
            io.AltPressed = keyboard.IsKeyDown(Keys.LeftAlt) || keyboard.IsKeyDown(Keys.RightAlt);
            io.SuperPressed = keyboard.IsKeyDown(Keys.LeftWindows) || keyboard.IsKeyDown(Keys.RightWindows);

            io.DisplaySize = new System.Numerics.Vector2(Game.GraphicsDevice.PresentationParameters.BackBufferWidth, Game.GraphicsDevice.PresentationParameters.BackBufferHeight);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(1f, 1f);

            double currentTime = gameTime.TotalGameTime.TotalSeconds;
            io.DeltaTime = _Time > 0D ? (float)(currentTime - _Time) : (1f / 60f);
            _Time = currentTime;

            io.MousePosition = new System.Numerics.Vector2(mouse.X, mouse.Y);

            io.MouseDown[0] = mouse.LeftButton == ButtonState.Pressed;
            io.MouseDown[1] = mouse.RightButton == ButtonState.Pressed;
            io.MouseDown[2] = mouse.MiddleButton == ButtonState.Pressed;

            int scrollDelta = mouse.ScrollWheelValue - _ScrollWheelValue;
            io.MouseWheel = scrollDelta > 0 ? 1 : scrollDelta < 0 ? -1 : 0;
            _ScrollWheelValue = mouse.ScrollWheelValue;

            Game.IsMouseVisible = !io.MouseDrawCursor;

            ImGui.NewFrame();
        }

        public unsafe void Render()
        {
            ImGui.Render();
            if (ImGui.GetIO().RenderDrawListsFn == IntPtr.Zero)

                RenderDrawData(ImGui.GetDrawData());
        }

        public unsafe void RenderDrawData(DrawData* drawData)
        {
            GraphicsDevice device = Game.GraphicsDevice;

            // Setup render state: alpha-blending enabled, no face culling, no depth testing, scissor enabled, vertex/texcoord/color pointers.
            Viewport lastViewport = device.Viewport;
            Rectangle lastScissorBox = device.ScissorRectangle;

            device.BlendFactor = Color.White;
            device.BlendState = BlendState.NonPremultiplied;
            device.RasterizerState = RasterizerState;
            device.DepthStencilState = DepthStencilState.DepthRead;

            // Handle cases of screen coordinates != from framebuffer coordinates (e.g. retina displays)
            IO io = ImGui.GetIO();
            ImGui.ScaleClipRects(drawData, io.DisplayFramebufferScale);

            // Setup projection
            device.Viewport = new Viewport(0, 0, device.PresentationParameters.BackBufferWidth, device.PresentationParameters.BackBufferHeight);

            if (Effect == null)
                Effect = new BasicEffect(device);
            Effect effect = Effect;
            SetupEffect(this, effect);

            // Render command lists
            for (int n = 0; n < drawData->CmdListsCount; n++)
            {
                var cmdList = drawData->CmdLists[n];

                ImVector<DrawVertXNA> vtxBuffer;

                vtxBuffer = new ImVector<DrawVertXNA>(&cmdList->VtxBuffer);

                DrawVertXNA[] vtxArray = new DrawVertXNA[vtxBuffer.Size];
                for (int i = 0; i < vtxBuffer.Size; i++)
                    vtxArray[i] = vtxBuffer[i];

                ImVector<short> idxBuffer;

                idxBuffer = new ImVector<short>(&cmdList->IdxBuffer);

                /*
                short[] idxArray = new short[idxBuffer.Size];
                for (int i = 0; i < idxBuffer.Size; i++)
                    idxArray[i] = idxBuffer[i];
                */

                uint offset = 0;
                for (int cmdi = 0; cmdi < cmdList->CmdBuffer.Size; cmdi++)
                {
                    DrawCmd* pcmd = &(((DrawCmd*)cmdList->CmdBuffer.Data)[cmdi]);
                    if (pcmd->UserCallback != IntPtr.Zero)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        // Instead of uploading the complete idxBuffer again and again, just upload what's required.
                        short[] idxArray = new short[pcmd->ElemCount];
                        for (int i = 0; i < pcmd->ElemCount; i++)
                            idxArray[i] = idxBuffer[(int)offset + i];
                        SetEffectTexture(this, effect, GetTexture((int)pcmd->TextureId));
                        device.ScissorRectangle = new Rectangle(
                            (int)pcmd->ClipRect.X,
                            (int)pcmd->ClipRect.Y,
                            (int)(pcmd->ClipRect.Z - pcmd->ClipRect.X),
                            (int)(pcmd->ClipRect.W - pcmd->ClipRect.Y)
                        );
                        foreach (EffectPass pass in effect.CurrentTechnique.Passes)
                        {
                            pass.Apply();
                            device.DrawUserIndexedPrimitives(
                                PrimitiveType.TriangleList,
                                vtxArray, 0, vtxBuffer.Size,
                                idxArray, 0, (int)pcmd->ElemCount / 3,
                                DrawVertXNA._VertexDeclaration
                            );
                        }
                    }
                    offset += pcmd->ElemCount;
                }
            }

            // Restore modified state
            device.Viewport = lastViewport;
            device.ScissorRectangle = lastScissorBox;
        }
    }
}