#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveTriangle
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveTriangle::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveTriangle::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
