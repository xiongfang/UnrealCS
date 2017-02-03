using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct FScriptMapLayout
    {
        [FieldOffset(0)]
        public int KeyOffset;
        [FieldOffset(4)]
        public int ValueOffset;
        [FieldOffset(8)]
        public FScriptSetLayout SetLayout;
    };

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FScriptMap
    {
        [FieldOffset(0)]
        public FScriptSet Pairs;

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern bool IsValidIndex(ref FScriptMap _this,int Index);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern int Num(ref FScriptMap _this);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern int GetMaxIndex(ref FScriptMap _this);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern IntPtr GetData(ref FScriptMap _this, int Index, ref FScriptMapLayout Layout);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void Empty(ref FScriptMap _this, int Slack, ref  FScriptMapLayout Layout);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void RemoveAt(ref FScriptMap _this, int Index, ref FScriptMapLayout Layout);

        /**
         * Adds an uninitialized object to the map.
         * The map will need rehashing at some point after this call to make it valid.
         *
         * @return  The index of the added element.
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern int AddUninitialized(ref FScriptMap _this, ref FScriptMapLayout Layout);
    }

    public class TMap<TK,TV>
    {
        FScriptMap InternalMap;
        FScriptMapLayout MapLayout;

        public bool IsValidIndex(int Index)
        {
            return FScriptMap.IsValidIndex(ref InternalMap, Index);
        }

        public int Num()
        {
            return FScriptMap.Num(ref InternalMap);
        }

        public int GetMaxIndex()
        {
            return FScriptMap.GetMaxIndex(ref InternalMap);
        }

        public void Empty(int Slack)
        {
            FScriptMap.Empty(ref InternalMap,Slack,ref MapLayout);
        }

        public void RemoveAt(int Index)
        {
            FScriptMap.RemoveAt(ref InternalMap, Index, ref MapLayout);
        }

        public int AddUninitialized()
        {
            return FScriptMap.AddUninitialized(ref InternalMap, ref MapLayout);
        }
    }
}
