#pragma once

namespace UnrealEngine
{
	class _AEmitterCameraLensEffectBase
	{
		static UClass* StaticClass(){return AEmitterCameraLensEffectBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AEmitterCameraLensEffectBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
