#pragma once

namespace UnrealEngine
{
	class _USubDSurface
	{
		static UClass* StaticClass(){return USubDSurface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USubDSurface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
