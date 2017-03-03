#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DTransformSection
	{
		static UClass* StaticClass(){return UMovieScene3DTransformSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DTransformSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
