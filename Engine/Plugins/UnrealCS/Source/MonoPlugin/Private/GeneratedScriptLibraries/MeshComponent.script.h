#pragma once

namespace UnrealEngine
{
	class _UMeshComponent
	{
		static void SetVectorParameterValueOnMaterials(UMeshComponent* _this,MonoString* ParameterName,FVector* ParameterValue)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetVectorParameterValueOnMaterials(ParameterName_temp,*ParameterValue);
			
		}
		static void SetScalarParameterValueOnMaterials(UMeshComponent* _this,MonoString* ParameterName,float ParameterValue)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetScalarParameterValueOnMaterials(ParameterName_temp,ParameterValue);
			
		}
		static MonoArray* GetMaterials(UMeshComponent* _this)
		{
			TArray<UMaterialInterface*> ___ret = _this->GetMaterials();
			return TArrayToMonoArray(___ret,"System.IntPtr,mscorlib");
			
		}
		static UClass* StaticClass(){return UMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMeshComponent::SetVectorParameterValueOnMaterials",(const void*)SetVectorParameterValueOnMaterials);
			mono_add_internal_call("UnrealEngine.UMeshComponent::SetScalarParameterValueOnMaterials",(const void*)SetScalarParameterValueOnMaterials);
			mono_add_internal_call("UnrealEngine.UMeshComponent::GetMaterials",(const void*)GetMaterials);
			mono_add_internal_call("UnrealEngine.UMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
