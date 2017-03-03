#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionSetMaterialAttributes
	{
		static UClass* StaticClass(){return UMaterialExpressionSetMaterialAttributes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionSetMaterialAttributes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
