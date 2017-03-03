#pragma once

namespace UnrealEngine
{
	class _UMovieSceneBoolSection
	{
		static UClass* StaticClass(){return UMovieSceneBoolSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneBoolSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
