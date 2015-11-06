using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    /// <summary>
    /// Draw command list
    /// This is the low-level list of polygons that ImGui functions are filling. At the end of the frame, all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.
    /// At the moment, each ImGui window contains its own ImDrawList but they could potentially be merged in the future.
    /// If you want to add custom rendering within a window, you can use ImGui::GetWindowDrawList() to access the current draw list and add your own primitives.
    /// You can interleave normal ImGui:: calls and adding primitives to the current draw list.
    /// All positions are in screen coordinates (0,0=top-left, 1 pixel per unit). Primitives are always added to the list and not culled (culling is done at render time and at a higher-level by ImGui:: functions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DrawList
    {
        // This is what you have to render

        /// <summary>
        /// ImVector(ImDrawCmd).
        /// Commands. Typically 1 command = 1 gpu draw call.
        /// </summary>
        public ImVector CmdBuffer;
        /// <summary>
        /// ImVector(ImDrawIdx).
        /// Index buffer. Each command consume ImDrawCmd::ElemCount of those
        /// </summary>
        public ImVector IdxBuffer;
        /// <summary>
        /// ImVector(ImDrawVert)
        /// </summary>
        public ImVector VtxBuffer;

        // [Internal, used while building lists]
        /// <summary>
        /// Pointer to owner window's name (if any) for debugging
        /// </summary>
        public IntPtr _OwnerName;
        /// <summary>
        /// [Internal] == VtxBuffer.Size
        /// </summary>
        public uint _VtxCurrentIdx;

        /// <summary>
        /// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)
        /// </summary>
        public IntPtr _VtxWritePtr;
        /// <summary>
        /// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)
        /// </summary>
        public IntPtr _IdxWritePtr;

        /// <summary>
        /// [Internal]
        /// </summary>
        public ImVector _ClipRectStack;
        /// <summary>
        /// [Internal]
        /// </summary>
        public ImVector _TextureIdStack;
        /// <summary>
        /// [Internal] current path building
        /// </summary>
        public ImVector _Path;

        /// <summary>
        /// [Internal] current channel number (0)
        /// </summary>
        public int _ChannelsCurrent;
        /// <summary>
        /// [Internal] number of active channels (1+)
        /// </summary>
        public int _ChannelsCount;

        /// <summary>
        /// [Internal] draw channels for columns API (not resized down so _ChannelsCount may be smaller than _Channels.Size)
        /// </summary>
        public ImVector _Channels;
    }
}
