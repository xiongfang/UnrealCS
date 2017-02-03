using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsHandleComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInterpolationSpeed(IntPtr _this,float NewInterpolationSpeed);
/// <summary>Set interpolation speed</summary>
public  void SetInterpolationSpeed(float NewInterpolationSpeed)
{
	CheckIsValid();
	SetInterpolationSpeed(_this.Get(),NewInterpolationSpeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularStiffness(IntPtr _this,float NewAngularStiffness);
/// <summary>Set angular stiffness</summary>
public  void SetAngularStiffness(float NewAngularStiffness)
{
	CheckIsValid();
	SetAngularStiffness(_this.Get(),NewAngularStiffness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDamping(IntPtr _this,float NewAngularDamping);
/// <summary>Set angular damping</summary>
public  void SetAngularDamping(float NewAngularDamping)
{
	CheckIsValid();
	SetAngularDamping(_this.Get(),NewAngularDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearStiffness(IntPtr _this,float NewLinearStiffness);
/// <summary>Set linear stiffness</summary>
public  void SetLinearStiffness(float NewLinearStiffness)
{
	CheckIsValid();
	SetLinearStiffness(_this.Get(),NewLinearStiffness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearDamping(IntPtr _this,float NewLinearDamping);
/// <summary>Set linear damping</summary>
public  void SetLinearDamping(float NewLinearDamping)
{
	CheckIsValid();
	SetLinearDamping(_this.Get(),NewLinearDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTargetLocationAndRotation(IntPtr _this,out FVector TargetLocation,out FRotator TargetRotation);
/// <summary>Get the current location and rotation</summary>
public  void GetTargetLocationAndRotation(out FVector TargetLocation,out FRotator TargetRotation)
{
	CheckIsValid();
	GetTargetLocationAndRotation(_this.Get(),out TargetLocation,out TargetRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTargetLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
/// <summary>Set target location and rotation</summary>
public  void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation)
{
	CheckIsValid();
	SetTargetLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTargetRotation(IntPtr _this,ref FRotator NewRotation);
/// <summary>Set the target rotation</summary>
public  void SetTargetRotation(FRotator NewRotation)
{
	CheckIsValid();
	SetTargetRotation(_this.Get(),ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTargetLocation(IntPtr _this,ref FVector NewLocation);
/// <summary>Set the target location</summary>
public  void SetTargetLocation(FVector NewLocation)
{
	CheckIsValid();
	SetTargetLocation(_this.Get(),ref NewLocation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ReleaseComponent(IntPtr _this);
/// <summary>Release the currently held component</summary>
public  void ReleaseComponent()
{
	CheckIsValid();
	ReleaseComponent(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GrabComponent(IntPtr _this,IntPtr Component,string InBoneName,ref FVector GrabLocation,int bConstrainRotation);
/// <summary>Grab the specified component</summary>
public  void GrabComponent(UPrimitiveComponent Component,string InBoneName,FVector GrabLocation,bool bConstrainRotation)
{
	CheckIsValid();
	GrabComponent(_this.Get(),Component,InBoneName,ref GrabLocation,bConstrainRotation?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
