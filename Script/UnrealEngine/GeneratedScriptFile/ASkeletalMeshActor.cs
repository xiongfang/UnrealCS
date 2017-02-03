using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ASkeletalMeshActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedMaterial1(IntPtr _this);
public  void OnRep_ReplicatedMaterial1()
{
	CheckIsValid();
	OnRep_ReplicatedMaterial1(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedMaterial0(IntPtr _this);
public  void OnRep_ReplicatedMaterial0()
{
	CheckIsValid();
	OnRep_ReplicatedMaterial0(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedPhysAsset(IntPtr _this);
public  void OnRep_ReplicatedPhysAsset()
{
	CheckIsValid();
	OnRep_ReplicatedPhysAsset(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedMesh(IntPtr _this);
/// <summary>Replication Notification Callbacks</summary>
public  void OnRep_ReplicatedMesh()
{
	CheckIsValid();
	OnRep_ReplicatedMesh(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
