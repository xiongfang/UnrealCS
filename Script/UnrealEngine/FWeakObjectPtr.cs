using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FWeakObjectPtr
    {
        private int ObjectIndex;
        private int ObjectSerialNumber;


        public bool IsValid()
        {
            return IsValid(ref this) != 0;
        }
        public void Reset()
        {
            Reset(ref this);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static int IsValid(ref FWeakObjectPtr data);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void Reset(ref FWeakObjectPtr data);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void Set(ref FWeakObjectPtr data, IntPtr Ptr);
        public void Set(IntPtr Ptr)
        {
            Set(ref this, Ptr);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static IntPtr Get(ref FWeakObjectPtr data);
        public IntPtr Get()
        {
            return Get(ref this);
        }

        public override int GetHashCode()
        { return base.GetHashCode(); }
        public override bool Equals(object obj)
        {
            FWeakObjectPtr _uobj = (FWeakObjectPtr)obj;
            return _uobj.ObjectIndex == ObjectIndex && _uobj.ObjectSerialNumber == ObjectSerialNumber;
        }
        public static bool operator ==(FWeakObjectPtr a, FWeakObjectPtr b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(FWeakObjectPtr a, FWeakObjectPtr b)
        {
            return !(a == b);
        }


        public static implicit operator FWeakObjectPtr(IntPtr Ptr)
        {
            FWeakObjectPtr t = new FWeakObjectPtr();
            t.Set(Ptr);
            return t;
        }

        public readonly static FWeakObjectPtr Zero = new FWeakObjectPtr();
        
    }
}
