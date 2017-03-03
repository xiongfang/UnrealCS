#pragma once

namespace UnrealEngine
{
	class _UUserDefinedStruct
	{
		static UClass* StaticClass(){return UUserDefinedStruct::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUserDefinedStruct::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
