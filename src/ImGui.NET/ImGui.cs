using System;
using System.Numerics;

namespace ImGui
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

        public static void Text(string message, Vector4 color)
        {
            ImGuiNative.igTextColored(color, message);
        }

        public static bool Button(string message, Vector2 size)
        {
            return ImGuiNative.igButton(message, size);
        }


    }
}
