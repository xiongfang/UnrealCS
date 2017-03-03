#pragma once

namespace UnrealEngine
{
	class _UMovieSceneBindingOverridesInterface
	{
		static UClass* StaticClass(){return UMovieSceneBindingOverridesInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneBindingOverridesInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
