using System;
using System.Numerics;
using System.Runtime.InteropServices;

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

        public static unsafe void LoadDefaultFont()
        {
            NativeIO* ioPtr = ImGuiNative.igGetIO();
            ImGuiNative.ImFontAtlas_AddFontDefault(ioPtr->FontAtlas);
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

        public static bool CollapsingHeader(string label, string id, bool displayFrame, bool defaultOpen)
        {
            return ImGuiNative.igCollapsingHeader(label, id, displayFrame, defaultOpen);
        }

        public static bool Checkbox(string label, ref bool value)
        {
            return ImGuiNative.igCheckbox(label, ref value);
        }

        public static bool RadioButtonBool(string label, bool active)
        {
            return ImGuiNative.igRadioButtonBool(label, active);
        }

        public unsafe static bool Combo(string label, ref int current_item, string[] items)
        {
            throw new NotImplementedException();
        }

        public static bool ColorButton(Vector4 color, bool smallHeight, bool outlineBorder)
        {
            return ImGuiNative.igColorButton(color, smallHeight, outlineBorder);
        }

        public static bool ColorEdit3(string label, float r, float g, float b) => ColorEdit3(label, new Vector3(r, g, b));
        public static bool ColorEdit3(string label, Vector3 color)
        {
            return ImGuiNative.igColorEdit3(label, color);
        }

        public static bool ColorEdit4(string label, float r, float g, float b, float a, bool showAlpha)
            => ColorEdit4(label, new Vector4(r, g, b, a), showAlpha);

        public static bool ColorEdit4(string label, Vector4 color, bool showAlpha)
        {
            return ImGuiNative.igColorEdit4(label, color, showAlpha);
        }

        public static void ColorEditMode(ColorEditMode mode)
        {
            ImGuiNative.igColorEditMode(mode);
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

        public static void DragFloat(string label, ref float value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            ImGuiNative.igDragFloat(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static void DragVector2(string label, ref Vector2 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            ImGuiNative.igDragFloat2(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static void DragVector3(string label, ref Vector3 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            ImGuiNative.igDragFloat3(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
        }

        public static void DragVector4(string label, ref Vector4 value, float min, float max, float dragSpeed = 1f, string displayFormat = "%f", float dragPower = 1f)
        {
            ImGuiNative.igDragFloat4(label, ref value, dragSpeed, min, max, displayFormat, dragPower);
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

        public static void SetNextWindowSize(Vector2 size, SetCondition condition)
        {
            ImGuiNative.igSetNextWindowSize(size, condition);
        }

        public static void SetNextWindowPosCenter(SetCondition condition)
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
                DrawList* cmd_list = drawData->CmdLists[i];
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

        public static bool BeginMenu(string label)
        {
            return ImGuiNative.igBeginMenu(label, true);
        }

        public static bool BeginMenu(string label, bool enabled)
        {
            return ImGuiNative.igBeginMenu(label, enabled);
        }

        public static void BeginMenuBar()
        {
            ImGuiNative.igBeginMenuBar();
        }

        public static void CloseCurrentPopup()
        {
            ImGuiNative.igCloseCurrentPopup();
        }

        public static bool BeginWindow(string windowTitle, ref bool opened, Vector2 startingSize, WindowFlags flags)
        {
            return ImGuiNative.igBegin2(windowTitle, ref opened, startingSize, 1f, flags);
        }

        public static void EndMenuBar()
        {
            ImGuiNative.igEndMenuBar();
        }

        public static void EndMenu()
        {
            ImGuiNative.igEndMenu();
        }

        public static bool BeginWindow(string windowTitle, ref bool opened, Vector2 startingSize, float backgroundAlpha, WindowFlags flags)
        {
            return ImGuiNative.igBegin2(windowTitle, ref opened, startingSize, backgroundAlpha, flags);
        }

        public static void Separator()
        {
            ImGuiNative.igSeparator();
        }

        public static bool MenuItem(string label, string shortcut)
        {
            return MenuItem(label, shortcut, false, true);
        }

        public static unsafe bool InputText(string label, IntPtr textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback)
        {
            return InputText(label, textBuffer, bufferSize, flags, textEditCallback, IntPtr.Zero);
        }

        public static unsafe bool InputText(string label, IntPtr textBuffer, uint bufferSize, InputTextFlags flags, TextEditCallback textEditCallback, IntPtr userData)
        {
            return ImGuiNative.igInputText(label, textBuffer, bufferSize, flags, textEditCallback, userData.ToPointer());
        }

        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled)
        {
            return ImGuiNative.igMenuItem(label, shortcut, selected, enabled);
        }

        public static void EndWindow()
        {
            ImGuiNative.igEnd();
        }

        public static void PushStyleColor(ColorTarget target, Vector4 color)
        {
            ImGuiNative.igPushStyleColor(target, color);
        }

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

        public static void PopStyleColor()
        {
            PopStyleColor(1);
        }

        public static void PopStyleColor(int numStyles)
        {
            ImGuiNative.igPopStyleColor(numStyles);
        }

        public static bool BeginChildFrame(uint id, Vector2 size, WindowFlags flags)
        {
            return ImGuiNative.igBeginChildFrame(id, size, flags);
        }

        public static void EndChildFrame()
        {
            ImGuiNative.igEndChildFrame();
        }

        public static bool IsKeyDown(int keyIndex)
        {
            return ImGuiNative.igIsKeyDown(keyIndex);
        }

        public static bool IsKeyPressed(int keyIndex, bool repeat)
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

        public static bool IsMouseClicked(int button, bool repeat)
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

        public static bool IsMouseHoveringWindow()
        {
            return ImGuiNative.igIsMouseHoveringWindow();
        }

        public static bool IsMouseHoveringAnyWindow()
        {
            return ImGuiNative.igIsMouseHoveringAnyWindow();
        }

        public static bool IsMouseHoveringRect(Vector2 minPosition, Vector2 maxPosition, bool clip)
        {
            return IsMouseHoveringRect(minPosition, maxPosition, clip);
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

        public static void BeginMainMenuBar()
        {
            ImGuiNative.igBeginMainMenuBar();
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
            return ImGuiNative.igBeginPopupModal(name, WindowFlags.Default);
        }

        public static bool Selectable(string label, bool isSelected, SelectableFlags flags)
        {
            return Selectable(label, isSelected, flags, new Vector2());
        }

        public static bool Selectable(string label, bool isSelected, SelectableFlags flags, Vector2 size)
        {
            return ImGuiNative.igSelectable(label, isSelected, flags, size);
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

        public static unsafe void Dummy(Vector2 size)
        {
            ImGuiNative.igDummy(&size);
        }

        public static void Spacing()
        {
            ImGuiNative.igSpacing();
        }

        public static void OpenPopup(string id)
        {
            ImGuiNative.igOpenPopup(id);
        }

        public static void SameLine()
        {
            ImGuiNative.igSameLine(0, 0);
        }

        public static void SameLine(float localPositionX, float spacingW)
        {
            ImGuiNative.igSameLine(localPositionX, spacingW);
        }

        public static bool IsLastItemHovered()
        {
            return ImGuiNative.igIsItemHovered();
        }

        public static void ShowTooltip(string text)
        {
            ImGuiNative.igSetTooltip(text);
        }

        public static void SetNextTreeNodeOpened(bool opened)
        {
            ImGuiNative.igSetNextTreeNodeOpened(opened, SetCondition.Always);
        }

        public static bool TreeNode(string label)
        {
            return ImGuiNative.igTreeNode(label);
        }

        public static void TreePop()
        {
            ImGuiNative.igTreePop();
        }

        public static Vector2 GetLastItemRect()
        {
            Vector2 result;
            ImGuiNative.igGetItemRectSize(out result);
            return result;
        }
    }
}
