#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DConstraintSection
	{
		static UClass* StaticClass(){return UMovieScene3DConstraintSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DConstraintSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
