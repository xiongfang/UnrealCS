#pragma once

namespace UnrealEngine
{
	class _UMovieSceneByteSection
	{
		static UClass* StaticClass(){return UMovieSceneByteSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneByteSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
