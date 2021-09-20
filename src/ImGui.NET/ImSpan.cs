using System;
using System.Runtime.CompilerServices;


namespace ImGuiNET
{
    public unsafe struct ImSpan
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ImSpan(int size, int capacity, IntPtr data)
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

    public unsafe struct ImSpan<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ImSpan(ImSpan span)
        {
            Size = span.Size;
            Capacity = span.Capacity;
            Data = span.Data;
        }

        public ImSpan(int size, int capacity, IntPtr data)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
        }

        public ref T this[int index] => ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
    }

    public unsafe struct ImPtrSpan<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;
        private readonly int _stride;

        public ImPtrSpan(ImSpan span, int stride)
            : this(span.Size, span.Capacity, span.Data, stride)
        { }

        public ImPtrSpan(int size, int capacity, IntPtr data, int stride)
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