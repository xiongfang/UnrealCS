using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkeletalMeshSocket:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InitializeSocketFromLocation(IntPtr _this,IntPtr SkelComp,ref FVector WorldLocation,ref FVector WorldNormal);
/// <summary>Sets BoneName, RelativeLocation and RelativeRotation based on closest bone to WorldLocation and WorldNormal</summary>
public  void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp,FVector WorldLocation,FVector WorldNormal)
{
	CheckIsValid();
	InitializeSocketFromLocation(_this.Get(),SkelComp,ref WorldLocation,ref WorldNormal);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSocketLocation(IntPtr _this,IntPtr SkelComp);
public  FVector GetSocketLocation(USkeletalMeshComponent SkelComp)
{
	CheckIsValid();
	FVector ___ret = GetSocketLocation(_this.Get(),SkelComp);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
