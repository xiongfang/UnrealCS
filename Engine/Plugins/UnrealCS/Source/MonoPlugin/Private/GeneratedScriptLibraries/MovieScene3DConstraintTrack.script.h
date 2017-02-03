#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DConstraintTrack
	{
		static UClass* StaticClass(){return UMovieScene3DConstraintTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DConstraintTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
