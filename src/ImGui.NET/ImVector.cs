using System;
using System.Runtime.InteropServices;

namespace ImGui
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImVector
    {
        //[MarshalAs(UnmanagedType.SysInt)]
        public int Size;
        //[MarshalAs(UnmanagedType.SysInt)]
        public int Capacity;
        ///<summary>T* Data</summary>
        public void* Data;
    }
}
