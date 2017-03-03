#pragma once

namespace UnrealEngine
{
	class _UPolys
	{
		static UClass* StaticClass(){return UPolys::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPolys::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
