#pragma once

namespace UnrealEngine
{
	class _UInterpTrackFloatProp
	{
		static UClass* StaticClass(){return UInterpTrackFloatProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackFloatProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
