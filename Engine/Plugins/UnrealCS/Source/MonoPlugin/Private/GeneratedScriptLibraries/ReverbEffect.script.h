#pragma once

namespace UnrealEngine
{
	class _UReverbEffect
	{
		static UClass* StaticClass(){return UReverbEffect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UReverbEffect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
