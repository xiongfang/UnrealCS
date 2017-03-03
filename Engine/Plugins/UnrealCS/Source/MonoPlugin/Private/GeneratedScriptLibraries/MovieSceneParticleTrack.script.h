#pragma once

namespace UnrealEngine
{
	class _UMovieSceneParticleTrack
	{
		static UClass* StaticClass(){return UMovieSceneParticleTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneParticleTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
