using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UViewport:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr Spawn(IntPtr _this,IntPtr ActorClass);
public  AActor Spawn(TSubclassOf<AActor>  ActorClass)
{
	CheckIsValid();
	IntPtr ___ret = Spawn(_this.Get(),ActorClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetViewRotation(IntPtr _this,ref FRotator Rotation);
public  void SetViewRotation(FRotator Rotation)
{
	CheckIsValid();
	SetViewRotation(_this.Get(),ref Rotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetViewRotation(IntPtr _this);
public  FRotator GetViewRotation()
{
	CheckIsValid();
	FRotator ___ret = GetViewRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetViewLocation(IntPtr _this,ref FVector Location);
public  void SetViewLocation(FVector Location)
{
	CheckIsValid();
	SetViewLocation(_this.Get(),ref Location);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetViewLocation(IntPtr _this);
public  FVector GetViewLocation()
{
	CheckIsValid();
	FVector ___ret = GetViewLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetViewportWorld(IntPtr _this);
public  UWorld GetViewportWorld()
{
	CheckIsValid();
	IntPtr ___ret = GetViewportWorld(_this.Get());
	if(___ret==IntPtr.Zero) return null; UWorld ___ret2= new UWorld(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
