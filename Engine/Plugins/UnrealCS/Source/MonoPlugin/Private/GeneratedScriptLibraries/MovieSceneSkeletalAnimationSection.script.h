#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSkeletalAnimationSection
	{
		static UClass* StaticClass(){return UMovieSceneSkeletalAnimationSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSkeletalAnimationSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
