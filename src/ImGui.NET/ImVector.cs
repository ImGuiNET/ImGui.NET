using System;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe struct ImVector
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ref T Ref<T>(int index)
        {
            return ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
        }

        public IntPtr Address<T>(int index)
        {
            return (IntPtr)((byte*)Data + index * Unsafe.SizeOf<T>());
        }
    }
}
