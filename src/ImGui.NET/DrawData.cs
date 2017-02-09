using System.Runtime.InteropServices;

namespace ImGuiNET
{
    /// <summary>
    /// All draw data to render an ImGui frame
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DrawData
    {
        /// <summary>
        /// Only valid after Render() is called and before the next NewFrame() is called.
        /// </summary>
        public byte Valid;
        public NativeDrawList** CmdLists;
        public int CmdListsCount;
        /// <summary>
        /// For convenience, sum of all cmd_lists vtx_buffer.Size
        /// </summary>
        public int TotalVtxCount;
        /// <summary>
        /// For convenience, sum of all cmd_lists idx_buffer.Size
        /// </summary>
        public int TotalIdxCount;
    };
}
