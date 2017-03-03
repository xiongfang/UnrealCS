#pragma once

namespace UnrealEngine
{
	class _AMaterialInstanceActor
	{
		static UClass* StaticClass(){return AMaterialInstanceActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMaterialInstanceActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
