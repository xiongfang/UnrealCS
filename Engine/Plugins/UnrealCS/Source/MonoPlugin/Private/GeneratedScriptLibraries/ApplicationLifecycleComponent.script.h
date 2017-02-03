#pragma once

namespace UnrealEngine
{
	class _UApplicationLifecycleComponent
	{
		static UClass* StaticClass(){return UApplicationLifecycleComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UApplicationLifecycleComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
