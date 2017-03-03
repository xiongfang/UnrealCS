#pragma once

namespace UnrealEngine
{
	class _UNavAreaMeta_SwitchByAgent
	{
		static UClass* StaticClass(){return UNavAreaMeta_SwitchByAgent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavAreaMeta_SwitchByAgent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
