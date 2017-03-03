#pragma once

namespace UnrealEngine
{
	class _UBlueprintMapLibrary
	{
		static UClass* StaticClass(){return UBlueprintMapLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintMapLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
