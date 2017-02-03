#pragma once

namespace UnrealEngine
{
	class _UMovieSceneMaterialTrack
	{
		static UClass* StaticClass(){return UMovieSceneMaterialTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneMaterialTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
