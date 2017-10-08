using System;
using System.Runtime.CompilerServices;
namespace UnrealEngine
{
    public partial class UObject
    {
        //不能在这里初始化为Zero，否则MONO内部初始化会无效
        //public FWeakObjectPtr _this;

        //public static implicit operator UObject(IntPtr p)
        //{
        //    if (p == IntPtr.Zero)
        //        return null;
        //    return new UObject() { _this = p };
        //}

        //public static implicit operator IntPtr(UObject p)
        //{
        //    if (p == null)
        //        return IntPtr.Zero;
        //    return p._this.Get();
        //}


        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern void _LogInfo(string msg);
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern void _LogWarning(string msg);
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern void _LogError(string msg);

        //public extern static void LogInfo(string msg, params object[] args);
        ////{
        ////    _LogInfo(string.Format(msg, args));
        ////}
        //public extern static void LogWarning(string msg, params object[] args);
        ////{
        ////    _LogWarning(string.Format(msg, args));
        ////}
        //public extern static void LogError(string msg, params object[] args);
        ////{
        ////    _LogError(string.Format(msg, args));
        ////}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern string GetName(IntPtr _this);

        public extern FName GetName();
        //{
        //    CheckIsValid();
        //    return GetName(_this.Get());
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern IntPtr _GetClass(IntPtr _this);
        //public UClass GetClass()
        //{
        //    CheckIsValid();
        //    return _GetClass(this);
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern IntPtr GetOuter(IntPtr _this);
        //public UObject GetOuter()
        //{
        //    CheckIsValid(); return GetOuter(_this.Get());
        //}

        //protected void CheckIsValid()
        //{
        //    if (!_this.IsValid())
        //    {
        //        throw new Exception("Object Has Been Deleted But You Still Want To Visit It!");
        //    }
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        if (!_this.IsValid())
        //            return true;
        //        else
        //            return false;

        //    UObject _uobj = obj as UObject;
        //    if (_uobj != null)
        //    {
        //        return _this == _uobj._this;
        //    }

        //    return System.Object.ReferenceEquals(this, obj);
        //}
        //public static bool operator ==(UObject a, UObject b)
        //{
        //    // If both are null, or both are same instance, return true.
        //    if (System.Object.ReferenceEquals(a, b))
        //    {
        //        return true;
        //    }

        //    // If one is null, but not both, return false.
        //    if ((object)a != null)
        //    {
        //        return a.Equals(b);
        //    }
        //    else if ((object)b != null)
        //    {
        //        return b.Equals(a);
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //public static bool operator !=(UObject a, UObject b)
        //{
        //    return !(a == b);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern IntPtr NewObject(IntPtr _Class);


        /// <summary>
        /// 返回类型的UClass类
        /// </summary>
        /// <param name="type">必须继承于UObject</param>
        ///// <returns></returns>
        //public static IntPtr TypeClass(Type type)
        //{
        //    System.Reflection.MethodInfo mi = type.GetMethod("StaticClass", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        //    if (mi != null)
        //    {
        //        return (IntPtr)mi.Invoke(null, null);
        //    }

        //    if (type.IsSubclassOf(typeof(UMonoActorComponent)))
        //    {
        //        //注意，不能传入UBattlerComponent模参数，LoadClass内部需要UActorComponent.StaticClass，从而造成无限循环而栈溢出
        //        return UObject.LoadClass<UActorComponent>(null, string.Format("MonoBlueprint'/Game/Scripts/Blueprints/{0}.{0}_C'", type.Name));
        //    }

        //    throw new ArgumentException(string.Format("Type of {0} class not define!", type.Name));
        //}

        ///// <summary>
        ///// 返回泛型T的UClass
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <returns></returns>
        //public static IntPtr TypeClass<T>() where T : UObject, new()
        //{
        //    return TypeClass(typeof(T));
        //}

        //public static T NewObject<T>() where T : UObject, new()
        //{
        //    IntPtr classPtr = TypeClass<T>();
        //    IntPtr v = NewObject(classPtr);
        //    if (v == IntPtr.Zero) return null;
        //    return new T() { _this = v };
        //}

        //public static T NewObject<T>(UClass Class) where T : UObject, new()
        //{
        //    T t = new T() { _this = NewObject(Class) };
        //    return t;
        //}


        ////给IntPtr创建合适的UObject对象
        //public static T WrapObject<T>(IntPtr ObjPtr) where T : UObject, new()
        //{
        //    UClass classObj = _GetClass(ObjPtr);
        //    T t = System.Activator.CreateInstance(Type.GetType(classObj.GetClassNameCpp())) as T;
        //    t._this = ObjPtr;
        //    return t;
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //static extern int IsChildOf(IntPtr _this, IntPtr _class);

        public extern bool IsChildOf<T>() where T : UObject, new();
        //{
        //    CheckIsValid();
        //    IntPtr classPtr = TypeClass<T>();
        //    return IsChildOf(_this.Get(), classPtr) != 0;
        //}

