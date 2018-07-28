using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public unsafe static class ImGuiNative
    {
        [DllImport("cimgui")]
        public static extern float igGetFrameHeight();
        [DllImport("cimgui")]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cimgui")]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport("cimgui")]
        public static extern void igPopFont();
        [DllImport("cimgui")]
        public static extern byte igCombo(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport("cimgui")]
        public static extern byte igComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport("cimgui")]
        public static extern void igCaptureKeyboardFromApp(byte capture);
        [DllImport("cimgui")]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport("cimgui")]
        public static extern void igRender();
        [DllImport("cimgui")]
        public static extern void ImDrawList_ChannelsSetCurrent(int channel_index);
        [DllImport("cimgui")]
        public static extern byte igDragFloat4(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void ImDrawList_ChannelsSplit(int channels_count);
        [DllImport("cimgui")]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport("cimgui")]
        public static extern Vector2 igGetCursorScreenPos();
        [DllImport("cimgui")]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert);
        [DllImport("cimgui")]
        public static extern void igSetScrollHere(float center_y_ratio);
        [DllImport("cimgui")]
        public static extern void igSetScrollY(float scroll_y);
        [DllImport("cimgui")]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport("cimgui")]
        public static extern void igSetScrollFromPosY(float pos_y, float center_y_ratio);
        [DllImport("cimgui")]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport("cimgui")]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport("cimgui")]
        public static extern void ImVec4_ImVec4();
        [DllImport("cimgui")]
        public static extern void ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
        [DllImport("cimgui")]
        public static extern void ImColor_SetHSV(float h, float s, float v, float a);
        [DllImport("cimgui")]
        public static extern byte igDragFloat3(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddPolyline(Vector2* points, int num_points, uint col, byte closed, float thickness);
        [DllImport("cimgui")]
        public static extern void igValueBool(byte* prefix, byte b);
        [DllImport("cimgui")]
        public static extern void igValueInt(byte* prefix, int v);
        [DllImport("cimgui")]
        public static extern void igValueUint(byte* prefix, uint v);
        [DllImport("cimgui")]
        public static extern void igValueFloat(byte* prefix, float v, byte* float_format);
        [DllImport("cimgui")]
        public static extern void ImGuiTextFilter_Build();
        [DllImport("cimgui")]
        public static extern Vector2 igGetItemRectMax();
        [DllImport("cimgui")]
        public static extern byte igIsItemDeactivated();
        [DllImport("cimgui")]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);
        [DllImport("cimgui")]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport("cimgui")]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport("cimgui")]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max);
        [DllImport("cimgui")]
        public static extern void igUnindent(float indent_w);
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, char* glyph_ranges);
        [DllImport("cimgui")]
        public static extern void igPopAllowKeyboardFocus();
        [DllImport("cimgui")]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport("cimgui")]
        public static extern Vector2 igGetCursorStartPos();
        [DllImport("cimgui")]
        public static extern void igSetCursorScreenPos(Vector2 screen_pos);
        [DllImport("cimgui")]
        public static extern void ImFont_AddRemapChar(char dst, char src, byte overwrite_dst);
        [DllImport("cimgui")]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void ImFont_AddGlyph(char c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport("cimgui")]
        public static extern void ImFont_GrowIndex(int new_size);
        [DllImport("cimgui")]
        public static extern byte igIsRectVisible(Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igIsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport("cimgui")]
        public static extern void ImFont_RenderText(ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport("cimgui")]
        public static extern byte ImFontAtlas_Build();
        [DllImport("cimgui")]
        public static extern byte igSliderFloat4(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern ImFontGlyph* ImFont_FindGlyph(char c);
        [DllImport("cimgui")]
        public static extern void igLogFinish();
        [DllImport("cimgui")]
        public static extern byte igIsKeyPressed(int user_key_index, byte repeat);
        [DllImport("cimgui")]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PopClipRect();
        [DllImport("cimgui")]
        public static extern byte* ImFont_CalcWordWrapPositionA(float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern IntPtr igGetCurrentContext();
        [DllImport("cimgui")]
        public static extern byte igSmallButton(byte* label);
        [DllImport("cimgui")]
        public static extern byte igOpenPopupOnItemClick(byte* str_id, int mouse_button);
        [DllImport("cimgui")]
        public static extern byte igIsAnyMouseDown();
        [DllImport("cimgui")]
        public static extern Vector2 ImFont_CalcTextSizeA(float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_SetBit(int n);
        [DllImport("cimgui")]
        public static extern byte ImFont_IsLoaded();
        [DllImport("cimgui")]
        public static extern float ImFont_GetCharAdvance(char c);
        [DllImport("cimgui")]
        public static extern void ImFont_SetFallbackChar(char c);
        [DllImport("cimgui")]
        public static extern byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cimgui")]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(char c);
        [DllImport("cimgui")]
        public static extern void igEndFrame();
        [DllImport("cimgui")]
        public static extern byte igSliderFloat2(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void ImFont_RenderChar(ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport("cimgui")]
        public static extern byte igRadioButtonBool(byte* label, byte active);
        [DllImport("cimgui")]
        public static extern byte igRadioButtonIntPtr(byte* label, int* v, int v_button);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui")]
        public static extern void ImGuiTextEditCallbackData_DeleteChars(int pos, int bytes_count);
        [DllImport("cimgui")]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* v, int components, void* step, void* step_fast, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathBezierCurveTo(Vector2 p1, Vector2 p2, Vector2 p3, int num_segments);
        [DllImport("cimgui")]
        public static extern void ImGuiPayload_Clear();
        [DllImport("cimgui")]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern byte igIsItemFocused();
        [DllImport("cimgui")]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport("cimgui")]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void igSetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern void igSetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void ImFont_ImFont();
        [DllImport("cimgui")]
        public static extern void ImGuiTextEditCallbackData_InsertChars(int pos, byte* text, byte* text_end);
        [DllImport("cimgui")]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float out_h, float out_s, float out_v);
        [DllImport("cimgui")]
        public static extern byte igBeginMenuBar();
        [DllImport("cimgui")]
        public static extern byte igIsPopupOpen(byte* str_id);
        [DllImport("cimgui")]
        public static extern byte igIsItemVisible();
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_CalcCustomRectUV(CustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport("cimgui")]
        public static extern CustomRect* ImFontAtlas_GetCustomRectByIndex(int index);
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_AddText(byte* text, byte* text_end);
        [DllImport("cimgui")]
        public static extern byte TextRange_is_blank(byte c);
        [DllImport("cimgui")]
        public static extern void igSetScrollX(float scroll_x);
        [DllImport("cimgui")]
        public static extern int ImFontAtlas_AddCustomRectRegular(uint id, int width, int height);
        [DllImport("cimgui")]
        public static extern void igSetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern void igSetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern Vector2 igGetMouseDragDelta(int button, float lock_threshold);
        [DllImport("cimgui")]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport("cimgui")]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport("cimgui")]
        public static extern byte CustomRect_IsPacked();
        [DllImport("cimgui")]
        public static extern void igPlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui")]
        public static extern byte ImFontAtlas_IsBuilt();
        [DllImport("cimgui")]
        public static extern void ImVec2_ImVec2();
        [DllImport("cimgui")]
        public static extern void ImVec2_ImVec2Float(float _x, float _y);
        [DllImport("cimgui")]
        public static extern byte ImGuiPayload_IsDataType(byte* type);
        [DllImport("cimgui")]
        public static extern void ImDrawList_Clear();
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_AddRanges(char* ranges);
        [DllImport("cimgui")]
        public static extern Vector2 igGetMousePos();
        [DllImport("cimgui")]
        public static extern byte* ImFont_GetDebugName();
        [DllImport("cimgui")]
        public static extern void igListBoxFooter();
        [DllImport("cimgui")]
        public static extern void igPopClipRect();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddBezierCurve(Vector2 pos0, Vector2 cp0, Vector2 cp1, Vector2 pos1, uint col, float thickness, int num_segments);
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_GlyphRangesBuilder();
        [DllImport("cimgui")]
        public static extern Vector2 igGetWindowSize();
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesThai();
        [DllImport("cimgui")]
        public static extern byte igCheckboxFlags(byte* label, uint* flags, uint flags_value);
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesCyrillic();
        [DllImport("cimgui")]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon();
        [DllImport("cimgui")]
        public static extern void igPlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui")]
        public static extern byte igBeginPopupContextVoid(byte* str_id, int mouse_button);
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesChineseFull();
        [DllImport("cimgui")]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport("cimgui")]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport("cimgui")]
        public static extern Vector2 igGetWindowPos();
        [DllImport("cimgui")]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport("cimgui")]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport("cimgui")]
        public static extern void TextRange_trim_blanks();
        [DllImport("cimgui")]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport("cimgui")]
        public static extern void igLogToFile(int max_depth, byte* filename);
        [DllImport("cimgui")]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport("cimgui")]
        public static extern byte ImGuiStorage_GetBool(uint key, byte default_val);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PushTextureID(IntPtr texture_id);
        [DllImport("cimgui")]
        public static extern void igTreeAdvanceToLabelPos();
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesDefault();
        [DllImport("cimgui")]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_SetTexID(IntPtr id);
        [DllImport("cimgui")]
        public static extern byte igIsAnyItemActive();
        [DllImport("cimgui")]
        public static extern void igShowFontSelector(byte* label);
        [DllImport("cimgui")]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddRectFilled(Vector2 a, Vector2 b, uint col, float rounding, int rounding_corners_flags);
        [DllImport("cimgui")]
        public static extern float igGetCursorPosX();
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_ClearFonts();
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_ClearTexData();
        [DllImport("cimgui")]
        public static extern int igGetColumnsCount();
        [DllImport("cimgui")]
        public static extern void igPopButtonRepeat();
        [DllImport("cimgui")]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* v, int components, float v_speed, void* v_min, void* v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern byte ImGuiPayload_IsPreview();
        [DllImport("cimgui")]
        public static extern void igSpacing();
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_Clear();
        [DllImport("cimgui")]
        public static extern byte igIsAnyItemFocused();
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, char* glyph_ranges);
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, char* glyph_ranges);
        [DllImport("cimgui")]
        public static extern void igMemFree(void* ptr);
        [DllImport("cimgui")]
        public static extern Vector2 igGetFontTexUvWhitePixel();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddDrawCmd();
        [DllImport("cimgui")]
        public static extern byte igIsItemClicked(int mouse_button);
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(byte* filename, float size_pixels, ImFontConfig* font_cfg, char* glyph_ranges);
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontConfig* font_cfg);
        [DllImport("cimgui")]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport("cimgui")]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontConfig* font_cfg);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport("cimgui")]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern void ImFont_BuildLookupTable();
        [DllImport("cimgui")]
        public static extern float igGetScrollX();
        [DllImport("cimgui")]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);
        [DllImport("cimgui")]
        public static extern ImDrawList* igGetOverlayDrawList();
        [DllImport("cimgui")]
        public static extern uint igGetIDStr(byte* str_id);
        [DllImport("cimgui")]
        public static extern uint igGetIDStrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui")]
        public static extern uint igGetIDPtr(void* ptr_id);
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesJapanese();
        [DllImport("cimgui")]
        public static extern void ImFontConfig_ImFontConfig();
        [DllImport("cimgui")]
        public static extern void ImDrawData_ScaleClipRects(Vector2 sc);
        [DllImport("cimgui")]
        public static extern byte igIsMouseReleased(int button);
        [DllImport("cimgui")]
        public static extern void ImDrawData_DeIndexAllBuffers();
        [DllImport("cimgui")]
        public static extern Vector2 igGetItemRectMin();
        [DllImport("cimgui")]
        public static extern void ImDrawData_Clear();
        [DllImport("cimgui")]
        public static extern void igLogText(byte* fmt);
        [DllImport("cimgui")]
        public static extern void* ImGuiStorage_GetVoidPtr(uint key);
        [DllImport("cimgui")]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport("cimgui")]
        public static extern void ImDrawList_UpdateTextureID();
        [DllImport("cimgui")]
        public static extern void ImDrawList_UpdateClipRect();
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimVtx(Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui")]
        public static extern int igGetFrameCount();
        [DllImport("cimgui")]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size);
        [DllImport("cimgui")]
        public static extern byte* igGetClipboardText();
        [DllImport("cimgui")]
        public static extern byte igColorPicker4(byte* label, float* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimRect(Vector2 a, Vector2 b, uint col);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddQuad(Vector2 a, Vector2 b, Vector2 c, Vector2 d, uint col, float thickness);
        [DllImport("cimgui")]
        public static extern void ImDrawList_ClearFreeMemory();
        [DllImport("cimgui")]
        public static extern void igSetNextTreeNodeOpen(byte is_open, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern void igLogToTTY(int max_depth);
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_BuildRanges(ImVector out_ranges);
        [DllImport("cimgui")]
        public static extern ImDrawList* ImDrawList_CloneOutput();
        [DllImport("cimgui")]
        public static extern ImGuiIO* igGetIO();
        [DllImport("cimgui")]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void igNextColumn();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddRect(Vector2 a, Vector2 b, uint col, float rounding, int rounding_corners_flags, float thickness);
        [DllImport("cimgui")]
        public static extern void TextRange_split(byte separator, ImVector @out);
        [DllImport("cimgui")]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport("cimgui")]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddCallback(IntPtr callback, void* callback_data);
        [DllImport("cimgui")]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport("cimgui")]
        public static extern float igGetScrollMaxY();
        [DllImport("cimgui")]
        public static extern void igBeginTooltip();
        [DllImport("cimgui")]
        public static extern void igEndGroup();
        [DllImport("cimgui")]
        public static extern ImDrawData* igGetDrawData();
        [DllImport("cimgui")]
        public static extern float igGetTextLineHeight();
        [DllImport("cimgui")]
        public static extern void igSeparator();
        [DllImport("cimgui")]
        public static extern byte igBeginChild(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern byte igBeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathRect(Vector2 rect_min, Vector2 rect_max, float rounding, int rounding_corners_flags);
        [DllImport("cimgui")]
        public static extern byte igIsMouseClicked(int button, byte repeat);
        [DllImport("cimgui")]
        public static extern float igCalcItemWidth();
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathArcToFast(Vector2 centre, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport("cimgui")]
        public static extern void igEndChildFrame();
        [DllImport("cimgui")]
        public static extern void igIndent(float indent_w);
        [DllImport("cimgui")]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint size, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern byte GlyphRangesBuilder_GetBit(int n);
        [DllImport("cimgui")]
        public static extern byte ImGuiTextFilter_Draw(byte* label, float width);
        [DllImport("cimgui")]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathStroke(uint col, byte closed, float thickness);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathFillConvex(uint col);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathLineToMergeDuplicate(Vector2 pos);
        [DllImport("cimgui")]
        public static extern void igEndMenu();
        [DllImport("cimgui")]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui")]
        public static extern void igSetWindowFocus();
        [DllImport("cimgui")]
        public static extern void igSetWindowFocusStr(byte* name);
        [DllImport("cimgui")]
        public static extern void igSetClipboardText(byte* text);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathArcTo(Vector2 centre, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddConvexPolyFilled(Vector2* points, int num_points, uint col);
        [DllImport("cimgui")]
        public static extern byte igIsWindowCollapsed();
        [DllImport("cimgui")]
        public static extern void ImGuiIO_AddInputCharacter(char c);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddImageQuad(IntPtr user_texture_id, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowFocus();
        [DllImport("cimgui")]
        public static extern void igSameLine(float pos_x, float spacing_w);
        [DllImport("cimgui")]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern byte igColorEdit3(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddImage(IntPtr user_texture_id, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("cimgui")]
        public static extern void ImGuiIO_AddInputCharactersUTF8(byte* utf8_chars);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddText(Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddTextFontPtr(ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddCircleFilled(Vector2 centre, float radius, uint col, int num_segments);
        [DllImport("cimgui")]
        public static extern byte igDragFloat2(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void igPushButtonRepeat(byte repeat);
        [DllImport("cimgui")]
        public static extern void igPopItemWidth();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddCircle(Vector2 centre, float radius, uint col, int num_segments, float thickness);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddTriangleFilled(Vector2 a, Vector2 b, Vector2 c, uint col);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddTriangle(Vector2 a, Vector2 b, Vector2 c, uint col, float thickness);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddQuadFilled(Vector2 a, Vector2 b, Vector2 c, Vector2 d, uint col);
        [DllImport("cimgui")]
        public static extern float igGetFontSize();
        [DllImport("cimgui")]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimReserve(int idx_count, int vtx_count);
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddRectFilledMultiColor(Vector2 a, Vector2 b, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport("cimgui")]
        public static extern void igEndPopup();
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_ClearInputData();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddLine(Vector2 a, Vector2 b, uint col, float thickness);
        [DllImport("cimgui")]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
        [DllImport("cimgui")]
        public static extern byte igSelectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igSelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport("cimgui")]
        public static extern void ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport("cimgui")]
        public static extern Vector2 ImDrawList_GetClipRectMin();
        [DllImport("cimgui")]
        public static extern void ImDrawList_PopTextureID();
        [DllImport("cimgui")]
        public static extern byte igInputFloat4(byte* label, float* v, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void igNewLine();
        [DllImport("cimgui")]
        public static extern byte* igGetVersion();
        [DllImport("cimgui")]
        public static extern void igEndCombo();
        [DllImport("cimgui")]
        public static extern byte TextRange_front();
        [DllImport("cimgui")]
        public static extern void igPushIDStr(byte* str_id);
        [DllImport("cimgui")]
        public static extern void igPushIDRange(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui")]
        public static extern void igPushIDPtr(void* ptr_id);
        [DllImport("cimgui")]
        public static extern void igPushIDInt(int int_id);
        [DllImport("cimgui")]
        public static extern void ImDrawList_ImDrawList(IntPtr* shared_data);
        [DllImport("cimgui")]
        public static extern void ImDrawCmd_ImDrawCmd();
        [DllImport("cimgui")]
        public static extern void igAlignTextToFramePadding();
        [DllImport("cimgui")]
        public static extern void igPopStyleColor(int count);
        [DllImport("cimgui")]
        public static extern void ImGuiListClipper_End();
        [DllImport("cimgui")]
        public static extern void igText(byte* fmt);
        [DllImport("cimgui")]
        public static extern void ImGuiListClipper_Begin(int items_count, float items_height);
        [DllImport("cimgui")]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport("cimgui")]
        public static extern byte ImGuiListClipper_Step();
        [DllImport("cimgui")]
        public static extern float* ImGuiStorage_GetFloatRef(uint key, float default_val);
        [DllImport("cimgui")]
        public static extern void igEndTooltip();
        [DllImport("cimgui")]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void ImGuiListClipper_ImGuiListClipper(int items_count, float items_height);
        [DllImport("cimgui")]
        public static extern void igEndMainMenuBar();
        [DllImport("cimgui")]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float out_r, float out_g, float out_b);
        [DllImport("cimgui")]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui")]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport("cimgui")]
        public static extern void ImGuiIO_ImGuiIO();
        [DllImport("cimgui")]
        public static extern byte igBeginMainMenuBar();
        [DllImport("cimgui")]
        public static extern void CustomRect_CustomRect();
        [DllImport("cimgui")]
        public static extern void ImGuiPayload_ImGuiPayload();
        [DllImport("cimgui")]
        public static extern float igGetWindowContentRegionWidth();
        [DllImport("cimgui")]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport("cimgui")]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* v, void* v_min, void* v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_SetVoidPtr(uint key, void* val);
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_SetAllInt(int val);
        [DllImport("cimgui")]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport("cimgui")]
        public static extern byte igSliderFloat3(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void** ImGuiStorage_GetVoidPtrRef(uint key, void* default_val);
        [DllImport("cimgui")]
        public static extern float igGetWindowHeight();
        [DllImport("cimgui")]
        public static extern Vector2 igGetMousePosOnOpeningCurrentPopup();
        [DllImport("cimgui")]
        public static extern byte* ImGuiStorage_GetBoolRef(uint key, byte default_val);
        [DllImport("cimgui")]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [DllImport("cimgui")]
        public static extern int* ImGuiStorage_GetIntRef(uint key, int default_val);
        [DllImport("cimgui")]
        public static extern void igEndDragDropSource();
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_BuildSortByKey();
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_SetFloat(uint key, float val);
        [DllImport("cimgui")]
        public static extern float ImGuiStorage_GetFloat(uint key, float default_val);
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_SetBool(uint key, byte val);
        [DllImport("cimgui")]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_SetInt(uint key, int val);
        [DllImport("cimgui")]
        public static extern void igCloseCurrentPopup();
        [DllImport("cimgui")]
        public static extern void ImGuiTextBuffer_clear();
        [DllImport("cimgui")]
        public static extern void igPushTextWrapPos(float wrap_pos_x);
        [DllImport("cimgui")]
        public static extern void ImGuiStorage_Clear();
        [DllImport("cimgui")]
        public static extern void Pair_PairInt(uint _key, int _val_i);
        [DllImport("cimgui")]
        public static extern void Pair_PairFloat(uint _key, float _val_f);
        [DllImport("cimgui")]
        public static extern void Pair_PairPtr(uint _key, void* _val_p);
        [DllImport("cimgui")]
        public static extern void ImGuiTextBuffer_appendf(byte* fmt);
        [DllImport("cimgui")]
        public static extern byte* ImGuiTextBuffer_c_str();
        [DllImport("cimgui")]
        public static extern void ImGuiTextBuffer_reserve(int capacity);
        [DllImport("cimgui")]
        public static extern byte ImGuiTextBuffer_empty();
        [DllImport("cimgui")]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* v, void* v_min, void* v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void igTreePushStr(byte* str_id);
        [DllImport("cimgui")]
        public static extern void igTreePushPtr(void* ptr_id);
        [DllImport("cimgui")]
        public static extern int ImGuiTextBuffer_size();
        [DllImport("cimgui")]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport("cimgui")]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimWriteVtx(Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui")]
        public static extern void igBullet();
        [DllImport("cimgui")]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern byte igIsMouseDoubleClicked(int button);
        [DllImport("cimgui")]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport("cimgui")]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport("cimgui")]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern byte igIsItemDeactivatedAfterChange();
        [DllImport("cimgui")]
        public static extern Vector4 igColorConvertU32ToFloat4(uint @in);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport("cimgui")]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern void igOpenPopup(byte* str_id);
        [DllImport("cimgui")]
        public static extern Vector2 igGetWindowContentRegionMax();
        [DllImport("cimgui")]
        public static extern Vector2 ImDrawList_GetClipRectMax();
        [DllImport("cimgui")]
        public static extern void ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport("cimgui")]
        public static extern IntPtr* igGetDrawListSharedData();
        [DllImport("cimgui")]
        public static extern byte* TextRange_end();
        [DllImport("cimgui")]
        public static extern byte igIsItemActive();
        [DllImport("cimgui")]
        public static extern byte* TextRange_begin();
        [DllImport("cimgui")]
        public static extern void TextRange_TextRange();
        [DllImport("cimgui")]
        public static extern void TextRange_TextRangeStr(byte* _b, byte* _e);
        [DllImport("cimgui")]
        public static extern byte igBeginDragDropTarget();
        [DllImport("cimgui")]
        public static extern byte TextRange_empty();
        [DllImport("cimgui")]
        public static extern byte ImGuiPayload_IsDelivery();
        [DllImport("cimgui")]
        public static extern void ImGuiIO_ClearInputCharacters();
        [DllImport("cimgui")]
        public static extern void ImDrawList_AddImageRounded(IntPtr user_texture_id, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col, float rounding, int rounding_corners);
        [DllImport("cimgui")]
        public static extern uint igGetColorU32(ImGuiCol idx, float alpha_mul);
        [DllImport("cimgui")]
        public static extern uint igGetColorU32Vec4(Vector4 col);
        [DllImport("cimgui")]
        public static extern uint igGetColorU32U32(uint col);
        [DllImport("cimgui")]
        public static extern void ImGuiStyle_ImGuiStyle();
        [DllImport("cimgui")]
        public static extern Vector2 igGetContentRegionMax();
        [DllImport("cimgui")]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport("cimgui")]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport("cimgui")]
        public static extern void ImFont_ClearOutputData();
        [DllImport("cimgui")]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("cimgui")]
        public static extern void igEndDragDropTarget();
        [DllImport("cimgui")]
        public static extern char* ImFontAtlas_GetGlyphRangesKorean();
        [DllImport("cimgui")]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cimgui")]
        public static extern void igNewFrame();
        [DllImport("cimgui")]
        public static extern void igResetMouseDragDelta(int button);
        [DllImport("cimgui")]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport("cimgui")]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport("cimgui")]
        public static extern void GlyphRangesBuilder_AddChar(char c);
        [DllImport("cimgui")]
        public static extern void igPopID();
        [DllImport("cimgui")]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport("cimgui")]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport("cimgui")]
        public static extern byte ImGuiTextFilter_IsActive();
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathClear();
        [DllImport("cimgui")]
        public static extern byte igIsKeyReleased(int user_key_index);
        [DllImport("cimgui")]
        public static extern void igBeginGroup();
        [DllImport("cimgui")]
        public static extern void ImColor_ImColor();
        [DllImport("cimgui")]
        public static extern void ImColor_ImColorInt(int r, int g, int b, int a);
        [DllImport("cimgui")]
        public static extern void ImColor_ImColorU32(uint rgba);
        [DllImport("cimgui")]
        public static extern void ImColor_ImColorFloat(float r, float g, float b, float a);
        [DllImport("cimgui")]
        public static extern void ImColor_ImColorVec4(Vector4 col);
        [DllImport("cimgui")]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport("cimgui")]
        public static extern void igPopTextWrapPos();
        [DllImport("cimgui")]
        public static extern void ImGuiTextFilter_Clear();
        [DllImport("cimgui")]
        public static extern Vector2 igCalcTextSize(byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport("cimgui")]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport("cimgui")]
        public static extern void igEndMenuBar();
        [DllImport("cimgui")]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport("cimgui")]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport("cimgui")]
        public static extern byte igIsMouseDragging(int button, float lock_threshold);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimWriteIdx(ushort idx);
        [DllImport("cimgui")]
        public static extern void ImGuiStyle_ScaleAllSizes(float scale_factor);
        [DllImport("cimgui")]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);
        [DllImport("cimgui")]
        public static extern void igPushStyleColor(ImGuiCol idx, Vector4 col);
        [DllImport("cimgui")]
        public static extern void* igMemAlloc(uint size);
        [DllImport("cimgui")]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport("cimgui")]
        public static extern void igPushItemWidth(float item_width);
        [DllImport("cimgui")]
        public static extern byte igIsWindowAppearing();
        [DllImport("cimgui")]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport("cimgui")]
        public static extern void igSetItemAllowOverlap();
        [DllImport("cimgui")]
        public static extern void igEndChild();
        [DllImport("cimgui")]
        public static extern byte igCollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui")]
        public static extern byte igCollapsingHeaderBoolPtr(byte* label, byte* p_open, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui")]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, float power);
        [DllImport("cimgui")]
        public static extern void igSetMouseCursor(ImGuiMouseCursor type);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* v, void* step, void* step_fast, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PushClipRectFullScreen();
        [DllImport("cimgui")]
        public static extern void igSetCursorPosY(float y);
        [DllImport("cimgui")]
        public static extern float igGetTime();
        [DllImport("cimgui")]
        public static extern void ImDrawList_ChannelsMerge();
        [DllImport("cimgui")]
        public static extern int igGetColumnIndex();
        [DllImport("cimgui")]
        public static extern byte igBeginPopupContextItem(byte* str_id, int mouse_button);
        [DllImport("cimgui")]
        public static extern byte igListBoxHeaderVec2(byte* label, Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igListBoxHeaderInt(byte* label, int items_count, int height_in_items);
        [DllImport("cimgui")]
        public static extern Vector2 igGetItemRectSize();
        [DllImport("cimgui")]
        public static extern void igSetCursorPosX(float x);
        [DllImport("cimgui")]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport("cimgui")]
        public static extern byte igMenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport("cimgui")]
        public static extern byte igMenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport("cimgui")]
        public static extern float igGetScrollY();
        [DllImport("cimgui")]
        public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [DllImport("cimgui")]
        public static extern byte* ImGuiTextBuffer_begin();
        [DllImport("cimgui")]
        public static extern ImFont* igGetFont();
        [DllImport("cimgui")]
        public static extern void igSetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern void igSetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern float igGetCursorPosY();
        [DllImport("cimgui")]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFont* font, char id, int width, int height, float advance_x, Vector2 offset);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui")]
        public static extern float igGetContentRegionAvailWidth();
        [DllImport("cimgui")]
        public static extern void igShowUserGuide();
        [DllImport("cimgui")]
        public static extern byte igIsKeyDown(int user_key_index);
        [DllImport("cimgui")]
        public static extern byte igIsMouseDown(int button);
        [DllImport("cimgui")]
        public static extern byte igTreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui")]
        public static extern byte igTreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui")]
        public static extern byte igTreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui")]
        public static extern void igLogButtons();
        [DllImport("cimgui")]
        public static extern Vector2 igGetWindowContentRegionMin();
        [DllImport("cimgui")]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max);
        [DllImport("cimgui")]
        public static extern byte ImGuiTextEditCallbackData_HasSelection();
        [DllImport("cimgui")]
        public static extern float igGetWindowWidth();
        [DllImport("cimgui")]
        public static extern Vector2 igGetCursorPos();
        [DllImport("cimgui")]
        public static extern int ImGuiStorage_GetInt(uint key, int default_val);
        [DllImport("cimgui")]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* v, int components, void* v_min, void* v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern ImColor ImColor_HSV(float h, float s, float v, float a);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PathLineTo(Vector2 pos);
        [DllImport("cimgui")]
        public static extern byte igInputFloat2(byte* label, float* v, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport("cimgui")]
        public static extern void igDummy(Vector2 size);
        [DllImport("cimgui")]
        public static extern byte igColorPicker3(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui")]
        public static extern void ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport("cimgui")]
        public static extern void igBulletText(byte* fmt);
        [DllImport("cimgui")]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format);
        [DllImport("cimgui")]
        public static extern byte igColorEdit4(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui")]
        public static extern void ImDrawList_PrimRectUV(Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("cimgui")]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport("cimgui")]
        public static extern void igLogToClipboard(int max_depth);
        [DllImport("cimgui")]
        public static extern byte igBeginPopupContextWindow(byte* str_id, int mouse_button, byte also_over_items);
        [DllImport("cimgui")]
        public static extern void ImFontAtlas_ImFontAtlas();
        [DllImport("cimgui")]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* v, float v_speed, void* v_min, void* v_max, byte* format, float power);
        [DllImport("cimgui")]
        public static extern void igSetItemDefaultFocus();
        [DllImport("cimgui")]
        public static extern void igCaptureMouseFromApp(byte capture);
        [DllImport("cimgui")]
        public static extern byte igIsAnyItemHovered();
        [DllImport("cimgui")]
        public static extern void igPushFont(ImFont* font);
        [DllImport("cimgui")]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport("cimgui")]
        public static extern void igTreePop();
        [DllImport("cimgui")]
        public static extern void igEnd();
        [DllImport("cimgui")]
        public static extern void ImDrawData_ImDrawData();
        [DllImport("cimgui")]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport("cimgui")]
        public static extern byte* ImGuiTextBuffer_end();
        [DllImport("cimgui")]
        public static extern void igPopStyleVar(int count);
        [DllImport("cimgui")]
        public static extern byte ImGuiTextFilter_PassFilter(byte* text, byte* text_end);
        [DllImport("cimgui")]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport("cimgui")]
        public static extern void igColumns(int count, byte* id, byte border);
        [DllImport("cimgui")]
        public static extern byte igTreeNodeStr(byte* label);
        [DllImport("cimgui")]
        public static extern byte igTreeNodeStrStr(byte* str_id, byte* fmt);
        [DllImport("cimgui")]
        public static extern byte igTreeNodePtr(void* ptr_id, byte* fmt);
        [DllImport("cimgui")]
        public static extern float igGetScrollMaxX();
        [DllImport("cimgui")]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport("cimgui")]
        public static extern Vector2 igGetContentRegionAvail();
        [DllImport("cimgui")]
        public static extern byte igInputFloat3(byte* label, float* v, byte* format, ImGuiInputTextFlags extra_flags);
        [DllImport("cimgui")]
        public static extern void igSetKeyboardFocusHere(int offset);
    }
}
