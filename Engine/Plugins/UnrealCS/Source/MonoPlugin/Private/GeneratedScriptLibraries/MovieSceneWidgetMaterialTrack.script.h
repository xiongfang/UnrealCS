#pragma once

namespace UnrealEngine
{
	class _UMovieSceneWidgetMaterialTrack
	{
		static UClass* StaticClass(){return UMovieSceneWidgetMaterialTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneWidgetMaterialTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
