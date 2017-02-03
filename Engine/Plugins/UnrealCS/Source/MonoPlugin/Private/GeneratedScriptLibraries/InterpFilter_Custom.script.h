#pragma once

namespace UnrealEngine
{
	class _UInterpFilter_Custom
	{
		static UClass* StaticClass(){return UInterpFilter_Custom::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpFilter_Custom::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
