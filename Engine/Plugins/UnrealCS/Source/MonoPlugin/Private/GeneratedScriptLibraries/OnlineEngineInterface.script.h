#pragma once

namespace UnrealEngine
{
	class _UOnlineEngineInterface
	{
		static UClass* StaticClass(){return UOnlineEngineInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOnlineEngineInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
