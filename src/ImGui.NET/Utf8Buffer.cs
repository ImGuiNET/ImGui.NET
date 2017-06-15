using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe class Utf8Buffer
    {
        private const int BufferSize = 4 * 1024 * 20;  //20k utf8 chars at least
        private GCHandle _pinnedArray;
        private readonly IntPtr _memPtr;
        private readonly byte[] _arrayBuffer;
        private int _usedBytes;

        public Utf8Buffer()
        {
            _arrayBuffer = new byte[BufferSize];
            _pinnedArray = GCHandle.Alloc(_arrayBuffer, GCHandleType.Pinned);
            _memPtr = _pinnedArray.AddrOfPinnedObject();
        }

        //reset buffer position and make sure that any pointer into it will result in null-terminated string
        public void Reset()
        {
            _usedBytes = 0;
            _arrayBuffer[0] = 0;
            _arrayBuffer[BufferSize - 1] = 0;
        }

        public byte* FromStr(string str)
        {
            byte* dest = (byte*)_memPtr;
            //If the maximum possible string length doesn't fit our buffer, just return an empty string.
            //Probly some message like <Utf8Buffer: couldn't convert text> would be better, so user knows what happened
            //If _usedBytes equals 0, we could also re-allocate the buffer
            var maxBytes = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
            if (BufferSize < maxBytes)
            {
                Reset();
                return dest;
            }

            //Wrap if it's possible that the string won't fit. 
            //This is ok, assuming one ImGui call doesn't use longer strings (sum of their utf8 byte lengths) that would fit into our buffer.
            if (BufferSize < _usedBytes + maxBytes)
            {
                Reset();
            }

            dest += _usedBytes;
            int byteCount = Encoding.UTF8.GetBytes(str, 0, str.Length, _arrayBuffer, _usedBytes);
            dest[byteCount] = 0;
            _usedBytes += byteCount + 1;

            return dest;
        }

        public string ToStr(byte* b)
        {
            if (b == null)
                return string.Empty;
            int length = 0;
            while (b[length] != '\0')
                length++;

            Marshal.Copy((IntPtr)b, _arrayBuffer, 0, length);
            return Encoding.UTF8.GetString(_arrayBuffer, 0, length);
        }
    }
}
