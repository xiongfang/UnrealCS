#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInstEvent
	{
		static UClass* StaticClass(){return UInterpTrackInstEvent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInstEvent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
