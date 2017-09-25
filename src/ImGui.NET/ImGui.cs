using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ImGuiNET
{
    public static class ImGui
    {
        public static void NewFrame()
        {
            ImGuiNative.igNewFrame();
        }

        public static void Render()
        {
            ImGuiNative.igRender();
        }

        public static void Shutdown()
        {
            ImGuiNative.igShutdown();
        }

        private static unsafe readonly IO s_io = new IO(ImGuiNative.igGetIO());

        public static unsafe IO GetIO() => s_io;

        private static unsafe readonly Style s_style = new Style(ImGuiNative.igGetStyle());

        public static unsafe Style GetStyle()
        {
            return s_style;
        }

        public static void PushID(string id)
        {
            ImGuiNative.igPushIdStr(id);
        }

        public static void PushID(int id)
        {
            ImGuiNative.igPushIdInt(id);
        }

        public static void PushIDRange(string idBegin, string idEnd)
        {
            ImGuiNative.igPushIdStrRange(idBegin, idEnd);
        }

        public static void PushItemWidth(float width)
        {
            ImGuiNative.igPushItemWidth(width);
        }

        public static void PopItemWidth()
        {
            ImGuiNative.igPopItemWidth();
        }

        public static void PopID()
        {
            ImGuiNative.igPopId();
        }

        public static uint GetID(string id)
        {
            return ImGuiNative.igGetIdStr(id);
        }

        public static uint GetID(string idBegin, string idEnd)
        {
            return ImGuiNative.igGetIdStrRange(idBegin, idEnd);
        }

        public static void Text(string message)
        {
            ImGuiNative.igText(message);
        }

        public static void Text(string message, Vector4 color)
        {
            ImGuiNative.igTextColored(color, message);
        }

        public static void TextDisabled(string text)
        {
            ImGuiNative.igTextDisabled(text);
        }

        public static void TextWrapped(string text)
        {
            ImGuiNative.igTextWrapped(text);
        }

        public static unsafe void TextUnformatted(string message)
        {
            fixed (byte* bytes = System.Text.Encoding.UTF8.GetBytes(message))
            {
                ImGuiNative.igTextUnformatted(bytes, null);
            }
        }

        public static void LabelText(string label, string text)
        {
            ImGuiNative.igLabelText(label, text);
        }

        public static void Bullet()
        {
            ImGuiNative.igBullet();
        }

        public static void BulletText(string text)
        {
            ImGuiNative.igBulletText(text);
        }

        public static bool InvisibleButton(string id) => InvisibleButton(id, Vector2.Zero);

        public static bool InvisibleButton(string id, Vector2 size)
        {
            return ImGuiNative.igInvisibleButton(id, size);
        }

        public static void Image(IntPtr userTextureID, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tintColor, Vector4 borderColor)
        {
            ImGuiNative.igImage(userTextureID, size, uv0, uv1, tintColor, borderColor);
        }

        public static bool ImageButton(
            IntPtr userTextureID,
            Vector2 size,
            Vector2 uv0,
            Vector2 uv1,
            int framePadding,
            Vector4 backgroundColor,
            Vector4 tintColor)
        {
            return ImGuiNative.igImageButton(userTextureID, size, uv0, uv1, framePadding, backgroundColor, tintColor);
        }

        //obsolete!
        public static bool CollapsingHeader(string label, string id, bool displayFrame, bool defaultOpen)
        {
            TreeNodeFlags default_open_flags = TreeNodeFlags.DefaultOpen;
            return ImGuiNative.igCollapsingHeader(label, (defaultOpen ? default_open_flags : 0));
        }


        public static bool CollapsingHeader(string label, TreeNodeFlags flags)
        {
            return ImGuiNative.igCollapsingHeader(label, flags);
        }

        public static bool Checkbox(string label, ref bool value)
        {
            return ImGuiNative.igCheckbox(label, ref value);
        }

        public static unsafe bool RadioButton(string label, ref int target, int buttonValue)
        {
            int targetCopy = target;
            bool result = ImGuiNative.igRadioButton(label, &targetCopy, buttonValue);
            target = targetCopy;
            return result;
        }

        public static bool RadioButtonBool(string label, bool active)
        {
            return ImGuiNative.igRadioButtonBool(label, active);
        }

        public unsafe static bool Combo(string label, ref int current_item, string[] items)
        {
            return ImGuiNative.igCombo(label, ref current_item, items, items.Length, 5);
        }

        public unsafe static bool Combo(string label, ref int current_item, string[] items, int heightInItems)
        {
            return ImGuiNative.igCombo(label, ref current_item, items, items.Length, heightInItems);
        }

        public static bool ColorButton(string desc_id, Vector4 color, ColorEditFlags flags, Vector2 size)
        {
            return ImGuiNative.igColorButton(desc_id, color, flags, size);
        }

        public static unsafe bool ColorEdit3(string label, ref float r, ref float g, ref float b, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector3 localColor = new Vector3(r, g, b);
            bool result = ImGuiNative.igColorEdit3(label, &localColor, flags);
            if (result)
            {
                r = localColor.X;
                g = localColor.Y;
                b = localColor.Z;
            }

            return result;
        }

        public static unsafe bool ColorEdit3(string label, ref Vector3 color, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector3 localColor = color;
            bool result = ImGuiNative.igColorEdit3(label, &localColor, flags);
            if (result)
            {
                color = localColor;
            }

            return result;
        }

        public static unsafe bool ColorEdit4(string label, ref float r, ref float g, ref float b, ref float a, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector4 localColor = new Vector4(r, g, b, a);
            bool result = ImGuiNative.igColorEdit4(label, &localColor, flags);
            if (result)
            {
                r = localColor.X;
                g = localColor.Y;
                b = localColor.Z;
                a = localColor.W;
            }

            return result;
        }

        public static unsafe bool ColorEdit4(string label, ref Vector4 color, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector4 localColor = color;
            bool result = ImGuiNative.igColorEdit4(label, &localColor, flags);
            if (result)
            {
                color = localColor;
            }

            return result;
        }

        public static unsafe bool ColorPicker3(string label, ref Vector3 color, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector3 localColor = color;
            bool result = ImGuiNative.igColorPicker3(label, &localColor, flags);
            if (result)
            {
                color = localColor;
            }
            return result;
        }

        public static unsafe bool ColorPicker4(string label, ref Vector4 color, ColorEditFlags flags = ColorEditFlags.Default)
        {
            Vector4 localColor = color;
            bool result = ImGuiNative.igColorPicker4(label, &localColor, flags);
            if (result)
            {
                color = localColor;
            }
            return result;
        }

        public unsafe static void PlotLines(
            string label,
            float[] values,
            int valuesOffset,
            string overlayText,
            float scaleMin,
            float scaleMax,
            Vector2 graphSize,
            int stride)
        {
            fixed (float* valuesBasePtr = values)
            {
                ImGuiNative.igPlotLines(
                    label,
                    valuesBasePtr,
                    values.Length,
                    valuesOffset,
                    overlayText,
                    scaleMin,
                    scaleMax,
                    graphSize,
                    stride);
            }
        }

        public unsafe static void PlotHistogram(string label, float[] values, int valuesOffset, string overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
        {
            fixed (float* valuesBasePtr = values)
            {
                ImGuiNative.igPlotHistogram(
                    label,
                    valuesBasePtr,
                    values.Length,
                    valuesOffset,
                    overlayText,
                    scaleMin,
                    scaleMax,
                    graphSize,
                    stride);
            }
        }

        public static bool SliderFloat(string sliderLabel, ref float value, float min, float max, string displayText, float power)
        {
            return ImGuiNative.igSliderFloat(sliderLabel, ref value, min, max, displayText, power);
        }

        public static bool SliderVector2(string label, ref Vector2 value, float min, float max, string displayText, float power)
        {
            return ImGuiNative.igSliderFloat2(label, ref value, min, max, displayText, power);
        }

        public static bool SliderVector3(string label, ref Vector3 value, float min, float max, string displayText, float power)
        {
            return ImGuiNative.igSliderFloat3(label, ref value, min, max, displayText, power);
        }

        public static bool SliderVector4(string label, ref Vector4 value, float min, float max, string displayText, float power)
        {
            return ImGuiNative.igSliderFloat4(label, ref value, min, max, displayText, power);
        }

        public static bool SliderAngle(string label, ref float radians, float minDegrees, float maxDegrees)
        {
            return ImGuiNative.igSliderAngle(label, ref radians, minDegrees, maxDegrees);
        }

        public static bool SliderInt(string sliderLabel, ref int value, int min, int max, string displayText)
        {
            return ImGuiNative.igSliderInt(sliderLabel, ref value, min, max, displayText);
        }

        public static bool SliderInt2(string label, ref Int2 value, int min, int max, string displayText)
        {
            return ImGuiNative.igSliderInt2(label, ref value, min, max, displayText);
        }

        public static bool SliderInt3(string label, ref Int3 value, int min, int max, string displayText)
        {
            return ImGuiNative.igSliderInt3(label, ref value, min, max, displayText);
        }

        public static bool SliderInt4(string label, ref Int4 value, int min, int max, string displayText)
        {
            return ImGuiNative.igSliderInt4(label, ref value, min, max, displayText);
        }

        public static bool DragFloat(string label, ref float value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            return ImGuiNative.igDragFloat(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static bool DragVector2(string label, ref Vector2 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            return ImGuiNative.igDragFloat2(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static bool DragVector3(string label, ref Vector3 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            return ImGuiNative.igDragFloat3(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static bool DragVector4(string label, ref Vector4 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            return ImGuiNative.igDragFloat4(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static bool DragFloatRange2(
            string label,
            ref float currentMinValue,
            ref float currentMaxValue,
            float speed = 1.0f,
            float minValueLimit = 0.0f,
            float maxValueLimit = 0.0f,
            string displayFormat = "%.3f",
            string displayFormatMax = null,
            float power = 1.0f)
        {
            return ImGuiNative.igDragFloatRange2(label, ref currentMinValue, ref currentMaxValue, speed, minValueLimit, maxValueLimit, displayFormat, displayFormatMax, power);
        }

        public static bool DragInt(string label, ref int value, float speed, int minValue, int maxValue, string displayText)
        {
            return ImGuiNative.igDragInt(label, ref value, speed, minValue, maxValue, displayText);
        }

        public static bool DragInt2(string label, ref Int2 value, float speed, int minValue, int maxValue, string displayText)
        {
            return ImGuiNative.igDragInt2(label, ref value, speed, minValue, maxValue, displayText);
        }

        public static bool DragInt3(string label, ref Int3 value, float speed, int minValue, int maxValue, string displayText)
        {
            return ImGuiNative.igDragInt3(label, ref value, speed, minValue, maxValue, displayText);
        }

        public static bool DragInt4(string label, ref Int4 value, float speed, int minValue, int maxValue, string displayText)
        {
            return ImGuiNative.igDragInt4(label, ref value, speed, minValue, maxValue, displayText);
        }

        public static bool DragIntRange2(
            string label,
            ref int currentMinValue,
            ref int currentMaxValue,
            float speed = 1.0f,
            int minLimit = 0,
            int maxLimit = 0,
            string displayFormat = "%.0f",
            string displayFormatMax = null)
        {
            return ImGuiNative.igDragIntRange2(
                label,
                ref currentMinValue,
                ref currentMaxValue,
                speed,
                minLimit,
                maxLimit,
                displayFormat,
                displayFormatMax);
        }

        public static bool Button(string message)
        {
            return ImGuiNative.igButton(message, Vector2.Zero);
        }

        public static bool Button(string message, Vector2 size)
        {
            return ImGuiNative.igButton(message, size);
        }

        public static void SetNextWindowSize(Vector2 size, Condition condition)
        {
            ImGuiNative.igSetNextWindowSize(size, condition);
        }

        public static void SetNextWindowFocus()
        {
            ImGuiNative.igSetNextWindowFocus();
        }

        public static void SetNextWindowPos(Vector2 position, Condition condition)
        {
            ImGuiNative.igSetNextWindowPos(position, condition);
        }

        public static void SetNextWindowPosCenter(Condition condition)
        {
            ImGuiNative.igSetNextWindowPosCenter(condition);
        }

        public static void AddInputCharacter(char keyChar)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(keyChar);
        }

        /// <summary>
        /// Helper to scale the ClipRect field of each ImDrawCmd.
        /// Use if your final output buffer is at a different scale than ImGui expects,
        /// or if there is a difference between your window resolution and framebuffer resolution.
        /// </summary>
        /// <param name="drawData">Pointer to the DrawData to scale.</param>
        /// <param name="scale">The scale to apply.</param>
        public static unsafe void ScaleClipRects(DrawData* drawData, Vector2 scale)
        {
            for (int i = 0; i < drawData->CmdListsCount; i++)
            {
                NativeDrawList* cmd_list = drawData->CmdLists[i];
                for (int cmd_i = 0; cmd_i < cmd_list->CmdBuffer.Size; cmd_i++)
                {
                    DrawCmd* drawCmdList = (DrawCmd*)cmd_list->CmdBuffer.Data;
                    DrawCmd* cmd = &drawCmdList[cmd_i];
                    cmd->ClipRect = new Vector4(cmd->ClipRect.X * scale.X, cmd->ClipRect.Y * scale.Y, cmd->ClipRect.Z * scale.X, cmd->ClipRect.W * scale.Y);
                }
            }
        }

        public static float GetWindowHeight()
        {
            return ImGuiNative.igGetWindowHeight();
        }


        public static float GetWindowWidth()
        {
            return ImGuiNative.igGetWindowWidth();
        }

        public static Vector2 GetWindowSize()
        {
            Vector2 size;
            ImGuiNative.igGetWindowSize(out size);
            return size;
        }

        public static Vector2 GetWindowPosition()
        {
            Vector2 pos;
            ImGuiNative.igGetWindowPos(out pos);
            return pos;
        }


        public static void SetWindowSize(Vector2 size, Condition cond = 0)
        {
            ImGuiNative.igSetWindowSize(size, cond);
        }

        public static bool BeginWindow(string windowTitle) => BeginWindow(windowTitle, WindowFlags.Default);

        public static bool BeginWindow(string windowTitle, WindowFlags flags)
        {
            bool opened = true;
            return ImGuiNative.igBegin(windowTitle, ref opened, flags);
        }

        public static bool BeginWindow(string windowTitle, ref bool opened, WindowFlags flags)
        {
            return ImGuiNative.igBegin(windowTitle, ref opened, flags);
        }

        public static bool BeginWindow(string windowTitle, ref bool opened, float backgroundAlpha, WindowFlags flags)
        {
            return ImGuiNative.igBegin2(windowTitle, ref opened, new Vector2(), backgroundAlpha, flags);
        }

        public static bool BeginWindow(string windowTitle, ref bool opened, Vector2 startingSize, WindowFlags flags)
        {
            return ImGuiNative.igBegin2(windowTitle, ref opened, startingSize, 1f, flags);
        }
        
        public static bool BeginWindow(string windowTitle, ref bool opened, Vector2 startingSize, float backgroundAlpha, WindowFlags flags)
        {
            return ImGuiNative.igBegin2(windowTitle, ref opened, startingSize, backgroundAlpha, flags);
        }

        public static bool BeginMenu(string label)
        {
            return ImGuiNative.igBeginMenu(label, true);
        }

        public static bool BeginMenu(string label, bool enabled)
        {
            return ImGuiNative.igBeginMenu(label, enabled);
        }

        public static bool BeginMenuBar()
        {
            return ImGuiNative.igBeginMenuBar();
        }

        public static void CloseCurrentPopup()
        {
            ImGuiNative.igCloseCurrentPopup();
        }

        public static void EndMenuBar()
        {
            ImGuiNative.igEndMenuBar();
        }

        public static void EndMenu()
        {
            ImGuiNative.igEndMenu();
        }

        public static void Separator()
        {
            ImGuiNative.igSeparator();
        }

        public static bool MenuItem(string label)
        {
            return MenuItem(label, string.Empty, false, true);
        }

        public static bool MenuItem(string label, string shortcut)
        {
            return MenuItem(label, shortcut, false, true);
        }

        public static bool MenuItem(string label, bool enabled)
        {
            return MenuItem(label, string.Empty, false, enabled);
        }

        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled)
        {
            return ImGuiNative.igMenuItem(label, shortcut, selected, enabled);
        }

        public static unsafe bool InputText(string label, byte[] textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback)
        {
            return InputText(label, textBuffer, bufferSize, flags, textEditCallback, IntPtr.Zero);
        }

        public static unsafe bool InputText(string label, byte[] textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback, IntPtr userData)
        {
            Debug.Assert(bufferSize <= textBuffer.Length);
            fixed (byte* ptrBuf = textBuffer)
            {
                return InputText(label, new IntPtr(ptrBuf), bufferSize, flags, textEditCallback, userData);
            }
        }

        public static unsafe bool InputText(string label, IntPtr textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback)
        {
            return InputText(label, textBuffer, bufferSize, flags, textEditCallback, IntPtr.Zero);
        }

        public static unsafe bool InputText(string label, IntPtr textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback, IntPtr userData)
        {
            return ImGuiNative.igInputText(label, textBuffer, bufferSize, flags, textEditCallback, userData.ToPointer());
        }

        public static void EndWindow()
        {
            ImGuiNative.igEnd();
        }

        public static void PushStyleColor(ColorTarget target, Vector4 color)
        {
            ImGuiNative.igPushStyleColor(target, color);
        }

        public static void PopStyleColor()
        {
            PopStyleColor(1);
        }

        public static void PopStyleColor(int numStyles)
        {
            ImGuiNative.igPopStyleColor(numStyles);
        }

        public static void PushStyleVar(StyleVar var, float value) => ImGuiNative.igPushStyleVar(var, value);
        public static void PushStyleVar(StyleVar var, Vector2 value) => ImGuiNative.igPushStyleVarVec(var, value);

        public static void PopStyleVar() => ImGuiNative.igPopStyleVar(1);
        public static void PopStyleVar(int count) => ImGuiNative.igPopStyleVar(count);

        public static unsafe void InputTextMultiline(string label, IntPtr textBuffer, uint bufferSize, Vector2 size, InputTextFlags flags, TextEditCallback callback)
        {
            ImGuiNative.igInputTextMultiline(label, textBuffer, bufferSize, size, flags, callback, null);
        }

        public static unsafe DrawData* GetDrawData()
        {
            return ImGuiNative.igGetDrawData();
        }

        public static unsafe void InputTextMultiline(string label, IntPtr textBuffer, uint bufferSize, Vector2 size, InputTextFlags flags, TextEditCallback callback, IntPtr userData)
        {
            ImGuiNative.igInputTextMultiline(label, textBuffer, bufferSize, size, flags, callback, userData.ToPointer());
        }

        public static bool BeginChildFrame(uint id, Vector2 size, WindowFlags flags)
        {
            return ImGuiNative.igBeginChildFrame(id, size, flags);
        }

        public static void EndChildFrame()
        {
            ImGuiNative.igEndChildFrame();
        }

        public static unsafe void ColorConvertRGBToHSV(float r, float g, float b, out float h, out float s, out float v)
        {
            float h2, s2, v2;
            ImGuiNative.igColorConvertRGBtoHSV(r, g, b, &h2, &s2, &v2);
            h = h2;
            s = s2;
            v = v2;
        }

        public static unsafe void ColorConvertHSVToRGB(float h, float s, float v, out float r, out float g, out float b)
        {
            float r2, g2, b2;
            ImGuiNative.igColorConvertHSVtoRGB(h, s, v, &r2, &g2, &b2);
            r = r2;
            g = g2;
            b = b2;
        }


        public static int GetKeyIndex(GuiKey key)
        {
            //TODO this got exported by later version of cimgui, call ImGuiNative after upgrading
            IO io = GetIO();
            return io.KeyMap[key];
        }

        public static bool IsKeyDown(int keyIndex)
        {
            return ImGuiNative.igIsKeyDown(keyIndex);
        }

        public static bool IsKeyPressed(int keyIndex, bool repeat = true)
        {
            return ImGuiNative.igIsKeyPressed(keyIndex, repeat);
        }

        public static bool IsKeyReleased(int keyIndex)
        {
            return ImGuiNative.igIsKeyReleased(keyIndex);
        }

        public static bool IsMouseDown(int button)
        {
            return ImGuiNative.igIsMouseDown(button);
        }

        public static bool IsMouseClicked(int button, bool repeat = false)
        {
            return ImGuiNative.igIsMouseClicked(button, repeat);
        }

        public static bool IsMouseDoubleClicked(int button)
        {
            return ImGuiNative.igIsMouseDoubleClicked(button);
        }

        public static bool IsMouseReleased(int button)
        {
            return ImGuiNative.igIsMouseReleased(button);
        }

        public static bool IsWindowRectHovered()
        {
            return ImGuiNative.igIsWindowRectHovered();
        }

        public static bool IsAnyWindowHovered()
        {
            return ImGuiNative.igIsAnyWindowHovered();
        }

        public static bool IsWindowFocused()
        {
            return ImGuiNative.igIsWindowFocused();
        }

        public static bool IsMouseHoveringRect(Vector2 minPosition, Vector2 maxPosition, bool clip)
        {
            return ImGuiNative.igIsMouseHoveringRect(minPosition, maxPosition, clip);
        }

        public static bool IsMouseDragging(int button, float lockThreshold)
        {
            return ImGuiNative.igIsMouseDragging(button, lockThreshold);
        }

        public static Vector2 GetMousePos()
        {
            Vector2 retVal;
            ImGuiNative.igGetMousePos(out retVal);
            return retVal;
        }

        public static Vector2 GetMousePosOnOpeningCurrentPopup()
        {
            Vector2 retVal;
            ImGuiNative.igGetMousePosOnOpeningCurrentPopup(out retVal);
            return retVal;
        }

        public static Vector2 GetMouseDragDelta(int button, float lockThreshold)
        {
            Vector2 retVal;
            ImGuiNative.igGetMouseDragDelta(out retVal, button, lockThreshold);
            return retVal;
        }

        public static void ResetMouseDragDelta(int button)
        {
            ImGuiNative.igResetMouseDragDelta(button);
        }

        public static MouseCursorKind MouseCursor
        {
            get
            {
                return ImGuiNative.igGetMouseCursor();
            }
            set
            {
                ImGuiNative.igSetMouseCursor(value);
            }
        }

        public static Vector2 GetCursorStartPos()
        {
            Vector2 retVal;
            ImGuiNative.igGetCursorStartPos(out retVal);
            return retVal;
        }

        public static unsafe Vector2 GetCursorScreenPos()
        {
            Vector2 retVal;
            ImGuiNative.igGetCursorScreenPos(&retVal);
            return retVal;
        }

        public static void SetCursorScreenPos(Vector2 pos)
        {
            ImGuiNative.igSetCursorScreenPos(pos);
        }

        public static bool BeginChild(string id, bool border = false, WindowFlags flags = 0)
        {
            return BeginChild(id, new Vector2(0, 0), border, flags);
        }

        public static bool BeginChild(string id, Vector2 size, bool border, WindowFlags flags)
        {
            return ImGuiNative.igBeginChild(id, size, border, flags);
        }

        public static bool BeginChild(uint id, Vector2 size, bool border, WindowFlags flags)
        {
            return ImGuiNative.igBeginChildEx(id, size, border, flags);
        }

        public static void EndChild()
        {
            ImGuiNative.igEndChild();
        }

        public static Vector2 GetContentRegionMax()
        {
            Vector2 value;
            ImGuiNative.igGetContentRegionMax(out value);
            return value;
        }

        public static Vector2 GetContentRegionAvailable()
        {
            Vector2 value;
            ImGuiNative.igGetContentRegionAvail(out value);
            return value;
        }

        public static float GetContentRegionAvailableWidth()
        {
            return ImGuiNative.igGetContentRegionAvailWidth();
        }

        public static Vector2 GetWindowContentRegionMin()
        {
            Vector2 value;
            ImGuiNative.igGetWindowContentRegionMin(out value);
            return value;
        }

        public static Vector2 GetWindowContentRegionMax()
        {
            Vector2 value;
            ImGuiNative.igGetWindowContentRegionMax(out value);
            return value;
        }

        public static float GetWindowContentRegionWidth()
        {
            return ImGuiNative.igGetWindowContentRegionWidth();
        }

        public static bool Selectable(string label)
        {
            return Selectable(label, false);
        }

        public static bool Selectable(string label, bool isSelected)
        {
            return Selectable(label, isSelected, SelectableFlags.Default);
        }

        public static bool BeginMainMenuBar()
        {
            return ImGuiNative.igBeginMainMenuBar();
        }

        public static bool BeginPopup(string id)
        {
            return ImGuiNative.igBeginPopup(id);
        }

        public static void EndMainMenuBar()
        {
            ImGuiNative.igEndMainMenuBar();
        }

        public static bool SmallButton(string label)
        {
            return ImGuiNative.igSmallButton(label);
        }

        public static bool BeginPopupModal(string name)
        {
            return BeginPopupModal(name, WindowFlags.Default);
        }

        public static bool BeginPopupModal(string name, ref bool opened)
        {
            return BeginPopupModal(name, ref opened, WindowFlags.Default);
        }

        public static unsafe bool BeginPopupModal(string name, WindowFlags extra_flags)
        {
            return ImGuiNative.igBeginPopupModal(name, null, extra_flags);
        }

        public static unsafe bool BeginPopupModal(string name, ref bool p_opened, WindowFlags extra_flags)
        {
            byte value = p_opened ? (byte)1 : (byte)0;
            bool result = ImGuiNative.igBeginPopupModal(name, &value, extra_flags);

            p_opened = value == 1 ? true : false;
            return result;
        }

        public static bool Selectable(string label, bool isSelected, SelectableFlags flags)
        {
            return Selectable(label, isSelected, flags, new Vector2());
        }

        public static bool Selectable(string label, bool isSelected, SelectableFlags flags, Vector2 size)
        {
            return ImGuiNative.igSelectable(label, isSelected, flags, size);
        }

        public static bool SelectableEx(string label, ref bool isSelected)
        {
            return ImGuiNative.igSelectableEx(label, ref isSelected, SelectableFlags.Default, new Vector2());
        }

        public static bool SelectableEx(string label, ref bool isSelected, SelectableFlags flags, Vector2 size)
        {
            return ImGuiNative.igSelectableEx(label, ref isSelected, flags, size);
        }

        public static unsafe Vector2 GetTextSize(string text, float wrapWidth = Int32.MaxValue)
        {
            Vector2 result;
            IntPtr buffer = Marshal.StringToHGlobalAnsi(text);
            byte* textStart = (byte*)buffer.ToPointer();
            byte* textEnd = textStart + text.Length;
            ImGuiNative.igCalcTextSize(out result, (char*)textStart, (char*)textEnd, false, wrapWidth);
            return result;
        }

        public static bool BeginPopupContextItem(string id)
        {
            return BeginPopupContextItem(id, 1);
        }

        public static bool BeginPopupContextItem(string id, int mouseButton)
        {
            return ImGuiNative.igBeginPopupContextItem(id, mouseButton);
        }

        public static unsafe void Dummy(float width, float height)
        {
            Dummy(new Vector2(width, height));
        }

        public static void EndPopup()
        {
            ImGuiNative.igEndPopup();
        }

        public static bool IsPopupOpen(string id)
        {
            return ImGuiNative.igIsPopupOpen(id);
        }

        public static unsafe void Dummy(Vector2 size)
        {
            ImGuiNative.igDummy(&size);
        }

        public static void Spacing()
        {
            ImGuiNative.igSpacing();
        }

        public static void Columns(int count, string id, bool border)
        {
            ImGuiNative.igColumns(count, id, border);
        }

        public static void NextColumn()
        {
            ImGuiNative.igNextColumn();
        }

        public static int GetColumnIndex()
        {
            return ImGuiNative.igGetColumnIndex();
        }

        public static float GetColumnOffset(int columnIndex)
        {
            return ImGuiNative.igGetColumnOffset(columnIndex);
        }

        public static void SetColumnOffset(int columnIndex, float offsetX)
        {
            ImGuiNative.igSetColumnOffset(columnIndex, offsetX);
        }

        public static float GetColumnWidth(int columnIndex)
        {
            return ImGuiNative.igGetColumnWidth(columnIndex);
        }

        public static void SetColumnWidth(int columnIndex, float width)
        {
            ImGuiNative.igSetColumnWidth(columnIndex, width);
        }

        public static int GetColumnsCount()
        {
            return ImGuiNative.igGetColumnsCount();
        }

        public static void OpenPopup(string id)
        {
            ImGuiNative.igOpenPopup(id);
        }

        public static void SameLine(float localPositionX = 0, float spacingW = -1.0f)
        {
            ImGuiNative.igSameLine(localPositionX, spacingW);
        }

        public static void PushClipRect(Vector2 min, Vector2 max, bool intersectWithCurrentCliRect)
        {
            ImGuiNative.igPushClipRect(min, max, intersectWithCurrentCliRect ? (byte)1 : (byte)0);
        }

        public static void PopClipRect()
        {
            ImGuiNative.igPopClipRect();
        }

        public static bool IsLastItemHovered()
        {
            return ImGuiNative.igIsItemHovered();
        }

        public static bool IsItemRectHovered()
        {
            return ImGuiNative.igIsItemRectHovered();
        }

        public static bool IsLastItemActive()
        {
            return ImGuiNative.igIsItemActive();
        }
   
        public static bool IsLastItemVisible()
        {
            return ImGuiNative.igIsItemVisible();
        }

        public static bool IsAnyItemHovered()
        {
            return ImGuiNative.igIsAnyItemHovered();
        }

        public static bool IsAnyItemActive()
        {
            return ImGuiNative.igIsAnyItemActive();
        }

        public static void SetTooltip(string text)
        {
            ImGuiNative.igSetTooltip(text);
        }

        public static void SetNextTreeNodeOpen(bool opened)
        {
            ImGuiNative.igSetNextTreeNodeOpen(opened, Condition.Always);
        }

        public static void SetNextTreeNodeOpen(bool opened, Condition setCondition)
        {
            ImGuiNative.igSetNextTreeNodeOpen(opened, setCondition);
        }

        public static bool TreeNode(string label)
        {
            return ImGuiNative.igTreeNode(label);
        }

        public static bool TreeNodeEx(string label, TreeNodeFlags flags = 0)
        {
            return ImGuiNative.igTreeNodeEx(label, flags);
        }

        public static void TreePop()
        {
            ImGuiNative.igTreePop();
        }

        public static Vector2 GetLastItemRectSize()
        {
            Vector2 result;
            ImGuiNative.igGetItemRectSize(out result);
            return result;
        }

        public static Vector2 GetLastItemRectMin()
        {
            Vector2 result;
            ImGuiNative.igGetItemRectMin(out result);
            return result;
        }

        public static Vector2 GetLastItemRectMax()
        {
            Vector2 result;
            ImGuiNative.igGetItemRectMax(out result);
            return result;
        }

        public static void SetWindowFontScale(float scale)
        {
            ImGuiNative.igSetWindowFontScale(scale);
        }

        public static void SetScrollHere()
        {
            ImGuiNative.igSetScrollHere();
        }

        public static void SetScrollHere(float centerYRatio)
        {
            ImGuiNative.igSetScrollHere(centerYRatio);
        }

        public static unsafe void PushFont(Font font)
        {
            ImGuiNative.igPushFont(font.NativeFont);
        }

        public static void PopFont()
        {
            ImGuiNative.igPopFont();
        }

        public static void SetKeyboardFocusHere()
        {
            ImGuiNative.igSetKeyboardFocusHere(0);
        }

        public static void SetKeyboardFocusHere(int offset)
        {
            ImGuiNative.igSetKeyboardFocusHere(offset);
        }
        
        public static void CalcListClipping(int itemsCount, float itemsHeight, ref int outItemsDisplayStart, ref int outItemsDisplayEnd)
        {
            ImGuiNative.igCalcListClipping(itemsCount, itemsHeight, ref outItemsDisplayStart, ref outItemsDisplayEnd);
        }        
    }
}
