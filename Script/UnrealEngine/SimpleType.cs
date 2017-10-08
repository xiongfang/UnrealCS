using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnrealEngine
{
    public struct FUInt8
    {
        public extern static byte ToInt8(FUInt8 v);
    }
    public struct FUInt16
    {
        public extern static Int16 ToInt16(FUInt16 v);
    }
    public struct FInt32
    {
        public extern static Int32 ToInt32(FInt32 v);
        public extern FInt32 FromInt32(int v);
        public Int32 ToInt32()
        {
            return ToInt32(this);
        }
    }

}
