#pragma once

namespace UnrealEngine
{
	class _USkeletalBodySetup
	{
		static UClass* StaticClass(){return USkeletalBodySetup::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeletalBodySetup::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
