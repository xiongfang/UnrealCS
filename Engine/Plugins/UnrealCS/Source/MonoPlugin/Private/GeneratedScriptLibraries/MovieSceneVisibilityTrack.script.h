#pragma once

namespace UnrealEngine
{
	class _UMovieSceneVisibilityTrack
	{
		static UClass* StaticClass(){return UMovieSceneVisibilityTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneVisibilityTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
