using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class FApp
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void AddTickableObject(object obj);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void RemoveTickableObject(object obj);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string GetGameName();
    }
}
