using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class BoolWrap
    {
        public static bool Get(IntPtr Ptr, int Offset, byte FieldSize, byte ByteOffset, byte ByteMask, byte FieldMask)
        {
            byte ByteValue = Marshal.ReadByte(Ptr + Offset + ByteOffset);
            return (ByteValue & FieldMask)!=0;
        }
        public static void Set(bool Value,IntPtr Ptr, int Offset, byte FieldSize, byte ByteOffset, byte ByteMask, byte FieldMask)
        {
            byte ByteValue = Marshal.ReadByte(Ptr + Offset + ByteOffset);
            ByteValue = (byte)(((ByteValue) & ~FieldMask) | (Value ? ByteMask : 0));
            Marshal.WriteByte(Ptr + Offset + ByteOffset, ByteValue);
        }
    }
}
