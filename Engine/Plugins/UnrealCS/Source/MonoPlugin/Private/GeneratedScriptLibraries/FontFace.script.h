#pragma once

namespace UnrealEngine
{
	class _UFontFace
	{
		static UClass* StaticClass(){return UFontFace::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFontFace::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
