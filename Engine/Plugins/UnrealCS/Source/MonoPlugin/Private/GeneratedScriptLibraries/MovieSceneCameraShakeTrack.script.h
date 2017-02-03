#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraShakeTrack
	{
		static UClass* StaticClass(){return UMovieSceneCameraShakeTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraShakeTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
