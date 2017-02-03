#pragma once

namespace UnrealEngine
{
	class _UPhysicsCollisionHandler
	{
		static UClass* StaticClass(){return UPhysicsCollisionHandler::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsCollisionHandler::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
