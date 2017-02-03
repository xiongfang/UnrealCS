#pragma once

namespace UnrealEngine
{
	class _UMovieSceneAudioSection
	{
		static UClass* StaticClass(){return UMovieSceneAudioSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneAudioSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
