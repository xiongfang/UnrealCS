#pragma once

namespace UnrealEngine
{
	class _UCameraShake
	{
		static UClass* StaticClass(){return UCameraShake::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraShake::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
