using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ImGuiNET.FNA
{
    public unsafe struct ImVector<T> where T : struct
    {
        // This won't change during the life of the application.
        private readonly static Type _T = typeof(T);

        private readonly static int _TSize = Marshal.SizeOf(_T);

        public readonly ImGuiNET.ImVector* Native;

        public ImVector(ImGuiNET.ImVector* native)
        {
            Native = native;
        }

        public int Size
        {
            get
            {
                return Native->Size;
            }
            set
            {
                Native->Size = value;
            }
        }

        public int Capacity
        {
            get
            {
                return Native->Capacity;
            }
            set
            {
                Native->Capacity = value;
            }
        }

        public IntPtr Data
        {
            get
            {
                return new IntPtr(Native->Data);
            }
            set
            {
                Native->Data = value.ToPointer();
            }
        }

        // T* not allowed in C#; Using Marshal.SizeOf(typeof(T)) instead.
        public T this[int i]
        {
            get
            {
                return (T)Marshal.PtrToStructure(new IntPtr((long)Data + i * _TSize), _T);
            }
            set
            {
                Marshal.StructureToPtr(value, new IntPtr((long)Data + i * _TSize), true);
            }
        }

        public static implicit operator ImGuiNET.ImVector* (ImVector<T> v) => v.Native;

        public static implicit operator ImVector<T>(ImGuiNET.ImVector* v) => new ImVector<T>(v);

        public static implicit operator ImGuiNET.ImVector(ImVector<T> v) => *v.Native;
    }

    public unsafe struct ImPtrVector<T> where T : struct
    {
        public readonly ImGuiNET.ImVector* Native;

        public ImPtrVector(ImGuiNET.ImVector* native)
        {
            Native = native;
        }

        public int Size
        {
            get
            {
                return Native->Size;
            }
            set
            {
                Native->Size = value;
            }
        }

        public int Capacity
        {
            get
            {
                return Native->Capacity;
            }
            set
            {
                Native->Capacity = value;
            }
        }

        public IntPtr Data
        {
            get
            {
                return new IntPtr(Native->Data);
            }
            set
            {
                Native->Data = value.ToPointer();
            }
        }

        // T* not allowed in C#...
        public IntPtr this[int i]
        {
            get
            {
                return *((IntPtr*)((long)Data + i * IntPtr.Size));
            }
            set
            {
                *((IntPtr*)((long)Data + i * IntPtr.Size)) = value;
            }
        }

        public static implicit operator ImGuiNET.ImVector* (ImPtrVector<T> v) => v.Native;

        public static implicit operator ImPtrVector<T>(ImGuiNET.ImVector* v) => new ImPtrVector<T>(v);

        public static implicit operator ImGuiNET.ImVector(ImPtrVector<T> v) => *v.Native;
    }

    public unsafe struct ImWrappedPtrVector<T> where T : struct
    {
        public readonly ImGuiNET.ImVector* Native;

        private static ConstructorInfo _NaiveWrapConstructor;

        public static Func<IntPtr, T> Wrap = ptr =>
        {
            if (_NaiveWrapConstructor == null)
                _NaiveWrapConstructor = typeof(T).GetConstructors()[0];
            if (_NaiveWrapConstructor == null)
                throw new NullReferenceException($"ImWrappedPtrVector<{typeof(T).GetType().FullName}>.Wrap");
            return (T)_NaiveWrapConstructor.Invoke(new object[] {
                Convert.ChangeType(ptr, _NaiveWrapConstructor.GetParameters()[0].ParameterType)
            });
        };

        private static FieldInfo _NaiveWrapNativeField;

        public static Func<T, IntPtr> Unwrap = wrap =>
        {
            if (_NaiveWrapNativeField == null)
                _NaiveWrapNativeField = typeof(T).GetField("Native");
            if (_NaiveWrapNativeField == null)
                throw new NullReferenceException($"ImWrappedPtrVector<{typeof(T).GetType().FullName}>.Unwrap");
            return (IntPtr)Convert.ChangeType(_NaiveWrapNativeField.GetValue(wrap), typeof(IntPtr));
        };

        public ImWrappedPtrVector(ImGuiNET.ImVector* native)
        {
            Native = native;
        }

        public int Size
        {
            get
            {
                return Native->Size;
            }
            set
            {
                Native->Size = value;
            }
        }

        public int Capacity
        {
            get
            {
                return Native->Capacity;
            }
            set
            {
                Native->Capacity = value;
            }
        }

        public IntPtr Data
        {
            get
            {
                return new IntPtr(Native->Data);
            }
            set
            {
                Native->Data = value.ToPointer();
            }
        }

        // T* not allowed in C#...
        public T this[int i]
        {
            get
            {
                return Wrap(*((IntPtr*)((long)Data + i * IntPtr.Size)));
            }
            set
            {
                *((IntPtr*)((long)Data + i * IntPtr.Size)) = Unwrap(value);
            }
        }

        public static implicit operator ImGuiNET.ImVector* (ImWrappedPtrVector<T> v) => v.Native;

        public static implicit operator ImWrappedPtrVector<T>(ImGuiNET.ImVector* v) => new ImWrappedPtrVector<T>(v);

        public static implicit operator ImGuiNET.ImVector(ImWrappedPtrVector<T> v) => *v.Native;
    }
}