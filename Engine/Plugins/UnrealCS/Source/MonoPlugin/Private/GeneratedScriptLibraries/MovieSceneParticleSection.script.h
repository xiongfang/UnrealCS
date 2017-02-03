#pragma once

namespace UnrealEngine
{
	class _UMovieSceneParticleSection
	{
		static UClass* StaticClass(){return UMovieSceneParticleSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneParticleSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
