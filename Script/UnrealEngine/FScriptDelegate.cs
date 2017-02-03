using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace UnrealEngine
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FScriptDelegate
    {
        /** The object bound to this delegate, or nullptr if no object is bound */
        [FieldOffset(0)]
        public FWeakObjectPtr Object;

        /** Name of the function to call on the bound object */
        [FieldOffset(8)]
        public FName FunctionName;
    }
}
