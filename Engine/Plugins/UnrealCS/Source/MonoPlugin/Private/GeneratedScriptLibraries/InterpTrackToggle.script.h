#pragma once

namespace UnrealEngine
{
	class _UInterpTrackToggle
	{
		static UClass* StaticClass(){return UInterpTrackToggle::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackToggle::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
