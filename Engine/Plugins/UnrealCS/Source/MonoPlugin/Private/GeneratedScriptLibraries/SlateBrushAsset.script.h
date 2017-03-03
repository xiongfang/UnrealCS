#pragma once

namespace UnrealEngine
{
	class _USlateBrushAsset
	{
		static UClass* StaticClass(){return USlateBrushAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateBrushAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
