#pragma once

namespace UnrealEngine
{
	class _ALightmassPortal
	{
		static UClass* StaticClass(){return ALightmassPortal::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALightmassPortal::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
