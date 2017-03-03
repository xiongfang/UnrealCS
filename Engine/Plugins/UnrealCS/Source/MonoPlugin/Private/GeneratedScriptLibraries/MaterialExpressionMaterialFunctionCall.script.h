#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionMaterialFunctionCall
	{
		static UClass* StaticClass(){return UMaterialExpressionMaterialFunctionCall::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionMaterialFunctionCall::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
