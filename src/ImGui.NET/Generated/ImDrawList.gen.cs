using System;
using System.Numerics;

namespace ImGuiNET
{
    public unsafe struct ImDrawList
    {
        public ImVector/*<ImDrawCmd>*/ CmdBuffer;
        public ImVector/*<ImDrawIdx>*/ IdxBuffer;
        public ImVector/*<ImDrawVert>*/ VtxBuffer;
        public ImDrawListFlags Flags;
        public IntPtr* _Data;
        public byte* _OwnerName;
        public uint _VtxCurrentIdx;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector/*<ImVec4>*/ _ClipRectStack;
        public ImVector/*<ImTextureID>*/ _TextureIdStack;
        public ImVector/*<ImVec2>*/ _Path;
        public int _ChannelsCurrent;
        public int _ChannelsCount;
        public ImVector/*<ImDrawChannel>*/ _Channels;
    }
}
