#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSection
	{
		static UClass* StaticClass(){return UMovieSceneSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
