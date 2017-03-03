#pragma once

namespace UnrealEngine
{
	class _UMovieScenePropertyTrack
	{
		static UClass* StaticClass(){return UMovieScenePropertyTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScenePropertyTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
