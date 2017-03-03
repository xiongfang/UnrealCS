#pragma once

namespace UnrealEngine
{
	class _UWorld
	{
		static UClass* StaticClass(){return UWorld::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWorld::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
