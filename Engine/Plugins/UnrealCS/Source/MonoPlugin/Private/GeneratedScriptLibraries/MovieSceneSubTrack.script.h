#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSubTrack
	{
		static UClass* StaticClass(){return UMovieSceneSubTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSubTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
