#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionGetMaterialAttributes
	{
		static UClass* StaticClass(){return UMaterialExpressionGetMaterialAttributes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionGetMaterialAttributes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
