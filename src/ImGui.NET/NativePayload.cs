using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativePayload
    {
        public void* Data;
        public int DataSize;

        // Internal
        private uint SourceId;
        private uint SourceParentId;
        private int DataFrameCount;
        private fixed byte DataType[8 + 1];
        private byte Preview;
        private byte Delivery;
    }
}
