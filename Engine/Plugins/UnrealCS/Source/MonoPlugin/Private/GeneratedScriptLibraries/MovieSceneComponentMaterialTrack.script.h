#pragma once

namespace UnrealEngine
{
	class _UMovieSceneComponentMaterialTrack
	{
		static UClass* StaticClass(){return UMovieSceneComponentMaterialTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneComponentMaterialTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
