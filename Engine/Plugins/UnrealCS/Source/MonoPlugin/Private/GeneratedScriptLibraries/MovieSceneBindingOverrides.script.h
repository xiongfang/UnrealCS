#pragma once

namespace UnrealEngine
{
	class _UMovieSceneBindingOverrides
	{
		static UClass* StaticClass(){return UMovieSceneBindingOverrides::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneBindingOverrides::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
