#pragma once

namespace UnrealEngine
{
	class _UNavLinkTrivial
	{
		static UClass* StaticClass(){return UNavLinkTrivial::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkTrivial::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
