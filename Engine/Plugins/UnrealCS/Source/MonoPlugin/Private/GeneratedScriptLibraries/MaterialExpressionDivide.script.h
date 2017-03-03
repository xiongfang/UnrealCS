#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionDivide
	{
		static UClass* StaticClass(){return UMaterialExpressionDivide::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionDivide::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
