#pragma once

namespace UnrealEngine
{
	class _UMovieScene2DTransformSection
	{
		static UClass* StaticClass(){return UMovieScene2DTransformSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene2DTransformSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
