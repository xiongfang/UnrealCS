#pragma once

namespace UnrealEngine
{
	class _UTextLayoutWidget
	{
		static UClass* StaticClass(){return UTextLayoutWidget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextLayoutWidget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
