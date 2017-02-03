using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial class UClass
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        static extern string GetClassNameCpp(IntPtr _this);

        public string GetClassNameCpp()
        {
            CheckIsValid();
            return GetClassNameCpp(_this.Get());
        }
    }
}
