using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGui
    {
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type)
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;
            ImGuiPayload* ret = ImGuiNative.igAcceptDragDropPayload(native_type, flags);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return new ImGuiPayloadPtr(ret);
        }
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type, ImGuiDragDropFlags flags)
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            ImGuiPayload* ret = ImGuiNative.igAcceptDragDropPayload(native_type, flags);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return new ImGuiPayloadPtr(ret);
        }
        public static void AlignTextToFramePadding()
        {
            ImGuiNative.igAlignTextToFramePadding();
        }
        public static bool ArrowButton(string str_id, ImGuiDir dir)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igArrowButton(native_str_id, dir);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool Begin(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte* p_open = null;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBegin(native_name, p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool Begin(string name, ref bool p_open)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBegin(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool Begin(string name, ref bool p_open, ImGuiWindowFlags flags)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igBegin(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginChild(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_Str(native_str_id, size, border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_Str(native_str_id, size, border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size, bool border)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_Str(native_str_id, size, native_border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChild(string str_id, Vector2 size, bool border, ImGuiWindowFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginChild_Str(native_str_id, size, native_border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChild(uint id)
        {
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_ID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size)
        {
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_ID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChild_ID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border, ImGuiWindowFlags flags)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginChild_ID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChildFrame(uint id, Vector2 size)
        {
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginChildFrame(id, size, flags);
            return ret != 0;
        }
        public static bool BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags)
        {
            byte ret = ImGuiNative.igBeginChildFrame(id, size, flags);
            return ret != 0;
        }
        public static bool BeginCombo(string label, string preview_value)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_preview_value;
            int preview_value_byteCount = 0;
            if (preview_value != null)
            {
                preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
                if (preview_value_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_preview_value = Util.Allocate(preview_value_byteCount + 1);
                }
                else
                {
                    byte* native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
                    native_preview_value = native_preview_value_stackBytes;
                }
                int native_preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            else { native_preview_value = null; }
            ImGuiComboFlags flags = (ImGuiComboFlags)0;
            byte ret = ImGuiNative.igBeginCombo(native_label, native_preview_value, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (preview_value_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_preview_value);
            }
            return ret != 0;
        }
        public static bool BeginCombo(string label, string preview_value, ImGuiComboFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_preview_value;
            int preview_value_byteCount = 0;
            if (preview_value != null)
            {
                preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
                if (preview_value_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_preview_value = Util.Allocate(preview_value_byteCount + 1);
                }
                else
                {
                    byte* native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
                    native_preview_value = native_preview_value_stackBytes;
                }
                int native_preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            else { native_preview_value = null; }
            byte ret = ImGuiNative.igBeginCombo(native_label, native_preview_value, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (preview_value_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_preview_value);
            }
            return ret != 0;
        }
        public static void BeginDisabled()
        {
            byte disabled = 1;
            ImGuiNative.igBeginDisabled(disabled);
        }
        public static void BeginDisabled(bool disabled)
        {
            byte native_disabled = disabled ? (byte)1 : (byte)0;
            ImGuiNative.igBeginDisabled(native_disabled);
        }
        public static bool BeginDragDropSource()
        {
            ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;
            byte ret = ImGuiNative.igBeginDragDropSource(flags);
            return ret != 0;
        }
        public static bool BeginDragDropSource(ImGuiDragDropFlags flags)
        {
            byte ret = ImGuiNative.igBeginDragDropSource(flags);
            return ret != 0;
        }
        public static bool BeginDragDropTarget()
        {
            byte ret = ImGuiNative.igBeginDragDropTarget();
            return ret != 0;
        }
        public static void BeginGroup()
        {
            ImGuiNative.igBeginGroup();
        }
        public static bool BeginListBox(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igBeginListBox(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginListBox(string label, Vector2 size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igBeginListBox(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginMainMenuBar()
        {
            byte ret = ImGuiNative.igBeginMainMenuBar();
            return ret != 0;
        }
        public static bool BeginMenu(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte enabled = 1;
            byte ret = ImGuiNative.igBeginMenu(native_label, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginMenu(string label, bool enabled)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginMenu(native_label, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginMenuBar()
        {
            byte ret = ImGuiNative.igBeginMenuBar();
            return ret != 0;
        }
        public static bool BeginPopup(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginPopup(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopup(string str_id, ImGuiWindowFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginPopup(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextItem()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, popup_flags);
            return ret != 0;
        }
        public static bool BeginPopupContextItem(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextItem(string str_id, ImGuiPopupFlags popup_flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginPopupContextItem(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextVoid()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, popup_flags);
            return ret != 0;
        }
        public static bool BeginPopupContextVoid(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextVoid(string str_id, ImGuiPopupFlags popup_flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginPopupContextVoid(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextWindow()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, popup_flags);
            return ret != 0;
        }
        public static bool BeginPopupContextWindow(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextWindow(string str_id, ImGuiPopupFlags popup_flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginPopupContextWindow(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupModal(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte* p_open = null;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginPopupModal(string name, ref bool p_open)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginPopupModal(string name, ref bool p_open, ImGuiWindowFlags flags)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igBeginPopupModal(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginTabBar(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiTabBarFlags flags = (ImGuiTabBarFlags)0;
            byte ret = ImGuiNative.igBeginTabBar(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTabBar(string str_id, ImGuiTabBarFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginTabBar(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTabItem(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* p_open = null;
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.igBeginTabItem(native_label, p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginTabItem(string label, ref bool p_open)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.igBeginTabItem(native_label, native_p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginTabItem(string label, ref bool p_open, ImGuiTabItemFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.igBeginTabItem(native_label, native_p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static bool BeginTable(string str_id, int column)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiTableFlags flags = (ImGuiTableFlags)0;
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, Vector2 outer_size)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igBeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static void BeginTooltip()
        {
            ImGuiNative.igBeginTooltip();
        }
        public static void Bullet()
        {
            ImGuiNative.igBullet();
        }
        public static void BulletText(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igBulletText(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static bool Button(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igButton(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool Button(string label, Vector2 size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igButton(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static float CalcItemWidth()
        {
            float ret = ImGuiNative.igCalcItemWidth();
            return ret;
        }
        public static void CaptureKeyboardFromApp()
        {
            byte want_capture_keyboard_value = 1;
            ImGuiNative.igCaptureKeyboardFromApp(want_capture_keyboard_value);
        }
        public static void CaptureKeyboardFromApp(bool want_capture_keyboard_value)
        {
            byte native_want_capture_keyboard_value = want_capture_keyboard_value ? (byte)1 : (byte)0;
            ImGuiNative.igCaptureKeyboardFromApp(native_want_capture_keyboard_value);
        }
        public static void CaptureMouseFromApp()
        {
            byte want_capture_mouse_value = 1;
            ImGuiNative.igCaptureMouseFromApp(want_capture_mouse_value);
        }
        public static void CaptureMouseFromApp(bool want_capture_mouse_value)
        {
            byte native_want_capture_mouse_value = want_capture_mouse_value ? (byte)1 : (byte)0;
            ImGuiNative.igCaptureMouseFromApp(native_want_capture_mouse_value);
        }
        public static bool Checkbox(string label, ref bool v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_v_val = v ? (byte)1 : (byte)0;
            byte* native_v = &native_v_val;
            byte ret = ImGuiNative.igCheckbox(native_label, native_v);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            v = native_v_val != 0;
            return ret != 0;
        }
        public static bool CheckboxFlags(string label, ref int flags, int flags_value)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_flags = &flags)
            {
                byte ret = ImGuiNative.igCheckboxFlags_IntPtr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool CheckboxFlags(string label, ref uint flags, uint flags_value)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (uint* native_flags = &flags)
            {
                byte ret = ImGuiNative.igCheckboxFlags_UintPtr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void CloseCurrentPopup()
        {
            ImGuiNative.igCloseCurrentPopup();
        }
        public static bool CollapsingHeader(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.igCollapsingHeader_TreeNodeFlags(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ImGuiTreeNodeFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igCollapsingHeader_TreeNodeFlags(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ref bool p_visible)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_visible_val = p_visible ? (byte)1 : (byte)0;
            byte* native_p_visible = &native_p_visible_val;
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.igCollapsingHeader_BoolPtr(native_label, native_p_visible, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_visible = native_p_visible_val != 0;
            return ret != 0;
        }
        public static bool CollapsingHeader(string label, ref bool p_visible, ImGuiTreeNodeFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_visible_val = p_visible ? (byte)1 : (byte)0;
            byte* native_p_visible = &native_p_visible_val;
            byte ret = ImGuiNative.igCollapsingHeader_BoolPtr(native_label, native_p_visible, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_visible = native_p_visible_val != 0;
            return ret != 0;
        }
        public static bool ColorButton(string desc_id, Vector4 col)
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags)
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            byte ret = ImGuiNative.igColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
        public static uint ColorConvertFloat4ToU32(Vector4 @in)
        {
            uint ret = ImGuiNative.igColorConvertFloat4ToU32(@in);
            return ret;
        }
        public static void ColorConvertHSVtoRGB(float h, float s, float v, out float out_r, out float out_g, out float out_b)
        {
            fixed (float* native_out_r = &out_r)
            {
                fixed (float* native_out_g = &out_g)
                {
                    fixed (float* native_out_b = &out_b)
                    {
                        ImGuiNative.igColorConvertHSVtoRGB(h, s, v, native_out_r, native_out_g, native_out_b);
                    }
                }
            }
        }
        public static void ColorConvertRGBtoHSV(float r, float g, float b, out float out_h, out float out_s, out float out_v)
        {
            fixed (float* native_out_h = &out_h)
            {
                fixed (float* native_out_s = &out_s)
                {
                    fixed (float* native_out_v = &out_v)
                    {
                        ImGuiNative.igColorConvertRGBtoHSV(r, g, b, native_out_h, native_out_s, native_out_v);
                    }
                }
            }
        }
        public static Vector4 ColorConvertU32ToFloat4(uint @in)
        {
            Vector4 __retval;
            ImGuiNative.igColorConvertU32ToFloat4(&__retval, @in);
            return __retval;
        }
        public static bool ColorEdit3(string label, ref Vector3 col)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.igColorEdit3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorEdit3(string label, ref Vector3 col, ImGuiColorEditFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.igColorEdit3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorEdit4(string label, ref Vector4 col)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.igColorEdit4(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorEdit4(string label, ref Vector4 col, ImGuiColorEditFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.igColorEdit4(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorPicker3(string label, ref Vector3 col)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.igColorPicker3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorPicker3(string label, ref Vector3 col, ImGuiColorEditFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.igColorPicker3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorPicker4(string label, ref Vector4 col)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            float* ref_col = null;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.igColorPicker4(native_label, native_col, flags, ref_col);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float* ref_col = null;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.igColorPicker4(native_label, native_col, flags, ref_col);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags, ref float ref_col)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_col = &col)
            {
                fixed (float* native_ref_col = &ref_col)
                {
                    byte ret = ImGuiNative.igColorPicker4(native_label, native_col, flags, native_ref_col);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
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
            byte* native_id;
            int id_byteCount = 0;
            if (id != null)
            {
                id_byteCount = Encoding.UTF8.GetByteCount(id);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_id = Util.Allocate(id_byteCount + 1);
                }
                else
                {
                    byte* native_id_stackBytes = stackalloc byte[id_byteCount + 1];
                    native_id = native_id_stackBytes;
                }
                int native_id_offset = Util.GetUtf8(id, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            else { native_id = null; }
            byte border = 1;
            ImGuiNative.igColumns(count, native_id, border);
            if (id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_id);
            }
        }
        public static void Columns(int count, string id, bool border)
        {
            byte* native_id;
            int id_byteCount = 0;
            if (id != null)
            {
                id_byteCount = Encoding.UTF8.GetByteCount(id);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_id = Util.Allocate(id_byteCount + 1);
                }
                else
                {
                    byte* native_id_stackBytes = stackalloc byte[id_byteCount + 1];
                    native_id = native_id_stackBytes;
                }
                int native_id_offset = Util.GetUtf8(id, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            else { native_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiNative.igColumns(count, native_id, native_border);
            if (id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_id);
            }
        }
        public static bool Combo(string label, ref int current_item, string[] items, int items_count)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
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
                    native_items_data[offset] = 0;
                    offset += 1;
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
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igCombo_Str_arr(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool Combo(string label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
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
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igCombo_Str_arr(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_items_separated_by_zeros;
            int items_separated_by_zeros_byteCount = 0;
            if (items_separated_by_zeros != null)
            {
                items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
                }
                else
                {
                    byte* native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
                    native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
                }
                int native_items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            else { native_items_separated_by_zeros = null; }
            int popup_max_height_in_items = -1;
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igCombo_Str(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_items_separated_by_zeros);
                }
                return ret != 0;
            }
        }
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros, int popup_max_height_in_items)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_items_separated_by_zeros;
            int items_separated_by_zeros_byteCount = 0;
            if (items_separated_by_zeros != null)
            {
                items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
                }
                else
                {
                    byte* native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
                    native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
                }
                int native_items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            else { native_items_separated_by_zeros = null; }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igCombo_Str(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_items_separated_by_zeros);
                }
                return ret != 0;
            }
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
        public static bool DebugCheckVersionAndDataLayout(string version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx)
        {
            byte* native_version_str;
            int version_str_byteCount = 0;
            if (version_str != null)
            {
                version_str_byteCount = Encoding.UTF8.GetByteCount(version_str);
                if (version_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_version_str = Util.Allocate(version_str_byteCount + 1);
                }
                else
                {
                    byte* native_version_str_stackBytes = stackalloc byte[version_str_byteCount + 1];
                    native_version_str = native_version_str_stackBytes;
                }
                int native_version_str_offset = Util.GetUtf8(version_str, native_version_str, version_str_byteCount);
                native_version_str[native_version_str_offset] = 0;
            }
            else { native_version_str = null; }
            byte ret = ImGuiNative.igDebugCheckVersionAndDataLayout(native_version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert, sz_drawidx);
            if (version_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_version_str);
            }
            return ret != 0;
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
        public static void DestroyPlatformWindows()
        {
            ImGuiNative.igDestroyPlatformWindows();
        }
        public static uint DockSpace(uint id)
        {
            Vector2 size = new Vector2();
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size)
        {
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags)
        {
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
        {
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            uint ret = ImGuiNative.igDockSpace(id, size, flags, native_window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport()
        {
            ImGuiViewport* viewport = null;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpaceOverViewport(viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpaceOverViewport(native_viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.igDockSpaceOverViewport(native_viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            uint ret = ImGuiNative.igDockSpaceOverViewport(native_viewport, flags, native_window_class);
            return ret;
        }
        public static bool DragFloat(string label, ref float v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat(string label, ref float v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igDragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragInt(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt(string label, ref int v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igDragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.igDragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            float v_speed = 1.0f;
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igDragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            float v_speed = 1.0f;
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igDragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static void Dummy(Vector2 size)
        {
            ImGuiNative.igDummy(size);
        }
        public static void End()
        {
            ImGuiNative.igEnd();
        }
        public static void EndChild()
        {
            ImGuiNative.igEndChild();
        }
        public static void EndChildFrame()
        {
            ImGuiNative.igEndChildFrame();
        }
        public static void EndCombo()
        {
            ImGuiNative.igEndCombo();
        }
        public static void EndDisabled()
        {
            ImGuiNative.igEndDisabled();
        }
        public static void EndDragDropSource()
        {
            ImGuiNative.igEndDragDropSource();
        }
        public static void EndDragDropTarget()
        {
            ImGuiNative.igEndDragDropTarget();
        }
        public static void EndFrame()
        {
            ImGuiNative.igEndFrame();
        }
        public static void EndGroup()
        {
            ImGuiNative.igEndGroup();
        }
        public static void EndListBox()
        {
            ImGuiNative.igEndListBox();
        }
        public static void EndMainMenuBar()
        {
            ImGuiNative.igEndMainMenuBar();
        }
        public static void EndMenu()
        {
            ImGuiNative.igEndMenu();
        }
        public static void EndMenuBar()
        {
            ImGuiNative.igEndMenuBar();
        }
        public static void EndPopup()
        {
            ImGuiNative.igEndPopup();
        }
        public static void EndTabBar()
        {
            ImGuiNative.igEndTabBar();
        }
        public static void EndTabItem()
        {
            ImGuiNative.igEndTabItem();
        }
        public static void EndTable()
        {
            ImGuiNative.igEndTable();
        }
        public static void EndTooltip()
        {
            ImGuiNative.igEndTooltip();
        }
        public static ImGuiViewportPtr FindViewportByID(uint id)
        {
            ImGuiViewport* ret = ImGuiNative.igFindViewportByID(id);
            return new ImGuiViewportPtr(ret);
        }
        public static ImGuiViewportPtr FindViewportByPlatformHandle(IntPtr platform_handle)
        {
            void* native_platform_handle = (void*)platform_handle.ToPointer();
            ImGuiViewport* ret = ImGuiNative.igFindViewportByPlatformHandle(native_platform_handle);
            return new ImGuiViewportPtr(ret);
        }
        public static void GetAllocatorFunctions(ref IntPtr p_alloc_func, ref IntPtr p_free_func, ref void* p_user_data)
        {
            fixed (IntPtr* native_p_alloc_func = &p_alloc_func)
            {
                fixed (IntPtr* native_p_free_func = &p_free_func)
                {
                    fixed (void** native_p_user_data = &p_user_data)
                    {
                        ImGuiNative.igGetAllocatorFunctions(native_p_alloc_func, native_p_free_func, native_p_user_data);
                    }
                }
            }
        }
        public static ImDrawListPtr GetBackgroundDrawList()
        {
            ImDrawList* ret = ImGuiNative.igGetBackgroundDrawList_Nil();
            return new ImDrawListPtr(ret);
        }
        public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImDrawList* ret = ImGuiNative.igGetBackgroundDrawList_ViewportPtr(native_viewport);
            return new ImDrawListPtr(ret);
        }
        public static string GetClipboardText()
        {
            byte* ret = ImGuiNative.igGetClipboardText();
            return Util.StringFromPtr(ret);
        }
        public static uint GetColorU32(ImGuiCol idx)
        {
            float alpha_mul = 1.0f;
            uint ret = ImGuiNative.igGetColorU32_Col(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(ImGuiCol idx, float alpha_mul)
        {
            uint ret = ImGuiNative.igGetColorU32_Col(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(Vector4 col)
        {
            uint ret = ImGuiNative.igGetColorU32_Vec4(col);
            return ret;
        }
        public static uint GetColorU32(uint col)
        {
            uint ret = ImGuiNative.igGetColorU32_U32(col);
            return ret;
        }
        public static int GetColumnIndex()
        {
            int ret = ImGuiNative.igGetColumnIndex();
            return ret;
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
        public static int GetColumnsCount()
        {
            int ret = ImGuiNative.igGetColumnsCount();
            return ret;
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
        public static Vector2 GetContentRegionAvail()
        {
            Vector2 __retval;
            ImGuiNative.igGetContentRegionAvail(&__retval);
            return __retval;
        }
        public static Vector2 GetContentRegionMax()
        {
            Vector2 __retval;
            ImGuiNative.igGetContentRegionMax(&__retval);
            return __retval;
        }
        public static IntPtr GetCurrentContext()
        {
            IntPtr ret = ImGuiNative.igGetCurrentContext();
            return ret;
        }
        public static Vector2 GetCursorPos()
        {
            Vector2 __retval;
            ImGuiNative.igGetCursorPos(&__retval);
            return __retval;
        }
        public static float GetCursorPosX()
        {
            float ret = ImGuiNative.igGetCursorPosX();
            return ret;
        }
        public static float GetCursorPosY()
        {
            float ret = ImGuiNative.igGetCursorPosY();
            return ret;
        }
        public static Vector2 GetCursorScreenPos()
        {
            Vector2 __retval;
            ImGuiNative.igGetCursorScreenPos(&__retval);
            return __retval;
        }
        public static Vector2 GetCursorStartPos()
        {
            Vector2 __retval;
            ImGuiNative.igGetCursorStartPos(&__retval);
            return __retval;
        }
        public static ImGuiPayloadPtr GetDragDropPayload()
        {
            ImGuiPayload* ret = ImGuiNative.igGetDragDropPayload();
            return new ImGuiPayloadPtr(ret);
        }
        public static ImDrawDataPtr GetDrawData()
        {
            ImDrawData* ret = ImGuiNative.igGetDrawData();
            return new ImDrawDataPtr(ret);
        }
        public static IntPtr GetDrawListSharedData()
        {
            IntPtr ret = ImGuiNative.igGetDrawListSharedData();
            return ret;
        }
        public static ImFontPtr GetFont()
        {
            ImFont* ret = ImGuiNative.igGetFont();
            return new ImFontPtr(ret);
        }
        public static float GetFontSize()
        {
            float ret = ImGuiNative.igGetFontSize();
            return ret;
        }
        public static Vector2 GetFontTexUvWhitePixel()
        {
            Vector2 __retval;
            ImGuiNative.igGetFontTexUvWhitePixel(&__retval);
            return __retval;
        }
        public static ImDrawListPtr GetForegroundDrawList()
        {
            ImDrawList* ret = ImGuiNative.igGetForegroundDrawList_Nil();
            return new ImDrawListPtr(ret);
        }
        public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImDrawList* ret = ImGuiNative.igGetForegroundDrawList_ViewportPtr(native_viewport);
            return new ImDrawListPtr(ret);
        }
        public static int GetFrameCount()
        {
            int ret = ImGuiNative.igGetFrameCount();
            return ret;
        }
        public static float GetFrameHeight()
        {
            float ret = ImGuiNative.igGetFrameHeight();
            return ret;
        }
        public static float GetFrameHeightWithSpacing()
        {
            float ret = ImGuiNative.igGetFrameHeightWithSpacing();
            return ret;
        }
        public static uint GetID(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            uint ret = ImGuiNative.igGetID_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret;
        }
        public static uint GetID(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            uint ret = ImGuiNative.igGetID_Ptr(native_ptr_id);
            return ret;
        }
        public static ImGuiIOPtr GetIO()
        {
            ImGuiIO* ret = ImGuiNative.igGetIO();
            return new ImGuiIOPtr(ret);
        }
        public static Vector2 GetItemRectMax()
        {
            Vector2 __retval;
            ImGuiNative.igGetItemRectMax(&__retval);
            return __retval;
        }
        public static Vector2 GetItemRectMin()
        {
            Vector2 __retval;
            ImGuiNative.igGetItemRectMin(&__retval);
            return __retval;
        }
        public static Vector2 GetItemRectSize()
        {
            Vector2 __retval;
            ImGuiNative.igGetItemRectSize(&__retval);
            return __retval;
        }
        public static int GetKeyIndex(ImGuiKey key)
        {
            int ret = ImGuiNative.igGetKeyIndex(key);
            return ret;
        }
        public static string GetKeyName(ImGuiKey key)
        {
            byte* ret = ImGuiNative.igGetKeyName(key);
            return Util.StringFromPtr(ret);
        }
        public static int GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate)
        {
            int ret = ImGuiNative.igGetKeyPressedAmount(key, repeat_delay, rate);
            return ret;
        }
        public static ImGuiViewportPtr GetMainViewport()
        {
            ImGuiViewport* ret = ImGuiNative.igGetMainViewport();
            return new ImGuiViewportPtr(ret);
        }
        public static int GetMouseClickedCount(ImGuiMouseButton button)
        {
            int ret = ImGuiNative.igGetMouseClickedCount(button);
            return ret;
        }
        public static ImGuiMouseCursor GetMouseCursor()
        {
            ImGuiMouseCursor ret = ImGuiNative.igGetMouseCursor();
            return ret;
        }
        public static Vector2 GetMouseDragDelta()
        {
            Vector2 __retval;
            ImGuiMouseButton button = (ImGuiMouseButton)0;
            float lock_threshold = -1.0f;
            ImGuiNative.igGetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMouseDragDelta(ImGuiMouseButton button)
        {
            Vector2 __retval;
            float lock_threshold = -1.0f;
            ImGuiNative.igGetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold)
        {
            Vector2 __retval;
            ImGuiNative.igGetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMousePos()
        {
            Vector2 __retval;
            ImGuiNative.igGetMousePos(&__retval);
            return __retval;
        }
        public static Vector2 GetMousePosOnOpeningCurrentPopup()
        {
            Vector2 __retval;
            ImGuiNative.igGetMousePosOnOpeningCurrentPopup(&__retval);
            return __retval;
        }
        public static ImGuiPlatformIOPtr GetPlatformIO()
        {
            ImGuiPlatformIO* ret = ImGuiNative.igGetPlatformIO();
            return new ImGuiPlatformIOPtr(ret);
        }
        public static float GetScrollMaxX()
        {
            float ret = ImGuiNative.igGetScrollMaxX();
            return ret;
        }
        public static float GetScrollMaxY()
        {
            float ret = ImGuiNative.igGetScrollMaxY();
            return ret;
        }
        public static float GetScrollX()
        {
            float ret = ImGuiNative.igGetScrollX();
            return ret;
        }
        public static float GetScrollY()
        {
            float ret = ImGuiNative.igGetScrollY();
            return ret;
        }
        public static ImGuiStoragePtr GetStateStorage()
        {
            ImGuiStorage* ret = ImGuiNative.igGetStateStorage();
            return new ImGuiStoragePtr(ret);
        }
        public static ImGuiStylePtr GetStyle()
        {
            ImGuiStyle* ret = ImGuiNative.igGetStyle();
            return new ImGuiStylePtr(ret);
        }
        public static string GetStyleColorName(ImGuiCol idx)
        {
            byte* ret = ImGuiNative.igGetStyleColorName(idx);
            return Util.StringFromPtr(ret);
        }
        public static Vector4* GetStyleColorVec4(ImGuiCol idx)
        {
            Vector4* ret = ImGuiNative.igGetStyleColorVec4(idx);
            return ret;
        }
        public static float GetTextLineHeight()
        {
            float ret = ImGuiNative.igGetTextLineHeight();
            return ret;
        }
        public static float GetTextLineHeightWithSpacing()
        {
            float ret = ImGuiNative.igGetTextLineHeightWithSpacing();
            return ret;
        }
        public static double GetTime()
        {
            double ret = ImGuiNative.igGetTime();
            return ret;
        }
        public static float GetTreeNodeToLabelSpacing()
        {
            float ret = ImGuiNative.igGetTreeNodeToLabelSpacing();
            return ret;
        }
        public static string GetVersion()
        {
            byte* ret = ImGuiNative.igGetVersion();
            return Util.StringFromPtr(ret);
        }
        public static Vector2 GetWindowContentRegionMax()
        {
            Vector2 __retval;
            ImGuiNative.igGetWindowContentRegionMax(&__retval);
            return __retval;
        }
        public static Vector2 GetWindowContentRegionMin()
        {
            Vector2 __retval;
            ImGuiNative.igGetWindowContentRegionMin(&__retval);
            return __retval;
        }
        public static uint GetWindowDockID()
        {
            uint ret = ImGuiNative.igGetWindowDockID();
            return ret;
        }
        public static float GetWindowDpiScale()
        {
            float ret = ImGuiNative.igGetWindowDpiScale();
            return ret;
        }
        public static ImDrawListPtr GetWindowDrawList()
        {
            ImDrawList* ret = ImGuiNative.igGetWindowDrawList();
            return new ImDrawListPtr(ret);
        }
        public static float GetWindowHeight()
        {
            float ret = ImGuiNative.igGetWindowHeight();
            return ret;
        }
        public static Vector2 GetWindowPos()
        {
            Vector2 __retval;
            ImGuiNative.igGetWindowPos(&__retval);
            return __retval;
        }
        public static Vector2 GetWindowSize()
        {
            Vector2 __retval;
            ImGuiNative.igGetWindowSize(&__retval);
            return __retval;
        }
        public static ImGuiViewportPtr GetWindowViewport()
        {
            ImGuiViewport* ret = ImGuiNative.igGetWindowViewport();
            return new ImGuiViewportPtr(ret);
        }
        public static float GetWindowWidth()
        {
            float ret = ImGuiNative.igGetWindowWidth();
            return ret;
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
        public static void Indent()
        {
            float indent_w = 0.0f;
            ImGuiNative.igIndent(indent_w);
        }
        public static void Indent(float indent_w)
        {
            ImGuiNative.igIndent(indent_w);
        }
        public static bool InputDouble(string label, ref double v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            double step = 0.0;
            double step_fast = 0.0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputDouble(string label, ref double v, double step)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            double step_fast = 0.0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.igInputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat(string label, ref float v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float step = 0.0f;
            float step_fast = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat(string label, ref float v, float step)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float step_fast = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat2(string label, ref Vector2 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat2(string label, ref Vector2 v, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat2(string label, ref Vector2 v, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat3(string label, ref Vector3 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat3(string label, ref Vector3 v, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat3(string label, ref Vector3 v, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat4(string label, ref Vector4 v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat4(string label, ref Vector4 v, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputFloat4(string label, ref Vector4 v, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool InputInt(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int step = 1;
            int step_fast = 100;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt(string label, ref int v, int step)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int step_fast = 100;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt(string label, ref int v, int step, int step_fast)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt(string label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt2(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt2(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt2(string label, ref int v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt2(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt3(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt3(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt3(string label, ref int v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt3(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt4(string label, ref int v)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt4(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputInt4(string label, ref int v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igInputInt4(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_step = null;
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, native_p_data, p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, native_p_data, native_p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_step = null;
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, native_p_data, components, p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, native_p_data, components, native_p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igInputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool InvisibleButton(string str_id, Vector2 size)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNative.igInvisibleButton(native_str_id, size, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool InvisibleButton(string str_id, Vector2 size, ImGuiButtonFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igInvisibleButton(native_str_id, size, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool IsAnyItemActive()
        {
            byte ret = ImGuiNative.igIsAnyItemActive();
            return ret != 0;
        }
        public static bool IsAnyItemFocused()
        {
            byte ret = ImGuiNative.igIsAnyItemFocused();
            return ret != 0;
        }
        public static bool IsAnyItemHovered()
        {
            byte ret = ImGuiNative.igIsAnyItemHovered();
            return ret != 0;
        }
        public static bool IsAnyMouseDown()
        {
            byte ret = ImGuiNative.igIsAnyMouseDown();
            return ret != 0;
        }
        public static bool IsItemActivated()
        {
            byte ret = ImGuiNative.igIsItemActivated();
            return ret != 0;
        }
        public static bool IsItemActive()
        {
            byte ret = ImGuiNative.igIsItemActive();
            return ret != 0;
        }
        public static bool IsItemClicked()
        {
            ImGuiMouseButton mouse_button = (ImGuiMouseButton)0;
            byte ret = ImGuiNative.igIsItemClicked(mouse_button);
            return ret != 0;
        }
        public static bool IsItemClicked(ImGuiMouseButton mouse_button)
        {
            byte ret = ImGuiNative.igIsItemClicked(mouse_button);
            return ret != 0;
        }
        public static bool IsItemDeactivated()
        {
            byte ret = ImGuiNative.igIsItemDeactivated();
            return ret != 0;
        }
        public static bool IsItemDeactivatedAfterEdit()
        {
            byte ret = ImGuiNative.igIsItemDeactivatedAfterEdit();
            return ret != 0;
        }
        public static bool IsItemEdited()
        {
            byte ret = ImGuiNative.igIsItemEdited();
            return ret != 0;
        }
        public static bool IsItemFocused()
        {
            byte ret = ImGuiNative.igIsItemFocused();
            return ret != 0;
        }
        public static bool IsItemHovered()
        {
            ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;
            byte ret = ImGuiNative.igIsItemHovered(flags);
            return ret != 0;
        }
        public static bool IsItemHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.igIsItemHovered(flags);
            return ret != 0;
        }
        public static bool IsItemToggledOpen()
        {
            byte ret = ImGuiNative.igIsItemToggledOpen();
            return ret != 0;
        }
        public static bool IsItemVisible()
        {
            byte ret = ImGuiNative.igIsItemVisible();
            return ret != 0;
        }
        public static bool IsKeyDown(ImGuiKey key)
        {
            byte ret = ImGuiNative.igIsKeyDown(key);
            return ret != 0;
        }
        public static bool IsKeyPressed(ImGuiKey key)
        {
            byte repeat = 1;
            byte ret = ImGuiNative.igIsKeyPressed(key, repeat);
            return ret != 0;
        }
        public static bool IsKeyPressed(ImGuiKey key, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsKeyPressed(key, native_repeat);
            return ret != 0;
        }
        public static bool IsKeyReleased(ImGuiKey key)
        {
            byte ret = ImGuiNative.igIsKeyReleased(key);
            return ret != 0;
        }
        public static bool IsMouseClicked(ImGuiMouseButton button)
        {
            byte repeat = 0;
            byte ret = ImGuiNative.igIsMouseClicked(button, repeat);
            return ret != 0;
        }
        public static bool IsMouseClicked(ImGuiMouseButton button, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsMouseClicked(button, native_repeat);
            return ret != 0;
        }
        public static bool IsMouseDoubleClicked(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.igIsMouseDoubleClicked(button);
            return ret != 0;
        }
        public static bool IsMouseDown(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.igIsMouseDown(button);
            return ret != 0;
        }
        public static bool IsMouseDragging(ImGuiMouseButton button)
        {
            float lock_threshold = -1.0f;
            byte ret = ImGuiNative.igIsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragging(ImGuiMouseButton button, float lock_threshold)
        {
            byte ret = ImGuiNative.igIsMouseDragging(button, lock_threshold);
            return ret != 0;
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
        public static bool IsMousePosValid()
        {
            Vector2* mouse_pos = null;
            byte ret = ImGuiNative.igIsMousePosValid(mouse_pos);
            return ret != 0;
        }
        public static bool IsMousePosValid(ref Vector2 mouse_pos)
        {
            fixed (Vector2* native_mouse_pos = &mouse_pos)
            {
                byte ret = ImGuiNative.igIsMousePosValid(native_mouse_pos);
                return ret != 0;
            }
        }
        public static bool IsMouseReleased(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.igIsMouseReleased(button);
            return ret != 0;
        }
        public static bool IsPopupOpen(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags flags = (ImGuiPopupFlags)0;
            byte ret = ImGuiNative.igIsPopupOpen_Str(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool IsPopupOpen(string str_id, ImGuiPopupFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.igIsPopupOpen_Str(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 size)
        {
            byte ret = ImGuiNative.igIsRectVisible_Nil(size);
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 rect_min, Vector2 rect_max)
        {
            byte ret = ImGuiNative.igIsRectVisible_Vec2(rect_min, rect_max);
            return ret != 0;
        }
        public static bool IsWindowAppearing()
        {
            byte ret = ImGuiNative.igIsWindowAppearing();
            return ret != 0;
        }
        public static bool IsWindowCollapsed()
        {
            byte ret = ImGuiNative.igIsWindowCollapsed();
            return ret != 0;
        }
        public static bool IsWindowDocked()
        {
            byte ret = ImGuiNative.igIsWindowDocked();
            return ret != 0;
        }
        public static bool IsWindowFocused()
        {
            ImGuiFocusedFlags flags = (ImGuiFocusedFlags)0;
            byte ret = ImGuiNative.igIsWindowFocused(flags);
            return ret != 0;
        }
        public static bool IsWindowFocused(ImGuiFocusedFlags flags)
        {
            byte ret = ImGuiNative.igIsWindowFocused(flags);
            return ret != 0;
        }
        public static bool IsWindowHovered()
        {
            ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;
            byte ret = ImGuiNative.igIsWindowHovered(flags);
            return ret != 0;
        }
        public static bool IsWindowHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.igIsWindowHovered(flags);
            return ret != 0;
        }
        public static void LabelText(string label, string fmt)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igLabelText(native_label, native_fmt);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
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
                    native_items_data[offset] = 0;
                    offset += 1;
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
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igListBox_Str_arr(native_label, native_current_item, native_items, items_count, height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count, int height_in_items)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
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
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.igListBox_Str_arr(native_label, native_current_item, native_items, items_count, height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void LoadIniSettingsFromDisk(string ini_filename)
        {
            byte* native_ini_filename;
            int ini_filename_byteCount = 0;
            if (ini_filename != null)
            {
                ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
                if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
                }
                else
                {
                    byte* native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
                    native_ini_filename = native_ini_filename_stackBytes;
                }
                int native_ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            else { native_ini_filename = null; }
            ImGuiNative.igLoadIniSettingsFromDisk(native_ini_filename);
            if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_filename);
            }
        }
        public static void LoadIniSettingsFromMemory(string ini_data)
        {
            byte* native_ini_data;
            int ini_data_byteCount = 0;
            if (ini_data != null)
            {
                ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
                if (ini_data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_data = Util.Allocate(ini_data_byteCount + 1);
                }
                else
                {
                    byte* native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
                    native_ini_data = native_ini_data_stackBytes;
                }
                int native_ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            else { native_ini_data = null; }
            uint ini_size = 0;
            ImGuiNative.igLoadIniSettingsFromMemory(native_ini_data, ini_size);
            if (ini_data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_data);
            }
        }
        public static void LoadIniSettingsFromMemory(string ini_data, uint ini_size)
        {
            byte* native_ini_data;
            int ini_data_byteCount = 0;
            if (ini_data != null)
            {
                ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
                if (ini_data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_data = Util.Allocate(ini_data_byteCount + 1);
                }
                else
                {
                    byte* native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
                    native_ini_data = native_ini_data_stackBytes;
                }
                int native_ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            else { native_ini_data = null; }
            ImGuiNative.igLoadIniSettingsFromMemory(native_ini_data, ini_size);
            if (ini_data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_data);
            }
        }
        public static void LogButtons()
        {
            ImGuiNative.igLogButtons();
        }
        public static void LogFinish()
        {
            ImGuiNative.igLogFinish();
        }
        public static void LogText(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igLogText(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void LogToClipboard()
        {
            int auto_open_depth = -1;
            ImGuiNative.igLogToClipboard(auto_open_depth);
        }
        public static void LogToClipboard(int auto_open_depth)
        {
            ImGuiNative.igLogToClipboard(auto_open_depth);
        }
        public static void LogToFile()
        {
            int auto_open_depth = -1;
            byte* native_filename = null;
            ImGuiNative.igLogToFile(auto_open_depth, native_filename);
        }
        public static void LogToFile(int auto_open_depth)
        {
            byte* native_filename = null;
            ImGuiNative.igLogToFile(auto_open_depth, native_filename);
        }
        public static void LogToFile(int auto_open_depth, string filename)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            ImGuiNative.igLogToFile(auto_open_depth, native_filename);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
        }
        public static void LogToTTY()
        {
            int auto_open_depth = -1;
            ImGuiNative.igLogToTTY(auto_open_depth);
        }
        public static void LogToTTY(int auto_open_depth)
        {
            ImGuiNative.igLogToTTY(auto_open_depth);
        }
        public static IntPtr MemAlloc(uint size)
        {
            void* ret = ImGuiNative.igMemAlloc(size);
            return (IntPtr)ret;
        }
        public static void MemFree(IntPtr ptr)
        {
            void* native_ptr = (void*)ptr.ToPointer();
            ImGuiNative.igMemFree(native_ptr);
        }
        public static bool MenuItem(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut = null;
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItem_Bool(native_label, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItem_Bool(native_label, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, bool selected)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItem_Bool(native_label, native_shortcut, native_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igMenuItem_Bool(native_label, native_shortcut, native_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, ref bool p_selected)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItem_BoolPtr(native_label, native_shortcut, native_p_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igMenuItem_BoolPtr(native_label, native_shortcut, native_p_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static void NewFrame()
        {
            ImGuiNative.igNewFrame();
        }
        public static void NewLine()
        {
            ImGuiNative.igNewLine();
        }
        public static void NextColumn()
        {
            ImGuiNative.igNextColumn();
        }
        public static void OpenPopup(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;
            ImGuiNative.igOpenPopup_Str(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void OpenPopup(string str_id, ImGuiPopupFlags popup_flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.igOpenPopup_Str(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void OpenPopup(uint id)
        {
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;
            ImGuiNative.igOpenPopup_ID(id, popup_flags);
        }
        public static void OpenPopup(uint id, ImGuiPopupFlags popup_flags)
        {
            ImGuiNative.igOpenPopup_ID(id, popup_flags);
        }
        public static void OpenPopupOnItemClick()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            ImGuiNative.igOpenPopupOnItemClick(native_str_id, popup_flags);
        }
        public static void OpenPopupOnItemClick(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            ImGuiNative.igOpenPopupOnItemClick(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void OpenPopupOnItemClick(string str_id, ImGuiPopupFlags popup_flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.igOpenPopupOnItemClick(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            fixed (float* native_values = &values)
            {
                ImGuiNative.igPlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PopAllowKeyboardFocus()
        {
            ImGuiNative.igPopAllowKeyboardFocus();
        }
        public static void PopButtonRepeat()
        {
            ImGuiNative.igPopButtonRepeat();
        }
        public static void PopClipRect()
        {
            ImGuiNative.igPopClipRect();
        }
        public static void PopFont()
        {
            ImGuiNative.igPopFont();
        }
        public static void PopID()
        {
            ImGuiNative.igPopID();
        }
        public static void PopItemWidth()
        {
            ImGuiNative.igPopItemWidth();
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
        public static void PopStyleVar()
        {
            int count = 1;
            ImGuiNative.igPopStyleVar(count);
        }
        public static void PopStyleVar(int count)
        {
            ImGuiNative.igPopStyleVar(count);
        }
        public static void PopTextWrapPos()
        {
            ImGuiNative.igPopTextWrapPos();
        }
        public static void ProgressBar(float fraction)
        {
            Vector2 size_arg = new Vector2(-float.MinValue, 0.0f);
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
            byte* native_overlay;
            int overlay_byteCount = 0;
            if (overlay != null)
            {
                overlay_byteCount = Encoding.UTF8.GetByteCount(overlay);
                if (overlay_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay = Util.Allocate(overlay_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_stackBytes = stackalloc byte[overlay_byteCount + 1];
                    native_overlay = native_overlay_stackBytes;
                }
                int native_overlay_offset = Util.GetUtf8(overlay, native_overlay, overlay_byteCount);
                native_overlay[native_overlay_offset] = 0;
            }
            else { native_overlay = null; }
            ImGuiNative.igProgressBar(fraction, size_arg, native_overlay);
            if (overlay_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_overlay);
            }
        }
        public static void PushAllowKeyboardFocus(bool allow_keyboard_focus)
        {
            byte native_allow_keyboard_focus = allow_keyboard_focus ? (byte)1 : (byte)0;
            ImGuiNative.igPushAllowKeyboardFocus(native_allow_keyboard_focus);
        }
        public static void PushButtonRepeat(bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            ImGuiNative.igPushButtonRepeat(native_repeat);
        }
        public static void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.igPushClipRect(clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public static void PushFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNative.igPushFont(native_font);
        }
        public static void PushID(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.igPushID_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void PushID(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            ImGuiNative.igPushID_Ptr(native_ptr_id);
        }
        public static void PushID(int int_id)
        {
            ImGuiNative.igPushID_Int(int_id);
        }
        public static void PushItemWidth(float item_width)
        {
            ImGuiNative.igPushItemWidth(item_width);
        }
        public static void PushStyleColor(ImGuiCol idx, uint col)
        {
            ImGuiNative.igPushStyleColor_U32(idx, col);
        }
        public static void PushStyleColor(ImGuiCol idx, Vector4 col)
        {
            ImGuiNative.igPushStyleColor_Vec4(idx, col);
        }
        public static void PushStyleVar(ImGuiStyleVar idx, float val)
        {
            ImGuiNative.igPushStyleVar_Float(idx, val);
        }
        public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
        {
            ImGuiNative.igPushStyleVar_Vec2(idx, val);
        }
        public static void PushTextWrapPos()
        {
            float wrap_local_pos_x = 0.0f;
            ImGuiNative.igPushTextWrapPos(wrap_local_pos_x);
        }
        public static void PushTextWrapPos(float wrap_local_pos_x)
        {
            ImGuiNative.igPushTextWrapPos(wrap_local_pos_x);
        }
        public static bool RadioButton(string label, bool active)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_active = active ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igRadioButton_Bool(native_label, native_active);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool RadioButton(string label, ref int v, int v_button)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igRadioButton_IntPtr(native_label, native_v, v_button);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void Render()
        {
            ImGuiNative.igRender();
        }
        public static void RenderPlatformWindowsDefault()
        {
            void* platform_render_arg = null;
            void* renderer_render_arg = null;
            ImGuiNative.igRenderPlatformWindowsDefault(platform_render_arg, renderer_render_arg);
        }
        public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg)
        {
            void* native_platform_render_arg = (void*)platform_render_arg.ToPointer();
            void* renderer_render_arg = null;
            ImGuiNative.igRenderPlatformWindowsDefault(native_platform_render_arg, renderer_render_arg);
        }
        public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg, IntPtr renderer_render_arg)
        {
            void* native_platform_render_arg = (void*)platform_render_arg.ToPointer();
            void* native_renderer_render_arg = (void*)renderer_render_arg.ToPointer();
            ImGuiNative.igRenderPlatformWindowsDefault(native_platform_render_arg, native_renderer_render_arg);
        }
        public static void ResetMouseDragDelta()
        {
            ImGuiMouseButton button = (ImGuiMouseButton)0;
            ImGuiNative.igResetMouseDragDelta(button);
        }
        public static void ResetMouseDragDelta(ImGuiMouseButton button)
        {
            ImGuiNative.igResetMouseDragDelta(button);
        }
        public static void SameLine()
        {
            float offset_from_start_x = 0.0f;
            float spacing = -1.0f;
            ImGuiNative.igSameLine(offset_from_start_x, spacing);
        }
        public static void SameLine(float offset_from_start_x)
        {
            float spacing = -1.0f;
            ImGuiNative.igSameLine(offset_from_start_x, spacing);
        }
        public static void SameLine(float offset_from_start_x, float spacing)
        {
            ImGuiNative.igSameLine(offset_from_start_x, spacing);
        }
        public static void SaveIniSettingsToDisk(string ini_filename)
        {
            byte* native_ini_filename;
            int ini_filename_byteCount = 0;
            if (ini_filename != null)
            {
                ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
                if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
                }
                else
                {
                    byte* native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
                    native_ini_filename = native_ini_filename_stackBytes;
                }
                int native_ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            else { native_ini_filename = null; }
            ImGuiNative.igSaveIniSettingsToDisk(native_ini_filename);
            if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_filename);
            }
        }
        public static string SaveIniSettingsToMemory()
        {
            uint* out_ini_size = null;
            byte* ret = ImGuiNative.igSaveIniSettingsToMemory(out_ini_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveIniSettingsToMemory(out uint out_ini_size)
        {
            fixed (uint* native_out_ini_size = &out_ini_size)
            {
                byte* ret = ImGuiNative.igSaveIniSettingsToMemory(native_out_ini_size);
                return Util.StringFromPtr(ret);
            }
        }
        public static bool Selectable(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte selected = 0;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable_Bool(native_label, selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igSelectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.igSelectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte ret = ImGuiNative.igSelectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static void Separator()
        {
            ImGuiNative.igSeparator();
        }
        public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func)
        {
            void* user_data = null;
            ImGuiNative.igSetAllocatorFunctions(alloc_func, free_func, user_data);
        }
        public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, IntPtr user_data)
        {
            void* native_user_data = (void*)user_data.ToPointer();
            ImGuiNative.igSetAllocatorFunctions(alloc_func, free_func, native_user_data);
        }
        public static void SetClipboardText(string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImGuiNative.igSetClipboardText(native_text);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void SetColorEditOptions(ImGuiColorEditFlags flags)
        {
            ImGuiNative.igSetColorEditOptions(flags);
        }
        public static void SetColumnOffset(int column_index, float offset_x)
        {
            ImGuiNative.igSetColumnOffset(column_index, offset_x);
        }
        public static void SetColumnWidth(int column_index, float width)
        {
            ImGuiNative.igSetColumnWidth(column_index, width);
        }
        public static void SetCurrentContext(IntPtr ctx)
        {
            ImGuiNative.igSetCurrentContext(ctx);
        }
        public static void SetCursorPos(Vector2 local_pos)
        {
            ImGuiNative.igSetCursorPos(local_pos);
        }
        public static void SetCursorPosX(float local_x)
        {
            ImGuiNative.igSetCursorPosX(local_x);
        }
        public static void SetCursorPosY(float local_y)
        {
            ImGuiNative.igSetCursorPosY(local_y);
        }
        public static void SetCursorScreenPos(Vector2 pos)
        {
            ImGuiNative.igSetCursorScreenPos(pos);
        }
        public static bool SetDragDropPayload(string type, IntPtr data, uint sz)
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            void* native_data = (void*)data.ToPointer();
            ImGuiCond cond = (ImGuiCond)0;
            byte ret = ImGuiNative.igSetDragDropPayload(native_type, native_data, sz, cond);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return ret != 0;
        }
        public static bool SetDragDropPayload(string type, IntPtr data, uint sz, ImGuiCond cond)
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            void* native_data = (void*)data.ToPointer();
            byte ret = ImGuiNative.igSetDragDropPayload(native_type, native_data, sz, cond);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return ret != 0;
        }
        public static void SetItemAllowOverlap()
        {
            ImGuiNative.igSetItemAllowOverlap();
        }
        public static void SetItemDefaultFocus()
        {
            ImGuiNative.igSetItemDefaultFocus();
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
        public static void SetMouseCursor(ImGuiMouseCursor cursor_type)
        {
            ImGuiNative.igSetMouseCursor(cursor_type);
        }
        public static void SetNextItemOpen(bool is_open)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetNextItemOpen(native_is_open, cond);
        }
        public static void SetNextItemOpen(bool is_open, ImGuiCond cond)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiNative.igSetNextItemOpen(native_is_open, cond);
        }
        public static void SetNextItemWidth(float item_width)
        {
            ImGuiNative.igSetNextItemWidth(item_width);
        }
        public static void SetNextWindowBgAlpha(float alpha)
        {
            ImGuiNative.igSetNextWindowBgAlpha(alpha);
        }
        public static void SetNextWindowClass(ImGuiWindowClassPtr window_class)
        {
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            ImGuiNative.igSetNextWindowClass(native_window_class);
        }
        public static void SetNextWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetNextWindowCollapsed(native_collapsed, cond);
        }
        public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetNextWindowCollapsed(native_collapsed, cond);
        }
        public static void SetNextWindowContentSize(Vector2 size)
        {
            ImGuiNative.igSetNextWindowContentSize(size);
        }
        public static void SetNextWindowDockID(uint dock_id)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetNextWindowDockID(dock_id, cond);
        }
        public static void SetNextWindowDockID(uint dock_id, ImGuiCond cond)
        {
            ImGuiNative.igSetNextWindowDockID(dock_id, cond);
        }
        public static void SetNextWindowFocus()
        {
            ImGuiNative.igSetNextWindowFocus();
        }
        public static void SetNextWindowPos(Vector2 pos)
        {
            ImGuiCond cond = (ImGuiCond)0;
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
        public static void SetNextWindowSize(Vector2 size)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetNextWindowSize(size, cond);
        }
        public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.igSetNextWindowSize(size, cond);
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
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, IntPtr custom_callback_data)
        {
            void* native_custom_callback_data = (void*)custom_callback_data.ToPointer();
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, native_custom_callback_data);
        }
        public static void SetNextWindowViewport(uint viewport_id)
        {
            ImGuiNative.igSetNextWindowViewport(viewport_id);
        }
        public static void SetScrollFromPosX(float local_x)
        {
            float center_x_ratio = 0.5f;
            ImGuiNative.igSetScrollFromPosX_Float(local_x, center_x_ratio);
        }
        public static void SetScrollFromPosX(float local_x, float center_x_ratio)
        {
            ImGuiNative.igSetScrollFromPosX_Float(local_x, center_x_ratio);
        }
        public static void SetScrollFromPosY(float local_y)
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.igSetScrollFromPosY_Float(local_y, center_y_ratio);
        }
        public static void SetScrollFromPosY(float local_y, float center_y_ratio)
        {
            ImGuiNative.igSetScrollFromPosY_Float(local_y, center_y_ratio);
        }
        public static void SetScrollHereX()
        {
            float center_x_ratio = 0.5f;
            ImGuiNative.igSetScrollHereX(center_x_ratio);
        }
        public static void SetScrollHereX(float center_x_ratio)
        {
            ImGuiNative.igSetScrollHereX(center_x_ratio);
        }
        public static void SetScrollHereY()
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.igSetScrollHereY(center_y_ratio);
        }
        public static void SetScrollHereY(float center_y_ratio)
        {
            ImGuiNative.igSetScrollHereY(center_y_ratio);
        }
        public static void SetScrollX(float scroll_x)
        {
            ImGuiNative.igSetScrollX_Float(scroll_x);
        }
        public static void SetScrollY(float scroll_y)
        {
            ImGuiNative.igSetScrollY_Float(scroll_y);
        }
        public static void SetStateStorage(ImGuiStoragePtr storage)
        {
            ImGuiStorage* native_storage = storage.NativePtr;
            ImGuiNative.igSetStateStorage(native_storage);
        }
        public static void SetTabItemClosed(string tab_or_docked_window_label)
        {
            byte* native_tab_or_docked_window_label;
            int tab_or_docked_window_label_byteCount = 0;
            if (tab_or_docked_window_label != null)
            {
                tab_or_docked_window_label_byteCount = Encoding.UTF8.GetByteCount(tab_or_docked_window_label);
                if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_tab_or_docked_window_label = Util.Allocate(tab_or_docked_window_label_byteCount + 1);
                }
                else
                {
                    byte* native_tab_or_docked_window_label_stackBytes = stackalloc byte[tab_or_docked_window_label_byteCount + 1];
                    native_tab_or_docked_window_label = native_tab_or_docked_window_label_stackBytes;
                }
                int native_tab_or_docked_window_label_offset = Util.GetUtf8(tab_or_docked_window_label, native_tab_or_docked_window_label, tab_or_docked_window_label_byteCount);
                native_tab_or_docked_window_label[native_tab_or_docked_window_label_offset] = 0;
            }
            else { native_tab_or_docked_window_label = null; }
            ImGuiNative.igSetTabItemClosed(native_tab_or_docked_window_label);
            if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_tab_or_docked_window_label);
            }
        }
        public static void SetTooltip(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igSetTooltip(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void SetWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowCollapsed_Bool(native_collapsed, cond);
        }
        public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetWindowCollapsed_Bool(native_collapsed, cond);
        }
        public static void SetWindowCollapsed(string name, bool collapsed)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowCollapsed_Str(native_name, native_collapsed, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowCollapsed(string name, bool collapsed, ImGuiCond cond)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetWindowCollapsed_Str(native_name, native_collapsed, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowFocus()
        {
            ImGuiNative.igSetWindowFocus_Nil();
        }
        public static void SetWindowFocus(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.igSetWindowFocus_Str(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowFontScale(float scale)
        {
            ImGuiNative.igSetWindowFontScale(scale);
        }
        public static void SetWindowPos(Vector2 pos)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowPos_Vec2(pos, cond);
        }
        public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
        {
            ImGuiNative.igSetWindowPos_Vec2(pos, cond);
        }
        public static void SetWindowPos(string name, Vector2 pos)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowPos_Str(native_name, pos, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowPos(string name, Vector2 pos, ImGuiCond cond)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.igSetWindowPos_Str(native_name, pos, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowSize(Vector2 size)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowSize_Vec2(size, cond);
        }
        public static void SetWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.igSetWindowSize_Vec2(size, cond);
        }
        public static void SetWindowSize(string name, Vector2 size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowSize_Str(native_name, size, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowSize(string name, Vector2 size, ImGuiCond cond)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.igSetWindowSize_Str(native_name, size, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void ShowAboutWindow()
        {
            byte* p_open = null;
            ImGuiNative.igShowAboutWindow(p_open);
        }
        public static void ShowAboutWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.igShowAboutWindow(native_p_open);
            p_open = native_p_open_val != 0;
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
        public static void ShowFontSelector(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.igShowFontSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
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
        public static void ShowStackToolWindow()
        {
            byte* p_open = null;
            ImGuiNative.igShowStackToolWindow(p_open);
        }
        public static void ShowStackToolWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.igShowStackToolWindow(native_p_open);
            p_open = native_p_open_val != 0;
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
        public static bool ShowStyleSelector(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igShowStyleSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void ShowUserGuide()
        {
            ImGuiNative.igShowUserGuide();
        }
        public static bool SliderAngle(string label, ref float v_rad)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_degrees_min = -360.0f;
            float v_degrees_max = +360.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_degrees_max = +360.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.igSliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt(string label, ref int v, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igSliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igSliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igSliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool SmallButton(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igSmallButton(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void Spacing()
        {
            ImGuiNative.igSpacing();
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
        public static bool TabItemButton(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.igTabItemButton(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TabItemButton(string label, ImGuiTabItemFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igTabItemButton(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static int TableGetColumnCount()
        {
            int ret = ImGuiNative.igTableGetColumnCount();
            return ret;
        }
        public static ImGuiTableColumnFlags TableGetColumnFlags()
        {
            int column_n = -1;
            ImGuiTableColumnFlags ret = ImGuiNative.igTableGetColumnFlags(column_n);
            return ret;
        }
        public static ImGuiTableColumnFlags TableGetColumnFlags(int column_n)
        {
            ImGuiTableColumnFlags ret = ImGuiNative.igTableGetColumnFlags(column_n);
            return ret;
        }
        public static int TableGetColumnIndex()
        {
            int ret = ImGuiNative.igTableGetColumnIndex();
            return ret;
        }
        public static string TableGetColumnName()
        {
            int column_n = -1;
            byte* ret = ImGuiNative.igTableGetColumnName_Int(column_n);
            return Util.StringFromPtr(ret);
        }
        public static string TableGetColumnName(int column_n)
        {
            byte* ret = ImGuiNative.igTableGetColumnName_Int(column_n);
            return Util.StringFromPtr(ret);
        }
        public static int TableGetRowIndex()
        {
            int ret = ImGuiNative.igTableGetRowIndex();
            return ret;
        }
        public static ImGuiTableSortSpecsPtr TableGetSortSpecs()
        {
            ImGuiTableSortSpecs* ret = ImGuiNative.igTableGetSortSpecs();
            return new ImGuiTableSortSpecsPtr(ret);
        }
        public static void TableHeader(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.igTableHeader(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableHeadersRow()
        {
            ImGuiNative.igTableHeadersRow();
        }
        public static bool TableNextColumn()
        {
            byte ret = ImGuiNative.igTableNextColumn();
            return ret != 0;
        }
        public static void TableNextRow()
        {
            ImGuiTableRowFlags row_flags = (ImGuiTableRowFlags)0;
            float min_row_height = 0.0f;
            ImGuiNative.igTableNextRow(row_flags, min_row_height);
        }
        public static void TableNextRow(ImGuiTableRowFlags row_flags)
        {
            float min_row_height = 0.0f;
            ImGuiNative.igTableNextRow(row_flags, min_row_height);
        }
        public static void TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height)
        {
            ImGuiNative.igTableNextRow(row_flags, min_row_height);
        }
        public static void TableSetBgColor(ImGuiTableBgTarget target, uint color)
        {
            int column_n = -1;
            ImGuiNative.igTableSetBgColor(target, color, column_n);
        }
        public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n)
        {
            ImGuiNative.igTableSetBgColor(target, color, column_n);
        }
        public static void TableSetColumnEnabled(int column_n, bool v)
        {
            byte native_v = v ? (byte)1 : (byte)0;
            ImGuiNative.igTableSetColumnEnabled(column_n, native_v);
        }
        public static bool TableSetColumnIndex(int column_n)
        {
            byte ret = ImGuiNative.igTableSetColumnIndex(column_n);
            return ret != 0;
        }
        public static void TableSetupColumn(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTableColumnFlags flags = (ImGuiTableColumnFlags)0;
            float init_width_or_weight = 0.0f;
            uint user_id = 0;
            ImGuiNative.igTableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float init_width_or_weight = 0.0f;
            uint user_id = 0;
            ImGuiNative.igTableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            uint user_id = 0;
            ImGuiNative.igTableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.igTableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableSetupScrollFreeze(int cols, int rows)
        {
            ImGuiNative.igTableSetupScrollFreeze(cols, rows);
        }
        public static void Text(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igText(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void TextColored(Vector4 col, string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igTextColored(col, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void TextDisabled(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igTextDisabled(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void TextUnformatted(string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            ImGuiNative.igTextUnformatted(native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void TextWrapped(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.igTextWrapped(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static bool TreeNode(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igTreeNode_Str(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TreeNode(string str_id, string fmt)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.igTreeNode_StrStr(native_str_id, native_fmt);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
        public static bool TreeNode(IntPtr ptr_id, string fmt)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.igTreeNode_Ptr(native_ptr_id, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
        public static bool TreeNodeEx(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.igTreeNodeEx_Str(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TreeNodeEx(string label, ImGuiTreeNodeFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.igTreeNodeEx_Str(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.igTreeNodeEx_StrStr(native_str_id, flags, native_fmt);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
        public static bool TreeNodeEx(IntPtr ptr_id, ImGuiTreeNodeFlags flags, string fmt)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.igTreeNodeEx_Ptr(native_ptr_id, flags, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
        public static void TreePop()
        {
            ImGuiNative.igTreePop();
        }
        public static void TreePush(string str_id)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.igTreePush_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void TreePush()
        {
            void* ptr_id = null;
            ImGuiNative.igTreePush_Ptr(ptr_id);
        }
        public static void TreePush(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            ImGuiNative.igTreePush_Ptr(native_ptr_id);
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
        public static void UpdatePlatformWindows()
        {
            ImGuiNative.igUpdatePlatformWindows();
        }
        public static void Value(string prefix, bool b)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuiNative.igValue_Bool(native_prefix, native_b);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
        public static void Value(string prefix, int v)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            ImGuiNative.igValue_Int(native_prefix, v);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
        public static void Value(string prefix, uint v)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            ImGuiNative.igValue_Uint(native_prefix, v);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
        public static void Value(string prefix, float v)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte* native_float_format = null;
            ImGuiNative.igValue_Float(native_prefix, v, native_float_format);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
        public static void Value(string prefix, float v, string float_format)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte* native_float_format;
            int float_format_byteCount = 0;
            if (float_format != null)
            {
                float_format_byteCount = Encoding.UTF8.GetByteCount(float_format);
                if (float_format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_float_format = Util.Allocate(float_format_byteCount + 1);
                }
                else
                {
                    byte* native_float_format_stackBytes = stackalloc byte[float_format_byteCount + 1];
                    native_float_format = native_float_format_stackBytes;
                }
                int native_float_format_offset = Util.GetUtf8(float_format, native_float_format, float_format_byteCount);
                native_float_format[native_float_format_offset] = 0;
            }
            else { native_float_format = null; }
            ImGuiNative.igValue_Float(native_prefix, v, native_float_format);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
            if (float_format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_float_format);
            }
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.igVSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igVSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
    }
}
