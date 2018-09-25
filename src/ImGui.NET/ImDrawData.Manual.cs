namespace ImGuiNET
{
    public unsafe partial struct ImDrawDataPtr
    {
        public RangeAccessor<ImDrawListPtr> CmdListsRange => new RangeAccessor<ImDrawListPtr>(CmdLists, CmdListsCount);
    }
}
