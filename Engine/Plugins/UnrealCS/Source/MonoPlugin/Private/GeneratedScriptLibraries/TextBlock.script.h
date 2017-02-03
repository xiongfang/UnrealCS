#pragma once

namespace UnrealEngine
{
	class _UTextBlock
	{
		static void SetText(UTextBlock* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->SetText(InText_temp);
			
		}
		static MonoString* GetText(UTextBlock* _this)
		{
			FText ___ret = _this->GetText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static void SetJustification(UTextBlock* _this,int32 InJustification)
		{
			_this->SetJustification((TEnumAsByte<ETextJustify::Type>)InJustification);
			
		}
		static void SetFont(UTextBlock* _this,FSlateFontInfo* InFontInfo)
		{
			_this->SetFont(*InFontInfo);
			
		}
		static void SetShadowOffset(UTextBlock* _this,FVector2D* InShadowOffset)
		{
			_this->SetShadowOffset(*InShadowOffset);
			
		}
		static void SetShadowColorAndOpacity(UTextBlock* _this,FLinearColor* InShadowColorAndOpacity)
		{
			_this->SetShadowColorAndOpacity(*InShadowColorAndOpacity);
			
		}
		static void SetOpacity(UTextBlock* _this,float InOpacity)
		{
			_this->SetOpacity(InOpacity);
			
		}
		static void SetColorAndOpacity(UTextBlock* _this,FSlateColor* InColorAndOpacity)
		{
			_this->SetColorAndOpacity(*InColorAndOpacity);
			
		}
		static UClass* StaticClass(){return UTextBlock::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextBlock::SetText",(const void*)SetText);
			mono_add_internal_call("UnrealEngine.UTextBlock::GetText",(const void*)GetText);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetJustification",(const void*)SetJustification);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetFont",(const void*)SetFont);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetShadowOffset",(const void*)SetShadowOffset);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetShadowColorAndOpacity",(const void*)SetShadowColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetOpacity",(const void*)SetOpacity);
			mono_add_internal_call("UnrealEngine.UTextBlock::SetColorAndOpacity",(const void*)SetColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UTextBlock::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
