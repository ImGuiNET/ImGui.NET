using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImNodesNET
{
    public static unsafe partial class ImNodes
    {
        public static void BeginInputAttribute(int id)
        {
            PinShape shape = PinShape._CircleFilled;
            ImNodesNative.imnodes_BeginInputAttribute(id, shape);
        }
        public static void BeginInputAttribute(int id, PinShape shape)
        {
            ImNodesNative.imnodes_BeginInputAttribute(id, shape);
        }
        public static void BeginNode(int id)
        {
            ImNodesNative.imnodes_BeginNode(id);
        }
        public static void BeginNodeEditor()
        {
            ImNodesNative.imnodes_BeginNodeEditor();
        }
        public static void BeginNodeTitleBar()
        {
            ImNodesNative.imnodes_BeginNodeTitleBar();
        }
        public static void BeginOutputAttribute(int id)
        {
            PinShape shape = PinShape._CircleFilled;
            ImNodesNative.imnodes_BeginOutputAttribute(id, shape);
        }
        public static void BeginOutputAttribute(int id, PinShape shape)
        {
            ImNodesNative.imnodes_BeginOutputAttribute(id, shape);
        }
        public static void BeginStaticAttribute(int id)
        {
            ImNodesNative.imnodes_BeginStaticAttribute(id);
        }
        public static void ClearLinkSelection()
        {
            ImNodesNative.imnodes_ClearLinkSelection();
        }
        public static void ClearNodeSelection()
        {
            ImNodesNative.imnodes_ClearNodeSelection();
        }
        public static IntPtr EditorContextCreate()
        {
            IntPtr ret = ImNodesNative.imnodes_EditorContextCreate();
            return ret;
        }
        public static void EditorContextFree(IntPtr noname1)
        {
            ImNodesNative.imnodes_EditorContextFree(noname1);
        }
        public static Vector2 EditorContextGetPanning()
        {
            Vector2 __retval;
            ImNodesNative.imnodes_EditorContextGetPanning(&__retval);
            return __retval;
        }
        public static void EditorContextMoveToNode(int node_id)
        {
            ImNodesNative.imnodes_EditorContextMoveToNode(node_id);
        }
        public static void EditorContextResetPanning(Vector2 pos)
        {
            ImNodesNative.imnodes_EditorContextResetPanning(pos);
        }
        public static void EditorContextSet(IntPtr noname1)
        {
            ImNodesNative.imnodes_EditorContextSet(noname1);
        }
        public static void EndInputAttribute()
        {
            ImNodesNative.imnodes_EndInputAttribute();
        }
        public static void EndNode()
        {
            ImNodesNative.imnodes_EndNode();
        }
        public static void EndNodeEditor()
        {
            ImNodesNative.imnodes_EndNodeEditor();
        }
        public static void EndNodeTitleBar()
        {
            ImNodesNative.imnodes_EndNodeTitleBar();
        }
        public static void EndOutputAttribute()
        {
            ImNodesNative.imnodes_EndOutputAttribute();
        }
        public static void EndStaticAttribute()
        {
            ImNodesNative.imnodes_EndStaticAttribute();
        }
        public static IO* GetIO()
        {
            IO* ret = ImNodesNative.imnodes_GetIO();
            return ret;
        }
        public static Vector2 GetNodeDimensions(int id)
        {
            Vector2 __retval;
            ImNodesNative.imnodes_GetNodeDimensions(&__retval, id);
            return __retval;
        }
        public static Vector2 GetNodeEditorSpacePos(int node_id)
        {
            Vector2 __retval;
            ImNodesNative.imnodes_GetNodeEditorSpacePos(&__retval, node_id);
            return __retval;
        }
        public static Vector2 GetNodeGridSpacePos(int node_id)
        {
            Vector2 __retval;
            ImNodesNative.imnodes_GetNodeGridSpacePos(&__retval, node_id);
            return __retval;
        }
        public static Vector2 GetNodeScreenSpacePos(int node_id)
        {
            Vector2 __retval;
            ImNodesNative.imnodes_GetNodeScreenSpacePos(&__retval, node_id);
            return __retval;
        }
        public static void GetSelectedLinks(ref int link_ids)
        {
            fixed (int* native_link_ids = &link_ids)
            {
                ImNodesNative.imnodes_GetSelectedLinks(native_link_ids);
            }
        }
        public static void GetSelectedNodes(ref int node_ids)
        {
            fixed (int* native_node_ids = &node_ids)
            {
                ImNodesNative.imnodes_GetSelectedNodes(native_node_ids);
            }
        }
        public static Style* GetStyle()
        {
            Style* ret = ImNodesNative.imnodes_GetStyle();
            return ret;
        }
        public static void Initialize()
        {
            ImNodesNative.imnodes_Initialize();
        }
        public static bool IsAnyAttributeActive()
        {
            int* attribute_id = null;
            byte ret = ImNodesNative.imnodes_IsAnyAttributeActive(attribute_id);
            return ret != 0;
        }
        public static bool IsAnyAttributeActive(ref int attribute_id)
        {
            fixed (int* native_attribute_id = &attribute_id)
            {
                byte ret = ImNodesNative.imnodes_IsAnyAttributeActive(native_attribute_id);
                return ret != 0;
            }
        }
        public static bool IsAttributeActive()
        {
            byte ret = ImNodesNative.imnodes_IsAttributeActive();
            return ret != 0;
        }
        public static bool IsEditorHovered()
        {
            byte ret = ImNodesNative.imnodes_IsEditorHovered();
            return ret != 0;
        }
        public static bool IsLinkCreated(ref int started_at_attribute_id, ref int ended_at_attribute_id)
        {
            byte* created_from_snap = null;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                fixed (int* native_ended_at_attribute_id = &ended_at_attribute_id)
                {
                    byte ret = ImNodesNative.imnodes_IsLinkCreatedBoolPtr(native_started_at_attribute_id, native_ended_at_attribute_id, created_from_snap);
                    return ret != 0;
                }
            }
        }
        public static bool IsLinkCreated(ref int started_at_attribute_id, ref int ended_at_attribute_id, ref bool created_from_snap)
        {
            byte native_created_from_snap_val = created_from_snap ? (byte)1 : (byte)0;
            byte* native_created_from_snap = &native_created_from_snap_val;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                fixed (int* native_ended_at_attribute_id = &ended_at_attribute_id)
                {
                    byte ret = ImNodesNative.imnodes_IsLinkCreatedBoolPtr(native_started_at_attribute_id, native_ended_at_attribute_id, native_created_from_snap);
                    created_from_snap = native_created_from_snap_val != 0;
                    return ret != 0;
                }
            }
        }
        public static bool IsLinkCreated(ref int started_at_node_id, ref int started_at_attribute_id, ref int ended_at_node_id, ref int ended_at_attribute_id)
        {
            byte* created_from_snap = null;
            fixed (int* native_started_at_node_id = &started_at_node_id)
            {
                fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
                {
                    fixed (int* native_ended_at_node_id = &ended_at_node_id)
                    {
                        fixed (int* native_ended_at_attribute_id = &ended_at_attribute_id)
                        {
                            byte ret = ImNodesNative.imnodes_IsLinkCreatedIntPtr(native_started_at_node_id, native_started_at_attribute_id, native_ended_at_node_id, native_ended_at_attribute_id, created_from_snap);
                            return ret != 0;
                        }
                    }
                }
            }
        }
        public static bool IsLinkCreated(ref int started_at_node_id, ref int started_at_attribute_id, ref int ended_at_node_id, ref int ended_at_attribute_id, ref bool created_from_snap)
        {
            byte native_created_from_snap_val = created_from_snap ? (byte)1 : (byte)0;
            byte* native_created_from_snap = &native_created_from_snap_val;
            fixed (int* native_started_at_node_id = &started_at_node_id)
            {
                fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
                {
                    fixed (int* native_ended_at_node_id = &ended_at_node_id)
                    {
                        fixed (int* native_ended_at_attribute_id = &ended_at_attribute_id)
                        {
                            byte ret = ImNodesNative.imnodes_IsLinkCreatedIntPtr(native_started_at_node_id, native_started_at_attribute_id, native_ended_at_node_id, native_ended_at_attribute_id, native_created_from_snap);
                            created_from_snap = native_created_from_snap_val != 0;
                            return ret != 0;
                        }
                    }
                }
            }
        }
        public static bool IsLinkDestroyed(ref int link_id)
        {
            fixed (int* native_link_id = &link_id)
            {
                byte ret = ImNodesNative.imnodes_IsLinkDestroyed(native_link_id);
                return ret != 0;
            }
        }
        public static bool IsLinkDropped()
        {
            int* started_at_attribute_id = null;
            byte including_detached_links = 1;
            byte ret = ImNodesNative.imnodes_IsLinkDropped(started_at_attribute_id, including_detached_links);
            return ret != 0;
        }
        public static bool IsLinkDropped(ref int started_at_attribute_id)
        {
            byte including_detached_links = 1;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = ImNodesNative.imnodes_IsLinkDropped(native_started_at_attribute_id, including_detached_links);
                return ret != 0;
            }
        }
        public static bool IsLinkDropped(ref int started_at_attribute_id, bool including_detached_links)
        {
            byte native_including_detached_links = including_detached_links ? (byte)1 : (byte)0;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = ImNodesNative.imnodes_IsLinkDropped(native_started_at_attribute_id, native_including_detached_links);
                return ret != 0;
            }
        }
        public static bool IsLinkHovered(ref int link_id)
        {
            fixed (int* native_link_id = &link_id)
            {
                byte ret = ImNodesNative.imnodes_IsLinkHovered(native_link_id);
                return ret != 0;
            }
        }
        public static bool IsLinkStarted(ref int started_at_attribute_id)
        {
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = ImNodesNative.imnodes_IsLinkStarted(native_started_at_attribute_id);
                return ret != 0;
            }
        }
        public static bool IsNodeHovered(ref int node_id)
        {
            fixed (int* native_node_id = &node_id)
            {
                byte ret = ImNodesNative.imnodes_IsNodeHovered(native_node_id);
                return ret != 0;
            }
        }
        public static bool IsPinHovered(ref int attribute_id)
        {
            fixed (int* native_attribute_id = &attribute_id)
            {
                byte ret = ImNodesNative.imnodes_IsPinHovered(native_attribute_id);
                return ret != 0;
            }
        }
        public static void Link(int id, int start_attribute_id, int end_attribute_id)
        {
            ImNodesNative.imnodes_Link(id, start_attribute_id, end_attribute_id);
        }
        public static void LoadCurrentEditorStateFromIniFile(string file_name)
        {
            byte* native_file_name;
            int file_name_byteCount = 0;
            if (file_name != null)
            {
                file_name_byteCount = Encoding.UTF8.GetByteCount(file_name);
                if (file_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_file_name = Util.Allocate(file_name_byteCount + 1);
                }
                else
                {
                    byte* native_file_name_stackBytes = stackalloc byte[file_name_byteCount + 1];
                    native_file_name = native_file_name_stackBytes;
                }
                int native_file_name_offset = Util.GetUtf8(file_name, native_file_name, file_name_byteCount);
                native_file_name[native_file_name_offset] = 0;
            }
            else { native_file_name = null; }
            ImNodesNative.imnodes_LoadCurrentEditorStateFromIniFile(native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static void LoadCurrentEditorStateFromIniString(string data, uint data_size)
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
            ImNodesNative.imnodes_LoadCurrentEditorStateFromIniString(native_data, data_size);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
        }
        public static void LoadEditorStateFromIniFile(IntPtr editor, string file_name)
        {
            byte* native_file_name;
            int file_name_byteCount = 0;
            if (file_name != null)
            {
                file_name_byteCount = Encoding.UTF8.GetByteCount(file_name);
                if (file_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_file_name = Util.Allocate(file_name_byteCount + 1);
                }
                else
                {
                    byte* native_file_name_stackBytes = stackalloc byte[file_name_byteCount + 1];
                    native_file_name = native_file_name_stackBytes;
                }
                int native_file_name_offset = Util.GetUtf8(file_name, native_file_name, file_name_byteCount);
                native_file_name[native_file_name_offset] = 0;
            }
            else { native_file_name = null; }
            ImNodesNative.imnodes_LoadEditorStateFromIniFile(editor, native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static void LoadEditorStateFromIniString(IntPtr editor, string data, uint data_size)
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
            ImNodesNative.imnodes_LoadEditorStateFromIniString(editor, native_data, data_size);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
        }
        public static int NumSelectedLinks()
        {
            int ret = ImNodesNative.imnodes_NumSelectedLinks();
            return ret;
        }
        public static int NumSelectedNodes()
        {
            int ret = ImNodesNative.imnodes_NumSelectedNodes();
            return ret;
        }
        public static void PopAttributeFlag()
        {
            ImNodesNative.imnodes_PopAttributeFlag();
        }
        public static void PopColorStyle()
        {
            ImNodesNative.imnodes_PopColorStyle();
        }
        public static void PopStyleVar()
        {
            ImNodesNative.imnodes_PopStyleVar();
        }
        public static void PushAttributeFlag(AttributeFlags flag)
        {
            ImNodesNative.imnodes_PushAttributeFlag(flag);
        }
        public static void PushColorStyle(ColorStyle item, uint color)
        {
            ImNodesNative.imnodes_PushColorStyle(item, color);
        }
        public static void PushStyleVar(StyleVar style_item, float value)
        {
            ImNodesNative.imnodes_PushStyleVar(style_item, value);
        }
        public static void SaveCurrentEditorStateToIniFile(string file_name)
        {
            byte* native_file_name;
            int file_name_byteCount = 0;
            if (file_name != null)
            {
                file_name_byteCount = Encoding.UTF8.GetByteCount(file_name);
                if (file_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_file_name = Util.Allocate(file_name_byteCount + 1);
                }
                else
                {
                    byte* native_file_name_stackBytes = stackalloc byte[file_name_byteCount + 1];
                    native_file_name = native_file_name_stackBytes;
                }
                int native_file_name_offset = Util.GetUtf8(file_name, native_file_name, file_name_byteCount);
                native_file_name[native_file_name_offset] = 0;
            }
            else { native_file_name = null; }
            ImNodesNative.imnodes_SaveCurrentEditorStateToIniFile(native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static string SaveCurrentEditorStateToIniString()
        {
            uint* data_size = null;
            byte* ret = ImNodesNative.imnodes_SaveCurrentEditorStateToIniString(data_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveCurrentEditorStateToIniString(ref uint data_size)
        {
            fixed (uint* native_data_size = &data_size)
            {
                byte* ret = ImNodesNative.imnodes_SaveCurrentEditorStateToIniString(native_data_size);
                return Util.StringFromPtr(ret);
            }
        }
        public static void SaveEditorStateToIniFile(IntPtr editor, string file_name)
        {
            byte* native_file_name;
            int file_name_byteCount = 0;
            if (file_name != null)
            {
                file_name_byteCount = Encoding.UTF8.GetByteCount(file_name);
                if (file_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_file_name = Util.Allocate(file_name_byteCount + 1);
                }
                else
                {
                    byte* native_file_name_stackBytes = stackalloc byte[file_name_byteCount + 1];
                    native_file_name = native_file_name_stackBytes;
                }
                int native_file_name_offset = Util.GetUtf8(file_name, native_file_name, file_name_byteCount);
                native_file_name[native_file_name_offset] = 0;
            }
            else { native_file_name = null; }
            ImNodesNative.imnodes_SaveEditorStateToIniFile(editor, native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static string SaveEditorStateToIniString(IntPtr editor)
        {
            uint* data_size = null;
            byte* ret = ImNodesNative.imnodes_SaveEditorStateToIniString(editor, data_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveEditorStateToIniString(IntPtr editor, ref uint data_size)
        {
            fixed (uint* native_data_size = &data_size)
            {
                byte* ret = ImNodesNative.imnodes_SaveEditorStateToIniString(editor, native_data_size);
                return Util.StringFromPtr(ret);
            }
        }
        public static void SetNodeDraggable(int node_id, bool draggable)
        {
            byte native_draggable = draggable ? (byte)1 : (byte)0;
            ImNodesNative.imnodes_SetNodeDraggable(node_id, native_draggable);
        }
        public static void SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos)
        {
            ImNodesNative.imnodes_SetNodeEditorSpacePos(node_id, editor_space_pos);
        }
        public static void SetNodeGridSpacePos(int node_id, Vector2 grid_pos)
        {
            ImNodesNative.imnodes_SetNodeGridSpacePos(node_id, grid_pos);
        }
        public static void SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos)
        {
            ImNodesNative.imnodes_SetNodeScreenSpacePos(node_id, screen_space_pos);
        }
        public static void Shutdown()
        {
            ImNodesNative.imnodes_Shutdown();
        }
        public static void StyleColorsClassic()
        {
            ImNodesNative.imnodes_StyleColorsClassic();
        }
        public static void StyleColorsDark()
        {
            ImNodesNative.imnodes_StyleColorsDark();
        }
        public static void StyleColorsLight()
        {
            ImNodesNative.imnodes_StyleColorsLight();
        }
    }
}
