#pragma once

namespace UnrealEngine
{
	class _UInterpGroupDirector
	{
		static UClass* StaticClass(){return UInterpGroupDirector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpGroupDirector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
