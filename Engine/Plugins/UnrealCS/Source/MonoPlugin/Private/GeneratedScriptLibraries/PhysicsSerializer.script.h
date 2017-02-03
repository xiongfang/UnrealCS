#pragma once

namespace UnrealEngine
{
	class _UPhysicsSerializer
	{
		static UClass* StaticClass(){return UPhysicsSerializer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsSerializer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