        /// <summary>
        /// 类型转换。
        /// 注意：如果T非UMonoActorComponent子类，这个方法可能返回新对象。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public extern static T Cast<T>(UObject obj) where T : UObject, new();
        //{
        //    if (obj == null)
        //        return null;
        //    if (obj is T)
        //        return obj as T;

        //    if (typeof(T).IsSubclassOf(typeof(UMonoActorComponent)))
        //    {
        //        return GetManagedObject(obj) as T;
        //    }
        //    if (obj.IsChildOf<T>())
        //    {
        //        T newObj = new T();
        //        newObj._this = obj._this;
        //        return newObj;
        //    }

        //    return null;
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static object GetManagedObject(IntPtr Ptr);

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr _StaticClass();

        //public static UClass StaticClass()
        //{
        //    return _StaticClass();
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //public static extern int GetPropertyOffset(IntPtr Struct, string ProName);
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //public static extern IntPtr GetNativeClassFromName(string InClassName);
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //public static extern IntPtr GetNativeStructFromName(string InStructName);
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //public static extern int GetNativeStructSize(string InStructName);

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr GetWorld(IntPtr _this);

        public extern UWorld GetWorld();
        //{
        //    return new UWorld() { _this = GetWorld(_this.Get()) };
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr _StaticFindObjectFast(IntPtr Class, IntPtr InOuter, string InName, bool ExactClass = false, bool AnyPackage = false);

        public extern static UObject StaticFindObjectFast(UClass Class, UObject InOuter, string InName, bool ExactClass = false, bool AnyPackage = false);
        //{
        //    return new UObject() { _this = _StaticFindObjectFast(Class, InOuter, InName, ExactClass, AnyPackage) };
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr _StaticFindObject(IntPtr Class, IntPtr InOuter, string InName, bool ExactClass = false);

        public extern static UObject StaticFindObject(UClass Class, UObject InOuter, string InName, bool ExactClass = false);
        //{
        //    IntPtr r = _StaticFindObject(Class, InOuter, InName, ExactClass);
        //    if (r == IntPtr.Zero)
        //        return null;
        //    return new UObject()
        //    {
        //        _this = r
        //    };
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr _StaticLoadObject(IntPtr Class, IntPtr InOuter, string Name, string Filename, uint LoadFlags, IntPtr Sandbox, bool bAllowObjectReconciliation);

        public extern static UObject StaticLoadObject(UClass Class, UObject InOuter, string Name, string Filename = null, uint LoadFlags = 0, UPackageMap Sandbox = null, bool bAllowObjectReconciliation = true);
        //{
        //    return _StaticLoadObject(Class, InOuter, Name, Filename, LoadFlags, Sandbox , bAllowObjectReconciliation);
        //}
        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static IntPtr _StaticLoadClass(IntPtr BaseClass, IntPtr InOuter, string Name, string Filename, uint LoadFlags, IntPtr Sandbox);

        public extern static UClass StaticLoadClass(UClass BaseClass, UObject InOuter, string Name, string Filename = null, uint LoadFlags = 0, UPackageMap Sandbox = null);
        //{
        //    IntPtr r = _StaticLoadClass(BaseClass, InOuter, Name, Filename, LoadFlags, Sandbox);
        //    if (r == IntPtr.Zero)
        //        return null;
        //    return new UClass() { _this = r };
        //}

        public extern static T FindObject<T>(UObject InOuter, string InName, bool ExactClass = false) where T : UObject, new();
        //{
        //    return Cast<T>(StaticFindObject(TypeClass<T>(), InOuter, InName, ExactClass));
        //}

        public extern static T LoadObject<T>(UObject InOuter, string Name, string Filename = null, uint LoadFlags = 0, UPackageMap Sandbox = null, bool bAllowObjectReconciliation = true) where T : UObject, new();
        //{
        //    return Cast<T>(StaticLoadObject(TypeClass<T>(), InOuter, Name, Filename, LoadFlags, Sandbox, bAllowObjectReconciliation));
        //}

        public extern static UClass LoadClass<T>(UObject InOuter, string Name, string Filename = null, uint LoadFlags = 0, UPackageMap Sandbox = null) where T : UObject, new();
        //{
        //    return StaticLoadClass(TypeClass<T>(), InOuter, Name, Filename, LoadFlags, Sandbox);
        //}

        ////[MethodImplAttribute(MethodImplOptions.InternalCall)]
        //extern static string _MakeUniqueObjectName(IntPtr Outer, IntPtr Class, string BaseName);

        public extern static string MakeUniqueObjectName(UObject Outer, UClass Class, string BaseName);
        //{
        //    return _MakeUniqueObjectName(Outer, Class, BaseName);
        //}

    }


    public partial class UClass
    {
        //public static implicit operator UClass(IntPtr p)
        //{
        //    if (p == IntPtr.Zero)
        //        return null;
        //    return new UClass() { _this = p };
        //}
    }
}
