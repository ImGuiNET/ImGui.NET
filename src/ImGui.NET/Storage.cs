using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Storage
    {
        /// <summary>
        /// A vector of Storage.Pair values.
        /// </summary>
        public ImVector Data;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct Pair
        {
            public uint Key;
            private OverlappedDataItem _overlappedData;

            public float FloatData
            {
                get { return _overlappedData.FloatData; }
                set { _overlappedData.FloatData = value; }
            }

            public int IntData
            {
                get { return _overlappedData.IntData; }
                set { _overlappedData.IntData = value; }
            }

            public IntPtr PtrData
            {
                get { return _overlappedData.PtrData; }
                set { _overlappedData.PtrData = value; }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        private unsafe struct OverlappedDataItem
        {
            [FieldOffset(0)]
            public float FloatData;
            [FieldOffset(0)]
            public int IntData;
            [FieldOffset(0)]
            public IntPtr PtrData;
        }
    }
}
