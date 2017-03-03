#pragma once

namespace UnrealEngine
{
	class _UEngine
	{
		static UClass* StaticClass(){return UEngine::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEngine::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
