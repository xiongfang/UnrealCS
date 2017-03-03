#pragma once

namespace UnrealEngine
{
	class _UNavLinkComponent
	{
		static UClass* StaticClass(){return UNavLinkComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
