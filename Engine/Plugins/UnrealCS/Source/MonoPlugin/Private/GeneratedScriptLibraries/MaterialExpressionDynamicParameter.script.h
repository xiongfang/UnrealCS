#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionDynamicParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionDynamicParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionDynamicParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
