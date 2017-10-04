using System;
namespace UnrealEngine
{
	public partial class UKismetMaterialLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Creates a Dynamic Material Instance which you can modify during gameplay.</summary>
		public extern static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject,UMaterialInterface Parent);
		/// <summary>Gets a vector parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
		public extern static FLinearColor GetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,FName ParameterName);
		/// <summary>Gets a scalar parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
		public extern static float GetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,FName ParameterName);
		/// <summary>Sets a vector parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
		public extern static void SetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,FName ParameterName,FLinearColor ParameterValue);
		/// <summary>Sets a scalar parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
		public extern static void SetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,FName ParameterName,float ParameterValue);
		
	}
	
}
