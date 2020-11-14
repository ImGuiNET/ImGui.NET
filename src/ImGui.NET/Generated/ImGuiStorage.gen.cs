using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStorage
    {
        public ImVector Data;
    }
    public unsafe partial struct ImGuiStoragePtr
    {
        public ImGuiStorage* NativePtr { get; }
        public ImGuiStoragePtr(ImGuiStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiStorage*)nativePtr;
        public static implicit operator ImGuiStoragePtr(ImGuiStorage* nativePtr) => new ImGuiStoragePtr(nativePtr);
        public static implicit operator ImGuiStorage* (ImGuiStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStoragePtr(IntPtr nativePtr) => new ImGuiStoragePtr(nativePtr);
        public ImPtrVector<ImGuiStoragePairPtr> Data => new ImPtrVector<ImGuiStoragePairPtr>(NativePtr->Data, Unsafe.SizeOf<ImGuiStoragePair>());
        public void BuildSortByKey()
        {
            ImGuiNative.ImGuiStorage_BuildSortByKey((ImGuiStorage*)(NativePtr));
        }
        public void Clear()
        {
            ImGuiNative.ImGuiStorage_Clear((ImGuiStorage*)(NativePtr));
        }
        public bool GetBool(uint key)
        {
            byte default_val = 0;
            byte ret = ImGuiNative.ImGuiStorage_GetBool((ImGuiStorage*)(NativePtr), key, default_val);
            return ret != 0;
        }
        public bool GetBool(uint key, bool default_val)
        {
            byte native_default_val = default_val ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGuiStorage_GetBool((ImGuiStorage*)(NativePtr), key, native_default_val);
            return ret != 0;
        }
        public byte* GetBoolRef(uint key)
        {
            byte default_val = 0;
            byte* ret = ImGuiNative.ImGuiStorage_GetBoolRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public byte* GetBoolRef(uint key, bool default_val)
        {
            byte native_default_val = default_val ? (byte)1 : (byte)0;
            byte* ret = ImGuiNative.ImGuiStorage_GetBoolRef((ImGuiStorage*)(NativePtr), key, native_default_val);
            return ret;
        }
        public float GetFloat(uint key)
        {
            float default_val = 0.0f;
            float ret = ImGuiNative.ImGuiStorage_GetFloat((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public float GetFloat(uint key, float default_val)
        {
            float ret = ImGuiNative.ImGuiStorage_GetFloat((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public float* GetFloatRef(uint key)
        {
            float default_val = 0.0f;
            float* ret = ImGuiNative.ImGuiStorage_GetFloatRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public float* GetFloatRef(uint key, float default_val)
        {
            float* ret = ImGuiNative.ImGuiStorage_GetFloatRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public int GetInt(uint key)
        {
            int default_val = 0;
            int ret = ImGuiNative.ImGuiStorage_GetInt((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public int GetInt(uint key, int default_val)
        {
            int ret = ImGuiNative.ImGuiStorage_GetInt((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public int* GetIntRef(uint key)
        {
            int default_val = 0;
            int* ret = ImGuiNative.ImGuiStorage_GetIntRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public int* GetIntRef(uint key, int default_val)
        {
            int* ret = ImGuiNative.ImGuiStorage_GetIntRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public IntPtr GetVoidPtr(uint key)
        {
            void* ret = ImGuiNative.ImGuiStorage_GetVoidPtr((ImGuiStorage*)(NativePtr), key);
            return (IntPtr)ret;
        }
        public void** GetVoidPtrRef(uint key)
        {
            void* default_val = null;
            void** ret = ImGuiNative.ImGuiStorage_GetVoidPtrRef((ImGuiStorage*)(NativePtr), key, default_val);
            return ret;
        }
        public void** GetVoidPtrRef(uint key, IntPtr default_val)
        {
            void* native_default_val = (void*)default_val.ToPointer();
            void** ret = ImGuiNative.ImGuiStorage_GetVoidPtrRef((ImGuiStorage*)(NativePtr), key, native_default_val);
            return ret;
        }
        public void SetAllInt(int val)
        {
            ImGuiNative.ImGuiStorage_SetAllInt((ImGuiStorage*)(NativePtr), val);
        }
        public void SetBool(uint key, bool val)
        {
            byte native_val = val ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiStorage_SetBool((ImGuiStorage*)(NativePtr), key, native_val);
        }
        public void SetFloat(uint key, float val)
        {
            ImGuiNative.ImGuiStorage_SetFloat((ImGuiStorage*)(NativePtr), key, val);
        }
        public void SetInt(uint key, int val)
        {
            ImGuiNative.ImGuiStorage_SetInt((ImGuiStorage*)(NativePtr), key, val);
        }
        public void SetVoidPtr(uint key, IntPtr val)
        {
            void* native_val = (void*)val.ToPointer();
            ImGuiNative.ImGuiStorage_SetVoidPtr((ImGuiStorage*)(NativePtr), key, native_val);
        }
    }
}
