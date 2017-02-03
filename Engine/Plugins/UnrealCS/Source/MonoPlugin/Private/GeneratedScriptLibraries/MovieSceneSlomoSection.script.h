#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSlomoSection
	{
		static UClass* StaticClass(){return UMovieSceneSlomoSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSlomoSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
