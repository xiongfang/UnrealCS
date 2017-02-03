#pragma once

namespace UnrealEngine
{
	class _ULevel
	{
		static UClass* StaticClass(){return ULevel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULevel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
