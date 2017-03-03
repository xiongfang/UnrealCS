#pragma once

namespace UnrealEngine
{
	class _UNavLinkDefinition
	{
		static UClass* StaticClass(){return UNavLinkDefinition::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkDefinition::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
