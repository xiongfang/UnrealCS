#pragma once

namespace UnrealEngine
{
	class _USlateWidgetStyleAsset
	{
		static UClass* StaticClass(){return USlateWidgetStyleAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateWidgetStyleAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
