#pragma once

namespace UnrealEngine
{
	class _ALevelBounds
	{
		static UClass* StaticClass(){return ALevelBounds::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALevelBounds::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
