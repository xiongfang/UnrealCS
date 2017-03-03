#pragma once

namespace UnrealEngine
{
	class _UBackgroundBlur
	{
		static void SetLowQualityFallbackBrush(UBackgroundBlur* _this,FSlateBrush* InBrush)
		{
			_this->SetLowQualityFallbackBrush(*InBrush);
			
		}
		static void SetBlurStrength(UBackgroundBlur* _this,float InStrength)
		{
			_this->SetBlurStrength(InStrength);
			
		}
		static void SetBlurRadius(UBackgroundBlur* _this,int32 InBlurRadius)
		{
			_this->SetBlurRadius(InBlurRadius);
			
		}
		static void SetApplyAlphaToBlur(UBackgroundBlur* _this,int32 bInApplyAlphaToBlur)
		{
			_this->SetApplyAlphaToBlur(bInApplyAlphaToBlur>0?true:false);
			
		}
		static void SetVerticalAlignment(UBackgroundBlur* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UBackgroundBlur* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UBackgroundBlur* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UBackgroundBlur::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetLowQualityFallbackBrush",(const void*)SetLowQualityFallbackBrush);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetBlurStrength",(const void*)SetBlurStrength);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetBlurRadius",(const void*)SetBlurRadius);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetApplyAlphaToBlur",(const void*)SetApplyAlphaToBlur);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UBackgroundBlur::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
