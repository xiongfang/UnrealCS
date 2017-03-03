#pragma once

namespace UnrealEngine
{
	class _UCameraModifier_CameraShake
	{
		static UClass* StaticClass(){return UCameraModifier_CameraShake::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraModifier_CameraShake::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
