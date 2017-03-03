#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionConstant4Vector
	{
		static UClass* StaticClass(){return UMaterialExpressionConstant4Vector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionConstant4Vector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
