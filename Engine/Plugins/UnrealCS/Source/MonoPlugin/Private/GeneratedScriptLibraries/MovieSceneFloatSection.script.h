#pragma once

namespace UnrealEngine
{
	class _UMovieSceneFloatSection
	{
		static UClass* StaticClass(){return UMovieSceneFloatSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneFloatSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
