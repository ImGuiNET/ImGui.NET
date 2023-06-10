using System;
using System.Runtime.CompilerServices;
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

        internal static int CalcSizeInUtf8(ReadOnlySpan<char> s, int start, int length)
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

        internal static int GetUtf8(string chars, byte* utf8Bytes, int utf8ByteCount)
        {
            return GetUtf8(chars.AsSpan(), utf8Bytes, utf8ByteCount);
        }

        internal static int GetUtf8(ReadOnlySpan<char> s, byte* utf8Bytes, int utf8ByteCount)
        {
            if (s.IsEmpty)
                return 0;
            
            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetBytes(utf16Ptr, s.Length, utf8Bytes, utf8ByteCount);
            }
        }

        internal static int GetUtf8(ReadOnlySpan<char> s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
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

        internal static int GetUtf8ByteCount(string chars)
        {
            return GetUtf8ByteCount(chars.AsSpan());
        }

        internal static int GetUtf8ByteCount(ReadOnlySpan<char> chars)
        {
            char* charsPtr = (char*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(chars));
            return Encoding.UTF8.GetByteCount(charsPtr, chars.Length);
        }
    }
}
