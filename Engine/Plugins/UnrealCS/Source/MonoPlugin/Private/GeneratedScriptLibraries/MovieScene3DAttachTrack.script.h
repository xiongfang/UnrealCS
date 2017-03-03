#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DAttachTrack
	{
		static UClass* StaticClass(){return UMovieScene3DAttachTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DAttachTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
