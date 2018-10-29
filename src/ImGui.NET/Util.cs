using System.Text;

namespace ImGuiNET
{
    internal static class Util
    {
        public static unsafe string StringFromPtr(byte* ptr)
        {
            int characters = 0;
            while (ptr[characters] != 0)
            {
                characters++;
            }

            return Encoding.UTF8.GetString(ptr, characters);
        }

        internal static unsafe bool AreStringsEqual(string a, byte* b)
        {
            if (a.Length == 0) { return b[0] == 0; }

            int aCount = Encoding.UTF8.GetByteCount(a);
            byte* aBytes = stackalloc byte[aCount];
            fixed (char* labelPtr = a)
            {
                Encoding.UTF8.GetBytes(labelPtr, a.Length, aBytes, aCount);
            }

            for (int i = 0; i < aCount; i++)
            {
                if (aBytes[i] != b[i]) { return false; }
            }

            if (b[aCount] != 0) { return false; }

            return true;
        }
    }
}
