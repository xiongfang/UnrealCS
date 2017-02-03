#pragma once

namespace UnrealEngine
{
	class _UMovieSceneParameterSection
	{
		static UClass* StaticClass(){return UMovieSceneParameterSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneParameterSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
