using System;

namespace UnrealEngine
{
    public struct TSubclassOf<T> where T:UObject,new()
    {
        private IntPtr NativeClassPtr;
        public IntPtr NativeClass
        {
            get
            {
                return NativeClassPtr;
            }
        }

        public TSubclassOf(Type klass)
        {
            if (klass == typeof(T) || klass.IsSubclassOf(typeof(T)))
            {
                NativeClassPtr = UObject.TypeClass(klass);
                if (NativeClassPtr == null)
                {
                    throw new ArgumentException(String.Format("{0} is invalid unreal class.", klass.Name));
                }
            }
            else
            {
                throw new ArgumentException(String.Format("{0} is not a subclass of {1}.", klass.Name, typeof(T).Name));
            }
        }

        public TSubclassOf(IntPtr nativeClass)
        {
            NativeClassPtr = nativeClass;
            //if (NativeClassPtr != IntPtr.Zero && SystemType == null)
            //{
            //    throw new InvalidOperationException(string.Format("{0} is not a valid value for SubclassOf<{1}>", UnrealObject.GetFName(NativeClassPtr), typeof(T).Name));
            //}
        }
        public static implicit operator TSubclassOf<T>(Type klass)
        {
            return new TSubclassOf<T>(klass);
        }
        public static implicit operator TSubclassOf<T>(IntPtr nativeClass)
        {
            return new TSubclassOf<T>(nativeClass);
        }
        public static implicit operator TSubclassOf<T>(UClass Class)
        {
            return new TSubclassOf<T>(Class!=null?Class._this.Get():IntPtr.Zero);
        }
        public static implicit operator IntPtr(TSubclassOf<T> V)
        {
            return V.NativeClassPtr;
        }
        public static implicit operator UClass(TSubclassOf<T> V)
        {
            return V.Class;
        }

        public UClass Class
        {
            get
            {
                UClass c = new UClass();
                c._this = NativeClassPtr;
                return c;
            }
        }

        //private Type SystemType
        //{
        //    get
        //    {
        //        if (NativeClass == IntPtr.Zero)
        //        {
        //            return null;
        //        }
        //        Type klass = Type.GetType("UnrealEngine."+Class.GetClassNameCpp());

        //        if (klass == typeof(T) || klass.IsSubclassOf(typeof(T)))
        //        {
        //            return klass;
        //        }
        //        else
        //        {
        //            //TODO: throw an exception?
        //            //      For now, soft fail on access in order to tolerate previously set classes that are no longer compatible.
        //            //      Ideally, this would be handled by deprecating the old property in favor of a new one and fixing things
        //            //      up in PostLoad, but we don't support this in managed code yet and need to be able to recover from a
        //            //      class property mismatch until we do.
        //            return null;
        //        }
        //    }
        //}
    }
}
