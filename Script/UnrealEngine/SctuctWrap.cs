using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public class SctuctWrap<T> where T:struct
    {
        IntPtr _Instance;

        public SctuctWrap()
        {
            _Instance = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));
        }
        ~SctuctWrap()
        {
            if (_Instance != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_Instance);
            }
        }
    }
}
