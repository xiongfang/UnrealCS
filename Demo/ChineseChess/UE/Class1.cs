using System;

namespace UE
{
    struct FString
    {

    }

    public class UObject
    {
        long handle;

        extern static FString GetName(long h);

        FString GetName()
        {
            return GetName(handle);
        }

        extern static public void Log(string msg);
    }

    public class UComponent:UObject
    {

    }

    public class UActorComponent:UComponent
    {
        public virtual void BeginPlay() { }
        public virtual void Tick(float deltaTime) { }
        public virtual void EndPlay() { }
    }
}
