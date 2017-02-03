#pragma once

namespace UnrealEngine
{
	class _UParticleLODLevel
	{
		static UClass* StaticClass(){return UParticleLODLevel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleLODLevel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
