using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FMulticastScriptDelegate
    {
        public FScriptArray InvocationList;


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void Add(ref FMulticastScriptDelegate This,IntPtr InObject, string funcName);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void Remove(ref FMulticastScriptDelegate This, IntPtr InObject, string funcName);

        public void Add(UObject InObject, string funcName)
        {
            Add(ref this, InObject, funcName);
        }

        public void Remove(UObject InObject, string funcName)
        {
            Remove(ref this, InObject, funcName);
        }
    }
}
