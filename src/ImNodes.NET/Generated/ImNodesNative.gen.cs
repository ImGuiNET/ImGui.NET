using System;
using UnityEngine;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace imnodesNET
{
    public static unsafe partial class imnodesNative
    {
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void EmulateThreeButtonMouse_destroy(EmulateThreeButtonMouse* self);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern EmulateThreeButtonMouse* EmulateThreeButtonMouse_EmulateThreeButtonMouse();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginInputAttribute(int id, ImNodesPinShape shape);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginNode(int id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginNodeEditor();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginNodeTitleBar();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginOutputAttribute(int id, ImNodesPinShape shape);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginStaticAttribute(int id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_ClearLinkSelection_Nil();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_ClearLinkSelection_Int(int link_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_ClearNodeSelection_Nil();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_ClearNodeSelection_Int(int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesContext* ImNodes_CreateContext();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_DestroyContext(ImNodesContext* ctx);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesEditorContext* ImNodes_EditorContextCreate();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EditorContextFree(ImNodesEditorContext* noname1);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EditorContextGetPanning(Vector2* pOut);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EditorContextMoveToNode(int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EditorContextResetPanning(Vector2 pos);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EditorContextSet(ImNodesEditorContext* noname1);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndInputAttribute();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndNode();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndNodeEditor();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndNodeTitleBar();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndOutputAttribute();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndStaticAttribute();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesContext* ImNodes_GetCurrentContext();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesIO* ImNodes_GetIO();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetNodeDimensions(Vector2* pOut, int id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetNodeEditorSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetNodeGridSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetNodeScreenSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetSelectedLinks(int* link_ids);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_GetSelectedNodes(int* node_ids);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesStyle* ImNodes_GetStyle();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsAnyAttributeActive(int* attribute_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsAttributeActive();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsEditorHovered();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkCreated_BoolPtr(int* started_at_attribute_id, int* ended_at_attribute_id, byte* created_from_snap);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkCreated_IntPtr(int* started_at_node_id, int* started_at_attribute_id, int* ended_at_node_id, int* ended_at_attribute_id, byte* created_from_snap);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkDestroyed(int* link_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkDropped(int* started_at_attribute_id, byte including_detached_links);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkHovered(int* link_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkSelected(int link_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsLinkStarted(int* started_at_attribute_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsNodeHovered(int* node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsNodeSelected(int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsPinHovered(int* attribute_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Link(int id, int start_attribute_id, int end_attribute_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_LoadCurrentEditorStateFromIniFile(byte* file_name);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_LoadCurrentEditorStateFromIniString(byte* data, uint data_size);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_LoadEditorStateFromIniFile(ImNodesEditorContext* editor, byte* file_name);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_LoadEditorStateFromIniString(ImNodesEditorContext* editor, byte* data, uint data_size);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location, imnodes.ImNodesMiniMapNodeHoveringCallback node_hovering_callback, void* node_hovering_callback_data);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImNodes_NumSelectedLinks();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImNodes_NumSelectedNodes();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PopAttributeFlag();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PopColorStyle();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PopStyleVar();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PushAttributeFlag(ImNodesAttributeFlags flag);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PushColorStyle(ImNodesCol item, uint color);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_PushStyleVar(ImNodesStyleVar style_item, float value);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SaveCurrentEditorStateToIniFile(byte* file_name);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImNodes_SaveCurrentEditorStateToIniString(uint* data_size);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SaveEditorStateToIniFile(ImNodesEditorContext* editor, byte* file_name);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImNodes_SaveEditorStateToIniString(ImNodesEditorContext* editor, uint* data_size);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SelectLink(int link_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SelectNode(int node_id);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetCurrentContext(ImNodesContext* ctx);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetImGuiContext(IntPtr ctx);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetNodeDraggable(int node_id, byte draggable);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetNodeGridSpacePos(int node_id, Vector2 grid_pos);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_StyleColorsClassic();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_StyleColorsDark();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_StyleColorsLight();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodesIO_destroy(ImNodesIO* self);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesIO* ImNodesIO_ImNodesIO();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodesStyle_destroy(ImNodesStyle* self);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImNodesStyle* ImNodesStyle_ImNodesStyle();
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LinkDetachWithModifierClick_destroy(LinkDetachWithModifierClick* self);
        [DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern LinkDetachWithModifierClick* LinkDetachWithModifierClick_LinkDetachWithModifierClick();
    }
}
