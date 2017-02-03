#pragma once

namespace UnrealEngine
{
	class _UMovieSceneNameableTrack
	{
		static UClass* StaticClass(){return UMovieSceneNameableTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneNameableTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
