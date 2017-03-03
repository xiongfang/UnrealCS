#pragma once

namespace UnrealEngine
{
	class _UMovieSceneEnumTrack
	{
		static UClass* StaticClass(){return UMovieSceneEnumTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneEnumTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
