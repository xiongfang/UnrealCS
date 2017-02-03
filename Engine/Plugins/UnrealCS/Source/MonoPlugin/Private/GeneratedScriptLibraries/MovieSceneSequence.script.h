#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSequence
	{
		static UClass* StaticClass(){return UMovieSceneSequence::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSequence::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
