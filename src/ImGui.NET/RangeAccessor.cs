using System;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe struct RangeAccessor<T> where T : struct
    {
        private static readonly int s_sizeOfT = Unsafe.SizeOf<T>();

        public readonly void* Data;
        public readonly int Count;

        public RangeAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public ref T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return ref Unsafe.AsRef<T>((byte*)Data + s_sizeOfT * index);
            }
        }
    }
}
