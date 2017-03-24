using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public class TextInputBuffer : IDisposable
    {
        private uint _length;

        public IntPtr Buffer { get; private set; }

        public uint Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be greater that Int32.MaxValue.");
                }

                Resize((int)value);
            }
        }

        public TextInputBuffer(int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            CreateBuffer(length);
        }

        public TextInputBuffer(string initialText)
        {
            Buffer = Marshal.StringToHGlobalAnsi(initialText);
            Length = (uint)initialText.Length;
        }

        private unsafe void Resize(int newSize)
        {
            IntPtr newBuffer = Marshal.AllocHGlobal(newSize);
            Unsafe.CopyBlock(newBuffer.ToPointer(), Buffer.ToPointer(), Length);
            Marshal.FreeHGlobal(Buffer);
            Buffer = newBuffer;
            _length = (uint)newSize;
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
            _length = 0;
        }

        public string StringValue
        {
            get
            {
                return Marshal.PtrToStringAnsi(Buffer);
            }
            set
            {
                Debug.Assert(value != null);
                if (value.Length > Length) // Doesn't fit into current buffer
                {
                    FreeNativeBuffer();
                    Buffer = Marshal.StringToHGlobalAnsi(value);
                    _length = (uint)value.Length;
                }
                else // Fits in current buffer, just copy data in.
                {
                    IntPtr tempNativeString = Marshal.StringToHGlobalAnsi(value);
                    uint bytesToCopy = (uint)Math.Min(Length, value.Length);
                    unsafe
                    {
                        Unsafe.CopyBlock(Buffer.ToPointer(), tempNativeString.ToPointer(), bytesToCopy);
                        byte* endOfData = (byte*)Buffer.ToPointer() + bytesToCopy;
                        uint bytesToClear = _length - bytesToCopy;
                        Unsafe.InitBlock(endOfData, 0, bytesToClear);
                    }
                    Marshal.FreeHGlobal(tempNativeString);
                }
            }
        }

        public override string ToString() => StringValue;
    }
}
