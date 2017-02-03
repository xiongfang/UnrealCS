#pragma once

namespace UnrealEngine
{
	class _UInterpGroupInstDirector
	{
		static UClass* StaticClass(){return UInterpGroupInstDirector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpGroupInstDirector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
