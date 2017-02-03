#pragma once

namespace UnrealEngine
{
	class _UCollisionProfile
	{
		static UClass* StaticClass(){return UCollisionProfile::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCollisionProfile::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
