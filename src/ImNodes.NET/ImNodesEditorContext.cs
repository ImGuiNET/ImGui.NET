using System;

namespace imnodesNET
{
	public unsafe struct ImNodesEditorContext { }

	public unsafe struct ImNodesEditorContextPtr
	{
		public ImNodesEditorContext* NativePtr { get; }
		public ImNodesEditorContextPtr(ImNodesEditorContext* nativePtr) => NativePtr = nativePtr;
		public ImNodesEditorContextPtr(IntPtr nativePtr) => NativePtr = (ImNodesEditorContext*)nativePtr;
		public static implicit operator ImNodesEditorContextPtr(ImNodesEditorContext* nativePtr) => new ImNodesEditorContextPtr(nativePtr);
		public static implicit operator ImNodesEditorContext*(ImNodesEditorContextPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImNodesEditorContextPtr(IntPtr nativePtr) => new ImNodesEditorContextPtr(nativePtr);
	}
}
