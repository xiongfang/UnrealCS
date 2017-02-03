#pragma once

namespace UnrealEngine
{
	class _UNavigationInvokerComponent
	{
		static UClass* StaticClass(){return UNavigationInvokerComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationInvokerComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
