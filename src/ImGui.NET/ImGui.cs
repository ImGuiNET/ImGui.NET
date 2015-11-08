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

        public static unsafe void LoadDefaultFont()
        {
            IO* ioPtr = ImGuiNative.igGetIO();
            ImGuiNative.ImFontAtlas_AddFontDefault(ioPtr->FontAtlas);
        }

        public static void Text(string message)
        {
            ImGuiNative.igText(message);
        }

        public static void PushId(string id)
        {
            ImGuiNative.igPushIdStr(id);
        }

        public static void PopId()
        {
            ImGuiNative.igPopId();
        }

        public static void Text(string message, Vector4 color)
        {
            ImGuiNative.igTextColored(color, message);
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

        public static bool ColorButton(Vector4 color, bool smallHeight, bool outlineBorder)
        {
            return ImGuiNative.igColorButton(color, smallHeight, outlineBorder);
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

        public static unsafe bool Checkbox(string label, ref bool value)
        {
            bool localVal = value;
            bool result = ImGuiNative.igCheckbox(label, &localVal);
            value = localVal;
            return result;
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

        public static bool Selectable(string label, bool isSelected)
        {
            return Selectable(label, isSelected, SelectableFlags.Default);
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
