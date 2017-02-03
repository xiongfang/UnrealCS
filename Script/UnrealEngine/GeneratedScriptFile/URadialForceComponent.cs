using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class URadialForceComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveObjectTypeToAffect(IntPtr _this,int ObjectType);
/// <summary>Remove an object type that is affected by this radial force</summary>
public  void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType)
{
	CheckIsValid();
	RemoveObjectTypeToAffect(_this.Get(),(int)ObjectType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddObjectTypeToAffect(IntPtr _this,int ObjectType);
/// <summary>Add an object type for this radial force to affect</summary>
public  void AddObjectTypeToAffect(EObjectTypeQuery ObjectType)
{
	CheckIsValid();
	AddObjectTypeToAffect(_this.Get(),(int)ObjectType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FireImpulse(IntPtr _this);
/// <summary>Fire a single impulse</summary>
public  void FireImpulse()
{
	CheckIsValid();
	FireImpulse(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
