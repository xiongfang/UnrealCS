#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTwoSidedSign
	{
		static UClass* StaticClass(){return UMaterialExpressionTwoSidedSign::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTwoSidedSign::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
