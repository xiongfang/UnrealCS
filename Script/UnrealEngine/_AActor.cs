using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial class AActor
    {
        //[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern void Destroy(IntPtr _this);

        public extern void Destroy();
        //{
        //    CheckIsValid();
        //    Destroy(_this.Get());
        //}

        public extern T[] GetComponentsByClass<T>() where T : UObject, new();
        //{
        //    CheckIsValid();
        //    return MarshalUtil.IntPtrArrayToObjectArray<T>( GetComponentsByClass(_this.Get(),TypeClass<T>()));
        //}

        public extern T GetComponentByClass<T>() where T : UObject, new();
        //{
        //    CheckIsValid();
        //    return Cast<T>(GetComponentByClass(TypeClass<T>()));
        //}
    }
}
