using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FText
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string ToString(ref FText str);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static FText FromString(string ret);


        public string ToString(FText str)
        {
            return ToString(ref this);
        }

        public static implicit operator FText(string str)
        {
            return FromString(str);
        }

        public static implicit operator string(FText str)
        {
            return str.ToString();
        }
    }
}
