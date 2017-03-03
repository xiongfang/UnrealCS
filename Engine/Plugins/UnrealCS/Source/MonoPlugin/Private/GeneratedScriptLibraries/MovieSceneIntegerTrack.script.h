#pragma once

namespace UnrealEngine
{
	class _UMovieSceneIntegerTrack
	{
		static UClass* StaticClass(){return UMovieSceneIntegerTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneIntegerTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
