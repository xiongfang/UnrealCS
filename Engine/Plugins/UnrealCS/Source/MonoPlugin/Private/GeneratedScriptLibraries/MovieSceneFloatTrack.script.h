#pragma once

namespace UnrealEngine
{
	class _UMovieSceneFloatTrack
	{
		static UClass* StaticClass(){return UMovieSceneFloatTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneFloatTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
