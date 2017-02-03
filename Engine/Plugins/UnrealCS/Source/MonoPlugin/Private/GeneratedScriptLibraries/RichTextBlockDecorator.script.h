#pragma once

namespace UnrealEngine
{
	class _URichTextBlockDecorator
	{
		static UClass* StaticClass(){return URichTextBlockDecorator::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URichTextBlockDecorator::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
