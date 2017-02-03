#pragma once

namespace UnrealEngine
{
	class _UMovieScene
	{
		static UClass* StaticClass(){return UMovieScene::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
