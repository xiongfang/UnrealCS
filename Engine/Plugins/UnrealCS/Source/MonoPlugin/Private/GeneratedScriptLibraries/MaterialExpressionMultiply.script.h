#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionMultiply
	{
		static UClass* StaticClass(){return UMaterialExpressionMultiply::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionMultiply::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
