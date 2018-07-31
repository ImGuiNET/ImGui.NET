using System;
using System.Runtime.InteropServices;

namespace ImGuiNET.FNA
{
    public unsafe struct ImVector<T> where T : struct
    {
        // This won't change during the life of the application.
        private readonly static Type _T = typeof(T);

        private readonly static int _TSize = Marshal.SizeOf(_T);

        public readonly ImVector* Native;

        public ImVector(ImGuiNET.ImVector* native)
        {
            Native = native;
        }

        public int Size
        {
            get => Native->Size;
            set => Native->Size = value;
        }

        public int Capacity
        {
            get => Native->Capacity;
            set => Native->Capacity = value;
        }

        public IntPtr Data
        {
            get => new IntPtr(Native->Data);
            set => Native->Data = value.ToPointer();
        }

        // T* not allowed in C#; Using Marshal.SizeOf(typeof(T)) instead.
        public T this[int i]
        {
            get => (T)Marshal.PtrToStructure(new IntPtr((long)Data + i * _TSize), _T);
            set => Marshal.StructureToPtr(value, new IntPtr((long)Data + i * _TSize), true);
        }

        public static implicit operator ImVector* (ImVector<T> v) => v.Native;

        public static implicit operator ImVector<T>(ImVector* v) => new ImVector<T>(v);

        public static implicit operator ImVector(ImVector<T> v) => *v.Native;
    }
}