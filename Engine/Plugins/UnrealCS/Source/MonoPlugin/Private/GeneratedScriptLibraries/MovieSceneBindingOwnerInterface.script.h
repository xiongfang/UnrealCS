#pragma once

namespace UnrealEngine
{
	class _UMovieSceneBindingOwnerInterface
	{
		static UClass* StaticClass(){return UMovieSceneBindingOwnerInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneBindingOwnerInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
