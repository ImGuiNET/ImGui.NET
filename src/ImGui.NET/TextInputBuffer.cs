using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public class TextInputBuffer : IDisposable
    {
        public IntPtr Buffer { get; private set; }
        public uint Length { get; private set; }

        public TextInputBuffer(int length)
        {
            CreateBuffer(length);
        }

        public TextInputBuffer(string initialText)
        {
            Buffer = Marshal.StringToHGlobalAnsi(initialText);
            Length = (uint)initialText.Length;
        }

        public void Resize(int newSize)
        {
            FreeNativeBuffer();
            CreateBuffer(newSize);
        }

        private unsafe void CreateBuffer(int size)
        {
            Buffer = Marshal.AllocHGlobal(size);
            Length = (uint)size;
            ClearData();
        }

        public unsafe void ClearData()
        {
            byte* ptr = (byte*)Buffer.ToPointer();
            for (int i = 0; i < Length; i++)
            {
                ptr[i] = 0;
            }
        }

        public void Dispose()
        {
            if (Buffer != IntPtr.Zero)
            {
                FreeNativeBuffer();
            }
        }

        private void FreeNativeBuffer()
        {
            Marshal.FreeHGlobal(Buffer);
            Buffer = IntPtr.Zero;
            Length = 0;
        }

        public string StringValue
        {
            get
            {
                return Marshal.PtrToStringAnsi(Buffer);
            }
            set
            {
                FreeNativeBuffer();
                Buffer = Marshal.StringToHGlobalAnsi(value);
                Length = (uint)value.Length;
            }
        }

        public override string ToString() => StringValue;
    }
}
