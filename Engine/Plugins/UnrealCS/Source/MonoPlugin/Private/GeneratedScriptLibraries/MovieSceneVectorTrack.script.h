#pragma once

namespace UnrealEngine
{
	class _UMovieSceneVectorTrack
	{
		static UClass* StaticClass(){return UMovieSceneVectorTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneVectorTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
