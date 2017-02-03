#pragma once

namespace UnrealEngine
{
	class _USelection
	{
		static UClass* StaticClass(){return USelection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USelection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
