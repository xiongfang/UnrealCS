#pragma once

namespace UnrealEngine
{
	class _URetainerBox
	{
		static void SetTextureParameter(URetainerBox* _this,MonoString* TextureParameter)
		{
			FName TextureParameter_temp=MonoStringToFName(TextureParameter);
			_this->SetTextureParameter(TextureParameter_temp);
			
		}
		static void SetEffectMaterial(URetainerBox* _this,UMaterialInterface* EffectMaterial)
		{
			_this->SetEffectMaterial(EffectMaterial);
			
		}
		static UMaterialInstanceDynamic* GetEffectMaterial(URetainerBox* _this)
		{
			UMaterialInstanceDynamic* ___ret = _this->GetEffectMaterial();
			return ___ret;
			
		}
		static UClass* StaticClass(){return URetainerBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URetainerBox::SetTextureParameter",(const void*)SetTextureParameter);
			mono_add_internal_call("UnrealEngine.URetainerBox::SetEffectMaterial",(const void*)SetEffectMaterial);
			mono_add_internal_call("UnrealEngine.URetainerBox::GetEffectMaterial",(const void*)GetEffectMaterial);
			mono_add_internal_call("UnrealEngine.URetainerBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
