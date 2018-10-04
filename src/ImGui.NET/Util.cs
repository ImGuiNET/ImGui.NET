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
    }
}
