#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionCustomOutput
	{
		static UClass* StaticClass(){return UMaterialExpressionCustomOutput::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionCustomOutput::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
