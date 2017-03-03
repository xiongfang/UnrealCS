#pragma once

namespace UnrealEngine
{
	class _USoundNodeEnveloper
	{
		static UClass* StaticClass(){return USoundNodeEnveloper::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeEnveloper::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
