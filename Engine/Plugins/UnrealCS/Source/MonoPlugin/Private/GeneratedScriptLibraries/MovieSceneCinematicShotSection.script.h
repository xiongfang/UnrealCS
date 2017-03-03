#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCinematicShotSection
	{
		static UClass* StaticClass(){return UMovieSceneCinematicShotSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCinematicShotSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
