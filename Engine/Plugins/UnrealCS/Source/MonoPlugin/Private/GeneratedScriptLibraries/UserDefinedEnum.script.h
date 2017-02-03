#pragma once

namespace UnrealEngine
{
	class _UUserDefinedEnum
	{
		static UClass* StaticClass(){return UUserDefinedEnum::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUserDefinedEnum::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
