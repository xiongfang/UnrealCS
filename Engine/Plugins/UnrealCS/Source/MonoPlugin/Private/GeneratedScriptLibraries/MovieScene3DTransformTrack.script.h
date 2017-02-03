#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DTransformTrack
	{
		static UClass* StaticClass(){return UMovieScene3DTransformTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DTransformTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
