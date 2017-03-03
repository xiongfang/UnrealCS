#pragma once

namespace UnrealEngine
{
	class _UMovieSceneActorReferenceTrack
	{
		static UClass* StaticClass(){return UMovieSceneActorReferenceTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneActorReferenceTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
