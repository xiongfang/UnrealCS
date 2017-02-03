using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial class UWorld
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        static extern IntPtr SpawnActor(IntPtr _this,IntPtr Class,ref FVector Location,ref FRotator Rotation);

        public AActor SpawnActor(UClass Class, FVector Location, FRotator Rotation)
        {
            AActor retValue = new AActor();
            retValue._this = SpawnActor(_this.Get(), Class._this.Get(), ref Location, ref Rotation);
            return retValue;
        }

        public T SpawnActor<T>(FVector Location, FRotator Rotation) where T:AActor,new()
        {
            T retValue = new T();
            Type type = typeof(T);
            IntPtr ClassPtr = TypeClass<T>();
            retValue._this = SpawnActor(_this.Get(), ClassPtr, ref Location, ref Rotation);
            return retValue;
        }

        public T SpawnActor<T>() where T : AActor, new()
        {
            FVector Location = new FVector();
            FRotator Rotation = new FRotator();
            return SpawnActor<T>(Location, Rotation);
        }
    }
}
