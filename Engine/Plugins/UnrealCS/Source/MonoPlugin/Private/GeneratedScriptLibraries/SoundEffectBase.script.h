#pragma once

namespace UnrealEngine
{
	class _USoundEffectBase
	{
		static UClass* StaticClass(){return USoundEffectBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
