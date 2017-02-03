#pragma once

namespace UnrealEngine
{
	class _UChildActorComponent
	{
		static void SetChildActorClass(UChildActorComponent* _this,TSubclassOf<AActor>  InClass)
		{
			_this->SetChildActorClass(InClass);
			
		}
		static UClass* StaticClass(){return UChildActorComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UChildActorComponent::SetChildActorClass",(const void*)SetChildActorClass);
			mono_add_internal_call("UnrealEngine.UChildActorComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
