#pragma once

namespace UnrealEngine
{
	class _UNetworkPredictionInterface
	{
		static UClass* StaticClass(){return UNetworkPredictionInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNetworkPredictionInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
