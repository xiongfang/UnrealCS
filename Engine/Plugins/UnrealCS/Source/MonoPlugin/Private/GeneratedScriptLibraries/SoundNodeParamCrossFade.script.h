#pragma once

namespace UnrealEngine
{
	class _USoundNodeParamCrossFade
	{
		static UClass* StaticClass(){return USoundNodeParamCrossFade::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeParamCrossFade::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
