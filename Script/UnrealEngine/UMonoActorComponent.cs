using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class UMonoActorComponent:UActorComponent
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static new IntPtr StaticClass();
    }
}
