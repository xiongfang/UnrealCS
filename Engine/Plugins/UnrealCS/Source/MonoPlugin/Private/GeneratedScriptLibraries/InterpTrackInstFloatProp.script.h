#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInstFloatProp
	{
		static UClass* StaticClass(){return UInterpTrackInstFloatProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInstFloatProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
