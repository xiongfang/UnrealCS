#pragma once

namespace UnrealEngine
{
	class _UNavRelevantComponent
	{
		static void SetNavigationRelevancy(UNavRelevantComponent* _this,int32 bRelevant)
		{
			_this->SetNavigationRelevancy(bRelevant>0?true:false);
			
		}
		static UClass* StaticClass(){return UNavRelevantComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavRelevantComponent::SetNavigationRelevancy",(const void*)SetNavigationRelevancy);
			mono_add_internal_call("UnrealEngine.UNavRelevantComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
