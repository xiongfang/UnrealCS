#pragma once

namespace UnrealEngine
{
	class _URichTextBlock
	{
		static UClass* StaticClass(){return URichTextBlock::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URichTextBlock::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
