using System;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe struct ImPool
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ImPool(int size, int capacity, IntPtr data)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
        }

        public ref T Ref<T>(int index)
        {
            return ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
        }

        public IntPtr Address<T>(int index)
        {
            return (IntPtr)((byte*)Data + index * Unsafe.SizeOf<T>());
        }
    }

    public unsafe struct ImPool<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ImPool(ImPool Pool)
        {
            Size = Pool.Size;
            Capacity = Pool.Capacity;
            Data = Pool.Data;
        }

        public ImPool(int size, int capacity, IntPtr data)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
        }

        public ref T this[int index] => ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
    }

    public unsafe struct ImPtrPool<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;
        private readonly int _stride;

        public ImPtrPool(ImPool Pool, int stride)
            : this(Pool.Size, Pool.Capacity, Pool.Data, stride)
        { }

        public ImPtrPool(int size, int capacity, IntPtr data, int stride)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
            _stride = stride;
        }

        public T this[int index]
        {
            get
            {
                byte* address = (byte*)Data + index * _stride;
                T ret = Unsafe.Read<T>(&address);
                return ret;
            }
        }
    }
}