#pragma once

namespace UnrealEngine
{
	class _UMovieSceneParticleParameterTrack
	{
		static UClass* StaticClass(){return UMovieSceneParticleParameterTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneParticleParameterTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
