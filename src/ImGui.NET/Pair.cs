using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public struct Pair
    {
        public uint Key;
        public UnionValue Value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UnionValue
    {
        [FieldOffset(0)]
        public int ValueI32;
        [FieldOffset(0)]
        public float ValueF32;
        [FieldOffset(0)]
        public IntPtr ValuePtr;
    }
}
