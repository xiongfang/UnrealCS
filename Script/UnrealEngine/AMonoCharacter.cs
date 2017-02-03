using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class AMonoCharacter : ACharacter
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static new IntPtr StaticClass();
    }
}
