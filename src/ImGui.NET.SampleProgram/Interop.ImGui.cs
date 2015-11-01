using System.Runtime.InteropServices;
using System.Numerics;

using ImGuiWindowFlags = System.IntPtr;
using ImGuiSetCond = System.IntPtr;
using ImGuiColorEditMode = System.IntPtr;
using ImVec2 = System.Numerics.Vector2;
using ImVec4 = System.Numerics.Vector4;
using ImGuiID = System.UInt32;
using ImTextureID = System.IntPtr;
using System;
using ImGuiStoragePtr = System.IntPtr;
using ImGuiCol = System.Int32;
using ImGuiStyleVar = System.Int32;
using size_t = System.UIntPtr;
using ImGuiInputTextFlags = System.Int32;

using ImGuiTextEditCallback = System.Func<System.IntPtr, System.IntPtr>;
// typedef int (* ImGuiTextEditCallback)(ImGuiTextEditCallbackData* data);

using ImGuiSelectableFlags = System.Int32;
using ImU32 = System.UInt32;
using ImGuiMouseCursor = System.Int32;
using ImDrawIdx = System.UInt16;

namespace ImGui
{
    internal static unsafe class Interop
    {
        private const string LibName = "cimgui";
        [DllImport(LibName)]
        internal static extern IntPtr igGetIO();
        internal static ImGuiIO* GetIOPtr() { return (ImGuiIO*)igGetIO().ToPointer(); }

        [DllImport(LibName)]
        internal static extern ImGuiStyle* igGetStyle();

        [DllImport(LibName)]
        internal static extern IntPtr igGetDrawData();
        internal static ImDrawData* GetDrawDataPtr()
        {
            return (ImDrawData*)igGetDrawData().ToPointer();
        }

        [DllImport(LibName)]
        internal static extern void igNewFrame();
        [DllImport(LibName)]
        internal static extern void igRender();
        [DllImport(LibName)]
        internal static extern void igShutdown();
        [DllImport(LibName)]
        internal static extern void igShowUserGuide();
        [DllImport(LibName)]
        internal static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport(LibName)]
        internal static extern void igShowTestWindow(bool* opened);
        [DllImport(LibName)]
        internal static extern void igShowMetricsWindow(bool* opened);

