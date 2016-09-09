using System.Runtime.InteropServices;
using System;
using System.Numerics;

namespace ImGuiNET
{
    // Load and rasterize multiple TTF fonts into a same texture.
    // Sharing a texture for multiple fonts allows us to reduce the number of draw calls during rendering.
    // We also add custom graphic data into the texture that serves for ImGui.
    //  1. (Optional) Call AddFont*** functions. If you don't call any, the default font will be loaded for you.
    //  2. Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.
    //  3. Upload the pixels data into a texture within your graphics system.
    //  4. Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture. This value will be passed back to you during rendering to identify the texture.
    //  5. Call ClearTexData() to free textures memory on the heap.
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeFontAtlas
    {
        // Members
        // (Access texture data via GetTexData*() calls which will setup a default font for you.)

        /// <summary>
        /// User data to refer to the texture once it has been uploaded to user's graphic systems.
        /// It ia passed back to you during rendering.
        /// </summary>
        public void* TexID;
        /// <summary>
        /// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight
        /// </summary>
        public byte* TexPixelsAlpha8;
        /// <summary>
        /// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4
        /// </summary>
        public UIntPtr TexPixelsRGBA32;
        /// <summary>
        /// Texture width calculated during Build().
        /// </summary>
        public IntPtr TexWidth;
        /// <summary>
        /// Texture height calculated during Build().
        /// </summary>
        public IntPtr TexHeight;
        /// <summary>
        /// Texture width desired by user before Build(). Must be a power-of-two.
        /// If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.
        /// </summary>
        public IntPtr TexDesiredWidth;
        /// <summary>
        /// Texture coordinates to a white pixel (part of the TexExtraData block)
        /// </summary>
        public Vector2 TexUvWhitePixel;

        /// <summary>
        /// (ImVector(ImFont*)
        /// </summary>
        public ImVector Fonts;

        // Private
        /// <summary>
        /// ImVector(ImFontConfig). Internal data
        /// </summary>
        public ImVector ConfigData;
    }
}
