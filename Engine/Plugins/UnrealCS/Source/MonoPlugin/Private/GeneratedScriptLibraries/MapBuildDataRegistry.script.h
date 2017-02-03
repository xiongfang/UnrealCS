#pragma once

namespace UnrealEngine
{
	class _UMapBuildDataRegistry
	{
		static UClass* StaticClass(){return UMapBuildDataRegistry::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMapBuildDataRegistry::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
