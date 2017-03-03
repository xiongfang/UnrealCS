#pragma once

namespace UnrealEngine
{
	class _UMovieSceneEnumSection
	{
		static UClass* StaticClass(){return UMovieSceneEnumSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneEnumSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
