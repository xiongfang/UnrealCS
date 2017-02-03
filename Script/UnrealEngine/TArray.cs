using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FScriptArray
    {
        IntPtr Data;
        int ArrayNum;
        int ArrayMax;


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern IntPtr GetData(ref FScriptArray _this);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void InsertZeroed(ref FScriptArray _this, int Index, int Count, int NumBytesPerElement);


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void Insert(ref FScriptArray _this, int Index, int Count, int NumBytesPerElement);


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern int Add(ref FScriptArray _this, int Count, int NumBytesPerElement);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern int AddZerod(ref FScriptArray _this, int Count, int NumBytesPerElement);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void Shrink(ref FScriptArray _this, int NumBytesPerElement);


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void Empty(ref FScriptArray _this, int Slack, int NumBytesPerElement);


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void Remove(ref FScriptArray _this, int Index, int Count, int NumBytesPerElement);

        public int GetSlack()
        {
            return ArrayMax - ArrayNum;
        }

        public int Num()
        {
            return ArrayNum;
        }

        public bool IsValidIndex(int i)
        {
            return i >= 0 && i < ArrayNum;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FScriptBitArray
    {
        //[FieldOffset(0)]
        //public fixed  byte[] AllocatorInstance[24];
        [FieldOffset(24)]
        public int NumBits;
        [FieldOffset(28)]
        public int MaxBits;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FScriptSparseArrayLayout
    {
        [FieldOffset(0)]
        public int ElementOffset;
        [FieldOffset(4)]
        public int Alignment;
        [FieldOffset(8)]
        public int Size;
    };

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct FScriptSparseArray
    {
        [FieldOffset(0)]
        public FScriptArray Data;
        [FieldOffset(16)]
        public FScriptBitArray AllocationFlags;
        [FieldOffset(48)]
        public int FirstFreeIndex;
        [FieldOffset(52)]
        public int NumFreeIndices;
    }

    public class TStructArray<T> where T:struct
    {
        public FScriptArray InterArray;

        public TStructArray(FScriptArray ScriptArray) { InterArray = ScriptArray; }

        public static explicit operator TStructArray<T>(FScriptArray ScriptArray) { return new TStructArray<T>(ScriptArray); }

        public T this[int index]
        {
            //实现索引器的get方法
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }
                return (T)Marshal.PtrToStructure(FScriptArray.GetData(ref InterArray) + Marshal.SizeOf(typeof(T))*index, typeof(T));
            }

            //实现索引器的set方法
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                Marshal.StructureToPtr(value, FScriptArray.GetData(ref InterArray) + Marshal.SizeOf(typeof(T)) * index, false);
            }
        }

        public void InsertZeroed(int Index, int Count)
        {
            FScriptArray.InsertZeroed(ref InterArray, Index, Count, Marshal.SizeOf(typeof(T)));
        }

        public void Insert(int Index, int Count)
        {
            FScriptArray.Insert(ref InterArray, Index, Count, Marshal.SizeOf(typeof(T)));
        }

        public int Add(int Count)
        {
            return FScriptArray.Add(ref InterArray, Count, Marshal.SizeOf(typeof(T)));
        }

        public int Add(T v)
        {
            int idx = Add(1);
            this[idx] = v;
            return idx;
        }

        public int AddZerod(int Count)
        {
            return FScriptArray.AddZerod(ref InterArray, Count, Marshal.SizeOf(typeof(T)));
        }

        public void Shrink()
        {
            FScriptArray.Shrink(ref InterArray, Marshal.SizeOf(typeof(T)));
        }

        public void Empty(int Slack)
        {
            FScriptArray.Empty(ref InterArray, Slack, Marshal.SizeOf(typeof(T)));
        }

        public void Remove(int Index, int Count)
        {
            FScriptArray.Remove(ref InterArray, Index, Count, Marshal.SizeOf(typeof(T)));
        }


        public int GetSlack()
        {
            return InterArray.GetSlack();
        }

        public int Num()
        {
            return InterArray.Num();
        }

        public bool IsValidIndex(int i)
        {
            return InterArray.IsValidIndex(i);
        }
    }


    public class TObjectArray<T> where T:UObject, new()
    {
        public FScriptArray InterArray;
        public TObjectArray(FScriptArray ScriptArray) { InterArray = ScriptArray; }

        public T this[int index]
        {
            //实现索引器的get方法
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }
                return  UObject.WrapObject<T>(Marshal.ReadIntPtr(FScriptArray.GetData(ref InterArray) + IntPtr.Size * index));
            }

            //实现索引器的set方法
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                Marshal.WriteIntPtr(FScriptArray.GetData(ref InterArray) + IntPtr.Size * index,value!=null? value._this.Get():IntPtr.Zero);
            }
        }

        public void InsertZeroed(int Index, int Count)
        {
            FScriptArray.InsertZeroed(ref InterArray, Index, Count, IntPtr.Size);
        }

        public void Insert(int Index, int Count)
        {
            FScriptArray.Insert(ref InterArray, Index, Count, IntPtr.Size);
        }

        public int Add(int Count)
        {
            return FScriptArray.Add(ref InterArray, Count, IntPtr.Size);
        }

        public int Add(T v)
        {
            int idx = Add(1);
            this[idx] = v;
            return idx;
        }

        public int AddZerod(int Count)
        {
            return FScriptArray.AddZerod(ref InterArray, Count, IntPtr.Size);
        }

        public void Shrink()
        {
            FScriptArray.Shrink(ref InterArray, IntPtr.Size);
        }

        public void Empty(int Slack)
        {
            FScriptArray.Empty(ref InterArray, Slack, IntPtr.Size);
        }

        public void Remove(int Index, int Count)
        {
            FScriptArray.Remove(ref InterArray, Index, Count, IntPtr.Size);
        }


        public int GetSlack()
        {
            return InterArray.GetSlack();
        }

        public int Num()
        {
            return InterArray.Num();
        }

        public bool IsValidIndex(int i)
        {
            return InterArray.IsValidIndex(i);
        }
    }

}
