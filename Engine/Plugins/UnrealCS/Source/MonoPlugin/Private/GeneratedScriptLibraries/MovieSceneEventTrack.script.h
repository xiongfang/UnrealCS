#pragma once

namespace UnrealEngine
{
	class _UMovieSceneEventTrack
	{
		static UClass* StaticClass(){return UMovieSceneEventTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneEventTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
