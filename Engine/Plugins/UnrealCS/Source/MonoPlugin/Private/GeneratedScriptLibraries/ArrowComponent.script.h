#pragma once

namespace UnrealEngine
{
	class _UArrowComponent
	{
		static void SetArrowColor_New(UArrowComponent* _this,FLinearColor* NewColor)
		{
			_this->SetArrowColor_New(*NewColor);
			
		}
		static UClass* StaticClass(){return UArrowComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UArrowComponent::SetArrowColor_New",(const void*)SetArrowColor_New);
			mono_add_internal_call("UnrealEngine.UArrowComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
