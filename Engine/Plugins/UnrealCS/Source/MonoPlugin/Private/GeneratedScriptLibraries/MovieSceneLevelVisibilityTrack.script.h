#pragma once

namespace UnrealEngine
{
	class _UMovieSceneLevelVisibilityTrack
	{
		static UClass* StaticClass(){return UMovieSceneLevelVisibilityTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneLevelVisibilityTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
