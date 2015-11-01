using System.Runtime.InteropServices;

namespace ImGui
{
    // All draw data to render an ImGui frame
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DrawData
    {
        public byte Valid;                  // Only valid after Render() is called and before the next NewFrame() is called.
        public DrawList** CmdLists;
        public int CmdListsCount;
        public int TotalVtxCount;          // For convenience, sum of all cmd_lists vtx_buffer.Size
        public int TotalIdxCount;          // For convenience, sum of all cmd_lists idx_buffer.Size
    };
}
