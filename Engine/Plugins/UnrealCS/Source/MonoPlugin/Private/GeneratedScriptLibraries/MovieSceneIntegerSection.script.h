#pragma once

namespace UnrealEngine
{
	class _UMovieSceneIntegerSection
	{
		static UClass* StaticClass(){return UMovieSceneIntegerSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneIntegerSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
