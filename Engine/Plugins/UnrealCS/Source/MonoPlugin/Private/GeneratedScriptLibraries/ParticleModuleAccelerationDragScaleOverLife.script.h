#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAccelerationDragScaleOverLife
	{
		static UClass* StaticClass(){return UParticleModuleAccelerationDragScaleOverLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAccelerationDragScaleOverLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
