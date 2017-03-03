#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraCutSection
	{
		static UClass* StaticClass(){return UMovieSceneCameraCutSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraCutSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
