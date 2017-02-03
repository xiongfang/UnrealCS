#pragma once

namespace UnrealEngine
{
	class _UNavLinkHostInterface
	{
		static UClass* StaticClass(){return UNavLinkHostInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkHostInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
