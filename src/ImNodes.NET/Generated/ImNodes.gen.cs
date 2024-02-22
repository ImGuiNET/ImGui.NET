using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public static unsafe partial class imnodes
    {
        public static void BeginInputAttribute(int id)
        {
            ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
            imnodesNative.ImNodes_BeginInputAttribute(id, shape);
        }
        public static void BeginInputAttribute(int id, ImNodesPinShape shape)
        {
            imnodesNative.ImNodes_BeginInputAttribute(id, shape);
        }
        public static void BeginNode(int id)
        {
            imnodesNative.ImNodes_BeginNode(id);
        }
        public static void BeginNodeEditor()
        {
            imnodesNative.ImNodes_BeginNodeEditor();
        }
        public static void BeginNodeTitleBar()
        {
            imnodesNative.ImNodes_BeginNodeTitleBar();
        }
        public static void BeginOutputAttribute(int id)
        {
            ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
            imnodesNative.ImNodes_BeginOutputAttribute(id, shape);
        }
        public static void BeginOutputAttribute(int id, ImNodesPinShape shape)
        {
            imnodesNative.ImNodes_BeginOutputAttribute(id, shape);
        }
        public static void BeginStaticAttribute(int id)
        {
            imnodesNative.ImNodes_BeginStaticAttribute(id);
        }
        public static void ClearLinkSelection()
        {
            imnodesNative.ImNodes_ClearLinkSelection_Nil();
        }
        public static void ClearLinkSelection(int link_id)
        {
            imnodesNative.ImNodes_ClearLinkSelection_Int(link_id);
        }
        public static void ClearNodeSelection()
        {
            imnodesNative.ImNodes_ClearNodeSelection_Nil();
        }
        public static void ClearNodeSelection(int node_id)
        {
            imnodesNative.ImNodes_ClearNodeSelection_Int(node_id);
        }
        public static ImNodesContextPtr CreateContext()
        {
            ImNodesContext* ret = imnodesNative.ImNodes_CreateContext();
            return new ImNodesContextPtr(ret);
        }
        public static void DestroyContext()
        {
            ImNodesContext* ctx = null;
            imnodesNative.ImNodes_DestroyContext(ctx);
        }
        public static void DestroyContext(ImNodesContextPtr ctx)
        {
            ImNodesContext* native_ctx = ctx.NativePtr;
            imnodesNative.ImNodes_DestroyContext(native_ctx);
        }
        public static ImNodesEditorContextPtr EditorContextCreate()
        {
            ImNodesEditorContext* ret = imnodesNative.ImNodes_EditorContextCreate();
            return new ImNodesEditorContextPtr(ret);
        }
        public static void EditorContextFree(ImNodesEditorContextPtr noname1)
        {
            ImNodesEditorContext* native_noname1 = noname1.NativePtr;
            imnodesNative.ImNodes_EditorContextFree(native_noname1);
        }
        public static Vector2 EditorContextGetPanning()
        {
            Vector2 __retval;
            imnodesNative.ImNodes_EditorContextGetPanning(&__retval);
            return __retval;
        }
        public static void EditorContextMoveToNode(int node_id)
        {
            imnodesNative.ImNodes_EditorContextMoveToNode(node_id);
        }
        public static void EditorContextResetPanning(Vector2 pos)
        {
            imnodesNative.ImNodes_EditorContextResetPanning(pos);
        }
        public static void EditorContextSet(ImNodesEditorContextPtr noname1)
        {
            ImNodesEditorContext* native_noname1 = noname1.NativePtr;
            imnodesNative.ImNodes_EditorContextSet(native_noname1);
        }
        public static void EndInputAttribute()
        {
            imnodesNative.ImNodes_EndInputAttribute();
        }
        public static void EndNode()
        {
            imnodesNative.ImNodes_EndNode();
        }
        public static void EndNodeEditor()
        {
            imnodesNative.ImNodes_EndNodeEditor();
        }
        public static void EndNodeTitleBar()
        {
            imnodesNative.ImNodes_EndNodeTitleBar();
        }
        public static void EndOutputAttribute()
        {
            imnodesNative.ImNodes_EndOutputAttribute();
        }
        public static void EndStaticAttribute()
        {
            imnodesNative.ImNodes_EndStaticAttribute();
        }
        public static ImNodesContextPtr GetCurrentContext()
        {
            ImNodesContext* ret = imnodesNative.ImNodes_GetCurrentContext();
            return new ImNodesContextPtr(ret);
        }
        public static ImNodesIOPtr GetIO()
        {
            ImNodesIO* ret = imnodesNative.ImNodes_GetIO();
            return new ImNodesIOPtr(ret);
        }
        public static Vector2 GetNodeDimensions(int id)
        {
            Vector2 __retval;
            imnodesNative.ImNodes_GetNodeDimensions(&__retval, id);
            return __retval;
        }
        public static Vector2 GetNodeEditorSpacePos(int node_id)
        {
            Vector2 __retval;
            imnodesNative.ImNodes_GetNodeEditorSpacePos(&__retval, node_id);
            return __retval;
        }
        public static Vector2 GetNodeGridSpacePos(int node_id)
        {
            Vector2 __retval;
            imnodesNative.ImNodes_GetNodeGridSpacePos(&__retval, node_id);
            return __retval;
        }
        public static Vector2 GetNodeScreenSpacePos(int node_id)
        {
            Vector2 __retval;
            imnodesNative.ImNodes_GetNodeScreenSpacePos(&__retval, node_id);
            return __retval;
        }
        public static void GetSelectedLinks(ref int link_ids)
        {
            fixed (int* native_link_ids = &link_ids)
            {
                imnodesNative.ImNodes_GetSelectedLinks(native_link_ids);
            }
        }
        public static void GetSelectedNodes(ref int node_ids)
        {
            fixed (int* native_node_ids = &node_ids)
            {
                imnodesNative.ImNodes_GetSelectedNodes(native_node_ids);
            }
        }
        public static ImNodesStylePtr GetStyle()
        {
            ImNodesStyle* ret = imnodesNative.ImNodes_GetStyle();
            return new ImNodesStylePtr(ret);
        }
        public static bool IsAnyAttributeActive()
        {
            int* attribute_id = null;
            byte ret = imnodesNative.ImNodes_IsAnyAttributeActive(attribute_id);
            return ret != 0;
        }
        public static bool IsAnyAttributeActive(ref int attribute_id)
        {
            fixed (int* native_attribute_id = &attribute_id)
            {
                byte ret = imnodesNative.ImNodes_IsAnyAttributeActive(native_attribute_id);
                return ret != 0;
            }
        }
        public static bool IsAttributeActive()
        {
            byte ret = imnodesNative.ImNodes_IsAttributeActive();
            return ret != 0;
        }
        public static bool IsEditorHovered()
        {
            byte ret = imnodesNative.ImNodes_IsEditorHovered();
            return ret != 0;
        }
        public static bool IsLinkCreated(ref int started_at_attribute_id, ref int ended_at_attribute_id)
        {
            byte* created_from_snap = null;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                fixed (int* native_ended_at_attribute_id = &ended_at_attribute_id)
                {
                    byte ret = imnodesNative.ImNodes_IsLinkCreated_BoolPtr(native_started_at_attribute_id, native_ended_at_attribute_id, created_from_snap);
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
                    byte ret = imnodesNative.ImNodes_IsLinkCreated_BoolPtr(native_started_at_attribute_id, native_ended_at_attribute_id, native_created_from_snap);
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
                            byte ret = imnodesNative.ImNodes_IsLinkCreated_IntPtr(native_started_at_node_id, native_started_at_attribute_id, native_ended_at_node_id, native_ended_at_attribute_id, created_from_snap);
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
                            byte ret = imnodesNative.ImNodes_IsLinkCreated_IntPtr(native_started_at_node_id, native_started_at_attribute_id, native_ended_at_node_id, native_ended_at_attribute_id, native_created_from_snap);
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
                byte ret = imnodesNative.ImNodes_IsLinkDestroyed(native_link_id);
                return ret != 0;
            }
        }
        public static bool IsLinkDropped()
        {
            int* started_at_attribute_id = null;
            byte including_detached_links = 1;
            byte ret = imnodesNative.ImNodes_IsLinkDropped(started_at_attribute_id, including_detached_links);
            return ret != 0;
        }
        public static bool IsLinkDropped(ref int started_at_attribute_id)
        {
            byte including_detached_links = 1;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = imnodesNative.ImNodes_IsLinkDropped(native_started_at_attribute_id, including_detached_links);
                return ret != 0;
            }
        }
        public static bool IsLinkDropped(ref int started_at_attribute_id, bool including_detached_links)
        {
            byte native_including_detached_links = including_detached_links ? (byte)1 : (byte)0;
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = imnodesNative.ImNodes_IsLinkDropped(native_started_at_attribute_id, native_including_detached_links);
                return ret != 0;
            }
        }
        public static bool IsLinkHovered(ref int link_id)
        {
            fixed (int* native_link_id = &link_id)
            {
                byte ret = imnodesNative.ImNodes_IsLinkHovered(native_link_id);
                return ret != 0;
            }
        }
        public static bool IsLinkSelected(int link_id)
        {
            byte ret = imnodesNative.ImNodes_IsLinkSelected(link_id);
            return ret != 0;
        }
        public static bool IsLinkStarted(ref int started_at_attribute_id)
        {
            fixed (int* native_started_at_attribute_id = &started_at_attribute_id)
            {
                byte ret = imnodesNative.ImNodes_IsLinkStarted(native_started_at_attribute_id);
                return ret != 0;
            }
        }
        public static bool IsNodeHovered(ref int node_id)
        {
            fixed (int* native_node_id = &node_id)
            {
                byte ret = imnodesNative.ImNodes_IsNodeHovered(native_node_id);
                return ret != 0;
            }
        }
        public static bool IsNodeSelected(int node_id)
        {
            byte ret = imnodesNative.ImNodes_IsNodeSelected(node_id);
            return ret != 0;
        }
        public static bool IsPinHovered(ref int attribute_id)
        {
            fixed (int* native_attribute_id = &attribute_id)
            {
                byte ret = imnodesNative.ImNodes_IsPinHovered(native_attribute_id);
                return ret != 0;
            }
        }
        public static void Link(int id, int start_attribute_id, int end_attribute_id)
        {
            imnodesNative.ImNodes_Link(id, start_attribute_id, end_attribute_id);
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
            imnodesNative.ImNodes_LoadCurrentEditorStateFromIniFile(native_file_name);
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
            imnodesNative.ImNodes_LoadCurrentEditorStateFromIniString(native_data, data_size);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
        }
        public static void LoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, string file_name)
        {
            ImNodesEditorContext* native_editor = editor.NativePtr;
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
            imnodesNative.ImNodes_LoadEditorStateFromIniFile(native_editor, native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static void LoadEditorStateFromIniString(ImNodesEditorContextPtr editor, string data, uint data_size)
        {
            ImNodesEditorContext* native_editor = editor.NativePtr;
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
            imnodesNative.ImNodes_LoadEditorStateFromIniString(native_editor, native_data, data_size);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
        }
        public static void MiniMap()
        {
            float minimap_size_fraction = 0.2f;
            ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
            ImNodesMiniMapNodeHoveringCallback node_hovering_callback = null;
            void* node_hovering_callback_data = null;
            imnodesNative.ImNodes_MiniMap(minimap_size_fraction, location, node_hovering_callback, node_hovering_callback_data);
        }
        public static void MiniMap(float minimap_size_fraction)
        {
            ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
            ImNodesMiniMapNodeHoveringCallback node_hovering_callback = null;
            void* node_hovering_callback_data = null;
            imnodesNative.ImNodes_MiniMap(minimap_size_fraction, location, node_hovering_callback, node_hovering_callback_data);
        }
        public static void MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location)
        {
            ImNodesMiniMapNodeHoveringCallback node_hovering_callback = null;
            void* node_hovering_callback_data = null;
            imnodesNative.ImNodes_MiniMap(minimap_size_fraction, location, node_hovering_callback, node_hovering_callback_data);
        }
        public static void MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback node_hovering_callback)
        {
            void* node_hovering_callback_data = null;
            imnodesNative.ImNodes_MiniMap(minimap_size_fraction, location, node_hovering_callback, node_hovering_callback_data);
        }
        public static void MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback node_hovering_callback, IntPtr node_hovering_callback_data)
        {
            void* native_node_hovering_callback_data = (void*)node_hovering_callback_data.ToPointer();
            imnodesNative.ImNodes_MiniMap(minimap_size_fraction, location, node_hovering_callback, native_node_hovering_callback_data);
        }
        public static int NumSelectedLinks()
        {
            int ret = imnodesNative.ImNodes_NumSelectedLinks();
            return ret;
        }
        public static int NumSelectedNodes()
        {
            int ret = imnodesNative.ImNodes_NumSelectedNodes();
            return ret;
        }
        public static void PopAttributeFlag()
        {
            imnodesNative.ImNodes_PopAttributeFlag();
        }
        public static void PopColorStyle()
        {
            imnodesNative.ImNodes_PopColorStyle();
        }
        public static void PopStyleVar()
        {
            imnodesNative.ImNodes_PopStyleVar();
        }
        public static void PushAttributeFlag(ImNodesAttributeFlags flag)
        {
            imnodesNative.ImNodes_PushAttributeFlag(flag);
        }
        public static void PushColorStyle(ImNodesCol item, uint color)
        {
            imnodesNative.ImNodes_PushColorStyle(item, color);
        }
        public static void PushStyleVar(ImNodesStyleVar style_item, float value)
        {
            imnodesNative.ImNodes_PushStyleVar(style_item, value);
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
            imnodesNative.ImNodes_SaveCurrentEditorStateToIniFile(native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static string SaveCurrentEditorStateToIniString()
        {
            uint* data_size = null;
            byte* ret = imnodesNative.ImNodes_SaveCurrentEditorStateToIniString(data_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveCurrentEditorStateToIniString(ref uint data_size)
        {
            fixed (uint* native_data_size = &data_size)
            {
                byte* ret = imnodesNative.ImNodes_SaveCurrentEditorStateToIniString(native_data_size);
                return Util.StringFromPtr(ret);
            }
        }
        public static void SaveEditorStateToIniFile(ImNodesEditorContextPtr editor, string file_name)
        {
            ImNodesEditorContext* native_editor = editor.NativePtr;
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
            imnodesNative.ImNodes_SaveEditorStateToIniFile(native_editor, native_file_name);
            if (file_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_file_name);
            }
        }
        public static string SaveEditorStateToIniString(ImNodesEditorContextPtr editor)
        {
            ImNodesEditorContext* native_editor = editor.NativePtr;
            uint* data_size = null;
            byte* ret = imnodesNative.ImNodes_SaveEditorStateToIniString(native_editor, data_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveEditorStateToIniString(ImNodesEditorContextPtr editor, ref uint data_size)
        {
            ImNodesEditorContext* native_editor = editor.NativePtr;
            fixed (uint* native_data_size = &data_size)
            {
                byte* ret = imnodesNative.ImNodes_SaveEditorStateToIniString(native_editor, native_data_size);
                return Util.StringFromPtr(ret);
            }
        }
        public static void SelectLink(int link_id)
        {
            imnodesNative.ImNodes_SelectLink(link_id);
        }
        public static void SelectNode(int node_id)
        {
            imnodesNative.ImNodes_SelectNode(node_id);
        }
        public static void SetCurrentContext(ImNodesContextPtr ctx)
        {
            ImNodesContext* native_ctx = ctx.NativePtr;
            imnodesNative.ImNodes_SetCurrentContext(native_ctx);
        }
        public static void SetImGuiContext(IntPtr ctx)
        {
            imnodesNative.ImNodes_SetImGuiContext(ctx);
        }
        public static void SetNodeDraggable(int node_id, bool draggable)
        {
            byte native_draggable = draggable ? (byte)1 : (byte)0;
            imnodesNative.ImNodes_SetNodeDraggable(node_id, native_draggable);
        }
        public static void SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos)
        {
            imnodesNative.ImNodes_SetNodeEditorSpacePos(node_id, editor_space_pos);
        }
        public static void SetNodeGridSpacePos(int node_id, Vector2 grid_pos)
        {
            imnodesNative.ImNodes_SetNodeGridSpacePos(node_id, grid_pos);
        }
        public static void SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos)
        {
            imnodesNative.ImNodes_SetNodeScreenSpacePos(node_id, screen_space_pos);
        }
        public static void StyleColorsClassic()
        {
            imnodesNative.ImNodes_StyleColorsClassic();
        }
        public static void StyleColorsDark()
        {
            imnodesNative.ImNodes_StyleColorsDark();
        }
        public static void StyleColorsLight()
        {
            imnodesNative.ImNodes_StyleColorsLight();
        }
    }
}
