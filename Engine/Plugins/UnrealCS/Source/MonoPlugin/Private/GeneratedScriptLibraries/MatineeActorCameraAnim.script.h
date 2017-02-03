#pragma once

namespace UnrealEngine
{
	class _AMatineeActorCameraAnim
	{
		static UClass* StaticClass(){return AMatineeActorCameraAnim::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMatineeActorCameraAnim::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
