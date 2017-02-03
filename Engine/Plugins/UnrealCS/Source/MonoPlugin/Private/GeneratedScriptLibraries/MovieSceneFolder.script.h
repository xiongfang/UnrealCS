#pragma once

namespace UnrealEngine
{
	class _UMovieSceneFolder
	{
		static UClass* StaticClass(){return UMovieSceneFolder::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneFolder::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
