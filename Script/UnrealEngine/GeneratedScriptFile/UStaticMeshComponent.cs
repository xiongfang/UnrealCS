using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStaticMeshComponent:UMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetLocalBounds(IntPtr _this,out FVector Min,out FVector Max);
/// <summary>Get Local bounds</summary>
public  void GetLocalBounds(out FVector Min,out FVector Max)
{
	CheckIsValid();
	GetLocalBounds(_this.Get(),out Min,out Max);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetForcedLodModel(IntPtr _this,int NewForcedLodModel);
public  void SetForcedLodModel(int NewForcedLodModel)
{
	CheckIsValid();
	SetForcedLodModel(_this.Get(),NewForcedLodModel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SetStaticMesh(IntPtr _this,IntPtr NewMesh);
/// <summary>Change the StaticMesh used by this instance.</summary>
public  bool SetStaticMesh(UStaticMesh NewMesh)
{
	CheckIsValid();
	int ___ret = SetStaticMesh(_this.Get(),NewMesh);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_StaticMesh(IntPtr _this,IntPtr OldStaticMesh);
public  void OnRep_StaticMesh(UStaticMesh OldStaticMesh)
{
	CheckIsValid();
	OnRep_StaticMesh(_this.Get(),OldStaticMesh);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
