#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DPathSection
	{
		static UClass* StaticClass(){return UMovieScene3DPathSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DPathSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
