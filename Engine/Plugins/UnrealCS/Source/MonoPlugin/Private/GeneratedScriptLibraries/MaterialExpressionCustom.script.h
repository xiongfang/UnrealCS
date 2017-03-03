#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionCustom
	{
		static UClass* StaticClass(){return UMaterialExpressionCustom::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionCustom::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
