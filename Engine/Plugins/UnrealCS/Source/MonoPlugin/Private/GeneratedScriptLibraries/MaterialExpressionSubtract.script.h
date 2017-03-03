#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionSubtract
	{
		static UClass* StaticClass(){return UMaterialExpressionSubtract::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionSubtract::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
