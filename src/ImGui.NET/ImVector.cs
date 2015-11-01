using System.Runtime.InteropServices;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImVector
    {
        public int Size;
        public int Capacity;
        ///<summary>T* Data</summary>
        public void* Data;
    }
}
