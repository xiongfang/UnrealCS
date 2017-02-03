#pragma once

namespace UnrealEngine
{
	class _UComboBox
	{
		static UClass* StaticClass(){return UComboBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UComboBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
