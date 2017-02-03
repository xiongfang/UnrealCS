#pragma once

namespace UnrealEngine
{
	class _UBlueprintCore
	{
		static UClass* StaticClass(){return UBlueprintCore::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintCore::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
