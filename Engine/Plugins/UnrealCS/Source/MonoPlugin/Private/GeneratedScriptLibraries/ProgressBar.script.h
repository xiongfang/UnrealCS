#pragma once

namespace UnrealEngine
{
	class _UProgressBar
	{
		static void SetIsMarquee(UProgressBar* _this,int32 InbIsMarquee)
		{
			_this->SetIsMarquee(InbIsMarquee>0?true:false);
			
		}
		static void SetFillColorAndOpacity(UProgressBar* _this,FLinearColor* InColor)
		{
			_this->SetFillColorAndOpacity(*InColor);
			
		}
		static void SetPercent(UProgressBar* _this,float InPercent)
		{
			_this->SetPercent(InPercent);
			
		}
		static UClass* StaticClass(){return UProgressBar::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UProgressBar::SetIsMarquee",(const void*)SetIsMarquee);
			mono_add_internal_call("UnrealEngine.UProgressBar::SetFillColorAndOpacity",(const void*)SetFillColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UProgressBar::SetPercent",(const void*)SetPercent);
			mono_add_internal_call("UnrealEngine.UProgressBar::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
