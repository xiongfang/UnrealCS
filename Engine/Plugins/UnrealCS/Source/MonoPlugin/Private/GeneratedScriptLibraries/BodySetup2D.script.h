#pragma once

namespace UnrealEngine
{
	class _UBodySetup2D
	{
		static UClass* StaticClass(){return UBodySetup2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBodySetup2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
