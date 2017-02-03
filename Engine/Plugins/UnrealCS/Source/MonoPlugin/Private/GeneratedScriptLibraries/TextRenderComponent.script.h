#pragma once

namespace UnrealEngine
{
	class _UTextRenderComponent
	{
		static FVector GetTextWorldSize(UTextRenderComponent* _this)
		{
			FVector ___ret = _this->GetTextWorldSize();
			return ___ret;
			
		}
		static FVector GetTextLocalSize(UTextRenderComponent* _this)
		{
			FVector ___ret = _this->GetTextLocalSize();
			return ___ret;
			
		}
		static void SetWorldSize(UTextRenderComponent* _this,float Value)
		{
			_this->SetWorldSize(Value);
			
		}
		static void SetVertSpacingAdjust(UTextRenderComponent* _this,float Value)
		{
			_this->SetVertSpacingAdjust(Value);
			
		}
		static void SetHorizSpacingAdjust(UTextRenderComponent* _this,float Value)
		{
			_this->SetHorizSpacingAdjust(Value);
			
		}
		static void SetYScale(UTextRenderComponent* _this,float Value)
		{
			_this->SetYScale(Value);
			
		}
		static void SetXScale(UTextRenderComponent* _this,float Value)
		{
			_this->SetXScale(Value);
			
		}
		static void SetTextRenderColor(UTextRenderComponent* _this,FColor* Value)
		{
			_this->SetTextRenderColor(*Value);
			
		}
		static void SetVerticalAlignment(UTextRenderComponent* _this,int32 Value)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalTextAligment>)Value);
			
		}
		static void SetHorizontalAlignment(UTextRenderComponent* _this,int32 Value)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizTextAligment>)Value);
			
		}
		static void SetFont(UTextRenderComponent* _this,UFont* Value)
		{
			_this->SetFont(Value);
			
		}
		static void SetTextMaterial(UTextRenderComponent* _this,UMaterialInterface* Material)
		{
			_this->SetTextMaterial(Material);
			
		}
		static void K2_SetText(UTextRenderComponent* _this,MonoString* Value)
		{
			FText Value_temp=FText::FromString(MonoStringToFString(Value));
			_this->K2_SetText(Value_temp);
			
		}
		static UClass* StaticClass(){return UTextRenderComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::GetTextWorldSize",(const void*)GetTextWorldSize);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::GetTextLocalSize",(const void*)GetTextLocalSize);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetWorldSize",(const void*)SetWorldSize);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetVertSpacingAdjust",(const void*)SetVertSpacingAdjust);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetHorizSpacingAdjust",(const void*)SetHorizSpacingAdjust);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetYScale",(const void*)SetYScale);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetXScale",(const void*)SetXScale);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetTextRenderColor",(const void*)SetTextRenderColor);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetFont",(const void*)SetFont);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::SetTextMaterial",(const void*)SetTextMaterial);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::K2_SetText",(const void*)K2_SetText);
			mono_add_internal_call("UnrealEngine.UTextRenderComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
