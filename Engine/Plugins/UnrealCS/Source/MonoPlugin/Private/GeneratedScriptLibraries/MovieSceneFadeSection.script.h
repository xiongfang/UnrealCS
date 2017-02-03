#pragma once

namespace UnrealEngine
{
	class _UMovieSceneFadeSection
	{
		static UClass* StaticClass(){return UMovieSceneFadeSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneFadeSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
