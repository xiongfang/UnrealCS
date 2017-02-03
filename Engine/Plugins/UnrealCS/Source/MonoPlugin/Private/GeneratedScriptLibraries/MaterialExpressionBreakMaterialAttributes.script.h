#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionBreakMaterialAttributes
	{
		static UClass* StaticClass(){return UMaterialExpressionBreakMaterialAttributes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionBreakMaterialAttributes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
