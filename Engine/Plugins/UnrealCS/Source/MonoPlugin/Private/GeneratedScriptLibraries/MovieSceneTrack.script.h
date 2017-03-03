#pragma once

namespace UnrealEngine
{
	class _UMovieSceneTrack
	{
		static UClass* StaticClass(){return UMovieSceneTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
