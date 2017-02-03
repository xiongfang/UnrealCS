#pragma once

namespace UnrealEngine
{
	class _UMovieSceneMarginSection
	{
		static UClass* StaticClass(){return UMovieSceneMarginSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneMarginSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
