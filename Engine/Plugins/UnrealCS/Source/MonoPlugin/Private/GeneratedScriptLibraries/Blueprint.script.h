#pragma once

namespace UnrealEngine
{
	class _UBlueprint
	{
		static UClass* StaticClass(){return UBlueprint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
