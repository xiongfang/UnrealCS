#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionConstant2Vector
	{
		static UClass* StaticClass(){return UMaterialExpressionConstant2Vector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionConstant2Vector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
