using ImGuiNET;
using Microsoft.Xna.Framework.Graphics;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET.FNA
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DrawVertXNA
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;

        public const int PosOffset = 0;
        public const int UVOffset = 8;
        public const int ColOffset = 16;

        public readonly static int Size = sizeof(DrawVert);

        public readonly static VertexDeclaration _VertexDeclaration = new VertexDeclaration(
            Size,
            new VertexElement(PosOffset, VertexElementFormat.Vector2, VertexElementUsage.Position, 0),
            new VertexElement(UVOffset, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0),
            new VertexElement(ColOffset, VertexElementFormat.Color, VertexElementUsage.Color, 0)
        );

        public VertexDeclaration VertexDeclaration => _VertexDeclaration;
    }
}