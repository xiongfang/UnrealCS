#pragma once

namespace UnrealEngine
{
	class _UMovieSceneFadeTrack
	{
		static UClass* StaticClass(){return UMovieSceneFadeTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneFadeTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
