using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class AMonoGameMode:AGameMode
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static new IntPtr StaticClass();
    }
}
