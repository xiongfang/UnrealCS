#pragma once

namespace UnrealEngine
{
	class _UBrushBuilder
	{
		static UClass* StaticClass(){return UBrushBuilder::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBrushBuilder::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
