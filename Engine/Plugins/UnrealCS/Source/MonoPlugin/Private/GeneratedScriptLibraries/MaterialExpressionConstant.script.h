#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionConstant
	{
		static UClass* StaticClass(){return UMaterialExpressionConstant::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionConstant::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
