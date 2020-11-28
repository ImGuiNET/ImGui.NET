using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImNodesNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void EmulateThreeButtonMouse_destroy(EmulateThreeButtonMouse* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern EmulateThreeButtonMouse* EmulateThreeButtonMouse_EmulateThreeButtonMouse();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginInputAttribute(int id, PinShape shape);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginNode(int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginNodeEditor();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginNodeTitleBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginOutputAttribute(int id, PinShape shape);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_BeginStaticAttribute(int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_ClearLinkSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_ClearNodeSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr imnodes_EditorContextCreate();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EditorContextFree(IntPtr noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EditorContextGetPanning(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EditorContextMoveToNode(int node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EditorContextResetPanning(Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EditorContextSet(IntPtr noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndInputAttribute();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndNode();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndNodeEditor();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndNodeTitleBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndOutputAttribute();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_EndStaticAttribute();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IO* imnodes_GetIO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetNodeDimensions(Vector2* pOut, int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetNodeEditorSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetNodeGridSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetNodeScreenSpacePos(Vector2* pOut, int node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetSelectedLinks(int* link_ids);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_GetSelectedNodes(int* node_ids);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Style* imnodes_GetStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_Initialize();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsAnyAttributeActive(int* attribute_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsAttributeActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsEditorHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkCreatedBoolPtr(int* started_at_attribute_id, int* ended_at_attribute_id, byte* created_from_snap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkCreatedIntPtr(int* started_at_node_id, int* started_at_attribute_id, int* ended_at_node_id, int* ended_at_attribute_id, byte* created_from_snap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkDestroyed(int* link_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkDropped(int* started_at_attribute_id, byte including_detached_links);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkHovered(int* link_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsLinkStarted(int* started_at_attribute_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsNodeHovered(int* node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imnodes_IsPinHovered(int* attribute_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_Link(int id, int start_attribute_id, int end_attribute_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_LoadCurrentEditorStateFromIniFile(byte* file_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_LoadCurrentEditorStateFromIniString(byte* data, uint data_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_LoadEditorStateFromIniFile(IntPtr editor, byte* file_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_LoadEditorStateFromIniString(IntPtr editor, byte* data, uint data_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int imnodes_NumSelectedLinks();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int imnodes_NumSelectedNodes();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PopAttributeFlag();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PopColorStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PopStyleVar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PushAttributeFlag(AttributeFlags flag);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PushColorStyle(ColorStyle item, uint color);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_PushStyleVar(StyleVar style_item, float value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SaveCurrentEditorStateToIniFile(byte* file_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* imnodes_SaveCurrentEditorStateToIniString(uint* data_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SaveEditorStateToIniFile(IntPtr editor, byte* file_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* imnodes_SaveEditorStateToIniString(IntPtr editor, uint* data_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SetNodeDraggable(int node_id, byte draggable);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SetNodeGridSpacePos(int node_id, Vector2 grid_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_Shutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_StyleColorsClassic();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_StyleColorsDark();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imnodes_StyleColorsLight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void IO_destroy(IO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IO* IO_IO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LinkDetachWithModifierClick_destroy(LinkDetachWithModifierClick* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern LinkDetachWithModifierClick* LinkDetachWithModifierClick_LinkDetachWithModifierClick();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Style_destroy(Style* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Style* Style_Style();
    }
}
