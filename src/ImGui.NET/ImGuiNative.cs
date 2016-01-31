using System.Runtime.InteropServices;
using System.Numerics;
using System;

namespace ImGuiNET
{
    /// <summary>
    /// Contains all of the exported functions from the native (c)imGui module.
    /// </summary>
    public static unsafe class ImGuiNative
    {
        private const string cimguiLib = "cimgui";

        [DllImport(cimguiLib)]
        public static extern NativeIO* igGetIO();

        [DllImport(cimguiLib)]
        public static extern NativeStyle* igGetStyle();

        [DllImport(cimguiLib)]
        public static extern DrawData* igGetDrawData();

        [DllImport(cimguiLib)]
        public static extern void igNewFrame();
        [DllImport(cimguiLib)]
        public static extern void igRender();
        [DllImport(cimguiLib)]
        public static extern void igShutdown();
        [DllImport(cimguiLib)]
        public static extern void igShowUserGuide();
        [DllImport(cimguiLib)]
        public static extern void igShowStyleEditor(ref NativeStyle @ref);

        [DllImport(cimguiLib)]
        public static extern void igShowTestWindow(ref bool opened);
        [DllImport(cimguiLib)]
        public static extern void igShowMetricsWindow(ref bool opened);

        // Window
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBegin(string name, ref bool p_opened, WindowFlags flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBegin2(string name, ref bool p_opened, Vector2 size_on_first_use, float bg_alpha, WindowFlags flags);
        [DllImport(cimguiLib)]
        public static extern void igEnd();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginChild(string str_id, Vector2 size, bool border, WindowFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginChildEx(uint id, Vector2 size, bool border, WindowFlags extra_flags);
        [DllImport(cimguiLib)]
        public static extern void igEndChild();

        [DllImport(cimguiLib)]
        public static extern void igGetContentRegionMax(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern void igGetContentRegionAvail(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern float igGetContentRegionAvailWidth();

        [DllImport(cimguiLib)]
        public static extern void igGetWindowContentRegionMin(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern void igGetWindowContentRegionMax(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern float igGetWindowContentRegionWidth();

        [DllImport(cimguiLib)]
        public static extern DrawList* igGetWindowDrawList();
        [DllImport(cimguiLib)]
        public static extern Font* igGetWindowFont();
        [DllImport(cimguiLib)]
        public static extern float igGetWindowFontSize();
        [DllImport(cimguiLib)]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport(cimguiLib)]
        public static extern void igGetWindowPos(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern void igGetWindowSize(out Vector2 @out);
        [DllImport(cimguiLib)]
        public static extern float igGetWindowWidth();
        [DllImport(cimguiLib)]
        public static extern float igGetWindowHeight();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsWindowCollapsed();

        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowPos(Vector2 pos, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowPosCenter(SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowSize(Vector2 size, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowContentWidth(float width);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowCollapsed(bool collapsed, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetNextWindowFocus();
        [DllImport(cimguiLib)]
        public static extern void igSetWindowPos(Vector2 pos, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowSize(Vector2 size, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowCollapsed(bool collapsed, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowFocus();
        [DllImport(cimguiLib)]
        public static extern void igSetWindowPosByName(string name, Vector2 pos, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowSize2(string name, Vector2 size, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowCollapsed2(string name, bool collapsed, SetCondition cond);
        [DllImport(cimguiLib)]
        public static extern void igSetWindowFocus2(string name);

        [DllImport(cimguiLib)]
        public static extern float igGetScrollX();
        [DllImport(cimguiLib)]
        public static extern float igGetScrollY();
        [DllImport(cimguiLib)]
        public static extern float igGetScrollMaxX();
        [DllImport(cimguiLib)]
        public static extern float igGetScrollMaxY();
        [DllImport(cimguiLib)]
        public static extern void igSetScrollX(float scroll_x);
        [DllImport(cimguiLib)]
        public static extern void igSetScrollY(float scroll_y);
        [DllImport(cimguiLib)]
        public static extern void igSetScrollHere(float center_y_ratio = 0.5f);

        [DllImport(cimguiLib)]
        public static extern void igSetScrollFromPosY(float pos_y, float center_y_ratio = 0.5f);
        [DllImport(cimguiLib)]
        public static extern void igSetKeyboardFocusHere(int offset);

        [DllImport(cimguiLib)]
        public static extern void igSetStateStorage(ref Storage tree);

        [DllImport(cimguiLib)]
        public static extern Storage* igGetStateStorage();

        // Parameters stacks (shared)
        [DllImport(cimguiLib)]
        public static extern void igPushFont(Font* font);
        [DllImport(cimguiLib)]
        public static extern void igPopFont();
        [DllImport(cimguiLib)]
        public static extern void igPushStyleColor(ColorTarget idx, Vector4 col);
        [DllImport(cimguiLib)]
        public static extern void igPopStyleColor(int count);
        [DllImport(cimguiLib)]
        public static extern void igPushStyleVar(StyleVar idx, float val);
        [DllImport(cimguiLib)]
        public static extern void igPushStyleVarVec(StyleVar idx, Vector2 val);
        [DllImport(cimguiLib)]
        public static extern void igPopStyleVar(int count);

        // Parameters stacks (current window)
        [DllImport(cimguiLib)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport(cimguiLib)]
        public static extern void igPopItemWidth();
        [DllImport(cimguiLib)]
        public static extern float igCalcItemWidth();
        [DllImport(cimguiLib)]
        public static extern void igPushTextWrapPos(float wrap_pos_x);
        [DllImport(cimguiLib)]
        public static extern void igPopTextWrapPos();
        [DllImport(cimguiLib)]
        public static extern void igPushAllowKeyboardFocus(bool v);
        [DllImport(cimguiLib)]
        public static extern void igPopAllowKeyboardFocus();
        [DllImport(cimguiLib)]
        public static extern void igPushButtonRepeat(bool repeat);
        [DllImport(cimguiLib)]
        public static extern void igPopButtonRepeat();

        // Layout
        [DllImport(cimguiLib)]
        public static extern void igBeginGroup();
        [DllImport(cimguiLib)]
        public static extern void igEndGroup();
        [DllImport(cimguiLib)]
        public static extern void igSeparator();
        [DllImport(cimguiLib)]
        public static extern void igSameLine(float local_pos_x, float spacing_w);
        [DllImport(cimguiLib)]
        public static extern void igSpacing();
        [DllImport(cimguiLib)]
        public static extern void igDummy(Vector2* size);
        [DllImport(cimguiLib)]
        public static extern void igIndent();
        [DllImport(cimguiLib)]
        public static extern void igUnindent();
        [DllImport(cimguiLib)]
        public static extern void igColumns(int count, string id, bool border);
        [DllImport(cimguiLib)]
        public static extern void igNextColumn();
        [DllImport(cimguiLib)]
        public static extern int igGetColumnIndex();
        [DllImport(cimguiLib)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport(cimguiLib)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport(cimguiLib)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport(cimguiLib)]
        public static extern int igGetColumnsCount();
        [DllImport(cimguiLib)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [DllImport(cimguiLib)]
        public static extern float igGetCursorPosX();
        [DllImport(cimguiLib)]
        public static extern float igGetCursorPosY();
        [DllImport(cimguiLib)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport(cimguiLib)]
        public static extern void igSetCursorPosX(float x);
        [DllImport(cimguiLib)]
        public static extern void igSetCursorPosY(float y);
        [DllImport(cimguiLib)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [DllImport(cimguiLib)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [DllImport(cimguiLib)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport(cimguiLib)]
        public static extern void igAlignFirstTextHeightToWidgets();
        [DllImport(cimguiLib)]
        public static extern float igGetTextLineHeight();
        [DllImport(cimguiLib)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport(cimguiLib)]
        public static extern float igGetItemsLineHeightWithSpacing();

        // ID scopes
        // If you are creating widgets in a loop you most likely want to push a unique identifier so ImGui can differentiate them
        // You can also use "##extra" within your widget name to distinguish them from each others (see 'Programmer Guide')
        [DllImport(cimguiLib)]
        public static extern void igPushIdStr(string str_id);
        [DllImport(cimguiLib)]
        public static extern void igPushIdStrRange(string str_begin, string str_end);
        [DllImport(cimguiLib)]
        public static extern void igPushIdPtr(void* ptr_id);
        [DllImport(cimguiLib)]
        public static extern void igPushIdInt(int int_id);
        [DllImport(cimguiLib)]
        public static extern void igPopId();
        [DllImport(cimguiLib)]
        public static extern uint igGetIdStr(string str_id);
        [DllImport(cimguiLib)]
        public static extern uint igGetIdStrRange(string str_begin, string str_end);
        [DllImport(cimguiLib)]
        public static extern uint igGetIdPtr(void* ptr_id);

        // Widgets
        [DllImport(cimguiLib)]
        public static extern void igText(string fmt);

        [DllImport(cimguiLib)]
        public static extern void igTextColored(Vector4 col, string fmt);

        [DllImport(cimguiLib)]
        public static extern void igTextDisabled(string fmt);
        [DllImport(cimguiLib)]
        public static extern void igTextWrapped(string fmt);

        [DllImport(cimguiLib)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);

        [DllImport(cimguiLib)]
        public static extern void igLabelText(string label, string fmt);

        [DllImport(cimguiLib)]
        public static extern void igBullet();

        [DllImport(cimguiLib)]
        public static extern void igBulletText(string fmt);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igButton(string label, Vector2 size);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSmallButton(string label);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInvisibleButton(string str_id, Vector2 size);
        [DllImport(cimguiLib)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCollapsingHeader(string label, string str_id, bool display_frame, bool default_open);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCheckbox(string label, ref bool v);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCheckboxFlags(string label, UIntPtr* flags, uint flags_value);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igRadioButtonBool(string label, bool active);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igRadioButton(string label, int* v, int v_button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCombo(string label, ref int current_item, char** items, int items_count, int height_in_items);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCombo2(string label, ref int current_item, string items_separated_by_zeros, int height_in_items);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igCombo3(string label, ref int current_item, ItemSelectedCallback items_getter, IntPtr data, int items_count, int height_in_items);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igColorButton(Vector4 col, bool small_height, bool outline_border);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igColorEdit3(string label, Vector3 col);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igColorEdit4(string label, Vector4 col, bool show_alpha);
        [DllImport(cimguiLib)]
        public static extern void igColorEditMode(ColorEditMode mode);
        [DllImport(cimguiLib)]
        public static extern void igPlotLines(string label, float* values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

        /*
        [DllImport(LibName)]
        public static extern void igPlotLines2(string label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size);
        */
        [DllImport(cimguiLib)]
        public static extern void igPlotHistogram(string label, float* values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

        /*
        [DllImport(LibName)]
        public static extern void igPlotHistogram2(string label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size);
        */

        // Widgets: Sliders (tip: ctrl+click on a slider to input text)
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderFloat(string label, float* v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderFloat(string label, ref float v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderInt(string label, ref int v, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderInt2(string label, ref Int2 v, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderInt3(string label, ref Int3 v, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSliderInt4(string label, ref Int4 v, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igVSliderFloat(string label, Vector2 size, float* v, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igVSliderInt(string label, Vector2 size, int* v, int v_min, int v_max, string display_format);

        // Widgets: Drags (tip: ctrl+click on a drag box to input text)
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string display_format, float power);     // If v_max >= v_max we have no bound
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string display_format = "%.3f", string display_format_max = null, float power = 1.0f);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragInt(string label, ref int v, float v_speed, int v_min, int v_max, string display_format);                                       // If v_max >= v_max we have no bound
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragInt2(string label, ref Int2 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragInt3(string label, ref Int3 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragInt4(string label, ref Int4 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igDragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string display_format = "%.0f", string display_format_max = null);


        // Widgets: Input
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputText(string label, IntPtr buffer, uint buf_size, InputTextFlags flags, TextEditCallback callback, void* user_data);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputTextMultiline(string label, IntPtr buffer, uint buf_size, Vector2 size, InputTextFlags flags, TextEditCallback callback, void* user_data);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputFloat(string label, float* v, float step, float step_fast, int decimal_precision, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputFloat2(string label, Vector2 v, int decimal_precision, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputFloat3(string label, Vector3 v, int decimal_precision, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputFloat4(string label, Vector4 v, int decimal_precision, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputInt(string label, int* v, int step, int step_fast, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputInt2(string label, Int2 v, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputInt3(string label, Int3 v, InputTextFlags extra_flags);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igInputInt4(string label, Int4 v, InputTextFlags extra_flags);

        // Widgets: Trees
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igTreeNode(string str_label_id);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igTreeNodeStr(string str_id, string fmt);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igTreeNodePtr(void* ptr_id, string fmt);

        [DllImport(cimguiLib)]
        public static extern void igTreePushStr(string str_id);
        [DllImport(cimguiLib)]
        public static extern void igTreePushPtr(void* ptr_id);
        [DllImport(cimguiLib)]
        public static extern void igTreePop();
        [DllImport(cimguiLib)]
        public static extern void igSetNextTreeNodeOpened(bool opened, SetCondition cond);

        // Widgets: Selectable / Lists
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSelectable(string label, bool selected, SelectableFlags flags, Vector2 size);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igSelectableEx(string label, ref bool p_selected, SelectableFlags flags, Vector2 size);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igListBox(string label, int* current_item, char** items, int items_count, int height_in_items);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igListBox2(string label, ref int currentItem, ItemSelectedCallback items_getter, IntPtr data, int items_count, int height_in_items);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igListBoxHeader(string label, Vector2 size);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igListBoxHeader2(string label, int items_count, int height_in_items);
        [DllImport(cimguiLib)]
        public static extern void igListBoxFooter();

        // Widgets: Value() Helpers. Output single value in "name: value" format (tip: freely declare your own within the ImGui namespace!)
        [DllImport(cimguiLib)]
        public static extern void igValueBool(string prefix, bool b);
        [DllImport(cimguiLib)]
        public static extern void igValueInt(string prefix, int v);
        [DllImport(cimguiLib)]
        public static extern void igValueUInt(string prefix, uint v);
        [DllImport(cimguiLib)]
        public static extern void igValueFloat(string prefix, float v, string float_format);
        [DllImport(cimguiLib)]
        public static extern void igColor(string prefix, Vector4 v);
        [DllImport(cimguiLib)]
        public static extern void igColor2(string prefix, uint v);

        // Tooltip
        [DllImport(cimguiLib)]
        public static extern void igSetTooltip(string fmt);
        [DllImport(cimguiLib)]
        public static extern void igBeginTooltip();
        [DllImport(cimguiLib)]
        public static extern void igEndTooltip();

        // Widgets: Menus
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginMainMenuBar();
        [DllImport(cimguiLib)]
        public static extern void igEndMainMenuBar();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginMenuBar();
        [DllImport(cimguiLib)]
        public static extern void igEndMenuBar();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginMenu(string label);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginMenu(string label, bool enabled);
        [DllImport(cimguiLib)]
        public static extern void igEndMenu();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igMenuItem(string label, string shortcut, bool selected, bool enabled);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igMenuItemPtr(string label, string shortcut, bool* p_selected, bool enabled);

        // Popup
        [DllImport(cimguiLib)]
        public static extern void igOpenPopup(string str_id);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginPopup(string str_id);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginPopupModal(string name, byte* p_opened, WindowFlags extra_flags);

        public static bool igBeginPopupModal(string name, WindowFlags extra_flags)
        {
            return igBeginPopupModal(name, null, extra_flags);
        }

        public static bool igBeginPopupModal(string name, ref bool p_opened, WindowFlags extra_flags)
        {
            byte value = p_opened ? (byte)1 : (byte)0;
            bool result = igBeginPopupModal(name, &value, extra_flags);

            p_opened = value == 1 ? true : false;
            return result;
        }

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginPopupContextItem(string str_id, int mouse_button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginPopupContextWindow(bool also_over_items, string str_id, int mouse_button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginPopupContextVoid(string str_id, int mouse_button);
        [DllImport(cimguiLib)]
        public static extern void igEndPopup();
        [DllImport(cimguiLib)]
        public static extern void igCloseCurrentPopup();

        // Logging: all text output from interface is redirected to tty/file/clipboard. Tree nodes are automatically opened.
        [DllImport(cimguiLib)]
        public static extern void igLogToTTY(int max_depth);
        [DllImport(cimguiLib)]
        public static extern void igLogToFile(int max_depth, string filename);
        [DllImport(cimguiLib)]
        public static extern void igLogToClipboard(int max_depth);
        [DllImport(cimguiLib)]
        public static extern void igLogFinish();
        [DllImport(cimguiLib)]
        public static extern void igLogButtons();

        [DllImport(cimguiLib)]
        //public static extern void igLogText(string fmt, ...);
        public static extern void igLogText(string fmt);

        // Utilities
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsItemHovered();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsItemHoveredRect();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsItemActive();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsItemVisible();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsAnyItemHovered();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsAnyItemActive();
        [DllImport(cimguiLib)]
        public static extern void igGetItemRectMin(out Vector2 pOut);
        [DllImport(cimguiLib)]
        public static extern void igGetItemRectMax(out Vector2 pOut);
        [DllImport(cimguiLib)]
        public static extern void igGetItemRectSize(out Vector2 pOut);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsWindowHovered();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsWindowFocused();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsRootWindowFocused();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsRootWindowOrAnyChildFocused();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsRectVisible(Vector2 item_size);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsPosHoveringAnyWindow(Vector2 pos);
        [DllImport(cimguiLib)]
        public static extern float igGetTime();
        [DllImport(cimguiLib)]
        public static extern int igGetFrameCount();
        [DllImport(cimguiLib)]
        public static extern string igGetStyleColName(ColorTarget idx);
        [DllImport(cimguiLib)]
        public static extern void igCalcItemRectClosestPoint(out Vector2 pOut, Vector2 pos, bool on_edge, float outward);
        [DllImport(cimguiLib)]
        public static extern void igCalcTextSize(out Vector2 pOut, char* text, char* text_end, bool hide_text_after_double_hash, float wrap_width);
        [DllImport(cimguiLib)]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igBeginChildFrame(uint id, Vector2 size, WindowFlags extra_flags);
        [DllImport(cimguiLib)]
        public static extern void igEndChildFrame();

        [DllImport(cimguiLib)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport(cimguiLib)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport(cimguiLib)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport(cimguiLib)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsKeyDown(int key_index);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsKeyPressed(int key_index, bool repeat);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsKeyReleased(int key_index);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseDown(int button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseClicked(int button, bool repeat);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseDoubleClicked(int button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseReleased(int button);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseHoveringWindow();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseHoveringAnyWindow();
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseHoveringRect(Vector2 pos_min, Vector2 pos_max, bool clip);
        [DllImport(cimguiLib)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool igIsMouseDragging(int button, float lock_threshold);
        [DllImport(cimguiLib)]
        public static extern void igGetMousePos(out Vector2 pOut);
        [DllImport(cimguiLib)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(out Vector2 pOut);
        [DllImport(cimguiLib)]
        public static extern void igGetMouseDragDelta(out Vector2 pOut, int button, float lock_threshold);
        [DllImport(cimguiLib)]
        public static extern void igResetMouseDragDelta(int button);
        [DllImport(cimguiLib)]
        public static extern MouseCursorKind igGetMouseCursor();
        [DllImport(cimguiLib)]
        public static extern void igSetMouseCursor(MouseCursorKind type);
        [DllImport(cimguiLib)]
        public static extern void igCaptureKeyboardFromApp();
        [DllImport(cimguiLib)]
        public static extern void igCaptureMouseFromApp();

        // Helpers functions to access functions pointers @in ImGui::GetIO()
        [DllImport(cimguiLib)]
        public static extern void* igMemAlloc(uint sz);
        [DllImport(cimguiLib)]
        public static extern void igMemFree(void* ptr);
        [DllImport(cimguiLib)]
        public static extern string igGetClipboardText();
        [DllImport(cimguiLib)]
        public static extern void igSetClipboardText(string text);

        // public state access - if you want to share ImGui state between modules (e.g. DLL) or allocate it yourself
        [DllImport(cimguiLib)]
        public static extern string igGetVersion();
        [DllImport(cimguiLib)]
        public static extern void* igGetpublicState();
        [DllImport(cimguiLib)]
        public static extern uint igGetpublicStateSize();
        [DllImport(cimguiLib)]
        public static extern void igSetpublicState(void* state, bool construct);


        [DllImport(cimguiLib)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(FontAtlas* atlas, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport(cimguiLib)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(FontAtlas* atlas, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport(cimguiLib)]
        public static extern void ImFontAtlas_SetTexID(FontAtlas* atlas, void* tex);

        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFont(FontAtlas* atlas, ref FontConfig font_cfg);

        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFontDefault(FontAtlas* atlas, IntPtr font_cfg);
        public static Font* ImFontAtlas_AddFontDefault(FontAtlas* atlas) { return ImFontAtlas_AddFontDefault(atlas, IntPtr.Zero); }

        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFontFromFileTTF(FontAtlas* atlas, string filename, float size_pixels, IntPtr font_cfg, char* glyph_ranges);
        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFontFromMemoryTTF(FontAtlas* atlas, void* ttf_data, int ttf_size, float size_pixels, IntPtr font_cfg, char* glyph_ranges);
        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFontFromMemoryCompressedTTF(FontAtlas* atlas, void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, FontConfig* font_cfg, char* glyph_ranges);
        [DllImport(cimguiLib)]
        public static extern Font* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(FontAtlas* atlas, string compressed_ttf_data_base85, float size_pixels, FontConfig* font_cfg, char* glyph_ranges);

        [DllImport(cimguiLib)]
        public static extern void ImFontAtlas_ClearTexData(FontAtlas* atlas);
        [DllImport(cimguiLib)]
        public static extern void ImFontAtlas_Clear(FontAtlas* atlas);


        [DllImport(cimguiLib)]
        public static extern void ImGuiIO_AddInputCharacter(ushort c);
        [DllImport(cimguiLib)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(string utf8_chars);

        [DllImport(cimguiLib)]
        public static extern int ImDrawList_GetVertexBufferSize(DrawList* list);
        [DllImport(cimguiLib)]
        public static extern DrawVert* ImDrawList_GetVertexPtr(DrawList* list, int n);
        [DllImport(cimguiLib)]
        public static extern int ImDrawList_GetIndexBufferSize(DrawList* list);
        [DllImport(cimguiLib)]
        public static extern ushort* ImDrawList_GetIndexPtr(DrawList* list, int n);
        [DllImport(cimguiLib)]
        public static extern int ImDrawList_GetCmdSize(DrawList* list);
        [DllImport(cimguiLib)]
        public static extern DrawCmd* ImDrawList_GetCmdPtr(DrawList* list, int n);
        [DllImport(cimguiLib)]
        public static extern void ImDrawData_DeIndexAllBuffers(DrawData* drawData);
    }

    public delegate bool ItemSelectedCallback(IntPtr data, int index, string out_text);
}
