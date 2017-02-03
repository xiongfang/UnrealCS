using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    class AMonoAIController:AController
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static new IntPtr StaticClass();
    }
}
