#pragma once

namespace UnrealEngine
{
	class _UMovieSceneVectorSection
	{
		static UClass* StaticClass(){return UMovieSceneVectorSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneVectorSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
