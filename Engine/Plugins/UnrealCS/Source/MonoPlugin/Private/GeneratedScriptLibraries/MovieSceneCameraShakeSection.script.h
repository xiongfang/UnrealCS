#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraShakeSection
	{
		static UClass* StaticClass(){return UMovieSceneCameraShakeSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraShakeSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
