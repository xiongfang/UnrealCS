#pragma once

namespace UnrealEngine
{
	class _UBillboardComponent
	{
		static void SetSpriteAndUV(UBillboardComponent* _this,UTexture2D* NewSprite,int32 NewU,int32 NewUL,int32 NewV,int32 NewVL)
		{
			_this->SetSpriteAndUV(NewSprite,NewU,NewUL,NewV,NewVL);
			
		}
		static void SetUV(UBillboardComponent* _this,int32 NewU,int32 NewUL,int32 NewV,int32 NewVL)
		{
			_this->SetUV(NewU,NewUL,NewV,NewVL);
			
		}
		static void SetSprite(UBillboardComponent* _this,UTexture2D* NewSprite)
		{
			_this->SetSprite(NewSprite);
			
		}
		static UClass* StaticClass(){return UBillboardComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBillboardComponent::SetSpriteAndUV",(const void*)SetSpriteAndUV);
			mono_add_internal_call("UnrealEngine.UBillboardComponent::SetUV",(const void*)SetUV);
			mono_add_internal_call("UnrealEngine.UBillboardComponent::SetSprite",(const void*)SetSprite);
			mono_add_internal_call("UnrealEngine.UBillboardComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
