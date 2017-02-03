#pragma once

namespace UnrealEngine
{
	class _UMovieSceneLevelVisibilitySection
	{
		static UClass* StaticClass(){return UMovieSceneLevelVisibilitySection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneLevelVisibilitySection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
