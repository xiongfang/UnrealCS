#pragma once

namespace UnrealEngine
{
	class _UMovieSceneVisibilitySection
	{
		static UClass* StaticClass(){return UMovieSceneVisibilitySection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneVisibilitySection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
