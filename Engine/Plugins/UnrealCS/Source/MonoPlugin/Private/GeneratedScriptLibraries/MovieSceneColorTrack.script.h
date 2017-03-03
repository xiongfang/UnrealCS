#pragma once

namespace UnrealEngine
{
	class _UMovieSceneColorTrack
	{
		static UClass* StaticClass(){return UMovieSceneColorTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneColorTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
