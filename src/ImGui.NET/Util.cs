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

        internal static unsafe bool AreStringsEqual(byte* a, int aLength, byte* b)
        {
            for (int i = 0; i < aLength; i++)
            {
                if (a[i] != b[i]) { return false; }
            }

            if (b[aLength] != 0) { return false; }

            return true;
        }
    }
}
