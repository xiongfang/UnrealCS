#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCinematicShotTrack
	{
		static UClass* StaticClass(){return UMovieSceneCinematicShotTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCinematicShotTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
