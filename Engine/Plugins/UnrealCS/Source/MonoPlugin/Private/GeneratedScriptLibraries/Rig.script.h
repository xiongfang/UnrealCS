#pragma once

namespace UnrealEngine
{
	class _URig
	{
		static UClass* StaticClass(){return URig::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URig::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
