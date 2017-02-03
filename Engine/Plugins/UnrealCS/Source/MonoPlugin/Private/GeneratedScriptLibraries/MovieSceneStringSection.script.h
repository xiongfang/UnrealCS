#pragma once

namespace UnrealEngine
{
	class _UMovieSceneStringSection
	{
		static UClass* StaticClass(){return UMovieSceneStringSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneStringSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
