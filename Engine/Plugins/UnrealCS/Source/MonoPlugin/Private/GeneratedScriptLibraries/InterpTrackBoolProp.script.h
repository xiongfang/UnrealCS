#pragma once

namespace UnrealEngine
{
	class _UInterpTrackBoolProp
	{
		static UClass* StaticClass(){return UInterpTrackBoolProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackBoolProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
