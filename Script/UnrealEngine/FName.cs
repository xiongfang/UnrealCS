using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FName
    {
        /** Index into the Names array (used to find String portion of the string/number pair used for comparison) */
        [FieldOffset(0)]
        public int ComparisonIndex;
		/** Index into the Names array (used to find String portion of the string/number pair used for display) */
        [FieldOffset(4)]
        public int DisplayIndex;
        /** Number portion of the string/number pair (stored internally as 1 more than actual, so zero'd memory will be the default, no-instance case) */
        [FieldOffset(8)]
        public uint Number;

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static string ToString(ref FName Name);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static FName FromString(string ret);

        public override string ToString()
        {
            return FName.ToString(ref this);
        }

        public static implicit operator FName(string name)
        {
            return FName.FromString(name);
        }
        public static implicit operator string(FName str)
        {
            return str.ToString();
        }
    }
}
