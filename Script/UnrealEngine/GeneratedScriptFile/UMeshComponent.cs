using System;
namespace UnrealEngine
{
	public partial class UMeshComponent:UPrimitiveComponent
	{
		/// <summary>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
		public extern void SetVectorParameterValueOnMaterials(FName ParameterName,FVector ParameterValue);
		/// <summary>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
		public extern void SetScalarParameterValueOnMaterials(FName ParameterName,float ParameterValue);
		public extern virtual bool IsMaterialSlotNameValid(FName MaterialSlotName);
		public extern virtual int GetMaterialIndex(FName MaterialSlotName);
		
	}
	
}
