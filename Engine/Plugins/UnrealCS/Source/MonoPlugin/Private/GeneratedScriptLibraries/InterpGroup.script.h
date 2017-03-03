#pragma once

namespace UnrealEngine
{
	class _UInterpGroup
	{
		static UClass* StaticClass(){return UInterpGroup::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpGroup::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
