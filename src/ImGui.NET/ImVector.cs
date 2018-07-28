using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe struct ImVector
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly void* Data;

        public ref T Ref<T>(int index)
        {
            return ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
        }
    }
}
