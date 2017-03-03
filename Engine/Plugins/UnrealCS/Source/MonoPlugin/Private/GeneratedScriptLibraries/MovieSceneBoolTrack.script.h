#pragma once

namespace UnrealEngine
{
	class _UMovieSceneBoolTrack
	{
		static UClass* StaticClass(){return UMovieSceneBoolTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneBoolTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
