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
        public static void ActivateItem(uint id)
        {
            ImGuiNative.igActivateItem(id);
        }
        public static uint AddContextHook(IntPtr context, ImGuiContextHookPtr hook)
        {
            ImGuiContextHook* native_hook = hook.NativePtr;
            uint ret = ImGuiNative.igAddContextHook(context, native_hook);
            return ret;
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
        public static bool ArrowButtonEx(string str_id, ImGuiDir dir, Vector2 size_arg)
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
            byte ret = ImGuiNative.igArrowButtonEx(native_str_id, dir, size_arg, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool ArrowButtonEx(string str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags)
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
            byte ret = ImGuiNative.igArrowButtonEx(native_str_id, dir, size_arg, flags);
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
        public static bool BeginChildEx(string name, uint id, Vector2 size_arg, bool border, ImGuiWindowFlags flags)
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
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginChildEx(native_name, id, size_arg, native_border, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
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
        public static void BeginColumns(string str_id, int count)
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
            ImGuiOldColumnFlags flags = (ImGuiOldColumnFlags)0;
            ImGuiNative.igBeginColumns(native_str_id, count, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void BeginColumns(string str_id, int count, ImGuiOldColumnFlags flags)
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
            ImGuiNative.igBeginColumns(native_str_id, count, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
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
        public static bool BeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags)
        {
            byte ret = ImGuiNative.igBeginComboPopup(popup_id, bb, flags);
            return ret != 0;
        }
        public static bool BeginComboPreview()
        {
            byte ret = ImGuiNative.igBeginComboPreview();
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
        public static void BeginDockableDragDropSource(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igBeginDockableDragDropSource(native_window);
        }
        public static void BeginDockableDragDropTarget(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igBeginDockableDragDropTarget(native_window);
        }
        public static void BeginDocked(ImGuiWindowPtr window, ref bool p_open)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.igBeginDocked(native_window, native_p_open);
            p_open = native_p_open_val != 0;
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
        public static bool BeginDragDropTargetCustom(ImRect bb, uint id)
        {
            byte ret = ImGuiNative.igBeginDragDropTargetCustom(bb, id);
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
        public static bool BeginMenuEx(string label, string icon)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte enabled = 1;
            byte ret = ImGuiNative.igBeginMenuEx(native_label, native_icon, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            return ret != 0;
        }
        public static bool BeginMenuEx(string label, string icon, bool enabled)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igBeginMenuEx(native_label, native_icon, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
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
        public static bool BeginPopupEx(uint id, ImGuiWindowFlags extra_flags)
        {
            byte ret = ImGuiNative.igBeginPopupEx(id, extra_flags);
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
        public static bool BeginTabBarEx(ImGuiTabBarPtr tab_bar, ImRect bb, ImGuiTabBarFlags flags, ImGuiDockNodePtr dock_node)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiDockNode* native_dock_node = dock_node.NativePtr;
            byte ret = ImGuiNative.igBeginTabBarEx(native_tab_bar, bb, flags, native_dock_node);
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
        public static bool BeginTableEx(string name, uint id, int columns_count)
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
            ImGuiTableFlags flags = (ImGuiTableFlags)0;
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags)
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
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size)
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
            float inner_width = 0.0f;
            byte ret = ImGuiNative.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
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
            byte ret = ImGuiNative.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static void BeginTooltip()
        {
            ImGuiNative.igBeginTooltip();
        }
        public static void BeginTooltipEx(ImGuiWindowFlags extra_flags, ImGuiTooltipFlags tooltip_flags)
        {
            ImGuiNative.igBeginTooltipEx(extra_flags, tooltip_flags);
        }
        public static bool BeginViewportSideBar(string name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags)
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
            ImGuiViewport* native_viewport = viewport.NativePtr;
            byte ret = ImGuiNative.igBeginViewportSideBar(native_name, native_viewport, dir, size, window_flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static void BringWindowToDisplayBack(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igBringWindowToDisplayBack(native_window);
        }
        public static void BringWindowToDisplayFront(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igBringWindowToDisplayFront(native_window);
        }
        public static void BringWindowToFocusFront(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igBringWindowToFocusFront(native_window);
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
        public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held)
        {
            byte native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
            byte* native_out_hovered = &native_out_hovered_val;
            byte native_out_held_val = out_held ? (byte)1 : (byte)0;
            byte* native_out_held = &native_out_held_val;
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNative.igButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
            out_hovered = native_out_hovered_val != 0;
            out_held = native_out_held_val != 0;
            return ret != 0;
        }
        public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held, ImGuiButtonFlags flags)
        {
            byte native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
            byte* native_out_hovered = &native_out_hovered_val;
            byte native_out_held_val = out_held ? (byte)1 : (byte)0;
            byte* native_out_held = &native_out_held_val;
            byte ret = ImGuiNative.igButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
            out_hovered = native_out_hovered_val != 0;
            out_held = native_out_held_val != 0;
            return ret != 0;
        }
        public static bool ButtonEx(string label)
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
            Vector2 size_arg = new Vector2();
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNative.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool ButtonEx(string label, Vector2 size_arg)
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
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNative.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool ButtonEx(string label, Vector2 size_arg, ImGuiButtonFlags flags)
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
            byte ret = ImGuiNative.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static Vector2 CalcItemSize(Vector2 size, float default_w, float default_h)
        {
            Vector2 __retval;
            ImGuiNative.igCalcItemSize(&__retval, size, default_w, default_h);
            return __retval;
        }
        public static float CalcItemWidth()
        {
            float ret = ImGuiNative.igCalcItemWidth();
            return ret;
        }
        public static int CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate)
        {
            int ret = ImGuiNative.igCalcTypematicRepeatAmount(t0, t1, repeat_delay, repeat_rate);
            return ret;
        }
        public static Vector2 CalcWindowNextAutoFitSize(ImGuiWindowPtr window)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igCalcWindowNextAutoFitSize(&__retval, native_window);
            return __retval;
        }
        public static float CalcWrapWidthForPos(Vector2 pos, float wrap_pos_x)
        {
            float ret = ImGuiNative.igCalcWrapWidthForPos(pos, wrap_pos_x);
            return ret;
        }
        public static void CallContextHooks(IntPtr context, ImGuiContextHookType type)
        {
            ImGuiNative.igCallContextHooks(context, type);
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
        public static bool CheckboxFlags(string label, ref long flags, long flags_value)
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
            fixed (long* native_flags = &flags)
            {
                byte ret = ImGuiNative.igCheckboxFlags_S64Ptr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool CheckboxFlags(string label, ref ulong flags, ulong flags_value)
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
            fixed (ulong* native_flags = &flags)
            {
                byte ret = ImGuiNative.igCheckboxFlags_U64Ptr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void ClearActiveID()
        {
            ImGuiNative.igClearActiveID();
        }
        public static void ClearDragDrop()
        {
            ImGuiNative.igClearDragDrop();
        }
        public static void ClearIniSettings()
        {
            ImGuiNative.igClearIniSettings();
        }
        public static bool CloseButton(uint id, Vector2 pos)
        {
            byte ret = ImGuiNative.igCloseButton(id, pos);
            return ret != 0;
        }
        public static void CloseCurrentPopup()
        {
            ImGuiNative.igCloseCurrentPopup();
        }
        public static void ClosePopupsOverWindow(ImGuiWindowPtr ref_window, bool restore_focus_to_window_under_popup)
        {
            ImGuiWindow* native_ref_window = ref_window.NativePtr;
            byte native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;
            ImGuiNative.igClosePopupsOverWindow(native_ref_window, native_restore_focus_to_window_under_popup);
        }
        public static void ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup)
        {
            byte native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;
            ImGuiNative.igClosePopupToLevel(remaining, native_restore_focus_to_window_under_popup);
        }
        public static bool CollapseButton(uint id, Vector2 pos, ImGuiDockNodePtr dock_node)
        {
            ImGuiDockNode* native_dock_node = dock_node.NativePtr;
            byte ret = ImGuiNative.igCollapseButton(id, pos, native_dock_node);
            return ret != 0;
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
        public static void ColorEditOptionsPopup(ref float col, ImGuiColorEditFlags flags)
        {
            fixed (float* native_col = &col)
            {
                ImGuiNative.igColorEditOptionsPopup(native_col, flags);
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
        public static void ColorPickerOptionsPopup(ref float ref_col, ImGuiColorEditFlags flags)
        {
            fixed (float* native_ref_col = &ref_col)
            {
                ImGuiNative.igColorPickerOptionsPopup(native_ref_col, flags);
            }
        }
        public static void ColorTooltip(string text, ref float col, ImGuiColorEditFlags flags)
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
            fixed (float* native_col = &col)
            {
                ImGuiNative.igColorTooltip(native_text, native_col, flags);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text);
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
        public static ImGuiWindowSettingsPtr CreateNewWindowSettings(string name)
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
            ImGuiWindowSettings* ret = ImGuiNative.igCreateNewWindowSettings(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static void DataTypeApplyOp(ImGuiDataType data_type, int op, IntPtr output, IntPtr arg_1, IntPtr arg_2)
        {
            void* native_output = (void*)output.ToPointer();
            void* native_arg_1 = (void*)arg_1.ToPointer();
            void* native_arg_2 = (void*)arg_2.ToPointer();
            ImGuiNative.igDataTypeApplyOp(data_type, op, native_output, native_arg_1, native_arg_2);
        }
        public static bool DataTypeApplyOpFromText(string buf, string initial_value_buf, ImGuiDataType data_type, IntPtr p_data, string format)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte* native_initial_value_buf;
            int initial_value_buf_byteCount = 0;
            if (initial_value_buf != null)
            {
                initial_value_buf_byteCount = Encoding.UTF8.GetByteCount(initial_value_buf);
                if (initial_value_buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_initial_value_buf = Util.Allocate(initial_value_buf_byteCount + 1);
                }
                else
                {
                    byte* native_initial_value_buf_stackBytes = stackalloc byte[initial_value_buf_byteCount + 1];
                    native_initial_value_buf = native_initial_value_buf_stackBytes;
                }
                int native_initial_value_buf_offset = Util.GetUtf8(initial_value_buf, native_initial_value_buf, initial_value_buf_byteCount);
                native_initial_value_buf[native_initial_value_buf_offset] = 0;
            }
            else { native_initial_value_buf = null; }
            void* native_p_data = (void*)p_data.ToPointer();
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
            byte ret = ImGuiNative.igDataTypeApplyOpFromText(native_buf, native_initial_value_buf, data_type, native_p_data, native_format);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (initial_value_buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_initial_value_buf);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool DataTypeClamp(ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
        {
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte ret = ImGuiNative.igDataTypeClamp(data_type, native_p_data, native_p_min, native_p_max);
            return ret != 0;
        }
        public static int DataTypeCompare(ImGuiDataType data_type, IntPtr arg_1, IntPtr arg_2)
        {
            void* native_arg_1 = (void*)arg_1.ToPointer();
            void* native_arg_2 = (void*)arg_2.ToPointer();
            int ret = ImGuiNative.igDataTypeCompare(data_type, native_arg_1, native_arg_2);
            return ret;
        }
        public static int DataTypeFormatString(string buf, int buf_size, ImGuiDataType data_type, IntPtr p_data, string format)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            void* native_p_data = (void*)p_data.ToPointer();
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
            int ret = ImGuiNative.igDataTypeFormatString(native_buf, buf_size, data_type, native_p_data, native_format);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret;
        }
        public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType data_type)
        {
            ImGuiDataTypeInfo* ret = ImGuiNative.igDataTypeGetInfo(data_type);
            return new ImGuiDataTypeInfoPtr(ret);
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
        public static void DebugDrawItemRect()
        {
            uint col = 4278190335;
            ImGuiNative.igDebugDrawItemRect(col);
        }
        public static void DebugDrawItemRect(uint col)
        {
            ImGuiNative.igDebugDrawItemRect(col);
        }
        public static void DebugNodeColumns(ImGuiOldColumnsPtr columns)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            ImGuiNative.igDebugNodeColumns(native_columns);
        }
        public static void DebugNodeDockNode(ImGuiDockNodePtr node, string label)
        {
            ImGuiDockNode* native_node = node.NativePtr;
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
            ImGuiNative.igDebugNodeDockNode(native_node, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawListPtr out_draw_list, ImDrawListPtr draw_list, ImDrawCmdPtr draw_cmd, bool show_mesh, bool show_aabb)
        {
            ImDrawList* native_out_draw_list = out_draw_list.NativePtr;
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImDrawCmd* native_draw_cmd = draw_cmd.NativePtr;
            byte native_show_mesh = show_mesh ? (byte)1 : (byte)0;
            byte native_show_aabb = show_aabb ? (byte)1 : (byte)0;
            ImGuiNative.igDebugNodeDrawCmdShowMeshAndBoundingBox(native_out_draw_list, native_draw_list, native_draw_cmd, native_show_mesh, native_show_aabb);
        }
        public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr draw_list, string label)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImDrawList* native_draw_list = draw_list.NativePtr;
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
            ImGuiNative.igDebugNodeDrawList(native_window, native_viewport, native_draw_list, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNative.igDebugNodeFont(native_font);
        }
        public static void DebugNodeStorage(ImGuiStoragePtr storage, string label)
        {
            ImGuiStorage* native_storage = storage.NativePtr;
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
            ImGuiNative.igDebugNodeStorage(native_storage, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeTabBar(ImGuiTabBarPtr tab_bar, string label)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
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
            ImGuiNative.igDebugNodeTabBar(native_tab_bar, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeTable(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igDebugNodeTable(native_table);
        }
        public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings)
        {
            ImGuiTableSettings* native_settings = settings.NativePtr;
            ImGuiNative.igDebugNodeTableSettings(native_settings);
        }
        public static void DebugNodeViewport(ImGuiViewportPPtr viewport)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igDebugNodeViewport(native_viewport);
        }
        public static void DebugNodeWindow(ImGuiWindowPtr window, string label)
        {
            ImGuiWindow* native_window = window.NativePtr;
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
            ImGuiNative.igDebugNodeWindow(native_window, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeWindowSettings(ImGuiWindowSettingsPtr settings)
        {
            ImGuiWindowSettings* native_settings = settings.NativePtr;
            ImGuiNative.igDebugNodeWindowSettings(native_settings);
        }
        public static void DebugNodeWindowsList(ref ImVector windows, string label)
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
            fixed (ImVector* native_windows = &windows)
            {
                ImGuiNative.igDebugNodeWindowsList(native_windows, native_label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void DebugRenderViewportThumbnail(ImDrawListPtr draw_list, ImGuiViewportPPtr viewport, ImRect bb)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igDebugRenderViewportThumbnail(native_draw_list, native_viewport, bb);
        }
        public static void DebugStartItemPicker()
        {
            ImGuiNative.igDebugStartItemPicker();
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
        public static void DestroyPlatformWindow(ImGuiViewportPPtr viewport)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igDestroyPlatformWindow(native_viewport);
        }
        public static void DestroyPlatformWindows()
        {
            ImGuiNative.igDestroyPlatformWindows();
        }
        public static uint DockBuilderAddNode()
        {
            uint node_id = 0;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            uint ret = ImGuiNative.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static uint DockBuilderAddNode(uint node_id)
        {
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            uint ret = ImGuiNative.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static uint DockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags)
        {
            uint ret = ImGuiNative.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static void DockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ref ImVector in_window_remap_pairs)
        {
            fixed (ImVector* native_in_window_remap_pairs = &in_window_remap_pairs)
            {
                ImGuiNative.igDockBuilderCopyDockSpace(src_dockspace_id, dst_dockspace_id, native_in_window_remap_pairs);
            }
        }
        public static void DockBuilderCopyNode(uint src_node_id, uint dst_node_id, out ImVector out_node_remap_pairs)
        {
            fixed (ImVector* native_out_node_remap_pairs = &out_node_remap_pairs)
            {
                ImGuiNative.igDockBuilderCopyNode(src_node_id, dst_node_id, native_out_node_remap_pairs);
            }
        }
        public static void DockBuilderCopyWindowSettings(string src_name, string dst_name)
        {
            byte* native_src_name;
            int src_name_byteCount = 0;
            if (src_name != null)
            {
                src_name_byteCount = Encoding.UTF8.GetByteCount(src_name);
                if (src_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_src_name = Util.Allocate(src_name_byteCount + 1);
                }
                else
                {
                    byte* native_src_name_stackBytes = stackalloc byte[src_name_byteCount + 1];
                    native_src_name = native_src_name_stackBytes;
                }
                int native_src_name_offset = Util.GetUtf8(src_name, native_src_name, src_name_byteCount);
                native_src_name[native_src_name_offset] = 0;
            }
            else { native_src_name = null; }
            byte* native_dst_name;
            int dst_name_byteCount = 0;
            if (dst_name != null)
            {
                dst_name_byteCount = Encoding.UTF8.GetByteCount(dst_name);
                if (dst_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst_name = Util.Allocate(dst_name_byteCount + 1);
                }
                else
                {
                    byte* native_dst_name_stackBytes = stackalloc byte[dst_name_byteCount + 1];
                    native_dst_name = native_dst_name_stackBytes;
                }
                int native_dst_name_offset = Util.GetUtf8(dst_name, native_dst_name, dst_name_byteCount);
                native_dst_name[native_dst_name_offset] = 0;
            }
            else { native_dst_name = null; }
            ImGuiNative.igDockBuilderCopyWindowSettings(native_src_name, native_dst_name);
            if (src_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_src_name);
            }
            if (dst_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_dst_name);
            }
        }
        public static void DockBuilderDockWindow(string window_name, uint node_id)
        {
            byte* native_window_name;
            int window_name_byteCount = 0;
            if (window_name != null)
            {
                window_name_byteCount = Encoding.UTF8.GetByteCount(window_name);
                if (window_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_window_name = Util.Allocate(window_name_byteCount + 1);
                }
                else
                {
                    byte* native_window_name_stackBytes = stackalloc byte[window_name_byteCount + 1];
                    native_window_name = native_window_name_stackBytes;
                }
                int native_window_name_offset = Util.GetUtf8(window_name, native_window_name, window_name_byteCount);
                native_window_name[native_window_name_offset] = 0;
            }
            else { native_window_name = null; }
            ImGuiNative.igDockBuilderDockWindow(native_window_name, node_id);
            if (window_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_window_name);
            }
        }
        public static void DockBuilderFinish(uint node_id)
        {
            ImGuiNative.igDockBuilderFinish(node_id);
        }
        public static ImGuiDockNodePtr DockBuilderGetCentralNode(uint node_id)
        {
            ImGuiDockNode* ret = ImGuiNative.igDockBuilderGetCentralNode(node_id);
            return new ImGuiDockNodePtr(ret);
        }
        public static ImGuiDockNodePtr DockBuilderGetNode(uint node_id)
        {
            ImGuiDockNode* ret = ImGuiNative.igDockBuilderGetNode(node_id);
            return new ImGuiDockNodePtr(ret);
        }
        public static void DockBuilderRemoveNode(uint node_id)
        {
            ImGuiNative.igDockBuilderRemoveNode(node_id);
        }
        public static void DockBuilderRemoveNodeChildNodes(uint node_id)
        {
            ImGuiNative.igDockBuilderRemoveNodeChildNodes(node_id);
        }
        public static void DockBuilderRemoveNodeDockedWindows(uint node_id)
        {
            byte clear_settings_refs = 1;
            ImGuiNative.igDockBuilderRemoveNodeDockedWindows(node_id, clear_settings_refs);
        }
        public static void DockBuilderRemoveNodeDockedWindows(uint node_id, bool clear_settings_refs)
        {
            byte native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;
            ImGuiNative.igDockBuilderRemoveNodeDockedWindows(node_id, native_clear_settings_refs);
        }
        public static void DockBuilderSetNodePos(uint node_id, Vector2 pos)
        {
            ImGuiNative.igDockBuilderSetNodePos(node_id, pos);
        }
        public static void DockBuilderSetNodeSize(uint node_id, Vector2 size)
        {
            ImGuiNative.igDockBuilderSetNodeSize(node_id, size);
        }
        public static uint DockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, out uint out_id_at_dir, out uint out_id_at_opposite_dir)
        {
            fixed (uint* native_out_id_at_dir = &out_id_at_dir)
            {
                fixed (uint* native_out_id_at_opposite_dir = &out_id_at_opposite_dir)
                {
                    uint ret = ImGuiNative.igDockBuilderSplitNode(node_id, split_dir, size_ratio_for_node_at_dir, native_out_id_at_dir, native_out_id_at_opposite_dir);
                    return ret;
                }
            }
        }
        public static bool DockContextCalcDropPosForDocking(ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload, ImGuiDir split_dir, bool split_outer, out Vector2 out_pos)
        {
            ImGuiWindow* native_target = target.NativePtr;
            ImGuiDockNode* native_target_node = target_node.NativePtr;
            ImGuiWindow* native_payload = payload.NativePtr;
            byte native_split_outer = split_outer ? (byte)1 : (byte)0;
            fixed (Vector2* native_out_pos = &out_pos)
            {
                byte ret = ImGuiNative.igDockContextCalcDropPosForDocking(native_target, native_target_node, native_payload, split_dir, native_split_outer, native_out_pos);
                return ret != 0;
            }
        }
        public static void DockContextClearNodes(IntPtr ctx, uint root_id, bool clear_settings_refs)
        {
            byte native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;
            ImGuiNative.igDockContextClearNodes(ctx, root_id, native_clear_settings_refs);
        }
        public static uint DockContextGenNodeID(IntPtr ctx)
        {
            uint ret = ImGuiNative.igDockContextGenNodeID(ctx);
            return ret;
        }
        public static void DockContextInitialize(IntPtr ctx)
        {
            ImGuiNative.igDockContextInitialize(ctx);
        }
        public static void DockContextNewFrameUpdateDocking(IntPtr ctx)
        {
            ImGuiNative.igDockContextNewFrameUpdateDocking(ctx);
        }
        public static void DockContextNewFrameUpdateUndocking(IntPtr ctx)
        {
            ImGuiNative.igDockContextNewFrameUpdateUndocking(ctx);
        }
        public static void DockContextQueueDock(IntPtr ctx, ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload, ImGuiDir split_dir, float split_ratio, bool split_outer)
        {
            ImGuiWindow* native_target = target.NativePtr;
            ImGuiDockNode* native_target_node = target_node.NativePtr;
            ImGuiWindow* native_payload = payload.NativePtr;
            byte native_split_outer = split_outer ? (byte)1 : (byte)0;
            ImGuiNative.igDockContextQueueDock(ctx, native_target, native_target_node, native_payload, split_dir, split_ratio, native_split_outer);
        }
        public static void DockContextQueueUndockNode(IntPtr ctx, ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            ImGuiNative.igDockContextQueueUndockNode(ctx, native_node);
        }
        public static void DockContextQueueUndockWindow(IntPtr ctx, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igDockContextQueueUndockWindow(ctx, native_window);
        }
        public static void DockContextRebuildNodes(IntPtr ctx)
        {
            ImGuiNative.igDockContextRebuildNodes(ctx);
        }
        public static void DockContextShutdown(IntPtr ctx)
        {
            ImGuiNative.igDockContextShutdown(ctx);
        }
        public static bool DockNodeBeginAmendTabBar(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            byte ret = ImGuiNative.igDockNodeBeginAmendTabBar(native_node);
            return ret != 0;
        }
        public static void DockNodeEndAmendTabBar()
        {
            ImGuiNative.igDockNodeEndAmendTabBar();
        }
        public static int DockNodeGetDepth(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            int ret = ImGuiNative.igDockNodeGetDepth(native_node);
            return ret;
        }
        public static ImGuiDockNodePtr DockNodeGetRootNode(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            ImGuiDockNode* ret = ImGuiNative.igDockNodeGetRootNode(native_node);
            return new ImGuiDockNodePtr(ret);
        }
        public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            uint ret = ImGuiNative.igDockNodeGetWindowMenuButtonId(native_node);
            return ret;
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
        public static bool DragBehavior(uint id, ImGuiDataType data_type, IntPtr p_v, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            void* native_p_v = (void*)p_v.ToPointer();
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
            byte ret = ImGuiNative.igDragBehavior(id, data_type, native_p_v, v_speed, native_p_min, native_p_max, native_format, flags);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
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
        public static void EndColumns()
        {
            ImGuiNative.igEndColumns();
        }
        public static void EndCombo()
        {
            ImGuiNative.igEndCombo();
        }
        public static void EndComboPreview()
        {
            ImGuiNative.igEndComboPreview();
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
        public static void ErrorCheckEndFrameRecover(IntPtr log_callback)
        {
            void* user_data = null;
            ImGuiNative.igErrorCheckEndFrameRecover(log_callback, user_data);
        }
        public static void ErrorCheckEndFrameRecover(IntPtr log_callback, IntPtr user_data)
        {
            void* native_user_data = (void*)user_data.ToPointer();
            ImGuiNative.igErrorCheckEndFrameRecover(log_callback, native_user_data);
        }
        public static Vector2 FindBestWindowPosForPopup(ImGuiWindowPtr window)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igFindBestWindowPosForPopup(&__retval, native_window);
            return __retval;
        }
        public static Vector2 FindBestWindowPosForPopupEx(Vector2 ref_pos, Vector2 size, IntPtr last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy)
        {
            Vector2 __retval;
            ImGuiNative.igFindBestWindowPosForPopupEx(&__retval, ref_pos, size, last_dir, r_outer, r_avoid, policy);
            return __retval;
        }
        public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiOldColumns* ret = ImGuiNative.igFindOrCreateColumns(native_window, id);
            return new ImGuiOldColumnsPtr(ret);
        }
        public static ImGuiWindowSettingsPtr FindOrCreateWindowSettings(string name)
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
            ImGuiWindowSettings* ret = ImGuiNative.igFindOrCreateWindowSettings(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static string FindRenderedTextEnd(string text)
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
            byte* ret = ImGuiNative.igFindRenderedTextEnd(native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
            return Util.StringFromPtr(ret);
        }
        public static ImGuiSettingsHandlerPtr FindSettingsHandler(string type_name)
        {
            byte* native_type_name;
            int type_name_byteCount = 0;
            if (type_name != null)
            {
                type_name_byteCount = Encoding.UTF8.GetByteCount(type_name);
                if (type_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type_name = Util.Allocate(type_name_byteCount + 1);
                }
                else
                {
                    byte* native_type_name_stackBytes = stackalloc byte[type_name_byteCount + 1];
                    native_type_name = native_type_name_stackBytes;
                }
                int native_type_name_offset = Util.GetUtf8(type_name, native_type_name, type_name_byteCount);
                native_type_name[native_type_name_offset] = 0;
            }
            else { native_type_name = null; }
            ImGuiSettingsHandler* ret = ImGuiNative.igFindSettingsHandler(native_type_name);
            if (type_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type_name);
            }
            return new ImGuiSettingsHandlerPtr(ret);
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
        public static ImGuiWindowPtr FindWindowByID(uint id)
        {
            ImGuiWindow* ret = ImGuiNative.igFindWindowByID(id);
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowPtr FindWindowByName(string name)
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
            ImGuiWindow* ret = ImGuiNative.igFindWindowByName(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowSettingsPtr FindWindowSettings(uint id)
        {
            ImGuiWindowSettings* ret = ImGuiNative.igFindWindowSettings(id);
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr under_this_window, ImGuiWindowPtr ignore_window)
        {
            ImGuiWindow* native_under_this_window = under_this_window.NativePtr;
            ImGuiWindow* native_ignore_window = ignore_window.NativePtr;
            ImGuiNative.igFocusTopMostWindowUnderOne(native_under_this_window, native_ignore_window);
        }
        public static void FocusWindow(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igFocusWindow(native_window);
        }
        public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igGcAwakeTransientWindowBuffers(native_window);
        }
        public static void GcCompactTransientMiscBuffers()
        {
            ImGuiNative.igGcCompactTransientMiscBuffers();
        }
        public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igGcCompactTransientWindowBuffers(native_window);
        }
        public static uint GetActiveID()
        {
            uint ret = ImGuiNative.igGetActiveID();
            return ret;
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
        public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            float ret = ImGuiNative.igGetColumnNormFromOffset(native_columns, offset);
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
        public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offset_norm)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            float ret = ImGuiNative.igGetColumnOffsetFromNorm(native_columns, offset_norm);
            return ret;
        }
        public static int GetColumnsCount()
        {
            int ret = ImGuiNative.igGetColumnsCount();
            return ret;
        }
        public static uint GetColumnsID(string str_id, int count)
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
            uint ret = ImGuiNative.igGetColumnsID(native_str_id, count);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
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
        public static Vector2 GetContentRegionMaxAbs()
        {
            Vector2 __retval;
            ImGuiNative.igGetContentRegionMaxAbs(&__retval);
            return __retval;
        }
        public static IntPtr GetCurrentContext()
        {
            IntPtr ret = ImGuiNative.igGetCurrentContext();
            return ret;
        }
        public static ImGuiTablePtr GetCurrentTable()
        {
            ImGuiTable* ret = ImGuiNative.igGetCurrentTable();
            return new ImGuiTablePtr(ret);
        }
        public static ImGuiWindowPtr GetCurrentWindow()
        {
            ImGuiWindow* ret = ImGuiNative.igGetCurrentWindow();
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowPtr GetCurrentWindowRead()
        {
            ImGuiWindow* ret = ImGuiNative.igGetCurrentWindowRead();
            return new ImGuiWindowPtr(ret);
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
        public static ImFontPtr GetDefaultFont()
        {
            ImFont* ret = ImGuiNative.igGetDefaultFont();
            return new ImFontPtr(ret);
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
        public static uint GetFocusedFocusScope()
        {
            uint ret = ImGuiNative.igGetFocusedFocusScope();
            return ret;
        }
        public static uint GetFocusID()
        {
            uint ret = ImGuiNative.igGetFocusID();
            return ret;
        }
        public static uint GetFocusScope()
        {
            uint ret = ImGuiNative.igGetFocusScope();
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
        public static ImDrawListPtr GetForegroundDrawList(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImDrawList* ret = ImGuiNative.igGetForegroundDrawList_WindowPtr(native_window);
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
        public static uint GetHoveredID()
        {
            uint ret = ImGuiNative.igGetHoveredID();
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
        public static ImGuiInputTextStatePtr GetInputTextState(uint id)
        {
            ImGuiInputTextState* ret = ImGuiNative.igGetInputTextState(id);
            return new ImGuiInputTextStatePtr(ret);
        }
        public static ImGuiIOPtr GetIO()
        {
            ImGuiIO* ret = ImGuiNative.igGetIO();
            return new ImGuiIOPtr(ret);
        }
        public static ImGuiItemFlags GetItemFlags()
        {
            ImGuiItemFlags ret = ImGuiNative.igGetItemFlags();
            return ret;
        }
        public static uint GetItemID()
        {
            uint ret = ImGuiNative.igGetItemID();
            return ret;
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
        public static ImGuiItemStatusFlags GetItemStatusFlags()
        {
            ImGuiItemStatusFlags ret = ImGuiNative.igGetItemStatusFlags();
            return ret;
        }
        public static int GetKeyIndex(ImGuiKey imgui_key)
        {
            int ret = ImGuiNative.igGetKeyIndex(imgui_key);
            return ret;
        }
        public static int GetKeyPressedAmount(int key_index, float repeat_delay, float rate)
        {
            int ret = ImGuiNative.igGetKeyPressedAmount(key_index, repeat_delay, rate);
            return ret;
        }
        public static ImGuiViewportPtr GetMainViewport()
        {
            ImGuiViewport* ret = ImGuiNative.igGetMainViewport();
            return new ImGuiViewportPtr(ret);
        }
        public static ImGuiKeyModFlags GetMergedKeyModFlags()
        {
            ImGuiKeyModFlags ret = ImGuiNative.igGetMergedKeyModFlags();
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
        public static float GetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode)
        {
            float ret = ImGuiNative.igGetNavInputAmount(n, mode);
            return ret;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode)
        {
            Vector2 __retval;
            float slow_factor = 0.0f;
            float fast_factor = 0.0f;
            ImGuiNative.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor)
        {
            Vector2 __retval;
            float fast_factor = 0.0f;
            ImGuiNative.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor)
        {
            Vector2 __retval;
            ImGuiNative.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static ImGuiPlatformIOPtr GetPlatformIO()
        {
            ImGuiPlatformIO* ret = ImGuiNative.igGetPlatformIO();
            return new ImGuiPlatformIOPtr(ret);
        }
        public static ImRect GetPopupAllowedExtentRect(ImGuiWindowPtr window)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igGetPopupAllowedExtentRect(&__retval, native_window);
            return __retval;
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
        public static ImGuiWindowPtr GetTopMostPopupModal()
        {
            ImGuiWindow* ret = ImGuiNative.igGetTopMostPopupModal();
            return new ImGuiWindowPtr(ret);
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
        public static ImGuiPlatformMonitorPtr GetViewportPlatformMonitor(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiPlatformMonitor* ret = ImGuiNative.igGetViewportPlatformMonitor(native_viewport);
            return new ImGuiPlatformMonitorPtr(ret);
        }
        public static bool GetWindowAlwaysWantOwnTabBar(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte ret = ImGuiNative.igGetWindowAlwaysWantOwnTabBar(native_window);
            return ret != 0;
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
        public static ImGuiDockNodePtr GetWindowDockNode()
        {
            ImGuiDockNode* ret = ImGuiNative.igGetWindowDockNode();
            return new ImGuiDockNodePtr(ret);
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
        public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNative.igGetWindowResizeBorderID(native_window, dir);
            return ret;
        }
        public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNative.igGetWindowResizeCornerID(native_window, n);
            return ret;
        }
        public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNative.igGetWindowScrollbarID(native_window, axis);
            return ret;
        }
        public static ImRect GetWindowScrollbarRect(ImGuiWindowPtr window, ImGuiAxis axis)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igGetWindowScrollbarRect(&__retval, native_window, axis);
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
        public static int ImAbs(int x)
        {
            int ret = ImGuiNative.igImAbs_Int(x);
            return ret;
        }
        public static float ImAbs(float x)
        {
            float ret = ImGuiNative.igImAbs_Float(x);
            return ret;
        }
        public static double ImAbs(double x)
        {
            double ret = ImGuiNative.igImAbs_double(x);
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
        public static bool ImageButtonEx(uint id, IntPtr texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector2 padding, Vector4 bg_col, Vector4 tint_col)
        {
            byte ret = ImGuiNative.igImageButtonEx(id, texture_id, size, uv0, uv1, padding, bg_col, tint_col);
            return ret != 0;
        }
        public static uint ImAlphaBlendColors(uint col_a, uint col_b)
        {
            uint ret = ImGuiNative.igImAlphaBlendColors(col_a, col_b);
            return ret;
        }
        public static Vector2 ImBezierCubicCalc(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
        {
            Vector2 __retval;
            ImGuiNative.igImBezierCubicCalc(&__retval, p1, p2, p3, p4, t);
            return __retval;
        }
        public static Vector2 ImBezierCubicClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments)
        {
            Vector2 __retval;
            ImGuiNative.igImBezierCubicClosestPoint(&__retval, p1, p2, p3, p4, p, num_segments);
            return __retval;
        }
        public static Vector2 ImBezierCubicClosestPointCasteljau(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol)
        {
            Vector2 __retval;
            ImGuiNative.igImBezierCubicClosestPointCasteljau(&__retval, p1, p2, p3, p4, p, tess_tol);
            return __retval;
        }
        public static Vector2 ImBezierQuadraticCalc(Vector2 p1, Vector2 p2, Vector2 p3, float t)
        {
            Vector2 __retval;
            ImGuiNative.igImBezierQuadraticCalc(&__retval, p1, p2, p3, t);
            return __retval;
        }
        public static void ImBitArrayClearBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNative.igImBitArrayClearBit(native_arr, n);
            }
        }
        public static void ImBitArraySetBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNative.igImBitArraySetBit(native_arr, n);
            }
        }
        public static void ImBitArraySetBitRange(ref uint arr, int n, int n2)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNative.igImBitArraySetBitRange(native_arr, n, n2);
            }
        }
        public static bool ImBitArrayTestBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                byte ret = ImGuiNative.igImBitArrayTestBit(native_arr, n);
                return ret != 0;
            }
        }
        public static bool ImCharIsBlankA(byte c)
        {
            byte ret = ImGuiNative.igImCharIsBlankA(c);
            return ret != 0;
        }
        public static bool ImCharIsBlankW(uint c)
        {
            byte ret = ImGuiNative.igImCharIsBlankW(c);
            return ret != 0;
        }
        public static Vector2 ImClamp(Vector2 v, Vector2 mn, Vector2 mx)
        {
            Vector2 __retval;
            ImGuiNative.igImClamp(&__retval, v, mn, mx);
            return __retval;
        }
        public static float ImDot(Vector2 a, Vector2 b)
        {
            float ret = ImGuiNative.igImDot(a, b);
            return ret;
        }
        public static bool ImFileClose(IntPtr file)
        {
            byte ret = ImGuiNative.igImFileClose(file);
            return ret != 0;
        }
        public static ulong ImFileGetSize(IntPtr file)
        {
            ulong ret = ImGuiNative.igImFileGetSize(file);
            return ret;
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode)
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
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            uint* out_file_size = null;
            int padding_bytes = 0;
            void* ret = ImGuiNative.igImFileLoadToMemory(native_filename, native_mode, out_file_size, padding_bytes);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            if (mode_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_mode);
            }
            return (IntPtr)ret;
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode, out uint out_file_size)
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
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            int padding_bytes = 0;
            fixed (uint* native_out_file_size = &out_file_size)
            {
                void* ret = ImGuiNative.igImFileLoadToMemory(native_filename, native_mode, native_out_file_size, padding_bytes);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_filename);
                }
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_mode);
                }
                return (IntPtr)ret;
            }
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode, out uint out_file_size, int padding_bytes)
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
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            fixed (uint* native_out_file_size = &out_file_size)
            {
                void* ret = ImGuiNative.igImFileLoadToMemory(native_filename, native_mode, native_out_file_size, padding_bytes);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_filename);
                }
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_mode);
                }
                return (IntPtr)ret;
            }
        }
        public static IntPtr ImFileOpen(string filename, string mode)
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
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            IntPtr ret = ImGuiNative.igImFileOpen(native_filename, native_mode);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            if (mode_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_mode);
            }
            return ret;
        }
        public static ulong ImFileRead(IntPtr data, ulong size, ulong count, IntPtr file)
        {
            void* native_data = (void*)data.ToPointer();
            ulong ret = ImGuiNative.igImFileRead(native_data, size, count, file);
            return ret;
        }
        public static ulong ImFileWrite(IntPtr data, ulong size, ulong count, IntPtr file)
        {
            void* native_data = (void*)data.ToPointer();
            ulong ret = ImGuiNative.igImFileWrite(native_data, size, count, file);
            return ret;
        }
        public static float ImFloor(float f)
        {
            float ret = ImGuiNative.igImFloor_Float(f);
            return ret;
        }
        public static Vector2 ImFloor(Vector2 v)
        {
            Vector2 __retval;
            ImGuiNative.igImFloor_Vec2(&__retval, v);
            return __retval;
        }
        public static float ImFloorSigned(float f)
        {
            float ret = ImGuiNative.igImFloorSigned(f);
            return ret;
        }
        public static void ImFontAtlasBuildFinish(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNative.igImFontAtlasBuildFinish(native_atlas);
        }
        public static void ImFontAtlasBuildInit(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNative.igImFontAtlasBuildInit(native_atlas);
        }
        public static void ImFontAtlasBuildMultiplyCalcLookupTable(out byte out_table, float in_multiply_factor)
        {
            fixed (byte* native_out_table = &out_table)
            {
                ImGuiNative.igImFontAtlasBuildMultiplyCalcLookupTable(native_out_table, in_multiply_factor);
            }
        }
        public static void ImFontAtlasBuildMultiplyRectAlpha8(ref byte table, ref byte pixels, int x, int y, int w, int h, int stride)
        {
            fixed (byte* native_table = &table)
            {
                fixed (byte* native_pixels = &pixels)
                {
                    ImGuiNative.igImFontAtlasBuildMultiplyRectAlpha8(native_table, native_pixels, x, y, w, h, stride);
                }
            }
        }
        public static void ImFontAtlasBuildPackCustomRects(ImFontAtlasPtr atlas, IntPtr stbrp_context_opaque)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            void* native_stbrp_context_opaque = (void*)stbrp_context_opaque.ToPointer();
            ImGuiNative.igImFontAtlasBuildPackCustomRects(native_atlas, native_stbrp_context_opaque);
        }
        public static void ImFontAtlasBuildRender32bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, uint in_marker_pixel_value)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            byte* native_in_str;
            int in_str_byteCount = 0;
            if (in_str != null)
            {
                in_str_byteCount = Encoding.UTF8.GetByteCount(in_str);
                if (in_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_in_str = Util.Allocate(in_str_byteCount + 1);
                }
                else
                {
                    byte* native_in_str_stackBytes = stackalloc byte[in_str_byteCount + 1];
                    native_in_str = native_in_str_stackBytes;
                }
                int native_in_str_offset = Util.GetUtf8(in_str, native_in_str, in_str_byteCount);
                native_in_str[native_in_str_offset] = 0;
            }
            else { native_in_str = null; }
            ImGuiNative.igImFontAtlasBuildRender32bppRectFromString(native_atlas, x, y, w, h, native_in_str, in_marker_char, in_marker_pixel_value);
            if (in_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_in_str);
            }
        }
        public static void ImFontAtlasBuildRender8bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, byte in_marker_pixel_value)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            byte* native_in_str;
            int in_str_byteCount = 0;
            if (in_str != null)
            {
                in_str_byteCount = Encoding.UTF8.GetByteCount(in_str);
                if (in_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_in_str = Util.Allocate(in_str_byteCount + 1);
                }
                else
                {
                    byte* native_in_str_stackBytes = stackalloc byte[in_str_byteCount + 1];
                    native_in_str = native_in_str_stackBytes;
                }
                int native_in_str_offset = Util.GetUtf8(in_str, native_in_str, in_str_byteCount);
                native_in_str[native_in_str_offset] = 0;
            }
            else { native_in_str = null; }
            ImGuiNative.igImFontAtlasBuildRender8bppRectFromString(native_atlas, x, y, w, h, native_in_str, in_marker_char, in_marker_pixel_value);
            if (in_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_in_str);
            }
        }
        public static void ImFontAtlasBuildSetupFont(ImFontAtlasPtr atlas, ImFontPtr font, ImFontConfigPtr font_config, float ascent, float descent)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImFont* native_font = font.NativePtr;
            ImFontConfig* native_font_config = font_config.NativePtr;
            ImGuiNative.igImFontAtlasBuildSetupFont(native_atlas, native_font, native_font_config, ascent, descent);
        }
        public static IntPtr* ImFontAtlasGetBuilderForStbTruetype()
        {
            IntPtr* ret = ImGuiNative.igImFontAtlasGetBuilderForStbTruetype();
            return ret;
        }
        public static int ImFormatString(string buf, uint buf_size, string fmt)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
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
            int ret = ImGuiNative.igImFormatString(native_buf, buf_size, native_fmt);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret;
        }
        public static ImGuiDir ImGetDirQuadrantFromDelta(float dx, float dy)
        {
            ImGuiDir ret = ImGuiNative.igImGetDirQuadrantFromDelta(dx, dy);
            return ret;
        }
        public static uint ImHashData(IntPtr data, uint data_size)
        {
            void* native_data = (void*)data.ToPointer();
            uint seed = 0;
            uint ret = ImGuiNative.igImHashData(native_data, data_size, seed);
            return ret;
        }
        public static uint ImHashData(IntPtr data, uint data_size, uint seed)
        {
            void* native_data = (void*)data.ToPointer();
            uint ret = ImGuiNative.igImHashData(native_data, data_size, seed);
            return ret;
        }
        public static uint ImHashStr(string data)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint data_size = 0;
            uint seed = 0;
            uint ret = ImGuiNative.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static uint ImHashStr(string data, uint data_size)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint seed = 0;
            uint ret = ImGuiNative.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static uint ImHashStr(string data, uint data_size, uint seed)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint ret = ImGuiNative.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static float ImInvLength(Vector2 lhs, float fail_value)
        {
            float ret = ImGuiNative.igImInvLength(lhs, fail_value);
            return ret;
        }
        public static bool ImIsPowerOfTwo(int v)
        {
            byte ret = ImGuiNative.igImIsPowerOfTwo_Int(v);
            return ret != 0;
        }
        public static bool ImIsPowerOfTwo(ulong v)
        {
            byte ret = ImGuiNative.igImIsPowerOfTwo_U64(v);
            return ret != 0;
        }
        public static float ImLengthSqr(Vector2 lhs)
        {
            float ret = ImGuiNative.igImLengthSqr_Vec2(lhs);
            return ret;
        }
        public static float ImLengthSqr(Vector4 lhs)
        {
            float ret = ImGuiNative.igImLengthSqr_Vec4(lhs);
            return ret;
        }
        public static Vector2 ImLerp(Vector2 a, Vector2 b, float t)
        {
            Vector2 __retval;
            ImGuiNative.igImLerp_Vec2Float(&__retval, a, b, t);
            return __retval;
        }
        public static Vector2 ImLerp(Vector2 a, Vector2 b, Vector2 t)
        {
            Vector2 __retval;
            ImGuiNative.igImLerp_Vec2Vec2(&__retval, a, b, t);
            return __retval;
        }
        public static Vector4 ImLerp(Vector4 a, Vector4 b, float t)
        {
            Vector4 __retval;
            ImGuiNative.igImLerp_Vec4(&__retval, a, b, t);
            return __retval;
        }
        public static float ImLinearSweep(float current, float target, float speed)
        {
            float ret = ImGuiNative.igImLinearSweep(current, target, speed);
            return ret;
        }
        public static Vector2 ImLineClosestPoint(Vector2 a, Vector2 b, Vector2 p)
        {
            Vector2 __retval;
            ImGuiNative.igImLineClosestPoint(&__retval, a, b, p);
            return __retval;
        }
        public static float ImLog(float x)
        {
            float ret = ImGuiNative.igImLog_Float(x);
            return ret;
        }
        public static double ImLog(double x)
        {
            double ret = ImGuiNative.igImLog_double(x);
            return ret;
        }
        public static Vector2 ImMax(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNative.igImMax(&__retval, lhs, rhs);
            return __retval;
        }
        public static Vector2 ImMin(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNative.igImMin(&__retval, lhs, rhs);
            return __retval;
        }
        public static int ImModPositive(int a, int b)
        {
            int ret = ImGuiNative.igImModPositive(a, b);
            return ret;
        }
        public static Vector2 ImMul(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNative.igImMul(&__retval, lhs, rhs);
            return __retval;
        }
        public static string ImParseFormatFindEnd(string format)
        {
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
            byte* ret = ImGuiNative.igImParseFormatFindEnd(native_format);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return Util.StringFromPtr(ret);
        }
        public static string ImParseFormatFindStart(string format)
        {
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
            byte* ret = ImGuiNative.igImParseFormatFindStart(native_format);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return Util.StringFromPtr(ret);
        }
        public static int ImParseFormatPrecision(string format, int default_value)
        {
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
            int ret = ImGuiNative.igImParseFormatPrecision(native_format, default_value);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret;
        }
        public static string ImParseFormatTrimDecorations(string format, string buf, uint buf_size)
        {
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
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte* ret = ImGuiNative.igImParseFormatTrimDecorations(native_format, native_buf, buf_size);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return Util.StringFromPtr(ret);
        }
        public static float ImPow(float x, float y)
        {
            float ret = ImGuiNative.igImPow_Float(x, y);
            return ret;
        }
        public static double ImPow(double x, double y)
        {
            double ret = ImGuiNative.igImPow_double(x, y);
            return ret;
        }
        public static Vector2 ImRotate(Vector2 v, float cos_a, float sin_a)
        {
            Vector2 __retval;
            ImGuiNative.igImRotate(&__retval, v, cos_a, sin_a);
            return __retval;
        }
        public static float ImRsqrt(float x)
        {
            float ret = ImGuiNative.igImRsqrt_Float(x);
            return ret;
        }
        public static double ImRsqrt(double x)
        {
            double ret = ImGuiNative.igImRsqrt_double(x);
            return ret;
        }
        public static float ImSaturate(float f)
        {
            float ret = ImGuiNative.igImSaturate(f);
            return ret;
        }
        public static float ImSign(float x)
        {
            float ret = ImGuiNative.igImSign_Float(x);
            return ret;
        }
        public static double ImSign(double x)
        {
            double ret = ImGuiNative.igImSign_double(x);
            return ret;
        }
        public static string ImStrdup(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            byte* ret = ImGuiNative.igImStrdup(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
            return Util.StringFromPtr(ret);
        }
        public static string ImStrdupcpy(string dst, ref uint p_dst_size, string str)
        {
            byte* native_dst;
            int dst_byteCount = 0;
            if (dst != null)
            {
                dst_byteCount = Encoding.UTF8.GetByteCount(dst);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst = Util.Allocate(dst_byteCount + 1);
                }
                else
                {
                    byte* native_dst_stackBytes = stackalloc byte[dst_byteCount + 1];
                    native_dst = native_dst_stackBytes;
                }
                int native_dst_offset = Util.GetUtf8(dst, native_dst, dst_byteCount);
                native_dst[native_dst_offset] = 0;
            }
            else { native_dst = null; }
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            fixed (uint* native_p_dst_size = &p_dst_size)
            {
                byte* ret = ImGuiNative.igImStrdupcpy(native_dst, native_p_dst_size, native_str);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_dst);
                }
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_str);
                }
                return Util.StringFromPtr(ret);
            }
        }
        public static int ImStricmp(string str1, string str2)
        {
            byte* native_str1;
            int str1_byteCount = 0;
            if (str1 != null)
            {
                str1_byteCount = Encoding.UTF8.GetByteCount(str1);
                if (str1_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str1 = Util.Allocate(str1_byteCount + 1);
                }
                else
                {
                    byte* native_str1_stackBytes = stackalloc byte[str1_byteCount + 1];
                    native_str1 = native_str1_stackBytes;
                }
                int native_str1_offset = Util.GetUtf8(str1, native_str1, str1_byteCount);
                native_str1[native_str1_offset] = 0;
            }
            else { native_str1 = null; }
            byte* native_str2;
            int str2_byteCount = 0;
            if (str2 != null)
            {
                str2_byteCount = Encoding.UTF8.GetByteCount(str2);
                if (str2_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str2 = Util.Allocate(str2_byteCount + 1);
                }
                else
                {
                    byte* native_str2_stackBytes = stackalloc byte[str2_byteCount + 1];
                    native_str2 = native_str2_stackBytes;
                }
                int native_str2_offset = Util.GetUtf8(str2, native_str2, str2_byteCount);
                native_str2[native_str2_offset] = 0;
            }
            else { native_str2 = null; }
            int ret = ImGuiNative.igImStricmp(native_str1, native_str2);
            if (str1_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str1);
            }
            if (str2_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str2);
            }
            return ret;
        }
        public static int ImStrlenW(IntPtr str)
        {
            ushort* native_str = (ushort*)str.ToPointer();
            int ret = ImGuiNative.igImStrlenW(native_str);
            return ret;
        }
        public static void ImStrncpy(string dst, string src, uint count)
        {
            byte* native_dst;
            int dst_byteCount = 0;
            if (dst != null)
            {
                dst_byteCount = Encoding.UTF8.GetByteCount(dst);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst = Util.Allocate(dst_byteCount + 1);
                }
                else
                {
                    byte* native_dst_stackBytes = stackalloc byte[dst_byteCount + 1];
                    native_dst = native_dst_stackBytes;
                }
                int native_dst_offset = Util.GetUtf8(dst, native_dst, dst_byteCount);
                native_dst[native_dst_offset] = 0;
            }
            else { native_dst = null; }
            byte* native_src;
            int src_byteCount = 0;
            if (src != null)
            {
                src_byteCount = Encoding.UTF8.GetByteCount(src);
                if (src_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_src = Util.Allocate(src_byteCount + 1);
                }
                else
                {
                    byte* native_src_stackBytes = stackalloc byte[src_byteCount + 1];
                    native_src = native_src_stackBytes;
                }
                int native_src_offset = Util.GetUtf8(src, native_src, src_byteCount);
                native_src[native_src_offset] = 0;
            }
            else { native_src = null; }
            ImGuiNative.igImStrncpy(native_dst, native_src, count);
            if (dst_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_dst);
            }
            if (src_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_src);
            }
        }
        public static int ImStrnicmp(string str1, string str2, uint count)
        {
            byte* native_str1;
            int str1_byteCount = 0;
            if (str1 != null)
            {
                str1_byteCount = Encoding.UTF8.GetByteCount(str1);
                if (str1_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str1 = Util.Allocate(str1_byteCount + 1);
                }
                else
                {
                    byte* native_str1_stackBytes = stackalloc byte[str1_byteCount + 1];
                    native_str1 = native_str1_stackBytes;
                }
                int native_str1_offset = Util.GetUtf8(str1, native_str1, str1_byteCount);
                native_str1[native_str1_offset] = 0;
            }
            else { native_str1 = null; }
            byte* native_str2;
            int str2_byteCount = 0;
            if (str2 != null)
            {
                str2_byteCount = Encoding.UTF8.GetByteCount(str2);
                if (str2_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str2 = Util.Allocate(str2_byteCount + 1);
                }
                else
                {
                    byte* native_str2_stackBytes = stackalloc byte[str2_byteCount + 1];
                    native_str2 = native_str2_stackBytes;
                }
                int native_str2_offset = Util.GetUtf8(str2, native_str2, str2_byteCount);
                native_str2[native_str2_offset] = 0;
            }
            else { native_str2 = null; }
            int ret = ImGuiNative.igImStrnicmp(native_str1, native_str2, count);
            if (str1_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str1);
            }
            if (str2_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str2);
            }
            return ret;
        }
        public static string ImStrSkipBlank(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            byte* ret = ImGuiNative.igImStrSkipBlank(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
            return Util.StringFromPtr(ret);
        }
        public static void ImStrTrimBlanks(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.igImStrTrimBlanks(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
        public static string ImTextCharToUtf8(out byte out_buf, uint c)
        {
            fixed (byte* native_out_buf = &out_buf)
            {
                byte* ret = ImGuiNative.igImTextCharToUtf8(native_out_buf, c);
                return Util.StringFromPtr(ret);
            }
        }
        public static float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
        {
            float ret = ImGuiNative.igImTriangleArea(a, b, c);
            return ret;
        }
        public static void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, out float out_u, out float out_v, out float out_w)
        {
            fixed (float* native_out_u = &out_u)
            {
                fixed (float* native_out_v = &out_v)
                {
                    fixed (float* native_out_w = &out_w)
                    {
                        ImGuiNative.igImTriangleBarycentricCoords(a, b, c, p, native_out_u, native_out_v, native_out_w);
                    }
                }
            }
        }
        public static Vector2 ImTriangleClosestPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
        {
            Vector2 __retval;
            ImGuiNative.igImTriangleClosestPoint(&__retval, a, b, c, p);
            return __retval;
        }
        public static bool ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
        {
            byte ret = ImGuiNative.igImTriangleContainsPoint(a, b, c, p);
            return ret != 0;
        }
        public static int ImUpperPowerOfTwo(int v)
        {
            int ret = ImGuiNative.igImUpperPowerOfTwo(v);
            return ret;
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
        public static void Initialize(IntPtr context)
        {
            ImGuiNative.igInitialize(context);
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
        public static bool InputTextEx(string label, string hint, string buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags)
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
            byte* native_hint;
            int hint_byteCount = 0;
            if (hint != null)
            {
                hint_byteCount = Encoding.UTF8.GetByteCount(hint);
                if (hint_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_hint = Util.Allocate(hint_byteCount + 1);
                }
                else
                {
                    byte* native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
                    native_hint = native_hint_stackBytes;
                }
                int native_hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
                native_hint[native_hint_offset] = 0;
            }
            else { native_hint = null; }
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            ImGuiInputTextCallback callback = null;
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextEx(native_label, native_hint, native_buf, buf_size, size_arg, flags, callback, user_data);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (hint_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_hint);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return ret != 0;
        }
        public static bool InputTextEx(string label, string hint, string buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
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
            byte* native_hint;
            int hint_byteCount = 0;
            if (hint != null)
            {
                hint_byteCount = Encoding.UTF8.GetByteCount(hint);
                if (hint_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_hint = Util.Allocate(hint_byteCount + 1);
                }
                else
                {
                    byte* native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
                    native_hint = native_hint_stackBytes;
                }
                int native_hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
                native_hint[native_hint_offset] = 0;
            }
            else { native_hint = null; }
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            void* user_data = null;
            byte ret = ImGuiNative.igInputTextEx(native_label, native_hint, native_buf, buf_size, size_arg, flags, callback, user_data);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (hint_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_hint);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return ret != 0;
        }
        public static bool InputTextEx(string label, string hint, string buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data)
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
            byte* native_hint;
            int hint_byteCount = 0;
            if (hint != null)
            {
                hint_byteCount = Encoding.UTF8.GetByteCount(hint);
                if (hint_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_hint = Util.Allocate(hint_byteCount + 1);
                }
                else
                {
                    byte* native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
                    native_hint = native_hint_stackBytes;
                }
                int native_hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
                native_hint[native_hint_offset] = 0;
            }
            else { native_hint = null; }
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            void* native_user_data = (void*)user_data.ToPointer();
            byte ret = ImGuiNative.igInputTextEx(native_label, native_hint, native_buf, buf_size, size_arg, flags, callback, native_user_data);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (hint_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_hint);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
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
        public static bool IsActiveIdUsingKey(ImGuiKey key)
        {
            byte ret = ImGuiNative.igIsActiveIdUsingKey(key);
            return ret != 0;
        }
        public static bool IsActiveIdUsingNavDir(ImGuiDir dir)
        {
            byte ret = ImGuiNative.igIsActiveIdUsingNavDir(dir);
            return ret != 0;
        }
        public static bool IsActiveIdUsingNavInput(ImGuiNavInput input)
        {
            byte ret = ImGuiNative.igIsActiveIdUsingNavInput(input);
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
        public static bool IsClippedEx(ImRect bb, uint id, bool clip_even_when_logged)
        {
            byte native_clip_even_when_logged = clip_even_when_logged ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsClippedEx(bb, id, native_clip_even_when_logged);
            return ret != 0;
        }
        public static bool IsDragDropPayloadBeingAccepted()
        {
            byte ret = ImGuiNative.igIsDragDropPayloadBeingAccepted();
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
        public static bool IsItemToggledSelection()
        {
            byte ret = ImGuiNative.igIsItemToggledSelection();
            return ret != 0;
        }
        public static bool IsItemVisible()
        {
            byte ret = ImGuiNative.igIsItemVisible();
            return ret != 0;
        }
        public static bool IsKeyDown(int user_key_index)
        {
            byte ret = ImGuiNative.igIsKeyDown(user_key_index);
            return ret != 0;
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
        public static bool IsKeyPressedMap(ImGuiKey key)
        {
            byte repeat = 1;
            byte ret = ImGuiNative.igIsKeyPressedMap(key, repeat);
            return ret != 0;
        }
        public static bool IsKeyPressedMap(ImGuiKey key, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsKeyPressedMap(key, native_repeat);
            return ret != 0;
        }
        public static bool IsKeyReleased(int user_key_index)
        {
            byte ret = ImGuiNative.igIsKeyReleased(user_key_index);
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
        public static bool IsMouseDragPastThreshold(ImGuiMouseButton button)
        {
            float lock_threshold = -1.0f;
            byte ret = ImGuiNative.igIsMouseDragPastThreshold(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold)
        {
            byte ret = ImGuiNative.igIsMouseDragPastThreshold(button, lock_threshold);
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
        public static bool IsNavInputDown(ImGuiNavInput n)
        {
            byte ret = ImGuiNative.igIsNavInputDown(n);
            return ret != 0;
        }
        public static bool IsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm)
        {
            byte ret = ImGuiNative.igIsNavInputTest(n, rm);
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
        public static bool IsPopupOpen(uint id, ImGuiPopupFlags popup_flags)
        {
            byte ret = ImGuiNative.igIsPopupOpen_ID(id, popup_flags);
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
        public static bool IsWindowAbove(ImGuiWindowPtr potential_above, ImGuiWindowPtr potential_below)
        {
            ImGuiWindow* native_potential_above = potential_above.NativePtr;
            ImGuiWindow* native_potential_below = potential_below.NativePtr;
            byte ret = ImGuiNative.igIsWindowAbove(native_potential_above, native_potential_below);
            return ret != 0;
        }
        public static bool IsWindowAppearing()
        {
            byte ret = ImGuiNative.igIsWindowAppearing();
            return ret != 0;
        }
        public static bool IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent, bool dock_hierarchy)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_potential_parent = potential_parent.NativePtr;
            byte native_dock_hierarchy = dock_hierarchy ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.igIsWindowChildOf(native_window, native_potential_parent, native_dock_hierarchy);
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
        public static bool IsWindowNavFocusable(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte ret = ImGuiNative.igIsWindowNavFocusable(native_window);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id)
        {
            ImRect* nav_bb = null;
            ImGuiItemFlags extra_flags = (ImGuiItemFlags)0;
            byte ret = ImGuiNative.igItemAdd(bb, id, nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb)
        {
            ImRect* native_nav_bb = nav_bb.NativePtr;
            ImGuiItemFlags extra_flags = (ImGuiItemFlags)0;
            byte ret = ImGuiNative.igItemAdd(bb, id, native_nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb, ImGuiItemFlags extra_flags)
        {
            ImRect* native_nav_bb = nav_bb.NativePtr;
            byte ret = ImGuiNative.igItemAdd(bb, id, native_nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemHoverable(ImRect bb, uint id)
        {
            byte ret = ImGuiNative.igItemHoverable(bb, id);
            return ret != 0;
        }
        public static void ItemInputable(ImGuiWindowPtr window, uint id)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igItemInputable(native_window, id);
        }
        public static void ItemSize(Vector2 size)
        {
            float text_baseline_y = -1.0f;
            ImGuiNative.igItemSize_Vec2(size, text_baseline_y);
        }
        public static void ItemSize(Vector2 size, float text_baseline_y)
        {
            ImGuiNative.igItemSize_Vec2(size, text_baseline_y);
        }
        public static void ItemSize(ImRect bb)
        {
            float text_baseline_y = -1.0f;
            ImGuiNative.igItemSize_Rect(bb, text_baseline_y);
        }
        public static void ItemSize(ImRect bb, float text_baseline_y)
        {
            ImGuiNative.igItemSize_Rect(bb, text_baseline_y);
        }
        public static void KeepAliveID(uint id)
        {
            ImGuiNative.igKeepAliveID(id);
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
        public static void LogBegin(ImGuiLogType type, int auto_open_depth)
        {
            ImGuiNative.igLogBegin(type, auto_open_depth);
        }
        public static void LogButtons()
        {
            ImGuiNative.igLogButtons();
        }
        public static void LogFinish()
        {
            ImGuiNative.igLogFinish();
        }
        public static void LogRenderedText(ref Vector2 ref_pos, string text)
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
            fixed (Vector2* native_ref_pos = &ref_pos)
            {
                ImGuiNative.igLogRenderedText(native_ref_pos, native_text, native_text_end);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text);
                }
            }
        }
        public static void LogSetNextTextDecoration(string prefix, string suffix)
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
            byte* native_suffix;
            int suffix_byteCount = 0;
            if (suffix != null)
            {
                suffix_byteCount = Encoding.UTF8.GetByteCount(suffix);
                if (suffix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_suffix = Util.Allocate(suffix_byteCount + 1);
                }
                else
                {
                    byte* native_suffix_stackBytes = stackalloc byte[suffix_byteCount + 1];
                    native_suffix = native_suffix_stackBytes;
                }
                int native_suffix_offset = Util.GetUtf8(suffix, native_suffix, suffix_byteCount);
                native_suffix[native_suffix_offset] = 0;
            }
            else { native_suffix = null; }
            ImGuiNative.igLogSetNextTextDecoration(native_prefix, native_suffix);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
            if (suffix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_suffix);
            }
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
        public static void LogToBuffer()
        {
            int auto_open_depth = -1;
            ImGuiNative.igLogToBuffer(auto_open_depth);
        }
        public static void LogToBuffer(int auto_open_depth)
        {
            ImGuiNative.igLogToBuffer(auto_open_depth);
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
        public static void MarkIniSettingsDirty()
        {
            ImGuiNative.igMarkIniSettingsDirty_Nil();
        }
        public static void MarkIniSettingsDirty(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igMarkIniSettingsDirty_WindowPtr(native_window);
        }
        public static void MarkItemEdited(uint id)
        {
            ImGuiNative.igMarkItemEdited(id);
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
        public static bool MenuItemEx(string label, string icon)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte* native_shortcut = null;
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.igMenuItemEx(native_label, native_icon, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
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
            byte ret = ImGuiNative.igMenuItemEx(native_label, native_icon, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut, bool selected)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
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
            byte ret = ImGuiNative.igMenuItemEx(native_label, native_icon, native_shortcut, native_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut, bool selected, bool enabled)
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
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
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
            byte ret = ImGuiNative.igMenuItemEx(native_label, native_icon, native_shortcut, native_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static void NavInitRequestApplyResult()
        {
            ImGuiNative.igNavInitRequestApplyResult();
        }
        public static void NavInitWindow(ImGuiWindowPtr window, bool force_reinit)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_force_reinit = force_reinit ? (byte)1 : (byte)0;
            ImGuiNative.igNavInitWindow(native_window, native_force_reinit);
        }
        public static void NavMoveRequestApplyResult()
        {
            ImGuiNative.igNavMoveRequestApplyResult();
        }
        public static bool NavMoveRequestButNoResultYet()
        {
            byte ret = ImGuiNative.igNavMoveRequestButNoResultYet();
            return ret != 0;
        }
        public static void NavMoveRequestCancel()
        {
            ImGuiNative.igNavMoveRequestCancel();
        }
        public static void NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags)
        {
            ImGuiNative.igNavMoveRequestForward(move_dir, clip_dir, move_flags);
        }
        public static void NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags)
        {
            ImGuiNative.igNavMoveRequestSubmit(move_dir, clip_dir, move_flags);
        }
        public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags move_flags)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igNavMoveRequestTryWrapping(native_window, move_flags);
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
        public static void OpenPopupEx(uint id)
        {
            ImGuiPopupFlags popup_flags = ImGuiPopupFlags.None;
            ImGuiNative.igOpenPopupEx(id, popup_flags);
        }
        public static void OpenPopupEx(uint id, ImGuiPopupFlags popup_flags)
        {
            ImGuiNative.igOpenPopupEx(id, popup_flags);
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
        public static void PopColumnsBackground()
        {
            ImGuiNative.igPopColumnsBackground();
        }
        public static void PopFocusScope()
        {
            ImGuiNative.igPopFocusScope();
        }
        public static void PopFont()
        {
            ImGuiNative.igPopFont();
        }
        public static void PopID()
        {
            ImGuiNative.igPopID();
        }
        public static void PopItemFlag()
        {
            ImGuiNative.igPopItemFlag();
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
        public static void PushColumnClipRect(int column_index)
        {
            ImGuiNative.igPushColumnClipRect(column_index);
        }
        public static void PushColumnsBackground()
        {
            ImGuiNative.igPushColumnsBackground();
        }
        public static void PushFocusScope(uint id)
        {
            ImGuiNative.igPushFocusScope(id);
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
        public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
        {
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            ImGuiNative.igPushItemFlag(option, native_enabled);
        }
        public static void PushItemWidth(float item_width)
        {
            ImGuiNative.igPushItemWidth(item_width);
        }
        public static void PushMultiItemsWidths(int components, float width_full)
        {
            ImGuiNative.igPushMultiItemsWidths(components, width_full);
        }
        public static void PushOverrideID(uint id)
        {
            ImGuiNative.igPushOverrideID(id);
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
        public static void RemoveContextHook(IntPtr context, uint hook_to_remove)
        {
            ImGuiNative.igRemoveContextHook(context, hook_to_remove);
        }
        public static void Render()
        {
            ImGuiNative.igRender();
        }
        public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            float scale = 1.0f;
            ImGuiNative.igRenderArrow(native_draw_list, pos, col, dir, scale);
        }
        public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderArrow(native_draw_list, pos, col, dir, scale);
        }
        public static void RenderArrowDockMenu(ImDrawListPtr draw_list, Vector2 p_min, float sz, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderArrowDockMenu(native_draw_list, p_min, sz, col);
        }
        public static void RenderArrowPointingAt(ImDrawListPtr draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderArrowPointingAt(native_draw_list, pos, half_sz, direction, col);
        }
        public static void RenderBullet(ImDrawListPtr draw_list, Vector2 pos, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderBullet(native_draw_list, pos, col);
        }
        public static void RenderCheckMark(ImDrawListPtr draw_list, Vector2 pos, uint col, float sz)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderCheckMark(native_draw_list, pos, col, sz);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col)
        {
            byte border = 1;
            float rounding = 0.0f;
            ImGuiNative.igRenderFrame(p_min, p_max, fill_col, border, rounding);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool border)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            float rounding = 0.0f;
            ImGuiNative.igRenderFrame(p_min, p_max, fill_col, native_border, rounding);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool border, float rounding)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiNative.igRenderFrame(p_min, p_max, fill_col, native_border, rounding);
        }
        public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max)
        {
            float rounding = 0.0f;
            ImGuiNative.igRenderFrameBorder(p_min, p_max, rounding);
        }
        public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding)
        {
            ImGuiNative.igRenderFrameBorder(p_min, p_max, rounding);
        }
        public static void RenderMouseCursor(ImDrawListPtr draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderMouseCursor(native_draw_list, pos, scale, mouse_cursor, col_fill, col_border, col_shadow);
        }
        public static void RenderNavHighlight(ImRect bb, uint id)
        {
            ImGuiNavHighlightFlags flags = ImGuiNavHighlightFlags.TypeDefault;
            ImGuiNative.igRenderNavHighlight(bb, id, flags);
        }
        public static void RenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags)
        {
            ImGuiNative.igRenderNavHighlight(bb, id, flags);
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
        public static void RenderRectFilledRangeH(ImDrawListPtr draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderRectFilledRangeH(native_draw_list, rect, col, x_start_norm, x_end_norm, rounding);
        }
        public static void RenderRectFilledWithHole(ImDrawListPtr draw_list, ImRect outer, ImRect inner, uint col, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igRenderRectFilledWithHole(native_draw_list, outer, inner, col, rounding);
        }
        public static void RenderText(Vector2 pos, string text)
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
            byte hide_text_after_hash = 1;
            ImGuiNative.igRenderText(pos, native_text, native_text_end, hide_text_after_hash);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
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
        public static void ScaleWindowsInViewport(ImGuiViewportPPtr viewport, float scale)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igScaleWindowsInViewport(native_viewport, scale);
        }
        public static void Scrollbar(ImGuiAxis axis)
        {
            ImGuiNative.igScrollbar(axis);
        }
        public static bool ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref float p_scroll_v, float avail_v, float contents_v, ImDrawFlags flags)
        {
            fixed (float* native_p_scroll_v = &p_scroll_v)
            {
                byte ret = ImGuiNative.igScrollbarEx(bb, id, axis, native_p_scroll_v, avail_v, contents_v, flags);
                return ret != 0;
            }
        }
        public static Vector2 ScrollToBringRectIntoView(ImGuiWindowPtr window, ImRect item_rect)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igScrollToBringRectIntoView(&__retval, native_window, item_rect);
            return __retval;
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
        public static void SeparatorEx(ImGuiSeparatorFlags flags)
        {
            ImGuiNative.igSeparatorEx(flags);
        }
        public static void SetActiveID(uint id, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetActiveID(id, native_window);
        }
        public static void SetActiveIdUsingNavAndKeys()
        {
            ImGuiNative.igSetActiveIdUsingNavAndKeys();
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
        public static void SetCurrentFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNative.igSetCurrentFont(native_font);
        }
        public static void SetCurrentViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igSetCurrentViewport(native_window, native_viewport);
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
        public static void SetFocusID(uint id, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetFocusID(id, native_window);
        }
        public static void SetHoveredID(uint id)
        {
            ImGuiNative.igSetHoveredID(id);
        }
        public static void SetItemAllowOverlap()
        {
            ImGuiNative.igSetItemAllowOverlap();
        }
        public static void SetItemDefaultFocus()
        {
            ImGuiNative.igSetItemDefaultFocus();
        }
        public static void SetItemUsingMouseWheel()
        {
            ImGuiNative.igSetItemUsingMouseWheel();
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
        public static void SetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect)
        {
            ImGuiNative.igSetLastItemData(item_id, in_flags, status_flags, item_rect);
        }
        public static void SetMouseCursor(ImGuiMouseCursor cursor_type)
        {
            ImGuiNative.igSetMouseCursor(cursor_type);
        }
        public static void SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel)
        {
            ImGuiNative.igSetNavID(id, nav_layer, focus_scope_id, rect_rel);
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
        public static void SetNextWindowScroll(Vector2 scroll)
        {
            ImGuiNative.igSetNextWindowScroll(scroll);
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
            IntPtr custom_callback = IntPtr.Zero;
            void* custom_callback_data = null;
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, IntPtr custom_callback)
        {
            void* custom_callback_data = null;
            ImGuiNative.igSetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, IntPtr custom_callback, IntPtr custom_callback_data)
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
        public static void SetScrollFromPosX(ImGuiWindowPtr window, float local_x, float center_x_ratio)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetScrollFromPosX_WindowPtr(native_window, local_x, center_x_ratio);
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
        public static void SetScrollFromPosY(ImGuiWindowPtr window, float local_y, float center_y_ratio)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetScrollFromPosY_WindowPtr(native_window, local_y, center_y_ratio);
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
        public static void SetScrollX(ImGuiWindowPtr window, float scroll_x)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetScrollX_WindowPtr(native_window, scroll_x);
        }
        public static void SetScrollY(float scroll_y)
        {
            ImGuiNative.igSetScrollY_Float(scroll_y);
        }
        public static void SetScrollY(ImGuiWindowPtr window, float scroll_y)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetScrollY_WindowPtr(native_window, scroll_y);
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
        public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, ImRect clip_rect)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetWindowClipRectBeforeSetChannel(native_window, clip_rect);
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
        public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowCollapsed_WindowPtr(native_window, native_collapsed, cond);
        }
        public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.igSetWindowCollapsed_WindowPtr(native_window, native_collapsed, cond);
        }
        public static void SetWindowDock(ImGuiWindowPtr window, uint dock_id, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetWindowDock(native_window, dock_id, cond);
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
        public static void SetWindowHitTestHole(ImGuiWindowPtr window, Vector2 pos, Vector2 size)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetWindowHitTestHole(native_window, pos, size);
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
        public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowPos_WindowPtr(native_window, pos, cond);
        }
        public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetWindowPos_WindowPtr(native_window, pos, cond);
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
        public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.igSetWindowSize_WindowPtr(native_window, size, cond);
        }
        public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igSetWindowSize_WindowPtr(native_window, size, cond);
        }
        public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igShadeVertsLinearColorGradientKeepAlpha(native_draw_list, vert_start_idx, vert_end_idx, gradient_p0, gradient_p1, col0, col1);
        }
        public static void ShadeVertsLinearUV(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, bool clamp)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte native_clamp = clamp ? (byte)1 : (byte)0;
            ImGuiNative.igShadeVertsLinearUV(native_draw_list, vert_start_idx, vert_end_idx, a, b, uv_a, uv_b, native_clamp);
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
        public static void ShowFontAtlas(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNative.igShowFontAtlas(native_atlas);
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
        public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float width_excess)
        {
            ImGuiShrinkWidthItem* native_items = items.NativePtr;
            ImGuiNative.igShrinkWidths(native_items, count, width_excess);
        }
        public static void Shutdown(IntPtr context)
        {
            ImGuiNative.igShutdown(context);
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
        public static bool SliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, IntPtr p_v, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags, ImRectPtr out_grab_bb)
        {
            void* native_p_v = (void*)p_v.ToPointer();
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
            ImRect* native_out_grab_bb = out_grab_bb.NativePtr;
            byte ret = ImGuiNative.igSliderBehavior(bb, id, data_type, native_p_v, native_p_min, native_p_max, native_format, flags, native_out_grab_bb);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
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
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2)
        {
            float hover_extend = 0.0f;
            float hover_visibility_delay = 0.0f;
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNative.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay);
                    return ret != 0;
                }
            }
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend)
        {
            float hover_visibility_delay = 0.0f;
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNative.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay);
                    return ret != 0;
                }
            }
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay)
        {
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNative.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay);
                    return ret != 0;
                }
            }
        }
        public static void StartMouseMovingWindow(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igStartMouseMovingWindow(native_window);
        }
        public static void StartMouseMovingWindowOrNode(ImGuiWindowPtr window, ImGuiDockNodePtr node, bool undock_floating_node)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiDockNode* native_node = node.NativePtr;
            byte native_undock_floating_node = undock_floating_node ? (byte)1 : (byte)0;
            ImGuiNative.igStartMouseMovingWindowOrNode(native_window, native_node, native_undock_floating_node);
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
        public static void TabBarAddTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindowPtr window)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNative.igTabBarAddTab(native_tab_bar, tab_flags, native_window);
        }
        public static void TabBarCloseTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNative.igTabBarCloseTab(native_tab_bar, native_tab);
        }
        public static ImGuiTabItemPtr TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBarPtr tab_bar)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* ret = ImGuiNative.igTabBarFindMostRecentlySelectedTabForActiveWindow(native_tab_bar);
            return new ImGuiTabItemPtr(ret);
        }
        public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tab_bar, uint tab_id)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* ret = ImGuiNative.igTabBarFindTabByID(native_tab_bar, tab_id);
            return new ImGuiTabItemPtr(ret);
        }
        public static bool TabBarProcessReorder(ImGuiTabBarPtr tab_bar)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            byte ret = ImGuiNative.igTabBarProcessReorder(native_tab_bar);
            return ret != 0;
        }
        public static void TabBarQueueReorder(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, int offset)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNative.igTabBarQueueReorder(native_tab_bar, native_tab, offset);
        }
        public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, Vector2 mouse_pos)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNative.igTabBarQueueReorderFromMousePos(native_tab_bar, native_tab, mouse_pos);
        }
        public static void TabBarRemoveTab(ImGuiTabBarPtr tab_bar, uint tab_id)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiNative.igTabBarRemoveTab(native_tab_bar, tab_id);
        }
        public static void TabItemBackground(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.igTabItemBackground(native_draw_list, bb, flags, col);
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
        public static Vector2 TabItemCalcSize(string label, bool has_close_button)
        {
            Vector2 __retval;
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
            byte native_has_close_button = has_close_button ? (byte)1 : (byte)0;
            ImGuiNative.igTabItemCalcSize(&__retval, native_label, native_has_close_button);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return __retval;
        }
        public static bool TabItemEx(ImGuiTabBarPtr tab_bar, string label, ref bool p_open, ImGuiTabItemFlags flags, ImGuiWindowPtr docked_window)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
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
            ImGuiWindow* native_docked_window = docked_window.NativePtr;
            byte ret = ImGuiNative.igTabItemEx(native_tab_bar, native_label, native_p_open, flags, native_docked_window);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static void TabItemLabelAndCloseButton(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, string label, uint tab_id, uint close_button_id, bool is_contents_visible, ref bool out_just_closed, ref bool out_text_clipped)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
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
            byte native_is_contents_visible = is_contents_visible ? (byte)1 : (byte)0;
            byte native_out_just_closed_val = out_just_closed ? (byte)1 : (byte)0;
            byte* native_out_just_closed = &native_out_just_closed_val;
            byte native_out_text_clipped_val = out_text_clipped ? (byte)1 : (byte)0;
            byte* native_out_text_clipped = &native_out_text_clipped_val;
            ImGuiNative.igTabItemLabelAndCloseButton(native_draw_list, bb, flags, frame_padding, native_label, tab_id, close_button_id, native_is_contents_visible, native_out_just_closed, native_out_text_clipped);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            out_just_closed = native_out_just_closed_val != 0;
            out_text_clipped = native_out_text_clipped_val != 0;
        }
        public static void TableBeginApplyRequests(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableBeginApplyRequests(native_table);
        }
        public static void TableBeginCell(ImGuiTablePtr table, int column_n)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableBeginCell(native_table, column_n);
        }
        public static void TableBeginInitMemory(ImGuiTablePtr table, int columns_count)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableBeginInitMemory(native_table, columns_count);
        }
        public static void TableBeginRow(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableBeginRow(native_table);
        }
        public static void TableDrawBorders(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableDrawBorders(native_table);
        }
        public static void TableDrawContextMenu(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableDrawContextMenu(native_table);
        }
        public static void TableEndCell(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableEndCell(native_table);
        }
        public static void TableEndRow(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableEndRow(native_table);
        }
        public static ImGuiTablePtr TableFindByID(uint id)
        {
            ImGuiTable* ret = ImGuiNative.igTableFindByID(id);
            return new ImGuiTablePtr(ret);
        }
        public static void TableFixColumnSortDirection(ImGuiTablePtr table, ImGuiTableColumnPtr column)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiTableColumn* native_column = column.NativePtr;
            ImGuiNative.igTableFixColumnSortDirection(native_table, native_column);
        }
        public static void TableGcCompactSettings()
        {
            ImGuiNative.igTableGcCompactSettings();
        }
        public static void TableGcCompactTransientBuffers(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableGcCompactTransientBuffers_TablePtr(native_table);
        }
        public static void TableGcCompactTransientBuffers(ImGuiTableTempDataPtr table)
        {
            ImGuiTableTempData* native_table = table.NativePtr;
            ImGuiNative.igTableGcCompactTransientBuffers_TableTempDataPtr(native_table);
        }
        public static ImGuiTableSettingsPtr TableGetBoundSettings(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiTableSettings* ret = ImGuiNative.igTableGetBoundSettings(native_table);
            return new ImGuiTableSettingsPtr(ret);
        }
        public static ImRect TableGetCellBgRect(ImGuiTablePtr table, int column_n)
        {
            ImRect __retval;
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableGetCellBgRect(&__retval, native_table, column_n);
            return __retval;
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
        public static string TableGetColumnName(ImGuiTablePtr table, int column_n)
        {
            ImGuiTable* native_table = table.NativePtr;
            byte* ret = ImGuiNative.igTableGetColumnName_TablePtr(native_table, column_n);
            return Util.StringFromPtr(ret);
        }
        public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column)
        {
            ImGuiTableColumn* native_column = column.NativePtr;
            ImGuiSortDirection ret = ImGuiNative.igTableGetColumnNextSortDirection(native_column);
            return ret;
        }
        public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n)
        {
            ImGuiTable* native_table = table.NativePtr;
            int instance_no = 0;
            uint ret = ImGuiNative.igTableGetColumnResizeID(native_table, column_n, instance_no);
            return ret;
        }
        public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n, int instance_no)
        {
            ImGuiTable* native_table = table.NativePtr;
            uint ret = ImGuiNative.igTableGetColumnResizeID(native_table, column_n, instance_no);
            return ret;
        }
        public static float TableGetColumnWidthAuto(ImGuiTablePtr table, ImGuiTableColumnPtr column)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiTableColumn* native_column = column.NativePtr;
            float ret = ImGuiNative.igTableGetColumnWidthAuto(native_table, native_column);
            return ret;
        }
        public static float TableGetHeaderRowHeight()
        {
            float ret = ImGuiNative.igTableGetHeaderRowHeight();
            return ret;
        }
        public static int TableGetHoveredColumn()
        {
            int ret = ImGuiNative.igTableGetHoveredColumn();
            return ret;
        }
        public static float TableGetMaxColumnWidth(ImGuiTablePtr table, int column_n)
        {
            ImGuiTable* native_table = table.NativePtr;
            float ret = ImGuiNative.igTableGetMaxColumnWidth(native_table, column_n);
            return ret;
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
        public static void TableLoadSettings(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableLoadSettings(native_table);
        }
        public static void TableMergeDrawChannels(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableMergeDrawChannels(native_table);
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
        public static void TableOpenContextMenu()
        {
            int column_n = -1;
            ImGuiNative.igTableOpenContextMenu(column_n);
        }
        public static void TableOpenContextMenu(int column_n)
        {
            ImGuiNative.igTableOpenContextMenu(column_n);
        }
        public static void TablePopBackgroundChannel()
        {
            ImGuiNative.igTablePopBackgroundChannel();
        }
        public static void TablePushBackgroundChannel()
        {
            ImGuiNative.igTablePushBackgroundChannel();
        }
        public static void TableRemove(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableRemove(native_table);
        }
        public static void TableResetSettings(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableResetSettings(native_table);
        }
        public static void TableSaveSettings(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSaveSettings(native_table);
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
        public static void TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs)
        {
            byte native_append_to_sort_specs = append_to_sort_specs ? (byte)1 : (byte)0;
            ImGuiNative.igTableSetColumnSortDirection(column_n, sort_direction, native_append_to_sort_specs);
        }
        public static void TableSetColumnWidth(int column_n, float width)
        {
            ImGuiNative.igTableSetColumnWidth(column_n, width);
        }
        public static void TableSetColumnWidthAutoAll(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSetColumnWidthAutoAll(native_table);
        }
        public static void TableSetColumnWidthAutoSingle(ImGuiTablePtr table, int column_n)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSetColumnWidthAutoSingle(native_table, column_n);
        }
        public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columns_count)
        {
            ImGuiTableSettings* ret = ImGuiNative.igTableSettingsCreate(id, columns_count);
            return new ImGuiTableSettingsPtr(ret);
        }
        public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id)
        {
            ImGuiTableSettings* ret = ImGuiNative.igTableSettingsFindByID(id);
            return new ImGuiTableSettingsPtr(ret);
        }
        public static void TableSettingsInstallHandler(IntPtr context)
        {
            ImGuiNative.igTableSettingsInstallHandler(context);
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
        public static void TableSetupDrawChannels(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSetupDrawChannels(native_table);
        }
        public static void TableSetupScrollFreeze(int cols, int rows)
        {
            ImGuiNative.igTableSetupScrollFreeze(cols, rows);
        }
        public static void TableSortSpecsBuild(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSortSpecsBuild(native_table);
        }
        public static void TableSortSpecsSanitize(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableSortSpecsSanitize(native_table);
        }
        public static void TableUpdateBorders(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableUpdateBorders(native_table);
        }
        public static void TableUpdateColumnsWeightFromWidth(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableUpdateColumnsWeightFromWidth(native_table);
        }
        public static void TableUpdateLayout(ImGuiTablePtr table)
        {
            ImGuiTable* native_table = table.NativePtr;
            ImGuiNative.igTableUpdateLayout(native_table);
        }
        public static bool TempInputIsActive(uint id)
        {
            byte ret = ImGuiNative.igTempInputIsActive(id);
            return ret != 0;
        }
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format)
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
            void* p_clamp_min = null;
            void* p_clamp_max = null;
            byte ret = ImGuiNative.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, p_clamp_min, p_clamp_max);
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
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format, IntPtr p_clamp_min)
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
            void* native_p_clamp_min = (void*)p_clamp_min.ToPointer();
            void* p_clamp_max = null;
            byte ret = ImGuiNative.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, p_clamp_max);
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
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format, IntPtr p_clamp_min, IntPtr p_clamp_max)
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
            void* native_p_clamp_min = (void*)p_clamp_min.ToPointer();
            void* native_p_clamp_max = (void*)p_clamp_max.ToPointer();
            byte ret = ImGuiNative.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, native_p_clamp_max);
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
        public static bool TempInputText(ImRect bb, uint id, string label, string buf, int buf_size, ImGuiInputTextFlags flags)
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
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte ret = ImGuiNative.igTempInputText(bb, id, native_label, native_buf, buf_size, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return ret != 0;
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
        public static void TextEx(string text)
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
            ImGuiTextFlags flags = (ImGuiTextFlags)0;
            ImGuiNative.igTextEx(native_text, native_text_end, flags);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
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
        public static void TranslateWindowsInViewport(ImGuiViewportPPtr viewport, Vector2 old_pos, Vector2 new_pos)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNative.igTranslateWindowsInViewport(native_viewport, old_pos, new_pos);
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
        public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, string label)
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
            byte* native_label_end = null;
            byte ret = ImGuiNative.igTreeNodeBehavior(id, flags, native_label, native_label_end);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TreeNodeBehaviorIsOpen(uint id)
        {
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.igTreeNodeBehaviorIsOpen(id, flags);
            return ret != 0;
        }
        public static bool TreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags)
        {
            byte ret = ImGuiNative.igTreeNodeBehaviorIsOpen(id, flags);
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
        public static void TreePushOverrideID(uint id)
        {
            ImGuiNative.igTreePushOverrideID(id);
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
        public static void UpdateHoveredWindowAndCaptureFlags()
        {
            ImGuiNative.igUpdateHoveredWindowAndCaptureFlags();
        }
        public static void UpdateMouseMovingWindowEndFrame()
        {
            ImGuiNative.igUpdateMouseMovingWindowEndFrame();
        }
        public static void UpdateMouseMovingWindowNewFrame()
        {
            ImGuiNative.igUpdateMouseMovingWindowNewFrame();
        }
        public static void UpdatePlatformWindows()
        {
            ImGuiNative.igUpdatePlatformWindows();
        }
        public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parent_window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_parent_window = parent_window.NativePtr;
            ImGuiNative.igUpdateWindowParentAndRootLinks(native_window, flags, native_parent_window);
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
