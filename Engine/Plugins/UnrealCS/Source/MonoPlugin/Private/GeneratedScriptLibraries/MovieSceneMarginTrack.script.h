#pragma once

namespace UnrealEngine
{
	class _UMovieSceneMarginTrack
	{
		static UClass* StaticClass(){return UMovieSceneMarginTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneMarginTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
