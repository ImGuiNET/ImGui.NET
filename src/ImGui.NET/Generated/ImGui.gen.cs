using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using static ImGuiNET.ImGuiNative;

namespace ImGuiNET
{
    public unsafe static partial class ImGui
    {
        public static float GetFrameHeight()
        {
            float ret = ImGuiNative.igGetFrameHeight();
            return ret;
        }
        public static IntPtr CreateContext()
        {
            ImFontAtlas* shared_font_atlas = null;
            IntPtr ret = ImGuiNative.igCreateContext(shared_font_atlas);
            return ret;
        }
        public static IntPtr CreateContext(ImFontAtlasPtr shared_font_atlas)
        {
            ImFontAtlas* native_shared_font_atlas = shared_font_atlas.NativePtr;
            IntPtr ret = ImGuiNative.igCreateContext(native_shared_font_atlas);
            return ret;
        }
        public static void TextUnformatted(string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            ImGuiNative.igTextUnformatted(native_text, native_text_end);
        }
        public static void TextUnformatted(string text, string text_end)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            ImGuiNative.igTextUnformatted(native_text, native_text_end);
        }
        public static void PopFont()
        {
            ImGuiNative.igPopFont();
        }
        public static bool Combo(string label, ref int current_item, string[] items, int items_count)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    offset += 1;
                    native_items_data[offset] = 0;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            int popup_max_height_in_items = -1;
            byte ret = ImGuiNative.igCombo(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static bool Combo(string label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    offset += 1;
                    native_items_data[offset] = 0;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            byte ret = ImGuiNative.igCombo(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
            byte* native_items_separated_by_zeros = stackalloc byte[items_separated_by_zeros_byteCount + 1];
            fixed (char* items_separated_by_zeros_ptr = items_separated_by_zeros)
            {
                int native_items_separated_by_zeros_offset = Encoding.UTF8.GetBytes(items_separated_by_zeros_ptr, items_separated_by_zeros.Length, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            int popup_max_height_in_items = -1;
            byte ret = ImGuiNative.igComboStr(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros, int popup_max_height_in_items)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
            byte* native_items_separated_by_zeros = stackalloc byte[items_separated_by_zeros_byteCount + 1];
            fixed (char* items_separated_by_zeros_ptr = items_separated_by_zeros)
            {
                int native_items_separated_by_zeros_offset = Encoding.UTF8.GetBytes(items_separated_by_zeros_ptr, items_separated_by_zeros.Length, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            byte ret = ImGuiNative.igComboStr(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static void CaptureKeyboardFromApp()
        {
            byte capture = 1;
            ImGuiNative.igCaptureKeyboardFromApp(capture);
        }
        public static void CaptureKeyboardFromApp(bool capture)
        {
            byte native_capture = capture ? (byte)1 : (byte)0;
            ImGuiNative.igCaptureKeyboardFromApp(native_capture);
        }
        public static bool IsWindowFocused()
        {
            ImGuiFocusedFlags flags = 0;
            byte ret = ImGuiNative.igIsWindowFocused(flags);
            return ret != 0;
        }
        public static bool IsWindowFocused(ImGuiFocusedFlags flags)
        {
            byte ret = ImGuiNative.igIsWindowFocused(flags);
            return ret != 0;
        }
        public static void Render()
        {
            ImGuiNative.igRender();
        }
        public static bool DragFloat4(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat4(string label, float* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat4(string label, float* v, float v_speed, float v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat4(string label, float* v, float v_speed, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat4(string label, float* v, float v_speed, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat4(string label, float* v, float v_speed, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragFloat4(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool IsMousePosValid()
        {
            Vector2* mouse_pos = null;
            byte ret = ImGuiNative.igIsMousePosValid(mouse_pos);
            return ret != 0;
        }
        public static bool IsMousePosValid(ref Vector2 mouse_pos)
        {
            Vector2 native_mouse_pos_val = mouse_pos;
            Vector2* native_mouse_pos = &native_mouse_pos_val;
            byte ret = ImGuiNative.igIsMousePosValid(native_mouse_pos);
            mouse_pos = native_mouse_pos_val;
            return ret != 0;
        }
        public static Vector2 GetCursorScreenPos()
        {
            Vector2 ret = ImGuiNative.igGetCursorScreenPos();
            return ret;
        }
        public static bool DebugCheckVersionAndDataLayout(string version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert)
        {
            int version_str_byteCount = Encoding.UTF8.GetByteCount(version_str);
            byte* native_version_str = stackalloc byte[version_str_byteCount + 1];
            fixed (char* version_str_ptr = version_str)
            {
                int native_version_str_offset = Encoding.UTF8.GetBytes(version_str_ptr, version_str.Length, native_version_str, version_str_byteCount);
                native_version_str[native_version_str_offset] = 0;
            }
            byte ret = ImGuiNative.igDebugCheckVersionAndDataLayout(native_version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert);
            return ret != 0;
        }
        public static void SetScrollHere()
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.igSetScrollHere(center_y_ratio);
        }
        public static void SetScrollHere(float center_y_ratio)
        {
            ImGuiNative.igSetScrollHere(center_y_ratio);
        }
        public static void SetScrollY(float scroll_y)
        {
            ImGuiNative.igSetScrollY(scroll_y);
        }
        public static void SetColorEditOptions(ImGuiColorEditFlags flags)
        {
            ImGuiNative.igSetColorEditOptions(flags);
        }
        public static void SetScrollFromPosY(float pos_y)
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.igSetScrollFromPosY(pos_y, center_y_ratio);
        }
        public static void SetScrollFromPosY(float pos_y, float center_y_ratio)
        {
            ImGuiNative.igSetScrollFromPosY(pos_y, center_y_ratio);
        }
        public static Vector4* GetStyleColorVec4(ImGuiCol idx)
        {
            Vector4* ret = ImGuiNative.igGetStyleColorVec4(idx);
            return ret;
        }
        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max)
        {
            byte clip = 1;
            byte ret = ImGuiNative.igIsMouseHoveringRect(r_min, r_max, clip);
            return ret != 0;
        }
        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, bool clip)
        {
            byte native_clip = clip ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsMouseHoveringRect(r_min, r_max, native_clip);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v, float v_speed, float v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v, float v_speed, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v, float v_speed, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat3(string label, float* v, float v_speed, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragFloat3(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static void Value(string prefix, bool b)
        {
            int prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
            byte* native_prefix = stackalloc byte[prefix_byteCount + 1];
            fixed (char* prefix_ptr = prefix)
            {
                int native_prefix_offset = Encoding.UTF8.GetBytes(prefix_ptr, prefix.Length, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuiNative.igValueBool(native_prefix, native_b);
        }
        public static void Value(string prefix, int v)
        {
            int prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
            byte* native_prefix = stackalloc byte[prefix_byteCount + 1];
            fixed (char* prefix_ptr = prefix)
            {
                int native_prefix_offset = Encoding.UTF8.GetBytes(prefix_ptr, prefix.Length, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            ImGuiNative.igValueInt(native_prefix, v);
        }
        public static void Value(string prefix, uint v)
        {
            int prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
            byte* native_prefix = stackalloc byte[prefix_byteCount + 1];
            fixed (char* prefix_ptr = prefix)
            {
                int native_prefix_offset = Encoding.UTF8.GetBytes(prefix_ptr, prefix.Length, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            ImGuiNative.igValueUint(native_prefix, v);
        }
        public static void Value(string prefix, float v)
        {
            int prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
            byte* native_prefix = stackalloc byte[prefix_byteCount + 1];
            fixed (char* prefix_ptr = prefix)
            {
                int native_prefix_offset = Encoding.UTF8.GetBytes(prefix_ptr, prefix.Length, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            byte* native_float_format = null;
            ImGuiNative.igValueFloat(native_prefix, v, native_float_format);
        }
        public static void Value(string prefix, float v, string float_format)
        {
            int prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
            byte* native_prefix = stackalloc byte[prefix_byteCount + 1];
            fixed (char* prefix_ptr = prefix)
            {
                int native_prefix_offset = Encoding.UTF8.GetBytes(prefix_ptr, prefix.Length, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            int float_format_byteCount = Encoding.UTF8.GetByteCount(float_format);
            byte* native_float_format = stackalloc byte[float_format_byteCount + 1];
            fixed (char* float_format_ptr = float_format)
            {
                int native_float_format_offset = Encoding.UTF8.GetBytes(float_format_ptr, float_format.Length, native_float_format, float_format_byteCount);
                native_float_format[native_float_format_offset] = 0;
            }
            ImGuiNative.igValueFloat(native_prefix, v, native_float_format);
        }
        public static Vector2 GetItemRectMax()
        {
            Vector2 ret = ImGuiNative.igGetItemRectMax();
            return ret;
        }
        public static bool IsItemDeactivated()
        {
            byte ret = ImGuiNative.igIsItemDeactivated();
            return ret != 0;
        }
        public static void PushStyleVar(ImGuiStyleVar idx, float val)
        {
            ImGuiNative.igPushStyleVarFloat(idx, val);
        }
        public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
        {
            ImGuiNative.igPushStyleVarVec2(idx, val);
        }
        public static byte* SaveIniSettingsToMemory()
        {
            uint* out_ini_size = null;
            byte* ret = ImGuiNative.igSaveIniSettingsToMemory(out_ini_size);
            return ret;
        }
        public static byte* SaveIniSettingsToMemory(out uint out_ini_size)
        {
            uint native_out_ini_size_val;
            uint* native_out_ini_size = &native_out_ini_size_val;
            byte* ret = ImGuiNative.igSaveIniSettingsToMemory(native_out_ini_size);
            out_ini_size = native_out_ini_size_val;
            return ret;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_current_min_val = v_current_min;
            int* native_v_current_min = &native_v_current_min_val;
            int native_v_current_max_val = v_current_max;
            int* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            int format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
            byte* native_format_max = stackalloc byte[format_max_byteCount + 1];
            fixed (char* format_max_ptr = format_max)
            {
                int native_format_max_offset = Encoding.UTF8.GetBytes(format_max_ptr, format_max.Length, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static void Unindent()
        {
            float indent_w = 0.0f;
            ImGuiNative.igUnindent(indent_w);
        }
        public static void Unindent(float indent_w)
        {
            ImGuiNative.igUnindent(indent_w);
        }
        public static void PopAllowKeyboardFocus()
        {
            ImGuiNative.igPopAllowKeyboardFocus();
        }
        public static void LoadIniSettingsFromDisk(string ini_filename)
        {
            int ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
            byte* native_ini_filename = stackalloc byte[ini_filename_byteCount + 1];
            fixed (char* ini_filename_ptr = ini_filename)
            {
                int native_ini_filename_offset = Encoding.UTF8.GetBytes(ini_filename_ptr, ini_filename.Length, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            ImGuiNative.igLoadIniSettingsFromDisk(native_ini_filename);
        }
        public static Vector2 GetCursorStartPos()
        {
            Vector2 ret = ImGuiNative.igGetCursorStartPos();
            return ret;
        }
        public static void SetCursorScreenPos(Vector2 screen_pos)
        {
            ImGuiNative.igSetCursorScreenPos(screen_pos);
        }
        public static bool InputInt4(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt4(native_label, v, extra_flags);
            return ret != 0;
        }
        public static bool InputInt4(string label, int* v, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igInputInt4(native_label, v, extra_flags);
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 size)
        {
            byte ret = ImGuiNative.igIsRectVisible(size);
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 rect_min, Vector2 rect_max)
        {
            byte ret = ImGuiNative.igIsRectVisibleVec2(rect_min, rect_max);
            return ret != 0;
        }
        public static void LabelText(string label, string fmt)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igLabelText(native_label, native_fmt);
        }
        public static void LogFinish()
        {
            ImGuiNative.igLogFinish();
        }
        public static bool IsKeyPressed(int user_key_index)
        {
            byte repeat = 1;
            byte ret = ImGuiNative.igIsKeyPressed(user_key_index, repeat);
            return ret != 0;
        }
        public static bool IsKeyPressed(int user_key_index, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsKeyPressed(user_key_index, native_repeat);
            return ret != 0;
        }
        public static float GetColumnOffset()
        {
            int column_index = -1;
            float ret = ImGuiNative.igGetColumnOffset(column_index);
            return ret;
        }
        public static float GetColumnOffset(int column_index)
        {
            float ret = ImGuiNative.igGetColumnOffset(column_index);
            return ret;
        }
        public static void SetNextWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = 0;
            ImGuiNative.igSetNextWindowCollapsed(native_collapsed, cond);
        }
        public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetNextWindowCollapsed(native_collapsed, cond);
        }
        public static IntPtr GetCurrentContext()
        {
            IntPtr ret = ImGuiNative.igGetCurrentContext();
            return ret;
        }
        public static bool SmallButton(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igSmallButton(native_label);
            return ret != 0;
        }
        public static bool OpenPopupOnItemClick()
        {
            byte* native_str_id = null;
            int mouse_button = 1;
            byte ret = ImGuiNative.igOpenPopupOnItemClick(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool OpenPopupOnItemClick(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int mouse_button = 1;
            byte ret = ImGuiNative.igOpenPopupOnItemClick(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool OpenPopupOnItemClick(string str_id, int mouse_button)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igOpenPopupOnItemClick(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool IsAnyMouseDown()
        {
            byte ret = ImGuiNative.igIsAnyMouseDown();
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size)
        {
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            int frame_padding = -1;
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0)
        {
            Vector2 uv1 = new Vector2(1, 1);
            int frame_padding = -1;
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1)
        {
            int frame_padding = -1;
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding)
        {
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col)
        {
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col)
        {
            byte ret = ImGuiNative.igImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);
            return ret != 0;
        }
        public static void EndFrame()
        {
            ImGuiNative.igEndFrame();
        }
        public static bool SliderFloat2(string label, float* v, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat2(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat2(string label, float* v, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat2(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat2(string label, float* v, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderFloat2(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool RadioButton(string label, bool active)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_active = active ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igRadioButtonBool(native_label, native_active);
            return ret != 0;
        }
        public static bool RadioButton(string label, ref int v, int v_button)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            byte ret = ImGuiNative.igRadioButtonIntPtr(native_label, native_v, v_button);
            v = native_v_val;
            return ret != 0;
        }
        public static bool IsItemDeactivatedAfterEdit()
        {
            byte ret = ImGuiNative.igIsItemDeactivatedAfterEdit();
            return ret != 0;
        }
        public static ImDrawListPtr GetWindowDrawList()
        {
            ImDrawList* ret = ImGuiNative.igGetWindowDrawList();
            return new ImDrawListPtr(ret);
        }
        public static void NewLine()
        {
            ImGuiNative.igNewLine();
        }
        public static bool IsItemFocused()
        {
            byte ret = ImGuiNative.igIsItemFocused();
            return ret != 0;
        }
        public static void LoadIniSettingsFromMemory(string ini_data)
        {
            int ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
            byte* native_ini_data = stackalloc byte[ini_data_byteCount + 1];
            fixed (char* ini_data_ptr = ini_data)
            {
                int native_ini_data_offset = Encoding.UTF8.GetBytes(ini_data_ptr, ini_data.Length, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            uint ini_size = 0;
            ImGuiNative.igLoadIniSettingsFromMemory(native_ini_data, ini_size);
        }
        public static void LoadIniSettingsFromMemory(string ini_data, uint ini_size)
        {
            int ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
            byte* native_ini_data = stackalloc byte[ini_data_byteCount + 1];
            fixed (char* ini_data_ptr = ini_data)
            {
                int native_ini_data_offset = Encoding.UTF8.GetBytes(ini_data_ptr, ini_data.Length, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            ImGuiNative.igLoadIniSettingsFromMemory(native_ini_data, ini_size);
        }
        public static bool SliderInt2(string label, int* v, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt2(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool SliderInt2(string label, int* v, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt2(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static void SetWindowSize(Vector2 size)
        {
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowSizeVec2(size, cond);
        }
        public static void SetWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.igSetWindowSizeVec2(size, cond);
        }
        public static void SetWindowSize(string name, Vector2 size)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowSizeStr(native_name, size, cond);
        }
        public static void SetWindowSize(string name, Vector2 size, ImGuiCond cond)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            ImGuiNative.igSetWindowSizeStr(native_name, size, cond);
        }
        public static bool InputFloat(string label, ref float v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            float step = 0.0f;
            float step_fast = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputFloat(string label, ref float v, float step)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            float step_fast = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static void ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v)
        {
            ImGuiNative.igColorConvertRGBtoHSV(r, g, b, out_h, out_s, out_v);
        }
        public static bool BeginMenuBar()
        {
            byte ret = ImGuiNative.igBeginMenuBar();
            return ret != 0;
        }
        public static bool IsPopupOpen(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igIsPopupOpen(native_str_id);
            return ret != 0;
        }
        public static bool IsItemVisible()
        {
            byte ret = ImGuiNative.igIsItemVisible();
            return ret != 0;
        }
        public static void SetNextWindowSize(Vector2 size)
        {
            ImGuiCond cond = 0;
            ImGuiNative.igSetNextWindowSize(size, cond);
        }
        public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.igSetNextWindowSize(size, cond);
        }
        public static void SetWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowCollapsedBool(native_collapsed, cond);
        }
        public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetWindowCollapsedBool(native_collapsed, cond);
        }
        public static void SetWindowCollapsed(string name, bool collapsed)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowCollapsedStr(native_name, native_collapsed, cond);
        }
        public static void SetWindowCollapsed(string name, bool collapsed, ImGuiCond cond)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetWindowCollapsedStr(native_name, native_collapsed, cond);
        }
        public static Vector2 GetMouseDragDelta()
        {
            int button = 0;
            float lock_threshold = -1.0f;
            Vector2 ret = ImGuiNative.igGetMouseDragDelta(button, lock_threshold);
            return ret;
        }
        public static Vector2 GetMouseDragDelta(int button)
        {
            float lock_threshold = -1.0f;
            Vector2 ret = ImGuiNative.igGetMouseDragDelta(button, lock_threshold);
            return ret;
        }
        public static Vector2 GetMouseDragDelta(int button, float lock_threshold)
        {
            Vector2 ret = ImGuiNative.igGetMouseDragDelta(button, lock_threshold);
            return ret;
        }
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type)
        {
            int type_byteCount = Encoding.UTF8.GetByteCount(type);
            byte* native_type = stackalloc byte[type_byteCount + 1];
            fixed (char* type_ptr = type)
            {
                int native_type_offset = Encoding.UTF8.GetBytes(type_ptr, type.Length, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            ImGuiDragDropFlags flags = 0;
            ImGuiPayload* ret = ImGuiNative.igAcceptDragDropPayload(native_type, flags);
            return new ImGuiPayloadPtr(ret);
        }
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type, ImGuiDragDropFlags flags)
        {
            int type_byteCount = Encoding.UTF8.GetByteCount(type);
            byte* native_type = stackalloc byte[type_byteCount + 1];
            fixed (char* type_ptr = type)
            {
                int native_type_offset = Encoding.UTF8.GetBytes(type_ptr, type.Length, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            ImGuiPayload* ret = ImGuiNative.igAcceptDragDropPayload(native_type, flags);
            return new ImGuiPayloadPtr(ret);
        }
        public static bool BeginDragDropSource()
        {
            ImGuiDragDropFlags flags = 0;
            byte ret = ImGuiNative.igBeginDragDropSource(flags);
            return ret != 0;
        }
        public static bool BeginDragDropSource(ImGuiDragDropFlags flags)
        {
            byte ret = ImGuiNative.igBeginDragDropSource(flags);
            return ret != 0;
        }
        public static void PlotLines(string label, ref float values, int values_count)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            byte* native_overlay_text = null;
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            int stride = sizeof(float);
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            ImGuiNative.igPlotLines(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static int GetFrameCount()
        {
            int ret = ImGuiNative.igGetFrameCount();
            return ret;
        }
        public static void ListBoxFooter()
        {
            ImGuiNative.igListBoxFooter();
        }
        public static void PopClipRect()
        {
            ImGuiNative.igPopClipRect();
        }
        public static Vector2 GetWindowSize()
        {
            Vector2 ret = ImGuiNative.igGetWindowSize();
            return ret;
        }
        public static bool CheckboxFlags(string label, ref uint flags, uint flags_value)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            uint native_flags_val = flags;
            uint* native_flags = &native_flags_val;
            byte ret = ImGuiNative.igCheckboxFlags(native_label, native_flags, flags_value);
            flags = native_flags_val;
            return ret != 0;
        }
        public static bool IsWindowHovered()
        {
            ImGuiHoveredFlags flags = 0;
            byte ret = ImGuiNative.igIsWindowHovered(flags);
            return ret != 0;
        }
        public static bool IsWindowHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.igIsWindowHovered(flags);
            return ret != 0;
        }
        public static void PlotHistogram(string label, ref float values, int values_count)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            byte* native_overlay_text = null;
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            float scale_min = 3.40282346638528859812e+38F;
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            float scale_max = 3.40282346638528859812e+38F;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            int stride = sizeof(float);
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_values_val = values;
            float* native_values = &native_values_val;
            int overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
            byte* native_overlay_text = stackalloc byte[overlay_text_byteCount + 1];
            fixed (char* overlay_text_ptr = overlay_text)
            {
                int native_overlay_text_offset = Encoding.UTF8.GetBytes(overlay_text_ptr, overlay_text.Length, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            ImGuiNative.igPlotHistogramFloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
            values = native_values_val;
        }
        public static bool BeginPopupContextVoid()
        {
            byte* native_str_id = null;
            int mouse_button = 1;
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool BeginPopupContextVoid(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int mouse_button = 1;
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool BeginPopupContextVoid(string str_id, int mouse_button)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, mouse_button);
            return ret != 0;
        }
        public static void ShowStyleEditor()
        {
            ImGuiStyle* @ref = null;
            ImGuiNative.igShowStyleEditor(@ref);
        }
        public static void ShowStyleEditor(ImGuiStylePtr @ref)
        {
            ImGuiStyle* native_ref = @ref.NativePtr;
            ImGuiNative.igShowStyleEditor(native_ref);
        }
        public static bool Checkbox(string label, ref bool v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_v_val = v ? (byte)1 : (byte)0;
            byte* native_v = &native_v_val;
            byte ret = ImGuiNative.igCheckbox(native_label, native_v);
            v = native_v_val != 0;
            return ret != 0;
        }
        public static Vector2 GetWindowPos()
        {
            Vector2 ret = ImGuiNative.igGetWindowPos();
            return ret;
        }
        public static void SetNextWindowContentSize(Vector2 size)
        {
            ImGuiNative.igSetNextWindowContentSize(size);
        }
        public static void TextColored(Vector4 col, string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igTextColored(col, native_fmt);
        }
        public static void LogToFile()
        {
            int max_depth = -1;
            byte* native_filename = null;
            ImGuiNative.igLogToFile(max_depth, native_filename);
        }
        public static void LogToFile(int max_depth)
        {
            byte* native_filename = null;
            ImGuiNative.igLogToFile(max_depth, native_filename);
        }
        public static void LogToFile(int max_depth, string filename)
        {
            int filename_byteCount = Encoding.UTF8.GetByteCount(filename);
            byte* native_filename = stackalloc byte[filename_byteCount + 1];
            fixed (char* filename_ptr = filename)
            {
                int native_filename_offset = Encoding.UTF8.GetBytes(filename_ptr, filename.Length, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            ImGuiNative.igLogToFile(max_depth, native_filename);
        }
        public static bool Button(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igButton(native_label, size);
            return ret != 0;
        }
        public static bool Button(string label, Vector2 size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igButton(native_label, size);
            return ret != 0;
        }
        public static bool IsItemEdited()
        {
            byte ret = ImGuiNative.igIsItemEdited();
            return ret != 0;
        }
        public static void TreeAdvanceToLabelPos()
        {
            ImGuiNative.igTreeAdvanceToLabelPos();
        }
        public static bool DragInt2(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt2(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt2(string label, int* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt2(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt2(string label, int* v, float v_speed, int v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt2(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt2(string label, int* v, float v_speed, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt2(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt2(string label, int* v, float v_speed, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt2(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool IsAnyItemActive()
        {
            byte ret = ImGuiNative.igIsAnyItemActive();
            return ret != 0;
        }
        public static bool MenuItem(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_shortcut = null;
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItemBool(native_label, native_shortcut, selected, enabled);
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
            byte* native_shortcut = stackalloc byte[shortcut_byteCount + 1];
            fixed (char* shortcut_ptr = shortcut)
            {
                int native_shortcut_offset = Encoding.UTF8.GetBytes(shortcut_ptr, shortcut.Length, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItemBool(native_label, native_shortcut, selected, enabled);
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, bool selected)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
            byte* native_shortcut = stackalloc byte[shortcut_byteCount + 1];
            fixed (char* shortcut_ptr = shortcut)
            {
                int native_shortcut_offset = Encoding.UTF8.GetBytes(shortcut_ptr, shortcut.Length, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItemBool(native_label, native_shortcut, native_selected, enabled);
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
            byte* native_shortcut = stackalloc byte[shortcut_byteCount + 1];
            fixed (char* shortcut_ptr = shortcut)
            {
                int native_shortcut_offset = Encoding.UTF8.GetBytes(shortcut_ptr, shortcut.Length, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igMenuItemBool(native_label, native_shortcut, native_selected, native_enabled);
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, ref bool p_selected)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
            byte* native_shortcut = stackalloc byte[shortcut_byteCount + 1];
            fixed (char* shortcut_ptr = shortcut)
            {
                int native_shortcut_offset = Encoding.UTF8.GetBytes(shortcut_ptr, shortcut.Length, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItemBoolPtr(native_label, native_shortcut, native_p_selected, enabled);
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
            byte* native_shortcut = stackalloc byte[shortcut_byteCount + 1];
            fixed (char* shortcut_ptr = shortcut)
            {
                int native_shortcut_offset = Encoding.UTF8.GetBytes(shortcut_ptr, shortcut.Length, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igMenuItemBoolPtr(native_label, native_shortcut, native_p_selected, native_enabled);
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool SliderFloat4(string label, float* v, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat4(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat4(string label, float* v, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat4(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat4(string label, float* v, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderFloat4(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static float GetCursorPosX()
        {
            float ret = ImGuiNative.igGetCursorPosX();
            return ret;
        }
        public static int GetColumnsCount()
        {
            int ret = ImGuiNative.igGetColumnsCount();
            return ret;
        }
        public static void PopButtonRepeat()
        {
            ImGuiNative.igPopButtonRepeat();
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, void* v, int components, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* v_min = null;
            void* v_max = null;
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, v, components, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, void* v, int components, float v_speed, void* v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* v_max = null;
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, v, components, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, void* v, int components, float v_speed, void* v_min, void* v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, v, components, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, void* v, int components, float v_speed, void* v_min, void* v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, v, components, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, void* v, int components, float v_speed, void* v_min, void* v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, v, components, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static void Spacing()
        {
            ImGuiNative.igSpacing();
        }
        public static bool IsAnyItemFocused()
        {
            byte ret = ImGuiNative.igIsAnyItemFocused();
            return ret != 0;
        }
        public static void MemFree(void* ptr)
        {
            ImGuiNative.igMemFree(ptr);
        }
        public static Vector2 GetFontTexUvWhitePixel()
        {
            Vector2 ret = ImGuiNative.igGetFontTexUvWhitePixel();
            return ret;
        }
        public static bool IsItemClicked()
        {
            int mouse_button = 0;
            byte ret = ImGuiNative.igIsItemClicked(mouse_button);
            return ret != 0;
        }
        public static bool IsItemClicked(int mouse_button)
        {
            byte ret = ImGuiNative.igIsItemClicked(mouse_button);
            return ret != 0;
        }
        public static void ProgressBar(float fraction)
        {
            Vector2 size_arg = new Vector2(-1, 0);
            byte* native_overlay = null;
            ImGuiNative.igProgressBar(fraction, size_arg, native_overlay);
        }
        public static void ProgressBar(float fraction, Vector2 size_arg)
        {
            byte* native_overlay = null;
            ImGuiNative.igProgressBar(fraction, size_arg, native_overlay);
        }
        public static void ProgressBar(float fraction, Vector2 size_arg, string overlay)
        {
            int overlay_byteCount = Encoding.UTF8.GetByteCount(overlay);
            byte* native_overlay = stackalloc byte[overlay_byteCount + 1];
            fixed (char* overlay_ptr = overlay)
            {
                int native_overlay_offset = Encoding.UTF8.GetBytes(overlay_ptr, overlay.Length, native_overlay, overlay_byteCount);
                native_overlay[native_overlay_offset] = 0;
            }
            ImGuiNative.igProgressBar(fraction, size_arg, native_overlay);
        }
        public static void SetNextWindowBgAlpha(float alpha)
        {
            ImGuiNative.igSetNextWindowBgAlpha(alpha);
        }
        public static bool BeginPopup(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginPopup(native_str_id, flags);
            return ret != 0;
        }
        public static bool BeginPopup(string str_id, ImGuiWindowFlags flags)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igBeginPopup(native_str_id, flags);
            return ret != 0;
        }
        public static float GetScrollX()
        {
            float ret = ImGuiNative.igGetScrollX();
            return ret;
        }
        public static int GetKeyIndex(ImGuiKey imgui_key)
        {
            int ret = ImGuiNative.igGetKeyIndex(imgui_key);
            return ret;
        }
        public static ImDrawListPtr GetOverlayDrawList()
        {
            ImDrawList* ret = ImGuiNative.igGetOverlayDrawList();
            return new ImDrawListPtr(ret);
        }
        public static uint GetID(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            uint ret = ImGuiNative.igGetIDStr(native_str_id);
            return ret;
        }
        public static uint GetID(string str_id_begin, string str_id_end)
        {
            int str_id_begin_byteCount = Encoding.UTF8.GetByteCount(str_id_begin);
            byte* native_str_id_begin = stackalloc byte[str_id_begin_byteCount + 1];
            fixed (char* str_id_begin_ptr = str_id_begin)
            {
                int native_str_id_begin_offset = Encoding.UTF8.GetBytes(str_id_begin_ptr, str_id_begin.Length, native_str_id_begin, str_id_begin_byteCount);
                native_str_id_begin[native_str_id_begin_offset] = 0;
            }
            int str_id_end_byteCount = Encoding.UTF8.GetByteCount(str_id_end);
            byte* native_str_id_end = stackalloc byte[str_id_end_byteCount + 1];
            fixed (char* str_id_end_ptr = str_id_end)
            {
                int native_str_id_end_offset = Encoding.UTF8.GetBytes(str_id_end_ptr, str_id_end.Length, native_str_id_end, str_id_end_byteCount);
                native_str_id_end[native_str_id_end_offset] = 0;
            }
            uint ret = ImGuiNative.igGetIDStrStr(native_str_id_begin, native_str_id_end);
            return ret;
        }
        public static uint GetID(void* ptr_id)
        {
            uint ret = ImGuiNative.igGetIDPtr(ptr_id);
            return ret;
        }
        public static bool ListBoxHeader(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igListBoxHeaderVec2(native_label, size);
            return ret != 0;
        }
        public static bool ListBoxHeader(string label, Vector2 size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igListBoxHeaderVec2(native_label, size);
            return ret != 0;
        }
        public static bool ListBoxHeader(string label, int items_count)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int height_in_items = -1;
            byte ret = ImGuiNative.igListBoxHeaderInt(native_label, items_count, height_in_items);
            return ret != 0;
        }
        public static bool ListBoxHeader(string label, int items_count, int height_in_items)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igListBoxHeaderInt(native_label, items_count, height_in_items);
            return ret != 0;
        }
        public static bool IsMouseReleased(int button)
        {
            byte ret = ImGuiNative.igIsMouseReleased(button);
            return ret != 0;
        }
        public static Vector2 GetItemRectMin()
        {
            Vector2 ret = ImGuiNative.igGetItemRectMin();
            return ret;
        }
        public static void LogText(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igLogText(native_fmt);
        }
        public static void TextWrapped(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igTextWrapped(native_fmt);
        }
        public static void EndGroup()
        {
            ImGuiNative.igEndGroup();
        }
        public static ImFontPtr GetFont()
        {
            ImFont* ret = ImGuiNative.igGetFont();
            return new ImFontPtr(ret);
        }
        public static void TreePush(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            ImGuiNative.igTreePushStr(native_str_id);
        }
        public static void TreePush()
        {
            void* ptr_id = null;
            ImGuiNative.igTreePushPtr(ptr_id);
        }
        public static void TreePush(void* ptr_id)
        {
            ImGuiNative.igTreePushPtr(ptr_id);
        }
        public static void TextDisabled(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igTextDisabled(native_fmt);
        }
        public static void SetNextTreeNodeOpen(bool is_open)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiCond cond = 0;
            ImGuiNative.igSetNextTreeNodeOpen(native_is_open, cond);
        }
        public static void SetNextTreeNodeOpen(bool is_open, ImGuiCond cond)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiNative.igSetNextTreeNodeOpen(native_is_open, cond);
        }
        public static void LogToTTY()
        {
            int max_depth = -1;
            ImGuiNative.igLogToTTY(max_depth);
        }
        public static void LogToTTY(int max_depth)
        {
            ImGuiNative.igLogToTTY(max_depth);
        }
        public static ImGuiIOPtr GetIO()
        {
            ImGuiIO* ret = ImGuiNative.igGetIO();
            return new ImGuiIOPtr(ret);
        }
        public static bool DragInt4(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt4(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt4(string label, int* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt4(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt4(string label, int* v, float v_speed, int v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt4(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt4(string label, int* v, float v_speed, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt4(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt4(string label, int* v, float v_speed, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt4(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static void NextColumn()
        {
            ImGuiNative.igNextColumn();
        }
        public static void SetCursorPos(Vector2 local_pos)
        {
            ImGuiNative.igSetCursorPos(local_pos);
        }
        public static bool BeginPopupModal(string name)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte* p_open = null;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, p_open, flags);
            return ret != 0;
        }
        public static bool BeginPopupModal(string name, ref bool p_open)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginPopupModal(string name, ref bool p_open, ImGuiWindowFlags flags)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool SliderInt4(string label, int* v, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt4(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool SliderInt4(string label, int* v, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt4(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static void ShowMetricsWindow()
        {
            byte* p_open = null;
            ImGuiNative.igShowMetricsWindow(p_open);
        }
        public static void ShowMetricsWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.igShowMetricsWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static float GetScrollMaxY()
        {
            float ret = ImGuiNative.igGetScrollMaxY();
            return ret;
        }
        public static void BeginTooltip()
        {
            ImGuiNative.igBeginTooltip();
        }
        public static void SetScrollX(float scroll_x)
        {
            ImGuiNative.igSetScrollX(scroll_x);
        }
        public static ImDrawDataPtr GetDrawData()
        {
            ImDrawData* ret = ImGuiNative.igGetDrawData();
            return new ImDrawDataPtr(ret);
        }
        public static float GetTextLineHeight()
        {
            float ret = ImGuiNative.igGetTextLineHeight();
            return ret;
        }
        public static void Separator()
        {
            ImGuiNative.igSeparator();
        }
        public static bool BeginChild(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChild(native_str_id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte border = 0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChild(native_str_id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size, bool border)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChild(native_str_id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size, bool border, ImGuiWindowFlags flags)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginChild(native_str_id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id)
        {
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChildID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size)
        {
            byte border = 0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChildID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChildID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border, ImGuiWindowFlags flags)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginChildID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool IsMouseClicked(int button)
        {
            byte repeat = 0;
            byte ret = ImGuiNative.igIsMouseClicked(button, repeat);
            return ret != 0;
        }
        public static bool IsMouseClicked(int button, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsMouseClicked(button, native_repeat);
            return ret != 0;
        }
        public static float CalcItemWidth()
        {
            float ret = ImGuiNative.igCalcItemWidth();
            return ret;
        }
        public static void EndChildFrame()
        {
            ImGuiNative.igEndChildFrame();
        }
        public static void Indent()
        {
            float indent_w = 0.0f;
            ImGuiNative.igIndent(indent_w);
        }
        public static void Indent(float indent_w)
        {
            ImGuiNative.igIndent(indent_w);
        }
        public static bool SetDragDropPayload(string type, void* data, uint size)
        {
            int type_byteCount = Encoding.UTF8.GetByteCount(type);
            byte* native_type = stackalloc byte[type_byteCount + 1];
            fixed (char* type_ptr = type)
            {
                int native_type_offset = Encoding.UTF8.GetBytes(type_ptr, type.Length, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            ImGuiCond cond = 0;
            byte ret = ImGuiNative.igSetDragDropPayload(native_type, data, size, cond);
            return ret != 0;
        }
        public static bool SetDragDropPayload(string type, void* data, uint size, ImGuiCond cond)
        {
            int type_byteCount = Encoding.UTF8.GetByteCount(type);
            byte* native_type = stackalloc byte[type_byteCount + 1];
            fixed (char* type_ptr = type)
            {
                int native_type_offset = Encoding.UTF8.GetBytes(type_ptr, type.Length, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            byte ret = ImGuiNative.igSetDragDropPayload(native_type, data, size, cond);
            return ret != 0;
        }
        public static void ShowDemoWindow()
        {
            byte* p_open = null;
            ImGuiNative.igShowDemoWindow(p_open);
        }
        public static void ShowDemoWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.igShowDemoWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void EndMenu()
        {
            ImGuiNative.igEndMenu();
        }
        public static bool ColorButton(string desc_id, Vector4 col)
        {
            int desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
            byte* native_desc_id = stackalloc byte[desc_id_byteCount + 1];
            fixed (char* desc_id_ptr = desc_id)
            {
                int native_desc_id_offset = Encoding.UTF8.GetBytes(desc_id_ptr, desc_id.Length, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            ImGuiColorEditFlags flags = 0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            return ret != 0;
        }
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags)
        {
            int desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
            byte* native_desc_id = stackalloc byte[desc_id_byteCount + 1];
            fixed (char* desc_id_ptr = desc_id)
            {
                int native_desc_id_offset = Encoding.UTF8.GetBytes(desc_id_ptr, desc_id.Length, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            return ret != 0;
        }
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
        {
            int desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
            byte* native_desc_id = stackalloc byte[desc_id_byteCount + 1];
            fixed (char* desc_id_ptr = desc_id)
            {
                int native_desc_id_offset = Encoding.UTF8.GetBytes(desc_id_ptr, desc_id.Length, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            return ret != 0;
        }
        public static bool IsKeyReleased(int user_key_index)
        {
            byte ret = ImGuiNative.igIsKeyReleased(user_key_index);
            return ret != 0;
        }
        public static void SetClipboardText(string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            ImGuiNative.igSetClipboardText(native_text);
        }
        public static bool IsWindowCollapsed()
        {
            byte ret = ImGuiNative.igIsWindowCollapsed();
            return ret != 0;
        }
        public static void ShowFontSelector(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiNative.igShowFontSelector(native_label);
        }
        public static void SetNextWindowFocus()
        {
            ImGuiNative.igSetNextWindowFocus();
        }
        public static void SameLine()
        {
            float pos_x = 0.0f;
            float spacing_w = -1.0f;
            ImGuiNative.igSameLine(pos_x, spacing_w);
        }
        public static void SameLine(float pos_x)
        {
            float spacing_w = -1.0f;
            ImGuiNative.igSameLine(pos_x, spacing_w);
        }
        public static void SameLine(float pos_x, float spacing_w)
        {
            ImGuiNative.igSameLine(pos_x, spacing_w);
        }
        public static bool Begin(string name)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte* p_open = null;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBegin(native_name, p_open, flags);
            return ret != 0;
        }
        public static bool Begin(string name, ref bool p_open)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBegin(native_name, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool Begin(string name, ref bool p_open, ImGuiWindowFlags flags)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igBegin(native_name, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool ColorEdit3(string label, float* col)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiColorEditFlags flags = 0;
            byte ret = ImGuiNative.igColorEdit3(native_label, col, flags);
            return ret != 0;
        }
        public static bool ColorEdit3(string label, float* col, ImGuiColorEditFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igColorEdit3(native_label, col, flags);
            return ret != 0;
        }
        public static bool InputFloat2(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat2(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat2(string label, float* v, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat2(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat2(string label, float* v, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputFloat2(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static void PushButtonRepeat(bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            ImGuiNative.igPushButtonRepeat(native_repeat);
        }
        public static void PopItemWidth()
        {
            ImGuiNative.igPopItemWidth();
        }
        public static float GetFontSize()
        {
            float ret = ImGuiNative.igGetFontSize();
            return ret;
        }
        public static bool InputDouble(string label, ref double v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            double native_v_val = v;
            double* native_v = &native_v_val;
            double step = 0.0f;
            double step_fast = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.6f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.6f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputDouble(string label, ref double v, double step)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            double native_v_val = v;
            double* native_v = &native_v_val;
            double step_fast = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.6f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.6f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            double native_v_val = v;
            double* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.6f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.6f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            double native_v_val = v;
            double* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            double native_v_val = v;
            double* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static void EndPopup()
        {
            ImGuiNative.igEndPopup();
        }
        public static bool InputTextMultiline(string label, string buf, uint buf_size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            Vector2 size = new Vector2();
            ImGuiInputTextFlags flags = 0;
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextMultiline(native_label, native_buf, buf_size, size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputTextMultiline(string label, string buf, uint buf_size, Vector2 size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            ImGuiInputTextFlags flags = 0;
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextMultiline(native_label, native_buf, buf_size, size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputTextMultiline(string label, string buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextMultiline(native_label, native_buf, buf_size, size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputTextMultiline(string label, string buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextMultiline(native_label, native_buf, buf_size, size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputTextMultiline(string label, string buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            byte ret = ImGuiNative.igInputTextMultiline(native_label, native_buf, buf_size, size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool Selectable(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte selected = 0;
            ImGuiSelectableFlags flags = 0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable(native_label, selected, flags, size);
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_selected = selected ? (byte)1 : (byte)0;
            ImGuiSelectableFlags flags = 0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable(native_label, native_selected, flags, size);
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_selected = selected ? (byte)1 : (byte)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable(native_label, native_selected, flags, size);
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igSelectable(native_label, native_selected, flags, size);
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            ImGuiSelectableFlags flags = 0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectableBoolPtr(native_label, native_p_selected, flags, size);
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectableBoolPtr(native_label, native_p_selected, flags, size);
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte ret = ImGuiNative.igSelectableBoolPtr(native_label, native_p_selected, flags, size);
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    offset += 1;
                    native_items_data[offset] = 0;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            int height_in_items = -1;
            byte ret = ImGuiNative.igListBoxStr_arr(native_label, native_current_item, native_items, items_count, height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count, int height_in_items)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_current_item_val = current_item;
            int* native_current_item = &native_current_item_val;
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    offset += 1;
                    native_items_data[offset] = 0;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            byte ret = ImGuiNative.igListBoxStr_arr(native_label, native_current_item, native_items, items_count, height_in_items);
            current_item = native_current_item_val;
            return ret != 0;
        }
        public static Vector2 GetCursorPos()
        {
            Vector2 ret = ImGuiNative.igGetCursorPos();
            return ret;
        }
        public static bool InputFloat4(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat4(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat4(string label, float* v, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat4(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat4(string label, float* v, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputFloat4(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static void SetCursorPosY(float y)
        {
            ImGuiNative.igSetCursorPosY(y);
        }
        public static byte* GetVersion()
        {
            byte* ret = ImGuiNative.igGetVersion();
            return ret;
        }
        public static void EndCombo()
        {
            ImGuiNative.igEndCombo();
        }
        public static void PushID(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            ImGuiNative.igPushIDStr(native_str_id);
        }
        public static void PushID(string str_id_begin, string str_id_end)
        {
            int str_id_begin_byteCount = Encoding.UTF8.GetByteCount(str_id_begin);
            byte* native_str_id_begin = stackalloc byte[str_id_begin_byteCount + 1];
            fixed (char* str_id_begin_ptr = str_id_begin)
            {
                int native_str_id_begin_offset = Encoding.UTF8.GetBytes(str_id_begin_ptr, str_id_begin.Length, native_str_id_begin, str_id_begin_byteCount);
                native_str_id_begin[native_str_id_begin_offset] = 0;
            }
            int str_id_end_byteCount = Encoding.UTF8.GetByteCount(str_id_end);
            byte* native_str_id_end = stackalloc byte[str_id_end_byteCount + 1];
            fixed (char* str_id_end_ptr = str_id_end)
            {
                int native_str_id_end_offset = Encoding.UTF8.GetBytes(str_id_end_ptr, str_id_end.Length, native_str_id_end, str_id_end_byteCount);
                native_str_id_end[native_str_id_end_offset] = 0;
            }
            ImGuiNative.igPushIDRange(native_str_id_begin, native_str_id_end);
        }
        public static void PushID(void* ptr_id)
        {
            ImGuiNative.igPushIDPtr(ptr_id);
        }
        public static void PushID(int int_id)
        {
            ImGuiNative.igPushIDInt(int_id);
        }
        public static void AlignTextToFramePadding()
        {
            ImGuiNative.igAlignTextToFramePadding();
        }
        public static void PopStyleColor()
        {
            int count = 1;
            ImGuiNative.igPopStyleColor(count);
        }
        public static void PopStyleColor(int count)
        {
            ImGuiNative.igPopStyleColor(count);
        }
        public static void Text(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igText(native_fmt);
        }
        public static float GetTextLineHeightWithSpacing()
        {
            float ret = ImGuiNative.igGetTextLineHeightWithSpacing();
            return ret;
        }
        public static void EndTooltip()
        {
            ImGuiNative.igEndTooltip();
        }
        public static bool DragInt(string label, ref int v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragInt(string label, ref int v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static uint ColorConvertFloat4ToU32(Vector4 @in)
        {
            uint ret = ImGuiNative.igColorConvertFloat4ToU32(@in);
            return ret;
        }
        public static void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.igPushClipRect(clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public static void SetColumnWidth(int column_index, float width)
        {
            ImGuiNative.igSetColumnWidth(column_index, width);
        }
        public static bool BeginMainMenuBar()
        {
            byte ret = ImGuiNative.igBeginMainMenuBar();
            return ret != 0;
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, void* v, void* v_min, void* v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, void* v, void* v_min, void* v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, void* v, void* v_min, void* v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static void StyleColorsLight()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.igStyleColorsLight(dst);
        }
        public static void StyleColorsLight(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.igStyleColorsLight(native_dst);
        }
        public static bool SliderFloat3(string label, float* v, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat3(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat3(string label, float* v, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderFloat3(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderFloat3(string label, float* v, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderFloat3(native_label, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static float GetWindowHeight()
        {
            float ret = ImGuiNative.igGetWindowHeight();
            return ret;
        }
        public static Vector2 GetMousePosOnOpeningCurrentPopup()
        {
            Vector2 ret = ImGuiNative.igGetMousePosOnOpeningCurrentPopup();
            return ret;
        }
        public static void CalcListClipping(int items_count, float items_height, out int out_items_display_start, out int out_items_display_end)
        {
            int native_out_items_display_start_val;
            int* native_out_items_display_start = &native_out_items_display_start_val;
            int native_out_items_display_end_val;
            int* native_out_items_display_end = &native_out_items_display_end_val;
            ImGuiNative.igCalcListClipping(items_count, items_height, native_out_items_display_start, native_out_items_display_end);
            out_items_display_start = native_out_items_display_start_val;
            out_items_display_end = native_out_items_display_end_val;
        }
        public static void EndDragDropSource()
        {
            ImGuiNative.igEndDragDropSource();
        }
        public static float GetFrameHeightWithSpacing()
        {
            float ret = ImGuiNative.igGetFrameHeightWithSpacing();
            return ret;
        }
        public static void CloseCurrentPopup()
        {
            ImGuiNative.igCloseCurrentPopup();
        }
        public static void BeginGroup()
        {
            ImGuiNative.igBeginGroup();
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, void* v, void* v_min, void* v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, void* v, void* v_min, void* v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, void* v, void* v_min, void* v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, v, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool BeginCombo(string label, string preview_value)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
            byte* native_preview_value = stackalloc byte[preview_value_byteCount + 1];
            fixed (char* preview_value_ptr = preview_value)
            {
                int native_preview_value_offset = Encoding.UTF8.GetBytes(preview_value_ptr, preview_value.Length, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            ImGuiComboFlags flags = 0;
            byte ret = ImGuiNative.igBeginCombo(native_label, native_preview_value, flags);
            return ret != 0;
        }
        public static bool BeginCombo(string label, string preview_value, ImGuiComboFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
            byte* native_preview_value = stackalloc byte[preview_value_byteCount + 1];
            fixed (char* preview_value_ptr = preview_value)
            {
                int native_preview_value_offset = Encoding.UTF8.GetBytes(preview_value_ptr, preview_value.Length, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            byte ret = ImGuiNative.igBeginCombo(native_label, native_preview_value, flags);
            return ret != 0;
        }
        public static bool BeginMenu(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte enabled = 1;
            byte ret = ImGuiNative.igBeginMenu(native_label, enabled);
            return ret != 0;
        }
        public static bool BeginMenu(string label, bool enabled)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginMenu(native_label, native_enabled);
            return ret != 0;
        }
        public static bool IsItemHovered()
        {
            ImGuiHoveredFlags flags = 0;
            byte ret = ImGuiNative.igIsItemHovered(flags);
            return ret != 0;
        }
        public static bool IsItemHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.igIsItemHovered(flags);
            return ret != 0;
        }
        public static void Bullet()
        {
            ImGuiNative.igBullet();
        }
        public static bool InputText(string label, string buf, uint buf_size)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            ImGuiInputTextFlags flags = 0;
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputText(native_label, native_buf, buf_size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputText(string label, string buf, uint buf_size, ImGuiInputTextFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputText(native_label, native_buf, buf_size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputText(string label, string buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            void* user_data = null;
            byte ret = ImGuiNative.igInputText(native_label, native_buf, buf_size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputText(string label, string buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int buf_byteCount = Encoding.UTF8.GetByteCount(buf);
            byte* native_buf = stackalloc byte[buf_byteCount + 1];
            fixed (char* buf_ptr = buf)
            {
                int native_buf_offset = Encoding.UTF8.GetBytes(buf_ptr, buf.Length, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            byte ret = ImGuiNative.igInputText(native_label, native_buf, buf_size, flags, callback, user_data);
            return ret != 0;
        }
        public static bool InputInt3(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt3(native_label, v, extra_flags);
            return ret != 0;
        }
        public static bool InputInt3(string label, int* v, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igInputInt3(native_label, v, extra_flags);
            return ret != 0;
        }
        public static void StyleColorsDark()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.igStyleColorsDark(dst);
        }
        public static void StyleColorsDark(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.igStyleColorsDark(native_dst);
        }
        public static bool InputInt(string label, ref int v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int step = 1;
            int step_fast = 100;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputInt(string label, ref int v, int step)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int step_fast = 100;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputInt(string label, ref int v, int step, int step_fast)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static bool InputInt(string label, ref int v, int step, int step_fast, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, extra_flags);
            v = native_v_val;
            return ret != 0;
        }
        public static void SetWindowFontScale(float scale)
        {
            ImGuiNative.igSetWindowFontScale(scale);
        }
        public static bool SliderInt(string label, ref int v, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt(native_label, native_v, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt(native_label, native_v, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static void SetNextWindowPos(Vector2 pos)
        {
            ImGuiCond cond = 0;
            Vector2 pivot = new Vector2();
            ImGuiNative.igSetNextWindowPos(pos, cond, pivot);
        }
        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond)
        {
            Vector2 pivot = new Vector2();
            ImGuiNative.igSetNextWindowPos(pos, cond, pivot);
        }
        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
        {
            ImGuiNative.igSetNextWindowPos(pos, cond, pivot);
        }
        public static bool DragInt3(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt3(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt3(string label, int* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_min = 0;
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt3(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt3(string label, int* v, float v_speed, int v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int v_max = 0;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt3(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt3(string label, int* v, float v_speed, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt3(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool DragInt3(string label, int* v, float v_speed, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragInt3(native_label, v, v_speed, v_min, v_max, native_format);
            return ret != 0;
        }
        public static void OpenPopup(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            ImGuiNative.igOpenPopup(native_str_id);
        }
        public static Vector2 CalcTextSize(string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            byte hide_text_after_double_hash = 0;
            float wrap_width = -1.0f;
            Vector2 ret = ImGuiNative.igCalcTextSize(native_text, native_text_end, hide_text_after_double_hash, wrap_width);
            return ret;
        }
        public static Vector2 CalcTextSize(string text, string text_end)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte hide_text_after_double_hash = 0;
            float wrap_width = -1.0f;
            Vector2 ret = ImGuiNative.igCalcTextSize(native_text, native_text_end, hide_text_after_double_hash, wrap_width);
            return ret;
        }
        public static Vector2 CalcTextSize(string text, string text_end, bool hide_text_after_double_hash)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte native_hide_text_after_double_hash = hide_text_after_double_hash ? (byte)1 : (byte)0;
            float wrap_width = -1.0f;
            Vector2 ret = ImGuiNative.igCalcTextSize(native_text, native_text_end, native_hide_text_after_double_hash, wrap_width);
            return ret;
        }
        public static Vector2 CalcTextSize(string text, string text_end, bool hide_text_after_double_hash, float wrap_width)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte native_hide_text_after_double_hash = hide_text_after_double_hash ? (byte)1 : (byte)0;
            Vector2 ret = ImGuiNative.igCalcTextSize(native_text, native_text_end, native_hide_text_after_double_hash, wrap_width);
            return ret;
        }
        public static IntPtr* GetDrawListSharedData()
        {
            IntPtr* ret = ImGuiNative.igGetDrawListSharedData();
            return ret;
        }
        public static void Columns()
        {
            int count = 1;
            byte* native_id = null;
            byte border = 1;
            ImGuiNative.igColumns(count, native_id, border);
        }
        public static void Columns(int count)
        {
            byte* native_id = null;
            byte border = 1;
            ImGuiNative.igColumns(count, native_id, border);
        }
        public static void Columns(int count, string id)
        {
            int id_byteCount = Encoding.UTF8.GetByteCount(id);
            byte* native_id = stackalloc byte[id_byteCount + 1];
            fixed (char* id_ptr = id)
            {
                int native_id_offset = Encoding.UTF8.GetBytes(id_ptr, id.Length, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            byte border = 1;
            ImGuiNative.igColumns(count, native_id, border);
        }
        public static void Columns(int count, string id, bool border)
        {
            int id_byteCount = Encoding.UTF8.GetByteCount(id);
            byte* native_id = stackalloc byte[id_byteCount + 1];
            fixed (char* id_ptr = id)
            {
                int native_id_offset = Encoding.UTF8.GetBytes(id_ptr, id.Length, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiNative.igColumns(count, native_id, native_border);
        }
        public static bool IsItemActive()
        {
            byte ret = ImGuiNative.igIsItemActive();
            return ret != 0;
        }
        public static bool BeginDragDropTarget()
        {
            byte ret = ImGuiNative.igBeginDragDropTarget();
            return ret != 0;
        }
        public static bool ColorPicker3(string label, float* col)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiColorEditFlags flags = 0;
            byte ret = ImGuiNative.igColorPicker3(native_label, col, flags);
            return ret != 0;
        }
        public static bool ColorPicker3(string label, float* col, ImGuiColorEditFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igColorPicker3(native_label, col, flags);
            return ret != 0;
        }
        public static Vector2 GetContentRegionMax()
        {
            Vector2 ret = ImGuiNative.igGetContentRegionMax();
            return ret;
        }
        public static bool BeginChildFrame(uint id, Vector2 size)
        {
            ImGuiWindowFlags flags = 0;
            byte ret = ImGuiNative.igBeginChildFrame(id, size, flags);
            return ret != 0;
        }
        public static bool BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags)
        {
            byte ret = ImGuiNative.igBeginChildFrame(id, size, flags);
            return ret != 0;
        }
        public static void SaveIniSettingsToDisk(string ini_filename)
        {
            int ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
            byte* native_ini_filename = stackalloc byte[ini_filename_byteCount + 1];
            fixed (char* ini_filename_ptr = ini_filename)
            {
                int native_ini_filename_offset = Encoding.UTF8.GetBytes(ini_filename_ptr, ini_filename.Length, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            ImGuiNative.igSaveIniSettingsToDisk(native_ini_filename);
        }
        public static byte* GetClipboardText()
        {
            byte* ret = ImGuiNative.igGetClipboardText();
            return ret;
        }
        public static void EndDragDropTarget()
        {
            ImGuiNative.igEndDragDropTarget();
        }
        public static int GetKeyPressedAmount(int key_index, float repeat_delay, float rate)
        {
            int ret = ImGuiNative.igGetKeyPressedAmount(key_index, repeat_delay, rate);
            return ret;
        }
        public static void NewFrame()
        {
            ImGuiNative.igNewFrame();
        }
        public static void ResetMouseDragDelta()
        {
            int button = 0;
            ImGuiNative.igResetMouseDragDelta(button);
        }
        public static void ResetMouseDragDelta(int button)
        {
            ImGuiNative.igResetMouseDragDelta(button);
        }
        public static float GetTreeNodeToLabelSpacing()
        {
            float ret = ImGuiNative.igGetTreeNodeToLabelSpacing();
            return ret;
        }
        public static Vector2 GetMousePos()
        {
            Vector2 ret = ImGuiNative.igGetMousePos();
            return ret;
        }
        public static void PopID()
        {
            ImGuiNative.igPopID();
        }
        public static bool IsMouseDoubleClicked(int button)
        {
            byte ret = ImGuiNative.igIsMouseDoubleClicked(button);
            return ret != 0;
        }
        public static void StyleColorsClassic()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.igStyleColorsClassic(dst);
        }
        public static void StyleColorsClassic(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.igStyleColorsClassic(native_dst);
        }
        public static void SetWindowFocus()
        {
            ImGuiNative.igSetWindowFocus();
        }
        public static void SetWindowFocus(string name)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            ImGuiNative.igSetWindowFocusStr(native_name);
        }
        public static void ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b)
        {
            ImGuiNative.igColorConvertHSVtoRGB(h, s, v, out_r, out_g, out_b);
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_val = v;
            float* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, power);
            v = native_v_val;
            return ret != 0;
        }
        public static Vector4 ColorConvertU32ToFloat4(uint @in)
        {
            Vector4 ret = ImGuiNative.igColorConvertU32ToFloat4(@in);
            return ret;
        }
        public static void PopTextWrapPos()
        {
            ImGuiNative.igPopTextWrapPos();
        }
        public static ImGuiStoragePtr GetStateStorage()
        {
            ImGuiStorage* ret = ImGuiNative.igGetStateStorage();
            return new ImGuiStoragePtr(ret);
        }
        public static float GetColumnWidth()
        {
            int column_index = -1;
            float ret = ImGuiNative.igGetColumnWidth(column_index);
            return ret;
        }
        public static float GetColumnWidth(int column_index)
        {
            float ret = ImGuiNative.igGetColumnWidth(column_index);
            return ret;
        }
        public static void EndMenuBar()
        {
            ImGuiNative.igEndMenuBar();
        }
        public static void SetStateStorage(ImGuiStoragePtr storage)
        {
            ImGuiStorage* native_storage = storage.NativePtr;
            ImGuiNative.igSetStateStorage(native_storage);
        }
        public static byte* GetStyleColorName(ImGuiCol idx)
        {
            byte* ret = ImGuiNative.igGetStyleColorName(idx);
            return ret;
        }
        public static bool IsMouseDragging()
        {
            int button = 0;
            float lock_threshold = -1.0f;
            byte ret = ImGuiNative.igIsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragging(int button)
        {
            float lock_threshold = -1.0f;
            byte ret = ImGuiNative.igIsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragging(int button, float lock_threshold)
        {
            byte ret = ImGuiNative.igIsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static void PushStyleColor(ImGuiCol idx, uint col)
        {
            ImGuiNative.igPushStyleColorU32(idx, col);
        }
        public static void PushStyleColor(ImGuiCol idx, Vector4 col)
        {
            ImGuiNative.igPushStyleColor(idx, col);
        }
        public static void* MemAlloc(uint size)
        {
            void* ret = ImGuiNative.igMemAlloc(size);
            return ret;
        }
        public static void SetCurrentContext(IntPtr ctx)
        {
            ImGuiNative.igSetCurrentContext(ctx);
        }
        public static void PushItemWidth(float item_width)
        {
            ImGuiNative.igPushItemWidth(item_width);
        }
        public static bool IsWindowAppearing()
        {
            byte ret = ImGuiNative.igIsWindowAppearing();
            return ret != 0;
        }
        public static ImGuiStylePtr GetStyle()
        {
            ImGuiStyle* ret = ImGuiNative.igGetStyle();
            return new ImGuiStylePtr(ret);
        }
        public static void SetItemAllowOverlap()
        {
            ImGuiNative.igSetItemAllowOverlap();
        }
        public static void EndChild()
        {
            ImGuiNative.igEndChild();
        }
        public static bool CollapsingHeader(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiTreeNodeFlags flags = 0;
            byte ret = ImGuiNative.igCollapsingHeader(native_label, flags);
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ImGuiTreeNodeFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igCollapsingHeader(native_label, flags);
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ref bool p_open)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiTreeNodeFlags flags = 0;
            byte ret = ImGuiNative.igCollapsingHeaderBoolPtr(native_label, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ref bool p_open, ImGuiTreeNodeFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igCollapsingHeaderBoolPtr(native_label, native_p_open, flags);
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte* native_format_max = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            int format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
            byte* native_format_max = stackalloc byte[format_max_byteCount + 1];
            fixed (char* format_max_ptr = format_max)
            {
                int native_format_max_offset = Encoding.UTF8.GetBytes(format_max_ptr, format_max.Length, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_current_min_val = v_current_min;
            float* native_v_current_min = &native_v_current_min_val;
            float native_v_current_max_val = v_current_max;
            float* native_v_current_max = &native_v_current_max_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            int format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
            byte* native_format_max = stackalloc byte[format_max_byteCount + 1];
            fixed (char* format_max_ptr = format_max)
            {
                int native_format_max_offset = Encoding.UTF8.GetBytes(format_max_ptr, format_max.Length, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, power);
            v_current_min = native_v_current_min_val;
            v_current_max = native_v_current_max_val;
            return ret != 0;
        }
        public static void SetMouseCursor(ImGuiMouseCursor type)
        {
            ImGuiNative.igSetMouseCursor(type);
        }
        public static Vector2 GetWindowContentRegionMax()
        {
            Vector2 ret = ImGuiNative.igGetWindowContentRegionMax();
            return ret;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, void* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* step = null;
            void* step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, v, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, void* v, void* step)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, v, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, void* v, void* step, void* step_fast)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, v, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, void* v, void* step, void* step_fast, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, v, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, void* v, void* step, void* step_fast, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, v, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static uint GetColorU32(ImGuiCol idx)
        {
            float alpha_mul = 1.0f;
            uint ret = ImGuiNative.igGetColorU32(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(ImGuiCol idx, float alpha_mul)
        {
            uint ret = ImGuiNative.igGetColorU32(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(Vector4 col)
        {
            uint ret = ImGuiNative.igGetColorU32Vec4(col);
            return ret;
        }
        public static uint GetColorU32(uint col)
        {
            uint ret = ImGuiNative.igGetColorU32U32(col);
            return ret;
        }
        public static double GetTime()
        {
            double ret = ImGuiNative.igGetTime();
            return ret;
        }
        public static int GetColumnIndex()
        {
            int ret = ImGuiNative.igGetColumnIndex();
            return ret;
        }
        public static bool BeginPopupContextItem()
        {
            byte* native_str_id = null;
            int mouse_button = 1;
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool BeginPopupContextItem(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int mouse_button = 1;
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, mouse_button);
            return ret != 0;
        }
        public static bool BeginPopupContextItem(string str_id, int mouse_button)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, mouse_button);
            return ret != 0;
        }
        public static void SetCursorPosX(float x)
        {
            ImGuiNative.igSetCursorPosX(x);
        }
        public static Vector2 GetItemRectSize()
        {
            Vector2 ret = ImGuiNative.igGetItemRectSize();
            return ret;
        }
        public static bool ArrowButton(string str_id, ImGuiDir dir)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igArrowButton(native_str_id, dir);
            return ret != 0;
        }
        public static ImGuiMouseCursor GetMouseCursor()
        {
            ImGuiMouseCursor ret = ImGuiNative.igGetMouseCursor();
            return ret;
        }
        public static void PushAllowKeyboardFocus(bool allow_keyboard_focus)
        {
            byte native_allow_keyboard_focus = allow_keyboard_focus ? (byte)1 : (byte)0;
            ImGuiNative.igPushAllowKeyboardFocus(native_allow_keyboard_focus);
        }
        public static float GetScrollY()
        {
            float ret = ImGuiNative.igGetScrollY();
            return ret;
        }
        public static void SetColumnOffset(int column_index, float offset_x)
        {
            ImGuiNative.igSetColumnOffset(column_index, offset_x);
        }
        public static void SetWindowPos(Vector2 pos)
        {
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowPosVec2(pos, cond);
        }
        public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
        {
            ImGuiNative.igSetWindowPosVec2(pos, cond);
        }
        public static void SetWindowPos(string name, Vector2 pos)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            ImGuiCond cond = 0;
            ImGuiNative.igSetWindowPosStr(native_name, pos, cond);
        }
        public static void SetWindowPos(string name, Vector2 pos, ImGuiCond cond)
        {
            int name_byteCount = Encoding.UTF8.GetByteCount(name);
            byte* native_name = stackalloc byte[name_byteCount + 1];
            fixed (char* name_ptr = name)
            {
                int native_name_offset = Encoding.UTF8.GetBytes(name_ptr, name.Length, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            ImGuiNative.igSetWindowPosStr(native_name, pos, cond);
        }
        public static void SetKeyboardFocusHere()
        {
            int offset = 0;
            ImGuiNative.igSetKeyboardFocusHere(offset);
        }
        public static void SetKeyboardFocusHere(int offset)
        {
            ImGuiNative.igSetKeyboardFocusHere(offset);
        }
        public static float GetCursorPosY()
        {
            float ret = ImGuiNative.igGetCursorPosY();
            return ret;
        }
        public static void EndMainMenuBar()
        {
            ImGuiNative.igEndMainMenuBar();
        }
        public static float GetContentRegionAvailWidth()
        {
            float ret = ImGuiNative.igGetContentRegionAvailWidth();
            return ret;
        }
        public static bool IsKeyDown(int user_key_index)
        {
            byte ret = ImGuiNative.igIsKeyDown(user_key_index);
            return ret != 0;
        }
        public static bool IsMouseDown(int button)
        {
            byte ret = ImGuiNative.igIsMouseDown(button);
            return ret != 0;
        }
        public static Vector2 GetWindowContentRegionMin()
        {
            Vector2 ret = ImGuiNative.igGetWindowContentRegionMin();
            return ret;
        }
        public static void LogButtons()
        {
            ImGuiNative.igLogButtons();
        }
        public static float GetWindowContentRegionWidth()
        {
            float ret = ImGuiNative.igGetWindowContentRegionWidth();
            return ret;
        }
        public static bool SliderAngle(string label, ref float v_rad)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_rad_val = v_rad;
            float* native_v_rad = &native_v_rad_val;
            float v_degrees_min = -360.0f;
            float v_degrees_max = +360.0f;
            byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max);
            v_rad = native_v_rad_val;
            return ret != 0;
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_rad_val = v_rad;
            float* native_v_rad = &native_v_rad_val;
            float v_degrees_max = +360.0f;
            byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max);
            v_rad = native_v_rad_val;
            return ret != 0;
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_v_rad_val = v_rad;
            float* native_v_rad = &native_v_rad_val;
            byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max);
            v_rad = native_v_rad_val;
            return ret != 0;
        }
        public static bool TreeNodeEx(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiTreeNodeFlags flags = 0;
            byte ret = ImGuiNative.igTreeNodeExStr(native_label, flags);
            return ret != 0;
        }
        public static bool TreeNodeEx(string label, ImGuiTreeNodeFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodeExStr(native_label, flags);
            return ret != 0;
        }
        public static bool TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodeExStrStr(native_str_id, flags, native_fmt);
            return ret != 0;
        }
        public static bool TreeNodeEx(void* ptr_id, ImGuiTreeNodeFlags flags, string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodeExPtr(ptr_id, flags, native_fmt);
            return ret != 0;
        }
        public static float GetWindowWidth()
        {
            float ret = ImGuiNative.igGetWindowWidth();
            return ret;
        }
        public static void PushTextWrapPos()
        {
            float wrap_pos_x = 0.0f;
            ImGuiNative.igPushTextWrapPos(wrap_pos_x);
        }
        public static void PushTextWrapPos(float wrap_pos_x)
        {
            ImGuiNative.igPushTextWrapPos(wrap_pos_x);
        }
        public static bool SliderInt3(string label, int* v, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt3(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static bool SliderInt3(string label, int* v, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderInt3(native_label, v, v_min, v_max, native_format);
            return ret != 0;
        }
        public static void ShowUserGuide()
        {
            ImGuiNative.igShowUserGuide();
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, void* v, int components, void* v_min, void* v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, v, components, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, void* v, int components, void* v_min, void* v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, v, components, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, void* v, int components, void* v_min, void* v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, v, components, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static void Image(IntPtr user_texture_id, Vector2 size)
        {
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.igImage(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0)
        {
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.igImage(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1)
        {
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.igImage(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col)
        {
            Vector4 border_col = new Vector4();
            ImGuiNative.igImage(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col)
        {
            ImGuiNative.igImage(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max)
        {
            ImGuiSizeCallback custom_callback = null;
            void* custom_callback_data = null;
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback)
        {
            void* custom_callback_data = null;
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data)
        {
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void Dummy(Vector2 size)
        {
            ImGuiNative.igDummy(size);
        }
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount("%d");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%d")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%d".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igVSliderInt(native_label, size, native_v, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int native_v_val = v;
            int* native_v = &native_v_val;
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igVSliderInt(native_label, size, native_v, v_min, v_max, native_format);
            v = native_v_val;
            return ret != 0;
        }
        public static void BulletText(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igBulletText(native_fmt);
        }
        public static bool ColorEdit4(string label, float* col)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiColorEditFlags flags = 0;
            byte ret = ImGuiNative.igColorEdit4(native_label, col, flags);
            return ret != 0;
        }
        public static bool ColorEdit4(string label, float* col, ImGuiColorEditFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igColorEdit4(native_label, col, flags);
            return ret != 0;
        }
        public static bool ColorPicker4(string label, float* col)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiColorEditFlags flags = 0;
            float* ref_col = null;
            byte ret = ImGuiNative.igColorPicker4(native_label, col, flags, ref_col);
            return ret != 0;
        }
        public static bool ColorPicker4(string label, float* col, ImGuiColorEditFlags flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float* ref_col = null;
            byte ret = ImGuiNative.igColorPicker4(native_label, col, flags, ref_col);
            return ret != 0;
        }
        public static bool ColorPicker4(string label, float* col, ImGuiColorEditFlags flags, ref float ref_col)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float native_ref_col_val = ref_col;
            float* native_ref_col = &native_ref_col_val;
            byte ret = ImGuiNative.igColorPicker4(native_label, col, flags, native_ref_col);
            ref_col = native_ref_col_val;
            return ret != 0;
        }
        public static bool InvisibleButton(string str_id, Vector2 size)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte ret = ImGuiNative.igInvisibleButton(native_str_id, size);
            return ret != 0;
        }
        public static void LogToClipboard()
        {
            int max_depth = -1;
            ImGuiNative.igLogToClipboard(max_depth);
        }
        public static void LogToClipboard(int max_depth)
        {
            ImGuiNative.igLogToClipboard(max_depth);
        }
        public static bool BeginPopupContextWindow()
        {
            byte* native_str_id = null;
            int mouse_button = 1;
            byte also_over_items = 1;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, mouse_button, also_over_items);
            return ret != 0;
        }
        public static bool BeginPopupContextWindow(string str_id)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int mouse_button = 1;
            byte also_over_items = 1;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, mouse_button, also_over_items);
            return ret != 0;
        }
        public static bool BeginPopupContextWindow(string str_id, int mouse_button)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte also_over_items = 1;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, mouse_button, also_over_items);
            return ret != 0;
        }
        public static bool BeginPopupContextWindow(string str_id, int mouse_button, bool also_over_items)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            byte native_also_over_items = also_over_items ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, mouse_button, native_also_over_items);
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, void* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* v_min = null;
            void* v_max = null;
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, void* v, float v_speed, void* v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* v_max = null;
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, void* v, float v_speed, void* v_min, void* v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, void* v, float v_speed, void* v_min, void* v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, void* v, float v_speed, void* v_min, void* v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static void SetItemDefaultFocus()
        {
            ImGuiNative.igSetItemDefaultFocus();
        }
        public static void CaptureMouseFromApp()
        {
            byte capture = 1;
            ImGuiNative.igCaptureMouseFromApp(capture);
        }
        public static void CaptureMouseFromApp(bool capture)
        {
            byte native_capture = capture ? (byte)1 : (byte)0;
            ImGuiNative.igCaptureMouseFromApp(native_capture);
        }
        public static bool IsAnyItemHovered()
        {
            byte ret = ImGuiNative.igIsAnyItemHovered();
            return ret != 0;
        }
        public static void PushFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNative.igPushFont(native_font);
        }
        public static bool InputInt2(string label, int* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputInt2(native_label, v, extra_flags);
            return ret != 0;
        }
        public static bool InputInt2(string label, int* v, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igInputInt2(native_label, v, extra_flags);
            return ret != 0;
        }
        public static void TreePop()
        {
            ImGuiNative.igTreePop();
        }
        public static void End()
        {
            ImGuiNative.igEnd();
        }
        public static void DestroyContext()
        {
            IntPtr ctx = IntPtr.Zero;
            ImGuiNative.igDestroyContext(ctx);
        }
        public static void DestroyContext(IntPtr ctx)
        {
            ImGuiNative.igDestroyContext(ctx);
        }
        public static void PopStyleVar()
        {
            int count = 1;
            ImGuiNative.igPopStyleVar(count);
        }
        public static void PopStyleVar(int count)
        {
            ImGuiNative.igPopStyleVar(count);
        }
        public static bool ShowStyleSelector(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igShowStyleSelector(native_label);
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, void* v, int components)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* step = null;
            void* step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, v, components, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, void* v, int components, void* step)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            void* step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, v, components, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, void* v, int components, void* step, void* step_fast)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte* native_format = null;
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, v, components, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, void* v, int components, void* step, void* step_fast, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, v, components, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, void* v, int components, void* step, void* step_fast, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, v, components, step, step_fast, native_format, extra_flags);
            return ret != 0;
        }
        public static bool TreeNode(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodeStr(native_label);
            return ret != 0;
        }
        public static bool TreeNode(string str_id, string fmt)
        {
            int str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
            byte* native_str_id = stackalloc byte[str_id_byteCount + 1];
            fixed (char* str_id_ptr = str_id)
            {
                int native_str_id_offset = Encoding.UTF8.GetBytes(str_id_ptr, str_id.Length, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodeStrStr(native_str_id, native_fmt);
            return ret != 0;
        }
        public static bool TreeNode(void* ptr_id, string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            byte ret = ImGuiNative.igTreeNodePtr(ptr_id, native_fmt);
            return ret != 0;
        }
        public static float GetScrollMaxX()
        {
            float ret = ImGuiNative.igGetScrollMaxX();
            return ret;
        }
        public static void SetTooltip(string fmt)
        {
            int fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
            byte* native_fmt = stackalloc byte[fmt_byteCount + 1];
            fixed (char* fmt_ptr = fmt)
            {
                int native_fmt_offset = Encoding.UTF8.GetBytes(fmt_ptr, fmt.Length, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            ImGuiNative.igSetTooltip(native_fmt);
        }
        public static Vector2 GetContentRegionAvail()
        {
            Vector2 ret = ImGuiNative.igGetContentRegionAvail();
            return ret;
        }
        public static bool InputFloat3(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat3(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat3(string label, float* v, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            ImGuiInputTextFlags extra_flags = 0;
            byte ret = ImGuiNative.igInputFloat3(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool InputFloat3(string label, float* v, string format, ImGuiInputTextFlags extra_flags)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igInputFloat3(native_label, v, native_format, extra_flags);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v, float v_speed)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_min = 0.0f;
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v, float v_speed, float v_min)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float v_max = 0.0f;
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v, float v_speed, float v_min, float v_max)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = "%.3f")
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, "%.3f".Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v, float v_speed, float v_min, float v_max, string format)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            float power = 1.0f;
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
        public static bool DragFloat2(string label, float* v, float v_speed, float v_min, float v_max, string format, float power)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            int format_byteCount = Encoding.UTF8.GetByteCount(format);
            byte* native_format = stackalloc byte[format_byteCount + 1];
            fixed (char* format_ptr = format)
            {
                int native_format_offset = Encoding.UTF8.GetBytes(format_ptr, format.Length, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            byte ret = ImGuiNative.igDragFloat2(native_label, v, v_speed, v_min, v_max, native_format, power);
            return ret != 0;
        }
    }
}
