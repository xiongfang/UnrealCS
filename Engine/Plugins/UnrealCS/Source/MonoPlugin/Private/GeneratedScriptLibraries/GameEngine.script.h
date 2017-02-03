#pragma once

namespace UnrealEngine
{
	class _UGameEngine
	{
		static UClass* StaticClass(){return UGameEngine::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGameEngine::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
