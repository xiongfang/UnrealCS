#pragma once

namespace UnrealEngine
{
	class _UMovieSceneStringTrack
	{
		static UClass* StaticClass(){return UMovieSceneStringTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneStringTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
