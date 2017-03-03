#pragma once

namespace UnrealEngine
{
	class _UMovieSceneCameraCutTrack
	{
		static UClass* StaticClass(){return UMovieSceneCameraCutTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneCameraCutTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
