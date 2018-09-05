using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGui
    {
        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size)
        {
            return InputText(label, buf, buf_size, 0, null, null);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags)
        {
            return InputText(label, buf, buf_size, flags, null, null);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback)
        {
            return InputText(label, buf, buf_size, flags, callback, null);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            void* user_data)
        {

            int labelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* labelBytes = stackalloc byte[labelByteCount];
            fixed (char* labelPtr = label)
            {
                Encoding.UTF8.GetBytes(labelPtr, label.Length, labelBytes, labelByteCount);
            }

            fixed (byte* bufPtr = buf)
            {
                return ImGuiNative.igInputText(labelBytes, bufPtr, buf_size, flags, callback, user_data) != 0;
            }
        }
    }
}
