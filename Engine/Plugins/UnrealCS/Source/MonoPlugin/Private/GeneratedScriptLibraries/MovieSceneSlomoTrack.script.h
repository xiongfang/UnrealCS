#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSlomoTrack
	{
		static UClass* StaticClass(){return UMovieSceneSlomoTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSlomoTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
