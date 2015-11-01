using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ImVec4 = System.Numerics.Vector4;
using System.Runtime.InteropServices;

namespace ImGui
{
    // Typically, 1 command = 1 gpu draw call (unless command is a callback)
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct ImDrawCmd
    {
        public uint ElemCount;              // Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].
        public ImVec4 ClipRect;               // Clipping rectangle (x1, y1, x2, y2)
        public IntPtr TextureId;              // User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.
        
        // typedef void (*ImDrawCallback)(const ImDrawList* parent_list, const ImDrawCmd* cmd);
        public IntPtr UserCallback;           // If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.
        public IntPtr UserCallbackData;       // The draw callback code can access this.

        /*
        public ImDrawCmd() { ElemCount = 0; ClipRect.X = ClipRect.Y = -8192.0f; ClipRect.Z = ClipRect.W = +8192.0f; TextureId = ImTextureID.Zero; UserCallback = null; UserCallbackData = null; }
        */
    };
}
