#pragma once

namespace UnrealEngine
{
	class _UMovieSceneEventSection
	{
		static UClass* StaticClass(){return UMovieSceneEventSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneEventSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
