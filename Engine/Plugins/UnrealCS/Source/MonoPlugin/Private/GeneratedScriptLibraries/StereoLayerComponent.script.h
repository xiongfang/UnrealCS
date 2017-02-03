#pragma once

namespace UnrealEngine
{
	class _UStereoLayerComponent
	{
		static void MarkTextureForUpdate(UStereoLayerComponent* _this)
		{
			_this->MarkTextureForUpdate();
			
		}
		static int32 GetPriority(UStereoLayerComponent* _this)
		{
			int32 ___ret = _this->GetPriority();
			return ___ret;
			
		}
		static void SetPriority(UStereoLayerComponent* _this,int32 InPriority)
		{
			_this->SetPriority(InPriority);
			
		}
		static FBox2D GetUVRect(UStereoLayerComponent* _this)
		{
			FBox2D ___ret = _this->GetUVRect();
			return ___ret;
			
		}
		static void SetUVRect(UStereoLayerComponent* _this,FBox2D* InUVRect)
		{
			_this->SetUVRect(*InUVRect);
			
		}
		static FVector2D GetQuadSize(UStereoLayerComponent* _this)
		{
			FVector2D ___ret = _this->GetQuadSize();
			return ___ret;
			
		}
		static void SetQuadSize(UStereoLayerComponent* _this,FVector2D* InQuadSize)
		{
			_this->SetQuadSize(*InQuadSize);
			
		}
		static UTexture* GetTexture(UStereoLayerComponent* _this)
		{
			UTexture* ___ret = _this->GetTexture();
			return ___ret;
			
		}
		static void SetTexture(UStereoLayerComponent* _this,UTexture* InTexture)
		{
			_this->SetTexture(InTexture);
			
		}
		static UClass* StaticClass(){return UStereoLayerComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::MarkTextureForUpdate",(const void*)MarkTextureForUpdate);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::GetPriority",(const void*)GetPriority);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::SetPriority",(const void*)SetPriority);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::GetUVRect",(const void*)GetUVRect);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::SetUVRect",(const void*)SetUVRect);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::GetQuadSize",(const void*)GetQuadSize);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::SetQuadSize",(const void*)SetQuadSize);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::GetTexture",(const void*)GetTexture);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::SetTexture",(const void*)SetTexture);
			mono_add_internal_call("UnrealEngine.UStereoLayerComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
