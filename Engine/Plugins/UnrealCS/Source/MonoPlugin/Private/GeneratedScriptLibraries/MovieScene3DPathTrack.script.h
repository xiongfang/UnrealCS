#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DPathTrack
	{
		static UClass* StaticClass(){return UMovieScene3DPathTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DPathTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
