#pragma once

namespace UnrealEngine
{
	class _UListView
	{
		static UClass* StaticClass(){return UListView::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UListView::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
