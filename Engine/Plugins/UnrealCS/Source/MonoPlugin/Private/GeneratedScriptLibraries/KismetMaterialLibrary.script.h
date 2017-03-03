#pragma once

namespace UnrealEngine
{
	class _UKismetMaterialLibrary
	{
		static UMaterialInstanceDynamic* CreateDynamicMaterialInstance(UKismetMaterialLibrary* _this,UObject* WorldContextObject,UMaterialInterface* Parent)
		{
			UMaterialInstanceDynamic* ___ret = _this->CreateDynamicMaterialInstance(WorldContextObject,Parent);
			return ___ret;
			
		}
		static FLinearColor GetVectorParameterValue(UKismetMaterialLibrary* _this,UObject* WorldContextObject,UMaterialParameterCollection* Collection,MonoString* ParameterName)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			FLinearColor ___ret = _this->GetVectorParameterValue(WorldContextObject,Collection,ParameterName_temp);
			return ___ret;
			
		}
		static float GetScalarParameterValue(UKismetMaterialLibrary* _this,UObject* WorldContextObject,UMaterialParameterCollection* Collection,MonoString* ParameterName)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			float ___ret = _this->GetScalarParameterValue(WorldContextObject,Collection,ParameterName_temp);
			return ___ret;
			
		}
		static void SetVectorParameterValue(UKismetMaterialLibrary* _this,UObject* WorldContextObject,UMaterialParameterCollection* Collection,MonoString* ParameterName,FLinearColor* ParameterValue)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetVectorParameterValue(WorldContextObject,Collection,ParameterName_temp,*ParameterValue);
			
		}
		static void SetScalarParameterValue(UKismetMaterialLibrary* _this,UObject* WorldContextObject,UMaterialParameterCollection* Collection,MonoString* ParameterName,float ParameterValue)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetScalarParameterValue(WorldContextObject,Collection,ParameterName_temp,ParameterValue);
			
		}
		static UClass* StaticClass(){return UKismetMaterialLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::CreateDynamicMaterialInstance",(const void*)CreateDynamicMaterialInstance);
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::GetVectorParameterValue",(const void*)GetVectorParameterValue);
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::GetScalarParameterValue",(const void*)GetScalarParameterValue);
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::SetVectorParameterValue",(const void*)SetVectorParameterValue);
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::SetScalarParameterValue",(const void*)SetScalarParameterValue);
			mono_add_internal_call("UnrealEngine.UKismetMaterialLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
