#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSubSection
	{
		static UClass* StaticClass(){return UMovieSceneSubSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSubSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
