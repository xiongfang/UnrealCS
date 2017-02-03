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
		static int32 IsMaterialSlotNameValid(UMeshComponent* _this,MonoString* MaterialSlotName)
		{
			FName MaterialSlotName_temp=MonoStringToFName(MaterialSlotName);
			bool ___ret = _this->IsMaterialSlotNameValid(MaterialSlotName_temp);
			return ___ret?1:0;
			
		}
		static MonoArray* GetMaterialSlotNames(UMeshComponent* _this)
		{
			TArray<FName> ___ret = _this->GetMaterialSlotNames();
			return TArrayToMonoArray(___ret,"UnrealEngine.FName,UnrealEngine");
			
		}
		static int32 GetMaterialIndex(UMeshComponent* _this,MonoString* MaterialSlotName)
		{
			FName MaterialSlotName_temp=MonoStringToFName(MaterialSlotName);
			int32 ___ret = _this->GetMaterialIndex(MaterialSlotName_temp);
			return ___ret;
			
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
			mono_add_internal_call("UnrealEngine.UMeshComponent::IsMaterialSlotNameValid",(const void*)IsMaterialSlotNameValid);
			mono_add_internal_call("UnrealEngine.UMeshComponent::GetMaterialSlotNames",(const void*)GetMaterialSlotNames);
			mono_add_internal_call("UnrealEngine.UMeshComponent::GetMaterialIndex",(const void*)GetMaterialIndex);
			mono_add_internal_call("UnrealEngine.UMeshComponent::GetMaterials",(const void*)GetMaterials);
			mono_add_internal_call("UnrealEngine.UMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
