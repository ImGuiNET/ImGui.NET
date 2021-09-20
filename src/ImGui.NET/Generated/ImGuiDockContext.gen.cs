using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDockContext
    {
        public ImGuiStorage Nodes;
        public ImVector Requests;
        public ImVector NodesSettings;
        public byte WantFullRebuild;
    }
    public unsafe partial struct ImGuiDockContextPtr
    {
        public ImGuiDockContext* NativePtr { get; }
        public ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => NativePtr = nativePtr;
        public ImGuiDockContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockContext*)nativePtr;
        public static implicit operator ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => new ImGuiDockContextPtr(nativePtr);
        public static implicit operator ImGuiDockContext* (ImGuiDockContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDockContextPtr(IntPtr nativePtr) => new ImGuiDockContextPtr(nativePtr);
        public ref ImGuiStorage Nodes => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Nodes);
        public ImVector<IntPtr> Requests => new ImVector<IntPtr>(NativePtr->Requests);
        public ImVector<IntPtr> NodesSettings => new ImVector<IntPtr>(NativePtr->NodesSettings);
        public ref bool WantFullRebuild => ref Unsafe.AsRef<bool>(&NativePtr->WantFullRebuild);
        public void Destroy()
        {
            ImGuiNative.ImGuiDockContext_destroy((ImGuiDockContext*)(NativePtr));
        }
    }
}
