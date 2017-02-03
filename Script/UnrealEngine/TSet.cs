using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct FScriptSetLayout
    {
        [FieldOffset(0)]
        public int ElementOffset;
        [FieldOffset(4)]
        public int HashNextIdOffset;
        [FieldOffset(8)]
        public int HashIndexOffset;
        [FieldOffset(12)]
        public int Size;
        [FieldOffset(16)]
        public FScriptSparseArrayLayout SparseArrayLayout;
    };

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FScriptSet
    {
        [FieldOffset(0)]
	    public FScriptSparseArray Elements;
        //[FieldOffset(56)]
        //public HashType   Hash;
        [FieldOffset(76)]
        public int HashSize;

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static FScriptSetLayout GetScriptLayout(int ElementSize, int ElementAlignment);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool IsValidIndex(ref FScriptSet _this,int Index);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
	    public extern static int Num(ref FScriptSet _this);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
	    public extern static int GetMaxIndex(ref FScriptSet _this);

    }
}
