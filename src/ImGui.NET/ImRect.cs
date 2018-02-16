using System.Numerics;

namespace ImGuiNET
{
    public struct ImRect
    {
        public Vector2 Min;
        public Vector2 Max;

        public ImRect(Vector2 min, Vector2 max)
        {
            Min = min;
            Max = max;
        }

        public bool Contains(Vector2 p)
        {
            return p.X >= Min.X && p.Y >= Min.Y && p.X < Max.X && p.Y < Max.Y;
        }

        public Vector2 GetSize()
        {
            return Max - Min;
        }
    }
}
