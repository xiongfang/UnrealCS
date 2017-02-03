#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSkeletalAnimationTrack
	{
		static UClass* StaticClass(){return UMovieSceneSkeletalAnimationTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSkeletalAnimationTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
