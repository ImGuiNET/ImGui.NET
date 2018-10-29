using System;
using System.Numerics;
using System.Runtime.CompilerServices;
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
            return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags)
        {
            return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback)
        {
            return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {

            int labelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* labelBytes = stackalloc byte[labelByteCount];
            fixed (char* labelPtr = label)
            {
                Encoding.UTF8.GetBytes(labelPtr, label.Length, labelBytes, labelByteCount);
            }

            fixed (byte* bufPtr = buf)
            {
                return ImGuiNative.igInputText(labelBytes, bufPtr, buf_size, flags, callback, user_data.ToPointer()) != 0;
            }
        }

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength) => InputText(label, ref input, maxLength, 0, null, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags) => InputText(label, ref input, maxLength, flags, null, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback) => InputText(label, ref input, maxLength, flags, callback, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int labelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* labelBytes = stackalloc byte[labelByteCount];
            fixed (char* labelPtr = label)
            {
                Encoding.UTF8.GetBytes(labelPtr, label.Length, labelBytes, labelByteCount);
            }

            int originalByteCount = Encoding.UTF8.GetByteCount(input);
            int stackBufSize = Math.Max((int)maxLength, originalByteCount);
            byte* bufBytes = stackalloc byte[stackBufSize];
            fixed (char* u16Ptr = input)
            {
                Encoding.UTF8.GetBytes(u16Ptr, input.Length, bufBytes, stackBufSize);
            }

            byte* originalBufBytes = stackalloc byte[originalByteCount];
            Unsafe.CopyBlock(originalBufBytes, bufBytes, (uint)originalByteCount);

            byte result = ImGuiNative.igInputText(
                labelBytes,
                bufBytes,
                (uint)stackBufSize,
                flags,
                callback,
                user_data.ToPointer());
            if (!Util.AreStringsEqual(originalBufBytes, originalByteCount, bufBytes))
            {
                input = Util.StringFromPtr(bufBytes);
            }

            return result != 0;
        }

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size) => InputTextMultiline(label, ref input, maxLength, size, 0, null, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags) => InputTextMultiline(label, ref input, maxLength, size, flags, null, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback) => InputTextMultiline(label, ref input, maxLength, size, flags, callback, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int labelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* labelBytes = stackalloc byte[labelByteCount];
            fixed (char* labelPtr = label)
            {
                Encoding.UTF8.GetBytes(labelPtr, label.Length, labelBytes, labelByteCount);
            }

            int originalByteCount = Encoding.UTF8.GetByteCount(input);
            int stackBufSize = Math.Max((int)maxLength, originalByteCount);
            byte* bufBytes = stackalloc byte[stackBufSize];
            fixed (char* u16Ptr = input)
            {
                Encoding.UTF8.GetBytes(u16Ptr, input.Length, bufBytes, stackBufSize);
            }

            byte* originalBufBytes = stackalloc byte[originalByteCount];
            Unsafe.CopyBlock(originalBufBytes, bufBytes, (uint)originalByteCount);

            byte result = ImGuiNative.igInputTextMultiline(
                labelBytes,
                bufBytes,
                (uint)stackBufSize,
                size,
                flags,
                callback,
                user_data.ToPointer());
            if (!Util.AreStringsEqual(originalBufBytes, originalByteCount, bufBytes))
            {
                input = Util.StringFromPtr(bufBytes);
            }

            return result != 0;
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size)
        {
            return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags)
        {
            return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback)
        {
            return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {

            int labelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* labelBytes = stackalloc byte[labelByteCount];
            fixed (char* labelPtr = label)
            {
                Encoding.UTF8.GetBytes(labelPtr, label.Length, labelBytes, labelByteCount);
            }

            return ImGuiNative.igInputText(labelBytes, (byte*)buf.ToPointer(), buf_size, flags, callback, user_data.ToPointer()) != 0;
        }

        public static bool Begin(string name, ImGuiWindowFlags flags)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte* p_open = null;
            byte ret = ImGuiNative.igBegin(native_name, p_open, flags);
            return ret != 0;
        }

        public static bool MenuItem(string label, bool enabled)
        {
            return MenuItem(label, string.Empty, false, enabled);
        }
    }
}
