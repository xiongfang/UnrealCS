#pragma once

namespace UnrealEngine
{
	class _UMovieScene2DTransformTrack
	{
		static UClass* StaticClass(){return UMovieScene2DTransformTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene2DTransformTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
