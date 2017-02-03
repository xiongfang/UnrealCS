#pragma once

namespace UnrealEngine
{
	class _UNavLinkCustomInterface
	{
		static UClass* StaticClass(){return UNavLinkCustomInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkCustomInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
