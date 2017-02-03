#pragma once

namespace UnrealEngine
{
	class _UAnimBlueprint
	{
		static UClass* StaticClass(){return UAnimBlueprint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimBlueprint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
