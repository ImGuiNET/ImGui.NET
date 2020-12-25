using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    internal static unsafe class Util
    {
        internal const int StackAllocationSizeLimit = 2048;

        public static string StringFromPtr(byte* ptr)
        {
            int characters = 0;
            while (ptr[characters] != 0)
            {
                characters++;
            }

            return Encoding.UTF8.GetString(ptr, characters);
        }

        internal static bool AreStringsEqual(byte* a, int aLength, byte* b)
        {
            for (int i = 0; i < aLength; i++)
            {
                if (a[i] != b[i]) { return false; }
            }

            if (b[aLength] != 0) { return false; }

            return true;
        }

        internal static byte* Allocate(int byteCount) => (byte*)Marshal.AllocHGlobal(byteCount);

        internal static void Free(byte* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

        internal static int CalcSizeInUtf8(string s, int start, int length)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetByteCount(utf16Ptr + start, length);
            }
        }

        internal static int GetUtf8(string s, byte* utf8Bytes, int utf8ByteCount)
        {
            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetBytes(utf16Ptr, s.Length, utf8Bytes, utf8ByteCount);
            }
        }

        internal static int GetUtf8(string s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetBytes(utf16Ptr + start, length, utf8Bytes, utf8ByteCount);
            }
        }
    }
}
