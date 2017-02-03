#pragma once

namespace UnrealEngine
{
	class _ULevelScriptBlueprint
	{
		static UClass* StaticClass(){return ULevelScriptBlueprint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULevelScriptBlueprint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
