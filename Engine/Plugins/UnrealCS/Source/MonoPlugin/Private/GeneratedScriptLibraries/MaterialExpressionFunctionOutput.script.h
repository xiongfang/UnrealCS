#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFunctionOutput
	{
		static UClass* StaticClass(){return UMaterialExpressionFunctionOutput::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFunctionOutput::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
