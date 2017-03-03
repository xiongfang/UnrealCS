#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSpawnSection
	{
		static UClass* StaticClass(){return UMovieSceneSpawnSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSpawnSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
