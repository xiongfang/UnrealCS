#pragma once

namespace UnrealEngine
{
	class _UInterpTrackLinearColorBase
	{
		static UClass* StaticClass(){return UInterpTrackLinearColorBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackLinearColorBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
