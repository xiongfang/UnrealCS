#pragma once

namespace UnrealEngine
{
	class _UCheckBoxStyleAsset
	{
		static UClass* StaticClass(){return UCheckBoxStyleAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCheckBoxStyleAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
