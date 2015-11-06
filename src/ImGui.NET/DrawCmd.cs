using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    /// <summary>
    /// Typically, 1 command = 1 gpu draw call (unless command is a callback)
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DrawCmd
    {
        /// <summary>
        /// Number of indices (multiple of 3) to be rendered as triangles.
        /// Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].
        /// </summary>
        public uint ElemCount;
        /// <summary>
        /// Clipping rectangle (x1, y1, x2, y2)
        /// </summary>
        public Vector4 ClipRect;
        /// <summary>
        /// User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions.
        /// Ignore if never using images or multiple fonts atlas.
        /// </summary>
        public IntPtr TextureId;
        /// <summary>
        /// If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.
        /// </summary>
        public IntPtr UserCallback;
        /// <summary>
        /// The draw callback code can access this.
        /// </summary>
        public IntPtr UserCallbackData;
    };
}
