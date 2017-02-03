#pragma once

namespace UnrealEngine
{
	class _USkeletalMeshReductionSettings
	{
		static UClass* StaticClass(){return USkeletalMeshReductionSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeletalMeshReductionSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
