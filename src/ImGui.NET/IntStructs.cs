using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Int2
    {
        public readonly int X, Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Int3
    {
        public readonly int X, Y, Z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Int4
    {
        public readonly int X, Y, Z, W;
    }
}
