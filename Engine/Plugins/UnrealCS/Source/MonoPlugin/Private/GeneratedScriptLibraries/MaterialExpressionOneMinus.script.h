#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionOneMinus
	{
		static UClass* StaticClass(){return UMaterialExpressionOneMinus::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionOneMinus::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
