using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class AMonoPlayerController:APlayerController
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static new IntPtr StaticClass();
    }
}
