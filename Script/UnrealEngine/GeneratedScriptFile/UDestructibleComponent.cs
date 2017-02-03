using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UDestructibleComponent:USkinnedMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDestructibleMesh(IntPtr _this);
public  UDestructibleMesh GetDestructibleMesh()
{
	CheckIsValid();
	IntPtr ___ret = GetDestructibleMesh(_this.Get());
	if(___ret==IntPtr.Zero) return null; UDestructibleMesh ___ret2= new UDestructibleMesh(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDestructibleMesh(IntPtr _this,IntPtr NewMesh);
public  void SetDestructibleMesh(UDestructibleMesh NewMesh)
{
	CheckIsValid();
	SetDestructibleMesh(_this.Get(),NewMesh);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyRadiusDamage(IntPtr _this,float BaseDamage,ref FVector HurtOrigin,float DamageRadius,float ImpulseStrength,int bFullDamage);
/// <summary>Take radius damage</summary>
public  void ApplyRadiusDamage(float BaseDamage,FVector HurtOrigin,float DamageRadius,float ImpulseStrength,bool bFullDamage)
{
	CheckIsValid();
	ApplyRadiusDamage(_this.Get(),BaseDamage,ref HurtOrigin,DamageRadius,ImpulseStrength,bFullDamage?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyDamage(IntPtr _this,float DamageAmount,ref FVector HitLocation,ref FVector ImpulseDir,float ImpulseStrength);
/// <summary>Take damage</summary>
public  void ApplyDamage(float DamageAmount,FVector HitLocation,FVector ImpulseDir,float ImpulseStrength)
{
	CheckIsValid();
	ApplyDamage(_this.Get(),DamageAmount,ref HitLocation,ref ImpulseDir,ImpulseStrength);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
