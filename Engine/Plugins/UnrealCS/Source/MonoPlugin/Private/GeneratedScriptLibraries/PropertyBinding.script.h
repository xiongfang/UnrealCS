#pragma once

namespace UnrealEngine
{
	class _UPropertyBinding
	{
		static UClass* StaticClass(){return UPropertyBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPropertyBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
