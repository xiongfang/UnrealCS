#pragma once

namespace UnrealEngine
{
	class _UMovieSceneColorSection
	{
		static UClass* StaticClass(){return UMovieSceneColorSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneColorSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
