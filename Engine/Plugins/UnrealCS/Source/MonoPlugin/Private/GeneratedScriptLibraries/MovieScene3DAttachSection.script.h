#pragma once

namespace UnrealEngine
{
	class _UMovieScene3DAttachSection
	{
		static UClass* StaticClass(){return UMovieScene3DAttachSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieScene3DAttachSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
