#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFunctionInput
	{
		static UClass* StaticClass(){return UMaterialExpressionFunctionInput::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFunctionInput::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
