#pragma once

namespace UnrealEngine
{
	class _USoundNodeMature
	{
		static UClass* StaticClass(){return USoundNodeMature::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeMature::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
