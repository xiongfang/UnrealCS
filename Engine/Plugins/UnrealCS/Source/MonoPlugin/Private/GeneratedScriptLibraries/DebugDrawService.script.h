#pragma once

namespace UnrealEngine
{
	class _UDebugDrawService
	{
		static UClass* StaticClass(){return UDebugDrawService::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDebugDrawService::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
