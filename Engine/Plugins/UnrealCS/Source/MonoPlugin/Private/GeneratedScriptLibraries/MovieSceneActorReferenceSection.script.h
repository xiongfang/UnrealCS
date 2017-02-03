#pragma once

namespace UnrealEngine
{
	class _UMovieSceneActorReferenceSection
	{
		static UClass* StaticClass(){return UMovieSceneActorReferenceSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneActorReferenceSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
