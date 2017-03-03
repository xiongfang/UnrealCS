#pragma once

namespace UnrealEngine
{
	class _UInterpTrackEvent
	{
		static UClass* StaticClass(){return UInterpTrackEvent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackEvent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
