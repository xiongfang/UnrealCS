#pragma once

namespace UnrealEngine
{
	class _UMovieSceneAudioTrack
	{
		static UClass* StaticClass(){return UMovieSceneAudioTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneAudioTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
