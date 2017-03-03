#pragma once

namespace UnrealEngine
{
	class _UPhysicsConstraintTemplate
	{
		static UClass* StaticClass(){return UPhysicsConstraintTemplate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsConstraintTemplate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
