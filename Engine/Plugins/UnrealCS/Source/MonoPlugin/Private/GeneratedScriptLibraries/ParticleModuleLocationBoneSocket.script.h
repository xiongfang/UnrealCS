#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationBoneSocket
	{
		static UClass* StaticClass(){return UParticleModuleLocationBoneSocket::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationBoneSocket::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
