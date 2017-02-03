#pragma once

namespace UnrealEngine
{
	class _UDataAsset
	{
		static UClass* StaticClass(){return UDataAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDataAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
