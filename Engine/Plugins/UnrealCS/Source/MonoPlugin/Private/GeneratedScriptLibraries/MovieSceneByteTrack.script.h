#pragma once

namespace UnrealEngine
{
	class _UMovieSceneByteTrack
	{
		static UClass* StaticClass(){return UMovieSceneByteTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneByteTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
