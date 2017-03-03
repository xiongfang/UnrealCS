#pragma once

namespace UnrealEngine
{
	class _UWidgetTree
	{
		static UClass* StaticClass(){return UWidgetTree::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetTree::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
