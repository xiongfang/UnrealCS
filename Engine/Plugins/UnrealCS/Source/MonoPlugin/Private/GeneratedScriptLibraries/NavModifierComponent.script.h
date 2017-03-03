#pragma once

namespace UnrealEngine
{
	class _UNavModifierComponent
	{
		static void SetAreaClass(UNavModifierComponent* _this,TSubclassOf<UNavArea>  NewAreaClass)
		{
			_this->SetAreaClass(NewAreaClass);
			
		}
		static UClass* StaticClass(){return UNavModifierComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavModifierComponent::SetAreaClass",(const void*)SetAreaClass);
			mono_add_internal_call("UnrealEngine.UNavModifierComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
