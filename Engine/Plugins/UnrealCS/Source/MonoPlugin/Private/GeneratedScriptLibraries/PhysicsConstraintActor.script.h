#pragma once

namespace UnrealEngine
{
	class _APhysicsConstraintActor
	{
		static UClass* StaticClass(){return APhysicsConstraintActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APhysicsConstraintActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
