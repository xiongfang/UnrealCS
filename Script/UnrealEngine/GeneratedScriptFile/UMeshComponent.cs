using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMeshComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorParameterValueOnMaterials(IntPtr _this,string ParameterName,ref FVector ParameterValue);
/// <summary>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
public  void SetVectorParameterValueOnMaterials(string ParameterName,FVector ParameterValue)
{
	CheckIsValid();
	SetVectorParameterValueOnMaterials(_this.Get(),ParameterName,ref ParameterValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScalarParameterValueOnMaterials(IntPtr _this,string ParameterName,float ParameterValue);
/// <summary>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
public  void SetScalarParameterValueOnMaterials(string ParameterName,float ParameterValue)
{
	CheckIsValid();
	SetScalarParameterValueOnMaterials(_this.Get(),ParameterName,ParameterValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] GetMaterials(IntPtr _this);
public  UMaterialInterface[] GetMaterials()
{
	CheckIsValid();
	IntPtr[] ___ret = GetMaterials(_this.Get());
	return MarshalUtil.IntPtrArrayToObjectArray<UMaterialInterface>(___ret);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
