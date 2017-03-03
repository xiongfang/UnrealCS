#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInst
	{
		static UClass* StaticClass(){return UInterpTrackInst::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInst::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
