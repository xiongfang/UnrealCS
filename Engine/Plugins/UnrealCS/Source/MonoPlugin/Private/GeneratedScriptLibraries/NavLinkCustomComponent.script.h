#pragma once

namespace UnrealEngine
{
	class _UNavLinkCustomComponent
	{
		static UClass* StaticClass(){return UNavLinkCustomComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkCustomComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
