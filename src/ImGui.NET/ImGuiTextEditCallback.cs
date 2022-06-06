using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackData* data);
}
