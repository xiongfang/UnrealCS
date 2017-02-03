#pragma once

namespace UnrealEngine
{
	class _USoundNodeGroupControl
	{
		static UClass* StaticClass(){return USoundNodeGroupControl::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeGroupControl::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
