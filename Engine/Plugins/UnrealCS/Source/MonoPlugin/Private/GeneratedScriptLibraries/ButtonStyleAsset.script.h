#pragma once

namespace UnrealEngine
{
	class _UButtonStyleAsset
	{
		static UClass* StaticClass(){return UButtonStyleAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UButtonStyleAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
