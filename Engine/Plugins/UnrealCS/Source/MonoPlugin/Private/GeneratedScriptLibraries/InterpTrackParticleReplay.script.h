#pragma once

namespace UnrealEngine
{
	class _UInterpTrackParticleReplay
	{
		static UClass* StaticClass(){return UInterpTrackParticleReplay::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackParticleReplay::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
