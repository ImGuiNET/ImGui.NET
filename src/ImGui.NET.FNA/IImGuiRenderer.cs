using System;

namespace ImGuiNET
{
    public interface IImGuiRenderer
    {
        /// <summary>
        /// Called after one or more calls to ImGui.GetIO().FontAtlas.AddFontXX().
        /// Creates/updates the font atlas texture
        /// </summary>
        void RebuildFontAtlas();

        /// <summary>
        /// Update ImGui.GetIO() with the current time and inputs
        /// </summary>
        void Update(float deltaSeconds);

        /// <summary>
        /// Binds an api-specific texture to an ImGui-local texture id that can be passed to calls such as <see cref="ImGui.Image()"/>
        /// </summary>
        IntPtr BindTexture(object texture);

        /// <summary>
        /// Removes the binding, therefore releasing the bound texture
        /// </summary>
        void UnbindTexture(IntPtr textureId);

        /// <summary>
        /// Gets the created layout of the current frame from ImGui and draws it using the specific graphical implementation
        /// </summary>
        void Render();
    }
}