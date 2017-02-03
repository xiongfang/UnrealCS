#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionLogarithm2
	{
		static UClass* StaticClass(){return UMaterialExpressionLogarithm2::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionLogarithm2::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
