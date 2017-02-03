#pragma once

namespace UnrealEngine
{
	class _ARigidBodyBase
	{
		static UClass* StaticClass(){return ARigidBodyBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ARigidBodyBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
