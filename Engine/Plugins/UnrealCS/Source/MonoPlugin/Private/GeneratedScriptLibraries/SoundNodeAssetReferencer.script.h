#pragma once

namespace UnrealEngine
{
	class _USoundNodeAssetReferencer
	{
		static UClass* StaticClass(){return USoundNodeAssetReferencer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeAssetReferencer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
