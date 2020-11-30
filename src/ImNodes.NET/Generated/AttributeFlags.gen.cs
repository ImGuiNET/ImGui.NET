namespace ImNodesNET
{
    [System.Flags]
    public enum AttributeFlags
    {
        _None = 0,
        _EnableLinkDetachWithDragClick = 1 << 0,
        _EnableLinkCreationOnSnap = 1 << 1,
    }
}
