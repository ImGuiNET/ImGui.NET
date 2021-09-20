using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDockNode
    {
        public uint ID;
        public ImGuiDockNodeFlags SharedFlags;
        public ImGuiDockNodeFlags LocalFlags;
        public ImGuiDockNodeFlags LocalFlagsInWindows;
        public ImGuiDockNodeFlags MergedFlags;
        public ImGuiDockNodeState State;
        public ImGuiDockNode* ParentNode;
        public ImGuiDockNode* ChildNodes_0;
        public ImGuiDockNode* ChildNodes_1;
        public ImVector Windows;
        public ImGuiTabBar* TabBar;
        public Vector2 Pos;
        public Vector2 Size;
        public Vector2 SizeRef;
        public ImGuiAxis SplitAxis;
        public ImGuiWindowClass WindowClass;
        public ImGuiWindow* HostWindow;
        public ImGuiWindow* VisibleWindow;
        public ImGuiDockNode* CentralNode;
        public ImGuiDockNode* OnlyNodeWithWindows;
        public int CountNodeWithWindows;
        public int LastFrameAlive;
        public int LastFrameActive;
        public int LastFrameFocused;
        public uint LastFocusedNodeId;
        public uint SelectedTabId;
        public uint WantCloseTabId;
        public ImGuiDataAuthority AuthorityForPos;
        public ImGuiDataAuthority AuthorityForSize;
        public ImGuiDataAuthority AuthorityForViewport;
        public byte IsVisible;
        public byte IsFocused;
        public byte HasCloseButton;
        public byte HasWindowMenuButton;
        public byte HasCentralNodeChild;
        public byte WantCloseAll;
        public byte WantLockSizeOnce;
        public byte WantMouseMove;
        public byte WantHiddenTabBarUpdate;
        public byte WantHiddenTabBarToggle;
        public byte MarkedForPosSizeWrite;
    }
    public unsafe partial struct ImGuiDockNodePtr
    {
        public ImGuiDockNode* NativePtr { get; }
        public ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => NativePtr = nativePtr;
        public ImGuiDockNodePtr(IntPtr nativePtr) => NativePtr = (ImGuiDockNode*)nativePtr;
        public static implicit operator ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => new ImGuiDockNodePtr(nativePtr);
        public static implicit operator ImGuiDockNode* (ImGuiDockNodePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDockNodePtr(IntPtr nativePtr) => new ImGuiDockNodePtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiDockNodeFlags SharedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->SharedFlags);
        public ref ImGuiDockNodeFlags LocalFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlags);
        public ref ImGuiDockNodeFlags LocalFlagsInWindows => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlagsInWindows);
        public ref ImGuiDockNodeFlags MergedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->MergedFlags);
        public ref ImGuiDockNodeState State => ref Unsafe.AsRef<ImGuiDockNodeState>(&NativePtr->State);
        public ImGuiDockNodePtr ParentNode => new ImGuiDockNodePtr(NativePtr->ParentNode);
        public RangeAccessor<ImGuiDockNode> ChildNodes => new RangeAccessor<ImGuiDockNode>(&NativePtr->ChildNodes_0, 2);
        public ImVector<ImGuiWindowPtr> Windows => new ImVector<ImGuiWindowPtr>(NativePtr->Windows);
        public ImGuiTabBarPtr TabBar => new ImGuiTabBarPtr(NativePtr->TabBar);
        public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
        public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);
        public ref Vector2 SizeRef => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeRef);
        public ref ImGuiAxis SplitAxis => ref Unsafe.AsRef<ImGuiAxis>(&NativePtr->SplitAxis);
        public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);
        public ImGuiWindowPtr HostWindow => new ImGuiWindowPtr(NativePtr->HostWindow);
        public ImGuiWindowPtr VisibleWindow => new ImGuiWindowPtr(NativePtr->VisibleWindow);
        public ImGuiDockNodePtr CentralNode => new ImGuiDockNodePtr(NativePtr->CentralNode);
        public ImGuiDockNodePtr OnlyNodeWithWindows => new ImGuiDockNodePtr(NativePtr->OnlyNodeWithWindows);
        public ref int CountNodeWithWindows => ref Unsafe.AsRef<int>(&NativePtr->CountNodeWithWindows);
        public ref int LastFrameAlive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameAlive);
        public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
        public ref int LastFrameFocused => ref Unsafe.AsRef<int>(&NativePtr->LastFrameFocused);
        public ref uint LastFocusedNodeId => ref Unsafe.AsRef<uint>(&NativePtr->LastFocusedNodeId);
        public ref uint SelectedTabId => ref Unsafe.AsRef<uint>(&NativePtr->SelectedTabId);
        public ref uint WantCloseTabId => ref Unsafe.AsRef<uint>(&NativePtr->WantCloseTabId);
        public ref ImGuiDataAuthority AuthorityForPos => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForPos);
        public ref ImGuiDataAuthority AuthorityForSize => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForSize);
        public ref ImGuiDataAuthority AuthorityForViewport => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForViewport);
        public ref bool IsVisible => ref Unsafe.AsRef<bool>(&NativePtr->IsVisible);
        public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);
        public ref bool HasCloseButton => ref Unsafe.AsRef<bool>(&NativePtr->HasCloseButton);
        public ref bool HasWindowMenuButton => ref Unsafe.AsRef<bool>(&NativePtr->HasWindowMenuButton);
        public ref bool HasCentralNodeChild => ref Unsafe.AsRef<bool>(&NativePtr->HasCentralNodeChild);
        public ref bool WantCloseAll => ref Unsafe.AsRef<bool>(&NativePtr->WantCloseAll);
        public ref bool WantLockSizeOnce => ref Unsafe.AsRef<bool>(&NativePtr->WantLockSizeOnce);
        public ref bool WantMouseMove => ref Unsafe.AsRef<bool>(&NativePtr->WantMouseMove);
        public ref bool WantHiddenTabBarUpdate => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarUpdate);
        public ref bool WantHiddenTabBarToggle => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarToggle);
        public ref bool MarkedForPosSizeWrite => ref Unsafe.AsRef<bool>(&NativePtr->MarkedForPosSizeWrite);
        public void Destroy()
        {
            ImGuiNative.ImGuiDockNode_destroy((ImGuiDockNode*)(NativePtr));
        }
        public bool IsCentralNode()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsCentralNode((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsDockSpace()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsDockSpace((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsEmpty()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsEmpty((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsFloatingNode()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsFloatingNode((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsHiddenTabBar()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsHiddenTabBar((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsLeafNode()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsLeafNode((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsNoTabBar()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsNoTabBar((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsRootNode()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsRootNode((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public bool IsSplitNode()
        {
            byte ret = ImGuiNative.ImGuiDockNode_IsSplitNode((ImGuiDockNode*)(NativePtr));
            return ret != 0;
        }
        public ImRect Rect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiDockNode_Rect(&__retval, (ImGuiDockNode*)(NativePtr));
            return __retval;
        }
        public void SetLocalFlags(ImGuiDockNodeFlags flags)
        {
            ImGuiNative.ImGuiDockNode_SetLocalFlags((ImGuiDockNode*)(NativePtr), flags);
        }
        public void UpdateMergedFlags()
        {
            ImGuiNative.ImGuiDockNode_UpdateMergedFlags((ImGuiDockNode*)(NativePtr));
        }
    }
}
