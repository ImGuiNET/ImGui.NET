namespace ImGuiNET
{
    public struct Bool8
    {
        public readonly byte Value;
        public static implicit operator bool(Bool8 b8) => b8.Value != 0;
        public static implicit operator Bool8(bool b) => new Bool8(b);

        public Bool8(bool value)
        {
            Value = value ? (byte)1 : (byte)0;
        }

        public Bool8(byte value)
        {
            Value = value;
        }

        public override string ToString() => string.Format("{0} [{1}]", (bool)this, Value);
    }
}
