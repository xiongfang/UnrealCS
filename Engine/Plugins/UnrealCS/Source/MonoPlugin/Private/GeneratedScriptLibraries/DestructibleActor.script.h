#pragma once

namespace UnrealEngine
{
	class _ADestructibleActor
	{
		static UClass* StaticClass(){return ADestructibleActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADestructibleActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
