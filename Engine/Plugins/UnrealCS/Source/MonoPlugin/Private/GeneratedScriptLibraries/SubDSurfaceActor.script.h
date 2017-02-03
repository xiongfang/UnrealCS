#pragma once

namespace UnrealEngine
{
	class _ASubDSurfaceActor
	{
		static UClass* StaticClass(){return ASubDSurfaceActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASubDSurfaceActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
