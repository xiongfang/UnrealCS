using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UE
{
    struct FString
    {

    }

    public class UObject
    {
        long handle;

        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static FString GetName(long h);

        FString GetName()
        {
            return GetName(handle);
        }
    }

    public class UComponent:UObject
    {

    }
}
