#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraAnimTrack
	{
		static UClass* StaticClass(){return UMovieSceneCameraAnimTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraAnimTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
