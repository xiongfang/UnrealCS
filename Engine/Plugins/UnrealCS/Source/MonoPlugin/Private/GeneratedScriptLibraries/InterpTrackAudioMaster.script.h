#pragma once

namespace UnrealEngine
{
	class _UInterpTrackAudioMaster
	{
		static UClass* StaticClass(){return UInterpTrackAudioMaster::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackAudioMaster::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