        // Window
        [DllImport(LibName)]
        internal static extern bool igBegin(string name, bool* p_opened, ImGuiWindowFlags flags);
        [DllImport(LibName)]
        internal static extern bool igBegin2(string name, bool* p_opened, ImVec2 size_on_first_use, float bg_alpha, ImGuiWindowFlags flags);
        [DllImport(LibName)]
        internal static extern void igEnd();
        [DllImport(LibName)]
        internal static extern bool igBeginChild(string str_id, ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igBeginChildEx(ImGuiID id, ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
        [DllImport(LibName)]
        internal static extern void igEndChild();
        [DllImport(LibName)]
        internal static extern void igGetContentRegionMax(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern void igGetContentRegionAvail(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern float igGetContentRegionAvailWidth();                                       //
        [DllImport(LibName)]
        internal static extern void igGetWindowContentRegionMin(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern void igGetWindowContentRegionMax(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern float igGetWindowContentRegionWidth();                                      //
        [DllImport(LibName)]
        internal static extern ImDrawList* igGetWindowDrawList();
        [DllImport(LibName)]
        internal static extern ImFont* igGetWindowFont();
        [DllImport(LibName)]
        internal static extern float igGetWindowFontSize();
        [DllImport(LibName)]
        internal static extern void igSetWindowFontScale(float scale);
        [DllImport(LibName)]
        internal static extern void igGetWindowPos(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern void igGetWindowSize(ImVec2* @out);
        [DllImport(LibName)]
        internal static extern float igGetWindowWidth();
        [DllImport(LibName)]
        internal static extern float igGetWindowHeight();
        [DllImport(LibName)]
        internal static extern bool igIsWindowCollapsed();

        [DllImport(LibName)]
        internal static extern void igSetNextWindowPos(ImVec2 pos, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowPosCenter(ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowSize(ImVec2 size, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowContentSize(ImVec2 size);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowContentWidth(float width);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowCollapsed(bool collapsed, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetNextWindowFocus();
        [DllImport(LibName)]
        internal static extern void igSetWindowPos(ImVec2 pos, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowSize(ImVec2 size, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowCollapsed(bool collapsed, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowFocus();
        [DllImport(LibName)]
        internal static extern void igSetWindowPosByName(string name, ImVec2 pos, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowSize2(string name, ImVec2 size, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowCollapsed2(string name, bool collapsed, ImGuiSetCond cond);
        [DllImport(LibName)]
        internal static extern void igSetWindowFocus2(string name);

        [DllImport(LibName)]
        internal static extern float igGetScrollX();
        [DllImport(LibName)]
        internal static extern float igGetScrollY();
        [DllImport(LibName)]
        internal static extern float igGetScrollMaxX();
        [DllImport(LibName)]
        internal static extern float igGetScrollMaxY();
        [DllImport(LibName)]
        internal static extern void igSetScrollX(float scroll_x);
        [DllImport(LibName)]
        internal static extern void igSetScrollY(float scroll_y);
        [DllImport(LibName)]
        internal static extern void igSetScrollHere(float center_y_ratio = 0.5f);
        [DllImport(LibName)]
        internal static extern void igSetScrollFromPosY(float pos_y, float center_y_ratio = 0.5f);
        [DllImport(LibName)]
        internal static extern void igSetKeyboardFocusHere(int offset);

        [DllImport(LibName)]
        //internal static extern void igSetStateStorage(ImGuiStorage* tree);
        internal static extern void igSetStateStorage(ImGuiStoragePtr tree);

        [DllImport(LibName)]
        internal static extern ImGuiStoragePtr* igGetStateStorage();

        // Parameters stacks (shared)
        [DllImport(LibName)]
        internal static extern void igPushFont(ImFont* font);
        [DllImport(LibName)]
        internal static extern void igPopFont();
        [DllImport(LibName)]
        internal static extern void igPushStyleColor(ImGuiCol idx, ImVec4 col);
        [DllImport(LibName)]
        internal static extern void igPopStyleColor(int count);
        [DllImport(LibName)]
        internal static extern void igPushStyleVar(ImGuiStyleVar idx, float val);
        [DllImport(LibName)]
        internal static extern void igPushStyleVarVec(ImGuiStyleVar idx, ImVec2 val);
        [DllImport(LibName)]
        internal static extern void igPopStyleVar(int count);

        // Parameters stacks (current window)
        [DllImport(LibName)]
        internal static extern void igPushItemWidth(float item_width);
        [DllImport(LibName)]
        internal static extern void igPopItemWidth();
        [DllImport(LibName)]
        internal static extern float igCalcItemWidth();
        [DllImport(LibName)]
        internal static extern void igPushTextWrapPos(float wrap_pos_x);
        [DllImport(LibName)]
        internal static extern void igPopTextWrapPos();
        [DllImport(LibName)]
        internal static extern void igPushAllowKeyboardFocus(bool v);
        [DllImport(LibName)]
        internal static extern void igPopAllowKeyboardFocus();
        [DllImport(LibName)]
        internal static extern void igPushButtonRepeat(bool repeat);
        [DllImport(LibName)]
        internal static extern void igPopButtonRepeat();

        // Layout
        [DllImport(LibName)]
        internal static extern void igBeginGroup();
        [DllImport(LibName)]
        internal static extern void igEndGroup();
        [DllImport(LibName)]
        internal static extern void igSeparator();
        [DllImport(LibName)]
        internal static extern void igSameLine(float local_pos_x, float spacing_w);
        [DllImport(LibName)]
        internal static extern void igSpacing();
        [DllImport(LibName)]
        internal static extern void igDummy(ImVec2* size);
        [DllImport(LibName)]
        internal static extern void igIndent();
        [DllImport(LibName)]
        internal static extern void igUnindent();
        [DllImport(LibName)]
        internal static extern void igColumns(int count, string id, bool border);
        [DllImport(LibName)]
        internal static extern void igNextColumn();
        [DllImport(LibName)]
        internal static extern int igGetColumnIndex();
        [DllImport(LibName)]
        internal static extern float igGetColumnOffset(int column_index);
        [DllImport(LibName)]
        internal static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport(LibName)]
        internal static extern float igGetColumnWidth(int column_index);
        [DllImport(LibName)]
        internal static extern int igGetColumnsCount();
        [DllImport(LibName)]
        internal static extern void igGetCursorPos(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern float igGetCursorPosX();
        [DllImport(LibName)]
        internal static extern float igGetCursorPosY();
        [DllImport(LibName)]
        internal static extern void igSetCursorPos(ImVec2 local_pos);
        [DllImport(LibName)]
        internal static extern void igSetCursorPosX(float x);
        [DllImport(LibName)]
        internal static extern void igSetCursorPosY(float y);
        [DllImport(LibName)]
        internal static extern void igGetCursorStartPos(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igGetCursorScreenPos(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igSetCursorScreenPos(ImVec2 pos);
        [DllImport(LibName)]
        internal static extern void igAlignFirstTextHeightToWidgets();
        [DllImport(LibName)]
        internal static extern float igGetTextLineHeight();
        [DllImport(LibName)]
        internal static extern float igGetTextLineHeightWithSpacing();
        [DllImport(LibName)]
        internal static extern float igGetItemsLineHeightWithSpacing();

        // ID scopes
        // If you are creating widgets @in a loop you most likely want to push a unique identifier so ImGui can differentiate them
        // You can also use "##extra" within your widget name to distinguish them from each others (see 'Programmer Guide')
        [DllImport(LibName)]
        internal static extern void igPushIdStr(string str_id);
        [DllImport(LibName)]
        internal static extern void igPushIdStrRange(string str_begin, string str_end);
        [DllImport(LibName)]
        internal static extern void igPushIdPtr(void* ptr_id);
        [DllImport(LibName)]
        internal static extern void igPushIdInt(int int_id);
        [DllImport(LibName)]
        internal static extern void igPopId();
        [DllImport(LibName)]
        internal static extern ImGuiID igGetIdStr(string str_id);
        [DllImport(LibName)]
        internal static extern ImGuiID igGetIdStrRange(string str_begin, string str_end);
        [DllImport(LibName)]
        internal static extern ImGuiID igGetIdPtr(void* ptr_id);

        // Widgets
        [DllImport(LibName)]
        //internal static extern void igText(string fmt, ...);
        internal static extern void igText(string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igTextV(string fmt, va_list args);
        */

        [DllImport(LibName)]
        //internal static extern void igTextColored(ImVec4 col, string fmt, ...);
        internal static extern void igTextColored(ImVec4 col, string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igTextColoredV(ImVec4 col, string fmt, va_list args);
        */

        [DllImport(LibName)]
        //internal static extern void igTextDisabled(string fmt, ...);
        internal static extern void igTextDisabled(string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igTextDisabledV(string fmt, va_list args);
        */

        [DllImport(LibName)]
        //internal static extern void igTextWrapped(string fmt, ...);
        internal static extern void igTextWrapped(string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igTextWrappedV(string fmt, va_list args);
        */

        [DllImport(LibName)]
        internal static extern void igTextUnformatted(string text, string text_end);

        [DllImport(LibName)]
        //internal static extern void igLabelText(string label, string fmt, ...);
        internal static extern void igLabelText(string label, string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igLabelTextV(string label, string fmt, va_list args);
        */

        [DllImport(LibName)]
        internal static extern void igBullet();

        [DllImport(LibName)]
        //internal static extern void igBulletText(string fmt, ...);
        internal static extern void igBulletText(string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igBulletTextV(string fmt, va_list args);
        */

        [DllImport(LibName)]
        internal static extern bool igButton(string label, ImVec2 size);
        [DllImport(LibName)]
        internal static extern bool igSmallButton(string label);
        [DllImport(LibName)]
        internal static extern bool igInvisibleButton(string str_id, ImVec2 size);
        [DllImport(LibName)]
        internal static extern void igImage(ImTextureID user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, ImVec4 tint_col, ImVec4 border_col);
        [DllImport(LibName)]
        internal static extern bool igImageButton(ImTextureID user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, int frame_padding, ImVec4 bg_col, ImVec4 tint_col);
        [DllImport(LibName)]
        internal static extern bool igCollapsingHeader(string label, string str_id, bool display_frame, bool default_open);
        [DllImport(LibName)]
        internal static extern bool igCheckbox(string label, bool* v);
        [DllImport(LibName)]
        internal static extern bool igCheckboxFlags(string label, UIntPtr* flags, uint flags_value);
        [DllImport(LibName)]
        internal static extern bool igRadioButtonBool(string label, bool active);
        [DllImport(LibName)]
        internal static extern bool igRadioButton(string label, int* v, int v_button);
        [DllImport(LibName)]
        internal static extern bool igCombo(string label, int* current_item, char** items, int items_count, int height_in_items);
        [DllImport(LibName)]
        internal static extern bool igCombo2(string label, int* current_item, string items_separated_by_zeros, int height_in_items);

        /*
        [DllImport(LibName)]
        internal static extern bool igCombo3(string label, int* current_item, bool(*items_getter)(void* data, int idx, string* out_text), void* data, int items_count, int height_in_items);
        */

        [DllImport(LibName)]
        internal static extern bool igColorButton(ImVec4 col, bool small_height, bool outline_border);
        [DllImport(LibName)]
        internal static extern bool igColorEdit3(string label, Vector3 col);
        [DllImport(LibName)]
        internal static extern bool igColorEdit4(string label, Vector4 col, bool show_alpha);
        [DllImport(LibName)]
        internal static extern void igColorEditMode(ImGuiColorEditMode mode);
        [DllImport(LibName)]
        internal static extern void igPlotLines(string label, float* values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        /*
        [DllImport(LibName)]
        internal static extern void igPlotLines2(string label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, ImVec2 graph_size);
        */
        [DllImport(LibName)]
        internal static extern void igPlotHistogram(string label, float* values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);

        /*
        [DllImport(LibName)]
        internal static extern void igPlotHistogram2(string label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, ImVec2 graph_size);
        */

        // Widgets: Sliders (tip: ctrl+click on a slider to input text)
        [DllImport(LibName)]
        internal static extern bool igSliderFloat(string label, float* v, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igSliderFloat2(string label, Vector2 v, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igSliderFloat3(string label, Vector3 v, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igSliderFloat4(string label, Vector4 v, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igSliderAngle(string label, float* v_rad, float v_degrees_min, float v_degrees_max);
        [DllImport(LibName)]
        internal static extern bool igSliderInt(string label, int* v, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igSliderInt2(string label, Int2 v, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igSliderInt3(string label, Int3 v, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igSliderInt4(string label, Int4 v, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igVSliderFloat(string label, ImVec2 size, float* v, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igVSliderInt(string label, ImVec2 size, int* v, int v_min, int v_max, string display_format);

        // Widgets: Drags (tip: ctrl+click on a drag box to input text)
        [DllImport(LibName)]
        internal static extern bool igDragFloat(string label, float* v, float v_speed, float v_min, float v_max, string display_format, float power);     // If v_max >= v_max we have no bound
        [DllImport(LibName)]
        internal static extern bool igDragFloat2(string label, Vector2 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igDragFloat3(string label, Vector3 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igDragFloat4(string label, Vector4 v, float v_speed, float v_min, float v_max, string display_format, float power);
        [DllImport(LibName)]
        internal static extern bool igDragFloatRange2(string label, float* v_current_min, float* v_current_max, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string display_format = "%.3f", string display_format_max = null, float power = 1.0f);
        [DllImport(LibName)]
        internal static extern bool igDragInt(string label, int* v, float v_speed, int v_min, int v_max, string display_format);                                       // If v_max >= v_max we have no bound
        [DllImport(LibName)]
        internal static extern bool igDragInt2(string label, Int2 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igDragInt3(string label, Int3 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igDragInt4(string label, Int4 v, float v_speed, int v_min, int v_max, string display_format);
        [DllImport(LibName)]
        internal static extern bool igDragIntRange2(string label, int* v_current_min, int* v_current_max, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string display_format = "%.0f", string display_format_max = null);


        // Widgets: Input
        [DllImport(LibName)]
        internal static extern bool igInputText(string label, string buf, size_t buf_size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
        [DllImport(LibName)]
        internal static extern bool igInputTextMultiline(string label, string buf, size_t buf_size, ImVec2 size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
        [DllImport(LibName)]
        internal static extern bool igInputFloat(string label, float* v, float step, float step_fast, int decimal_precision, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputFloat2(string label, Vector2 v, int decimal_precision, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputFloat3(string label, Vector3 v, int decimal_precision, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputFloat4(string label, Vector4 v, int decimal_precision, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputInt(string label, int* v, int step, int step_fast, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputInt2(string label, Int2 v, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputInt3(string label, Int3 v, ImGuiInputTextFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igInputInt4(string label, Int4 v, ImGuiInputTextFlags extra_flags);

        // Widgets: Trees
        [DllImport(LibName)]
        internal static extern bool igTreeNode(string str_label_id);

        [DllImport(LibName)]
        //internal static extern bool igTreeNodeStr(string str_id, string fmt, ...);
        internal static extern bool igTreeNodeStr(string str_id, string fmt);

        [DllImport(LibName)]
        //internal static extern bool igTreeNodePtr(void* ptr_id, string fmt, ...);
        internal static extern bool igTreeNodePtr(void* ptr_id, string fmt);

        /*
        [DllImport(LibName)]
        internal static extern bool igTreeNodeStrV(string str_id, string fmt, va_list args);
        [DllImport(LibName)]
        internal static extern bool igTreeNodePtrV(void* ptr_id, string fmt, va_list args);
        */

        [DllImport(LibName)]
        internal static extern void igTreePushStr(string str_id);
        [DllImport(LibName)]
        internal static extern void igTreePushPtr(void* ptr_id);
        [DllImport(LibName)]
        internal static extern void igTreePop();
        [DllImport(LibName)]
        internal static extern void igSetNextTreeNodeOpened(bool opened, ImGuiSetCond cond);

        // Widgets: Selectable / Lists
        [DllImport(LibName)]
        internal static extern bool igSelectable(string label, bool selected, ImGuiSelectableFlags flags, ImVec2 size);
        [DllImport(LibName)]
        internal static extern bool igSelectableEx(string label, bool* p_selected, ImGuiSelectableFlags flags, ImVec2 size);
        [DllImport(LibName)]
        internal static extern bool igListBox(string label, int* current_item, char** items, int items_count, int height_in_items);

        /*
        [DllImport(LibName)]
        internal static extern bool igListBox2(string label, int* current_item, bool(*items_getter)(void* data, int idx, string* out_text), void* data, int items_count, int height_in_items);
        */

        [DllImport(LibName)]
        internal static extern bool igListBoxHeader(string label, ImVec2 size);
        [DllImport(LibName)]
        internal static extern bool igListBoxHeader2(string label, int items_count, int height_in_items);
        [DllImport(LibName)]
        internal static extern void igListBoxFooter();

        // Widgets: Value() Helpers. Output single value @in "name: value" format (tip: freely declare your own within the ImGui namespace!)
        [DllImport(LibName)]
        internal static extern void igValueBool(string prefix, bool b);
        [DllImport(LibName)]
        internal static extern void igValueInt(string prefix, int v);
        [DllImport(LibName)]
        internal static extern void igValueUInt(string prefix, uint v);
        [DllImport(LibName)]
        internal static extern void igValueFloat(string prefix, float v, string float_format);
        [DllImport(LibName)]
        internal static extern void igColor(string prefix, ImVec4 v);
        [DllImport(LibName)]
        internal static extern void igColor2(string prefix, uint v);

        // Tooltip
        [DllImport(LibName)]
        //internal static extern void igSetTooltip(string fmt, ...);
        internal static extern void igSetTooltip(string fmt);

        /*
        [DllImport(LibName)]
        internal static extern void igSetTooltipV(string fmt, va_list args);
        */

        [DllImport(LibName)]
        internal static extern void igBeginTooltip();
        [DllImport(LibName)]
        internal static extern void igEndTooltip();

        // Widgets: Menus
        [DllImport(LibName)]
        internal static extern bool igBeginMainMenuBar();
        [DllImport(LibName)]
        internal static extern void igEndMainMenuBar();
        [DllImport(LibName)]
        internal static extern bool igBeginMenuBar();
        [DllImport(LibName)]
        internal static extern void igEndMenuBar();
        [DllImport(LibName)]
        internal static extern bool igBeginMenu(string label, bool enabled);
        [DllImport(LibName)]
        internal static extern void igEndMenu();
        [DllImport(LibName)]
        internal static extern bool igMenuItem(string label, string shortcut, bool selected, bool enabled);
        [DllImport(LibName)]
        internal static extern bool igMenuItemPtr(string label, string shortcut, bool* p_selected, bool enabled);

        // Popup
        [DllImport(LibName)]
        internal static extern void igOpenPopup(string str_id);
        [DllImport(LibName)]
        internal static extern bool igBeginPopup(string str_id);
        [DllImport(LibName)]
        internal static extern bool igBeginPopupModal(string name, bool* p_opened, ImGuiWindowFlags extra_flags);
        [DllImport(LibName)]
        internal static extern bool igBeginPopupContextItem(string str_id, int mouse_button);
        [DllImport(LibName)]
        internal static extern bool igBeginPopupContextWindow(bool also_over_items, string str_id, int mouse_button);
        [DllImport(LibName)]
        internal static extern bool igBeginPopupContextVoid(string str_id, int mouse_button);
        [DllImport(LibName)]
        internal static extern void igEndPopup();
        [DllImport(LibName)]
        internal static extern void igCloseCurrentPopup();

        // Logging: all text output from interface is redirected to tty/file/clipboard. Tree nodes are automatically opened.
        [DllImport(LibName)]
        internal static extern void igLogToTTY(int max_depth);
        [DllImport(LibName)]
        internal static extern void igLogToFile(int max_depth, string filename);
        [DllImport(LibName)]
        internal static extern void igLogToClipboard(int max_depth);
        [DllImport(LibName)]
        internal static extern void igLogFinish();
        [DllImport(LibName)]
        internal static extern void igLogButtons();

        [DllImport(LibName)]
        //internal static extern void igLogText(string fmt, ...);
        internal static extern void igLogText(string fmt);

        // Utilities
        [DllImport(LibName)]
        internal static extern bool igIsItemHovered();
        [DllImport(LibName)]
        internal static extern bool igIsItemHoveredRect();
        [DllImport(LibName)]
        internal static extern bool igIsItemActive();
        [DllImport(LibName)]
        internal static extern bool igIsItemVisible();
        [DllImport(LibName)]
        internal static extern bool igIsAnyItemHovered();
        [DllImport(LibName)]
        internal static extern bool igIsAnyItemActive();
        [DllImport(LibName)]
        internal static extern void igGetItemRectMin(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igGetItemRectMax(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igGetItemRectSize(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern bool igIsWindowHovered();
        [DllImport(LibName)]
        internal static extern bool igIsWindowFocused();
        [DllImport(LibName)]
        internal static extern bool igIsRootWindowFocused();
        [DllImport(LibName)]
        internal static extern bool igIsRootWindowOrAnyChildFocused();
        [DllImport(LibName)]
        internal static extern bool igIsRectVisible(ImVec2 item_size);
        [DllImport(LibName)]
        internal static extern bool igIsPosHoveringAnyWindow(ImVec2 pos);
        [DllImport(LibName)]
        internal static extern float igGetTime();
        [DllImport(LibName)]
        internal static extern int igGetFrameCount();
        [DllImport(LibName)]
        internal static extern string igGetStyleColName(ImGuiCol idx);
        [DllImport(LibName)]
        internal static extern void igCalcItemRectClosestPoint(ImVec2* pOut, ImVec2 pos, bool on_edge, float outward);
        [DllImport(LibName)]
        internal static extern void igCalcTextSize(ImVec2* pOut, string text, string text_end, bool hide_text_after_double_hash, float wrap_width);
        [DllImport(LibName)]
        internal static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);

        [DllImport(LibName)]
        internal static extern bool igBeginChildFrame(ImGuiID id, ImVec2 size, ImGuiWindowFlags extra_flags);
        [DllImport(LibName)]
        internal static extern void igEndChildFrame();

        [DllImport(LibName)]
        internal static extern void igColorConvertU32ToFloat4(ImVec4* pOut, ImU32 @in);
        [DllImport(LibName)]
        internal static extern ImU32 igColorConvertFloat4ToU32(ImVec4 @in);
        [DllImport(LibName)]
        internal static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport(LibName)]
        internal static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

        [DllImport(LibName)]
        internal static extern bool igIsKeyDown(int key_index);
        [DllImport(LibName)]
        internal static extern bool igIsKeyPressed(int key_index, bool repeat);
        [DllImport(LibName)]
        internal static extern bool igIsKeyReleased(int key_index);
        [DllImport(LibName)]
        internal static extern bool igIsMouseDown(int button);
        [DllImport(LibName)]
        internal static extern bool igIsMouseClicked(int button, bool repeat);
        [DllImport(LibName)]
        internal static extern bool igIsMouseDoubleClicked(int button);
        [DllImport(LibName)]
        internal static extern bool igIsMouseReleased(int button);
        [DllImport(LibName)]
        internal static extern bool igIsMouseHoveringWindow();
        [DllImport(LibName)]
        internal static extern bool igIsMouseHoveringAnyWindow();
        [DllImport(LibName)]
        internal static extern bool igIsMouseHoveringRect(ImVec2 pos_min, ImVec2 pos_max, bool clip);
        [DllImport(LibName)]
        internal static extern bool igIsMouseDragging(int button, float lock_threshold);
        [DllImport(LibName)]
        internal static extern void igGetMousePos(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igGetMousePosOnOpeningCurrentPopup(ImVec2* pOut);
        [DllImport(LibName)]
        internal static extern void igGetMouseDragDelta(ImVec2* pOut, int button, float lock_threshold);
        [DllImport(LibName)]
        internal static extern void igResetMouseDragDelta(int button);
        [DllImport(LibName)]
        internal static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport(LibName)]
        internal static extern void igSetMouseCursor(ImGuiMouseCursor type);
        [DllImport(LibName)]
        internal static extern void igCaptureKeyboardFromApp();
        [DllImport(LibName)]
        internal static extern void igCaptureMouseFromApp();

        // Helpers functions to access functions pointers @in ImGui::GetIO()
        [DllImport(LibName)]
        internal static extern void* igMemAlloc(size_t sz);
        [DllImport(LibName)]
        internal static extern void igMemFree(void* ptr);
        [DllImport(LibName)]
        internal static extern string igGetClipboardText();
        [DllImport(LibName)]
        internal static extern void igSetClipboardText(string text);

        // Internal state access - if you want to share ImGui state between modules (e.g. DLL) or allocate it yourself
        [DllImport(LibName)]
        internal static extern string igGetVersion();
        [DllImport(LibName)]
        internal static extern void* igGetInternalState();
        [DllImport(LibName)]
        internal static extern size_t igGetInternalStateSize();
        [DllImport(LibName)]
        internal static extern void igSetInternalState(void* state, bool construct);


        [DllImport(LibName)]
        internal static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* atlas, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport(LibName)]
        internal static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* atlas, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [DllImport(LibName)]
        internal static extern void ImFontAtlas_SetTexID(ImFontAtlas* atlas, void* tex);

        /*
        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* atlas, ImFontConfig* font_cfg);
        */

        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* atlas, IntPtr font_cfg);

        /*
        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* atlas, string filename, float size_pixels, ImFontConfig* font_cfg, ImWstring glyph_ranges);
        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* atlas, void* ttf_data, int ttf_size, float size_pixels, ImFontConfig* font_cfg, ImWstring glyph_ranges);
        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* atlas, void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, ImFontConfig* font_cfg, ImWstring glyph_ranges);
        [DllImport(LibName)]
        internal static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* atlas, string compressed_ttf_data_base85, float size_pixels, ImFontConfig* font_cfg, ImWstring glyph_ranges);
            */
        [DllImport(LibName)]
        internal static extern void ImFontAtlas_ClearTexData(ImFontAtlas* atlas);
        [DllImport(LibName)]
        internal static extern void ImFontAtlas_Clear(ImFontAtlas* atlas);


        [DllImport(LibName)]
        internal static extern void ImGuiIO_AddInputCharacter(ushort c);
        [DllImport(LibName)]
        internal static extern void ImGuiIO_AddInputCharactersUTF8(string utf8_chars);

        [DllImport(LibName)]
        internal static extern int ImDrawList_GetVertexBufferSize(ImDrawList* list);
        [DllImport(LibName)]
        internal static extern ImDrawVert* ImDrawList_GetVertexPtr(ImDrawList* list, int n);
        [DllImport(LibName)]
        internal static extern int ImDrawList_GetIndexBufferSize(ImDrawList* list);
        [DllImport(LibName)]
        internal static extern ImDrawIdx* ImDrawList_GetIndexPtr(ImDrawList* list, int n);
        [DllImport(LibName)]
        internal static extern int ImDrawList_GetCmdSize(ImDrawList* list);
        [DllImport(LibName)]
        internal static extern ImDrawCmd* ImDrawList_GetCmdPtr(ImDrawList* list, int n);
        [DllImport(LibName)]
        internal static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* drawData);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Int2
    {
        public readonly int X, Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Int3
    {
        public readonly int X, Y, Z;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Int4
    {
        public readonly int X, Y, Z, W;
    }


}
