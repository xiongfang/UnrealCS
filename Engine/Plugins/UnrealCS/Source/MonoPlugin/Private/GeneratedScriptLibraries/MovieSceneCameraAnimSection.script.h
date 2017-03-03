#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraAnimSection
	{
		static UClass* StaticClass(){return UMovieSceneCameraAnimSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraAnimSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
