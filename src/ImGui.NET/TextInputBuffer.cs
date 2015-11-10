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
            ClearBuffer();
            CreateBuffer(newSize);
        }

        private void CreateBuffer(int size)
        {
            Buffer = Marshal.AllocHGlobal(size);
            Length = Length;
        }

        private void ClearBuffer()
        {
            Marshal.FreeHGlobal(Buffer);
            Buffer = IntPtr.Zero;
            Length = 0;
        }

        public void Dispose()
        {
            if (Buffer != IntPtr.Zero)
            {
                ClearBuffer();
            }
        }
    }
}
