#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionConstant3Vector
	{
		static UClass* StaticClass(){return UMaterialExpressionConstant3Vector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionConstant3Vector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
