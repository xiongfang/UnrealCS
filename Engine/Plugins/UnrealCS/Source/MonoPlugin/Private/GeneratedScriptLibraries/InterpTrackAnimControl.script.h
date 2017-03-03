#pragma once

namespace UnrealEngine
{
	class _UInterpTrackAnimControl
	{
		static UClass* StaticClass(){return UInterpTrackAnimControl::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackAnimControl::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
