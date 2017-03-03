#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSpawnTrack
	{
		static UClass* StaticClass(){return UMovieSceneSpawnTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSpawnTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
