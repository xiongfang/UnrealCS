#pragma once

namespace UnrealEngine
{
	class _UInterpTrackFloatBase
	{
		static UClass* StaticClass(){return UInterpTrackFloatBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackFloatBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
