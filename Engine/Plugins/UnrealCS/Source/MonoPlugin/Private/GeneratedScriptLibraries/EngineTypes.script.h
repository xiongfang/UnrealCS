#pragma once

namespace UnrealEngine
{
	class _UEngineTypes
	{
		static UClass* StaticClass(){return UEngineTypes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEngineTypes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
